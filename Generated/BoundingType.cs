namespace ACBindings.Internal;

// BoundingType
public enum BoundingType : uint
{
    OUTSIDE = 0x0,
    PARTIALLY_INSIDE = 0x1,
    ENTIRELY_INSIDE = 0x2,
    FORCE_BoundingType_32_BIT = 0x7FFFFFFF
}

