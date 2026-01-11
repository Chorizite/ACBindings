namespace ACBindings.Internal;

public unsafe struct RenderMeshFragmentTopology : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.ReferenceCountTemplate BaseClass_ReferenceCountTemplate; // ACBindings.Internal.ReferenceCountTemplate

    // Child Types
    public unsafe struct RenderMeshFragmentTopology_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderMeshFragmentTopology*, void> RenderMeshFragmentTopology_dtor_0; // function pointer

        // Methods
    }
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

        /// <summary>
        /// <code>Offset: 0x0044DEE0
        /// void __thiscall RenderMeshFragmentTopology::TopBatchType::TopBatchType(RenderMeshFragmentTopology::TopBatchType*)</code>
        /// </summary>
        public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderMeshFragmentTopology.TopBatchType, void>)0x0044DEE0)(ref this);
    }
    public unsafe struct TopEdgeType
    {
        // Members
        public fixed ushort m_TopVertexIndices[2];
        public fixed ushort m_NeighbourTopTriangleIndices[2];

        // Methods

        /// <summary>
        /// <code>Offset: 0x0044DBD0
        /// void __thiscall RenderMeshFragmentTopology::TopEdgeType::Serialize(RenderMeshFragmentTopology::TopEdgeType*,Archive*)</code>
        /// </summary>
        public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderMeshFragmentTopology.TopEdgeType, ACBindings.Internal.Archive*, void>)0x0044DBD0)(ref this, io_archive);
    }
    public unsafe struct TopTriangleType
    {
        // Members
        public fixed ushort m_TopVertexIndices[3];
        public fixed ushort m_TopEdgeIndices[3];

        // Methods

        /// <summary>
        /// <code>Offset: 0x0044DB50
        /// void __thiscall RenderMeshFragmentTopology::TopTriangleType::Serialize(RenderMeshFragmentTopology::TopTriangleType*,Archive*)</code>
        /// </summary>
        public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderMeshFragmentTopology.TopTriangleType, ACBindings.Internal.Archive*, void>)0x0044DB50)(ref this, io_archive);
    }
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

    /// <summary>
    /// <code>Offset: 0x0044E050
    /// void __thiscall RenderMeshFragmentTopology::~RenderMeshFragmentTopology(RenderMeshFragmentTopology*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderMeshFragmentTopology, void>)0x0044E050)(ref this);
}

