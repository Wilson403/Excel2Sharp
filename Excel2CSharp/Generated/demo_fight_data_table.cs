// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: demo_fight_data_table.proto
// </auto-generated>

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace Hot.Generated
{

    [global::ProtoBuf.ProtoContract()]
    public partial class DemoFightDataTableConfig : global::ProtoBuf.IExtensible
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
        public int Atlas { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"my_model_id1")]
        public int MyModelId1 { get; set; }

        [global::ProtoBuf.ProtoMember(5, Name = @"my_monster_id1")]
        public int MyMonsterId1 { get; set; }

        [global::ProtoBuf.ProtoMember(6, Name = @"dead1")]
        public int Dead1 { get; set; }

        [global::ProtoBuf.ProtoMember(7, Name = @"my_model_id2")]
        public int MyModelId2 { get; set; }

        [global::ProtoBuf.ProtoMember(8, Name = @"my_monster_id2")]
        public int MyMonsterId2 { get; set; }

        [global::ProtoBuf.ProtoMember(9, Name = @"dead2")]
        public int Dead2 { get; set; }

        [global::ProtoBuf.ProtoMember(10, Name = @"my_model_id3")]
        public int MyModelId3 { get; set; }

        [global::ProtoBuf.ProtoMember(11, Name = @"my_monster_id3")]
        public int MyMonsterId3 { get; set; }

        [global::ProtoBuf.ProtoMember(12, Name = @"dead3")]
        public int Dead3 { get; set; }

        [global::ProtoBuf.ProtoMember(13, Name = @"my_model_id4")]
        public int MyModelId4 { get; set; }

        [global::ProtoBuf.ProtoMember(14, Name = @"my_monster_id4")]
        public int MyMonsterId4 { get; set; }

        [global::ProtoBuf.ProtoMember(15, Name = @"dead4")]
        public int Dead4 { get; set; }

        [global::ProtoBuf.ProtoMember(16, Name = @"my_model_id5")]
        public int MyModelId5 { get; set; }

        [global::ProtoBuf.ProtoMember(17, Name = @"my_monster_id5")]
        public int MyMonsterId5 { get; set; }

        [global::ProtoBuf.ProtoMember(18, Name = @"dead5")]
        public int Dead5 { get; set; }

        [global::ProtoBuf.ProtoMember(19, Name = @"my_pet_skill1")]
        public int MyPetSkill1 { get; set; }

        [global::ProtoBuf.ProtoMember(20, Name = @"my_pet_skill2")]
        public int MyPetSkill2 { get; set; }

        [global::ProtoBuf.ProtoMember(21, Name = @"my_pet_skill3")]
        public int MyPetSkill3 { get; set; }

        [global::ProtoBuf.ProtoMember(22, Name = @"en_model_id1")]
        public int EnModelId1 { get; set; }

        [global::ProtoBuf.ProtoMember(23, Name = @"en_monster_id1")]
        public int EnMonsterId1 { get; set; }

        [global::ProtoBuf.ProtoMember(24, Name = @"en_model_id2")]
        public int EnModelId2 { get; set; }

        [global::ProtoBuf.ProtoMember(25, Name = @"en_monster_id2")]
        public int EnMonsterId2 { get; set; }

        [global::ProtoBuf.ProtoMember(26, Name = @"en_model_id3")]
        public int EnModelId3 { get; set; }

        [global::ProtoBuf.ProtoMember(27, Name = @"en_monster_id3")]
        public int EnMonsterId3 { get; set; }

        [global::ProtoBuf.ProtoMember(28, Name = @"en_model_id4")]
        public int EnModelId4 { get; set; }

        [global::ProtoBuf.ProtoMember(29, Name = @"en_monster_id4")]
        public int EnMonsterId4 { get; set; }

        [global::ProtoBuf.ProtoMember(30, Name = @"en_model_id5")]
        public int EnModelId5 { get; set; }

        [global::ProtoBuf.ProtoMember(31, Name = @"en_monster_id5")]
        public int EnMonsterId5 { get; set; }

        [global::ProtoBuf.ProtoMember(32, Name = @"en_pet_skill1")]
        public int EnPetSkill1 { get; set; }

        [global::ProtoBuf.ProtoMember(33, Name = @"en_pet_skill2")]
        public int EnPetSkill2 { get; set; }

        [global::ProtoBuf.ProtoMember(34, Name = @"en_pet_skill3")]
        public int EnPetSkill3 { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class DemoFightDataTableConfigData : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public global::System.Collections.Generic.List<DemoFightDataTableConfig> ConfigVo { get; } = new global::System.Collections.Generic.List<DemoFightDataTableConfig>();

    }

}

#pragma warning restore CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#endregion