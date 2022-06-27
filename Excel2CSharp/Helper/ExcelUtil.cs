using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Excel2CSharp
{
    public class ExcelUtil
    {
        /// <summary>
        /// 获取类型名称
        /// </summary>
        /// <param name="typeName"></param>
        public static string GetTypeName (string typeName)
        {
            //必须小写
            typeName = typeName.ToLower ();

            switch ( typeName )
            {
                case "int":
                case "int32":
                    return "int32";

                case "long":
                case "int64":
                    return "int64";

                case "string":
                    return "string";

                case "float":
                    return "float";

                case "int[]":
                case "int32[]":
                    return "repeated int32";

                case "int64[]":
                    return "repeated int64";

                case "string[]":
                    return "repeated string";

                case "bool":
                case "boolean":
                    return "bool";

                case "float[]":
                    return "repeated float";

                default:
                    throw new System.Exception ($"获取到一个意外的类型{typeName}，请格外注意");
            }
        }

        /// <summary>
        /// 下划线转大驼峰命名
        /// </summary>
        public static string UnderScore2UpperCamelNames (string content)
        {
            var strArr = content.Split ('_');
            if ( strArr == null || strArr.Length == 0 ) return content;

            StringBuilder sb = new StringBuilder ();
            for ( int i = 0 ; i < strArr.Length ; i++ )
            {
                sb.Append (ToUpperFirst (strArr [i]));
            }
            return sb.ToString ();
        }

        /// <summary>
        /// 大驼峰命名转下划线
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        public static string UpperCamelNames2UnderScore (string content)
        {
            string newContent = "";

            for ( int j = 0 ; j < content.Length ; j++ )
            {
                var charItem = content [j];
                if ( CompareChar (charItem) > 0 )
                {
                    if ( j == 0 )
                    {
                        newContent += charItem.ToString ().ToLower ();
                    }
                    else
                    {
                        newContent += "_" + charItem.ToString ().ToLower ();
                    }
                }
                else
                {
                    newContent += charItem;
                }
            }

            return newContent;
        }

        /// <summary>
        /// 判断字符是否为大写字母
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>       
        public static int CompareChar (char c)
        {
            if ( c >= 'A' && c <= 'Z' )
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// 将字符串首字符改为大写
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static unsafe string ToUpperFirst (string str)
        {
            if ( str == null ) return null;
            string ret = string.Copy (str);
            fixed ( char* ptr = ret )
                *ptr = char.ToUpper (*ptr);
            return ret;
        }

        /// <summary>
        /// 将字符串首字符改为小写
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static unsafe string ToLowerFirst (string str)
        {
            if ( str == null ) return null;
            string ret = string.Copy (str);
            fixed ( char* ptr = ret )
                *ptr = char.ToLower (*ptr);
            return ret;
        }

        /// <summary>
        /// 获取MD5
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public static string GetMD5 (string filePath)
        {
            FileStream fs = new FileStream (filePath , FileMode.Open);
            MD5 md5 = new MD5CryptoServiceProvider ();
            byte [] bytes = md5.ComputeHash (fs);
            fs.Close ();
            StringBuilder strbul = new StringBuilder (40);
            for ( int i = 0 ; i < bytes.Length ; i++ )
            {
                strbul.Append (bytes [i].ToString ("x2"));//加密结果"x2"结果为32位,"x3"结果为48位,"x4"结果为64位
            }
            md5.Dispose ();
            return strbul.ToString ();
        }

        /// <summary>
        /// 在字符串里插入字符
        /// </summary>
        /// <param name="content">内容</param>
        /// <param name="theChar">字符</param>
        /// <returns></returns>
        public static string StringInsertChar (string content , char theChar)
        {
            if ( string.IsNullOrEmpty (content) )
            {
                return "";
            }

            StringBuilder versionInfoSb = new StringBuilder ();
            for ( int i = 0 ; i < content.Length ; i++ )
            {
                versionInfoSb.Append ($"{content [i]}");
                if ( i != content.Length - 1 )
                {
                    versionInfoSb.Append (theChar);
                }
            }
            return versionInfoSb.ToString ();
        }
    }
}