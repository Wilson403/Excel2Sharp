// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: time_gift_table.proto
// </auto-generated>

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace Hot.Generated
{

    [global::ProtoBuf.ProtoContract()]
    public partial class TimeGiftTableConfig : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"id")]
        public int Id { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"TimeGift_name")]
        [global::System.ComponentModel.DefaultValue("")]
        public string TimeGiftname { get; set; } = "";

        [global::ProtoBuf.ProtoMember(3, Name = @"Gift_type")]
        public int Gifttype { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"group")]
        public int Group { get; set; }

        [global::ProtoBuf.ProtoMember(5, Name = @"grade")]
        public int Grade { get; set; }

        [global::ProtoBuf.ProtoMember(6, Name = @"icon1")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Icon1 { get; set; } = "";

        [global::ProtoBuf.ProtoMember(7, Name = @"icon2")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Icon2 { get; set; } = "";

        [global::ProtoBuf.ProtoMember(8, Name = @"icon3Url")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Icon3Url { get; set; } = "";

        [global::ProtoBuf.ProtoMember(9, Name = @"icon3")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Icon3 { get; set; } = "";

        [global::ProtoBuf.ProtoMember(10)]
        public int ShowText { get; set; }

        [global::ProtoBuf.ProtoMember(11)]
        [global::System.ComponentModel.DefaultValue("")]
        public string Table1 { get; set; } = "";

        [global::ProtoBuf.ProtoMember(12)]
        public int Resource1 { get; set; }

        [global::ProtoBuf.ProtoMember(13)]
        public int Count1 { get; set; }

        [global::ProtoBuf.ProtoMember(14)]
        [global::System.ComponentModel.DefaultValue("")]
        public string Table2 { get; set; } = "";

        [global::ProtoBuf.ProtoMember(15)]
        public int Resource2 { get; set; }

        [global::ProtoBuf.ProtoMember(16)]
        public int Count2 { get; set; }

        [global::ProtoBuf.ProtoMember(17)]
        [global::System.ComponentModel.DefaultValue("")]
        public string Table3 { get; set; } = "";

        [global::ProtoBuf.ProtoMember(18)]
        public int Resource3 { get; set; }

        [global::ProtoBuf.ProtoMember(19)]
        public int Count3 { get; set; }

        [global::ProtoBuf.ProtoMember(20)]
        [global::System.ComponentModel.DefaultValue("")]
        public string Table4 { get; set; } = "";

        [global::ProtoBuf.ProtoMember(21)]
        public int Resource4 { get; set; }

        [global::ProtoBuf.ProtoMember(22)]
        public int Count4 { get; set; }

        [global::ProtoBuf.ProtoMember(23)]
        [global::System.ComponentModel.DefaultValue("")]
        public string Table5 { get; set; } = "";

        [global::ProtoBuf.ProtoMember(24)]
        public int Resource5 { get; set; }

        [global::ProtoBuf.ProtoMember(25)]
        public int Count5 { get; set; }

        [global::ProtoBuf.ProtoMember(26, Name = @"gold_desc")]
        public int GoldDesc { get; set; }

        [global::ProtoBuf.ProtoMember(27, Name = @"dia_price")]
        public int DiaPrice { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class TimeGiftTableConfigData : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public global::System.Collections.Generic.List<TimeGiftTableConfig> ConfigVo { get; } = new global::System.Collections.Generic.List<TimeGiftTableConfig>();

    }

}

#pragma warning restore CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#endregion
