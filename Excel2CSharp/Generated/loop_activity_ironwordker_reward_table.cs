// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: loop_activity_ironwordker_reward_table.proto

#pragma warning disable CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace Hot.Generated
{

    [global::ProtoBuf.ProtoContract()]
    public partial class LoopActivityIronwordkerRewardTableConfig : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"id")]
        public int Id { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"reward_type")]
        public int RewardType { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"data_id")]
        public int DataId { get; set; }

        [global::ProtoBuf.ProtoMember(4)]
        [global::System.ComponentModel.DefaultValue("")]
        public string CostType1 { get; set; } = "";

        [global::ProtoBuf.ProtoMember(5)]
        public int CostId1 { get; set; }

        [global::ProtoBuf.ProtoMember(6)]
        public int CostNum11 { get; set; }

        [global::ProtoBuf.ProtoMember(7)]
        public int CostNum12 { get; set; }

        [global::ProtoBuf.ProtoMember(8, Name = @"constant_type")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ConstantType { get; set; } = "";

        [global::ProtoBuf.ProtoMember(9, Name = @"constant_id")]
        public int ConstantId { get; set; }

        [global::ProtoBuf.ProtoMember(10, Name = @"constant_num")]
        public int ConstantNum { get; set; }

        [global::ProtoBuf.ProtoMember(11, Name = @"jackpot_limit", IsPacked = true)]
        public int[] JackpotLimits { get; set; }

        [global::ProtoBuf.ProtoMember(12)]
        [global::System.ComponentModel.DefaultValue("")]
        public string RewardTable1 { get; set; } = "";

        [global::ProtoBuf.ProtoMember(13)]
        public int RewardID1 { get; set; }

        [global::ProtoBuf.ProtoMember(14)]
        public int RewardNum1 { get; set; }

        [global::ProtoBuf.ProtoMember(15, Name = @"weight1")]
        public int Weight1 { get; set; }

        [global::ProtoBuf.ProtoMember(16)]
        [global::System.ComponentModel.DefaultValue("")]
        public string RewardTable2 { get; set; } = "";

        [global::ProtoBuf.ProtoMember(17)]
        public int RewardID2 { get; set; }

        [global::ProtoBuf.ProtoMember(18)]
        public int RewardNum2 { get; set; }

        [global::ProtoBuf.ProtoMember(19, Name = @"weight2")]
        public int Weight2 { get; set; }

        [global::ProtoBuf.ProtoMember(20)]
        [global::System.ComponentModel.DefaultValue("")]
        public string RewardTable3 { get; set; } = "";

        [global::ProtoBuf.ProtoMember(21)]
        public int RewardID3 { get; set; }

        [global::ProtoBuf.ProtoMember(22)]
        public int RewardNum3 { get; set; }

        [global::ProtoBuf.ProtoMember(23, Name = @"weight3")]
        public int Weight3 { get; set; }

        [global::ProtoBuf.ProtoMember(24)]
        [global::System.ComponentModel.DefaultValue("")]
        public string RewardTable4 { get; set; } = "";

        [global::ProtoBuf.ProtoMember(25)]
        public int RewardID4 { get; set; }

        [global::ProtoBuf.ProtoMember(26)]
        public int RewardNum4 { get; set; }

        [global::ProtoBuf.ProtoMember(27, Name = @"weight4")]
        public int Weight4 { get; set; }

        [global::ProtoBuf.ProtoMember(28)]
        [global::System.ComponentModel.DefaultValue("")]
        public string RewardTable5 { get; set; } = "";

        [global::ProtoBuf.ProtoMember(29)]
        public int RewardID5 { get; set; }

        [global::ProtoBuf.ProtoMember(30)]
        public int RewardNum5 { get; set; }

        [global::ProtoBuf.ProtoMember(31, Name = @"weight5")]
        public int Weight5 { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class LoopActivityIronwordkerRewardTableConfigData : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public global::System.Collections.Generic.List<LoopActivityIronwordkerRewardTableConfig> ConfigVoes { get; } = new global::System.Collections.Generic.List<LoopActivityIronwordkerRewardTableConfig>();

    }

}

#pragma warning restore CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
