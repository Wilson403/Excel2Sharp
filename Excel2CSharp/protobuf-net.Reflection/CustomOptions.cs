// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: protogen.proto

#pragma warning disable CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace ProtoBuf.Reflection
{

    [global::ProtoBuf.ProtoContract()]
    public partial class ProtogenFileOptions : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"namespace")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Namespace { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"access")]
        public Access Access { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"extensions")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ExtensionTypeName { get; set; } = "";

        [global::ProtoBuf.ProtoMember(4, Name = @"csharp_langver")]
        [global::System.ComponentModel.DefaultValue("")]
        public string CSharpLanguageVersion { get; set; } = "";

        [global::ProtoBuf.ProtoMember(5, Name = @"requiredDefaults")]
        public bool EmitRequiredDefaults { get; set; }

        [global::ProtoBuf.ProtoMember(6, Name = @"oneofEnum")]
        public bool EmitOneOfEnum { get; set; }

        [global::ProtoBuf.ProtoMember(7, Name = @"vb_langver")]
        [global::System.ComponentModel.DefaultValue("")]
        public string VisualBasicLanguageVersion { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ProtogenMessageOptions : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"name")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Name { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"access")]
        public Access Access { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"extensions")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ExtensionTypeName { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ProtogenFieldOptions : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"name")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Name { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"access")]
        public Access Access { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"asRef")]
        public bool AsReference { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"dynamicType")]
        public bool DynamicType { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ProtogenEnumOptions : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"name")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Name { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"access")]
        public Access Access { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ProtogenEnumValueOptions : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"name")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Name { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ProtogenServiceOptions : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"name")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Name { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"access")]
        public Access Access { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ProtogenMethodOptions : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"name")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Name { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ProtogenOneofOptions : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"name")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Name { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"isSubType")]
        public bool IsSubType { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public enum Access
    {
        [global::ProtoBuf.ProtoEnum(Name = @"INHERIT")]
        Inherit = 0,
        [global::ProtoBuf.ProtoEnum(Name = @"PUBLIC")]
        Public = 1,
        [global::ProtoBuf.ProtoEnum(Name = @"PRIVATE")]
        Private = 2,
        [global::ProtoBuf.ProtoEnum(Name = @"INTERNAL")]
        Internal = 3,
    }

    public static class Extensions
    {
        public static ProtogenFileOptions GetOptions(this global::Google.Protobuf.Reflection.FileOptions obj)
            => obj == null ? default : global::ProtoBuf.Extensible.GetValue<ProtogenFileOptions>(obj, 1037);

        public static void SetOptions(this global::Google.Protobuf.Reflection.FileOptions obj, ProtogenFileOptions value)
            => global::ProtoBuf.Extensible.AppendValue<ProtogenFileOptions>(obj, 1037, value);

        public static ProtogenMessageOptions GetOptions(this global::Google.Protobuf.Reflection.MessageOptions obj)
            => obj == null ? default : global::ProtoBuf.Extensible.GetValue<ProtogenMessageOptions>(obj, 1037);

        public static void SetOptions(this global::Google.Protobuf.Reflection.MessageOptions obj, ProtogenMessageOptions value)
            => global::ProtoBuf.Extensible.AppendValue<ProtogenMessageOptions>(obj, 1037, value);

        public static ProtogenFieldOptions GetOptions(this global::Google.Protobuf.Reflection.FieldOptions obj)
            => obj == null ? default : global::ProtoBuf.Extensible.GetValue<ProtogenFieldOptions>(obj, 1037);

        public static void SetOptions(this global::Google.Protobuf.Reflection.FieldOptions obj, ProtogenFieldOptions value)
            => global::ProtoBuf.Extensible.AppendValue<ProtogenFieldOptions>(obj, 1037, value);

        public static ProtogenEnumOptions GetOptions(this global::Google.Protobuf.Reflection.EnumOptions obj)
            => obj == null ? default : global::ProtoBuf.Extensible.GetValue<ProtogenEnumOptions>(obj, 1037);

        public static void SetOptions(this global::Google.Protobuf.Reflection.EnumOptions obj, ProtogenEnumOptions value)
            => global::ProtoBuf.Extensible.AppendValue<ProtogenEnumOptions>(obj, 1037, value);

        public static ProtogenEnumValueOptions GetOptions(this global::Google.Protobuf.Reflection.EnumValueOptions obj)
            => obj == null ? default : global::ProtoBuf.Extensible.GetValue<ProtogenEnumValueOptions>(obj, 1037);

        public static void SetOptions(this global::Google.Protobuf.Reflection.EnumValueOptions obj, ProtogenEnumValueOptions value)
            => global::ProtoBuf.Extensible.AppendValue<ProtogenEnumValueOptions>(obj, 1037, value);

        public static ProtogenServiceOptions GetOptions(this global::Google.Protobuf.Reflection.ServiceOptions obj)
            => obj == null ? default : global::ProtoBuf.Extensible.GetValue<ProtogenServiceOptions>(obj, 1037);

        public static void SetOptions(this global::Google.Protobuf.Reflection.ServiceOptions obj, ProtogenServiceOptions value)
            => global::ProtoBuf.Extensible.AppendValue<ProtogenServiceOptions>(obj, 1037, value);

        public static ProtogenMethodOptions GetOptions(this global::Google.Protobuf.Reflection.MethodOptions obj)
            => obj == null ? default : global::ProtoBuf.Extensible.GetValue<ProtogenMethodOptions>(obj, 1037);

        public static void SetOptions(this global::Google.Protobuf.Reflection.MethodOptions obj, ProtogenMethodOptions value)
            => global::ProtoBuf.Extensible.AppendValue<ProtogenMethodOptions>(obj, 1037, value);

        public static ProtogenOneofOptions GetOptions(this global::Google.Protobuf.Reflection.OneofOptions obj)
            => obj == null ? default : global::ProtoBuf.Extensible.GetValue<ProtogenOneofOptions>(obj, 1037);

        public static void SetOptions(this global::Google.Protobuf.Reflection.OneofOptions obj, ProtogenOneofOptions value)
            => global::ProtoBuf.Extensible.AppendValue<ProtogenOneofOptions>(obj, 1037, value);

    }
}

#pragma warning restore CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192