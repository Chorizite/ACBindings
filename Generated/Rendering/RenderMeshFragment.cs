namespace ACBindings;

// RenderMeshFragment
public unsafe struct RenderMeshFragment : System.IDisposable
{
    // Base Classes
    public ACBindings.ReferenceCountTemplate BaseClass_ReferenceCountTemplate; // ACBindings.ReferenceCountTemplate

    // Child Types
    // RenderMeshFragment_vtbl
    public unsafe struct RenderMeshFragment_vtbl
    {
        // Members
        public System.IntPtr RenderMeshFragment_dtor_0; // function pointer

        // Methods
    }

    // Members
    public uint m_Type;
    public ACBindings.SmartArray__RenderMeshBatch_ptr m_MaterialBatches;
    public ACBindings.RenderMeshFragmentTopology* m_pTopology;
    public uint m_AttribID;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall RenderMeshFragment::~RenderMeshFragment(RenderMeshFragment*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderMeshFragment, void>)0x0044DF80)(ref this);
    // void __thiscall RenderMeshFragment::AddMaterialBatch(RenderMeshFragment*,RenderMeshBatch*)
    public void AddMaterialBatch(ACBindings.RenderMeshBatch* pBatch) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderMeshFragment, ACBindings.RenderMeshBatch*, void>)0x0044E5D0)(ref this, pBatch);
    // void __thiscall RenderMeshFragment::OrganizeMaterialBatches(RenderMeshFragment*)
    public void OrganizeMaterialBatches() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderMeshFragment, void>)0x0044E7E0)(ref this);
    // char __thiscall RenderMeshFragment::GenerateAdjacencyGraph(_DWORD*,_DWORD*)
    public sbyte GenerateAdjacencyGraph(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderMeshFragment, int*, sbyte>)0x0044E970)(ref this, a2);
    // void __thiscall RenderMeshFragment::Serialize(RenderMeshFragment*,Archive*,RenderMesh*)
    public void Serialize(ACBindings.Archive* a2, ACBindings.RenderMesh* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderMeshFragment, ACBindings.Archive*, ACBindings.RenderMesh*, void>)0x0044ED90)(ref this, a2, a3);
    // int __thiscall RenderMeshFragment::GenerateTopologyVertices(_DWORD*,_DWORD*,_DWORD*)
    public int GenerateTopologyVertices(int* a2, int* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderMeshFragment, int*, int*, int>)0x0044EF30)(ref this, a2, a3);
    // void __thiscall RenderMeshFragment::GenerateTopology(RenderMeshFragment*)
    public void GenerateTopology() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderMeshFragment, void>)0x0044F1E0)(ref this);
}

