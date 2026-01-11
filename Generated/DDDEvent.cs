namespace ACBindings.Internal;

// DDDEvent
public enum DDDEvent : byte
{
    DDD_PatchtimeInterrogation = 0x0,
    DDD_RegionSet = 0x1,
    DDD_PatchtimePending = 0x2,
    DDD_PatchtimeBegin = 0x3,
    DDD_PatchtimeEnd = 0x4,
    DDD_DataDownloaded = 0x5,
    DDD_DynamicDataRequested = 0x6,
    DDD_DataError = 0x7
}

