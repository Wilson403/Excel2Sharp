// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: cycle_rank_manage_table.proto
// </auto-generated>

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace Hot.Generated
{

    [global::ProtoBuf.ProtoContract()]
    public partial class CycleRankManageTableConfig : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"id")]
        public int Id { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"note")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Note { get; set; } = "";

        [global::ProtoBuf.ProtoMember(3, Name = @"name")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Name { get; set; } = "";

        [global::ProtoBuf.ProtoMember(4, Name = @"server", IsPacked = true)]
        public global::System.Collections.Generic.List<int> Server { get; } = new global::System.Collections.Generic.List<int>();

        [global::ProtoBuf.ProtoMember(5, Name = @"loop_type")]
        public int LoopType { get; set; }

        [global::ProtoBuf.ProtoMember(6, Name = @"loop_start_time")]
        public long LoopStartTime { get; set; }

        [global::ProtoBuf.ProtoMember(7, Name = @"loop_end_time")]
        public long LoopEndTime { get; set; }

        [global::ProtoBuf.ProtoMember(8, Name = @"loop_index")]
        public int LoopIndex { get; set; }

        [global::ProtoBuf.ProtoMember(9, Name = @"open_time")]
        public int OpenTime { get; set; }

        [global::ProtoBuf.ProtoMember(10, Name = @"close_time")]
        public int CloseTime { get; set; }

        [global::ProtoBuf.ProtoMember(11, Name = @"level")]
        public int Level { get; set; }

        [global::ProtoBuf.ProtoMember(12, Name = @"img")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Img { get; set; } = "";

        [global::ProtoBuf.ProtoMember(13, Name = @"rank_type")]
        public int RankType { get; set; }

        [global::ProtoBuf.ProtoMember(14, Name = @"stay")]
        public int Stay { get; set; }

        [global::ProtoBuf.ProtoMember(15, Name = @"data_id")]
        public int DataId { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CycleRankManageTableConfigData : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public global::System.Collections.Generic.List<CycleRankManageTableConfig> ConfigVo { get; } = new global::System.Collections.Generic.List<CycleRankManageTableConfig>();

    }

}

#pragma warning restore CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#endregion
