namespace ACBindings.Internal;

// OptionalHeaderFlags
public enum OptionalHeaderFlags : uint
{
    ohfDisposable = 0x1,
    ohfExclusive = 0x2,
    ohfNotConn = 0x4,
    ohfTimeSensitive = 0x8,
    ohfShouldPiggyBack = 0x10,
    ohfHighPriority = 0x20,
    ohfCountsAsTouch = 0x40,
    ohfEncrypted = 0x20000000,
    ohfSigned = 0x40000000
}

