namespace ACBindings;

// GRVDataType
public enum GRVDataType : byte
{
    GRVDataType_Unknown = 0x0,
    GRVDataType_DataID = 0x1,
    GRVDataType_Bool = 0x2,
    GRVDataType_Int32 = 0x3,
    GRVDataType_UInt32 = 0x4,
    GRVDataType_Int16 = 0x5,
    GRVDataType_UInt16 = 0x6,
    GRVDataType_Int8 = 0x7,
    GRVDataType_UInt8 = 0x8,
    GRVDataType_Float32 = 0x9,
    GRVDataType_Float64 = 0xA,
    GRVDataType_Vector3 = 0xB,
    GRVDataType_RGBAColor = 0xC,
    GRVDataType_PString = 0xD,
    GRVDataType_Waveform = 0xE
}

