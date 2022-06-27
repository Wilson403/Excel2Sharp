using System;
using System.Collections.Generic;
using System.Data;
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
            _excel2DataSet = new Excel2DataSet ($"E:\\Luna_svn\\preview\\tools\\excel_json\\excel\\excel_config\\{sourcefileName}.xlsx");
            ExportProtoFile ();
        }

        public void ExportProtoFile ()
        {
            var tableCount = _excel2DataSet.GetTableCount ();
            for ( int tableIndex = 0 ; tableIndex < tableCount ; tableIndex++ )
            {
                var sheet = _excel2DataSet [tableIndex];
                var vo = ExcelOverViewTable.Ins.GetSheetList (_sourcefileName).FirstOrDefault (x => x.sheetName.Equals (sheet.TableName));

                //表格无法索引时抛出异常
                if ( string.IsNullOrEmpty (vo.exportFileName) )
                {
                    Console.WriteLine ($"跳过了一个格式不符合的配置表。源文件：{_sourcefileName}, 表格：{sheet.TableName}");
                    continue;
                    // throw new Exception ($"无效的表格，文件：{_sourcefileName} 名称：{sheet.TableName}");
                }

                ////表格格式检查
                //if ( !CheckExcelSheetIsUseful (sheet) )
                //{
                //    Console.WriteLine ($"跳过了一个格式不符合的配置表。源文件：{_sourcefileName}, 表格：{vo.exportFileName}");
                //    continue;
                //}

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
                sb.Append ($"package {GetNameSpace (vo)};\n\n");

                //写入消息名称
                sb.Append ($"message {className}{ExcelConst.CONFIG_VALUEOBJECT_MESSAGE_END_NAME}{{\n");

                List<string> tableFieldNames = new List<string> ();

                for ( int j = 0 ; j < col ; j++ )
                {
                    if ( CheckExcelColIsNull (sheet , j) )
                    {
                        //如果下一列也为空，直接跳出
                        var next = j + 1;
                        if ( next < col )
                        {
                            if ( CheckExcelColIsNull (sheet , next) )
                            {
                                break;
                            }
                        }
                        else
                        {
                            break;
                        }
                    }

                    if ( CheckExcelColIsCanFilter (sheet , j) )
                    {
                        continue;
                    }

                    //获取变量名称
                    var variableName = sheet.GetString (2 , j);

                    //获取描述
                    var desc = sheet.GetString (0 , j);

                    //获取类型名称
                    var typeName = sheet.GetString (1 , j);

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
                    sb.Append ($"\t{ExcelUtil.GetTypeName (typeName)} {variableName} = {j};");
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

                FileStream fs = File.Create ("E:\\Luna_svn\\preview\\LunaProject\\LibraryZero\\BattleCheck\\proto" + "/" + configScriptDataVo.exportFileName + ".proto");
                char [] data = sb.ToString ().ToCharArray ();
                BinaryWriter bw = new BinaryWriter (fs);
                bw.Write (data);
                bw.Close ();
                fs.Close ();
            }
        }

        /// <summary>
        /// 检查表格是否有效
        /// 这个表格标准是项目而定的，主要是对表头信息进行检查，符合要求才是项目需要的配置表
        /// </summary>
        /// <returns></returns>
        private bool CheckExcelSheetIsUseful (DataTable dataTable)
        {
            //如果表头信息都不存在，不继续
            if ( dataTable.Rows.Count < 3 || dataTable.Columns.Count < 1 )
            {
                return false;
            }

            string desc = dataTable.GetString (0 , 0);
            string type = dataTable.GetString (1 , 0);
            string variable = dataTable.GetString (2 , 0);

            //缺少任一重要信息，不继续执行
            if ( string.IsNullOrEmpty (desc) || string.IsNullOrEmpty (type) || string.IsNullOrEmpty (variable) )
            {
                return false;
            }

            return desc.Equals ("desc") && type.Equals ("type") && variable.Equals ("id");
        }

        /// <summary>
        /// 获取命名空间
        /// </summary>
        /// <returns></returns>
        private string GetNameSpace (ExcelOverViewTableVo excelOverViewTable)
        {
            return excelOverViewTable.codeSource.Equals (0) ? ExcelConst.EXCEL_2_PROTOBUF_SCRIPT_NAMESPACE_1 : ExcelConst.EXCEL_2_PROTOBUF_SCRIPT_NAMESPACE_2;
        }

        /// <summary>
        /// 检查Excel表该行是否为空
        /// </summary>
        /// <param name="sheet"></param>
        /// <param name="col"></param>
        /// <returns></returns>
        private bool CheckExcelColIsNull (DataTable sheet , int col)
        {
            return string.IsNullOrEmpty (sheet.GetString (0 , col)) && string.IsNullOrEmpty (sheet.GetString (1 , col)) && string.IsNullOrEmpty (sheet.GetString (2 , col));
        }

        /// <summary>
        /// 检查Excel表该行是否可以过滤掉
        /// </summary>
        /// <param name="sheet"></param>
        /// <param name="col"></param>
        /// <returns></returns>
        private bool CheckExcelColIsCanFilter (DataTable sheet , int col)
        {
            return string.IsNullOrEmpty (sheet.GetString (1 , col)) || string.IsNullOrEmpty (sheet.GetString (2 , col));
        }
    }
}