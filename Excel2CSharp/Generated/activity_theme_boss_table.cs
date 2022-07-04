// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: activity_theme_boss_table.proto

#pragma warning disable CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace Hot.Generated
{

    [global::ProtoBuf.ProtoContract()]
    public partial class ActivityThemeBossTableConfig : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"id")]
        public int Id { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"name")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Name { get; set; } = "";

        [global::ProtoBuf.ProtoMember(3, Name = @"model")]
        public int Model { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"round")]
        public int Round { get; set; }

        [global::ProtoBuf.ProtoMember(5)]
        public int Speed { get; set; }

        [global::ProtoBuf.ProtoMember(6)]
        public long MaxHp { get; set; }

        [global::ProtoBuf.ProtoMember(7)]
        public int Attack { get; set; }

        [global::ProtoBuf.ProtoMember(8)]
        public int PhysicDefense { get; set; }

        [global::ProtoBuf.ProtoMember(9)]
        public int Hit { get; set; }

        [global::ProtoBuf.ProtoMember(10)]
        public int Dodge { get; set; }

        [global::ProtoBuf.ProtoMember(11)]
        public int Crit { get; set; }

        [global::ProtoBuf.ProtoMember(12)]
        public int CritResist { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ActivityThemeBossTableConfigData : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public global::System.Collections.Generic.List<ActivityThemeBossTableConfig> ConfigVoes { get; } = new global::System.Collections.Generic.List<ActivityThemeBossTableConfig>();

    }

}

#pragma warning restore CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
