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

        static void Main (string [] args)
        {
            Console.WriteLine ("Excel2CSharp - Input \"help\" to view command");
            System.Text.Encoding.RegisterProvider (System.Text.CodePagesEncodingProvider.Instance);
            ExcelOverViewTableManager.Ins.Init ("E:\\Luna_svn\\preview\\tools\\excel_json\\excel\\设置导出的表格.xlsx");
            configPath = Path.GetFullPath ("../../../Excel2Csharp/Config/");
            csharpPath = Path.GetFullPath ("../../../Excel2Csharp/Generated/");
            protoFilePath = "E:\\Luna_svn\\preview\\LunaProject\\LibraryZero\\BattleCheck\\proto";

            string input;
            //命令处理循环
            while ( ( input = Console.ReadLine () ) != "exit" )
            {
                switch ( input )
                {
                    case "start":
                        Start ();
                        break;

                    case "help":
                        PrintHelpInfo ();
                        break;

                    default:
                        Console.WriteLine ($"未找到的命令:{input}");
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
            Console.WriteLine ($"total time:{sw.ElapsedMilliseconds / 1000}s");
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

        /// <summary>
        /// 打印帮助信息
        /// </summary>
        static void PrintHelpInfo ()
        {
            Console.WriteLine ("=======================");
            Console.WriteLine ("start: 执行代码");
            Console.WriteLine ("exit: 关闭控制台程序");
            Console.WriteLine ("=======================");
        }
    }
}