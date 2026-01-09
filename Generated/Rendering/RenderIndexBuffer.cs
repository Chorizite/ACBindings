namespace ACBindings;

// RenderIndexBuffer
public unsafe struct RenderIndexBuffer
{
    // Child Types
    // RenderIndexBuffer_vtbl
    public unsafe struct RenderIndexBuffer_vtbl
    {
        // Members
        public System.IntPtr RenderIndexBuffer_dtor_0; // function pointer
        public System.IntPtr Startup; // function pointer
        public System.IntPtr Shutdown; // function pointer
        public System.IntPtr Duplicate; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public uint m_nNumIndices;
    public uint m_nActualNumIndices;
    public byte indexSize;
    public byte* indices;
    public byte staticData;
    public byte m_OnlyWriteOnce;
    public byte locked;
    public byte needRefresh;
    public byte m_bUseIndexCaching;
    public uint m_nMinVertexIndex;
    public uint m_nMaxVertexIndex;
    public byte m_bNeedRecalcMinMax;

    // Methods
    // void __thiscall RenderIndexBuffer::Begin(RenderIndexBuffer*)
    public void Begin() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderIndexBuffer, void>)0x0044CA60)(ref this);
    // void __thiscall RenderIndexBuffer::End(RenderIndexBuffer*)
    public void End() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderIndexBuffer, void>)0x0044CA90)(ref this);
    // bool __thiscall RenderIndexBuffer::Startup(RenderIndexBuffer*,const unsigned int,const unsigned __int8,const bool,const bool,const bool)
    public byte Startup(uint nNumIndices, byte indexSize, byte staticData, byte OnlyWriteOnce, byte bUseIndexCaching) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderIndexBuffer, uint, byte, byte, byte, byte, byte>)0x0044CAC0)(ref this, nNumIndices, indexSize, staticData, OnlyWriteOnce, bUseIndexCaching);
    // void __thiscall RenderIndexBuffer::Shutdown(RenderIndexBuffer*)
    public void Shutdown() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderIndexBuffer, void>)0x0044CB20)(ref this);
    // unsigned __int8* __thiscall RenderIndexBuffer::Lock(RenderIndexBuffer*)
    public byte* Lock() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderIndexBuffer, byte*>)0x0044CB70)(ref this);
    // void __thiscall RenderIndexBuffer::RecalculateMinMaxIndices(RenderIndexBuffer*)
    public void RecalculateMinMaxIndices() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderIndexBuffer, void>)0x0044CB90)(ref this);
    // bool __thiscall RenderIndexBuffer::SetRenderIndexBuffer(RenderIndexBuffer*,const RenderIndexBuffer*)
    public byte SetRenderIndexBuffer(ACBindings.RenderIndexBuffer* source) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderIndexBuffer, ACBindings.RenderIndexBuffer*, byte>)0x0044CCC0)(ref this, source);
    // void __thiscall RenderIndexBuffer::Serialize(RenderIndexBuffer*,Archive*)
    public void Serialize(ACBindings.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderIndexBuffer, ACBindings.Archive*, void>)0x0044CD60)(ref this, io_archive);
    // RenderIndexBuffer* __thiscall RenderIndexBuffer::Duplicate(RenderIndexBuffer*)
    public ACBindings.RenderIndexBuffer* Duplicate() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderIndexBuffer, ACBindings.RenderIndexBuffer*>)0x0044CDF0)(ref this);
    // bool __thiscall RenderIndexBuffer::FromFileNode(RenderIndexBuffer*,const PFileNode*)
    public byte FromFileNode(ACBindings.PFileNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderIndexBuffer, ACBindings.PFileNode*, byte>)0x0044CEC0)(ref this, node);
}

