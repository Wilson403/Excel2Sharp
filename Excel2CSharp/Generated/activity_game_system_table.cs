// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: activity_game_system_table.proto

#pragma warning disable CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace Hot.Generated
{

    [global::ProtoBuf.ProtoContract()]
    public partial class ActivityGameSystemTableConfig : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"id")]
        public int Id { get; set; }

        [global::ProtoBuf.ProtoMember(2)]
        public int AllLimitBuy { get; set; }

        [global::ProtoBuf.ProtoMember(3)]
        public int PersonalLimitBuy { get; set; }

        [global::ProtoBuf.ProtoMember(4)]
        [global::System.ComponentModel.DefaultValue("")]
        public string BuyID1 { get; set; } = "";

        [global::ProtoBuf.ProtoMember(5)]
        [global::System.ComponentModel.DefaultValue("")]
        public string BuyTable1 { get; set; } = "";

        [global::ProtoBuf.ProtoMember(6)]
        public int BuyCount1 { get; set; }

        [global::ProtoBuf.ProtoMember(7)]
        [global::System.ComponentModel.DefaultValue("")]
        public string BuyID2 { get; set; } = "";

        [global::ProtoBuf.ProtoMember(8)]
        [global::System.ComponentModel.DefaultValue("")]
        public string BuyTable2 { get; set; } = "";

        [global::ProtoBuf.ProtoMember(9)]
        public int BuyCount2 { get; set; }

        [global::ProtoBuf.ProtoMember(10)]
        [global::System.ComponentModel.DefaultValue("")]
        public string BuyID3 { get; set; } = "";

        [global::ProtoBuf.ProtoMember(11)]
        [global::System.ComponentModel.DefaultValue("")]
        public string BuyTable3 { get; set; } = "";

        [global::ProtoBuf.ProtoMember(12)]
        public int BuyCount3 { get; set; }

        [global::ProtoBuf.ProtoMember(13)]
        [global::System.ComponentModel.DefaultValue("")]
        public string Name { get; set; } = "";

        [global::ProtoBuf.ProtoMember(14)]
        [global::System.ComponentModel.DefaultValue("")]
        public string Condition { get; set; } = "";

        [global::ProtoBuf.ProtoMember(15)]
        public int Value1 { get; set; }

        [global::ProtoBuf.ProtoMember(16)]
        public int Value2 { get; set; }

        [global::ProtoBuf.ProtoMember(17)]
        public int Goto { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ActivityGameSystemTableConfigData : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public global::System.Collections.Generic.List<ActivityGameSystemTableConfig> ConfigVoes { get; } = new global::System.Collections.Generic.List<ActivityGameSystemTableConfig>();

    }

}

#pragma warning restore CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
