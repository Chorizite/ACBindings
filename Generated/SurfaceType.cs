namespace ACBindings;

// SurfaceType
public enum SurfaceType : uint
{
    BASE1_SOLID = 0x1,
    BASE1_IMAGE = 0x2,
    BASE1_CLIPMAP = 0x4,
    TRANSLUCENT = 0x10,
    DIFFUSE = 0x20,
    LUMINOUS = 0x40,
    ALPHA = 0x100,
    INVALPHA = 0x200,
    ADDITIVE = 0x10000,
    DETAIL = 0x20000,
    GOURAUD = 0x10000000,
    STIPPLED = 0x40000000,
    FORCE_SurfaceType_32_BIT = 0x7FFFFFFF,
    PERSPECTIVE = 0x80000000
}

