// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: explore_turns_reward_table.proto
// </auto-generated>

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace Hot.Generated
{

    [global::ProtoBuf.ProtoContract()]
    public partial class ExploreTurnsRewardTableConfig : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"id")]
        public int Id { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"turns_top")]
        public int TurnsTop { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"turns_low")]
        public int TurnsLow { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"turns_point")]
        public int TurnsPoint { get; set; }

        [global::ProtoBuf.ProtoMember(5, Name = @"turns_reward_type1")]
        [global::System.ComponentModel.DefaultValue("")]
        public string TurnsRewardType1 { get; set; } = "";

        [global::ProtoBuf.ProtoMember(6, Name = @"turns_reward_id1")]
        public int TurnsRewardId1 { get; set; }

        [global::ProtoBuf.ProtoMember(7, Name = @"turns_reward_num1")]
        public int TurnsRewardNum1 { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ExploreTurnsRewardTableConfigData : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public global::System.Collections.Generic.List<ExploreTurnsRewardTableConfig> ConfigVo { get; } = new global::System.Collections.Generic.List<ExploreTurnsRewardTableConfig>();

    }

}

#pragma warning restore CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#endregion
