using System.Data;

namespace Excel2CSharp
{
    /// <summary>
    /// 配置脚本的数据数据结构
    /// </summary>
    public struct ConfigScriptCacheDataVo
    {
        /// <summary>
        /// 表格ID
        /// </summary>
        public int sheetId;

        /// <summary>
        /// 源文件名
        /// </summary>
        public string sourceFile;

        /// <summary>
        /// 导出文件名
        /// </summary>
        public string exportFileName;

        /// <summary>
        /// 类名
        /// </summary>
        public string className;

        /// <summary>
        /// 表格对象
        /// 缓存起来，不然重新读取速度太慢
        /// </summary>
        public DataTable worksheet;

        /// <summary>
        /// excel行数
        /// </summary>
        public int excelRowCount;

        /// <summary>
        /// excel列数
        /// </summary>
        public int excelColCount;
    }
}