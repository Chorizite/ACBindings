namespace ACBindings.Internal;

public unsafe struct RenderMeshMaterialArray : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.ReferenceCountTemplate BaseClass_ReferenceCountTemplate; // ACBindings.Internal.ReferenceCountTemplate

    // Child Types
    public unsafe struct RenderMeshMaterialArray_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderMeshMaterialArray*, void> RenderMeshMaterialArray_dtor_0; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.SmartArray____STL_pair___IDClass____tagDataID___MaterialInstance_ptr m_Materials;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x00444FD0
    /// void __thiscall RenderMeshMaterialArray::~RenderMeshMaterialArray(RenderMeshMaterialArray*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderMeshMaterialArray, void>)0x00444FD0)(ref this);
}

