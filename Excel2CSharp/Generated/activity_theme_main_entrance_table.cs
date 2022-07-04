// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: activity_theme_main_entrance_table.proto

#pragma warning disable CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace Hot.Generated
{

    [global::ProtoBuf.ProtoContract()]
    public partial class ActivityThemeMainEntranceTableConfig : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"id")]
        public int Id { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"opentime")]
        public int Opentime { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"duration")]
        public int Duration { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"accounts_way")]
        public int AccountsWay { get; set; }

        [global::ProtoBuf.ProtoMember(5, Name = @"theme")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Theme { get; set; } = "";

        [global::ProtoBuf.ProtoMember(6, Name = @"prefabs")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Prefabs { get; set; } = "";

        [global::ProtoBuf.ProtoMember(7, Name = @"bg_image")]
        [global::System.ComponentModel.DefaultValue("")]
        public string BgImage { get; set; } = "";

        [global::ProtoBuf.ProtoMember(8, Name = @"title_image")]
        [global::System.ComponentModel.DefaultValue("")]
        public string TitleImage { get; set; } = "";

        [global::ProtoBuf.ProtoMember(9, Name = @"round_nub")]
        [global::System.ComponentModel.DefaultValue("")]
        public string RoundNub { get; set; } = "";

        [global::ProtoBuf.ProtoMember(10, Name = @"entrance_1")]
        public int Entrance1 { get; set; }

        [global::ProtoBuf.ProtoMember(11, Name = @"entrance_1duration")]
        public int Entrance1duration { get; set; }

        [global::ProtoBuf.ProtoMember(12, Name = @"entrance_1image")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Entrance1image { get; set; } = "";

        [global::ProtoBuf.ProtoMember(13, Name = @"entrance_2")]
        public int Entrance2 { get; set; }

        [global::ProtoBuf.ProtoMember(14, Name = @"entrance_2duration")]
        public int Entrance2duration { get; set; }

        [global::ProtoBuf.ProtoMember(15, Name = @"entrance_2image")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Entrance2image { get; set; } = "";

        [global::ProtoBuf.ProtoMember(16, Name = @"entrance_3")]
        public int Entrance3 { get; set; }

        [global::ProtoBuf.ProtoMember(17, Name = @"entrance_3duration")]
        public int Entrance3duration { get; set; }

        [global::ProtoBuf.ProtoMember(18, Name = @"entrance_3image")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Entrance3image { get; set; } = "";

        [global::ProtoBuf.ProtoMember(19, Name = @"entrance_4")]
        public int Entrance4 { get; set; }

        [global::ProtoBuf.ProtoMember(20, Name = @"entrance_4duration")]
        public int Entrance4duration { get; set; }

        [global::ProtoBuf.ProtoMember(21, Name = @"entrance_4image")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Entrance4image { get; set; } = "";

        [global::ProtoBuf.ProtoMember(22, Name = @"entrance_5")]
        public int Entrance5 { get; set; }

        [global::ProtoBuf.ProtoMember(23, Name = @"entrance_5duration")]
        public int Entrance5duration { get; set; }

        [global::ProtoBuf.ProtoMember(24, Name = @"entrance_5image")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Entrance5image { get; set; } = "";

        [global::ProtoBuf.ProtoMember(25, Name = @"entrance_6")]
        public int Entrance6 { get; set; }

        [global::ProtoBuf.ProtoMember(26, Name = @"entrance_6duration")]
        public int Entrance6duration { get; set; }

        [global::ProtoBuf.ProtoMember(27, Name = @"entrance_6image")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Entrance6image { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ActivityThemeMainEntranceTableConfigData : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public global::System.Collections.Generic.List<ActivityThemeMainEntranceTableConfig> ConfigVoes { get; } = new global::System.Collections.Generic.List<ActivityThemeMainEntranceTableConfig>();

    }

}

#pragma warning restore CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
