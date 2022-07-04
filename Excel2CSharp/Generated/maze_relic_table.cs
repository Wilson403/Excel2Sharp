// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: maze_relic_table.proto

#pragma warning disable CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace Hot.Generated
{

    [global::ProtoBuf.ProtoContract()]
    public partial class MazeRelicTableConfig : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"id")]
        public int Id { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"note")]
        public int Note { get; set; }

        [global::ProtoBuf.ProtoMember(3)]
        [global::System.ComponentModel.DefaultValue("")]
        public string relicName { get; set; } = "";

        [global::ProtoBuf.ProtoMember(4)]
        [global::System.ComponentModel.DefaultValue("")]
        public string relicPic { get; set; } = "";

        [global::ProtoBuf.ProtoMember(5)]
        [global::System.ComponentModel.DefaultValue("")]
        public string relicDes { get; set; } = "";

        [global::ProtoBuf.ProtoMember(6)]
        public int relicAtt { get; set; }

        [global::ProtoBuf.ProtoMember(7, Name = @"quality")]
        public int Quality { get; set; }

        [global::ProtoBuf.ProtoMember(8)]
        public int buffType { get; set; }

        [global::ProtoBuf.ProtoMember(9)]
        public int buffSubtype { get; set; }

        [global::ProtoBuf.ProtoMember(10, Name = @"value1")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Value1 { get; set; } = "";

        [global::ProtoBuf.ProtoMember(11, Name = @"value2")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Value2 { get; set; } = "";

        [global::ProtoBuf.ProtoMember(12, Name = @"value3")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Value3 { get; set; } = "";

        [global::ProtoBuf.ProtoMember(13, Name = @"value4")]
        public int Value4 { get; set; }

        [global::ProtoBuf.ProtoMember(14, Name = @"value5")]
        public int Value5 { get; set; }

        [global::ProtoBuf.ProtoMember(15, Name = @"value6")]
        public int Value6 { get; set; }

        [global::ProtoBuf.ProtoMember(16, Name = @"race")]
        public int Race { get; set; }

        [global::ProtoBuf.ProtoMember(17, Name = @"duty")]
        public int Duty { get; set; }

        [global::ProtoBuf.ProtoMember(18, Name = @"power")]
        public int Power { get; set; }

        [global::ProtoBuf.ProtoMember(19, Name = @"superpose_type")]
        public int SuperposeType { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MazeRelicTableConfigData : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public global::System.Collections.Generic.List<MazeRelicTableConfig> ConfigVoes { get; } = new global::System.Collections.Generic.List<MazeRelicTableConfig>();

    }

}

#pragma warning restore CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
