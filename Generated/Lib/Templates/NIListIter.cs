namespace ACBindings.Internal;


/// <summary>Iterates over collections of unsigned long values, holding pointers to the underlying list and tracking the current and previous elements during traversal.</summary>
public unsafe struct NIListIter__uint
{
    // Members
    public System.IntPtr list_;
    public System.IntPtr cur_;
    public System.IntPtr prev_;

    // Methods
}


/// <summary>
/// Maintains iterator context for traversing a linked list of NetPacket objects, storing references to the underlying list, the current node, and its predecessor.
/// </summary>
public unsafe struct NIListIter___NetPacket_ptr
{
    // Members
    public System.IntPtr list_;
    public System.IntPtr cur_;
    public System.IntPtr prev_;

    // Methods
}

