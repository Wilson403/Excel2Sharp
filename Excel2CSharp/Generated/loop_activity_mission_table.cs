// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: loop_activity_mission_table.proto
// </auto-generated>

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace Hot.Generated
{

    [global::ProtoBuf.ProtoContract()]
    public partial class LoopActivityMissionTableConfig : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"id")]
        public int Id { get; set; }

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue("")]
        public string Note { get; set; } = "";

        [global::ProtoBuf.ProtoMember(3)]
        [global::System.ComponentModel.DefaultValue("")]
        public string BannerImg { get; set; } = "";

        [global::ProtoBuf.ProtoMember(4, Name = @"time_type")]
        public int TimeType { get; set; }

        [global::ProtoBuf.ProtoMember(5, Name = @"loop_time_id")]
        public int LoopTimeId { get; set; }

        [global::ProtoBuf.ProtoMember(6, Name = @"data_arr_id")]
        public int DataArrId { get; set; }

        [global::ProtoBuf.ProtoMember(7)]
        [global::System.ComponentModel.DefaultValue("")]
        public string Name { get; set; } = "";

        [global::ProtoBuf.ProtoMember(8)]
        public int FrontTask { get; set; }

        [global::ProtoBuf.ProtoMember(9)]
        public int NextTask { get; set; }

        [global::ProtoBuf.ProtoMember(10)]
        [global::System.ComponentModel.DefaultValue("")]
        public string Type { get; set; } = "";

        [global::ProtoBuf.ProtoMember(11)]
        [global::System.ComponentModel.DefaultValue("")]
        public string Condition { get; set; } = "";

        [global::ProtoBuf.ProtoMember(12)]
        public int IsPaid { get; set; }

        [global::ProtoBuf.ProtoMember(13)]
        public int Price { get; set; }

        [global::ProtoBuf.ProtoMember(14)]
        public int Value1 { get; set; }

        [global::ProtoBuf.ProtoMember(15)]
        public int Value2 { get; set; }

        [global::ProtoBuf.ProtoMember(16)]
        [global::System.ComponentModel.DefaultValue("")]
        public string RewardType1 { get; set; } = "";

        [global::ProtoBuf.ProtoMember(17)]
        public int RewardID1 { get; set; }

        [global::ProtoBuf.ProtoMember(18)]
        public int RewardNum1 { get; set; }

        [global::ProtoBuf.ProtoMember(19)]
        [global::System.ComponentModel.DefaultValue("")]
        public string RewardType2 { get; set; } = "";

        [global::ProtoBuf.ProtoMember(20)]
        public int RewardID2 { get; set; }

        [global::ProtoBuf.ProtoMember(21)]
        public int RewardNum2 { get; set; }

        [global::ProtoBuf.ProtoMember(22)]
        [global::System.ComponentModel.DefaultValue("")]
        public string RewardType3 { get; set; } = "";

        [global::ProtoBuf.ProtoMember(23)]
        public int RewardID3 { get; set; }

        [global::ProtoBuf.ProtoMember(24)]
        public int RewardNum3 { get; set; }

        [global::ProtoBuf.ProtoMember(25)]
        [global::System.ComponentModel.DefaultValue("")]
        public string RewardType4 { get; set; } = "";

        [global::ProtoBuf.ProtoMember(26)]
        public int RewardID4 { get; set; }

        [global::ProtoBuf.ProtoMember(27)]
        public int RewardNum4 { get; set; }

        [global::ProtoBuf.ProtoMember(28)]
        public int Goto { get; set; }

        [global::ProtoBuf.ProtoMember(29, Name = @"rule")]
        public int Rule { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class LoopActivityMissionTableConfigData : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public global::System.Collections.Generic.List<LoopActivityMissionTableConfig> ConfigVo { get; } = new global::System.Collections.Generic.List<LoopActivityMissionTableConfig>();

    }

}

#pragma warning restore CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#endregion
