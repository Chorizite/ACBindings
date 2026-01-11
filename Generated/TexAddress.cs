namespace ACBindings.Internal;

// TexAddress
public enum TexAddress : uint
{
    TEXADDRESS_WRAP = 0x1,
    TEXADDRESS_MIRROR = 0x2,
    TEXADDRESS_CLAMP = 0x3,
    TEXADDRESS_BORDER = 0x4,
    TEXADDRESS_MIRRORONCE = 0x5,
    TEXADDRESS_INVALID = 0x7FFFFFFF
}

