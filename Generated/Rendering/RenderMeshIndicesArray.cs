namespace ACBindings.Internal;

public unsafe struct RenderMeshIndicesArray : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.ReferenceCountTemplate BaseClass_ReferenceCountTemplate; // ACBindings.Internal.ReferenceCountTemplate

    // Child Types
    public unsafe struct RenderMeshIndicesArray_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderMeshIndicesArray*, void> RenderMeshIndicesArray_dtor_0; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.SmartArray___RenderIndexBuffer_ptr m_IndexArrays;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x00445100
    /// void __thiscall RenderMeshIndicesArray::~RenderMeshIndicesArray(RenderMeshIndicesArray*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderMeshIndicesArray, void>)0x00445100)(ref this);
}

