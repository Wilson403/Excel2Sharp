using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace Excel2CSharp
{
    class Program
    {
        private static readonly List<DataSetExchangeTool> _cacheDataSetExchangeToolList = new List<DataSetExchangeTool> ();
        public static string configPath;
        public static string csharpPath;
        public static string protoFilePath;
        public static string byteFilePath;
        public static string excelOverviewPath;
        public static string excelDir;
        public static string hotCsharpPath;
        public static string jsonFileExportDir;


        static void Main (string [] args)
        {
            System.Text.Encoding.RegisterProvider (System.Text.CodePagesEncodingProvider.Instance);
            configPath = Path.Combine (Environment.CurrentDirectory , "Config");

            for ( int i = 0 ; i < args.Length ; i++ )
            {
                string arg = args [i];
                string lhs = arg;
                string rhs = "";

                if ( lhs.StartsWith ("--byte_out")
                    || lhs.StartsWith ("--csharp_out")
                    || lhs.StartsWith ("--hot_csharp_out")
                    || lhs.StartsWith ("--proto_out")
                    || lhs.StartsWith ("--excelOver_out")
                    || lhs.StartsWith ("--excel_out") )
                {
                    var arr = lhs.Split ("=");
                    lhs = arr [0];
                    rhs = arr [1];
                }

                switch ( lhs )
                {
                    case "--byte_out":
                        byteFilePath = rhs;
                        break;

                    case "--csharp_out":
                        csharpPath = rhs;
                        break;

                    case "--proto_out":
                        protoFilePath = rhs;
                        break;

                    case "--excelOver_out":
                        excelOverviewPath = rhs;
                        break;

                    case "--excel_out":
                        excelDir = rhs;
                        break;

                    case "--hot_csharp_out":
                        hotCsharpPath = rhs;
                        break;

                    case "--json_export_dir":
                        jsonFileExportDir = rhs;
                        break;

                    case "--start":
                        ExcelOverViewTableManager.Ins.Init (excelOverviewPath , "设置导出的表格.xlsx");
                        Start ();
                        break;

                    default:
                        ConsoleHelper.Ins.WriteErrorLine ($"未处理的参数命令{lhs}");
                        break;
                }
            }
        }

        static void Start ()
        {
            var sw = new Stopwatch ();
            sw.Start ();
            ExcelUtil.DelectDir (protoFilePath);
            for ( int i = 0 ; i < ExcelOverViewTableManager.Ins.GetExcelCount () ; i++ )
            {
                _cacheDataSetExchangeToolList.Add (new DataSetExchangeTool (ExcelOverViewTableManager.Ins.GetExcelSourceFileName (i)));
            }
            Proto2CSharpManager.Ins.Init ();
            ConsoleHelper.Ins.WriteWarningLine ($"total time:{sw.ElapsedMilliseconds / 1000}s");
        }

        public static bool FindConfigScriptCacheDataVo (string className , ref ConfigScriptCacheDataVo configScriptCacheDataVo)
        {
            for ( int i = 0 ; i < _cacheDataSetExchangeToolList.Count ; i++ )
            {
                if ( _cacheDataSetExchangeToolList [i].TryGetConfigScriptCacheData (className , out configScriptCacheDataVo) )
                {
                    return true;
                }
            }
            return false;
        }

        public static List<ConfigScriptCacheDataVo> WhereConfigScriptCacheDataVo ()
        {
            List<ConfigScriptCacheDataVo> list = new List<ConfigScriptCacheDataVo> ();
            for ( int i = 0 ; i < _cacheDataSetExchangeToolList.Count ; i++ )
            {
                foreach ( var item in _cacheDataSetExchangeToolList [i].configScriptDataDict.Values )
                {
                    list.Add (item);
                }
            }
            return list;
        }
    }
}