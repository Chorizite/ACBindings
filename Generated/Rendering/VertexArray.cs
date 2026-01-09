namespace ACBindings;

// VertexArray
public unsafe struct VertexArray : System.IDisposable
{
    // Base Classes
    public ACBindings.ReferenceCountTemplate BaseClass_ReferenceCountTemplate; // ACBindings.ReferenceCountTemplate

    // Child Types
    // VertexArray_vtbl
    public unsafe struct VertexArray_vtbl
    {
        // Members
        public System.IntPtr VertexArray_dtor_0; // function pointer
        public System.IntPtr Startup;
        public System.IntPtr Shutdown;
        public System.IntPtr Lock;
        public System.IntPtr Unlock;

        // Methods
    }

    // Members
    public ACBindings.VertexFormatInfo vertexFormat;
    public uint numVertices;
    public System.IntPtr vertices;
    public byte staticVertices;
    public byte locked;
    public byte m_bStripHWExtraTexCoords;
    public byte m_OnlyWriteOnce;
    public ACBindings.BBox m_BoundingBox;
    public ACBindings.SmartArray__uint m_InfluencedBoneIndexArray;
    public byte m_IsYAndZSwapped;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall VertexArray::~VertexArray(VertexArray*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.VertexArray, void>)0x00447CF0)(ref this);
    // char __thiscall VertexArray::RequestStripHWExtraTexCoords(VertexArray*,bool)
    public sbyte RequestStripHWExtraTexCoords(byte a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.VertexArray, byte, sbyte>)0x005D83A0)(ref this, a2);
    // bool __thiscall VertexArray::Startup(VertexArray*,unsigned int,unsigned int,bool,bool,unsigned int)
    public byte Startup(uint a2, uint a3, byte a4, byte a5, uint a6) => ((delegate* unmanaged[Thiscall]<ref ACBindings.VertexArray, uint, uint, byte, byte, uint, byte>)0x005D83C0)(ref this, a2, a3, a4, a5, a6);
    // int __thiscall VertexArray::Lock(VertexArray*,unsigned int,unsigned int)
    public int Lock(uint a2, uint a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.VertexArray, uint, uint, int>)0x005D8420)(ref this, a2, a3);
    // unsigned int __thiscall VertexArray::GenerateBoundingBox(VertexArray*)
    public uint GenerateBoundingBox() => ((delegate* unmanaged[Thiscall]<ref ACBindings.VertexArray, uint>)0x005D85E0)(ref this);
    // void __thiscall VertexArray::Begin(VertexArray*)
    public void Begin() => ((delegate* unmanaged[Thiscall]<ref ACBindings.VertexArray, void>)0x005D8650)(ref this);
    // void __thiscall VertexArray::End(void**)
    public void End() => ((delegate* unmanaged[Thiscall]<ref ACBindings.VertexArray, void>)0x005D86A0)(ref this);
    // void __thiscall VertexArray::Shutdown(void**)
    public void Shutdown() => ((delegate* unmanaged[Thiscall]<ref ACBindings.VertexArray, void>)0x005D86D0)(ref this);
    // void __thiscall VertexArray::Serialize(VertexArray*,Archive*)
    public void Serialize(ACBindings.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.VertexArray, ACBindings.Archive*, void>)0x005D88B0)(ref this, io_archive);
    // void __thiscall VertexArray::ComputeInfluencedBoneIndices(VertexArray*)
    public void ComputeInfluencedBoneIndices() => ((delegate* unmanaged[Thiscall]<ref ACBindings.VertexArray, void>)0x005D9630)(ref this);
    // void __thiscall VertexArray::Unlock(VertexArray*,bool,bool)
    public void Unlock(byte a2, byte a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.VertexArray, byte, byte, void>)0x005D97C0)(ref this, a2, a3);
}

