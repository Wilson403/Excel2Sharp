// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: guildcopy_chapters_table.proto
// </auto-generated>

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace Hot.Generated
{

    [global::ProtoBuf.ProtoContract()]
    public partial class GuildcopyChaptersTableConfig : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"id")]
        public int Id { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"unlocklv")]
        public int Unlocklv { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"copyName")]
        [global::System.ComponentModel.DefaultValue("")]
        public string CopyName { get; set; } = "";

        [global::ProtoBuf.ProtoMember(4, Name = @"guard1_ID")]
        public int Guard1ID { get; set; }

        [global::ProtoBuf.ProtoMember(5, Name = @"guard1_reward")]
        public int Guard1Reward { get; set; }

        [global::ProtoBuf.ProtoMember(6, Name = @"guard2_ID")]
        public int Guard2ID { get; set; }

        [global::ProtoBuf.ProtoMember(7, Name = @"guard2_reward")]
        public int Guard2Reward { get; set; }

        [global::ProtoBuf.ProtoMember(8, Name = @"guard3_ID")]
        public int Guard3ID { get; set; }

        [global::ProtoBuf.ProtoMember(9, Name = @"guard3_reward")]
        public int Guard3Reward { get; set; }

        [global::ProtoBuf.ProtoMember(10, Name = @"guard4_ID")]
        public int Guard4ID { get; set; }

        [global::ProtoBuf.ProtoMember(11, Name = @"guard4_reward")]
        public int Guard4Reward { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class GuildcopyChaptersTableConfigData : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public global::System.Collections.Generic.List<GuildcopyChaptersTableConfig> ConfigVo { get; } = new global::System.Collections.Generic.List<GuildcopyChaptersTableConfig>();

    }

}

#pragma warning restore CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#endregion
