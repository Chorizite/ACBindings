namespace ACBindings;

// LandChangeType
public enum LandChangeType : uint
{
    CHANGE_LAND_HEIGHT = 0x0,
    CHANGE_LAND_ROAD = 0x1,
    CHANGE_LAND_TERRAIN = 0x2,
    CHANGE_LAND_SCENE = 0x3,
    CHANGE_LAND_ENCOUNTER = 0x4,
    FORCE_LandChangeType_32_BIT = 0x7FFFFFFF
}

