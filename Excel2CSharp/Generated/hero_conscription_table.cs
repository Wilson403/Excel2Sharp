// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: hero_conscription_table.proto

#pragma warning disable CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace Hot.Generated
{

    [global::ProtoBuf.ProtoContract()]
    public partial class HeroConscriptionTableConfig : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"id")]
        public int Id { get; set; }

        [global::ProtoBuf.ProtoMember(2)]
        public int Level { get; set; }

        [global::ProtoBuf.ProtoMember(3)]
        public int DataId { get; set; }

        [global::ProtoBuf.ProtoMember(4)]
        public int FloorsNum { get; set; }

        [global::ProtoBuf.ProtoMember(5, Name = @"dia_limit")]
        public int DiaLimit { get; set; }

        [global::ProtoBuf.ProtoMember(6)]
        public int WeightUp { get; set; }

        [global::ProtoBuf.ProtoMember(7)]
        [global::System.ComponentModel.DefaultValue("")]
        public string CostType1 { get; set; } = "";

        [global::ProtoBuf.ProtoMember(8)]
        public int CostId1 { get; set; }

        [global::ProtoBuf.ProtoMember(9)]
        public int CostNum1 { get; set; }

        [global::ProtoBuf.ProtoMember(10)]
        public int CostNum12 { get; set; }

        [global::ProtoBuf.ProtoMember(11)]
        [global::System.ComponentModel.DefaultValue("")]
        public string CostType2 { get; set; } = "";

        [global::ProtoBuf.ProtoMember(12)]
        public int CostId2 { get; set; }

        [global::ProtoBuf.ProtoMember(13)]
        public int CostNum2 { get; set; }

        [global::ProtoBuf.ProtoMember(14)]
        public int CostNum22 { get; set; }

        [global::ProtoBuf.ProtoMember(15)]
        public int NormalPoolId { get; set; }

        [global::ProtoBuf.ProtoMember(16)]
        public int HeroPoolID { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class HeroConscriptionTableConfigData : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public global::System.Collections.Generic.List<HeroConscriptionTableConfig> ConfigVoes { get; } = new global::System.Collections.Generic.List<HeroConscriptionTableConfig>();

    }

}

#pragma warning restore CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
