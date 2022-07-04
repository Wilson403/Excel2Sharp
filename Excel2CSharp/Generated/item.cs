// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: item.proto
// </auto-generated>

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace Hot.Generated
{

    [global::ProtoBuf.ProtoContract()]
    public partial class ItemConfig : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"id")]
        public int Id { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"note")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Note { get; set; } = "";

        [global::ProtoBuf.ProtoMember(3)]
        [global::System.ComponentModel.DefaultValue("")]
        public string Name { get; set; } = "";

        [global::ProtoBuf.ProtoMember(4)]
        [global::System.ComponentModel.DefaultValue("")]
        public string Icon { get; set; } = "";

        [global::ProtoBuf.ProtoMember(5)]
        [global::System.ComponentModel.DefaultValue("")]
        public string Desc { get; set; } = "";

        [global::ProtoBuf.ProtoMember(6)]
        public int Type { get; set; }

        [global::ProtoBuf.ProtoMember(7)]
        public int SubType { get; set; }

        [global::ProtoBuf.ProtoMember(8)]
        public int Quality { get; set; }

        [global::ProtoBuf.ProtoMember(9)]
        public int Price { get; set; }

        [global::ProtoBuf.ProtoMember(10)]
        public int CellMax { get; set; }

        [global::ProtoBuf.ProtoMember(11)]
        public int Sexp { get; set; }

        [global::ProtoBuf.ProtoMember(12, Name = @"eqp_index")]
        public int EqpIndex { get; set; }

        [global::ProtoBuf.ProtoMember(13)]
        public int Value1 { get; set; }

        [global::ProtoBuf.ProtoMember(14)]
        public int Value2 { get; set; }

        [global::ProtoBuf.ProtoMember(15)]
        public int Value3 { get; set; }

        [global::ProtoBuf.ProtoMember(16)]
        public int Value4 { get; set; }

        [global::ProtoBuf.ProtoMember(17)]
        public int Value5 { get; set; }

        [global::ProtoBuf.ProtoMember(18)]
        public int Value6 { get; set; }

        [global::ProtoBuf.ProtoMember(19)]
        public int Value7 { get; set; }

        [global::ProtoBuf.ProtoMember(20)]
        public int Value8 { get; set; }

        [global::ProtoBuf.ProtoMember(21)]
        public int Value9 { get; set; }

        [global::ProtoBuf.ProtoMember(22)]
        public int Value10 { get; set; }

        [global::ProtoBuf.ProtoMember(23)]
        public int Value11 { get; set; }

        [global::ProtoBuf.ProtoMember(24)]
        public int Value12 { get; set; }

        [global::ProtoBuf.ProtoMember(25)]
        public int Value13 { get; set; }

        [global::ProtoBuf.ProtoMember(26)]
        public int Value14 { get; set; }

        [global::ProtoBuf.ProtoMember(27)]
        public int Value15 { get; set; }

        [global::ProtoBuf.ProtoMember(28)]
        public int Value16 { get; set; }

        [global::ProtoBuf.ProtoMember(29)]
        public int Value17 { get; set; }

        [global::ProtoBuf.ProtoMember(30, Name = @"ways", IsPacked = true)]
        public global::System.Collections.Generic.List<int> Ways { get; } = new global::System.Collections.Generic.List<int>();

        [global::ProtoBuf.ProtoMember(31, Name = @"fx_switch")]
        public int FxSwitch { get; set; }

        [global::ProtoBuf.ProtoMember(32, Name = @"bag_way", IsPacked = true)]
        public global::System.Collections.Generic.List<int> BagWay { get; } = new global::System.Collections.Generic.List<int>();

        [global::ProtoBuf.ProtoMember(33, Name = @"shop_way", IsPacked = true)]
        public global::System.Collections.Generic.List<int> ShopWay { get; } = new global::System.Collections.Generic.List<int>();

        [global::ProtoBuf.ProtoMember(34, Name = @"guild_show_way", IsPacked = true)]
        public global::System.Collections.Generic.List<int> GuildShowWay { get; } = new global::System.Collections.Generic.List<int>();

        [global::ProtoBuf.ProtoMember(35, Name = @"soul_shop_way", IsPacked = true)]
        public global::System.Collections.Generic.List<int> SoulShopWay { get; } = new global::System.Collections.Generic.List<int>();

        [global::ProtoBuf.ProtoMember(36, Name = @"maze_shop_way", IsPacked = true)]
        public global::System.Collections.Generic.List<int> MazeShopWay { get; } = new global::System.Collections.Generic.List<int>();

        [global::ProtoBuf.ProtoMember(37, Name = @"garden_shop_way", IsPacked = true)]
        public global::System.Collections.Generic.List<int> GardenShopWay { get; } = new global::System.Collections.Generic.List<int>();

        [global::ProtoBuf.ProtoMember(38, Name = @"daily_gift_way", IsPacked = true)]
        public global::System.Collections.Generic.List<int> DailyGiftWay { get; } = new global::System.Collections.Generic.List<int>();

        [global::ProtoBuf.ProtoMember(39, Name = @"Island_gift_way", IsPacked = true)]
        public global::System.Collections.Generic.List<int> Islandgiftway { get; } = new global::System.Collections.Generic.List<int>();

        [global::ProtoBuf.ProtoMember(40, Name = @"soul_item_way", IsPacked = true)]
        public global::System.Collections.Generic.List<int> SoulItemWay { get; } = new global::System.Collections.Generic.List<int>();

        [global::ProtoBuf.ProtoMember(41, Name = @"bonfire_way", IsPacked = true)]
        public global::System.Collections.Generic.List<int> BonfireWay { get; } = new global::System.Collections.Generic.List<int>();

        [global::ProtoBuf.ProtoMember(42, Name = @"mount_way", IsPacked = true)]
        public global::System.Collections.Generic.List<int> MountWay { get; } = new global::System.Collections.Generic.List<int>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ItemConfigData : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public global::System.Collections.Generic.List<ItemConfig> ConfigVo { get; } = new global::System.Collections.Generic.List<ItemConfig>();

    }

}

#pragma warning restore CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#endregion