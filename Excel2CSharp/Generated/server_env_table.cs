// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: server_env_table.proto
// </auto-generated>

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace Hot.Generated
{

    [global::ProtoBuf.ProtoContract()]
    public partial class ServerEnvTableConfig : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"id")]
        public int Id { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"name")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Name { get; set; } = "";

        [global::ProtoBuf.ProtoMember(3, Name = @"http_type")]
        [global::System.ComponentModel.DefaultValue("")]
        public string HttpType { get; set; } = "";

        [global::ProtoBuf.ProtoMember(4, Name = @"ip")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Ip { get; set; } = "";

        [global::ProtoBuf.ProtoMember(5, Name = @"wordId")]
        [global::System.ComponentModel.DefaultValue("")]
        public string WordId { get; set; } = "";

        [global::ProtoBuf.ProtoMember(6, Name = @"editor_ignore")]
        public int EditorIgnore { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ServerEnvTableConfigData : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public global::System.Collections.Generic.List<ServerEnvTableConfig> ConfigVo { get; } = new global::System.Collections.Generic.List<ServerEnvTableConfig>();

    }

}

#pragma warning restore CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#endregion
