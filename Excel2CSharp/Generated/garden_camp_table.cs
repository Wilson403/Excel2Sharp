// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: garden_camp_table.proto

#pragma warning disable CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace Hot.Generated
{

    [global::ProtoBuf.ProtoContract()]
    public partial class GardenCampTableConfig : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"id")]
        public int Id { get; set; }

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue("")]
        public string CampName { get; set; } = "";

        [global::ProtoBuf.ProtoMember(3, Name = @"campattribute")]
        public int Campattribute { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"camptype")]
        public int Camptype { get; set; }

        [global::ProtoBuf.ProtoMember(5, Name = @"camplevel")]
        public int Camplevel { get; set; }

        [global::ProtoBuf.ProtoMember(6)]
        public int SlotPetType1 { get; set; }

        [global::ProtoBuf.ProtoMember(7)]
        public int SlotPetType2 { get; set; }

        [global::ProtoBuf.ProtoMember(8)]
        public int SlotPetType3 { get; set; }

        [global::ProtoBuf.ProtoMember(9)]
        [global::System.ComponentModel.DefaultValue("")]
        public string Reward1Table { get; set; } = "";

        [global::ProtoBuf.ProtoMember(10)]
        public int Reward1ID { get; set; }

        [global::ProtoBuf.ProtoMember(11)]
        public int Reward1Num { get; set; }

        [global::ProtoBuf.ProtoMember(12)]
        [global::System.ComponentModel.DefaultValue("")]
        public string Reward2Table { get; set; } = "";

        [global::ProtoBuf.ProtoMember(13)]
        public int Reward2ID { get; set; }

        [global::ProtoBuf.ProtoMember(14)]
        public int Reward2Num1Slot { get; set; }

        [global::ProtoBuf.ProtoMember(15)]
        public int Reward2Num2Slot { get; set; }

        [global::ProtoBuf.ProtoMember(16)]
        public int Reward2Num3Slot { get; set; }

        [global::ProtoBuf.ProtoMember(17)]
        public int LevelItemID { get; set; }

        [global::ProtoBuf.ProtoMember(18)]
        public int LevelItemNum { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class GardenCampTableConfigData : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public global::System.Collections.Generic.List<GardenCampTableConfig> ConfigVoes { get; } = new global::System.Collections.Generic.List<GardenCampTableConfig>();

    }

}

#pragma warning restore CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
