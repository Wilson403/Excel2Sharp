// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: explore_pack_table.proto
// </auto-generated>

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace Hot.Generated
{

    [global::ProtoBuf.ProtoContract()]
    public partial class ExplorePackTableConfig : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"id")]
        public int Id { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"name")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Name { get; set; } = "";

        [global::ProtoBuf.ProtoMember(3)]
        [global::System.ComponentModel.DefaultValue("")]
        public string Table1 { get; set; } = "";

        [global::ProtoBuf.ProtoMember(4)]
        public int Resource1 { get; set; }

        [global::ProtoBuf.ProtoMember(5)]
        public int Count1 { get; set; }

        [global::ProtoBuf.ProtoMember(6)]
        [global::System.ComponentModel.DefaultValue("")]
        public string Table2 { get; set; } = "";

        [global::ProtoBuf.ProtoMember(7)]
        public int Resource2 { get; set; }

        [global::ProtoBuf.ProtoMember(8)]
        public int Count2 { get; set; }

        [global::ProtoBuf.ProtoMember(9)]
        [global::System.ComponentModel.DefaultValue("")]
        public string Table3 { get; set; } = "";

        [global::ProtoBuf.ProtoMember(10)]
        public int Resource3 { get; set; }

        [global::ProtoBuf.ProtoMember(11)]
        public int Count3 { get; set; }

        [global::ProtoBuf.ProtoMember(12)]
        [global::System.ComponentModel.DefaultValue("")]
        public string Table4 { get; set; } = "";

        [global::ProtoBuf.ProtoMember(13)]
        public int Resource4 { get; set; }

        [global::ProtoBuf.ProtoMember(14)]
        public int Count4 { get; set; }

        [global::ProtoBuf.ProtoMember(15)]
        public int BuyCount { get; set; }

        [global::ProtoBuf.ProtoMember(16)]
        public int ActualPrice { get; set; }

        [global::ProtoBuf.ProtoMember(17)]
        public int ShowPrice { get; set; }

        [global::ProtoBuf.ProtoMember(18, Name = @"gold_desc")]
        public int GoldDesc { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ExplorePackTableConfigData : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public global::System.Collections.Generic.List<ExplorePackTableConfig> ConfigVo { get; } = new global::System.Collections.Generic.List<ExplorePackTableConfig>();

    }

}

#pragma warning restore CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#endregion
