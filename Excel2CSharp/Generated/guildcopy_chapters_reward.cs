// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: guildcopy_chapters_reward.proto

#pragma warning disable CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace Hot.Generated
{

    [global::ProtoBuf.ProtoContract()]
    public partial class GuildcopyChaptersRewardConfig : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"id")]
        public int Id { get; set; }

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue("")]
        public string Name { get; set; } = "";

        [global::ProtoBuf.ProtoMember(3, Name = @"resource1")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Resource1 { get; set; } = "";

        [global::ProtoBuf.ProtoMember(4, Name = @"reward1")]
        public int Reward1 { get; set; }

        [global::ProtoBuf.ProtoMember(5, Name = @"num1")]
        public int Num1 { get; set; }

        [global::ProtoBuf.ProtoMember(6, Name = @"resource2")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Resource2 { get; set; } = "";

        [global::ProtoBuf.ProtoMember(7, Name = @"reward2")]
        public int Reward2 { get; set; }

        [global::ProtoBuf.ProtoMember(8, Name = @"num2")]
        public int Num2 { get; set; }

        [global::ProtoBuf.ProtoMember(9, Name = @"resource3")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Resource3 { get; set; } = "";

        [global::ProtoBuf.ProtoMember(10, Name = @"reward3")]
        public int Reward3 { get; set; }

        [global::ProtoBuf.ProtoMember(11, Name = @"num3")]
        public int Num3 { get; set; }

        [global::ProtoBuf.ProtoMember(12, Name = @"resource4")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Resource4 { get; set; } = "";

        [global::ProtoBuf.ProtoMember(13, Name = @"reward4")]
        public int Reward4 { get; set; }

        [global::ProtoBuf.ProtoMember(14, Name = @"num4")]
        public int Num4 { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class GuildcopyChaptersRewardConfigData : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public global::System.Collections.Generic.List<GuildcopyChaptersRewardConfig> ConfigVoes { get; } = new global::System.Collections.Generic.List<GuildcopyChaptersRewardConfig>();

    }

}

#pragma warning restore CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
