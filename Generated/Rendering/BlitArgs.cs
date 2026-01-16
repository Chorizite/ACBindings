namespace ACBindings.Internal;


/// <summary>Encapsulates arguments for a blit operation, specifying source and destination buffer parameters, dimensions, mode, and an optional alpha modifier.</summary>
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

