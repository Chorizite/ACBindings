namespace ACBindings.Internal;


/// <summary>Maintains metadata for a block in an LRU-based buffer, tracking link padding and age relationships between entries.</summary>
/// <remarks>Fields: <c>link_padding_lm</c> holds the padding value; <c>younger_lm</c> and <c>older_lm</c> denote relative positions within the LRU chain; <c>used_lm</c> flags whether the block is currently active.</remarks>
public unsafe struct LRUB_Info_t
{
    // Members
    public int link_padding_lm;
    public int younger_lm;
    public int older_lm;
    public int used_lm;

    // Methods
}

