namespace ACBindings.Internal.AC1Legacy;


/// <summary>Manages an array‑based priority queue for double values, tracking element count and allocation parameters to support efficient insertion and removal. Maintains capacity limits to balance performance and memory usage.</summary>
public unsafe struct PQueueArray__double
{
    // Child Types

    /// <summary>Entry in a priority‑queue array, storing a numeric key and an associated data pointer.</summary>
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

    /// <summary>Inserts a double value and an associated integer into the priority queue array, expanding storage if necessary and maintaining heap order.
    /// <code>Offset: 0x00508470
    /// int __thiscall AC1Legacy::PQueueArray&lt;double&gt;::Insert(_DWORD*,double,int)</code>
    /// </summary>
    /// <param name="a2">The double value to insert.</param>
    /// <param name="a3">An auxiliary integer stored alongside the value (e.g., key or priority).</param>
    /// <returns>Address of the inserted element within the internal array, cast to an int.</returns>
    // int __thiscall AC1Legacy::PQueueArray<double>::Insert(_DWORD*,double,int) (template type method)

    /// <summary>Removes the minimum element from the priority‑queue array, copies its key and value into the supplied buffers, restores the heap order, and indicates success.
    /// <code>Offset: 0x005084F0
    /// int __thiscall AC1Legacy::PQueueArray&lt;double&gt;::RemoveMin(_DWORD*,_DWORD*,_DWORD*)</code>
    /// </summary>
    /// <param name="a2">Pointer to a buffer that receives the removed node’s first two fields (key and associated value).</param>
    /// <param name="a3">Pointer where an additional field from the removed node is stored.</param>
    /// <returns>1 if an element was successfully removed; 0 when the queue is empty.</returns>
    // int __thiscall AC1Legacy::PQueueArray<double>::RemoveMin(_DWORD*,_DWORD*,_DWORD*) (template type method)
}

