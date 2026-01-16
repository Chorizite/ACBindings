namespace ACBindings.Internal;


/// <summary>
/// Stores vertex buffer data together with format details, bounding‑box calculations, and bone influence lists for rendering. Manages allocation, locking state, and various flags controlling static usage and extra texture coordinate handling.
/// </summary>
public unsafe struct VertexArray : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.ReferenceCountTemplate BaseClass_ReferenceCountTemplate; // ACBindings.Internal.ReferenceCountTemplate

    // Child Types
    public unsafe struct VertexArray_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.VertexArray*, void> VertexArray_dtor_0; // function pointer
        public System.IntPtr Startup;
        public System.IntPtr Shutdown;
        public System.IntPtr Lock;
        public System.IntPtr Unlock;

        // Methods
    }

    // Members
    public ACBindings.Internal.VertexFormatInfo vertexFormat;
    public uint numVertices;
    public System.IntPtr vertices;
    public byte staticVertices;
    public byte locked;
    public byte m_bStripHWExtraTexCoords;
    public byte m_OnlyWriteOnce;
    public ACBindings.Internal.BBox m_BoundingBox;
    public ACBindings.Internal.SmartArray__uint m_InfluencedBoneIndexArray;
    public byte m_IsYAndZSwapped;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Destroys a VertexArray instance, performing cleanup via End, releasing the vertex buffer when the ownership flag is set, and resetting the object to its reference‑counting base class.
    /// <code>Offset: 0x00447CF0
    /// void __thiscall VertexArray::~VertexArray(VertexArray*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VertexArray, void>)0x00447CF0)(ref this);

    /// <summary>Requests enabling or disabling hardware‑generated extra texture coordinates on this vertex array.
    /// <code>Offset: 0x005D83A0
    /// char __thiscall VertexArray::RequestStripHWExtraTexCoords(VertexArray*,bool)</code>
    /// </summary>
    /// <param name="a2">The desired state for the m_bStripHWExtraTexCoords flag.</param>
    /// <returns>True if the flag was set; false if the request failed, typically because the vertex data is already in use or otherwise locked.</returns>
    public sbyte RequestStripHWExtraTexCoords(byte a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VertexArray, byte, sbyte>)0x005D83A0)(ref this, a2);

    /// <summary>Initializes the vertex array with the specified number of vertices, configures vertex format offsets, allocates memory for vertex data and sets related flags.
    /// <code>Offset: 0x005D83C0
    /// bool __thiscall VertexArray::Startup(VertexArray*,unsigned int,unsigned int,bool,bool,unsigned int)</code>
    /// </summary>
    /// <param name="a2">Number of vertices to allocate.</param>
    /// <param name="a3">Internal size parameter used during initialization.</param>
    /// <param name="a4">Flag indicating whether the vertex buffer is static.</param>
    /// <param name="a5">Flag specifying if the array should be locked after initialization.</param>
    /// <param name="a6">Additional configuration value (unused directly in allocation).</param>
    /// <returns>True if memory allocation succeeds; otherwise false.</returns>
    public byte Startup(uint a2, uint a3, byte a4, byte a5, uint a6) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VertexArray, uint, uint, byte, byte, uint, byte>)0x005D83C0)(ref this, a2, a3, a4, a5, a6);

    /// <summary>Locks a contiguous block of vertices for direct manipulation and returns a pointer to the first vertex in the requested range.
    /// <code>Offset: 0x005D8420
    /// int __thiscall VertexArray::Lock(VertexArray*,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="a2">Index of the first vertex to lock.</param>
    /// <param name="a3">Number of consecutive vertices to lock.</param>
    /// <returns>An integer representing the address of the locked vertex data, or 0 if the array is already locked or the specified range exceeds bounds.</returns>
    public int Lock(uint a2, uint a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VertexArray, uint, uint, int>)0x005D8420)(ref this, a2, a3);

    /// <summary>Computes the axis‑aligned bounding box for all vertices in the array and updates the object’s internal m_BoundingBox field.
    /// <code>Offset: 0x005D85E0
    /// unsigned int __thiscall VertexArray::GenerateBoundingBox(VertexArray*)</code>
    /// </summary>
    /// <returns>The total number of vertices processed to construct the bounding box.</returns>
    public uint GenerateBoundingBox() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VertexArray, uint>)0x005D85E0)(ref this);

    /// <summary>Prepares the vertex array for reuse by resetting vertex count, status flags, bounding box, and clearing profiling data.
    /// <code>Offset: 0x005D8650
    /// void __thiscall VertexArray::Begin(VertexArray*)</code>
    /// </summary>
    public void Begin() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VertexArray, void>)0x005D8650)(ref this);

    /// <summary>Releases the allocated vertex buffer if present and clears the internal smart array.
    /// <code>Offset: 0x005D86A0
    /// void __thiscall VertexArray::End(void**)</code>
    /// </summary>
    public void End() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VertexArray, void>)0x005D86A0)(ref this);

    /// <summary>Shuts down the vertex array by freeing any allocated vertex memory, resetting internal smart arrays, and reinitializing for subsequent use.
    /// <code>Offset: 0x005D86D0
    /// void __thiscall VertexArray::Shutdown(void**)</code>
    /// </summary>
    public void Shutdown() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VertexArray, void>)0x005D86D0)(ref this);

    /// <summary>Serializes or deserializes a VertexArray’s state—including vertex count, format information, vertex buffer contents, bounding‑box, and influencing bone indices—to or from the provided Archive.
    /// <code>Offset: 0x005D88B0
    /// void __thiscall VertexArray::Serialize(VertexArray*,Archive*)</code>
    /// </summary>
    /// <param name="io_archive">The archive used for reading or writing the data. When its flags indicate a write operation, the current VertexArray values are written; otherwise the archive is read into the VertexArray’s fields.</param>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VertexArray, ACBindings.Internal.Archive*, void>)0x005D88B0)(ref this, io_archive);

    /// <summary>Collects all unique bone indices that influence any vertex in the array and stores them in m_InfluencedBoneIndexArray.
    /// <code>Offset: 0x005D9630
    /// void __thiscall VertexArray::ComputeInfluencedBoneIndices(VertexArray*)</code>
    /// </summary>
    public void ComputeInfluencedBoneIndices() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VertexArray, void>)0x005D9630)(ref this);

    /// <summary>Unlocks the vertex array by clearing its lock flag and optionally updating geometry data.
    /// <code>Offset: 0x005D97C0
    /// void __thiscall VertexArray::Unlock(VertexArray*,bool,bool)</code>
    /// </summary>
    /// <param name="a2">When true, regenerates the bounding box for the vertex array.</param>
    /// <param name="a3">When true, recomputes influenced bone indices for the vertex array.</param>
    public void Unlock(byte a2, byte a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VertexArray, byte, byte, void>)0x005D97C0)(ref this, a2, a3);
}

