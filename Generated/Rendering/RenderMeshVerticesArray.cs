namespace ACBindings;

// RenderMeshVerticesArray
public unsafe struct RenderMeshVerticesArray : System.IDisposable
{
    // Base Classes
    public ACBindings.ReferenceCountTemplate BaseClass_ReferenceCountTemplate; // ACBindings.ReferenceCountTemplate

    // Child Types
    // RenderMeshVerticesArray_vtbl
    public unsafe struct RenderMeshVerticesArray_vtbl
    {
        // Members
        public System.IntPtr RenderMeshVerticesArray_dtor_0; // function pointer

        // Methods
    }

    // Members
    public ACBindings.SmartArray__RenderVertexBuffer_ptr m_VertexArrays;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall RenderMeshVerticesArray::~RenderMeshVerticesArray(RenderMeshVerticesArray*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderMeshVerticesArray, void>)0x00445040)(ref this);
}

