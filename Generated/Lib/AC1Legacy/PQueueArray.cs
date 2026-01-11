namespace ACBindings.Internal.AC1Legacy;

public unsafe struct PQueueArray__double
{
    // Child Types
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

    /// <summary>
    /// <code>Offset: 0x00508470
    /// int __thiscall AC1Legacy::PQueueArray&lt;double&gt;::Insert(_DWORD*,double,int)</code>
    /// </summary>
    // int __thiscall AC1Legacy::PQueueArray<double>::Insert(_DWORD*,double,int) (template type method)

    /// <summary>
    /// <code>Offset: 0x005084F0
    /// int __thiscall AC1Legacy::PQueueArray&lt;double&gt;::RemoveMin(_DWORD*,_DWORD*,_DWORD*)</code>
    /// </summary>
    // int __thiscall AC1Legacy::PQueueArray<double>::RemoveMin(_DWORD*,_DWORD*,_DWORD*) (template type method)
}

