// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: explore_level_table.proto
// </auto-generated>

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace Hot.Generated
{

    [global::ProtoBuf.ProtoContract()]
    public partial class ExploreLevelTableConfig : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"id")]
        public int Id { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"explore_level")]
        public int ExploreLevel { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"unlock_level")]
        public int UnlockLevel { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"explore_describe1")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ExploreDescribe1 { get; set; } = "";

        [global::ProtoBuf.ProtoMember(5, Name = @"explore_describe2")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ExploreDescribe2 { get; set; } = "";

        [global::ProtoBuf.ProtoMember(6, Name = @"empty_event")]
        [global::System.ComponentModel.DefaultValue("")]
        public string EmptyEvent { get; set; } = "";

        [global::ProtoBuf.ProtoMember(7, Name = @"empty_event_num")]
        public int EmptyEventNum { get; set; }

        [global::ProtoBuf.ProtoMember(8, Name = @"empty_event_weight")]
        public int EmptyEventWeight { get; set; }

        [global::ProtoBuf.ProtoMember(9, Name = @"seller_event")]
        [global::System.ComponentModel.DefaultValue("")]
        public string SellerEvent { get; set; } = "";

        [global::ProtoBuf.ProtoMember(10, Name = @"seller_event_num")]
        public int SellerEventNum { get; set; }

        [global::ProtoBuf.ProtoMember(11, Name = @"seller_event_weight")]
        public int SellerEventWeight { get; set; }

        [global::ProtoBuf.ProtoMember(12, Name = @"random_event")]
        [global::System.ComponentModel.DefaultValue("")]
        public string RandomEvent { get; set; } = "";

        [global::ProtoBuf.ProtoMember(13, Name = @"random_event_num")]
        public int RandomEventNum { get; set; }

        [global::ProtoBuf.ProtoMember(14, Name = @"random_event_weight")]
        public int RandomEventWeight { get; set; }

        [global::ProtoBuf.ProtoMember(15, Name = @"reward_event1")]
        [global::System.ComponentModel.DefaultValue("")]
        public string RewardEvent1 { get; set; } = "";

        [global::ProtoBuf.ProtoMember(16, Name = @"reward_event1_num")]
        public int RewardEvent1Num { get; set; }

        [global::ProtoBuf.ProtoMember(17, Name = @"reward_event1_weight")]
        public int RewardEvent1Weight { get; set; }

        [global::ProtoBuf.ProtoMember(18, Name = @"reward_event2")]
        [global::System.ComponentModel.DefaultValue("")]
        public string RewardEvent2 { get; set; } = "";

        [global::ProtoBuf.ProtoMember(19, Name = @"reward_event2_num")]
        public int RewardEvent2Num { get; set; }

        [global::ProtoBuf.ProtoMember(20, Name = @"reward_event2_weight")]
        public int RewardEvent2Weight { get; set; }

        [global::ProtoBuf.ProtoMember(21, Name = @"reward_event3")]
        [global::System.ComponentModel.DefaultValue("")]
        public string RewardEvent3 { get; set; } = "";

        [global::ProtoBuf.ProtoMember(22, Name = @"reward_event3_num")]
        public int RewardEvent3Num { get; set; }

        [global::ProtoBuf.ProtoMember(23, Name = @"reward_event3_weight")]
        public int RewardEvent3Weight { get; set; }

        [global::ProtoBuf.ProtoMember(24, Name = @"reward_event4")]
        [global::System.ComponentModel.DefaultValue("")]
        public string RewardEvent4 { get; set; } = "";

        [global::ProtoBuf.ProtoMember(25, Name = @"reward_event4_num")]
        public int RewardEvent4Num { get; set; }

        [global::ProtoBuf.ProtoMember(26, Name = @"reward_event4_weight")]
        public int RewardEvent4Weight { get; set; }

        [global::ProtoBuf.ProtoMember(27, Name = @"reward_event5")]
        [global::System.ComponentModel.DefaultValue("")]
        public string RewardEvent5 { get; set; } = "";

        [global::ProtoBuf.ProtoMember(28, Name = @"reward_event5_num")]
        public int RewardEvent5Num { get; set; }

        [global::ProtoBuf.ProtoMember(29, Name = @"reward_event5_weight")]
        public int RewardEvent5Weight { get; set; }

        [global::ProtoBuf.ProtoMember(30, Name = @"reward_event6")]
        [global::System.ComponentModel.DefaultValue("")]
        public string RewardEvent6 { get; set; } = "";

        [global::ProtoBuf.ProtoMember(31, Name = @"reward_event6_num")]
        public int RewardEvent6Num { get; set; }

        [global::ProtoBuf.ProtoMember(32, Name = @"reward_event6_weight")]
        public int RewardEvent6Weight { get; set; }

        [global::ProtoBuf.ProtoMember(33, Name = @"reward_event7")]
        [global::System.ComponentModel.DefaultValue("")]
        public string RewardEvent7 { get; set; } = "";

        [global::ProtoBuf.ProtoMember(34, Name = @"reward_event7_num")]
        public int RewardEvent7Num { get; set; }

        [global::ProtoBuf.ProtoMember(35, Name = @"reward_event7_weight")]
        public int RewardEvent7Weight { get; set; }

        [global::ProtoBuf.ProtoMember(36, Name = @"reward_event8")]
        [global::System.ComponentModel.DefaultValue("")]
        public string RewardEvent8 { get; set; } = "";

        [global::ProtoBuf.ProtoMember(37, Name = @"reward_event8_num")]
        public int RewardEvent8Num { get; set; }

        [global::ProtoBuf.ProtoMember(38, Name = @"reward_event8_weight")]
        public int RewardEvent8Weight { get; set; }

        [global::ProtoBuf.ProtoMember(39, Name = @"chest_event1")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ChestEvent1 { get; set; } = "";

        [global::ProtoBuf.ProtoMember(40, Name = @"chest_type1")]
        public int ChestType1 { get; set; }

        [global::ProtoBuf.ProtoMember(41, Name = @"chest_num1")]
        public int ChestNum1 { get; set; }

        [global::ProtoBuf.ProtoMember(42, Name = @"chest_event1_weight")]
        public int ChestEvent1Weight { get; set; }

        [global::ProtoBuf.ProtoMember(43, Name = @"chest_event2")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ChestEvent2 { get; set; } = "";

        [global::ProtoBuf.ProtoMember(44, Name = @"chest_type2")]
        public int ChestType2 { get; set; }

        [global::ProtoBuf.ProtoMember(45, Name = @"chest_num2")]
        public int ChestNum2 { get; set; }

        [global::ProtoBuf.ProtoMember(46, Name = @"chest_event2_weight")]
        public int ChestEvent2Weight { get; set; }

        [global::ProtoBuf.ProtoMember(47, Name = @"chest_event3")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ChestEvent3 { get; set; } = "";

        [global::ProtoBuf.ProtoMember(48, Name = @"chest_type3")]
        public int ChestType3 { get; set; }

        [global::ProtoBuf.ProtoMember(49, Name = @"chest_num3")]
        public int ChestNum3 { get; set; }

        [global::ProtoBuf.ProtoMember(50, Name = @"chest_event3_weight")]
        public int ChestEvent3Weight { get; set; }

        [global::ProtoBuf.ProtoMember(51, Name = @"chest_event4")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ChestEvent4 { get; set; } = "";

        [global::ProtoBuf.ProtoMember(52, Name = @"chest_type4")]
        public int ChestType4 { get; set; }

        [global::ProtoBuf.ProtoMember(53, Name = @"chest_num4")]
        public int ChestNum4 { get; set; }

        [global::ProtoBuf.ProtoMember(54, Name = @"chest_event4_weight")]
        public int ChestEvent4Weight { get; set; }

        [global::ProtoBuf.ProtoMember(55, Name = @"mysterious_shop")]
        [global::System.ComponentModel.DefaultValue("")]
        public string MysteriousShop { get; set; } = "";

        [global::ProtoBuf.ProtoMember(56, Name = @"mysterious_shop_num")]
        public int MysteriousShopNum { get; set; }

        [global::ProtoBuf.ProtoMember(57, Name = @"mysterious_shop_weight")]
        public int MysteriousShopWeight { get; set; }

        [global::ProtoBuf.ProtoMember(58, Name = @"double_point_event")]
        [global::System.ComponentModel.DefaultValue("")]
        public string DoublePointEvent { get; set; } = "";

        [global::ProtoBuf.ProtoMember(59, Name = @"double_point_num")]
        public int DoublePointNum { get; set; }

        [global::ProtoBuf.ProtoMember(60, Name = @"double_point_weight")]
        public int DoublePointWeight { get; set; }

        [global::ProtoBuf.ProtoMember(61, Name = @"add_point")]
        [global::System.ComponentModel.DefaultValue("")]
        public string AddPoint { get; set; } = "";

        [global::ProtoBuf.ProtoMember(62, Name = @"add_point_num")]
        public int AddPointNum { get; set; }

        [global::ProtoBuf.ProtoMember(63, Name = @"add_point_weight")]
        public int AddPointWeight { get; set; }

        [global::ProtoBuf.ProtoMember(64, Name = @"special_event")]
        [global::System.ComponentModel.DefaultValue("")]
        public string SpecialEvent { get; set; } = "";

        [global::ProtoBuf.ProtoMember(65, Name = @"special_event_num")]
        public int SpecialEventNum { get; set; }

        [global::ProtoBuf.ProtoMember(66, Name = @"special_event_weight")]
        public int SpecialEventWeight { get; set; }

        [global::ProtoBuf.ProtoMember(67, Name = @"explore_exp")]
        public int ExploreExp { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ExploreLevelTableConfigData : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public global::System.Collections.Generic.List<ExploreLevelTableConfig> ConfigVo { get; } = new global::System.Collections.Generic.List<ExploreLevelTableConfig>();

    }

}

#pragma warning restore CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#endregion
