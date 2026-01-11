namespace ACBindings.Internal;

// BlitMode
public enum BlitMode : byte
{
    Blit_Normal = 0x0,
    Blit_3Alpha = 0x1,
    Blit_4Alpha = 0x2,
    Blit_Colorize = 0x3,
    Blit_Multiply = 0x4,
    Blit_Screen = 0x5,
    Blit_Grayscale = 0x6,
    Blit_NOP = 0x7,
    Blit_nModes = 0x8
}

