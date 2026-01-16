namespace ACBindings.Internal;


/// <summary>Encapsulates a Direct3D vertex buffer stream used by the rendering engine, storing vertex count, format information, and flags that control resource behavior. Provides mechanisms to create, purge, and update the underlying IDirect3DVertexBuffer9 while tracking usage for efficient memory management.</summary>
public unsafe struct RenderVertexStreamD3D
{
    // Base Classes
    public ACBindings.Internal.GraphicsResource BaseClass_GraphicsResource; // ACBindings.Internal.GraphicsResource

    // Child Types
    public unsafe struct RenderVertexStreamD3D_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderVertexStreamD3D*, void> RenderVertexStreamD3D_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderVertexStreamD3D*, ACBindings.Internal.GraphicsResource*, byte> CopyInto; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderVertexStreamD3D*, byte> PurgeResource; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderVertexStreamD3D*, byte> RestoreResource; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderVertexStreamD3D*, uint, uint, uint, byte> Create; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderVertexStreamD3D*, void> Destroy; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr m_pD3DVertexBuffer;
    public uint m_nNumVertices;
    public ACBindings.Internal.VertexFormatInfo m_VertexFormatInfo;
    public uint m_Flags;
    public uint m_nNextVertexIndex;
    public uint m_nIdealVertexCount;
    public uint m_nStreamFrameID;
    public uint m_WriteLockCount;

    // Methods

    /// <summary>Resets the vertex stream state, clearing any existing vertex buffer reference and zeroing counters and flags.
    /// <code>Offset: 0x00698580
    /// void __thiscall RenderVertexStreamD3D::Begin(RenderVertexStreamD3D*)</code>
    /// </summary>
    public void Begin() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderVertexStreamD3D, void>)0x00698580)(ref this);

    /// <summary>Create a vertex stream buffer with the specified number of vertices and format. Fails when the vertex count is zero or the format requires matrices.
    /// <code>Offset: 0x006985C0
    /// bool __thiscall RenderVertexStreamD3D::Create(RenderVertexStreamD3D*,const unsigned int,const unsigned int,const unsigned int)</code>
    /// </summary>
    /// <param name="nNumVertices">Number of vertices to allocate for the stream; must be greater than zero.</param>
    /// <param name="VertexFormat">Bitmask describing the layout of each vertex (position, normal, texture coordinates, etc.). If the format includes matrix attributes, creation fails.</param>
    /// <param name="Flags">Options controlling resource behavior. Bit 2 (value 4) disables thrashing when set; if unset, the stream is marked as thrashable.</param>
    /// <returns>True if initialization succeeds; false for an invalid vertex count or unsupported format.</returns>
    public byte Create(uint nNumVertices, uint VertexFormat, uint Flags) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderVertexStreamD3D, uint, uint, uint, byte>)0x006985C0)(ref this, nNumVertices, VertexFormat, Flags);

    /// <summary>Creates or updates the Direct3D vertex buffer for this render vertex stream based on its format, size, and flags. Computes required byte count, sets usage flags, obtains a new IDirect3DVertexBuffer9 from the render device, and marks the resource as valid when successful.
    /// <code>Offset: 0x00698620
    /// bool __thiscall RenderVertexStreamD3D::CreateD3DVertexBuffer(RenderVertexStreamD3D*)</code>
    /// </summary>
    /// <returns>True if the vertex buffer was successfully created or restored; otherwise false.</returns>
    public byte CreateD3DVertexBuffer() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderVertexStreamD3D, byte>)0x00698620)(ref this);

    /// <summary>Retrieves the Direct3D vertex buffer associated with this render stream, restoring it if previously lost and creating it on demand.
    /// <code>Offset: 0x00698740
    /// IDirect3DVertexBuffer9* __thiscall RenderVertexStreamD3D::GetD3DVertexBuffer(RenderVertexStreamD3D*)</code>
    /// </summary>
    /// <returns>The IDirect3DVertexBuffer9 instance representing the stream's vertex buffer, or NULL when restoration fails.</returns>
    public System.IntPtr GetD3DVertexBuffer() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderVertexStreamD3D, System.IntPtr>)0x00698740)(ref this);

    /// <summary>Copies vertex data into the stream’s Direct3D vertex buffer, converting from a source format and optionally swapping Y and Z coordinates while respecting stream bounds.
    /// <code>Offset: 0x00698790
    /// bool __thiscall RenderVertexStreamD3D::FillData(RenderVertexStreamD3D*,const unsigned int,const unsigned int,const void*,const VertexFormatInfo*,const bool,unsigned int*)</code>
    /// </summary>
    /// <param name="FirstVertex">The index of the first vertex within the stream where data will be written.</param>
    /// <param name="NumVertices">Number of vertices to copy into the stream.</param>
    /// <param name="pSourceData">Pointer to the source vertex data in system memory.</param>
    /// <param name="SourceVFI">Vertex format information describing the layout of the source data.</param>
    /// <param name="SwapYAndZ">If true, Y and Z components are swapped during conversion.</param>
    /// <param name="nBaseVertexIndex">Outputs the base vertex index used for this operation.</param>
    /// <returns>True if the data was successfully transferred; otherwise false.</returns>
    public byte FillData(uint FirstVertex, uint NumVertices, void* pSourceData, ACBindings.Internal.VertexFormatInfo* SourceVFI, byte SwapYAndZ, uint* nBaseVertexIndex) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderVertexStreamD3D, uint, uint, void*, ACBindings.Internal.VertexFormatInfo*, byte, uint*, byte>)0x00698790)(ref this, FirstVertex, NumVertices, pSourceData, SourceVFI, SwapYAndZ, nBaseVertexIndex);

    /// <summary>Resets vertex indices and clears internal counters, incrementing the stream frame identifier.
    /// <code>Offset: 0x00698910
    /// void __thiscall RenderVertexStreamD3D::ResetVertexIndices(RenderVertexStreamD3D*)</code>
    /// </summary>
    public void ResetVertexIndices() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderVertexStreamD3D, void>)0x00698910)(ref this);

    /// <summary>Releases the Direct3D vertex buffer tied to this stream, clears any cached references in the render device, and resets internal bookkeeping.
    /// <code>Offset: 0x00698930
    /// bool __thiscall RenderVertexStreamD3D::PurgeResource(RenderVertexStreamD3D*)</code>
    /// </summary>
    /// <returns>True when the purge succeeds; otherwise returns false.</returns>
    public byte PurgeResource() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderVertexStreamD3D, byte>)0x00698930)(ref this);

    /// <summary>Releases the attached Direct3D vertex buffer, invalidates any cached device references, clears the write‑lock count, and marks the underlying graphics resource as not lost.
    /// <code>Offset: 0x00698990
    /// void __thiscall RenderVertexStreamD3D::End(RenderVertexStreamD3D*)</code>
    /// </summary>
    public void End() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderVertexStreamD3D, void>)0x00698990)(ref this);

    /// <summary>Releases the Direct3D vertex buffer tied to this stream, invalidates cached references, and resets the object's state so it can be safely discarded or reused.
    /// <code>Offset: 0x006989D0
    /// void __thiscall RenderVertexStreamD3D::Destroy(RenderVertexStreamD3D*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderVertexStreamD3D, void>)0x006989D0)(ref this);
}

