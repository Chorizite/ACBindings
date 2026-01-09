namespace ACBindings.AC1Legacy;

// AC1Legacy::PQueueArray<double>
public unsafe struct PQueueArray__double
{
    // Child Types
    // AC1Legacy::PQueueArray<double>::PQueueNode
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
    // AC1Legacy::PQueueArray<double>::Insert (template type method)
    // AC1Legacy::PQueueArray<double>::RemoveMin (template type method)
}

