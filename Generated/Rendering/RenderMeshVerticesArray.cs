namespace ACBindings.Internal;

public unsafe struct RenderMeshVerticesArray : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.ReferenceCountTemplate BaseClass_ReferenceCountTemplate; // ACBindings.Internal.ReferenceCountTemplate

    // Child Types
    public unsafe struct RenderMeshVerticesArray_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderMeshVerticesArray*, void> RenderMeshVerticesArray_dtor_0; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.SmartArray___RenderVertexBuffer_ptr m_VertexArrays;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x00445040
    /// void __thiscall RenderMeshVerticesArray::~RenderMeshVerticesArray(RenderMeshVerticesArray*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderMeshVerticesArray, void>)0x00445040)(ref this);
}

