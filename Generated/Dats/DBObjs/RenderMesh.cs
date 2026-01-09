namespace ACBindings;

// RenderMesh
public unsafe struct RenderMesh : System.IDisposable
{
    // Base Classes
    public ACBindings.DBObj BaseClass_DBObj; // ACBindings.DBObj

    // Child Types
    // RenderMesh_vtbl
    public unsafe struct RenderMesh_vtbl
    {
        // Members
        public System.IntPtr IUnknown_QueryInterface; // function pointer
        public System.IntPtr IUnknown_AddRef; // function pointer
        public System.IntPtr IUnknown_Release; // function pointer
        public System.IntPtr QueryInterface; // function pointer
        public System.IntPtr AddRef; // function pointer
        public System.IntPtr Release; // function pointer
        public System.IntPtr DBObj_dtor_18; // function pointer
        public System.IntPtr Serialize; // function pointer
        public System.IntPtr GetSubDataIDs; // function pointer
        public System.IntPtr InitLoad; // function pointer
        public System.IntPtr GetSubObjects; // function pointer
        public System.IntPtr ReleaseSubObjects; // function pointer
        public System.IntPtr NotifyFidelityLevel; // function pointer
        public System.IntPtr Refresh;
        public System.IntPtr CopyInto; // function pointer
        public System.IntPtr Destroy; // function pointer
        public System.IntPtr FillDataGraph; // function pointer
        public System.IntPtr SetDID;
        public System.IntPtr GetDBOType; // function pointer
        public System.IntPtr Allocate; // function pointer
        public System.IntPtr SaveToDisk;
        public System.IntPtr ReloadFromDisk; // function pointer
        public System.IntPtr FromFileNode;

        // Methods
    }

