// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: unlock_tower_table.proto
// </auto-generated>

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace Hot.Generated
{

    [global::ProtoBuf.ProtoContract()]
    public partial class UnlockTowerTableConfig : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"id")]
        public int Id { get; set; }

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue("")]
        public string Name { get; set; } = "";

        [global::ProtoBuf.ProtoMember(3)]
        public int Level { get; set; }

        [global::ProtoBuf.ProtoMember(4)]
        public int RewardLimit { get; set; }

        [global::ProtoBuf.ProtoMember(5, Name = @"openplay")]
        public int Openplay { get; set; }

        [global::ProtoBuf.ProtoMember(6, Name = @"sceneName")]
        [global::System.ComponentModel.DefaultValue("")]
        public string SceneName { get; set; } = "";

        [global::ProtoBuf.ProtoMember(7)]
        public int IsMondayOn { get; set; }

        [global::ProtoBuf.ProtoMember(8)]
        public int IsTuesdayOn { get; set; }

        [global::ProtoBuf.ProtoMember(9)]
        public int IsWensdayOn { get; set; }

        [global::ProtoBuf.ProtoMember(10)]
        public int IsThurdayOn { get; set; }

        [global::ProtoBuf.ProtoMember(11)]
        public int IsFridayOn { get; set; }

        [global::ProtoBuf.ProtoMember(12)]
        public int IsSaturdayOn { get; set; }

        [global::ProtoBuf.ProtoMember(13)]
        public int IsSundayOn { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class UnlockTowerTableConfigData : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public global::System.Collections.Generic.List<UnlockTowerTableConfig> ConfigVo { get; } = new global::System.Collections.Generic.List<UnlockTowerTableConfig>();

    }

}

#pragma warning restore CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#endregion
