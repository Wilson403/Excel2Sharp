// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: pet_stars_v2_table.proto
// </auto-generated>

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace Hot.Generated
{

    [global::ProtoBuf.ProtoContract()]
    public partial class PetStarsV2TableConfig : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"id")]
        public int Id { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"pet_id")]
        public int PetId { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"soul_lv")]
        public int SoulLv { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"star")]
        public int Star { get; set; }

        [global::ProtoBuf.ProtoMember(5, Name = @"item_costs", IsPacked = true)]
        public global::System.Collections.Generic.List<int> ItemCosts { get; } = new global::System.Collections.Generic.List<int>();

        [global::ProtoBuf.ProtoMember(6, Name = @"stone_cost")]
        public int StoneCost { get; set; }

        [global::ProtoBuf.ProtoMember(7, Name = @"star_hp")]
        public int StarHp { get; set; }

        [global::ProtoBuf.ProtoMember(8, Name = @"star_attack")]
        public int StarAttack { get; set; }

        [global::ProtoBuf.ProtoMember(9, Name = @"star_def")]
        public int StarDef { get; set; }

        [global::ProtoBuf.ProtoMember(10, Name = @"skill_id")]
        public int SkillId { get; set; }

        [global::ProtoBuf.ProtoMember(11, Name = @"entry_numb")]
        public int EntryNumb { get; set; }

        [global::ProtoBuf.ProtoMember(12, Name = @"entry_default1")]
        public int EntryDefault1 { get; set; }

        [global::ProtoBuf.ProtoMember(13, Name = @"entry1_value")]
        public int Entry1Value { get; set; }

        [global::ProtoBuf.ProtoMember(14, Name = @"entry1_point")]
        public int Entry1Point { get; set; }

        [global::ProtoBuf.ProtoMember(15, Name = @"entry_default2")]
        public int EntryDefault2 { get; set; }

        [global::ProtoBuf.ProtoMember(16, Name = @"entry2_value")]
        public int Entry2Value { get; set; }

        [global::ProtoBuf.ProtoMember(17, Name = @"entry2_point")]
        public int Entry2Point { get; set; }

        [global::ProtoBuf.ProtoMember(18, Name = @"entry_default3")]
        public int EntryDefault3 { get; set; }

        [global::ProtoBuf.ProtoMember(19, Name = @"entry3_value")]
        public int Entry3Value { get; set; }

        [global::ProtoBuf.ProtoMember(20, Name = @"entry3_point")]
        public int Entry3Point { get; set; }

        [global::ProtoBuf.ProtoMember(21, Name = @"entry_default4")]
        public int EntryDefault4 { get; set; }

        [global::ProtoBuf.ProtoMember(22, Name = @"entry4_value")]
        public int Entry4Value { get; set; }

        [global::ProtoBuf.ProtoMember(23, Name = @"entry4_point")]
        public int Entry4Point { get; set; }

        [global::ProtoBuf.ProtoMember(24, Name = @"entry_default5")]
        public int EntryDefault5 { get; set; }

        [global::ProtoBuf.ProtoMember(25, Name = @"entry5_value")]
        public int Entry5Value { get; set; }

        [global::ProtoBuf.ProtoMember(26, Name = @"entry5_point")]
        public int Entry5Point { get; set; }

        [global::ProtoBuf.ProtoMember(27, Name = @"star_point")]
        public int StarPoint { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class PetStarsV2TableConfigData : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public global::System.Collections.Generic.List<PetStarsV2TableConfig> ConfigVo { get; } = new global::System.Collections.Generic.List<PetStarsV2TableConfig>();

    }

}

#pragma warning restore CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#endregion
