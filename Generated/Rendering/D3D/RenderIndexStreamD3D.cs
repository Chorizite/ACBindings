namespace ACBindings.Internal;

public unsafe struct RenderIndexStreamD3D
{
    // Base Classes
    public ACBindings.Internal.GraphicsResource BaseClass_GraphicsResource; // ACBindings.Internal.GraphicsResource

    // Child Types
    public unsafe struct RenderIndexStreamD3D_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderIndexStreamD3D*, void> RenderIndexStreamD3D_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderIndexStreamD3D*, ACBindings.Internal.GraphicsResource*, byte> CopyInto; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderIndexStreamD3D*, byte> PurgeResource; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderIndexStreamD3D*, byte> RestoreResource; // function pointer

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

    /// <summary>
    /// <code>Offset: 0x00698980
    /// bool __thiscall RenderIndexStreamD3D::RestoreResource(RenderIndexStreamD3D*)</code>
    /// </summary>
    public byte RestoreResource() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderIndexStreamD3D, byte>)0x00698980)(ref this);

    /// <summary>
    /// <code>Offset: 0x00698A40
    /// void __thiscall RenderIndexStreamD3D::RenderIndexStreamD3D(RenderIndexStreamD3D*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderIndexStreamD3D, void>)0x00698A40)(ref this);

    /// <summary>
    /// <code>Offset: 0x00698A70
    /// bool __thiscall RenderIndexStreamD3D::Init(RenderIndexStreamD3D*,const unsigned int,const unsigned int)</code>
    /// </summary>
    public byte Init(uint NumIndices, uint Flags) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderIndexStreamD3D, uint, uint, byte>)0x00698A70)(ref this, NumIndices, Flags);

    /// <summary>
    /// <code>Offset: 0x00698AB0
    /// bool __thiscall RenderIndexStreamD3D::CreateDirect3DIndexBuffer(RenderIndexStreamD3D*)</code>
    /// </summary>
    public byte CreateDirect3DIndexBuffer() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderIndexStreamD3D, byte>)0x00698AB0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00698BC0
    /// bool __thiscall RenderIndexStreamD3D::PurgeResource(RenderIndexStreamD3D*)</code>
    /// </summary>
    public byte PurgeResource() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderIndexStreamD3D, byte>)0x00698BC0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00698C00
    /// IDirect3DIndexBuffer9* __thiscall RenderIndexStreamD3D::GetDirect3DIndexBuffer(RenderIndexStreamD3D*)</code>
    /// </summary>
    public System.IntPtr GetDirect3DIndexBuffer() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderIndexStreamD3D, System.IntPtr>)0x00698C00)(ref this);

    /// <summary>
    /// <code>Offset: 0x00698C50
    /// bool __thiscall RenderIndexStreamD3D::FillData(RenderIndexStreamD3D*,const unsigned int,const void*,unsigned int*)</code>
    /// </summary>
    public byte FillData(uint NumIndices, void* pSourceData, uint* FirstRemoteIndex) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderIndexStreamD3D, uint, void*, uint*, byte>)0x00698C50)(ref this, NumIndices, pSourceData, FirstRemoteIndex);

    /// <summary>
    /// <code>Offset: 0x00698D90
    /// void __thiscall RenderIndexStreamD3D::NotifyFrameChanged(RenderIndexStreamD3D*)</code>
    /// </summary>
    public void NotifyFrameChanged() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderIndexStreamD3D, void>)0x00698D90)(ref this);
}

