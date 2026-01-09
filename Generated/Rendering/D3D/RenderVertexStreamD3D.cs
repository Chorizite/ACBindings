namespace ACBindings;

// RenderVertexStreamD3D
public unsafe struct RenderVertexStreamD3D
{
    // Base Classes
    public ACBindings.GraphicsResource BaseClass_GraphicsResource; // ACBindings.GraphicsResource

    // Child Types
    // RenderVertexStreamD3D_vtbl
    public unsafe struct RenderVertexStreamD3D_vtbl
    {
        // Members
        public System.IntPtr RenderVertexStreamD3D_dtor_0; // function pointer
        public System.IntPtr CopyInto; // function pointer
        public System.IntPtr PurgeResource; // function pointer
        public System.IntPtr RestoreResource; // function pointer
        public System.IntPtr Create; // function pointer
        public System.IntPtr Destroy; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr m_pD3DVertexBuffer;
    public uint m_nNumVertices;
    public ACBindings.VertexFormatInfo m_VertexFormatInfo;
    public uint m_Flags;
    public uint m_nNextVertexIndex;
    public uint m_nIdealVertexCount;
    public uint m_nStreamFrameID;
    public uint m_WriteLockCount;

    // Methods
    // void __thiscall RenderVertexStreamD3D::Begin(RenderVertexStreamD3D*)
    public void Begin() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderVertexStreamD3D, void>)0x00698580)(ref this);
    // bool __thiscall RenderVertexStreamD3D::Create(RenderVertexStreamD3D*,const unsigned int,const unsigned int,const unsigned int)
    public byte Create(uint nNumVertices, uint VertexFormat, uint Flags) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderVertexStreamD3D, uint, uint, uint, byte>)0x006985C0)(ref this, nNumVertices, VertexFormat, Flags);
    // bool __thiscall RenderVertexStreamD3D::CreateD3DVertexBuffer(RenderVertexStreamD3D*)
    public byte CreateD3DVertexBuffer() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderVertexStreamD3D, byte>)0x00698620)(ref this);
    // IDirect3DVertexBuffer9* __thiscall RenderVertexStreamD3D::GetD3DVertexBuffer(RenderVertexStreamD3D*)
    public System.IntPtr GetD3DVertexBuffer() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderVertexStreamD3D, System.IntPtr>)0x00698740)(ref this);
    // bool __thiscall RenderVertexStreamD3D::FillData(RenderVertexStreamD3D*,const unsigned int,const unsigned int,const void*,const VertexFormatInfo*,const bool,unsigned int*)
    public byte FillData(uint FirstVertex, uint NumVertices, void* pSourceData, ACBindings.VertexFormatInfo* SourceVFI, byte SwapYAndZ, uint* nBaseVertexIndex) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderVertexStreamD3D, uint, uint, void*, ACBindings.VertexFormatInfo*, byte, uint*, byte>)0x00698790)(ref this, FirstVertex, NumVertices, pSourceData, SourceVFI, SwapYAndZ, nBaseVertexIndex);
    // void __thiscall RenderVertexStreamD3D::ResetVertexIndices(RenderVertexStreamD3D*)
    public void ResetVertexIndices() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderVertexStreamD3D, void>)0x00698910)(ref this);
    // bool __thiscall RenderVertexStreamD3D::PurgeResource(RenderVertexStreamD3D*)
    public byte PurgeResource() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderVertexStreamD3D, byte>)0x00698930)(ref this);
    // void __thiscall RenderVertexStreamD3D::End(RenderVertexStreamD3D*)
    public void End() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderVertexStreamD3D, void>)0x00698990)(ref this);
    // void __thiscall RenderVertexStreamD3D::Destroy(RenderVertexStreamD3D*)
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderVertexStreamD3D, void>)0x006989D0)(ref this);
}

