namespace Excel2CSharp
{
    /// <summary>
    /// 定义Excel生成工具所需要的常量
    /// </summary>
    public class ExcelConst
    {
        /// <summary>
        /// Excel导出脚本文件的命名空间1
        /// </summary>
        public const string EXCEL_2_PROTOBUF_SCRIPT_NAMESPACE_1 = "Hot.Generated";

        /// <summary>
        /// Excel导出脚本文件的命名空间2
        /// </summary>
        public const string EXCEL_2_PROTOBUF_SCRIPT_NAMESPACE_2 = "Main.Generated";

        /// <summary>
        /// 配置Vo消息的后缀名称
        /// </summary>
        public const string CONFIG_VALUEOBJECT_MESSAGE_END_NAME = "Config";

        /// <summary>
        /// 配置数据的后缀名称
        /// </summary>
        public const string CONFIG_DATA_MESSAGE_END_NAME = "ConfigData";

        /// <summary>
        /// 配置数据的变量名称
        /// </summary>
        public const string CONFIG_DATA_VARIABLE_NAME = "ConfigVo";

        /// <summary>
        /// 配置管理器脚本的名称
        /// </summary>
        public const string CONFIG_MGR_SCRIPT_NAME = "ConfigMgr.cs";

        /// <summary>
        /// config总览Proto的名称1
        /// </summary>
        public const string ALL_CONFIG_HOT_PROTO_NAME = "all_config_hot.proto";

        /// <summary>
        /// config总览Proto的名称2
        /// </summary>
        public const string ALL_CONFIG_PROTO_NAME = "all_config.proto";

        public const string ALL_CONFIG_HOT_CLASS_NAME = "AllConfigHot";

        public const string ALL_CONFIG_CLASS_NAME = "AllConfig";

        public const string ALL_CONFIG_VAR_NAME_1 = "_allConfigHot";

        public const string ALL_CONFIG_VAR_NAME_2 = "_allConfig";
    }
}