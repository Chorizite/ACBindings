namespace ACBindings.Internal;


/// <summary>Represents an entry in a binary tree table, storing metadata for a data block including its unique identifier, file offset, size, timestamp, and iteration count.</summary>
public unsafe struct BTEntry
{
    // Members
    public int _bf_0;
    public ACBindings.Internal.IDClass____tagDataID GID_;
    public int Offset_;
    public uint size_;
    public int date_;
    public int iter_;

    // Methods
}

