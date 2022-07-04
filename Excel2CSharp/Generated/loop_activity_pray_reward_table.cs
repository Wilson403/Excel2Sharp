// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: loop_activity_pray_reward_table.proto

#pragma warning disable CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace Hot.Generated
{

    [global::ProtoBuf.ProtoContract()]
    public partial class LoopActivityPrayRewardTableConfig : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"id")]
        public int Id { get; set; }

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue("")]
        public string Note { get; set; } = "";

        [global::ProtoBuf.ProtoMember(3, Name = @"reward_pool_id")]
        public int RewardPoolId { get; set; }

        [global::ProtoBuf.ProtoMember(4)]
        public int Weight1 { get; set; }

        [global::ProtoBuf.ProtoMember(5, Name = @"data_id")]
        public int DataId { get; set; }

        [global::ProtoBuf.ProtoMember(6)]
        [global::System.ComponentModel.DefaultValue("")]
        public string CostType1 { get; set; } = "";

        [global::ProtoBuf.ProtoMember(7)]
        public int CostId1 { get; set; }

        [global::ProtoBuf.ProtoMember(8)]
        public int CostNum11 { get; set; }

        [global::ProtoBuf.ProtoMember(9)]
        public int CostNum12 { get; set; }

        [global::ProtoBuf.ProtoMember(10, Name = @"constant_type")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ConstantType { get; set; } = "";

        [global::ProtoBuf.ProtoMember(11, Name = @"constant_id")]
        public int ConstantId { get; set; }

        [global::ProtoBuf.ProtoMember(12, Name = @"constant_num")]
        public int ConstantNum { get; set; }

        [global::ProtoBuf.ProtoMember(13, Name = @"source_table1")]
        [global::System.ComponentModel.DefaultValue("")]
        public string SourceTable1 { get; set; } = "";

        [global::ProtoBuf.ProtoMember(14, Name = @"item_id1")]
        public int ItemId1 { get; set; }

        [global::ProtoBuf.ProtoMember(15, Name = @"item_nub1")]
        public int ItemNub1 { get; set; }

        [global::ProtoBuf.ProtoMember(16, Name = @"source_table2")]
        [global::System.ComponentModel.DefaultValue("")]
        public string SourceTable2 { get; set; } = "";

        [global::ProtoBuf.ProtoMember(17, Name = @"item_id2")]
        public int ItemId2 { get; set; }

        [global::ProtoBuf.ProtoMember(18, Name = @"item_nub2")]
        public int ItemNub2 { get; set; }

        [global::ProtoBuf.ProtoMember(19, Name = @"source_table3")]
        [global::System.ComponentModel.DefaultValue("")]
        public string SourceTable3 { get; set; } = "";

        [global::ProtoBuf.ProtoMember(20, Name = @"item_id3")]
        public int ItemId3 { get; set; }

        [global::ProtoBuf.ProtoMember(21, Name = @"item_nub3")]
        public int ItemNub3 { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class LoopActivityPrayRewardTableConfigData : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public global::System.Collections.Generic.List<LoopActivityPrayRewardTableConfig> ConfigVoes { get; } = new global::System.Collections.Generic.List<LoopActivityPrayRewardTableConfig>();

    }

}

#pragma warning restore CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
