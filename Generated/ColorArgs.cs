namespace ACBindings.Internal;


/// <summary>Specifies configuration parameters for a color blitting operation, including the blit mode, optional mask buffer settings, and target width and height. These arguments guide how pixel data is copied or transformed during rendering.</summary>
public unsafe struct ColorArgs
{
    // Members
    public ACBindings.Internal.BlitMode eMode;
    public ACBindings.Internal._A12ED80CE92ACAC66B39ECEEFE04F117 ___u1;
    public ACBindings.Internal.BlitBufferArgs cMaskArgs;
    public uint nWidth;
    public uint nHeight;

    // Methods
}

