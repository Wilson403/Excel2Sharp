using System;

namespace Excel2CSharp
{
    public static class ExcelDataReaderExtend
    {
        public static int GetInt (this object originData)
        {
            var val = GetString (originData);
            if ( string.IsNullOrEmpty (val) )
            {
                return 0;
            }

            return int.Parse (CertainNumIsInt (val));
        }

        public static long GetLong (this object originData)
        {
            var val = GetString (originData);
            if ( string.IsNullOrEmpty (val) )
            {
                return 0;
            }
            return long.Parse (CertainNumIsInt (val));
        }

        public static float GetFloat (this object originData)
        {
            var val = GetString (originData);
            if ( string.IsNullOrEmpty (val) )
            {
                return 0;
            }
            return float.Parse (val);
        }

        public static bool GetBool (this object originData)
        {
            var val = GetString (originData);
            if ( string.IsNullOrEmpty (val) )
            {
                return false;
            }
            return bool.Parse (val);
        }

        public static string GetString (this object originData)
        {
            var val = originData.ToString ();
            if ( string.IsNullOrEmpty (val) )
            {
                return "";
            }
            return val;
        }

        /// <summary>
        /// 确保数字是整形
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        private static string CertainNumIsInt (string content)
        {
            if ( content.Contains ('.') )
            {
                content = Math.Round (double.Parse (content)).ToString ();
            }
            return content.Split ('.') [0];
        }
    }
}