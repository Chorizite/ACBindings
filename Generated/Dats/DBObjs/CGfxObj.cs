namespace ACBindings.Internal;


/// <summary>
/// Manages the graphical representation of an object by storing its geometry, materials, surfaces, physics polygons, spheres, BSP trees, bounding volumes, and identifiers for degradation.
/// </summary>
public unsafe struct CGfxObj
{
    // Base Classes
    public ACBindings.Internal.DBObj BaseClass_DBObj; // ACBindings.Internal.DBObj

    // Child Types
    public unsafe struct CGfxObj_vtbl
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

        // Methods
    }

    // Members
    public ACBindings.Internal.CMaterial* material;
    public uint num_surfaces;
    public ACBindings.Internal.CSurface** m_rgSurfaces;
    public ACBindings.Internal.CVertexArray vertex_array;
    public uint num_physics_polygons;
    public ACBindings.Internal.CPolygon* physics_polygons;
    public ACBindings.Internal.MeshBuffer* ructed_mesh;
    public int use_built_mesh;
    public ACBindings.Internal.CSphere* physics_sphere;
    public ACBindings.Internal.BSPTREE* physics_bsp;
    public ACBindings.Internal.AC1Legacy.Vector3 sort_center;
    public uint num_polygons;
    public ACBindings.Internal.CPolygon* polygons;
    public ACBindings.Internal.CSphere* drawing_sphere;
    public ACBindings.Internal.BSPTREE* drawing_bsp;
    public ACBindings.Internal.BBox gfx_bound_box;
    public ACBindings.Internal.IDClass____tagDataID m_didDegrade;

    // Methods

    /// <summary>Allocates memory for a new CGfxObj instance, initializes its members to default values, and returns a pointer to the base DBObj part of the object.
    /// <code>Offset: 0x004F7B10
    /// DBObj* __cdecl CGfxObj::Allocator()</code>
    /// </summary>
    /// <returns>A pointer to the newly created CGfxObj instance cast as a DBObj; NULL if allocation fails.</returns>
    public static ACBindings.Internal.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.DBObj*>)0x004F7B10)();

    /// <summary>Enables UV animation for the object's constructed mesh and assigns the specified velocity vector to drive texture scrolling.
    /// <code>Offset: 0x00534F10
    /// bool __thiscall CGfxObj::TexVelocity(CGfxObj*,CVec2Duv)</code>
    /// </summary>
    /// <param name="delta">The 2D UV offset increment applied each frame, influencing how the texture scrolls over time.</param>
    /// <returns>True after configuring the UV animation; always returns true because configuration succeeds if a constructed mesh exists or simply succeeds otherwise.</returns>
    public byte TexVelocity(ACBindings.Internal.CVec2Duv delta) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CGfxObj, ACBindings.Internal.CVec2Duv, byte>)0x00534F10)(ref this, delta);

    /// <summary>Computes and stores the axis‑aligned bounding box for this graphics object based on its vertex array. When no vertices exist, both minimum and maximum bounds are initialized to zero vectors.
    /// <code>Offset: 0x00534F40
    /// void __thiscall CGfxObj::init_end(CGfxObj*)</code>
    /// </summary>
    public void init_end() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CGfxObj, void>)0x00534F40)(ref this);

    /// <summary>
    /// Releases all resources owned by the graphics object: deletes drawing and physics BSP trees, polygon arrays, physics sphere, vertex array, surface references, and the constructed mesh.
    /// 
    /// <code>Offset: 0x005352C0
    /// void __thiscall CGfxObj::Destroy(CGfxObj*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CGfxObj, void>)0x005352C0)(ref this);

    /// <summary>Prepares the graphics object for rendering by removing non‑portal nodes from its drawing BSP tree and attempting to build a runtime mesh, updating internal flags accordingly.
    /// <code>Offset: 0x005353F0
    /// bool __thiscall CGfxObj::InitLoad(CGfxObj*)</code>
    /// </summary>
    /// <returns>True when initialization completes; this implementation always returns true.</returns>
    public byte InitLoad() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CGfxObj, byte>)0x005353F0)(ref this);

    /// <summary>Checks whether this object's physics representation collides with the spheres described in a transition. If no spheres exist, reports success; otherwise it tests each sphere for intersection and, depending on the insertion type, either performs an initial placement or queries the object's BSP tree for collisions.
    /// <code>Offset: 0x00535440
    /// TransitionState __thiscall CGfxObj::find_obj_collisions(CGfxObj*,CTransition*,float)</code>
    /// </summary>
    /// <param name="transition">The transition containing sphere data to test against the object.</param>
    /// <param name="scale">A scaling factor applied when evaluating collisions with the BSP tree.</param>
    /// <returns>A TransitionState value indicating success or collision status.</returns>
    public ACBindings.Internal.TransitionState find_obj_collisions(ACBindings.Internal.CTransition* transition, float scale) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CGfxObj, ACBindings.Internal.CTransition*, float, ACBindings.Internal.TransitionState>)0x00535440)(ref this, transition, scale);

    /// <summary>Collects qualified data identifiers from each surface of the graphics object and adds the object's degrade identifier to the supplied array.
    /// <code>Offset: 0x005355B0
    /// void __thiscall CGfxObj::GetSubDataIDs(CGfxObj*,QualifiedDataIDArray*)</code>
    /// </summary>
    /// <param name="id_array">The collection into which data IDs are inserted.</param>
    public void GetSubDataIDs(ACBindings.Internal.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CGfxObj, ACBindings.Internal.QualifiedDataIDArray*, void>)0x005355B0)(ref this, id_array);

    /// <summary>Serializes a CGfxObj's surfaces, vertex array, polygons and associated BSP trees into or from an Archive, allocating resources when loading.
    /// <code>Offset: 0x005356B0
    /// void __thiscall CGfxObj::Serialize(CGfxObj*,Archive*)</code>
    /// </summary>
    /// <param name="this">The graphics object instance to serialize.</param>
    /// <param name="io_archive">Archive used for reading or writing the object's data.</param>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CGfxObj, ACBindings.Internal.Archive*, void>)0x005356B0)(ref this, io_archive);
}

