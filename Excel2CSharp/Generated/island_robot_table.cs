// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: island_robot_table.proto
// </auto-generated>

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace Hot.Generated
{

    [global::ProtoBuf.ProtoContract()]
    public partial class IslandRobotTableConfig : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"id")]
        public int Id { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"name")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Name { get; set; } = "";

        [global::ProtoBuf.ProtoMember(3, Name = @"lev")]
        public int Lev { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"head")]
        public int Head { get; set; }

        [global::ProtoBuf.ProtoMember(5, Name = @"pvp_score")]
        public int PvpScore { get; set; }

        [global::ProtoBuf.ProtoMember(6, Name = @"island_id1")]
        public int IslandId1 { get; set; }

        [global::ProtoBuf.ProtoMember(7)]
        public int EmptyProbability { get; set; }

        [global::ProtoBuf.ProtoMember(8)]
        public int EmptyMonster { get; set; }

        [global::ProtoBuf.ProtoMember(9, Name = @"island_id2")]
        public int IslandId2 { get; set; }

        [global::ProtoBuf.ProtoMember(10)]
        public int Island1Probability { get; set; }

        [global::ProtoBuf.ProtoMember(11)]
        public int Island1Monster { get; set; }

        [global::ProtoBuf.ProtoMember(12, Name = @"island_id3")]
        public int IslandId3 { get; set; }

        [global::ProtoBuf.ProtoMember(13)]
        public int Island2Probability { get; set; }

        [global::ProtoBuf.ProtoMember(14)]
        public int Island2Monster { get; set; }

        [global::ProtoBuf.ProtoMember(15, Name = @"island_id4")]
        public int IslandId4 { get; set; }

        [global::ProtoBuf.ProtoMember(16)]
        public int Island3Probability { get; set; }

        [global::ProtoBuf.ProtoMember(17)]
        public int Island3Monster { get; set; }

        [global::ProtoBuf.ProtoMember(18)]
        public int DisplayTeam { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class IslandRobotTableConfigData : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public global::System.Collections.Generic.List<IslandRobotTableConfig> ConfigVo { get; } = new global::System.Collections.Generic.List<IslandRobotTableConfig>();

    }

}

#pragma warning restore CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#endregion
