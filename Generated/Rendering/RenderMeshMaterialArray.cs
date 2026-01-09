namespace ACBindings;

// RenderMeshMaterialArray
public unsafe struct RenderMeshMaterialArray : System.IDisposable
{
    // Base Classes
    public ACBindings.ReferenceCountTemplate BaseClass_ReferenceCountTemplate; // ACBindings.ReferenceCountTemplate

    // Child Types
    // RenderMeshMaterialArray_vtbl
    public unsafe struct RenderMeshMaterialArray_vtbl
    {
        // Members
        public System.IntPtr RenderMeshMaterialArray_dtor_0; // function pointer

        // Methods
    }

    // Members
    public ACBindings.SmartArray___STL_pair__IDClass___tagDataID__MaterialInstance_ptr m_Materials;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall RenderMeshMaterialArray::~RenderMeshMaterialArray(RenderMeshMaterialArray*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderMeshMaterialArray, void>)0x00444FD0)(ref this);
}

