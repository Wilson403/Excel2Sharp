// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: chest_open_table.proto

#pragma warning disable CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace Hot.Generated
{

    [global::ProtoBuf.ProtoContract()]
    public partial class ChestOpenTableConfig : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"id")]
        public int Id { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"item_id")]
        public int ItemId { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"item_name")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ItemName { get; set; } = "";

        [global::ProtoBuf.ProtoMember(4)]
        public int Quality { get; set; }

        [global::ProtoBuf.ProtoMember(5, Name = @"image_lock")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ImageLock { get; set; } = "";

        [global::ProtoBuf.ProtoMember(6, Name = @"image_unlock_bottom")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ImageUnlockBottom { get; set; } = "";

        [global::ProtoBuf.ProtoMember(7, Name = @"image_unlock_top")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ImageUnlockTop { get; set; } = "";

        [global::ProtoBuf.ProtoMember(8, Name = @"image_unlock_icon")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ImageUnlockIcon { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ChestOpenTableConfigData : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public global::System.Collections.Generic.List<ChestOpenTableConfig> ConfigVoes { get; } = new global::System.Collections.Generic.List<ChestOpenTableConfig>();

    }

}

#pragma warning restore CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
