using System;

namespace Excel2CSharp
{
    /// <summary>
    /// 控制台帮助类
    /// </summary>
    public class ConsoleHelper : SafeSingleton<ConsoleHelper>
    {
        public void WriteColorLine (string str , ConsoleColor color)
        {
            ConsoleColor currentForeColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.WriteLine (str);
            Console.ForegroundColor = currentForeColor;
        }

        /// <summary>
        /// 打印错误信息
        /// </summary>
        /// <param name="str"></param>
        public void WriteErrorLine (string str)
        {
            WriteColorLine (str , ConsoleColor.Red);
        }

        /// <summary>
        /// 打印警告信息
        /// </summary>
        /// <param name="str"></param>
        public void WriteWarningLine (string str)
        {
            WriteColorLine (str , ConsoleColor.Yellow);
        }

        /// <summary>
        /// 打印正常信息
        /// </summary>
        /// <param name="str"></param>
        public void WriteInfoLine (string str)
        {
            WriteColorLine (str , ConsoleColor.White);
        }

        /// <summary>
        /// 打印成功的信息
        /// </summary>
        /// <param name="str"></param>
        public void WriteSuccessLine (string str)
        {
            WriteColorLine (str , ConsoleColor.Green);
        }
    }
}