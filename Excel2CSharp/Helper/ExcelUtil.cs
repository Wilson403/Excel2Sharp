using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Emit;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;

namespace Excel2CSharp
{
    public class ExcelUtil
    {
        /// <summary>
        /// 格式化json字符串
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string ConvertJsonString (string str)
        {
            JsonSerializer serializer = new JsonSerializer ();
            TextReader tr = new StringReader (str);
            JsonTextReader jtr = new JsonTextReader (tr);
            object obj = serializer.Deserialize (jtr);
            if ( obj != null )
            {
                StringWriter textWriter = new StringWriter ();
                JsonTextWriter jsonWriter = new JsonTextWriter (textWriter)
                {
                    Formatting = Formatting.Indented ,
                    Indentation = 4 ,
                    IndentChar = ' '
                };
                serializer.Serialize (jsonWriter , obj);
                return textWriter.ToString ();
            }
            else
            {
                return str;
            }
        }

        /// <summary>
        /// 动态编译
        /// </summary>
        /// <param name="code">需要动态编译的代码</param>
        /// <returns>动态生成的程序集</returns>
        public static Assembly GenerateAssemblyFromCode (string[] codes)
        {
            Assembly assembly = null;

            // 随机程序集名称
            string assemblyName = Path.GetRandomFileName ();

            List<MetadataReference> references = new List<MetadataReference> ();
            for ( int i = 0 ; i < AppDomain.CurrentDomain.GetAssemblies ().Length ; i++ )
            {
                var x = AppDomain.CurrentDomain.GetAssemblies () [i];
                if ( !string.IsNullOrEmpty (x.Location) )
                {
                    try
                    {
                        references.Add (MetadataReference.CreateFromFile (x.Location));
                    }
                    catch ( Exception e )
                    {
                        ConsoleHelper.Ins.WriteErrorLine ($"Location:{x.Location}\n{e}");
                    }
                }
            }

            //丛代码中转换表达式树
            SyntaxTree [] syntaxTrees = new SyntaxTree [codes.Length];
            for ( int i = 0 ; i < codes.Length ; i++ )
            {
                syntaxTrees [i] = CSharpSyntaxTree.ParseText (codes [i]);
            }

            // 创建编译对象
            CSharpCompilation compilation = CSharpCompilation.Create (assemblyName , syntaxTrees , references , new CSharpCompilationOptions (OutputKind.DynamicallyLinkedLibrary));

            using ( var ms = new MemoryStream () )
            {
                // 将编译好的IL代码放入内存流
                EmitResult result = compilation.Emit (ms);

                // 编译失败，提示
                if ( !result.Success )
                {
                    IEnumerable<Diagnostic> failures = result.Diagnostics.Where (diagnostic =>
                                 diagnostic.IsWarningAsError ||
                                 diagnostic.Severity == DiagnosticSeverity.Error);
                    foreach ( Diagnostic diagnostic in failures )
                    {
                        Console.Error.WriteLine ("{0}: {1}" , diagnostic.Id , diagnostic.GetMessage ());
                    }
                }
                else
                {
                    // 编译成功，从内存中加载编译好的程序集
                    ms.Seek (0 , SeekOrigin.Begin);
                    assembly = Assembly.Load (ms.ToArray ());
                }
            }
            return assembly;
        }


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

        /// <summary>
        /// 删除文件夹
        /// </summary>
        /// <param name="srcPath"></param>
        public static void DelectDir (string srcPath)
        {
            if ( !Directory.Exists (srcPath) )
            {
                return;
            }

            try
            {
                DirectoryInfo dir = new DirectoryInfo (srcPath);
                FileSystemInfo [] fileinfo = dir.GetFileSystemInfos ();  //返回目录中所有文件和子目录
                foreach ( FileSystemInfo i in fileinfo )
                {
                    if ( i is DirectoryInfo )            //判断是否文件夹
                    {
                        DirectoryInfo subdir = new DirectoryInfo (i.FullName);
                        subdir.Delete (true);          //删除子目录和文件
                    }
                    else
                    {
                        File.Delete (i.FullName);      //删除指定文件
                    }
                }
            }
            catch ( Exception e )
            {
                throw e;
            }
        }
    }
}