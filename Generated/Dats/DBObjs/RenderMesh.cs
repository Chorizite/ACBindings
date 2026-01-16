namespace ACBindings.Internal;


/// <summary>
/// Represents a renderable 3D mesh, holding geometry data, material references, fragment collections, LOD indices, and precomputed bounding boxes for efficient rendering.
/// </summary>
public unsafe struct RenderMesh : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.DBObj BaseClass_DBObj; // ACBindings.Internal.DBObj

    // Child Types
    public unsafe struct RenderMesh_vtbl
    {
        // Members
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, ACBindings.Internal._GUID*, void**, int> IUnknown_QueryInterface; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_AddRef; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_Release; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, ACBindings.Internal.TResult*, ACBindings.Internal.Turbine_GUID*, void**, ACBindings.Internal.TResult*> QueryInterface; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> AddRef; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> Release; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, void> DBObj_dtor_18; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.Archive*, void> Serialize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.QualifiedDataIDArray*, void> GetSubDataIDs; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> InitLoad; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> GetSubObjects; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> ReleaseSubObjects; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> NotifyFidelityLevel; // function pointer
        public System.IntPtr Refresh;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.DBObj*, byte> CopyInto; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, void> Destroy; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.IDataGraph*, void> FillDataGraph; // function pointer
        public System.IntPtr SetDID;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, uint> GetDBOType; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.DBObj*> Allocate; // function pointer
        public System.IntPtr SaveToDisk;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> ReloadFromDisk; // function pointer
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

    /// <summary>Retrieves material objects from the database and stores them in the mesh's material array.
    /// <code>Offset: 0x00444A30
    /// char __thiscall RenderMesh::GetMaterialsFromDatabase(RenderMesh*)</code>
    /// </summary>
    /// <returns>True when every referenced material was successfully loaded; false if any lookup fails.</returns>
    public sbyte GetMaterialsFromDatabase() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderMesh, sbyte>)0x00444A30)(ref this);

    /// <summary>Releases all subobjects owned by the RenderMesh, invoking their cleanup routines and clearing references.
    /// <code>Offset: 0x00444AC0
    /// char __thiscall RenderMesh::ReleaseSubObjects(RenderMesh*)</code>
    /// </summary>
    /// <returns>A non‑zero value indicating that the operation succeeded.</returns>
    public sbyte ReleaseSubObjects() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderMesh, sbyte>)0x00444AC0)(ref this);

    /// <summary>Detects whether the render mesh includes skeletal animation data, caches the result, and returns how many mesh fragments were inspected.
    /// <code>Offset: 0x00444B00
    /// unsigned int __thiscall RenderMesh::CacheHasSkeletalData(RenderMesh*)</code>
    /// </summary>
    /// <returns>Number of fragments processed during the check. If no fragments exist, zero is returned.</returns>
    public uint CacheHasSkeletalData() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderMesh, uint>)0x00444B00)(ref this);

    /// <summary>Computes and caches the render bounding box for this RenderMesh by aggregating all vertices of its LOD fragments. If no fragments exist, stores a zero‑sized AABB.
    /// <code>Offset: 0x00444B80
    /// unsigned int __thiscall RenderMesh::CacheRenderBoundingBox(RenderMesh*)</code>
    /// </summary>
    /// <returns>The number of sub‑fragments examined while building the bounding box, or zero if none were processed.</returns>
    public uint CacheRenderBoundingBox() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderMesh, uint>)0x00444B80)(ref this);

    /// <summary>Prepares a specific mesh subset for rendering by updating its fragment and index buffer data.
    /// <code>Offset: 0x00444BF0
    /// char __thiscall RenderMesh::DrawSubset(RenderMesh*,unsigned int)</code>
    /// </summary>
    /// <param name="a2">The identifier of the mesh subset to process.</param>
    /// <returns>Non‑zero if the subset was successfully processed; zero otherwise.</returns>
    public sbyte DrawSubset(uint a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderMesh, uint, sbyte>)0x00444BF0)(ref this, a2);

    /// <summary>Generates topology data for each fragment of a render mesh, ensuring all fragments are prepared for rendering.
    /// <code>Offset: 0x00444D50
    /// unsigned int __thiscall RenderMesh::GenerateTopologyForFragments(RenderMesh*)</code>
    /// </summary>
    /// <returns>The total number of fragments processed.</returns>
    public uint GenerateTopologyForFragments() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderMesh, uint>)0x00444D50)(ref this);

    /// <summary>Organizes material batches across all render mesh fragments by retrieving materials from the database and invoking per‑fragment organization logic.
    /// <code>Offset: 0x00444D90
    /// unsigned int __thiscall RenderMesh::OrganizeFragmentBatches(RenderMesh*)</code>
    /// </summary>
    /// <returns>The number of fragments processed, usually matching the current fragment count.</returns>
    public uint OrganizeFragmentBatches() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderMesh, uint>)0x00444D90)(ref this);

    /// <summary>Returns the database object type identifier for a RenderMesh instance.
    /// <code>Offset: 0x004452C0
    /// int __thiscall RenderMesh::GetDBOType(RenderMesh*)</code>
    /// </summary>
    /// <returns>An integer constant (67) representing the RenderMesh DBO type.</returns>
    public int GetDBOType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderMesh, int>)0x004452C0)(ref this);

    /// <summary>Releases all render mesh fragments, clears fragment references, deallocates dynamic index arrays, and resets internal counters.
    /// <code>Offset: 0x004452D0
    /// void __thiscall RenderMesh::ReleaseFragments(RenderMesh*)</code>
    /// </summary>
    public void ReleaseFragments() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderMesh, void>)0x004452D0)(ref this);

    /// <summary>Cleans up all resources associated with the RenderMesh instance, releasing fragment data and referenced objects, resetting internal flags, clearing bounding boxes, and marking the mesh as destroyed.
    /// <code>Offset: 0x004453F0
    /// void __thiscall RenderMesh::Destroy(RenderMesh*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderMesh, void>)0x004453F0)(ref this);

    /// <summary>Retrieves all valid sub‑data identifiers from this RenderMesh and appends them to the supplied QualifiedDataIDArray.
    /// <code>Offset: 0x004454B0
    /// int __thiscall RenderMesh::GetSubDataIDs(RenderMesh*,QualifiedDataIDArray*)</code>
    /// </summary>
    /// <param name="a2">The array into which qualifying data IDs will be added.</param>
    /// <returns>The internal sub‑data container pointer (or zero if no IDs were present).</returns>
    public int GetSubDataIDs(ACBindings.Internal.QualifiedDataIDArray* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderMesh, ACBindings.Internal.QualifiedDataIDArray*, int>)0x004454B0)(ref this, a2);

    /// <summary>Releases all resources owned by a RenderMesh instance, invoking internal cleanup routines and then calling the base DBObj destructor.
    /// <code>Offset: 0x004455A0
    /// void __thiscall RenderMesh::~RenderMesh(RenderMesh*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderMesh, void>)0x004455A0)(ref this);

    /// <summary>Adds a RenderVertexBuffer to this RenderMesh's vertex array, creating the array if it does not yet exist.
    /// <code>Offset: 0x004456C0
    /// unsigned int __thiscall RenderMesh::AddVertexArray(RenderMesh*,RenderVertexBuffer*)</code>
    /// </summary>
    /// <param name="a2">The RenderVertexBuffer to append to the mesh.</param>
    /// <returns>The number of vertex buffers that were present in the mesh before the new buffer was added; this value is also the index at which the new buffer will be stored.</returns>
    public uint AddVertexArray(ACBindings.Internal.RenderVertexBuffer* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderMesh, ACBindings.Internal.RenderVertexBuffer*, uint>)0x004456C0)(ref this, a2);

    /// <summary>Adds a RenderIndexBuffer to the mesh’s internal indices list, creating and expanding the list as needed.
    /// <code>Offset: 0x00445740
    /// unsigned int __thiscall RenderMesh::AddIndexArray(RenderMesh*,RenderIndexBuffer*)</code>
    /// </summary>
    /// <param name="a2">The RenderIndexBuffer to append.</param>
    /// <returns>Previous number of index buffers stored in the mesh before this addition.</returns>
    public uint AddIndexArray(ACBindings.Internal.RenderIndexBuffer* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderMesh, ACBindings.Internal.RenderIndexBuffer*, uint>)0x00445740)(ref this, a2);

    /// <summary>Serializes a RenderMesh instance’s material array, vertex and index buffers, timestamps, and fragment list to or from an Archive, handling both loading and saving modes while respecting DBLoader settings and alignment requirements.
    /// <code>Offset: 0x004457C0
    /// void** __thiscall RenderMesh::Serialize(DBObj*,Archive*)</code>
    /// </summary>
    /// <param name="this">The RenderMesh object to be serialized.</param>
    /// <param name="io_archive">The archive used for reading or writing the mesh data.</param>
    /// <returns>A pointer obtained from the archive (e.g., a version token or read value), or null if no additional data is present.</returns>
    public void** Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderMesh, ACBindings.Internal.Archive*, void**>)0x004457C0)(ref this, io_archive);

    /// <summary>Parses a render‑mesh definition from the specified file node, populating its fragments and setting the appearance type.
    /// <code>Offset: 0x00445EA0
    /// char __thiscall RenderMesh::ParseFromFileNode(RenderMesh*,const PFileNode*)</code>
    /// </summary>
    /// <param name="file_node">The root <c>PFileNode</c> containing mesh data to be parsed.</param>
    /// <returns>Non‑zero on successful parsing; zero if the input is null or a parsing error occurs.</returns>
    public sbyte ParseFromFileNode(ACBindings.Internal.PFileNode* file_node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderMesh, ACBindings.Internal.PFileNode*, sbyte>)0x00445EA0)(ref this, file_node);

    /// <summary>Collects and stores indices of mesh fragments by type, filling render‑LOD and occluder lists while recording the first fragment marked for shadow LOD. Resets existing lists before processing.
    /// <code>Offset: 0x004460C0
    /// unsigned int __thiscall RenderMesh::GenerateFragmentIndexLists(RenderMesh*)</code>
    /// </summary>
    /// <param name="this">The RenderMesh instance whose fragment indices are generated.</param>
    /// <returns>The total number of fragments examined.</returns>
    public uint GenerateFragmentIndexLists() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderMesh, uint>)0x004460C0)(ref this);

    /// <summary>Adds the supplied RenderMeshBatch to the mesh’s render LOD system by locating or creating an appropriate fragment container and delegating to that fragment’s AddMaterialBatch method.
    /// <code>Offset: 0x00446180
    /// char __thiscall RenderMesh::AddBatchToRenderLOD(RenderMesh*,void***,RenderMeshBatch*)</code>
    /// </summary>
    /// <param name="a2">Reference to a pointer array used to identify (or create) the target fragment for the batch.</param>
    /// <param name="pBatch">The RenderMeshBatch containing primitives, material index, and related data to be added.</param>
    /// <returns>Non‑zero value if the batch was successfully added; zero otherwise.</returns>
    public sbyte AddBatchToRenderLOD(void*** a2, ACBindings.Internal.RenderMeshBatch* pBatch) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderMesh, void***, ACBindings.Internal.RenderMeshBatch*, sbyte>)0x00446180)(ref this, a2, pBatch);

    /// <summary>Caches material attribute flags for a mesh by inspecting each material group, aggregating support for lighting, multi‑pass lighting, combined ambient pass, glowing, and alpha blending while ensuring all materials within the mesh are consistently lit or unlit.
    /// <code>Offset: 0x00446200
    /// unsigned int __thiscall RenderMesh::CacheMaterialAttributes(RenderMesh*)</code>
    /// </summary>
    /// <returns>The number of material groups examined and cached during this operation.</returns>
    public uint CacheMaterialAttributes() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderMesh, uint>)0x00446200)(ref this);

    /// <summary>Refreshes cached rendering data for the mesh, updating material attributes, skeletal support flags, and the render bounding box.
    /// <code>Offset: 0x00446590
    /// unsigned int __thiscall RenderMesh::UpdateCachedData(RenderMesh*)</code>
    /// </summary>
    /// <returns>An unsigned integer returned by CacheRenderBoundingBox, usually a status code indicating success or failure.</returns>
    public uint UpdateCachedData() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderMesh, uint>)0x00446590)(ref this);

    /// <summary>Loads the mesh’s subobjects from the database, caching material attributes at runtime when appropriate.
    /// <code>Offset: 0x004465B0
    /// char __thiscall RenderMesh::GetSubObjects(RenderMesh*)</code>
    /// </summary>
    /// <returns>Returns 1 upon successful loading; otherwise returns the error code produced by GetMaterialsFromDatabase.</returns>
    public sbyte GetSubObjects() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderMesh, sbyte>)0x004465B0)(ref this);

    /// <summary>Refreshes cached rendering state of the mesh by updating material attributes, skeletal data flag, and bounding box.
    /// <code>Offset: 0x004465E0
    /// char __thiscall RenderMesh::Refresh(RenderMesh*,int)</code>
    /// </summary>
    /// <param name="a2">Reserved parameter; currently unused.</param>
    /// <returns>Non‑zero value indicates successful refresh.</returns>
    public sbyte Refresh(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderMesh, int, sbyte>)0x004465E0)(ref this, a2);

    /// <summary>Create an LOD rendering batch, initialize it with the supplied material and geometry parameters, and register it with the mesh’s LOD list.
    /// <code>Offset: 0x00446600
    /// char __thiscall RenderMesh::CreateLODBatch(RenderMesh*,void***,MaterialInstance*,enum PrimType,unsigned int,unsigned int,unsigned int,int,int,RenderVertexBuffer**)</code>
    /// </summary>
    /// <param name="a2">Pointer to a collection that will receive the created LOD batch.</param>
    /// <param name="a3">Material instance that defines appearance for the batch.</param>
    /// <param name="a4">Primitive type (e.g., triangles, lines) used to assemble vertices.</param>
    /// <param name="a5">Offset of the first index in the mesh’s index buffer.</param>
    /// <param name="a6">Count of indices to include for this LOD level.</param>
    /// <param name="a7">Stride or secondary parameter controlling geometry subdivision.</param>
    /// <param name="a8">Offset of the first vertex in the mesh’s vertex buffer.</param>
    /// <param name="a9">Number of vertices to use for this LOD level.</param>
    /// <param name="a10">Pointer to a RenderVertexBuffer that will be created or updated for the batch.</param>
    /// <returns>Non‑zero if the batch was successfully created and added; zero on failure.</returns>
    public sbyte CreateLODBatch(void*** a2, ACBindings.Internal.MaterialInstance* a3, ACBindings.Internal.PrimType a4, uint a5, uint a6, uint a7, int a8, int a9, ACBindings.Internal.RenderVertexBuffer** a10) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderMesh, void***, ACBindings.Internal.MaterialInstance*, ACBindings.Internal.PrimType, uint, uint, uint, int, int, ACBindings.Internal.RenderVertexBuffer**, sbyte>)0x00446600)(ref this, a2, a3, a4, a5, a6, a7, a8, a9, a10);

    /// <summary>Initializes a RenderMesh by generating fragment index lists, organizing fragment batches, caching material and skeletal data, computing bounding boxes, and optionally creating topology when not running in runtime mode.
    /// <code>Offset: 0x00446890
    /// char __thiscall RenderMesh::InitLoad(RenderMesh*)</code>
    /// </summary>
    /// <returns>Non‑zero if initialization succeeds; zero if the mesh lacks required information for initialization.</returns>
    public sbyte InitLoad() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderMesh, sbyte>)0x00446890)(ref this);

    /// <summary>Parses a RenderMesh from a versioned file node, loading its binary representation and initializing the mesh object.
    /// <code>Offset: 0x00446950
    /// bool __thiscall RenderMesh::ParseFromVersionedFileNode(RenderMesh*,PFileNode*)</code>
    /// </summary>
    /// <param name="a2">The file node containing the mesh data to parse.</param>
    /// <returns>True if parsing succeeds; otherwise false when the node is missing or binary data cannot be retrieved.</returns>
    public byte ParseFromVersionedFileNode(ACBindings.Internal.PFileNode* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderMesh, ACBindings.Internal.PFileNode*, byte>)0x00446950)(ref this, a2);

    /// <summary>Loads mesh data from the specified file node and prepares rendering resources such as materials, fragment lists, and bounding boxes.
    /// <code>Offset: 0x00446A60
    /// char __thiscall RenderMesh::FromFileNode(RenderMesh*,const PFileNode*)</code>
    /// </summary>
    /// <param name="file_node">The root file node containing mesh definitions.</param>
    /// <returns>Nonzero if the mesh was successfully parsed and initialized; zero otherwise.</returns>
    public sbyte FromFileNode(ACBindings.Internal.PFileNode* file_node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderMesh, ACBindings.Internal.PFileNode*, sbyte>)0x00446A60)(ref this, file_node);
}

