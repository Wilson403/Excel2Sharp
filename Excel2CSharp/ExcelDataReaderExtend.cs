using System.Data;

namespace Excel2CSharp
{
    public static class ExcelDataReaderExtend
    {
        public static int GetInt (this DataTable dataTable , int row , int col)
        {
            var val = GetString (dataTable , row , col);
            if ( string.IsNullOrEmpty (val) )
            {
                return 0;
            }
            return int.Parse (val);
        }

        public static long GetLong (this DataTable dataTable , int row , int col)
        {
            var val = GetString (dataTable , row , col);
            if ( string.IsNullOrEmpty (val) )
            {
                return 0;
            }
            return long.Parse (val);
        }

        public static string GetString (this DataTable dataTable , int row , int col)
        {
            var val = dataTable.Rows [row] [col].ToString ();
            if ( string.IsNullOrEmpty (val) )
            {
                return "";
            }
            return val;
        }
    }
}