    // Members
    public uint m_InstanceFlags;
    public uint m_MeshAppearanceType;
    public ACBindings.RenderMeshMaterialArray* m_pMaterialArray;
    public ACBindings.RenderMeshVerticesArray* m_pVerticesArray;
    public ACBindings.RenderMeshIndicesArray* m_pIndicesArray;
    public ACBindings.SmartArray__RenderMeshFragment_ptr m_Fragments;
    public ACBindings.SmartArray__uint m_RenderLODFragmentIndices;
    public ACBindings.SmartArray__uint m_OccluderFragmentIndices;
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
    public ACBindings.BBox m_CachedRenderBoundingBox;
    public ACBindings.BBox m_CachedSkinnedBoundingBox;
    public byte m_IsSkinnedBoundingBoxValid;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // char __thiscall RenderMesh::GetMaterialsFromDatabase(RenderMesh*)
    public sbyte GetMaterialsFromDatabase() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderMesh, sbyte>)0x00444A30)(ref this);
    // char __thiscall RenderMesh::ReleaseSubObjects(RenderMesh*)
    public sbyte ReleaseSubObjects() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderMesh, sbyte>)0x00444AC0)(ref this);
    // unsigned int __thiscall RenderMesh::CacheHasSkeletalData(RenderMesh*)
    public uint CacheHasSkeletalData() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderMesh, uint>)0x00444B00)(ref this);
    // unsigned int __thiscall RenderMesh::CacheRenderBoundingBox(RenderMesh*)
    public uint CacheRenderBoundingBox() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderMesh, uint>)0x00444B80)(ref this);
    // char __thiscall RenderMesh::DrawSubset(RenderMesh*,unsigned int)
    public sbyte DrawSubset(uint a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderMesh, uint, sbyte>)0x00444BF0)(ref this, a2);
    // unsigned int __thiscall RenderMesh::GenerateTopologyForFragments(RenderMesh*)
    public uint GenerateTopologyForFragments() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderMesh, uint>)0x00444D50)(ref this);
    // unsigned int __thiscall RenderMesh::OrganizeFragmentBatches(RenderMesh*)
    public uint OrganizeFragmentBatches() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderMesh, uint>)0x00444D90)(ref this);
    // int __thiscall RenderMesh::GetDBOType(RenderMesh*)
    public int GetDBOType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderMesh, int>)0x004452C0)(ref this);
    // void __thiscall RenderMesh::ReleaseFragments(RenderMesh*)
    public void ReleaseFragments() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderMesh, void>)0x004452D0)(ref this);
    // void __thiscall RenderMesh::Destroy(RenderMesh*)
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderMesh, void>)0x004453F0)(ref this);
    // int __thiscall RenderMesh::GetSubDataIDs(RenderMesh*,QualifiedDataIDArray*)
    public int GetSubDataIDs(ACBindings.QualifiedDataIDArray* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderMesh, ACBindings.QualifiedDataIDArray*, int>)0x004454B0)(ref this, a2);
    // void __thiscall RenderMesh::~RenderMesh(RenderMesh*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderMesh, void>)0x004455A0)(ref this);
    // unsigned int __thiscall RenderMesh::AddVertexArray(RenderMesh*,RenderVertexBuffer*)
    public uint AddVertexArray(ACBindings.RenderVertexBuffer* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderMesh, ACBindings.RenderVertexBuffer*, uint>)0x004456C0)(ref this, a2);
    // unsigned int __thiscall RenderMesh::AddIndexArray(RenderMesh*,RenderIndexBuffer*)
    public uint AddIndexArray(ACBindings.RenderIndexBuffer* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderMesh, ACBindings.RenderIndexBuffer*, uint>)0x00445740)(ref this, a2);
    // void** __thiscall RenderMesh::Serialize(DBObj*,Archive*)
    public void** Serialize(ACBindings.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderMesh, ACBindings.Archive*, void**>)0x004457C0)(ref this, io_archive);
    // char __thiscall RenderMesh::ParseFromFileNode(RenderMesh*,const PFileNode*)
    public sbyte ParseFromFileNode(ACBindings.PFileNode* file_node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderMesh, ACBindings.PFileNode*, sbyte>)0x00445EA0)(ref this, file_node);
    // unsigned int __thiscall RenderMesh::GenerateFragmentIndexLists(RenderMesh*)
    public uint GenerateFragmentIndexLists() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderMesh, uint>)0x004460C0)(ref this);
    // char __thiscall RenderMesh::AddBatchToRenderLOD(RenderMesh*,void***,RenderMeshBatch*)
    public sbyte AddBatchToRenderLOD(void*** a2, ACBindings.RenderMeshBatch* pBatch) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderMesh, void***, ACBindings.RenderMeshBatch*, sbyte>)0x00446180)(ref this, a2, pBatch);
    // unsigned int __thiscall RenderMesh::CacheMaterialAttributes(RenderMesh*)
    public uint CacheMaterialAttributes() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderMesh, uint>)0x00446200)(ref this);
    // unsigned int __thiscall RenderMesh::UpdateCachedData(RenderMesh*)
    public uint UpdateCachedData() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderMesh, uint>)0x00446590)(ref this);
    // char __thiscall RenderMesh::GetSubObjects(RenderMesh*)
    public sbyte GetSubObjects() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderMesh, sbyte>)0x004465B0)(ref this);
    // char __thiscall RenderMesh::Refresh(RenderMesh*,int)
    public sbyte Refresh(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderMesh, int, sbyte>)0x004465E0)(ref this, a2);
    // char __thiscall RenderMesh::CreateLODBatch(RenderMesh*,void***,MaterialInstance*,enum PrimType,unsigned int,unsigned int,unsigned int,int,int,RenderVertexBuffer**)
    public sbyte CreateLODBatch(void*** a2, ACBindings.MaterialInstance* a3, ACBindings.PrimType a4, uint a5, uint a6, uint a7, int a8, int a9, ACBindings.RenderVertexBuffer** a10) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderMesh, void***, ACBindings.MaterialInstance*, ACBindings.PrimType, uint, uint, uint, int, int, ACBindings.RenderVertexBuffer**, sbyte>)0x00446600)(ref this, a2, a3, a4, a5, a6, a7, a8, a9, a10);
    // char __thiscall RenderMesh::InitLoad(RenderMesh*)
    public sbyte InitLoad() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderMesh, sbyte>)0x00446890)(ref this);
    // bool __thiscall RenderMesh::ParseFromVersionedFileNode(RenderMesh*,PFileNode*)
    public byte ParseFromVersionedFileNode(ACBindings.PFileNode* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderMesh, ACBindings.PFileNode*, byte>)0x00446950)(ref this, a2);
    // char __thiscall RenderMesh::FromFileNode(RenderMesh*,const PFileNode*)
    public sbyte FromFileNode(ACBindings.PFileNode* file_node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderMesh, ACBindings.PFileNode*, sbyte>)0x00446A60)(ref this, file_node);
}

