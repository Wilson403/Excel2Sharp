// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: loop_activity_world_boss_reward_table.proto

#pragma warning disable CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace Hot.Generated
{

    [global::ProtoBuf.ProtoContract()]
    public partial class LoopActivityWorldBossRewardTableConfig : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"id")]
        public int Id { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"data_id")]
        public int DataId { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"damge_low")]
        public long DamgeLow { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"damge_top")]
        public long DamgeTop { get; set; }

        [global::ProtoBuf.ProtoMember(5, Name = @"reaward_type1")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ReawardType1 { get; set; } = "";

        [global::ProtoBuf.ProtoMember(6, Name = @"reward_id1")]
        public int RewardId1 { get; set; }

        [global::ProtoBuf.ProtoMember(7)]
        public int UpLimit1 { get; set; }

        [global::ProtoBuf.ProtoMember(8)]
        public int DownLimit1 { get; set; }

        [global::ProtoBuf.ProtoMember(9, Name = @"reaward_type2")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ReawardType2 { get; set; } = "";

        [global::ProtoBuf.ProtoMember(10, Name = @"reward_id2")]
        public int RewardId2 { get; set; }

        [global::ProtoBuf.ProtoMember(11)]
        public int UpLimit2 { get; set; }

        [global::ProtoBuf.ProtoMember(12)]
        public int DownLimit2 { get; set; }

        [global::ProtoBuf.ProtoMember(13, Name = @"reaward_type3")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ReawardType3 { get; set; } = "";

        [global::ProtoBuf.ProtoMember(14, Name = @"reward_id3")]
        public int RewardId3 { get; set; }

        [global::ProtoBuf.ProtoMember(15)]
        public int UpLimit3 { get; set; }

        [global::ProtoBuf.ProtoMember(16)]
        public int DownLimit3 { get; set; }

        [global::ProtoBuf.ProtoMember(17, Name = @"reaward_type4")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ReawardType4 { get; set; } = "";

        [global::ProtoBuf.ProtoMember(18, Name = @"reward_id4")]
        public int RewardId4 { get; set; }

        [global::ProtoBuf.ProtoMember(19)]
        public int UpLimit4 { get; set; }

        [global::ProtoBuf.ProtoMember(20)]
        public int DownLimit4 { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class LoopActivityWorldBossRewardTableConfigData : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public global::System.Collections.Generic.List<LoopActivityWorldBossRewardTableConfig> ConfigVoes { get; } = new global::System.Collections.Generic.List<LoopActivityWorldBossRewardTableConfig>();

    }

}

#pragma warning restore CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
