namespace ACBindings.Internal;


/// <summary>Core storage layout and configuration for a hash table keyed by unsigned long values, including table size, mask, and bucket pointers.</summary>
public unsafe struct HashBase__uint
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public uint table_mask;
    public uint key_shift;
    public System.IntPtr buckets;
    public uint table_size;
    public int fPlacementNew_;

    // Methods
}

public unsafe struct HashBase__ulong
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public ulong table_mask;
    public uint key_shift;
    public System.IntPtr buckets;
    public uint table_size;
    public int fPlacementNew_;

    // Methods
}

