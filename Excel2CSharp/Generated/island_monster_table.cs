// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: island_monster_table.proto
// </auto-generated>

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace Hot.Generated
{

    [global::ProtoBuf.ProtoContract()]
    public partial class IslandMonsterTableConfig : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"id")]
        public int Id { get; set; }

        [global::ProtoBuf.ProtoMember(2)]
        public int TeamId { get; set; }

        [global::ProtoBuf.ProtoMember(3)]
        public int MonsterTeam { get; set; }

        [global::ProtoBuf.ProtoMember(4)]
        public int UnlockDayLow { get; set; }

        [global::ProtoBuf.ProtoMember(5)]
        public int UnlockDayUp { get; set; }

        [global::ProtoBuf.ProtoMember(6)]
        public int IslandResLow { get; set; }

        [global::ProtoBuf.ProtoMember(7)]
        public int IslandResUp { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class IslandMonsterTableConfigData : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public global::System.Collections.Generic.List<IslandMonsterTableConfig> ConfigVo { get; } = new global::System.Collections.Generic.List<IslandMonsterTableConfig>();

    }

}

#pragma warning restore CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#endregion
