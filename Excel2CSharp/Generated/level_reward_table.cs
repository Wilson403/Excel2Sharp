// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: level_reward_table.proto

#pragma warning disable CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace Hot.Generated
{

    [global::ProtoBuf.ProtoContract()]
    public partial class LevelRewardTableConfig : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"id")]
        public int Id { get; set; }

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue("")]
        public string Table1 { get; set; } = "";

        [global::ProtoBuf.ProtoMember(3)]
        public int itemID { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"note")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Note { get; set; } = "";

        [global::ProtoBuf.ProtoMember(5)]
        public int rewardsPoints { get; set; }

        [global::ProtoBuf.ProtoMember(6)]
        public int basicSpeed { get; set; }

        [global::ProtoBuf.ProtoMember(7)]
        public int speedsType { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class LevelRewardTableConfigData : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public global::System.Collections.Generic.List<LevelRewardTableConfig> ConfigVoes { get; } = new global::System.Collections.Generic.List<LevelRewardTableConfig>();

    }

}

#pragma warning restore CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
