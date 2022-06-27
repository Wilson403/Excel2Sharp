using ExcelDataReader;
using System;
using System.Data;
using System.Diagnostics;
using System.IO;

namespace Excel2CSharp
{
    /// <summary>
    /// Excel转化DataSet
    /// </summary>
    public class Excel2DataSet
    {
        private readonly DataSet _allTableData;

        public Excel2DataSet (string excelFile)
        {
            var sw = new Stopwatch ();
            sw.Start ();
            using ( FileStream stream = new FileStream (excelFile , FileMode.Open , FileAccess.Read , FileShare.ReadWrite) )
            {
                IExcelDataReader mExcelReader = ExcelReaderFactory.CreateOpenXmlReader (stream);
                var openTiming = sw.ElapsedMilliseconds;
                using ( mExcelReader )
                {
                    _allTableData = mExcelReader.AsDataSet ();
                    if ( _allTableData == null || _allTableData.Tables.Count == 0 )
                    {
                        throw new Exception ($"{excelFile}读取异常");
                    }
                    Console.WriteLine ($"{excelFile}：读取耗时:{sw.ElapsedMilliseconds}ms");
                }
            }
        }

        /// <summary>
        /// 获取首个表格
        /// </summary>
        /// <returns></returns>
        public DataTable GetFirstTable ()
        {
            return _allTableData.Tables [0];
        }

        /// <summary>
        /// 获取表格数量
        /// </summary>
        /// <returns></returns>
        public int GetTableCount ()
        {
            return _allTableData.Tables.Count;
        }

        /// <summary>
        /// 表格索引器
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public DataTable this [int index]
        {
            get
            {
                return _allTableData.Tables [index];
            }
        }
    }
}