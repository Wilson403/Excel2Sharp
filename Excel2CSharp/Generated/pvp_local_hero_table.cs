// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: pvp_local_hero_table.proto

#pragma warning disable CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace Hot.Generated
{

    [global::ProtoBuf.ProtoContract()]
    public partial class PvpLocalHeroTableConfig : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"id")]
        public int Id { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"pvp_team")]
        public int PvpTeam { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"heros_mod")]
        public int HerosMod { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"heros_attack")]
        public int HerosAttack { get; set; }

        [global::ProtoBuf.ProtoMember(5, Name = @"heros_def")]
        public int HerosDef { get; set; }

        [global::ProtoBuf.ProtoMember(6, Name = @"heros_hp")]
        public int HerosHp { get; set; }

        [global::ProtoBuf.ProtoMember(7, Name = @"heros_hit")]
        public int HerosHit { get; set; }

        [global::ProtoBuf.ProtoMember(8, Name = @"heros_dodge")]
        public int HerosDodge { get; set; }

        [global::ProtoBuf.ProtoMember(9, Name = @"heros_crt")]
        public int HerosCrt { get; set; }

        [global::ProtoBuf.ProtoMember(10, Name = @"heros_critresist")]
        public int HerosCritresist { get; set; }

        [global::ProtoBuf.ProtoMember(11, Name = @"heros_attinc")]
        public int HerosAttinc { get; set; }

        [global::ProtoBuf.ProtoMember(12, Name = @"heros_attresist")]
        public int HerosAttresist { get; set; }

        [global::ProtoBuf.ProtoMember(13, Name = @"heros_power")]
        public int HerosPower { get; set; }

        [global::ProtoBuf.ProtoMember(14, Name = @"heros_level")]
        public int HerosLevel { get; set; }

        [global::ProtoBuf.ProtoMember(15, Name = @"heros_quality")]
        public int HerosQuality { get; set; }

        [global::ProtoBuf.ProtoMember(16, Name = @"heros_equip_slot1")]
        public int HerosEquipSlot1 { get; set; }

        [global::ProtoBuf.ProtoMember(17, Name = @"heros_equip_lv1")]
        public int HerosEquipLv1 { get; set; }

        [global::ProtoBuf.ProtoMember(18, Name = @"heros_equip_slot2")]
        public int HerosEquipSlot2 { get; set; }

        [global::ProtoBuf.ProtoMember(19, Name = @"heros_equip_lv2")]
        public int HerosEquipLv2 { get; set; }

        [global::ProtoBuf.ProtoMember(20, Name = @"heros_equip_slot3")]
        public int HerosEquipSlot3 { get; set; }

        [global::ProtoBuf.ProtoMember(21, Name = @"heros_equip_lv3")]
        public int HerosEquipLv3 { get; set; }

        [global::ProtoBuf.ProtoMember(22, Name = @"heros_equip_slot4")]
        public int HerosEquipSlot4 { get; set; }

        [global::ProtoBuf.ProtoMember(23, Name = @"heros_equip_lv4")]
        public int HerosEquipLv4 { get; set; }

        [global::ProtoBuf.ProtoMember(24, Name = @"pet_id")]
        public int PetId { get; set; }

        [global::ProtoBuf.ProtoMember(25, Name = @"pet_star_lv")]
        public int PetStarLv { get; set; }

        [global::ProtoBuf.ProtoMember(26, Name = @"pet_adva_lv")]
        public int PetAdvaLv { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class PvpLocalHeroTableConfigData : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public global::System.Collections.Generic.List<PvpLocalHeroTableConfig> ConfigVoes { get; } = new global::System.Collections.Generic.List<PvpLocalHeroTableConfig>();

    }

}

#pragma warning restore CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
