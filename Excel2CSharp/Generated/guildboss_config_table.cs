// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: guildboss_config_table.proto
// </auto-generated>

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace Hot.Generated
{

    [global::ProtoBuf.ProtoContract()]
    public partial class GuildbossConfigTableConfig : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"id")]
        public int Id { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"model")]
        public int Model { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"des")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Des { get; set; } = "";

        [global::ProtoBuf.ProtoMember(4)]
        public int Quality { get; set; }

        [global::ProtoBuf.ProtoMember(5)]
        public int Speed { get; set; }

        [global::ProtoBuf.ProtoMember(6)]
        public long MaxHp { get; set; }

        [global::ProtoBuf.ProtoMember(7)]
        public int Attack { get; set; }

        [global::ProtoBuf.ProtoMember(8)]
        public int PhysicDefense { get; set; }

        [global::ProtoBuf.ProtoMember(9)]
        public int Hit { get; set; }

        [global::ProtoBuf.ProtoMember(10)]
        public int Dodge { get; set; }

        [global::ProtoBuf.ProtoMember(11)]
        public int Crit { get; set; }

        [global::ProtoBuf.ProtoMember(12)]
        public int CritResist { get; set; }

        [global::ProtoBuf.ProtoMember(13, Name = @"sicon1")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Sicon1 { get; set; } = "";

        [global::ProtoBuf.ProtoMember(14, Name = @"sname1")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Sname1 { get; set; } = "";

        [global::ProtoBuf.ProtoMember(15, Name = @"sdes1")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Sdes1 { get; set; } = "";

        [global::ProtoBuf.ProtoMember(16, Name = @"sicon2")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Sicon2 { get; set; } = "";

        [global::ProtoBuf.ProtoMember(17, Name = @"sname2")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Sname2 { get; set; } = "";

        [global::ProtoBuf.ProtoMember(18, Name = @"sdes2")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Sdes2 { get; set; } = "";

        [global::ProtoBuf.ProtoMember(19, Name = @"sicon3")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Sicon3 { get; set; } = "";

        [global::ProtoBuf.ProtoMember(20, Name = @"sname3")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Sname3 { get; set; } = "";

        [global::ProtoBuf.ProtoMember(21, Name = @"sdes3")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Sdes3 { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class GuildbossConfigTableConfigData : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public global::System.Collections.Generic.List<GuildbossConfigTableConfig> ConfigVo { get; } = new global::System.Collections.Generic.List<GuildbossConfigTableConfig>();

    }

}

#pragma warning restore CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#endregion