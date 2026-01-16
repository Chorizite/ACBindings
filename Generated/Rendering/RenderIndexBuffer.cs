namespace ACBindings.Internal;


/// <summary>Represents an index buffer that stores vertex indices for rendering, managing memory allocation, lock state, and caching flags while supporting initialization, copying, and archive‑based serialization.</summary>
public unsafe struct RenderIndexBuffer
{
    // Child Types
    public unsafe struct RenderIndexBuffer_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderIndexBuffer*, void> RenderIndexBuffer_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderIndexBuffer*, uint, byte, byte, byte, byte, byte> Startup; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderIndexBuffer*, void> Shutdown; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderIndexBuffer*, ACBindings.Internal.RenderIndexBuffer*> Duplicate; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public uint m_nNumIndices;
    public uint m_nActualNumIndices;
    public byte indexSize;
    public byte* indices;
    public byte staticData;
    public byte m_OnlyWriteOnce;
    public byte locked;
    public byte needRefresh;
    public byte m_bUseIndexCaching;
    public uint m_nMinVertexIndex;
    public uint m_nMaxVertexIndex;
    public byte m_bNeedRecalcMinMax;

    // Methods

    /// <summary>Initializes the RenderIndexBuffer instance by resetting all internal counters, indices, flags, and caching settings to their default state.
    /// <code>Offset: 0x0044CA60
    /// void __thiscall RenderIndexBuffer::Begin(RenderIndexBuffer*)</code>
    /// </summary>
    public void Begin() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderIndexBuffer, void>)0x0044CA60)(ref this);

    /// <summary>Releases any allocated index data and resets internal counters, preparing the buffer for reuse or destruction.
    /// <code>Offset: 0x0044CA90
    /// void __thiscall RenderIndexBuffer::End(RenderIndexBuffer*)</code>
    /// </summary>
    public void End() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderIndexBuffer, void>)0x0044CA90)(ref this);

    /// <summary>Initializes an index buffer with the specified number of indices, size per index, and configuration flags, allocating memory for the indices array and resetting internal state.
    /// <code>Offset: 0x0044CAC0
    /// bool __thiscall RenderIndexBuffer::Startup(RenderIndexBuffer*,const unsigned int,const unsigned __int8,const bool,const bool,const bool)</code>
    /// </summary>
    /// <param name="nNumIndices">The total count of indices to allocate.</param>
    /// <param name="indexSize">The size in bytes of each index (typically 2 or 4).</param>
    /// <param name="staticData">If true, marks the data as static for potential optimizations.</param>
    /// <param name="OnlyWriteOnce">When set, indicates that the buffer will be written only once during its lifetime.</param>
    /// <param name="bUseIndexCaching">Enables or disables index caching behavior.</param>
    /// <returns>True if initialization succeeds; otherwise false (currently always true).</returns>
    public byte Startup(uint nNumIndices, byte indexSize, byte staticData, byte OnlyWriteOnce, byte bUseIndexCaching) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderIndexBuffer, uint, byte, byte, byte, byte, byte>)0x0044CAC0)(ref this, nNumIndices, indexSize, staticData, OnlyWriteOnce, bUseIndexCaching);

    /// <summary>Releases the index array owned by the RenderIndexBuffer instance and resets all internal state to default values.
    /// <code>Offset: 0x0044CB20
    /// void __thiscall RenderIndexBuffer::Shutdown(RenderIndexBuffer*)</code>
    /// </summary>
    public void Shutdown() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderIndexBuffer, void>)0x0044CB20)(ref this);

    /// <summary>Locks the index buffer and returns a pointer to its indices.
    /// <code>Offset: 0x0044CB70
    /// unsigned __int8* __thiscall RenderIndexBuffer::Lock(RenderIndexBuffer*)</code>
    /// </summary>
    /// <returns>A pointer to the buffer's index array for direct manipulation.</returns>
    public byte* Lock() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderIndexBuffer, byte*>)0x0044CB70)(ref this);

    /// <summary>Recalculates the minimum and maximum vertex indices of the index buffer when caching is enabled and a recalculation is required, updating internal fields accordingly.
    /// <code>Offset: 0x0044CB90
    /// void __thiscall RenderIndexBuffer::RecalculateMinMaxIndices(RenderIndexBuffer*)</code>
    /// </summary>
    public void RecalculateMinMaxIndices() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderIndexBuffer, void>)0x0044CB90)(ref this);

    /// <summary>Copies index data from the given source RenderIndexBuffer into this instance after initializing resources.
    /// <code>Offset: 0x0044CCC0
    /// bool __thiscall RenderIndexBuffer::SetRenderIndexBuffer(RenderIndexBuffer*,const RenderIndexBuffer*)</code>
    /// </summary>
    /// <param name="source">Source buffer whose indices are to be copied.</param>
    /// <returns>True if initialization and copy succeeded; otherwise false.</returns>
    public byte SetRenderIndexBuffer(ACBindings.Internal.RenderIndexBuffer* source) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderIndexBuffer, ACBindings.Internal.RenderIndexBuffer*, byte>)0x0044CCC0)(ref this, source);

    /// <summary>Serializes a RenderIndexBuffer to or from an Archive, handling alignment and read/write based on archive flags. When loading, it initializes index storage; after serialization, it marks the buffer as needing refresh and unlocks it. If initialization fails, it raises an error via the archive.
    /// <code>Offset: 0x0044CD60
    /// void __thiscall RenderIndexBuffer::Serialize(RenderIndexBuffer*,Archive*)</code>
    /// </summary>
    /// <param name="this">The RenderIndexBuffer instance being serialized.</param>
    /// <param name="io_archive">Archive to read from or write to during serialization.</param>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderIndexBuffer, ACBindings.Internal.Archive*, void>)0x0044CD60)(ref this, io_archive);

    /// <summary>Creates a duplicate of the current render index buffer by allocating a new instance and copying its contents. Returns the new buffer on success, otherwise null.
    /// <code>Offset: 0x0044CDF0
    /// RenderIndexBuffer* __thiscall RenderIndexBuffer::Duplicate(RenderIndexBuffer*)</code>
    /// </summary>
    /// <returns>A pointer to the duplicated RenderIndexBuffer, or nullptr if allocation or copy fails.</returns>
    public ACBindings.Internal.RenderIndexBuffer* Duplicate() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderIndexBuffer, ACBindings.Internal.RenderIndexBuffer*>)0x0044CDF0)(ref this);

    /// <summary>Loads an index buffer from a file node, handling both textual and binary index arrays.
    /// <code>Offset: 0x0044CEC0
    /// bool __thiscall RenderIndexBuffer::FromFileNode(RenderIndexBuffer*,const PFileNode*)</code>
    /// </summary>
    /// <param name="node">The file node providing the index data to load.</param>
    /// <returns>True if the index buffer was successfully populated; otherwise false.</returns>
    public byte FromFileNode(ACBindings.Internal.PFileNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderIndexBuffer, ACBindings.Internal.PFileNode*, byte>)0x0044CEC0)(ref this, node);
}

