// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: player_title_privilege_table.proto
// </auto-generated>

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace Hot.Generated
{

    [global::ProtoBuf.ProtoContract()]
    public partial class PlayerTitlePrivilegeTableConfig : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"id")]
        public int Id { get; set; }

        [global::ProtoBuf.ProtoMember(2)]
        public int Idlegold { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"needexp1")]
        public int Needexp1 { get; set; }

        [global::ProtoBuf.ProtoMember(4)]
        public int Idleheroexp { get; set; }

        [global::ProtoBuf.ProtoMember(5, Name = @"needexp2")]
        public int Needexp2 { get; set; }

        [global::ProtoBuf.ProtoMember(6)]
        public int Idlenum { get; set; }

        [global::ProtoBuf.ProtoMember(7, Name = @"needexp3")]
        public int Needexp3 { get; set; }

        [global::ProtoBuf.ProtoMember(8)]
        public int Idlepvp { get; set; }

        [global::ProtoBuf.ProtoMember(9, Name = @"needexp4")]
        public int Needexp4 { get; set; }

        [global::ProtoBuf.ProtoMember(10)]
        public int Buypvp { get; set; }

        [global::ProtoBuf.ProtoMember(11, Name = @"needexp5")]
        public int Needexp5 { get; set; }

        [global::ProtoBuf.ProtoMember(12)]
        public int HeroBag { get; set; }

        [global::ProtoBuf.ProtoMember(13, Name = @"needexp6")]
        public int Needexp6 { get; set; }

        [global::ProtoBuf.ProtoMember(14)]
        public int TaskQuest { get; set; }

        [global::ProtoBuf.ProtoMember(15, Name = @"needexp7")]
        public int Needexp7 { get; set; }

        [global::ProtoBuf.ProtoMember(16)]
        public int MazeGold { get; set; }

        [global::ProtoBuf.ProtoMember(17, Name = @"needexp8")]
        public int Needexp8 { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class PlayerTitlePrivilegeTableConfigData : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public global::System.Collections.Generic.List<PlayerTitlePrivilegeTableConfig> ConfigVo { get; } = new global::System.Collections.Generic.List<PlayerTitlePrivilegeTableConfig>();

    }

}

#pragma warning restore CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#endregion