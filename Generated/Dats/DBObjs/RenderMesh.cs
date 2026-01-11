namespace ACBindings.Internal;

public unsafe struct RenderMesh : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.DBObj BaseClass_DBObj; // ACBindings.Internal.DBObj

    // Child Types
    public unsafe struct RenderMesh_vtbl
    {
        // Members
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, ACBindings.Internal._GUID*, void**, int> IUnknown_QueryInterface; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_AddRef; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_Release; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, ACBindings.Internal.TResult*, ACBindings.Internal.Turbine_GUID*, void**, ACBindings.Internal.TResult*> QueryInterface; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> AddRef; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> Release; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, void> DBObj_dtor_18; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.Archive*, void> Serialize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.QualifiedDataIDArray*, void> GetSubDataIDs; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> InitLoad; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> GetSubObjects; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> ReleaseSubObjects; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> NotifyFidelityLevel; // function pointer
        public System.IntPtr Refresh;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.DBObj*, byte> CopyInto; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, void> Destroy; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.IDataGraph*, void> FillDataGraph; // function pointer
        public System.IntPtr SetDID;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, uint> GetDBOType; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.DBObj*> Allocate; // function pointer
        public System.IntPtr SaveToDisk;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> ReloadFromDisk; // function pointer
        public System.IntPtr FromFileNode;

        // Methods
    }

    // Members
    public uint m_InstanceFlags;
    public uint m_MeshAppearanceType;
    public ACBindings.Internal.RenderMeshMaterialArray* m_pMaterialArray;
    public ACBindings.Internal.RenderMeshVerticesArray* m_pVerticesArray;
    public ACBindings.Internal.RenderMeshIndicesArray* m_pIndicesArray;
    public ACBindings.Internal.SmartArray___RenderMeshFragment_ptr m_Fragments;
    public ACBindings.Internal.SmartArray__uint m_RenderLODFragmentIndices;
    public ACBindings.Internal.SmartArray__uint m_OccluderFragmentIndices;
    public uint m_ShadowLODFragmentIndex;
    public byte m_CachedSupportsLighting;
    public byte m_CachedSupportsMultiPassLighting;
    public byte m_CachedSupportsCombinedAmbientPass;
    public byte m_CachedIsGlowing;
    public byte m_CachedNeedAlphaBlendPass;
    public byte m_CachedHasSkeletalData;
    public byte m_CachedAllSkeletalLODsWereBlended;
    public uint m_CachedSkeletalRenderLODIndex;
    public uint m_CachedSkeletalShadowVolumeLODIndex;
    public ACBindings.Internal.BBox m_CachedRenderBoundingBox;
    public ACBindings.Internal.BBox m_CachedSkinnedBoundingBox;
    public byte m_IsSkinnedBoundingBoxValid;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x00444A30
    /// char __thiscall RenderMesh::GetMaterialsFromDatabase(RenderMesh*)</code>
    /// </summary>
    public sbyte GetMaterialsFromDatabase() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderMesh, sbyte>)0x00444A30)(ref this);

    /// <summary>
    /// <code>Offset: 0x00444AC0
    /// char __thiscall RenderMesh::ReleaseSubObjects(RenderMesh*)</code>
    /// </summary>
    public sbyte ReleaseSubObjects() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderMesh, sbyte>)0x00444AC0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00444B00
    /// unsigned int __thiscall RenderMesh::CacheHasSkeletalData(RenderMesh*)</code>
    /// </summary>
    public uint CacheHasSkeletalData() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderMesh, uint>)0x00444B00)(ref this);

    /// <summary>
    /// <code>Offset: 0x00444B80
    /// unsigned int __thiscall RenderMesh::CacheRenderBoundingBox(RenderMesh*)</code>
    /// </summary>
    public uint CacheRenderBoundingBox() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderMesh, uint>)0x00444B80)(ref this);

    /// <summary>
    /// <code>Offset: 0x00444BF0
    /// char __thiscall RenderMesh::DrawSubset(RenderMesh*,unsigned int)</code>
    /// </summary>
    public sbyte DrawSubset(uint a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderMesh, uint, sbyte>)0x00444BF0)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x00444D50
    /// unsigned int __thiscall RenderMesh::GenerateTopologyForFragments(RenderMesh*)</code>
    /// </summary>
    public uint GenerateTopologyForFragments() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderMesh, uint>)0x00444D50)(ref this);

    /// <summary>
    /// <code>Offset: 0x00444D90
    /// unsigned int __thiscall RenderMesh::OrganizeFragmentBatches(RenderMesh*)</code>
    /// </summary>
    public uint OrganizeFragmentBatches() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderMesh, uint>)0x00444D90)(ref this);

    /// <summary>
    /// <code>Offset: 0x004452C0
    /// int __thiscall RenderMesh::GetDBOType(RenderMesh*)</code>
    /// </summary>
    public int GetDBOType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderMesh, int>)0x004452C0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004452D0
    /// void __thiscall RenderMesh::ReleaseFragments(RenderMesh*)</code>
    /// </summary>
    public void ReleaseFragments() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderMesh, void>)0x004452D0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004453F0
    /// void __thiscall RenderMesh::Destroy(RenderMesh*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderMesh, void>)0x004453F0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004454B0
    /// int __thiscall RenderMesh::GetSubDataIDs(RenderMesh*,QualifiedDataIDArray*)</code>
    /// </summary>
    public int GetSubDataIDs(ACBindings.Internal.QualifiedDataIDArray* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderMesh, ACBindings.Internal.QualifiedDataIDArray*, int>)0x004454B0)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x004455A0
    /// void __thiscall RenderMesh::~RenderMesh(RenderMesh*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderMesh, void>)0x004455A0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004456C0
    /// unsigned int __thiscall RenderMesh::AddVertexArray(RenderMesh*,RenderVertexBuffer*)</code>
    /// </summary>
    public uint AddVertexArray(ACBindings.Internal.RenderVertexBuffer* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderMesh, ACBindings.Internal.RenderVertexBuffer*, uint>)0x004456C0)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x00445740
    /// unsigned int __thiscall RenderMesh::AddIndexArray(RenderMesh*,RenderIndexBuffer*)</code>
    /// </summary>
    public uint AddIndexArray(ACBindings.Internal.RenderIndexBuffer* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderMesh, ACBindings.Internal.RenderIndexBuffer*, uint>)0x00445740)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x004457C0
    /// void** __thiscall RenderMesh::Serialize(DBObj*,Archive*)</code>
    /// </summary>
    public void** Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderMesh, ACBindings.Internal.Archive*, void**>)0x004457C0)(ref this, io_archive);

    /// <summary>
    /// <code>Offset: 0x00445EA0
    /// char __thiscall RenderMesh::ParseFromFileNode(RenderMesh*,const PFileNode*)</code>
    /// </summary>
    public sbyte ParseFromFileNode(ACBindings.Internal.PFileNode* file_node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderMesh, ACBindings.Internal.PFileNode*, sbyte>)0x00445EA0)(ref this, file_node);

    /// <summary>
    /// <code>Offset: 0x004460C0
    /// unsigned int __thiscall RenderMesh::GenerateFragmentIndexLists(RenderMesh*)</code>
    /// </summary>
    public uint GenerateFragmentIndexLists() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderMesh, uint>)0x004460C0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00446180
    /// char __thiscall RenderMesh::AddBatchToRenderLOD(RenderMesh*,void***,RenderMeshBatch*)</code>
    /// </summary>
    public sbyte AddBatchToRenderLOD(void*** a2, ACBindings.Internal.RenderMeshBatch* pBatch) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderMesh, void***, ACBindings.Internal.RenderMeshBatch*, sbyte>)0x00446180)(ref this, a2, pBatch);

    /// <summary>
    /// <code>Offset: 0x00446200
    /// unsigned int __thiscall RenderMesh::CacheMaterialAttributes(RenderMesh*)</code>
    /// </summary>
    public uint CacheMaterialAttributes() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderMesh, uint>)0x00446200)(ref this);

    /// <summary>
    /// <code>Offset: 0x00446590
    /// unsigned int __thiscall RenderMesh::UpdateCachedData(RenderMesh*)</code>
    /// </summary>
    public uint UpdateCachedData() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderMesh, uint>)0x00446590)(ref this);

    /// <summary>
    /// <code>Offset: 0x004465B0
    /// char __thiscall RenderMesh::GetSubObjects(RenderMesh*)</code>
    /// </summary>
    public sbyte GetSubObjects() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderMesh, sbyte>)0x004465B0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004465E0
    /// char __thiscall RenderMesh::Refresh(RenderMesh*,int)</code>
    /// </summary>
    public sbyte Refresh(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderMesh, int, sbyte>)0x004465E0)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x00446600
    /// char __thiscall RenderMesh::CreateLODBatch(RenderMesh*,void***,MaterialInstance*,enum PrimType,unsigned int,unsigned int,unsigned int,int,int,RenderVertexBuffer**)</code>
    /// </summary>
    public sbyte CreateLODBatch(void*** a2, ACBindings.Internal.MaterialInstance* a3, ACBindings.Internal.PrimType a4, uint a5, uint a6, uint a7, int a8, int a9, ACBindings.Internal.RenderVertexBuffer** a10) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderMesh, void***, ACBindings.Internal.MaterialInstance*, ACBindings.Internal.PrimType, uint, uint, uint, int, int, ACBindings.Internal.RenderVertexBuffer**, sbyte>)0x00446600)(ref this, a2, a3, a4, a5, a6, a7, a8, a9, a10);

    /// <summary>
    /// <code>Offset: 0x00446890
    /// char __thiscall RenderMesh::InitLoad(RenderMesh*)</code>
    /// </summary>
    public sbyte InitLoad() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderMesh, sbyte>)0x00446890)(ref this);

    /// <summary>
    /// <code>Offset: 0x00446950
    /// bool __thiscall RenderMesh::ParseFromVersionedFileNode(RenderMesh*,PFileNode*)</code>
    /// </summary>
    public byte ParseFromVersionedFileNode(ACBindings.Internal.PFileNode* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderMesh, ACBindings.Internal.PFileNode*, byte>)0x00446950)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x00446A60
    /// char __thiscall RenderMesh::FromFileNode(RenderMesh*,const PFileNode*)</code>
    /// </summary>
    public sbyte FromFileNode(ACBindings.Internal.PFileNode* file_node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderMesh, ACBindings.Internal.PFileNode*, sbyte>)0x00446A60)(ref this, file_node);
}

