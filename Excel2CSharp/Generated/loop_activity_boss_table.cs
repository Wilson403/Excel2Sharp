// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: loop_activity_boss_table.proto
// </auto-generated>

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace Hot.Generated
{

    [global::ProtoBuf.ProtoContract()]
    public partial class LoopActivityBossTableConfig : global::ProtoBuf.IExtensible
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

        [global::ProtoBuf.ProtoMember(4, Name = @"data_id")]
        public int DataId { get; set; }

        [global::ProtoBuf.ProtoMember(5, Name = @"day_time")]
        public int DayTime { get; set; }

        [global::ProtoBuf.ProtoMember(6, Name = @"buy_time")]
        public int BuyTime { get; set; }

        [global::ProtoBuf.ProtoMember(7, Name = @"buy_price", IsPacked = true)]
        public global::System.Collections.Generic.List<int> BuyPrice { get; } = new global::System.Collections.Generic.List<int>();

        [global::ProtoBuf.ProtoMember(8)]
        public int Speed { get; set; }

        [global::ProtoBuf.ProtoMember(9)]
        public long MaxHp { get; set; }

        [global::ProtoBuf.ProtoMember(10)]
        public int Attack { get; set; }

        [global::ProtoBuf.ProtoMember(11)]
        public int PhysicDefense { get; set; }

        [global::ProtoBuf.ProtoMember(12)]
        public int Hit { get; set; }

        [global::ProtoBuf.ProtoMember(13)]
        public int Dodge { get; set; }

        [global::ProtoBuf.ProtoMember(14)]
        public int Crit { get; set; }

        [global::ProtoBuf.ProtoMember(15)]
        public int CritResist { get; set; }

        [global::ProtoBuf.ProtoMember(16, IsPacked = true)]
        public global::System.Collections.Generic.List<int> HeroList { get; } = new global::System.Collections.Generic.List<int>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class LoopActivityBossTableConfigData : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public global::System.Collections.Generic.List<LoopActivityBossTableConfig> ConfigVo { get; } = new global::System.Collections.Generic.List<LoopActivityBossTableConfig>();

    }

}

#pragma warning restore CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#endregion
