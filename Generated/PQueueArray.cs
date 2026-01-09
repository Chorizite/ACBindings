namespace ACBindings;

// PQueueArray<double,void*>
public unsafe struct PQueueArray__double__void_ptr
{
    // Child Types
    // PQueueArray<double,void*>::PQueueNode
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

// PQueueArray<unsigned long,void*>
public unsafe struct PQueueArray__uint__void_ptr
{
    // Child Types
    // PQueueArray<unsigned long,void*>::PQueueNode
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

