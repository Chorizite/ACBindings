namespace ACBindings.Internal;


/// <summary>Direct3D implementation of a render index buffer that stores vertex indices and controls an associated RenderIndexStreamD3D for rendering indexed geometry, handling static or dynamic streams and automatic refresh when the underlying graphics resource is lost.</summary>
public unsafe struct RenderIndexBufferD3D
{
    // Base Classes
    public ACBindings.Internal.RenderIndexBuffer BaseClass_RenderIndexBuffer; // ACBindings.Internal.RenderIndexBuffer

    // Child Types
    public unsafe struct RenderIndexBufferD3D_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderIndexBufferD3D*, void> RenderIndexBufferD3D_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderIndexBufferD3D*, uint, byte, byte, byte, byte, byte> Startup; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderIndexBufferD3D*, void> Shutdown; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderIndexBufferD3D*, ACBindings.Internal.RenderIndexBuffer*> Duplicate; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.RenderIndexStreamD3D* m_pIndexStream;

    // Methods

    /// <summary>Finalizes the render index buffer by releasing its associated stream when marked as static and resetting the internal pointer.
    /// <code>Offset: 0x00698E10
    /// void __thiscall RenderIndexBufferD3D::End(RenderIndexBufferD3D*)</code>
    /// </summary>
    public void End() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderIndexBufferD3D, void>)0x00698E10)(ref this);

    /// <summary>Initializes the index buffer with the given parameters, allocating or acquiring an index stream depending on whether the data is static.
    /// <code>Offset: 0x00698E30
    /// bool __thiscall RenderIndexBufferD3D::Startup(RenderIndexBufferD3D*,const unsigned int,const unsigned __int8,const bool,const bool,const bool)</code>
    /// </summary>
    /// <param name="this">Pointer to the RenderIndexBufferD3D instance being initialized.</param>
    /// <param name="nNumIndices">Total number of indices the buffer will hold.</param>
    /// <param name="indexSize">Size in bytes for each index (typically 1, 2, or 4).</param>
    /// <param name="staticData">If true, the data is immutable after creation; otherwise a dynamic stream is used.</param>
    /// <param name="OnlyWriteOnce">Enables write‑once optimization when creating a static stream.</param>
    /// <param name="bUseIndexCaching">Indicates whether index caching should be enabled during initialization.</param>
    /// <returns>True if the buffer and its associated stream were successfully created or acquired; otherwise false.</returns>
    public byte Startup(uint nNumIndices, byte indexSize, byte staticData, byte OnlyWriteOnce, byte bUseIndexCaching) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderIndexBufferD3D, uint, byte, byte, byte, byte, byte>)0x00698E30)(ref this, nNumIndices, indexSize, staticData, OnlyWriteOnce, bUseIndexCaching);

    /// <summary>Releases resources owned by the render index buffer, cleaning up the associated index stream when static data is present.
    /// <code>Offset: 0x00698ED0
    /// void __thiscall RenderIndexBufferD3D::Shutdown(RenderIndexBufferD3D*)</code>
    /// </summary>
    public void Shutdown() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderIndexBufferD3D, void>)0x00698ED0)(ref this);

    /// <summary>Updates the Direct3D index stream associated with this buffer, recalculating vertex indices when a refresh is required. Returns true on success or when no update is necessary.
    /// <code>Offset: 0x00698F00
    /// bool __thiscall RenderIndexBufferD3D::UpdateIndexBuffer(RenderIndexBufferD3D*)</code>
    /// </summary>
    /// <returns>True if the index data was refreshed successfully or if no action was needed; false if memory allocation for index remapping failed.</returns>
    public byte UpdateIndexBuffer() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderIndexBufferD3D, byte>)0x00698F00)(ref this);

    /// <summary>Creates a deep copy of this RenderIndexBufferD3D object and returns a pointer to the newly constructed RenderIndexBuffer. If allocation fails or setting up the index buffer fails, it cleans up and returns nullptr.
    /// <code>Offset: 0x00698FE0
    /// RenderIndexBuffer* __thiscall RenderIndexBufferD3D::Duplicate(RenderIndexBufferD3D*)</code>
    /// </summary>
    /// <returns>A pointer to the duplicated RenderIndexBuffer instance, or nullptr if duplication could not be completed.</returns>
    public ACBindings.Internal.RenderIndexBuffer* Duplicate() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderIndexBufferD3D, ACBindings.Internal.RenderIndexBuffer*>)0x00698FE0)(ref this);
}

