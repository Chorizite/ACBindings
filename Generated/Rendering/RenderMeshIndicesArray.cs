namespace ACBindings;

// RenderMeshIndicesArray
public unsafe struct RenderMeshIndicesArray : System.IDisposable
{
    // Base Classes
    public ACBindings.ReferenceCountTemplate BaseClass_ReferenceCountTemplate; // ACBindings.ReferenceCountTemplate

    // Child Types
    // RenderMeshIndicesArray_vtbl
    public unsafe struct RenderMeshIndicesArray_vtbl
    {
        // Members
        public System.IntPtr RenderMeshIndicesArray_dtor_0; // function pointer

        // Methods
    }

    // Members
    public ACBindings.SmartArray__RenderIndexBuffer_ptr m_IndexArrays;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall RenderMeshIndicesArray::~RenderMeshIndicesArray(RenderMeshIndicesArray*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderMeshIndicesArray, void>)0x00445100)(ref this);
}

