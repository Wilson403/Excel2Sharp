// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: vip_gift_table.proto
// </auto-generated>

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace Hot.Generated
{

    [global::ProtoBuf.ProtoContract()]
    public partial class VipGiftTableConfig : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"id")]
        public int Id { get; set; }

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue("")]
        public string FreeTable1 { get; set; } = "";

        [global::ProtoBuf.ProtoMember(3)]
        public int FreeRes1 { get; set; }

        [global::ProtoBuf.ProtoMember(4)]
        public int FreeCount1 { get; set; }

        [global::ProtoBuf.ProtoMember(5)]
        [global::System.ComponentModel.DefaultValue("")]
        public string FreeTable2 { get; set; } = "";

        [global::ProtoBuf.ProtoMember(6)]
        public int FreeRes2 { get; set; }

        [global::ProtoBuf.ProtoMember(7)]
        public int FreeCount2 { get; set; }

        [global::ProtoBuf.ProtoMember(8)]
        [global::System.ComponentModel.DefaultValue("")]
        public string FreeTable3 { get; set; } = "";

        [global::ProtoBuf.ProtoMember(9)]
        public int FreeRes3 { get; set; }

        [global::ProtoBuf.ProtoMember(10)]
        public int FreeCount3 { get; set; }

        [global::ProtoBuf.ProtoMember(11)]
        public int ActualPrice1 { get; set; }

        [global::ProtoBuf.ProtoMember(12)]
        public int ShowPrice1 { get; set; }

        [global::ProtoBuf.ProtoMember(13)]
        [global::System.ComponentModel.DefaultValue("")]
        public string PayTable1 { get; set; } = "";

        [global::ProtoBuf.ProtoMember(14)]
        public int PayRes1 { get; set; }

        [global::ProtoBuf.ProtoMember(15)]
        public int PayCount1 { get; set; }

        [global::ProtoBuf.ProtoMember(16)]
        [global::System.ComponentModel.DefaultValue("")]
        public string PayTable2 { get; set; } = "";

        [global::ProtoBuf.ProtoMember(17)]
        public int PayRes2 { get; set; }

        [global::ProtoBuf.ProtoMember(18)]
        public int PayCount2 { get; set; }

        [global::ProtoBuf.ProtoMember(19)]
        [global::System.ComponentModel.DefaultValue("")]
        public string PayTable3 { get; set; } = "";

        [global::ProtoBuf.ProtoMember(20)]
        public int PayRes3 { get; set; }

        [global::ProtoBuf.ProtoMember(21)]
        public int PayCount3 { get; set; }

        [global::ProtoBuf.ProtoMember(22)]
        public int ActualPrice2 { get; set; }

        [global::ProtoBuf.ProtoMember(23)]
        public int ShowPrice2 { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class VipGiftTableConfigData : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public global::System.Collections.Generic.List<VipGiftTableConfig> ConfigVo { get; } = new global::System.Collections.Generic.List<VipGiftTableConfig>();

    }

}

#pragma warning restore CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#endregion