namespace ACBindings.Internal;


/// <summary>
/// Captures the connectivity of a render mesh fragment by storing its vertices, triangles, and edges.
/// Reference‑counted for safe reuse across rendering operations.
/// </summary>
public unsafe struct RenderMeshFragmentTopology : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.ReferenceCountTemplate BaseClass_ReferenceCountTemplate; // ACBindings.Internal.ReferenceCountTemplate

    // Child Types
    public unsafe struct RenderMeshFragmentTopology_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderMeshFragmentTopology*, void> RenderMeshFragmentTopology_dtor_0; // function pointer

        // Methods
    }

    /// <summary>Holds a pointer to a mesh batch and an array mapping each vertex of that batch to the corresponding top‑level vertex index, enabling efficient rendering of mesh fragments.</summary>
    public unsafe struct TopBatchType
    {
        // Members
        public ACBindings.Internal.RenderMeshBatch* m_pBatch;
        public ACBindings.Internal.SmartArray__ushort m_BatchVertexToTopVertexIndices;

        // Generated Constructor
        public TopBatchType() {
            _ConstructorInternal();
        }

        // Methods

        /// <summary>Initializes a TopBatchType instance, clearing its vertex-to-top-vertex index array.
        /// <code>Offset: 0x0044DEE0
        /// void __thiscall RenderMeshFragmentTopology::TopBatchType::TopBatchType(RenderMeshFragmentTopology::TopBatchType*)</code>
        /// </summary>
        public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderMeshFragmentTopology.TopBatchType, void>)0x0044DEE0)(ref this);
    }

    /// <summary>
    /// Represents an edge of a mesh fragment topology, storing the indices of its two top vertices and references to adjacent triangles on the same side.
    /// </summary>
    public unsafe struct TopEdgeType
    {
        // Members
        public fixed ushort m_TopVertexIndices[2];
        public fixed ushort m_NeighbourTopTriangleIndices[2];

        // Methods

        /// <summary>Serializes the top vertex indices and neighbour triangle indices of a mesh fragment topology edge into an archive, reading or writing values depending on the archive's mode flag.
        /// <code>Offset: 0x0044DBD0
        /// void __thiscall RenderMeshFragmentTopology::TopEdgeType::Serialize(RenderMeshFragmentTopology::TopEdgeType*,Archive*)</code>
        /// </summary>
        /// <param name="io_archive">The archive used for serialization; its flags determine whether data is written to or read from the buffer.</param>
        public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderMeshFragmentTopology.TopEdgeType, ACBindings.Internal.Archive*, void>)0x0044DBD0)(ref this, io_archive);
    }

    /// <summary>Represents a single triangle within a mesh fragment topology, storing its three vertex and edge indices for efficient serialization and reconstruction of the mesh structure.</summary>
    public unsafe struct TopTriangleType
    {
        // Members
        public fixed ushort m_TopVertexIndices[3];
        public fixed ushort m_TopEdgeIndices[3];

        // Methods

        /// <summary>Serializes or deserializes the triangle’s vertex and edge indices to an Archive, handling alignment and read/write mode based on archive flags.
        /// <code>Offset: 0x0044DB50
        /// void __thiscall RenderMeshFragmentTopology::TopTriangleType::Serialize(RenderMeshFragmentTopology::TopTriangleType*,Archive*)</code>
        /// </summary>
        /// <param name="this">The TopTriangleType instance containing the indices to serialize.</param>
        /// <param name="io_archive">Archive used for reading or writing the index data.</param>
        public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderMeshFragmentTopology.TopTriangleType, ACBindings.Internal.Archive*, void>)0x0044DB50)(ref this, io_archive);
    }

    /// <summary>Describes a vertex within a render mesh fragment topology, storing its batch index and relative vertex index for efficient rendering.</summary>
    public unsafe struct TopVertexType
    {
        // Members
        public byte m_BatchIndex;
        public ushort m_VertexIndex;

        // Methods
    }

    // Members
    public ACBindings.Internal.SmartArray___RenderMeshFragmentTopology_TopVertexType m_TopVertices;
    public ACBindings.Internal.SmartArray___RenderMeshFragmentTopology_TopTriangleType m_TopTriangles;
    public ACBindings.Internal.SmartArray___RenderMeshFragmentTopology_TopEdgeType m_TopEdges;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Destroys a RenderMeshFragmentTopology instance by releasing its vertex, triangle, and edge arrays and resetting base class virtual table pointers.
    /// <code>Offset: 0x0044E050
    /// void __thiscall RenderMeshFragmentTopology::~RenderMeshFragmentTopology(RenderMeshFragmentTopology*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderMeshFragmentTopology, void>)0x0044E050)(ref this);
}

