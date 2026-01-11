namespace ACBindings.Internal;

// TexFilterMode
public enum TexFilterMode : uint
{
    TEXFILTER_NONE = 0x0,
    TEXFILTER_POINT = 0x1,
    TEXFILTER_LINEAR = 0x2,
    TEXFILTER_ANISOTROPIC = 0x3,
    TEXFILTER_PYRAMIDALQUAD = 0x6,
    TEXFILTER_GAUSSIANQUAD = 0x7,
    TEXFILTER_INVALID = 0x7FFFFFFF
}

