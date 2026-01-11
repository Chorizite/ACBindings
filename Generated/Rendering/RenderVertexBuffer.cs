namespace ACBindings.Internal;

public unsafe struct RenderVertexBuffer
{
    // Base Classes
    public ACBindings.Internal.VertexArray BaseClass_VertexArray; // ACBindings.Internal.VertexArray

    // Child Types
    public unsafe struct RenderVertexBuffer_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderVertexBuffer*, void> RenderVertexBuffer_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderVertexBuffer*, uint, uint, byte, byte, uint, byte> Startup; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderVertexBuffer*, void> Shutdown; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderVertexBuffer*, uint, uint, System.IntPtr> Lock; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderVertexBuffer*, byte, byte, void> Unlock; // function pointer
        public System.IntPtr RenderIndexedPrimitives;
        public System.IntPtr RenderPrimitives;
        public System.IntPtr LockVirtualArray;
        public System.IntPtr UnlockVirtualArray;
        public System.IntPtr AddDirtyRange;

        // Methods
    }

    // Members
    public byte m_UseVirtualArray;
    public ACBindings.Internal.VertexFormatInfo m_HardwareVertexFormat;
    public System.IntPtr m_pVirtualArray;
    public byte m_IsVirtualArrayLocked;
    public byte m_NeedRefreshVirtualArray;
    public ACBindings.Internal.BBox m_VirtualArrayBoundingBox;
    public byte m_IsVirtualArrayBoundingBoxValid;

    // Generated Constructor
    public RenderVertexBuffer() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x004474E0
    /// RenderVertexBuffer* __thiscall RenderVertexBuffer::Begin(RenderVertexBuffer*)</code>
    /// </summary>
    public ACBindings.Internal.RenderVertexBuffer* Begin() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderVertexBuffer, ACBindings.Internal.RenderVertexBuffer*>)0x004474E0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00447520
    /// void __thiscall RenderVertexBuffer::End(void**)</code>
    /// </summary>
    public void End() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderVertexBuffer, void>)0x00447520)(ref this);

    /// <summary>
    /// <code>Offset: 0x00447550
    /// char __thiscall RenderVertexBuffer::Startup(RenderVertexBuffer*,unsigned int,unsigned int,bool,bool,unsigned int)</code>
    /// </summary>
    public sbyte Startup(uint a2, uint a3, byte a4, byte a5, uint a6) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderVertexBuffer, uint, uint, byte, byte, uint, sbyte>)0x00447550)(ref this, a2, a3, a4, a5, a6);

    /// <summary>
    /// <code>Offset: 0x00447620
    /// void __thiscall RenderVertexBuffer::Shutdown(void**)</code>
    /// </summary>
    public void Shutdown() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderVertexBuffer, void>)0x00447620)(ref this);

    /// <summary>
    /// <code>Offset: 0x00447680
    /// char __thiscall RenderVertexBuffer::UnlockVirtualArray(RenderVertexBuffer*)</code>
    /// </summary>
    public sbyte UnlockVirtualArray() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderVertexBuffer, sbyte>)0x00447680)(ref this);

    /// <summary>
    /// <code>Offset: 0x004476A0
    /// char __thiscall RenderVertexBuffer::Unlock(RenderVertexBuffer*,bool,bool)</code>
    /// </summary>
    public sbyte Unlock(byte a2, byte a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderVertexBuffer, byte, byte, sbyte>)0x004476A0)(ref this, a2, a3);

    /// <summary>
    /// <code>Offset: 0x004476D0
    /// void __cdecl RenderVertexBuffer::TransferVertices(const void*,const VertexFormatInfo*,void*,const VertexFormatInfo*,const unsigned int,const bool)</code>
    /// </summary>
    public static void TransferVertices(void* pSourceData, ACBindings.Internal.VertexFormatInfo* SourceVFI, System.IntPtr pDestData, ACBindings.Internal.VertexFormatInfo* DestVFI, uint NumVertices, byte SwapYAndZ) => ((delegate* unmanaged[Cdecl]<void*, ACBindings.Internal.VertexFormatInfo*, System.IntPtr, ACBindings.Internal.VertexFormatInfo*, uint, byte, void>)0x004476D0)(pSourceData, SourceVFI, pDestData, DestVFI, NumVertices, SwapYAndZ);

    /// <summary>
    /// <code>Offset: 0x00447AA0
    /// char __thiscall RenderVertexBuffer::RenderIndexedUsingMaterial(RenderVertexBuffer*,enum PrimType,unsigned int,unsigned int,unsigned int,unsigned int,unsigned int,RenderIndexBuffer*,const RenderMaterial*,const RenderMaterial*,enum RenderPassType,RGBAColor*,RGBAColor*,bool,int,unsigned int*,unsigned int*,int)</code>
    /// </summary>
    public sbyte RenderIndexedUsingMaterial(ACBindings.Internal.PrimType a2, uint a3, uint a4, uint a5, uint a6, uint a7, ACBindings.Internal.RenderIndexBuffer* a8, ACBindings.Internal.RenderMaterial* a9, ACBindings.Internal.RenderMaterial* a10, ACBindings.Internal.RenderPassType a11, ACBindings.Internal.RGBAColor* DiffuseColorScale, ACBindings.Internal.RGBAColor* AmbientLightBoost, byte ForceTranslucent, int a15, uint* a16, uint* a17, int a18) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderVertexBuffer, ACBindings.Internal.PrimType, uint, uint, uint, uint, uint, ACBindings.Internal.RenderIndexBuffer*, ACBindings.Internal.RenderMaterial*, ACBindings.Internal.RenderMaterial*, ACBindings.Internal.RenderPassType, ACBindings.Internal.RGBAColor*, ACBindings.Internal.RGBAColor*, byte, int, uint*, uint*, int, sbyte>)0x00447AA0)(ref this, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, DiffuseColorScale, AmbientLightBoost, ForceTranslucent, a15, a16, a17, a18);

    /// <summary>
    /// <code>Offset: 0x00447BE0
    /// char __thiscall RenderVertexBuffer::RenderUsingMaterial(RenderVertexBuffer*,enum PrimType,unsigned int,unsigned int,const RenderMaterial*,const RenderMaterial*,enum RenderPassType,RGBAColor*,RGBAColor*,unsigned int*,unsigned int*)</code>
    /// </summary>
    public sbyte RenderUsingMaterial(ACBindings.Internal.PrimType a2, uint a3, uint a4, ACBindings.Internal.RenderMaterial* a5, ACBindings.Internal.RenderMaterial* a6, ACBindings.Internal.RenderPassType a7, ACBindings.Internal.RGBAColor* DiffuseColorScale, ACBindings.Internal.RGBAColor* AmbientLightBoost, uint* a10, uint* a11) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderVertexBuffer, ACBindings.Internal.PrimType, uint, uint, ACBindings.Internal.RenderMaterial*, ACBindings.Internal.RenderMaterial*, ACBindings.Internal.RenderPassType, ACBindings.Internal.RGBAColor*, ACBindings.Internal.RGBAColor*, uint*, uint*, sbyte>)0x00447BE0)(ref this, a2, a3, a4, a5, a6, a7, DiffuseColorScale, AmbientLightBoost, a10, a11);

    /// <summary>
    /// <code>Offset: 0x00447D80
    /// RenderVertexBuffer* __thiscall RenderVertexBuffer::RenderVertexBuffer(RenderVertexBuffer*)</code>
    /// </summary>
    public ACBindings.Internal.RenderVertexBuffer* _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderVertexBuffer, ACBindings.Internal.RenderVertexBuffer*>)0x00447D80)(ref this);

    /// <summary>
    /// <code>Offset: 0x00447DF0
    /// char __thiscall RenderVertexBuffer::RenderIndexedPrimitives(RenderVertexBuffer*,enum PrimType,unsigned int,unsigned int,unsigned int,unsigned int,unsigned int,RenderIndexBuffer*,bool,unsigned int*,unsigned int*,bool)</code>
    /// </summary>
    public sbyte RenderIndexedPrimitives(ACBindings.Internal.PrimType a2, uint a3, uint a4, uint a5, uint a6, uint a7, ACBindings.Internal.RenderIndexBuffer* a8, byte a9, uint* a10, uint* a11, byte a12) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderVertexBuffer, ACBindings.Internal.PrimType, uint, uint, uint, uint, uint, ACBindings.Internal.RenderIndexBuffer*, byte, uint*, uint*, byte, sbyte>)0x00447DF0)(ref this, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12);

    /// <summary>
    /// <code>Offset: 0x00447E00
    /// char __thiscall RenderVertexBuffer::RenderPrimitives(RenderVertexBuffer*,enum PrimType,unsigned int,unsigned int,unsigned int*,unsigned int*)</code>
    /// </summary>
    public sbyte RenderPrimitives(ACBindings.Internal.PrimType a2, uint a3, uint a4, uint* a5, uint* a6) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderVertexBuffer, ACBindings.Internal.PrimType, uint, uint, uint*, uint*, sbyte>)0x00447E00)(ref this, a2, a3, a4, a5, a6);

    /// <summary>
    /// <code>Offset: 0x00447E40
    /// RenderVertexBuffer* RenderVertexBuffer::AllocateVertexBuffer()</code>
    /// </summary>
    public static ACBindings.Internal.RenderVertexBuffer* AllocateVertexBuffer() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.RenderVertexBuffer*>)0x00447E40)();

    /// <summary>
    /// <code>Offset: 0x00447E70
    /// void __thiscall RenderVertexBuffer::RefreshVirtualArray(RenderVertexBuffer*)</code>
    /// </summary>
    public void RefreshVirtualArray() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderVertexBuffer, void>)0x00447E70)(ref this);

    /// <summary>
    /// <code>Offset: 0x00447EE0
    /// unsigned int __thiscall RenderVertexBuffer::LockVirtualArray(RenderVertexBuffer*,int,int)</code>
    /// </summary>
    public uint LockVirtualArray(int a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderVertexBuffer, int, int, uint>)0x00447EE0)(ref this, a2, a3);
}

