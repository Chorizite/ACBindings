namespace ACBindings.Internal;

// StipplingType
public enum StipplingType : uint
{
    NO_STIPPLING = 0x0,
    POSITIVE_STIPPLING = 0x1,
    NEGATIVE_STIPPLING = 0x2,
    BOTH_STIPPLING = 0x3,
    NO_POS_UVS = 0x4,
    NO_NEG_UVS = 0x8,
    NO_UVS = 0x14,
    FORCE_StipplingType_32_BIT = 0x7FFFFFFF
}

