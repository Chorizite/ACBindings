namespace ACBindings;

// RenderMeshFragmentTopology
public unsafe struct RenderMeshFragmentTopology : System.IDisposable
{
    // Base Classes
    public ACBindings.ReferenceCountTemplate BaseClass_ReferenceCountTemplate; // ACBindings.ReferenceCountTemplate

    // Child Types
    // RenderMeshFragmentTopology_vtbl
    public unsafe struct RenderMeshFragmentTopology_vtbl
    {
        // Members
        public System.IntPtr RenderMeshFragmentTopology_dtor_0; // function pointer

        // Methods
    }
    // RenderMeshFragmentTopology::TopBatchType
    public unsafe struct TopBatchType
    {
        // Members
        public ACBindings.RenderMeshBatch* m_pBatch;
        public ACBindings.SmartArray__ushort m_BatchVertexToTopVertexIndices;

        // Generated Constructor
        public TopBatchType() {
            _ConstructorInternal();
        }

        // Methods
        // void __thiscall RenderMeshFragmentTopology::TopBatchType::TopBatchType(RenderMeshFragmentTopology::TopBatchType*)
        public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderMeshFragmentTopology.TopBatchType, void>)0x0044DEE0)(ref this);
    }
    // RenderMeshFragmentTopology::TopEdgeType
    public unsafe struct TopEdgeType
    {
        // Members
        public fixed ushort m_TopVertexIndices[2];
        public fixed ushort m_NeighbourTopTriangleIndices[2];

        // Methods
        // void __thiscall RenderMeshFragmentTopology::TopEdgeType::Serialize(RenderMeshFragmentTopology::TopEdgeType*,Archive*)
        public void Serialize(ACBindings.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderMeshFragmentTopology.TopEdgeType, ACBindings.Archive*, void>)0x0044DBD0)(ref this, io_archive);
    }
    // RenderMeshFragmentTopology::TopTriangleType
    public unsafe struct TopTriangleType
    {
        // Members
        public fixed ushort m_TopVertexIndices[3];
        public fixed ushort m_TopEdgeIndices[3];

        // Methods
        // void __thiscall RenderMeshFragmentTopology::TopTriangleType::Serialize(RenderMeshFragmentTopology::TopTriangleType*,Archive*)
        public void Serialize(ACBindings.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderMeshFragmentTopology.TopTriangleType, ACBindings.Archive*, void>)0x0044DB50)(ref this, io_archive);
    }
    // RenderMeshFragmentTopology::TopVertexType
    public unsafe struct TopVertexType
    {
        // Members
        public byte m_BatchIndex;
        public ushort m_VertexIndex;

        // Methods
    }

    // Members
    public ACBindings.SmartArray__RenderMeshFragmentTopology_TopVertexType m_TopVertices;
    public ACBindings.SmartArray__RenderMeshFragmentTopology_TopTriangleType m_TopTriangles;
    public ACBindings.SmartArray__RenderMeshFragmentTopology_TopEdgeType m_TopEdges;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall RenderMeshFragmentTopology::~RenderMeshFragmentTopology(RenderMeshFragmentTopology*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderMeshFragmentTopology, void>)0x0044E050)(ref this);
}

