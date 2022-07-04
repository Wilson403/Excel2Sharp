using System.Collections.Generic;
using System.Data;

namespace Excel2CSharp
{
    /// <summary>
    /// Excel总览表，用于管理参与导出的表格
    /// </summary>
    public class ExcelOverViewTableManager : SafeSingleton<ExcelOverViewTableManager>
    {
        /// <summary>
        /// 用于记录Excel总览数据的字典
        /// key: Excel源文件名称
        /// value: 
        /// </summary>
        private readonly Dictionary<string , List<ExcelOverViewTableVo>> _excelOverViewList = new Dictionary<string , List<ExcelOverViewTableVo>> ();
        private readonly List<string> _excelOverViewKeyArray = new List<string> ();

        public void Init (string excelOverviewPath)
        {
            Excel2DataSet excelExchangeTools = new Excel2DataSet (excelOverviewPath);
            var sheet = excelExchangeTools.GetFirstTable ();

            for ( int i = 0 ; i < sheet.Rows.Count ; i++ )
            {
                //忽略前2行表头的数据
                if ( i == 0 || i == 1 )
                {
                    continue;
                }

                var sourcefileName = sheet.Rows [i] [0].GetString ();
                var vo = new ExcelOverViewTableVo
                {
                    exportFileName = sheet.Rows [i] [2].GetString () ,
                    sheetName = sheet.Rows [i] [1].GetString () ,
                    sourcefileName = sheet.Rows [1] [0].GetString () ,
                    codeSource = sheet.Rows [i] [3].GetInt () ,
                    loadIndex = sheet.Rows [i] [4].GetInt ()
                };

                if ( _excelOverViewList.TryGetValue (sourcefileName , out var list) )
                {
                    list.Add (vo);
                    continue;
                }
                _excelOverViewList.Add (sourcefileName , new List<ExcelOverViewTableVo> (1) { vo });
                _excelOverViewKeyArray.Add (sourcefileName);
            }
        }

        /// <summary>
        /// 获取表格列表
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public List<ExcelOverViewTableVo> GetSheetList (string key)
        {
            return _excelOverViewList [key];
        }

        /// <summary>
        /// 获取Excel数量
        /// </summary>
        /// <returns></returns>
        public int GetExcelCount ()
        {
            return _excelOverViewKeyArray.Count;
        }

        /// <summary>
        /// 获取Excel数量
        /// </summary>
        /// <returns></returns>
        public string GetExcelSourceFileName (int idx)
        {
            return _excelOverViewKeyArray [idx];
        }

        /// <summary>
        /// 检查Excel表该行是否为空
        /// </summary>
        /// <param name="sheet"></param>
        /// <param name="col"></param>
        /// <returns></returns>
        public bool CheckExcelColIsNull (DataTable sheet , int col)
        {
            return string.IsNullOrEmpty (sheet.Rows [0] [col].GetString ()) && string.IsNullOrEmpty (sheet.Rows [1] [col].GetString ()) && string.IsNullOrEmpty (sheet.Rows [2] [col].GetString ());
        }

        /// <summary>
        /// 检查Excel表该行是否可以过滤掉
        /// </summary>
        /// <param name="sheet"></param>
        /// <param name="col"></param>
        /// <returns></returns>
        public bool CheckExcelColIsCanFilter (DataTable sheet , int col)
        {
            return string.IsNullOrEmpty (sheet.Rows [1] [col].GetString ()) || string.IsNullOrEmpty (sheet.Rows [2] [col].GetString ());
        }
    }
}