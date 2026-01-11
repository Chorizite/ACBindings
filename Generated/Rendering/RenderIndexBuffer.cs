namespace ACBindings.Internal;

public unsafe struct RenderIndexBuffer
{
    // Child Types
    public unsafe struct RenderIndexBuffer_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderIndexBuffer*, void> RenderIndexBuffer_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderIndexBuffer*, uint, byte, byte, byte, byte, byte> Startup; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderIndexBuffer*, void> Shutdown; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderIndexBuffer*, ACBindings.Internal.RenderIndexBuffer*> Duplicate; // function pointer

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

    /// <summary>
    /// <code>Offset: 0x0044CA60
    /// void __thiscall RenderIndexBuffer::Begin(RenderIndexBuffer*)</code>
    /// </summary>
    public void Begin() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderIndexBuffer, void>)0x0044CA60)(ref this);

    /// <summary>
    /// <code>Offset: 0x0044CA90
    /// void __thiscall RenderIndexBuffer::End(RenderIndexBuffer*)</code>
    /// </summary>
    public void End() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderIndexBuffer, void>)0x0044CA90)(ref this);

    /// <summary>
    /// <code>Offset: 0x0044CAC0
    /// bool __thiscall RenderIndexBuffer::Startup(RenderIndexBuffer*,const unsigned int,const unsigned __int8,const bool,const bool,const bool)</code>
    /// </summary>
    public byte Startup(uint nNumIndices, byte indexSize, byte staticData, byte OnlyWriteOnce, byte bUseIndexCaching) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderIndexBuffer, uint, byte, byte, byte, byte, byte>)0x0044CAC0)(ref this, nNumIndices, indexSize, staticData, OnlyWriteOnce, bUseIndexCaching);

    /// <summary>
    /// <code>Offset: 0x0044CB20
    /// void __thiscall RenderIndexBuffer::Shutdown(RenderIndexBuffer*)</code>
    /// </summary>
    public void Shutdown() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderIndexBuffer, void>)0x0044CB20)(ref this);

    /// <summary>
    /// <code>Offset: 0x0044CB70
    /// unsigned __int8* __thiscall RenderIndexBuffer::Lock(RenderIndexBuffer*)</code>
    /// </summary>
    public byte* Lock() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderIndexBuffer, byte*>)0x0044CB70)(ref this);

    /// <summary>
    /// <code>Offset: 0x0044CB90
    /// void __thiscall RenderIndexBuffer::RecalculateMinMaxIndices(RenderIndexBuffer*)</code>
    /// </summary>
    public void RecalculateMinMaxIndices() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderIndexBuffer, void>)0x0044CB90)(ref this);

    /// <summary>
    /// <code>Offset: 0x0044CCC0
    /// bool __thiscall RenderIndexBuffer::SetRenderIndexBuffer(RenderIndexBuffer*,const RenderIndexBuffer*)</code>
    /// </summary>
    public byte SetRenderIndexBuffer(ACBindings.Internal.RenderIndexBuffer* source) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderIndexBuffer, ACBindings.Internal.RenderIndexBuffer*, byte>)0x0044CCC0)(ref this, source);

    /// <summary>
    /// <code>Offset: 0x0044CD60
    /// void __thiscall RenderIndexBuffer::Serialize(RenderIndexBuffer*,Archive*)</code>
    /// </summary>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderIndexBuffer, ACBindings.Internal.Archive*, void>)0x0044CD60)(ref this, io_archive);

    /// <summary>
    /// <code>Offset: 0x0044CDF0
    /// RenderIndexBuffer* __thiscall RenderIndexBuffer::Duplicate(RenderIndexBuffer*)</code>
    /// </summary>
    public ACBindings.Internal.RenderIndexBuffer* Duplicate() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderIndexBuffer, ACBindings.Internal.RenderIndexBuffer*>)0x0044CDF0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0044CEC0
    /// bool __thiscall RenderIndexBuffer::FromFileNode(RenderIndexBuffer*,const PFileNode*)</code>
    /// </summary>
    public byte FromFileNode(ACBindings.Internal.PFileNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderIndexBuffer, ACBindings.Internal.PFileNode*, byte>)0x0044CEC0)(ref this, node);
}

