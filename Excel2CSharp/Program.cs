using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Excel2CSharp
{
    class Program
    {
        private static Dictionary<string , DataSetExchangeTool> _cacheDataSetExchangeToolDict = new Dictionary<string , DataSetExchangeTool> ();

        static void Main (string [] args)
        {
            Console.WriteLine ("Excel2CSharp - Input \"help\" to view command");
            System.Text.Encoding.RegisterProvider (System.Text.CodePagesEncodingProvider.Instance);
            ExcelOverViewTable.Ins.Init ("E:\\Luna_svn\\preview\\tools\\excel_json\\excel\\设置导出的表格.xlsx");
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
            for ( int i = 0 ; i < ExcelOverViewTable.Ins.GetExcelCount () ; i++ )
            {
                new DataSetExchangeTool (ExcelOverViewTable.Ins.GetExcelSourceFileName (i));
            }
            Console.WriteLine ($"total time:{sw.ElapsedMilliseconds / 1000}s");
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