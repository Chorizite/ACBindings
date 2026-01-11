namespace ACBindings.Internal;

// ObjectInfoEnum
public enum ObjectInfoEnum : uint
{
    DEFAULT_OI = 0x0,
    CONTACT_OI = 0x1,
    ON_WALKABLE_OI = 0x2,
    IS_VIEWER_OI = 0x4,
    PATH_CLIPPED_OI = 0x8,
    FREE_ROTATE_OI = 0x10,
    PERFECT_CLIP_OI = 0x40,
    IS_IMPENETRABLE = 0x80,
    IS_PLAYER = 0x100,
    EDGE_SLIDE = 0x200,
    IGNORE_CREATURES = 0x400,
    IS_PK = 0x800,
    IS_PKLITE = 0x1000,
    FORCE_ObjectInfoEnum_32_BIT = 0x7FFFFFFF
}

