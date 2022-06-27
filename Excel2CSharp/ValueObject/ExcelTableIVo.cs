using System.IO;

namespace Excel2CSharp
{
    public struct ExcelTableIVo
    {
        /// <summary>
        /// excel文件ID
        /// </summary>
        public int excelFileId;

        public string sourceFileName;

        public FileInfo fileInfo;
    }
}