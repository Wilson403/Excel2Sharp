// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: race_table.proto
// </auto-generated>

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace Hot.Generated
{

    [global::ProtoBuf.ProtoContract()]
    public partial class RaceTableConfig : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"id")]
        public int Id { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"name")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Name { get; set; } = "";

        [global::ProtoBuf.ProtoMember(3, Name = @"icon")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Icon { get; set; } = "";

        [global::ProtoBuf.ProtoMember(4)]
        [global::System.ComponentModel.DefaultValue("")]
        public string SkillName { get; set; } = "";

        [global::ProtoBuf.ProtoMember(5)]
        [global::System.ComponentModel.DefaultValue("")]
        public string SkillContent { get; set; } = "";

        [global::ProtoBuf.ProtoMember(6)]
        [global::System.ComponentModel.DefaultValue("")]
        public string SkillActiveContent { get; set; } = "";

        [global::ProtoBuf.ProtoMember(7)]
        [global::System.ComponentModel.DefaultValue("")]
        public string StarContent { get; set; } = "";

        [global::ProtoBuf.ProtoMember(8, Name = @"retina_icon")]
        [global::System.ComponentModel.DefaultValue("")]
        public string RetinaIcon { get; set; } = "";

        [global::ProtoBuf.ProtoMember(9, Name = @"herocount")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Herocount { get; set; } = "";

        [global::ProtoBuf.ProtoMember(10, Name = @"frame")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Frame { get; set; } = "";

        [global::ProtoBuf.ProtoMember(11, Name = @"hero_race")]
        [global::System.ComponentModel.DefaultValue("")]
        public string HeroRace { get; set; } = "";

        [global::ProtoBuf.ProtoMember(13, Name = @"against_lianbang")]
        public float AgainstLianbang { get; set; }

        [global::ProtoBuf.ProtoMember(14, Name = @"against_buluo")]
        public float AgainstBuluo { get; set; }

        [global::ProtoBuf.ProtoMember(15, Name = @"against_junlv")]
        public float AgainstJunlv { get; set; }

        [global::ProtoBuf.ProtoMember(16, Name = @"against_shengjie")]
        public float AgainstShengjie { get; set; }

        [global::ProtoBuf.ProtoMember(17, Name = @"against_yiyu")]
        public float AgainstYiyu { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class RaceTableConfigData : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public global::System.Collections.Generic.List<RaceTableConfig> ConfigVo { get; } = new global::System.Collections.Generic.List<RaceTableConfig>();

    }

}

#pragma warning restore CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#endregion