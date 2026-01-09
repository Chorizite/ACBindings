namespace ACBindings;

// RenderIndexStreamD3D
public unsafe struct RenderIndexStreamD3D
{
    // Base Classes
    public ACBindings.GraphicsResource BaseClass_GraphicsResource; // ACBindings.GraphicsResource

    // Child Types
    // RenderIndexStreamD3D_vtbl
    public unsafe struct RenderIndexStreamD3D_vtbl
    {
        // Members
        public System.IntPtr RenderIndexStreamD3D_dtor_0; // function pointer
        public System.IntPtr CopyInto; // function pointer
        public System.IntPtr PurgeResource; // function pointer
        public System.IntPtr RestoreResource; // function pointer

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
    // bool __thiscall RenderIndexStreamD3D::RestoreResource(RenderIndexStreamD3D*)
    public byte RestoreResource() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderIndexStreamD3D, byte>)0x00698980)(ref this);
    // void __thiscall RenderIndexStreamD3D::RenderIndexStreamD3D(RenderIndexStreamD3D*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderIndexStreamD3D, void>)0x00698A40)(ref this);
    // bool __thiscall RenderIndexStreamD3D::Init(RenderIndexStreamD3D*,const unsigned int,const unsigned int)
    public byte Init(uint NumIndices, uint Flags) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderIndexStreamD3D, uint, uint, byte>)0x00698A70)(ref this, NumIndices, Flags);
    // bool __thiscall RenderIndexStreamD3D::CreateDirect3DIndexBuffer(RenderIndexStreamD3D*)
    public byte CreateDirect3DIndexBuffer() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderIndexStreamD3D, byte>)0x00698AB0)(ref this);
    // bool __thiscall RenderIndexStreamD3D::PurgeResource(RenderIndexStreamD3D*)
    public byte PurgeResource() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderIndexStreamD3D, byte>)0x00698BC0)(ref this);
    // IDirect3DIndexBuffer9* __thiscall RenderIndexStreamD3D::GetDirect3DIndexBuffer(RenderIndexStreamD3D*)
    public System.IntPtr GetDirect3DIndexBuffer() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderIndexStreamD3D, System.IntPtr>)0x00698C00)(ref this);
    // bool __thiscall RenderIndexStreamD3D::FillData(RenderIndexStreamD3D*,const unsigned int,const void*,unsigned int*)
    public byte FillData(uint NumIndices, void* pSourceData, uint* FirstRemoteIndex) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderIndexStreamD3D, uint, void*, uint*, byte>)0x00698C50)(ref this, NumIndices, pSourceData, FirstRemoteIndex);
    // void __thiscall RenderIndexStreamD3D::NotifyFrameChanged(RenderIndexStreamD3D*)
    public void NotifyFrameChanged() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderIndexStreamD3D, void>)0x00698D90)(ref this);
}

