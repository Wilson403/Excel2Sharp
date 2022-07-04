// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: gashapon_reward_table.proto

#pragma warning disable CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace Hot.Generated
{

    [global::ProtoBuf.ProtoContract()]
    public partial class GashaponRewardTableConfig : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"id")]
        public int Id { get; set; }

        [global::ProtoBuf.ProtoMember(2)]
        public int Level { get; set; }

        [global::ProtoBuf.ProtoMember(3)]
        [global::System.ComponentModel.DefaultValue("")]
        public string Image1 { get; set; } = "";

        [global::ProtoBuf.ProtoMember(4)]
        [global::System.ComponentModel.DefaultValue("")]
        public string Image2 { get; set; } = "";

        [global::ProtoBuf.ProtoMember(5)]
        [global::System.ComponentModel.DefaultValue("")]
        public string Image3 { get; set; } = "";

        [global::ProtoBuf.ProtoMember(6)]
        [global::System.ComponentModel.DefaultValue("")]
        public string Simage1 { get; set; } = "";

        [global::ProtoBuf.ProtoMember(7)]
        public int FloorsNum { get; set; }

        [global::ProtoBuf.ProtoMember(8)]
        public int FloorsNum2 { get; set; }

        [global::ProtoBuf.ProtoMember(9, Name = @"dia_limit")]
        public int DiaLimit { get; set; }

        [global::ProtoBuf.ProtoMember(10)]
        [global::System.ComponentModel.DefaultValue("")]
        public string CostType1 { get; set; } = "";

        [global::ProtoBuf.ProtoMember(11)]
        public int CostId1 { get; set; }

        [global::ProtoBuf.ProtoMember(12)]
        public int CostNum1 { get; set; }

        [global::ProtoBuf.ProtoMember(13)]
        public int CostNum12 { get; set; }

        [global::ProtoBuf.ProtoMember(14)]
        [global::System.ComponentModel.DefaultValue("")]
        public string CostType2 { get; set; } = "";

        [global::ProtoBuf.ProtoMember(15)]
        public int CostId2 { get; set; }

        [global::ProtoBuf.ProtoMember(16)]
        public int CostNum2 { get; set; }

        [global::ProtoBuf.ProtoMember(17)]
        public int CostNum22 { get; set; }

        [global::ProtoBuf.ProtoMember(18)]
        public int NormalPoolId { get; set; }

        [global::ProtoBuf.ProtoMember(19)]
        public int NormalPoolWeight { get; set; }

        [global::ProtoBuf.ProtoMember(20)]
        public int RarePool1 { get; set; }

        [global::ProtoBuf.ProtoMember(21)]
        public int RarePoolWeight1 { get; set; }

        [global::ProtoBuf.ProtoMember(22)]
        public int RarePool2 { get; set; }

        [global::ProtoBuf.ProtoMember(23)]
        public int RarePoolWeight2 { get; set; }

        [global::ProtoBuf.ProtoMember(24)]
        public int JackPot1 { get; set; }

        [global::ProtoBuf.ProtoMember(25)]
        public int JackPotWeight1 { get; set; }

        [global::ProtoBuf.ProtoMember(26)]
        public int JackPot2 { get; set; }

        [global::ProtoBuf.ProtoMember(27)]
        public int JackPotWeight2 { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class GashaponRewardTableConfigData : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public global::System.Collections.Generic.List<GashaponRewardTableConfig> ConfigVoes { get; } = new global::System.Collections.Generic.List<GashaponRewardTableConfig>();

    }

}

#pragma warning restore CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
