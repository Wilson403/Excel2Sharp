// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: monster_group_table.proto

#pragma warning disable CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace Hot.Generated
{

    [global::ProtoBuf.ProtoContract()]
    public partial class MonsterGroupTableConfig : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"id")]
        public int Id { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"scoredown")]
        public int Scoredown { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"scoreup")]
        public int Scoreup { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"modid")]
        public int Modid { get; set; }

        [global::ProtoBuf.ProtoMember(5)]
        [global::System.ComponentModel.DefaultValue("")]
        public string Note { get; set; } = "";

        [global::ProtoBuf.ProtoMember(6, Name = @"heromod1")]
        public int Heromod1 { get; set; }

        [global::ProtoBuf.ProtoMember(7, Name = @"heromod2")]
        public int Heromod2 { get; set; }

        [global::ProtoBuf.ProtoMember(8, Name = @"heromod3")]
        public int Heromod3 { get; set; }

        [global::ProtoBuf.ProtoMember(9, Name = @"heromod4")]
        public int Heromod4 { get; set; }

        [global::ProtoBuf.ProtoMember(10, Name = @"heromod5")]
        public int Heromod5 { get; set; }

        [global::ProtoBuf.ProtoMember(11, Name = @"monsterid1")]
        public int Monsterid1 { get; set; }

        [global::ProtoBuf.ProtoMember(12, Name = @"monsterid2")]
        public int Monsterid2 { get; set; }

        [global::ProtoBuf.ProtoMember(13, Name = @"monsterid3")]
        public int Monsterid3 { get; set; }

        [global::ProtoBuf.ProtoMember(14, Name = @"monsterid4")]
        public int Monsterid4 { get; set; }

        [global::ProtoBuf.ProtoMember(15, Name = @"monsterid5")]
        public int Monsterid5 { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MonsterGroupTableConfigData : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public global::System.Collections.Generic.List<MonsterGroupTableConfig> ConfigVoes { get; } = new global::System.Collections.Generic.List<MonsterGroupTableConfig>();

    }

}

#pragma warning restore CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
