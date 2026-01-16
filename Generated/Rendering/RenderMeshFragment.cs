namespace ACBindings.Internal;


/// <summary>Represents a fragment of a renderable mesh, storing the material batches that make up the geometry and an optional topology structure used for efficient rendering. Manages reference counting, batch organization, and serialization of its constituent data.</summary>
public unsafe struct RenderMeshFragment : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.ReferenceCountTemplate BaseClass_ReferenceCountTemplate; // ACBindings.Internal.ReferenceCountTemplate

    // Child Types
    public unsafe struct RenderMeshFragment_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderMeshFragment*, void> RenderMeshFragment_dtor_0; // function pointer

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

    /// <summary>Destroys a RenderMeshFragment instance, releasing its topology and material batch references, clearing stored data, and freeing allocated memory when appropriate.
    /// <code>Offset: 0x0044DF80
    /// void __thiscall RenderMeshFragment::~RenderMeshFragment(RenderMeshFragment*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderMeshFragment, void>)0x0044DF80)(ref this);

    /// <summary>Increments the reference count of a material batch and appends it to the fragment's batch array, resizing the array as necessary.
    /// <code>Offset: 0x0044E5D0
    /// void __thiscall RenderMeshFragment::AddMaterialBatch(RenderMeshFragment*,RenderMeshBatch*)</code>
    /// </summary>
    /// <param name="pBatch">The material batch to add.</param>
    public void AddMaterialBatch(ACBindings.Internal.RenderMeshBatch* pBatch) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderMeshFragment, ACBindings.Internal.RenderMeshBatch*, void>)0x0044E5D0)(ref this, pBatch);

    /// <summary>Reorganizes the fragment’s material batch list by separating batches that reference materials with specific properties from those that do not, and appending the former to the end of the array for optimized rendering.
    /// <code>Offset: 0x0044E7E0
    /// void __thiscall RenderMeshFragment::OrganizeMaterialBatches(RenderMeshFragment*)</code>
    /// </summary>
    public void OrganizeMaterialBatches() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderMeshFragment, void>)0x0044E7E0)(ref this);

    /// <summary>Builds an adjacency graph from mesh fragment material batches by allocating and populating vertex and edge lists, then iterates through each batch to establish connectivity.
    /// <code>Offset: 0x0044E970
    /// char __thiscall RenderMeshFragment::GenerateAdjacencyGraph(_DWORD*,_DWORD*)</code>
    /// </summary>
    /// <param name="this">RenderMeshFragment instance whose topology is being updated.</param>
    /// <param name="a2">Array of batch descriptors; a2[0] points to the first descriptor and a2[2] holds the count of batches.</param>
    /// <returns>Character value whose low byte represents the number of processed batches (non‑zero on success).</returns>
    public sbyte GenerateAdjacencyGraph(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderMeshFragment, int*, sbyte>)0x0044E970)(ref this, a2);

    /// <summary>Serializes or deserializes a RenderMeshFragment into an Archive, handling its type, material batch collection and optional topology data.
    /// <code>Offset: 0x0044ED90
    /// void __thiscall RenderMeshFragment::Serialize(RenderMeshFragment*,Archive*,RenderMesh*)</code>
    /// </summary>
    /// <param name="this">The RenderMeshFragment instance to serialize.</param>
    /// <param name="a2">Archive used for the serialization process.</param>
    /// <param name="a3">Associated RenderMesh context passed to child batch serializations.</param>
    public void Serialize(ACBindings.Internal.Archive* a2, ACBindings.Internal.RenderMesh* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderMeshFragment, ACBindings.Internal.Archive*, ACBindings.Internal.RenderMesh*, void>)0x0044ED90)(ref this, a2, a3);

    /// <summary>Generates and populates topology vertex data for a mesh fragment by iterating over its material batches.
    /// <code>Offset: 0x0044EF30
    /// int __thiscall RenderMeshFragment::GenerateTopologyVertices(_DWORD*,_DWORD*,_DWORD*)</code>
    /// </summary>
    /// <param name="vertices">Array of Vector3 vertices; expanded to include any new positions required by the fragment’s batches.</param>
    /// <param name="topology">Topology buffer that stores batch references and vertex indices; grown if necessary.</param>
    /// <returns>The number of material batches processed (typically the fragment’s batch count).</returns>
    public int GenerateTopologyVertices(int* a2, int* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderMeshFragment, int*, int*, int>)0x0044EF30)(ref this, a2, a3);

    /// <summary>Creates and initializes the topology for a mesh fragment, replacing any existing topology reference, allocating new storage, generating vertices and adjacency information, and releasing temporary resources.
    /// <code>Offset: 0x0044F1E0
    /// void __thiscall RenderMeshFragment::GenerateTopology(RenderMeshFragment*)</code>
    /// </summary>
    public void GenerateTopology() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderMeshFragment, void>)0x0044F1E0)(ref this);
}

