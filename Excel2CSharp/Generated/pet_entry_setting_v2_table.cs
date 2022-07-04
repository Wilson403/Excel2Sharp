// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: pet_entry_setting_v2_table.proto

#pragma warning disable CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace Hot.Generated
{

    [global::ProtoBuf.ProtoContract()]
    public partial class PetEntrySettingV2TableConfig : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"id")]
        public int Id { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"res_table")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ResTable { get; set; } = "";

        [global::ProtoBuf.ProtoMember(3, Name = @"res_id")]
        public int ResId { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"entry_time")]
        public int EntryTime { get; set; }

        [global::ProtoBuf.ProtoMember(5, Name = @"entry_id")]
        public int EntryId { get; set; }

        [global::ProtoBuf.ProtoMember(6, Name = @"float_min")]
        public int FloatMin { get; set; }

        [global::ProtoBuf.ProtoMember(7, Name = @"float_max")]
        public int FloatMax { get; set; }

        [global::ProtoBuf.ProtoMember(8, Name = @"float_size")]
        public int FloatSize { get; set; }

        [global::ProtoBuf.ProtoMember(9, Name = @"entry_point")]
        public int EntryPoint { get; set; }

        [global::ProtoBuf.ProtoMember(10, Name = @"res_cost")]
        public int ResCost { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class PetEntrySettingV2TableConfigData : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public global::System.Collections.Generic.List<PetEntrySettingV2TableConfig> ConfigVoes { get; } = new global::System.Collections.Generic.List<PetEntrySettingV2TableConfig>();

    }

}

#pragma warning restore CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
