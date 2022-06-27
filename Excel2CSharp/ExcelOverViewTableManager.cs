using System.Collections.Generic;

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

                var sourcefileName = sheet.GetString (i , 0);
                var vo = new ExcelOverViewTableVo
                {
                    exportFileName = sheet.GetString (i , 2) ,
                    sheetName = sheet.GetString (i , 1) ,
                    sourcefileName = sheet.GetString (i , 0) ,
                    codeSource = sheet.GetInt (i , 3) ,
                    loadIndex = sheet.GetInt (i , 4)
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
    }
}