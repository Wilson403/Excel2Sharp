// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: arena_progress_reward_table.proto

#pragma warning disable CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace Hot.Generated
{

    [global::ProtoBuf.ProtoContract()]
    public partial class ArenaProgressRewardTableConfig : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"id")]
        public int Id { get; set; }

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue("")]
        public string Desc { get; set; } = "";

        [global::ProtoBuf.ProtoMember(3, Name = @"teamid")]
        public int Teamid { get; set; }

        [global::ProtoBuf.ProtoMember(4)]
        public int Level { get; set; }

        [global::ProtoBuf.ProtoMember(5, Name = @"condition")]
        public int Condition { get; set; }

        [global::ProtoBuf.ProtoMember(6)]
        [global::System.ComponentModel.DefaultValue("")]
        public string Table1 { get; set; } = "";

        [global::ProtoBuf.ProtoMember(7)]
        public int Item1 { get; set; }

        [global::ProtoBuf.ProtoMember(8, Name = @"num1")]
        public int Num1 { get; set; }

        [global::ProtoBuf.ProtoMember(9)]
        [global::System.ComponentModel.DefaultValue("")]
        public string Table2 { get; set; } = "";

        [global::ProtoBuf.ProtoMember(10)]
        public int Item2 { get; set; }

        [global::ProtoBuf.ProtoMember(11, Name = @"num2")]
        public int Num2 { get; set; }

        [global::ProtoBuf.ProtoMember(12)]
        [global::System.ComponentModel.DefaultValue("")]
        public string Table3 { get; set; } = "";

        [global::ProtoBuf.ProtoMember(13)]
        public int Item3 { get; set; }

        [global::ProtoBuf.ProtoMember(14, Name = @"num3")]
        public int Num3 { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ArenaProgressRewardTableConfigData : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public global::System.Collections.Generic.List<ArenaProgressRewardTableConfig> ConfigVoes { get; } = new global::System.Collections.Generic.List<ArenaProgressRewardTableConfig>();

    }

}

#pragma warning restore CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
