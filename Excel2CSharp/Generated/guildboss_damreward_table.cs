// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: guildboss_damreward_table.proto
// </auto-generated>

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace Hot.Generated
{

    [global::ProtoBuf.ProtoContract()]
    public partial class GuildbossDamrewardTableConfig : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"id")]
        public int Id { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"hpline")]
        public int Hpline { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"damage")]
        public long Damage { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"box")]
        public int Box { get; set; }

        [global::ProtoBuf.ProtoMember(5, Name = @"contribution")]
        public int Contribution { get; set; }

        [global::ProtoBuf.ProtoMember(6, Name = @"icon_box")]
        [global::System.ComponentModel.DefaultValue("")]
        public string IconBox { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class GuildbossDamrewardTableConfigData : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public global::System.Collections.Generic.List<GuildbossDamrewardTableConfig> ConfigVo { get; } = new global::System.Collections.Generic.List<GuildbossDamrewardTableConfig>();

    }

}

#pragma warning restore CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#endregion