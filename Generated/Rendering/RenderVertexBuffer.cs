namespace ACBindings;

// RenderVertexBuffer
public unsafe struct RenderVertexBuffer
{
    // Base Classes
    public ACBindings.VertexArray BaseClass_VertexArray; // ACBindings.VertexArray

    // Child Types
    // RenderVertexBuffer_vtbl
    public unsafe struct RenderVertexBuffer_vtbl
    {
        // Members
        public System.IntPtr RenderVertexBuffer_dtor_0; // function pointer
        public System.IntPtr Startup; // function pointer
        public System.IntPtr Shutdown; // function pointer
        public System.IntPtr Lock; // function pointer
        public System.IntPtr Unlock; // function pointer
        public System.IntPtr RenderIndexedPrimitives;
        public System.IntPtr RenderPrimitives;
        public System.IntPtr LockVirtualArray;
        public System.IntPtr UnlockVirtualArray;
        public System.IntPtr AddDirtyRange;

        // Methods
    }

    // Members
    public byte m_UseVirtualArray;
    public ACBindings.VertexFormatInfo m_HardwareVertexFormat;
    public System.IntPtr m_pVirtualArray;
    public byte m_IsVirtualArrayLocked;
    public byte m_NeedRefreshVirtualArray;
    public ACBindings.BBox m_VirtualArrayBoundingBox;
    public byte m_IsVirtualArrayBoundingBoxValid;

    // Generated Constructor
    public RenderVertexBuffer() {
        _ConstructorInternal();
    }

