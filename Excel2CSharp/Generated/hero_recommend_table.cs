// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: hero_recommend_table.proto
// </auto-generated>

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace Hot.Generated
{

    [global::ProtoBuf.ProtoContract()]
    public partial class HeroRecommendTableConfig : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"id")]
        public int Id { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"team_name")]
        [global::System.ComponentModel.DefaultValue("")]
        public string TeamName { get; set; } = "";

        [global::ProtoBuf.ProtoMember(3, Name = @"team_txt")]
        [global::System.ComponentModel.DefaultValue("")]
        public string TeamTxt { get; set; } = "";

        [global::ProtoBuf.ProtoMember(4, Name = @"hero_1")]
        public int Hero1 { get; set; }

        [global::ProtoBuf.ProtoMember(5, Name = @"hero_2")]
        public int Hero2 { get; set; }

        [global::ProtoBuf.ProtoMember(6, Name = @"hero_3")]
        public int Hero3 { get; set; }

        [global::ProtoBuf.ProtoMember(7, Name = @"hero_4")]
        public int Hero4 { get; set; }

        [global::ProtoBuf.ProtoMember(8, Name = @"hero_5")]
        public int Hero5 { get; set; }

        [global::ProtoBuf.ProtoMember(9, Name = @"hero_txt")]
        [global::System.ComponentModel.DefaultValue("")]
        public string HeroTxt { get; set; } = "";

        [global::ProtoBuf.ProtoMember(10, Name = @"pet_1")]
        public int Pet1 { get; set; }

        [global::ProtoBuf.ProtoMember(11, Name = @"pet_2")]
        public int Pet2 { get; set; }

        [global::ProtoBuf.ProtoMember(12, Name = @"pet_3")]
        public int Pet3 { get; set; }

        [global::ProtoBuf.ProtoMember(13, Name = @"pet_4")]
        public int Pet4 { get; set; }

        [global::ProtoBuf.ProtoMember(14, Name = @"pet_5")]
        public int Pet5 { get; set; }

        [global::ProtoBuf.ProtoMember(15, Name = @"pet_skill_1")]
        public int PetSkill1 { get; set; }

        [global::ProtoBuf.ProtoMember(16, Name = @"pet_skill_2")]
        public int PetSkill2 { get; set; }

        [global::ProtoBuf.ProtoMember(17, Name = @"pet_skill_3")]
        public int PetSkill3 { get; set; }

        [global::ProtoBuf.ProtoMember(18, Name = @"pet_txt")]
        [global::System.ComponentModel.DefaultValue("")]
        public string PetTxt { get; set; } = "";

        [global::ProtoBuf.ProtoMember(19, Name = @"mount_1")]
        public int Mount1 { get; set; }

        [global::ProtoBuf.ProtoMember(20, Name = @"mount_2")]
        public int Mount2 { get; set; }

        [global::ProtoBuf.ProtoMember(21, Name = @"mount_3")]
        public int Mount3 { get; set; }

        [global::ProtoBuf.ProtoMember(22, Name = @"mount_4")]
        public int Mount4 { get; set; }

        [global::ProtoBuf.ProtoMember(23, Name = @"mount_5")]
        public int Mount5 { get; set; }

        [global::ProtoBuf.ProtoMember(24, Name = @"mount_txt")]
        [global::System.ComponentModel.DefaultValue("")]
        public string MountTxt { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class HeroRecommendTableConfigData : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public global::System.Collections.Generic.List<HeroRecommendTableConfig> ConfigVo { get; } = new global::System.Collections.Generic.List<HeroRecommendTableConfig>();

    }

}

#pragma warning restore CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#endregion
