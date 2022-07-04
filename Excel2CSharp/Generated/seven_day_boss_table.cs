// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: seven_day_boss_table.proto

#pragma warning disable CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace Hot.Generated
{

    [global::ProtoBuf.ProtoContract()]
    public partial class SevenDayBossTableConfig : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"id")]
        public int Id { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"group")]
        public int Group { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"level")]
        public int Level { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"combat_recommend")]
        public int CombatRecommend { get; set; }

        [global::ProtoBuf.ProtoMember(5, Name = @"monster")]
        public int Monster { get; set; }

        [global::ProtoBuf.ProtoMember(6)]
        [global::System.ComponentModel.DefaultValue("")]
        public string RewardTable1 { get; set; } = "";

        [global::ProtoBuf.ProtoMember(7)]
        public int RewardId1 { get; set; }

        [global::ProtoBuf.ProtoMember(8)]
        public int RewardNum1 { get; set; }

        [global::ProtoBuf.ProtoMember(9)]
        [global::System.ComponentModel.DefaultValue("")]
        public string RewardTable2 { get; set; } = "";

        [global::ProtoBuf.ProtoMember(10)]
        public int RewardId2 { get; set; }

        [global::ProtoBuf.ProtoMember(11)]
        public int RewardNum2 { get; set; }

        [global::ProtoBuf.ProtoMember(12)]
        [global::System.ComponentModel.DefaultValue("")]
        public string RewardTable3 { get; set; } = "";

        [global::ProtoBuf.ProtoMember(13)]
        public int RewardId3 { get; set; }

        [global::ProtoBuf.ProtoMember(14)]
        public int RewardNum3 { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class SevenDayBossTableConfigData : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public global::System.Collections.Generic.List<SevenDayBossTableConfig> ConfigVoes { get; } = new global::System.Collections.Generic.List<SevenDayBossTableConfig>();

    }

}

#pragma warning restore CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
