namespace ACBindings.Internal;

// NodeNameType
public enum NodeNameType : byte
{
    PString_NAMETYPE = 0x0,
    UInt32_NAMETYPE = 0x1,
    Int32_NAMETYPE = 0x2,
    Double_NAMETYPE = 0x3,
    Float_NAMETYPE = 0x4,
    CellID_NAMETYPE = 0x5,
    InstanceID_NAMETYPE = 0x6,
    Bool_NAMETYPE = 0x7,
    Hex_NAMETYPE = 0x8,
    Binary_NAMETYPE = 0x9,
    BlockID_NAMETYPE = 0xA,
    UInt64_NAMETYPE = 0xB,
    Int64_NAMETYPE = 0xC,
    LongHex_NAMETYPE = 0xD,
    Guid_NAMETYPE = 0xE,
    NUM_NAMETYPES = 0xF,
    Null_NAMETYPE = 0xFF
}

