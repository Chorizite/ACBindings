namespace ACBindings;

// ObjectSelectStatus
public enum ObjectSelectStatus : uint
{
    Invalid_OSS = 0x0,
    ObjectOnscreen_OSS = 0x1,
    ObjectOffscreen_OSS = 0x2,
    ObjectNotFound_OSS = 0x3,
    FORCE_ObjectSelectStatus_32_BIT = 0x7FFFFFFF
}

