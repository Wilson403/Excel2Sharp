namespace Excel2CSharp
{
    public struct ExcelOverViewTableVo
    {
        /// <summary>
        /// 源文件名
        /// </summary>
        public string sourcefileName;

        /// <summary>
        /// 导出文件名
        /// </summary>
        public string exportFileName;

        /// <summary>
        /// 表格名
        /// </summary>
        public string sheetName;

        /// <summary>
        /// 代码来源
        /// </summary>
        public int codeSource;

        /// <summary>
        /// 加载批次
        /// </summary>
        public int loadIndex;
    }
}