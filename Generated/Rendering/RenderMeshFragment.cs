namespace ACBindings.Internal;

public unsafe struct RenderMeshFragment : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.ReferenceCountTemplate BaseClass_ReferenceCountTemplate; // ACBindings.Internal.ReferenceCountTemplate

    // Child Types
    public unsafe struct RenderMeshFragment_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderMeshFragment*, void> RenderMeshFragment_dtor_0; // function pointer

        // Methods
    }

    // Members
    public uint m_Type;
    public ACBindings.Internal.SmartArray___RenderMeshBatch_ptr m_MaterialBatches;
    public ACBindings.Internal.RenderMeshFragmentTopology* m_pTopology;
    public uint m_AttribID;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x0044DF80
    /// void __thiscall RenderMeshFragment::~RenderMeshFragment(RenderMeshFragment*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderMeshFragment, void>)0x0044DF80)(ref this);

    /// <summary>
    /// <code>Offset: 0x0044E5D0
    /// void __thiscall RenderMeshFragment::AddMaterialBatch(RenderMeshFragment*,RenderMeshBatch*)</code>
    /// </summary>
    public void AddMaterialBatch(ACBindings.Internal.RenderMeshBatch* pBatch) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderMeshFragment, ACBindings.Internal.RenderMeshBatch*, void>)0x0044E5D0)(ref this, pBatch);

    /// <summary>
    /// <code>Offset: 0x0044E7E0
    /// void __thiscall RenderMeshFragment::OrganizeMaterialBatches(RenderMeshFragment*)</code>
    /// </summary>
    public void OrganizeMaterialBatches() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderMeshFragment, void>)0x0044E7E0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0044E970
    /// char __thiscall RenderMeshFragment::GenerateAdjacencyGraph(_DWORD*,_DWORD*)</code>
    /// </summary>
    public sbyte GenerateAdjacencyGraph(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderMeshFragment, int*, sbyte>)0x0044E970)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x0044ED90
    /// void __thiscall RenderMeshFragment::Serialize(RenderMeshFragment*,Archive*,RenderMesh*)</code>
    /// </summary>
    public void Serialize(ACBindings.Internal.Archive* a2, ACBindings.Internal.RenderMesh* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderMeshFragment, ACBindings.Internal.Archive*, ACBindings.Internal.RenderMesh*, void>)0x0044ED90)(ref this, a2, a3);

    /// <summary>
    /// <code>Offset: 0x0044EF30
    /// int __thiscall RenderMeshFragment::GenerateTopologyVertices(_DWORD*,_DWORD*,_DWORD*)</code>
    /// </summary>
    public int GenerateTopologyVertices(int* a2, int* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderMeshFragment, int*, int*, int>)0x0044EF30)(ref this, a2, a3);

    /// <summary>
    /// <code>Offset: 0x0044F1E0
    /// void __thiscall RenderMeshFragment::GenerateTopology(RenderMeshFragment*)</code>
    /// </summary>
    public void GenerateTopology() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderMeshFragment, void>)0x0044F1E0)(ref this);
}

