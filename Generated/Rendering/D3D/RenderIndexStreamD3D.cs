namespace ACBindings.Internal;


/// <summary>Manages a Direct3D index buffer used for streaming indices, maintaining frame‑based usage counters and facilitating automatic restoration or purging of GPU resources.</summary>
public unsafe struct RenderIndexStreamD3D
{
    // Base Classes
    public ACBindings.Internal.GraphicsResource BaseClass_GraphicsResource; // ACBindings.Internal.GraphicsResource

    // Child Types
    public unsafe struct RenderIndexStreamD3D_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderIndexStreamD3D*, void> RenderIndexStreamD3D_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderIndexStreamD3D*, ACBindings.Internal.GraphicsResource*, byte> CopyInto; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderIndexStreamD3D*, byte> PurgeResource; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderIndexStreamD3D*, byte> RestoreResource; // function pointer

        // Methods
    }

    // Members
    public uint m_Flags;
    public uint m_IndexSizeInBytes;
    public uint m_NumIndices;
    public System.IntPtr m_pDirect3DIndexBuffer;
    public uint m_StreamFrameID;
    public uint m_NextRemoteIndex;
    public uint m_WriteLockCount;

    // Generated Constructor
    public RenderIndexStreamD3D() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>Restores the Direct3D index buffer associated with this render stream, delegating to the base graphics resource implementation.
    /// <code>Offset: 0x00698980
    /// bool __thiscall RenderIndexStreamD3D::RestoreResource(RenderIndexStreamD3D*)</code>
    /// </summary>
    /// <returns>True if the resource was successfully restored; otherwise false.</returns>
    public byte RestoreResource() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderIndexStreamD3D, byte>)0x00698980)(ref this);

    /// <summary>Initializes a new RenderIndexStreamD3D instance with default flags, zero indices, no associated Direct3D index buffer, and prepares for subsequent rendering operations.
    /// <code>Offset: 0x00698A40
    /// void __thiscall RenderIndexStreamD3D::RenderIndexStreamD3D(RenderIndexStreamD3D*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderIndexStreamD3D, void>)0x00698A40)(ref this);

    /// <summary>Initializes the index stream with a specified number of indices and configuration flags.
    /// <code>Offset: 0x00698A70
    /// bool __thiscall RenderIndexStreamD3D::Init(RenderIndexStreamD3D*,const unsigned int,const unsigned int)</code>
    /// </summary>
    /// <param name="NumIndices">Total count of indices to allocate for the stream. Must be greater than zero; otherwise initialization fails.</param>
    /// <param name="Flags">Bitmask controlling stream behavior; when bit 1 (value 2) is unset, the resource is marked as thrashable.</param>
    /// <returns>True if initialization succeeds (NumIndices > 0); otherwise false.</returns>
    public byte Init(uint NumIndices, uint Flags) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderIndexStreamD3D, uint, uint, byte>)0x00698A70)(ref this, NumIndices, Flags);

    /// <summary>Creates a Direct3D index buffer for the stream based on its flags, index size and number of indices, initializing DirectX resources and updating bookkeeping fields.
    /// <code>Offset: 0x00698AB0
    /// bool __thiscall RenderIndexStreamD3D::CreateDirect3DIndexBuffer(RenderIndexStreamD3D*)</code>
    /// </summary>
    /// <returns>True when the index buffer is successfully created; otherwise false if an error occurs or the buffer cannot be allocated.</returns>
    public byte CreateDirect3DIndexBuffer() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderIndexStreamD3D, byte>)0x00698AB0)(ref this);

    /// <summary>Releases the Direct3D index buffer associated with this stream, clearing internal state and adjusting global resource counters when a valid buffer exists.
    /// <code>Offset: 0x00698BC0
    /// bool __thiscall RenderIndexStreamD3D::PurgeResource(RenderIndexStreamD3D*)</code>
    /// </summary>
    /// <returns>True if the purge succeeded; otherwise returns the result of DBObj::InitLoad(), indicating failure to initialize the load context.</returns>
    public byte PurgeResource() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderIndexStreamD3D, byte>)0x00698BC0)(ref this);

    /// <summary>Provides access to the Direct3D index buffer used by this stream, automatically restoring or creating it if necessary.
    /// <code>Offset: 0x00698C00
    /// IDirect3DIndexBuffer9* __thiscall RenderIndexStreamD3D::GetDirect3DIndexBuffer(RenderIndexStreamD3D*)</code>
    /// </summary>
    /// <returns>A pointer to IDirect3DIndexBuffer9; null if the resource could not be restored or created.</returns>
    public System.IntPtr GetDirect3DIndexBuffer() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderIndexStreamD3D, System.IntPtr>)0x00698C00)(ref this);

    /// <summary>Copies a block of index data into the device's index buffer, updating internal offsets and handling optional streaming mode.
    /// <code>Offset: 0x00698C50
    /// bool __thiscall RenderIndexStreamD3D::FillData(RenderIndexStreamD3D*,const unsigned int,const void*,unsigned int*)</code>
    /// </summary>
    /// <param name="NumIndices">The number of indices to copy from pSourceData.</param>
    /// <param name="pSourceData">Pointer to the source index data to be written into the buffer.</param>
    /// <param name="FirstRemoteIndex">Receives the starting remote index within the buffer where the data was written.</param>
    /// <returns>True if the data was successfully copied and the buffer updated; otherwise false (e.g., invalid parameters or Direct3D failure).</returns>
    public byte FillData(uint NumIndices, void* pSourceData, uint* FirstRemoteIndex) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderIndexStreamD3D, uint, void*, uint*, byte>)0x00698C50)(ref this, NumIndices, pSourceData, FirstRemoteIndex);

    /// <summary>Notifies that a new rendering frame has started for this index stream, resetting the remote index counter and advancing the internal frame identifier.
    /// <code>Offset: 0x00698D90
    /// void __thiscall RenderIndexStreamD3D::NotifyFrameChanged(RenderIndexStreamD3D*)</code>
    /// </summary>
    public void NotifyFrameChanged() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderIndexStreamD3D, void>)0x00698D90)(ref this);
}

