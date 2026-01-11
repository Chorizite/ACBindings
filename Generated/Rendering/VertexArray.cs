namespace ACBindings.Internal;

public unsafe struct VertexArray : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.ReferenceCountTemplate BaseClass_ReferenceCountTemplate; // ACBindings.Internal.ReferenceCountTemplate

    // Child Types
    public unsafe struct VertexArray_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VertexArray*, void> VertexArray_dtor_0; // function pointer
        public System.IntPtr Startup;
        public System.IntPtr Shutdown;
        public System.IntPtr Lock;
        public System.IntPtr Unlock;

        // Methods
    }

    // Members
    public ACBindings.Internal.VertexFormatInfo vertexFormat;
    public uint numVertices;
    public System.IntPtr vertices;
    public byte staticVertices;
    public byte locked;
    public byte m_bStripHWExtraTexCoords;
    public byte m_OnlyWriteOnce;
    public ACBindings.Internal.BBox m_BoundingBox;
    public ACBindings.Internal.SmartArray__uint m_InfluencedBoneIndexArray;
    public byte m_IsYAndZSwapped;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x00447CF0
    /// void __thiscall VertexArray::~VertexArray(VertexArray*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VertexArray, void>)0x00447CF0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005D83A0
    /// char __thiscall VertexArray::RequestStripHWExtraTexCoords(VertexArray*,bool)</code>
    /// </summary>
    public sbyte RequestStripHWExtraTexCoords(byte a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VertexArray, byte, sbyte>)0x005D83A0)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x005D83C0
    /// bool __thiscall VertexArray::Startup(VertexArray*,unsigned int,unsigned int,bool,bool,unsigned int)</code>
    /// </summary>
    public byte Startup(uint a2, uint a3, byte a4, byte a5, uint a6) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VertexArray, uint, uint, byte, byte, uint, byte>)0x005D83C0)(ref this, a2, a3, a4, a5, a6);

    /// <summary>
    /// <code>Offset: 0x005D8420
    /// int __thiscall VertexArray::Lock(VertexArray*,unsigned int,unsigned int)</code>
    /// </summary>
    public int Lock(uint a2, uint a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VertexArray, uint, uint, int>)0x005D8420)(ref this, a2, a3);

    /// <summary>
    /// <code>Offset: 0x005D85E0
    /// unsigned int __thiscall VertexArray::GenerateBoundingBox(VertexArray*)</code>
    /// </summary>
    public uint GenerateBoundingBox() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VertexArray, uint>)0x005D85E0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005D8650
    /// void __thiscall VertexArray::Begin(VertexArray*)</code>
    /// </summary>
    public void Begin() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VertexArray, void>)0x005D8650)(ref this);

    /// <summary>
    /// <code>Offset: 0x005D86A0
    /// void __thiscall VertexArray::End(void**)</code>
    /// </summary>
    public void End() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VertexArray, void>)0x005D86A0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005D86D0
    /// void __thiscall VertexArray::Shutdown(void**)</code>
    /// </summary>
    public void Shutdown() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VertexArray, void>)0x005D86D0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005D88B0
    /// void __thiscall VertexArray::Serialize(VertexArray*,Archive*)</code>
    /// </summary>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VertexArray, ACBindings.Internal.Archive*, void>)0x005D88B0)(ref this, io_archive);

    /// <summary>
    /// <code>Offset: 0x005D9630
    /// void __thiscall VertexArray::ComputeInfluencedBoneIndices(VertexArray*)</code>
    /// </summary>
    public void ComputeInfluencedBoneIndices() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VertexArray, void>)0x005D9630)(ref this);

    /// <summary>
    /// <code>Offset: 0x005D97C0
    /// void __thiscall VertexArray::Unlock(VertexArray*,bool,bool)</code>
    /// </summary>
    public void Unlock(byte a2, byte a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VertexArray, byte, byte, void>)0x005D97C0)(ref this, a2, a3);
}

