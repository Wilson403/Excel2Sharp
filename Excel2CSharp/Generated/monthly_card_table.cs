// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: monthly_card_table.proto

#pragma warning disable CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace Hot.Generated
{

    [global::ProtoBuf.ProtoContract()]
    public partial class MonthlyCardTableConfig : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"id")]
        public int Id { get; set; }

        [global::ProtoBuf.ProtoMember(2)]
        public int CardType { get; set; }

        [global::ProtoBuf.ProtoMember(3)]
        public int ExpiryDate { get; set; }

        [global::ProtoBuf.ProtoMember(4)]
        [global::System.ComponentModel.DefaultValue("")]
        public string RewardType1 { get; set; } = "";

        [global::ProtoBuf.ProtoMember(5)]
        public int RewardID1 { get; set; }

        [global::ProtoBuf.ProtoMember(6)]
        public int Value1 { get; set; }

        [global::ProtoBuf.ProtoMember(7)]
        [global::System.ComponentModel.DefaultValue("")]
        public string RewardType2 { get; set; } = "";

        [global::ProtoBuf.ProtoMember(8)]
        public int RewardID2 { get; set; }

        [global::ProtoBuf.ProtoMember(9)]
        public int Value2 { get; set; }

        [global::ProtoBuf.ProtoMember(10)]
        [global::System.ComponentModel.DefaultValue("")]
        public string DayRewardType1 { get; set; } = "";

        [global::ProtoBuf.ProtoMember(11)]
        public int DayRewardID1 { get; set; }

        [global::ProtoBuf.ProtoMember(12)]
        public int DayValue1 { get; set; }

        [global::ProtoBuf.ProtoMember(13)]
        public int Price { get; set; }

        [global::ProtoBuf.ProtoMember(14, Name = @"gold_desc")]
        public int GoldDesc { get; set; }

        [global::ProtoBuf.ProtoMember(15)]
        public int GardenShipBox { get; set; }

        [global::ProtoBuf.ProtoMember(16)]
        public int GardenShipPet { get; set; }

        [global::ProtoBuf.ProtoMember(17)]
        public int GardenFight { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MonthlyCardTableConfigData : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public global::System.Collections.Generic.List<MonthlyCardTableConfig> ConfigVoes { get; } = new global::System.Collections.Generic.List<MonthlyCardTableConfig>();

    }

}

#pragma warning restore CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
