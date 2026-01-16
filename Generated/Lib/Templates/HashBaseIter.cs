namespace ACBindings.Internal;


/// <summary>Iterates over entries in a hash table keyed by unsigned long values, tracking the current bucket, position within that bucket's linked list, and whether iteration has finished.</summary>
public unsafe struct HashBaseIter__uint
{
    // Members
    public System.IntPtr myHash_;
    public uint curBucket_;
    public System.IntPtr curPtr_;
    public System.IntPtr lastThisChain_;
    public int fEnd_;

    // Methods
}


/// <summary>Iterates over entries in a 64‑bit hash table, tracking the current bucket, element pointer, and completion flag to support enumeration of stored values.</summary>
public unsafe struct HashBaseIter__ulong
{
    // Members
    public System.IntPtr myHash_;
    public uint curBucket_;
    public System.IntPtr curPtr_;
    public System.IntPtr lastThisChain_;
    public int fEnd_;

    // Methods
}

