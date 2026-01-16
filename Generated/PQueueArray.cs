namespace ACBindings.Internal;

public unsafe struct PQueueArray__double__void_ptr
{
    // Child Types

    /// <summary>Represents a node in a priority queue array, storing a numerical key and a pointer to associated data for efficient ordering and retrieval.</summary>
    public unsafe struct PQueueNode
    {
        // Members
        public double key;
        public System.IntPtr data;

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public System.IntPtr A;
    public int curNumNodes;
    public int allocatedNodes;
    public int minAllocatedNodes;

    // Methods
}

public unsafe struct PQueueArray__uint__void_ptr
{
    // Child Types

    /// <summary>Encapsulates an entry in a priority queue array, storing an unsigned integer key and a pointer to associated data.</summary>
    public unsafe struct PQueueNode
    {
        // Members
        public uint key;
        public System.IntPtr data;

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public System.IntPtr A;
    public int curNumNodes;
    public int allocatedNodes;
    public int minAllocatedNodes;

    // Methods
}

