// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: activity_config_table.proto
// </auto-generated>

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace Hot.Generated
{

    [global::ProtoBuf.ProtoContract()]
    public partial class ActivityConfigTableConfig : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"id")]
        public int Id { get; set; }

        [global::ProtoBuf.ProtoMember(2)]
        public int AllLimitBuy { get; set; }

        [global::ProtoBuf.ProtoMember(3)]
        public int PersonalLimitBuy { get; set; }

        [global::ProtoBuf.ProtoMember(4)]
        [global::System.ComponentModel.DefaultValue("")]
        public string BuyID1 { get; set; } = "";

        [global::ProtoBuf.ProtoMember(5)]
        [global::System.ComponentModel.DefaultValue("")]
        public string BuyTable1 { get; set; } = "";

        [global::ProtoBuf.ProtoMember(6)]
        public int BuyCount1 { get; set; }

        [global::ProtoBuf.ProtoMember(7)]
        [global::System.ComponentModel.DefaultValue("")]
        public string BuyID2 { get; set; } = "";

        [global::ProtoBuf.ProtoMember(8)]
        [global::System.ComponentModel.DefaultValue("")]
        public string BuyTable2 { get; set; } = "";

        [global::ProtoBuf.ProtoMember(9)]
        public int BuyCount2 { get; set; }

        [global::ProtoBuf.ProtoMember(10)]
        [global::System.ComponentModel.DefaultValue("")]
        public string BuyID3 { get; set; } = "";

        [global::ProtoBuf.ProtoMember(11)]
        [global::System.ComponentModel.DefaultValue("")]
        public string BuyTable3 { get; set; } = "";

        [global::ProtoBuf.ProtoMember(12)]
        public int BuyCount3 { get; set; }

        [global::ProtoBuf.ProtoMember(13)]
        [global::System.ComponentModel.DefaultValue("")]
        public string ConsumeID1 { get; set; } = "";

        [global::ProtoBuf.ProtoMember(14)]
        [global::System.ComponentModel.DefaultValue("")]
        public string ConsumeTable1 { get; set; } = "";

        [global::ProtoBuf.ProtoMember(15)]
        public int ConsumeCount1 { get; set; }

        [global::ProtoBuf.ProtoMember(16)]
        [global::System.ComponentModel.DefaultValue("")]
        public string ConsumeID2 { get; set; } = "";

        [global::ProtoBuf.ProtoMember(17)]
        [global::System.ComponentModel.DefaultValue("")]
        public string ConsumeTable2 { get; set; } = "";

        [global::ProtoBuf.ProtoMember(18)]
        public int ConsumeCount2 { get; set; }

        [global::ProtoBuf.ProtoMember(19)]
        [global::System.ComponentModel.DefaultValue("")]
        public string ConsumeID3 { get; set; } = "";

        [global::ProtoBuf.ProtoMember(20)]
        [global::System.ComponentModel.DefaultValue("")]
        public string ConsumeTable3 { get; set; } = "";

        [global::ProtoBuf.ProtoMember(21)]
        public int ConsumeCount3 { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ActivityConfigTableConfigData : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public global::System.Collections.Generic.List<ActivityConfigTableConfig> ConfigVo { get; } = new global::System.Collections.Generic.List<ActivityConfigTableConfig>();

    }

}

#pragma warning restore CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#endregion
