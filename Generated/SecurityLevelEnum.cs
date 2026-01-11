namespace ACBindings.Internal;

// SecurityLevelEnum
public enum SecurityLevelEnum : uint
{
    Undef_SecurityLevel = 0x0,
    Player_SecurityLevel = 0x0,
    Advocate1_SecurityLevel = 0x1,
    Advocate2_SecurityLevel = 0x2,
    Advocate3_SecurityLevel = 0x3,
    Advocate4_SecurityLevel = 0x4,
    Advocate5_SecurityLevel = 0x5,
    MaxAdvocate_SecurityLevel = 0x5,
    Sentinel1_SecurityLevel = 0x6,
    Sentinel2_SecurityLevel = 0x7,
    Sentinel3_SecurityLevel = 0x8,
    MaxSentinel_SecurityLevel = 0x8,
    Turbine_SecurityLevel = 0x9,
    Arch_SecurityLevel = 0xA,
    Admin_SecurityLevel = 0xB,
    Max_SecurityLevel = 0xB,
    FORCE_SecurityLevelEnum_32_BIT = 0x7FFFFFFF
}

