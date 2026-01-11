namespace ACBindings.Internal;

public unsafe struct RenderVertexStreamD3D
{
    // Base Classes
    public ACBindings.Internal.GraphicsResource BaseClass_GraphicsResource; // ACBindings.Internal.GraphicsResource

    // Child Types
    public unsafe struct RenderVertexStreamD3D_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderVertexStreamD3D*, void> RenderVertexStreamD3D_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderVertexStreamD3D*, ACBindings.Internal.GraphicsResource*, byte> CopyInto; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderVertexStreamD3D*, byte> PurgeResource; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderVertexStreamD3D*, byte> RestoreResource; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderVertexStreamD3D*, uint, uint, uint, byte> Create; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderVertexStreamD3D*, void> Destroy; // function pointer

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

    /// <summary>
    /// <code>Offset: 0x00698580
    /// void __thiscall RenderVertexStreamD3D::Begin(RenderVertexStreamD3D*)</code>
    /// </summary>
    public void Begin() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderVertexStreamD3D, void>)0x00698580)(ref this);

    /// <summary>
    /// <code>Offset: 0x006985C0
    /// bool __thiscall RenderVertexStreamD3D::Create(RenderVertexStreamD3D*,const unsigned int,const unsigned int,const unsigned int)</code>
    /// </summary>
    public byte Create(uint nNumVertices, uint VertexFormat, uint Flags) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderVertexStreamD3D, uint, uint, uint, byte>)0x006985C0)(ref this, nNumVertices, VertexFormat, Flags);

    /// <summary>
    /// <code>Offset: 0x00698620
    /// bool __thiscall RenderVertexStreamD3D::CreateD3DVertexBuffer(RenderVertexStreamD3D*)</code>
    /// </summary>
    public byte CreateD3DVertexBuffer() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderVertexStreamD3D, byte>)0x00698620)(ref this);

    /// <summary>
    /// <code>Offset: 0x00698740
    /// IDirect3DVertexBuffer9* __thiscall RenderVertexStreamD3D::GetD3DVertexBuffer(RenderVertexStreamD3D*)</code>
    /// </summary>
    public System.IntPtr GetD3DVertexBuffer() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderVertexStreamD3D, System.IntPtr>)0x00698740)(ref this);

    /// <summary>
    /// <code>Offset: 0x00698790
    /// bool __thiscall RenderVertexStreamD3D::FillData(RenderVertexStreamD3D*,const unsigned int,const unsigned int,const void*,const VertexFormatInfo*,const bool,unsigned int*)</code>
    /// </summary>
    public byte FillData(uint FirstVertex, uint NumVertices, void* pSourceData, ACBindings.Internal.VertexFormatInfo* SourceVFI, byte SwapYAndZ, uint* nBaseVertexIndex) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderVertexStreamD3D, uint, uint, void*, ACBindings.Internal.VertexFormatInfo*, byte, uint*, byte>)0x00698790)(ref this, FirstVertex, NumVertices, pSourceData, SourceVFI, SwapYAndZ, nBaseVertexIndex);

    /// <summary>
    /// <code>Offset: 0x00698910
    /// void __thiscall RenderVertexStreamD3D::ResetVertexIndices(RenderVertexStreamD3D*)</code>
    /// </summary>
    public void ResetVertexIndices() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderVertexStreamD3D, void>)0x00698910)(ref this);

    /// <summary>
    /// <code>Offset: 0x00698930
    /// bool __thiscall RenderVertexStreamD3D::PurgeResource(RenderVertexStreamD3D*)</code>
    /// </summary>
    public byte PurgeResource() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderVertexStreamD3D, byte>)0x00698930)(ref this);

    /// <summary>
    /// <code>Offset: 0x00698990
    /// void __thiscall RenderVertexStreamD3D::End(RenderVertexStreamD3D*)</code>
    /// </summary>
    public void End() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderVertexStreamD3D, void>)0x00698990)(ref this);

    /// <summary>
    /// <code>Offset: 0x006989D0
    /// void __thiscall RenderVertexStreamD3D::Destroy(RenderVertexStreamD3D*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderVertexStreamD3D, void>)0x006989D0)(ref this);
}

