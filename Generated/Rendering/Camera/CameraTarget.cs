namespace ACBindings.Internal;

// CameraTarget
public enum CameraTarget : uint
{
    INVALID_TARGET = 0x0,
    LOOK_IN_DIRECTION = 0x1,
    LOOK_AT_OBJECT = 0x2,
    LOOK_AT_PIVOT = 0x4,
    ALIGN_WITH_PIVOT = 0x8,
    ALIGN_WITH_PLANE = 0x10,
    FORCE_CameraTarget_32_BIT = 0x7FFFFFFF
}

