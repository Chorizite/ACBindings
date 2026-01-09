namespace ACBindings;

// ISerializeType
public enum ISerializeType : byte
{
    ISerializeOnly_ISerializeType = 0x0,
    ISerializeOrNull_ISerializeType = 0x1,
    AnyInterfaceOrNull_ISerializeType = 0x2
}

