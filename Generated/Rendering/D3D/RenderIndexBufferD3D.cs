namespace ACBindings;

// RenderIndexBufferD3D
public unsafe struct RenderIndexBufferD3D
{
    // Base Classes
    public ACBindings.RenderIndexBuffer BaseClass_RenderIndexBuffer; // ACBindings.RenderIndexBuffer

    // Child Types
    // RenderIndexBufferD3D_vtbl
    public unsafe struct RenderIndexBufferD3D_vtbl
    {
        // Members
        public System.IntPtr RenderIndexBufferD3D_dtor_0; // function pointer
        public System.IntPtr Startup; // function pointer
        public System.IntPtr Shutdown; // function pointer
        public System.IntPtr Duplicate; // function pointer

        // Methods
    }

    // Members
    public ACBindings.RenderIndexStreamD3D* m_pIndexStream;

    // Methods
    // void __thiscall RenderIndexBufferD3D::End(RenderIndexBufferD3D*)
    public void End() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderIndexBufferD3D, void>)0x00698E10)(ref this);
    // bool __thiscall RenderIndexBufferD3D::Startup(RenderIndexBufferD3D*,const unsigned int,const unsigned __int8,const bool,const bool,const bool)
    public byte Startup(uint nNumIndices, byte indexSize, byte staticData, byte OnlyWriteOnce, byte bUseIndexCaching) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderIndexBufferD3D, uint, byte, byte, byte, byte, byte>)0x00698E30)(ref this, nNumIndices, indexSize, staticData, OnlyWriteOnce, bUseIndexCaching);
    // void __thiscall RenderIndexBufferD3D::Shutdown(RenderIndexBufferD3D*)
    public void Shutdown() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderIndexBufferD3D, void>)0x00698ED0)(ref this);
    // bool __thiscall RenderIndexBufferD3D::UpdateIndexBuffer(RenderIndexBufferD3D*)
    public byte UpdateIndexBuffer() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderIndexBufferD3D, byte>)0x00698F00)(ref this);
    // RenderIndexBuffer* __thiscall RenderIndexBufferD3D::Duplicate(RenderIndexBufferD3D*)
    public ACBindings.RenderIndexBuffer* Duplicate() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderIndexBufferD3D, ACBindings.RenderIndexBuffer*>)0x00698FE0)(ref this);
}

