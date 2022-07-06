using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Excel2CSharp
{
    public class DataSetExchangeTool
    {
        /// <summary>
        /// 用于记录配置脚本字段的字典
        /// Key：类名
        /// Value: 脚本数据信息
        /// </summary>
        private readonly Dictionary<string , ConfigScriptCacheDataVo> _configScriptDataDict = new Dictionary<string , ConfigScriptCacheDataVo> ();
        private readonly Excel2DataSet _excel2DataSet;
        private readonly string _sourcefileName;

        public DataSetExchangeTool (string sourcefileName)
        {
            _sourcefileName = sourcefileName;
            _excel2DataSet = new Excel2DataSet (Program.excelDir , $"{sourcefileName}.xlsx"); //含中文的路径
            ExportProtoFile ();
        }

        /// <summary>
        /// 导出Proto文件
        /// </summary>
        public void ExportProtoFile ()
        {
            var tableCount = _excel2DataSet.GetTableCount ();
            var sheetList = ExcelOverViewTableManager.Ins.GetSheetList (_sourcefileName);

            for ( int tableIndex = 0 ; tableIndex < tableCount ; tableIndex++ )
            {
                var sheet = _excel2DataSet [tableIndex];
                var vo = sheetList.FirstOrDefault (x => x.sheetName.Equals (sheet.TableName));

                //表格无法索引时抛出异常
                if ( string.IsNullOrEmpty (vo.exportFileName) )
                {
                    ConsoleHelper.Ins.WriteWarningLine ($"跳过了一个格式不符合的配置表。源文件：{_sourcefileName}, 表格：{sheet.TableName}");
                    continue;
                }

                string fileName;
                string className;

                try
                {
                    fileName = vo.exportFileName;
                    className = ExcelUtil.UnderScore2UpperCamelNames (fileName);
                }
                catch ( Exception e )
                {
                    throw new Exception ($"导出报错：源文件：{_sourcefileName}, 表格：{vo.sheetName}，估计是导出总览表设置问题，详细信息：{e}");
                }

                int col = sheet.Columns.Count;
                int row = sheet.Rows.Count;

                //生成脚本文件所需的数据结构
                ConfigScriptCacheDataVo configScriptDataVo = new ConfigScriptCacheDataVo
                {
                    sourceFile = _sourcefileName ,
                    exportFileName = fileName ,
                    className = className ,
                    worksheet = sheet ,
                    excelColCount = col ,
                    excelRowCount = row
                };

                //将它缓存起来，其它地方需要用到这些数据
                _configScriptDataDict.Add (className , configScriptDataVo);

                //用于拼接文件内容
                StringBuilder sb = new StringBuilder ();

                //声明这是proto3的语法
                sb.Append ("syntax = \"proto3\";\n");

                //首行写入包声明
                sb.Append ($"package { ExcelConst.EXCEL_2_PROTOBUF_SCRIPT_NAMESPACE_1};\n\n");

                //写入消息名称
                sb.Append ($"message {className}{ExcelConst.CONFIG_VALUEOBJECT_MESSAGE_END_NAME}{{\n");

                List<string> tableFieldNames = new List<string> ();

                for ( int j = 0 ; j < col ; j++ )
                {
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
                        continue;
                    }

                    //获取变量名称
                    var variableName = sheet.Rows [2] [j].GetString ();

                    //获取描述
                    var desc = sheet.Rows [0] [j].GetString ();

                    //获取类型名称
                    var typeName = sheet.Rows [1] [j].GetString ();

                    //由于第一列比较特殊，这里手动替换第一列的内容
                    if ( j == 0 )
                    {
                        typeName = typeName.Replace ("type" , "int32");
                        desc = desc.Replace ("desc" , "唯一标识");
                        variableName = "id";
                    }

                    //去除描述里所有的换行符号
                    if ( !string.IsNullOrEmpty (desc) )
                    {
                        desc = desc.Replace ("\n" , "");
                    }

                    //写入变量
                    sb.Append ($"\t{ExcelUtil.GetTypeName (typeName)} {variableName} = {j + 1};");
                    //写入注释
                    sb.Append ($"\t\t//{desc}\n");

                    if ( tableFieldNames.Contains (variableName) )
                    {
                        throw new Exception ($"导出配置表过程遇到一个异常,{_sourcefileName}:{variableName}字段已存在，不能存在相同的配置表字段。配置表: {vo.sheetName}");
                    }

                    //记录这个字段
                    tableFieldNames.Add (variableName);
                }

                //结束
                sb.Append ("}\n\n");
                //写入消息名称
                sb.Append ($"message {className}{ExcelConst.CONFIG_DATA_MESSAGE_END_NAME}{{\n");
                //定义消息组
                sb.Append ($"\trepeated {className}{ExcelConst.CONFIG_VALUEOBJECT_MESSAGE_END_NAME} {ExcelConst.CONFIG_DATA_VARIABLE_NAME} = 1;\n");
                //结束
                sb.Append ("}\n");

                FileStream fs = File.Create (Path.Combine (Program.protoFilePath , $"{configScriptDataVo.exportFileName}.proto"));
                char [] data = sb.ToString ().ToCharArray ();
                BinaryWriter bw = new BinaryWriter (fs);
                bw.Write (data);
                bw.Close ();
                fs.Close ();
            }
        }

        /// <summary>
        /// 尝试获取配置脚本数据
        /// </summary>
        /// <param name="className"></param>
        /// <param name="configScriptCacheDataVo"></param>
        /// <returns></returns>
        public bool TryGetConfigScriptCacheData (string className , out ConfigScriptCacheDataVo configScriptCacheDataVo)
        {
            return _configScriptDataDict.TryGetValue (className , out configScriptCacheDataVo);
        }
    }
}