    // Methods
    // RenderVertexBuffer* __thiscall RenderVertexBuffer::Begin(RenderVertexBuffer*)
    public ACBindings.RenderVertexBuffer* Begin() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderVertexBuffer, ACBindings.RenderVertexBuffer*>)0x004474E0)(ref this);
    // void __thiscall RenderVertexBuffer::End(void**)
    public void End() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderVertexBuffer, void>)0x00447520)(ref this);
    // char __thiscall RenderVertexBuffer::Startup(RenderVertexBuffer*,unsigned int,unsigned int,bool,bool,unsigned int)
    public sbyte Startup(uint a2, uint a3, byte a4, byte a5, uint a6) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderVertexBuffer, uint, uint, byte, byte, uint, sbyte>)0x00447550)(ref this, a2, a3, a4, a5, a6);
    // void __thiscall RenderVertexBuffer::Shutdown(void**)
    public void Shutdown() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderVertexBuffer, void>)0x00447620)(ref this);
    // char __thiscall RenderVertexBuffer::UnlockVirtualArray(RenderVertexBuffer*)
    public sbyte UnlockVirtualArray() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderVertexBuffer, sbyte>)0x00447680)(ref this);
    // char __thiscall RenderVertexBuffer::Unlock(RenderVertexBuffer*,bool,bool)
    public sbyte Unlock(byte a2, byte a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderVertexBuffer, byte, byte, sbyte>)0x004476A0)(ref this, a2, a3);
    // void __cdecl RenderVertexBuffer::TransferVertices(const void*,const VertexFormatInfo*,void*,const VertexFormatInfo*,const unsigned int,const bool)
    public static void TransferVertices(void* pSourceData, ACBindings.VertexFormatInfo* SourceVFI, System.IntPtr pDestData, ACBindings.VertexFormatInfo* DestVFI, uint NumVertices, byte SwapYAndZ) => ((delegate* unmanaged[Cdecl]<void*, ACBindings.VertexFormatInfo*, System.IntPtr, ACBindings.VertexFormatInfo*, uint, byte, void>)0x004476D0)(pSourceData, SourceVFI, pDestData, DestVFI, NumVertices, SwapYAndZ);
    // char __thiscall RenderVertexBuffer::RenderIndexedUsingMaterial(RenderVertexBuffer*,enum PrimType,unsigned int,unsigned int,unsigned int,unsigned int,unsigned int,RenderIndexBuffer*,const RenderMaterial*,const RenderMaterial*,enum RenderPassType,RGBAColor*,RGBAColor*,bool,int,unsigned int*,unsigned int*,int)
    public sbyte RenderIndexedUsingMaterial(ACBindings.PrimType a2, uint a3, uint a4, uint a5, uint a6, uint a7, ACBindings.RenderIndexBuffer* a8, ACBindings.RenderMaterial* a9, ACBindings.RenderMaterial* a10, ACBindings.RenderPassType a11, ACBindings.RGBAColor* DiffuseColorScale, ACBindings.RGBAColor* AmbientLightBoost, byte ForceTranslucent, int a15, uint* a16, uint* a17, int a18) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderVertexBuffer, ACBindings.PrimType, uint, uint, uint, uint, uint, ACBindings.RenderIndexBuffer*, ACBindings.RenderMaterial*, ACBindings.RenderMaterial*, ACBindings.RenderPassType, ACBindings.RGBAColor*, ACBindings.RGBAColor*, byte, int, uint*, uint*, int, sbyte>)0x00447AA0)(ref this, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, DiffuseColorScale, AmbientLightBoost, ForceTranslucent, a15, a16, a17, a18);
    // char __thiscall RenderVertexBuffer::RenderUsingMaterial(RenderVertexBuffer*,enum PrimType,unsigned int,unsigned int,const RenderMaterial*,const RenderMaterial*,enum RenderPassType,RGBAColor*,RGBAColor*,unsigned int*,unsigned int*)
    public sbyte RenderUsingMaterial(ACBindings.PrimType a2, uint a3, uint a4, ACBindings.RenderMaterial* a5, ACBindings.RenderMaterial* a6, ACBindings.RenderPassType a7, ACBindings.RGBAColor* DiffuseColorScale, ACBindings.RGBAColor* AmbientLightBoost, uint* a10, uint* a11) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderVertexBuffer, ACBindings.PrimType, uint, uint, ACBindings.RenderMaterial*, ACBindings.RenderMaterial*, ACBindings.RenderPassType, ACBindings.RGBAColor*, ACBindings.RGBAColor*, uint*, uint*, sbyte>)0x00447BE0)(ref this, a2, a3, a4, a5, a6, a7, DiffuseColorScale, AmbientLightBoost, a10, a11);
    // RenderVertexBuffer* __thiscall RenderVertexBuffer::RenderVertexBuffer(RenderVertexBuffer*)
    public ACBindings.RenderVertexBuffer* _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderVertexBuffer, ACBindings.RenderVertexBuffer*>)0x00447D80)(ref this);
    // char __thiscall RenderVertexBuffer::RenderIndexedPrimitives(RenderVertexBuffer*,enum PrimType,unsigned int,unsigned int,unsigned int,unsigned int,unsigned int,RenderIndexBuffer*,bool,unsigned int*,unsigned int*,bool)
    public sbyte RenderIndexedPrimitives(ACBindings.PrimType a2, uint a3, uint a4, uint a5, uint a6, uint a7, ACBindings.RenderIndexBuffer* a8, byte a9, uint* a10, uint* a11, byte a12) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderVertexBuffer, ACBindings.PrimType, uint, uint, uint, uint, uint, ACBindings.RenderIndexBuffer*, byte, uint*, uint*, byte, sbyte>)0x00447DF0)(ref this, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12);
    // char __thiscall RenderVertexBuffer::RenderPrimitives(RenderVertexBuffer*,enum PrimType,unsigned int,unsigned int,unsigned int*,unsigned int*)
    public sbyte RenderPrimitives(ACBindings.PrimType a2, uint a3, uint a4, uint* a5, uint* a6) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderVertexBuffer, ACBindings.PrimType, uint, uint, uint*, uint*, sbyte>)0x00447E00)(ref this, a2, a3, a4, a5, a6);
    // RenderVertexBuffer* RenderVertexBuffer::AllocateVertexBuffer()
    public static ACBindings.RenderVertexBuffer* AllocateVertexBuffer() => ((delegate* unmanaged[Cdecl]<ACBindings.RenderVertexBuffer*>)0x00447E40)();
    // void __thiscall RenderVertexBuffer::RefreshVirtualArray(RenderVertexBuffer*)
    public void RefreshVirtualArray() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderVertexBuffer, void>)0x00447E70)(ref this);
    // unsigned int __thiscall RenderVertexBuffer::LockVirtualArray(RenderVertexBuffer*,int,int)
    public uint LockVirtualArray(int a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderVertexBuffer, int, int, uint>)0x00447EE0)(ref this, a2, a3);
}

