// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: heros_glow_u_table.proto

#pragma warning disable CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace Hot.Generated
{

    [global::ProtoBuf.ProtoContract()]
    public partial class HerosGlowUTableConfig : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"id")]
        public int Id { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"Heros_Level_d")]
        public int HerosLeveld { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"Heros_Level_u")]
        public int HerosLevelu { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"MaxHp_Co")]
        public int MaxHpCo { get; set; }

        [global::ProtoBuf.ProtoMember(5, Name = @"Attack_Co")]
        public int AttackCo { get; set; }

        [global::ProtoBuf.ProtoMember(6, Name = @"PhysicDefense_Co")]
        public int PhysicDefenseCo { get; set; }

        [global::ProtoBuf.ProtoMember(7, Name = @"Hit_Co")]
        public int HitCo { get; set; }

        [global::ProtoBuf.ProtoMember(8, Name = @"Dodge_Co")]
        public int DodgeCo { get; set; }

        [global::ProtoBuf.ProtoMember(9, Name = @"Crit_Co")]
        public int CritCo { get; set; }

        [global::ProtoBuf.ProtoMember(10, Name = @"CritResist_Co")]
        public int CritResistCo { get; set; }

        [global::ProtoBuf.ProtoMember(11, Name = @"Power_co")]
        public int Powerco { get; set; }

        [global::ProtoBuf.ProtoMember(12, Name = @"Stepup_co")]
        public int Stepupco { get; set; }

        [global::ProtoBuf.ProtoMember(13, Name = @"StepupPower_co")]
        public int StepupPowerco { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class HerosGlowUTableConfigData : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public global::System.Collections.Generic.List<HerosGlowUTableConfig> ConfigVoes { get; } = new global::System.Collections.Generic.List<HerosGlowUTableConfig>();

    }

}

#pragma warning restore CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
