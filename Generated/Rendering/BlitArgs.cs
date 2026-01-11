namespace ACBindings.Internal;

public unsafe struct BlitArgs
{
    // Members
    public ACBindings.Internal.BlitMode eMode;
    public ACBindings.Internal.BlitBufferArgs cSrcArgs;
    public ACBindings.Internal.BlitBufferArgs cDstArgs;
    public uint nWidth;
    public uint nHeight;
    public byte i8AlphaModifier;

    // Methods
}

