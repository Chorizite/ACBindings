namespace ACBindings.Internal;

public unsafe struct RenderIndexBufferD3D
{
    // Base Classes
    public ACBindings.Internal.RenderIndexBuffer BaseClass_RenderIndexBuffer; // ACBindings.Internal.RenderIndexBuffer

    // Child Types
    public unsafe struct RenderIndexBufferD3D_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderIndexBufferD3D*, void> RenderIndexBufferD3D_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderIndexBufferD3D*, uint, byte, byte, byte, byte, byte> Startup; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderIndexBufferD3D*, void> Shutdown; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderIndexBufferD3D*, ACBindings.Internal.RenderIndexBuffer*> Duplicate; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.RenderIndexStreamD3D* m_pIndexStream;

    // Methods

    /// <summary>
    /// <code>Offset: 0x00698E10
    /// void __thiscall RenderIndexBufferD3D::End(RenderIndexBufferD3D*)</code>
    /// </summary>
    public void End() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderIndexBufferD3D, void>)0x00698E10)(ref this);

    /// <summary>
    /// <code>Offset: 0x00698E30
    /// bool __thiscall RenderIndexBufferD3D::Startup(RenderIndexBufferD3D*,const unsigned int,const unsigned __int8,const bool,const bool,const bool)</code>
    /// </summary>
    public byte Startup(uint nNumIndices, byte indexSize, byte staticData, byte OnlyWriteOnce, byte bUseIndexCaching) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderIndexBufferD3D, uint, byte, byte, byte, byte, byte>)0x00698E30)(ref this, nNumIndices, indexSize, staticData, OnlyWriteOnce, bUseIndexCaching);

    /// <summary>
    /// <code>Offset: 0x00698ED0
    /// void __thiscall RenderIndexBufferD3D::Shutdown(RenderIndexBufferD3D*)</code>
    /// </summary>
    public void Shutdown() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderIndexBufferD3D, void>)0x00698ED0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00698F00
    /// bool __thiscall RenderIndexBufferD3D::UpdateIndexBuffer(RenderIndexBufferD3D*)</code>
    /// </summary>
    public byte UpdateIndexBuffer() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderIndexBufferD3D, byte>)0x00698F00)(ref this);

    /// <summary>
    /// <code>Offset: 0x00698FE0
    /// RenderIndexBuffer* __thiscall RenderIndexBufferD3D::Duplicate(RenderIndexBufferD3D*)</code>
    /// </summary>
    public ACBindings.Internal.RenderIndexBuffer* Duplicate() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderIndexBufferD3D, ACBindings.Internal.RenderIndexBuffer*>)0x00698FE0)(ref this);
}

