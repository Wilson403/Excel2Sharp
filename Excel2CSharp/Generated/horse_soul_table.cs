// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: horse_soul_table.proto

#pragma warning disable CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace Hot.Generated
{

    [global::ProtoBuf.ProtoContract()]
    public partial class HorseSoulTableConfig : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"id")]
        public int Id { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"talent")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Talent { get; set; } = "";

        [global::ProtoBuf.ProtoMember(3)]
        public int MountId { get; set; }

        [global::ProtoBuf.ProtoMember(4)]
        [global::System.ComponentModel.DefaultValue("")]
        public string StageName { get; set; } = "";

        [global::ProtoBuf.ProtoMember(5)]
        public int AttType { get; set; }

        [global::ProtoBuf.ProtoMember(6)]
        public int AttNum { get; set; }

        [global::ProtoBuf.ProtoMember(7)]
        public int LvUpCostNum { get; set; }

        [global::ProtoBuf.ProtoMember(8, Name = @"need_table1")]
        [global::System.ComponentModel.DefaultValue("")]
        public string NeedTable1 { get; set; } = "";

        [global::ProtoBuf.ProtoMember(9, Name = @"need_id1")]
        public int NeedId1 { get; set; }

        [global::ProtoBuf.ProtoMember(10, Name = @"need_num1")]
        public int NeedNum1 { get; set; }

        [global::ProtoBuf.ProtoMember(11, Name = @"need_table2")]
        [global::System.ComponentModel.DefaultValue("")]
        public string NeedTable2 { get; set; } = "";

        [global::ProtoBuf.ProtoMember(12, Name = @"need_id2")]
        public int NeedId2 { get; set; }

        [global::ProtoBuf.ProtoMember(13, Name = @"need_num2")]
        public int NeedNum2 { get; set; }

        [global::ProtoBuf.ProtoMember(14, Name = @"need_table3")]
        [global::System.ComponentModel.DefaultValue("")]
        public string NeedTable3 { get; set; } = "";

        [global::ProtoBuf.ProtoMember(15, Name = @"need_id3")]
        public int NeedId3 { get; set; }

        [global::ProtoBuf.ProtoMember(16, Name = @"need_num3")]
        public int NeedNum3 { get; set; }

        [global::ProtoBuf.ProtoMember(17, Name = @"need_table4")]
        [global::System.ComponentModel.DefaultValue("")]
        public string NeedTable4 { get; set; } = "";

        [global::ProtoBuf.ProtoMember(18, Name = @"need_id4")]
        public int NeedId4 { get; set; }

        [global::ProtoBuf.ProtoMember(19, Name = @"need_num4")]
        public int NeedNum4 { get; set; }

        [global::ProtoBuf.ProtoMember(20, Name = @"power")]
        public int Power { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class HorseSoulTableConfigData : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public global::System.Collections.Generic.List<HorseSoulTableConfig> ConfigVoes { get; } = new global::System.Collections.Generic.List<HorseSoulTableConfig>();

    }

}

#pragma warning restore CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
