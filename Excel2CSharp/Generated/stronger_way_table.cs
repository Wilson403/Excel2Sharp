// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: stronger_way_table.proto
// </auto-generated>

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace Hot.Generated
{

    [global::ProtoBuf.ProtoContract()]
    public partial class StrongerWayTableConfig : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"id")]
        public int Id { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"part_name")]
        [global::System.ComponentModel.DefaultValue("")]
        public string PartName { get; set; } = "";

        [global::ProtoBuf.ProtoMember(3, Name = @"part_icon")]
        [global::System.ComponentModel.DefaultValue("")]
        public string PartIcon { get; set; } = "";

        [global::ProtoBuf.ProtoMember(4, Name = @"part_inf")]
        [global::System.ComponentModel.DefaultValue("")]
        public string PartInf { get; set; } = "";

        [global::ProtoBuf.ProtoMember(5)]
        public int Goto { get; set; }

        [global::ProtoBuf.ProtoMember(6, Name = @"part_res_table1")]
        [global::System.ComponentModel.DefaultValue("")]
        public string PartResTable1 { get; set; } = "";

        [global::ProtoBuf.ProtoMember(7, Name = @"part_res_id1")]
        public int PartResId1 { get; set; }

        [global::ProtoBuf.ProtoMember(8, Name = @"part_res_table2")]
        [global::System.ComponentModel.DefaultValue("")]
        public string PartResTable2 { get; set; } = "";

        [global::ProtoBuf.ProtoMember(9, Name = @"part_res_id2")]
        public int PartResId2 { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class StrongerWayTableConfigData : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public global::System.Collections.Generic.List<StrongerWayTableConfig> ConfigVo { get; } = new global::System.Collections.Generic.List<StrongerWayTableConfig>();

    }

}

#pragma warning restore CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#endregion