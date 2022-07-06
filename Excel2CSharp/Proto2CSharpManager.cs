using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Excel2CSharp
{
    public class Proto2CSharpManager : SafeSingleton<Proto2CSharpManager>
    {
        private List<string> _protoFiles;
        private float _processByteFileCount = 0;
        private int _allByteFileCount = 0;
        private Assembly _csAssembly;

        public void Init ()
        {
            RefreshProteFiles ();
            CreateOverViewProtoFile ();
            RefreshProteFiles ();
            Proto2HotCSharp ();
            Proto2Csharp ();
        }

        /// <summary>
        /// Proto转化为CSharp代码
        /// </summary>
        private void Proto2Csharp ()
        {
            ExcelUtil.DelectDir (Program.csharpPath);
            //检查CS文件导出目录是否存在，不存在则创建
            if ( !Directory.Exists (Program.csharpPath) )
            {
                Directory.CreateDirectory (Program.csharpPath);
            }

            var set = new Google.Protobuf.Reflection.FileDescriptorSet ();
            set.AddImportPath (Program.protoFilePath);

            //添加每个proto文件的名称
            foreach ( var file in _protoFiles )
            {
                var strArr = file.Split ('\\');
                var fileName = strArr [^1];
                set.Add (fileName , true);
            }
            set.Process ();

            var files = ProtoBuf.Reflection.CSharpCodeGenerator.Default.Generate (set , null , new Dictionary<string , string> (StringComparer.OrdinalIgnoreCase));
            string [] contents = new string [files.Count ()];
            var index = 0;
            //导出每一个CS文件
            foreach ( var file in files )
            {
                var path = Path.Combine (Program.csharpPath , file.Name);
                File.WriteAllText (path , file.Text);
                contents [index++] = file.Text;
            }
            _csAssembly = ExcelUtil.GenerateAssemblyFromCode (contents);
            ExportProtoData (ExcelConst.EXCEL_2_PROTOBUF_SCRIPT_NAMESPACE_1 , ExcelConst.ALL_CONFIG_HOT_CLASS_NAME , true);
        }

        /// <summary>
        /// 导出热更使用的CSharp代码
        /// </summary>
        private void Proto2HotCSharp ()
        {
            ExcelUtil.DelectDir (Program.hotCsharpPath);
            Directory.CreateDirectory (Program.hotCsharpPath);

            var set = new ProtoBuf.Reflection.ILRuntime.FileDescriptorSet ();
            set.AddImportPath (Program.protoFilePath);

            //添加每个proto文件的名称
            foreach ( var file in _protoFiles )
            {
                var strArr = file.Split ('\\');
                var fileName = strArr [strArr.Length - 1];
                set.Add (fileName , true);
            }

            set.Process ();
            ProtoBuf.Reflection.ILRuntime.CSharpCodeGenerator.ClearTypeNames ();
            var files = ProtoBuf.Reflection.ILRuntime.CSharpCodeGenerator.Default.Generate (set);

            //导出每一个CS文件
            foreach ( var file in files )
            {
                var path = Path.Combine (Program.hotCsharpPath , file.Name);
                File.WriteAllText (path , file.Text);
                ProtoBuf.Reflection.ILRuntime.CSharpCodeGenerator.ClearTypeNames ();
            }
        }

        private void ExportProtoData (string nameSpace , string allConfigClassName , bool isCreateMds = false)
        {
            //获取配置总表的类型
            Type allConfigType = _csAssembly.GetType ($"{nameSpace}.{allConfigClassName}");
            if ( allConfigType == null )
            {
                throw new Exception ($"not find allConfigType");
            }

            //接着实例化这个类型
            object allConfigObj = Activator.CreateInstance (allConfigType);
            //获取这个类型的属性集合
            PropertyInfo [] propertyInfos = allConfigType.GetProperties ();
            _processByteFileCount = 0;
            _allByteFileCount = propertyInfos.Length;


            for ( int i = 0 ; i < propertyInfos.Length ; i++ )
            {
                var propertyInfo = propertyInfos [i];
                ProcessByteFile (propertyInfo , allConfigObj);
            }
        }

        /// <summary>
        /// 处理二进制文件
        /// </summary>
        /// <param name="propertyInfo"></param>
        /// <param name="allConfigObj"></param>
        private void ProcessByteFile (PropertyInfo propertyInfo , object allConfigObj)
        {
            //检查是否是需要赋值的属性
            if ( propertyInfo.Name.EndsWith (ExcelConst.CONFIG_DATA_MESSAGE_END_NAME) )
            {
                object excelData = null;

                //根据属性名获取到类名
                var className = ExcelUtil.ToUpperFirst (propertyInfo.Name.Replace (ExcelConst.CONFIG_DATA_MESSAGE_END_NAME , ""));

                ConfigScriptCacheDataVo vo = new ConfigScriptCacheDataVo ();
                if ( Program.FindConfigScriptCacheDataVo (className , ref vo) )
                {
                    excelData = GetExcelData (className , vo.worksheet , vo.excelColCount , vo.excelRowCount);
                }
                else
                {
                    throw new Exception ($"无法找到ConfigScriptCacheDataVo，ClassName:{className}");
                }

                if ( excelData == null )
                {
                    ConsoleHelper.Ins.WriteWarningLine ($"跳过了一个空数据,属性名{propertyInfo.Name}");
                }
                else
                {
                    ExportByteFile (excelData , propertyInfo.Name + ".bytes");
                    //给汇总对象赋值，将用于生成汇总二进制文件
                    propertyInfo.SetValue (allConfigObj , excelData);
                }
                _processByteFileCount++;
            }
        }

        /// <summary>
        /// 导出二进制文件
        /// </summary>
        /// <param name="data"></param>
        /// <param name="fileName"></param>
        private void ExportByteFile (object data , string fileName)
        {
            using ( MemoryStream ms = new MemoryStream () )
            {
                ProtoBuf.Serializer.Serialize (ms , data);
                FileStream fs = File.Create (Path.Combine (Program.byteFilePath , fileName));
                BinaryWriter bw = new BinaryWriter (fs);
                bw.Write (ms.ToArray ());
                bw.Close ();
                fs.Close ();
            }
        }

        /// <summary>
        /// 获取配置表数据
        /// </summary>
        /// <param name="className"></param>
        /// <param name="sheet"></param>
        /// <returns></returns>
        private object GetExcelData (string className , DataTable sheet , int col , int row)
        {
            if ( sheet == null )
            {
                throw new Exception ($"{className}的sheet对象为空,返回空数据");
            }

            //获取命名空间
            var nameSpace = ExcelConst.EXCEL_2_PROTOBUF_SCRIPT_NAMESPACE_1;

            //获取这个配置数据结构（只包含值对象的实例）定义类型
            Type configVoType = _csAssembly.GetType ($"{nameSpace}.{className}{ExcelConst.CONFIG_VALUEOBJECT_MESSAGE_END_NAME}");

            //获取这个配置数据定义类型
            Type configDataType = _csAssembly.GetType ($"{nameSpace}.{className}{ExcelConst.CONFIG_DATA_MESSAGE_END_NAME}");

            if ( configVoType == null || configDataType == null )
            {
                ConsoleHelper.Ins.WriteWarningLine ($"类{className}找不到类型，详细信息为->configVoType：{configVoType}，configData：{configDataType}");
                return null;
            }

            //获取这个配置数据类型的定义字段
            PropertyInfo propertyInfo = configDataType.GetProperty ($"{ExcelConst.CONFIG_DATA_VARIABLE_NAME}");

            if ( propertyInfo == null )
            {
                ConsoleHelper.Ins.WriteWarningLine ($"类{className}找不到无法获取字段{ExcelConst.CONFIG_DATA_VARIABLE_NAME}");
                return null;
            }

            //获取配置值对象的包含的属性集合
            PropertyInfo [] configVoProps = configVoType.GetProperties (BindingFlags.Public | BindingFlags.Instance | BindingFlags.SetField);

            //实例化类型
            object configDataObj = Activator.CreateInstance (configDataType);

            //获取字段值
            IList dataList = propertyInfo.GetValue (configDataObj) as IList;

            //遍历配置表的行
            for ( int i = 0 ; i < row ; i++ )
            {
                //从第4行起才是数据内容
                if ( i > 2 )
                {
                    //创建一个新的数据实例
                    object configVo = Activator.CreateInstance (configVoType);

                    //遇到无效的行就跳出
                    if ( col > 0 )
                    {
                        if ( string.IsNullOrEmpty (sheet.Rows [i] [0].GetString ()) )
                        {
                            break;
                        }
                    }

                    //遍历配置表的列
                    for ( int j = 0, propIndex = 0 ; j < col ; j++ )
                    {
                        //如果这列为空
                        if ( ExcelOverViewTableManager.Ins.CheckExcelColIsNull (sheet , j) )
                        {
                            //如果下一列也为空，直接跳出
                            var next = j + 1;
                            if ( next < col )
                            {
                                if ( ExcelOverViewTableManager.Ins.CheckExcelColIsNull (sheet , next) )
                                {
                                    break;
                                }
                            }
                            else
                            {
                                break;
                            }
                        }

                        if ( ExcelOverViewTableManager.Ins.CheckExcelColIsCanFilter (sheet , j) )
                        {
                            ConsoleHelper.Ins.WriteWarningLine ($"过滤掉一列数据，表{sheet.TableName},类名{className},列数为{j}");
                            continue;
                        }

                        //单元格原始数据
                        object cellValue;
                        try
                        {
                            cellValue = sheet.Rows [i] [j];
                        }
                        catch ( Exception e )
                        {
                            throw new Exception ($"读取数据出错了，类{className},行数为{i},列数为{j},值:{sheet.GetString ()}详细信息为{e}");
                        }

                        if ( propIndex >= configVoProps.Length )
                        {
                            throw new Exception ($"类{className}的属性集合数量与配置表的字段数量不匹配，一般重新导出可以解决");
                        }

                        var propInfo = configVoProps [propIndex];

                        //这是一个集合类型
                        if ( propInfo.PropertyType.GetInterface ("ICollection" , false) != null )
                        {
                            //类型码
                            TypeCode typeCode = TypeCode.Empty;
                            //数组类型
                            Type arrayType = null;

                            //如果是泛型，获取泛型参数
                            if ( propInfo.PropertyType.IsGenericType )
                            {
                                if ( propInfo.PropertyType.GetGenericArguments ().Length != 0 )
                                {
                                    typeCode = Type.GetTypeCode (propInfo.PropertyType.GetGenericArguments () [0]);
                                }
                                else
                                {
                                    throw new Exception ($"泛型参数长度为0，表名称: {sheet.TableName}\t属性名称:{propInfo.Name}\t类名称:{className}\t行数{i}\t列数{j}");
                                }
                            }
                            else
                            {
                                //如果是数组
                                if ( propInfo.PropertyType.IsArray )
                                {
                                    var typeName = propInfo.PropertyType.FullName.Replace ("[]" , "");
                                    arrayType = propInfo.PropertyType.Assembly.GetType (typeName);
                                    typeCode = Type.GetTypeCode (arrayType);
                                }
                                else
                                {
                                    throw new Exception ($"导出未知错误，表名称: {sheet.TableName}\t属性名称:{propInfo.Name}\t类名称:{className}\t行数{i}\t列数{j}");
                                }
                            }

                            string [] arr;
                            string arrContent = cellValue.GetString ();
                            if ( string.IsNullOrEmpty (arrContent) || arrContent.Equals ("[]") )
                            {
                                arr = new string [0];
                            }
                            else
                            {
                                arrContent = arrContent.Replace ("[" , "");
                                arrContent = arrContent.Replace ("]" , "");
                                arr = arrContent.Split (',');
                            }

                            //如果是数组，需要为数组申请内存空间
                            if ( propInfo.PropertyType.IsArray )
                            {
                                var arrayval = Array.CreateInstance (arrayType , arr.Length);
                                for ( int index = 0 ; index < arr.Length ; index++ )
                                {
                                    switch ( typeCode )
                                    {
                                        case TypeCode.Int32:
                                            arrayval.SetValue (arr [index].GetInt () , index);
                                            break;

                                        case TypeCode.Int64:
                                            arrayval.SetValue (arr [index].GetLong () , index);
                                            break;

                                        case TypeCode.String:
                                            arrayval.SetValue (arr [index] , index);
                                            break;

                                        default:
                                            throw new Exception ($"未处理的类型{typeCode}");
                                    }
                                }
                                propInfo.SetValue (configVo , arrayval);
                            }
                            //List为动态分配
                            else
                            {
                                try
                                {
                                    IList list = propInfo.GetValue (configVo , null) as IList;
                                    foreach ( var item in arr )
                                    {
                                        switch ( typeCode )
                                        {
                                            case TypeCode.Int32:
                                                list.Add (item.GetInt ());
                                                break;

                                            case TypeCode.Single:
                                                list.Add (item.GetFloat ());
                                                break;

                                            case TypeCode.Int64:
                                                list.Add (item.GetLong ());
                                                break;

                                            case TypeCode.String:
                                                list.Add (item);
                                                break;

                                            default:
                                                throw new Exception ($"未处理的类型{typeCode}");
                                        }
                                    }
                                }
                                catch
                                {

                                }
                            }
                        }

                        //不是集合类型
                        else
                        {
                            var typeCode = Type.GetTypeCode (propInfo.PropertyType);
                            try
                            {
                                switch ( typeCode )
                                {
                                    case TypeCode.Int32:
                                        propInfo.SetValue (configVo , cellValue.GetInt ());
                                        break;

                                    case TypeCode.Int64:
                                        propInfo.SetValue (configVo , cellValue.GetLong ());
                                        break;

                                    case TypeCode.Single:
                                        propInfo.SetValue (configVo , cellValue.GetFloat ());
                                        break;

                                    case TypeCode.String:
                                        propInfo.SetValue (configVo , cellValue.GetString ());
                                        break;

                                    case TypeCode.Boolean:
                                        propInfo.SetValue (configVo , cellValue.GetBool ());
                                        break;

                                    default:
                                        throw new Exception ($"未处理的类型{typeCode}");
                                }
                            }
                            catch ( Exception e )
                            {
                                throw new Exception ($"导出未知错误，表名称: {sheet.TableName}\t类名称:{className}\t属性名称:{propInfo.Name}\t行数{i}\t值{cellValue}\n详细信息：{e}");
                            }
                        }
                        propIndex++;
                    }

                    dataList.Add (configVo);
                }
            }

            return configDataObj;
        }

        /// <summary>
        /// 刷新proto文件组
        /// </summary>
        public void RefreshProteFiles ()
        {
            if ( !string.IsNullOrEmpty (Program.protoFilePath) )
            {
                _protoFiles = Directory.GetFiles (Program.protoFilePath , "*.proto" , SearchOption.AllDirectories).ToList ();
            }

            //将汇总文件放到尾部
            var totalFileName = _protoFiles.FirstOrDefault (x => x.Equals (Path.Combine (Program.protoFilePath , ExcelConst.ALL_CONFIG_HOT_PROTO_NAME)));
            if ( totalFileName != null )
            {
                _protoFiles.Remove (totalFileName);
                _protoFiles.Add (totalFileName);
            }
        }

        /// <summary>
        /// 创建proto汇总文件
        /// </summary>
        private void CreateOverViewProtoFile ()
        {
            //用于热更代码的字符串拼接器
            StringBuilder importPackageNameSb1 = new StringBuilder ();
            StringBuilder variableNameSb1 = new StringBuilder ();

            //读取出Proto汇总文件模板的内容
            string template = File.ReadAllText (Path.Combine (Program.configPath , "AllConfigProtoTemplate.txt"));

            //穷举所有的proto文件集合
            for ( int i = 0 ; i < _protoFiles.Count ; i++ )
            {
                var strArr = _protoFiles [i].Split ('\\');
                var fileName = strArr [strArr.Length - 1];

                //自身文件名称排除
                if ( fileName.Equals (ExcelConst.ALL_CONFIG_HOT_PROTO_NAME) )
                {
                    continue;
                }

                var tempStr = fileName.Replace (".proto" , "");
                var realFileName = ExcelUtil.UnderScore2UpperCamelNames (tempStr);
                var typeName = $"{realFileName}{ExcelConst.CONFIG_DATA_MESSAGE_END_NAME}";
                importPackageNameSb1.Append ($"import \"{fileName}\";\r\n");
                variableNameSb1.Append ($"\t{typeName} {ExcelUtil.ToLowerFirst (typeName)} = {( i + 1 )};\r\n");
            }

            //对模板进行内容替换
            template = template.Replace ("{0}" , ExcelConst.EXCEL_2_PROTOBUF_SCRIPT_NAMESPACE_1);
            template = template.Replace ("{1}" , importPackageNameSb1.ToString ());
            template = template.Replace ("{2}" , ExcelConst.ALL_CONFIG_HOT_CLASS_NAME);
            template = template.Replace ("{3}" , variableNameSb1.ToString ());
            //写入内容
            File.WriteAllText (Path.Combine (Program.protoFilePath , ExcelConst.ALL_CONFIG_HOT_PROTO_NAME) , template);
        }
    }
}