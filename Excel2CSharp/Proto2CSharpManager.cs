using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Excel2CSharp
{
    public class Proto2CSharpManager : SafeSingleton<Proto2CSharpManager>
    {
        private List<string> _protoFiles;
        private string _protoFileExportDir;

        public void Init (string protoFileExportDir)
        {
            _protoFileExportDir = protoFileExportDir;
            RefreshProteFiles ();
            CreateOverViewProtoFile ();
            RefreshProteFiles ();
        }

        /// <summary>
        /// 刷新proto文件组
        /// </summary>
        public void RefreshProteFiles ()
        {
            if ( !string.IsNullOrEmpty (_protoFileExportDir) )
            {
                _protoFiles = Directory.GetFiles (_protoFileExportDir , "*.proto" , SearchOption.AllDirectories).ToList ();
            }

            //将汇总文件放到尾部
            var totalFileName = _protoFiles.FirstOrDefault (x => x.Equals (Path.Combine (_protoFileExportDir , ExcelConst.ALL_CONFIG_HOT_PROTO_NAME)));
            if ( totalFileName != null )
            {
                _protoFiles.Remove (totalFileName);
                _protoFiles.Add (totalFileName);
            }
        }

        /// <summary>
        /// 创建proto汇总文件
        /// </summary>
        private void CreateOverViewProtoFile ()
        {
            //用于热更代码的字符串拼接器
            StringBuilder importPackageNameSb1 = new StringBuilder ();
            StringBuilder variableNameSb1 = new StringBuilder ();

            //用于非热更代码的字符串拼接器
            StringBuilder importPackageNameSb2 = new StringBuilder ();
            StringBuilder variableNameSb2 = new StringBuilder ();

            //读取出Proto汇总文件模板的内容
            string template = File.ReadAllText (Path.Combine (Program.configPath , "AllConfigProtoTemplate.txt"));

            //穷举所有的proto文件集合
            for ( int i = 0 ; i < _protoFiles.Count ; i++ )
            {
                var strArr = _protoFiles [i].Split ('\\');
                var fileName = strArr [strArr.Length - 1];

                //自身文件名称排除
                if ( fileName.Equals (ExcelConst.ALL_CONFIG_HOT_PROTO_NAME) )
                {
                    continue;
                }

                var tempStr = fileName.Replace (".proto" , "");
                var realFileName = ExcelUtil.UnderScore2UpperCamelNames (tempStr);
                var typeName = $"{realFileName}{ExcelConst.CONFIG_DATA_MESSAGE_END_NAME}";
                importPackageNameSb1.Append ($"import \"{fileName}\";\r\n");
                variableNameSb1.Append ($"\t{typeName} {ExcelUtil.ToLowerFirst (typeName)} = {( i + 1 )};\r\n");

                //var isHot = GetCodeSource (tempStr).Equals (0);
                //使用条件表达式返回适合的拼接器
                //( isHot ? importPackageNameSb1 : importPackageNameSb2 ).Append ($"import \"{fileName}\";\r\n");
                //( isHot ? variableNameSb1 : variableNameSb2 ).Append ($"\t{typeName} {ExcelUtil.ToLowerFirst (typeName)} = {( i + 1 )};\r\n");
            }

            //在替换之前先保存一份
            var template2 = template;

            //对模板进行内容替换
            template = template.Replace ("{0}" , ExcelConst.EXCEL_2_PROTOBUF_SCRIPT_NAMESPACE_1);
            template = template.Replace ("{1}" , importPackageNameSb1.ToString ());
            template = template.Replace ("{2}" , ExcelConst.ALL_CONFIG_HOT_CLASS_NAME);
            template = template.Replace ("{3}" , variableNameSb1.ToString ());
            //写入内容
            File.WriteAllText (Path.Combine (_protoFileExportDir , ExcelConst.ALL_CONFIG_HOT_PROTO_NAME) , template);

            //替换为第二组拼接器的内容
            template2 = template2.Replace ("{0}" , ExcelConst.EXCEL_2_PROTOBUF_SCRIPT_NAMESPACE_2);
            template2 = template2.Replace ("{1}" , importPackageNameSb2.ToString ());
            template2 = template2.Replace ("{2}" , ExcelConst.ALL_CONFIG_CLASS_NAME);
            template2 = template2.Replace ("{3}" , variableNameSb2.ToString ());
            //再写一遍
            File.WriteAllText (Path.Combine (_protoFileExportDir , ExcelConst.ALL_CONFIG_PROTO_NAME) , template2);
        }
    }
}