namespace ACBindings.Internal;

public unsafe struct CGfxObj
{
    // Base Classes
    public ACBindings.Internal.DBObj BaseClass_DBObj; // ACBindings.Internal.DBObj

    // Child Types
    public unsafe struct CGfxObj_vtbl
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

    /// <summary>
    /// <code>Offset: 0x004F7B10
    /// DBObj* __cdecl CGfxObj::Allocator()</code>
    /// </summary>
    public static ACBindings.Internal.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.DBObj*>)0x004F7B10)();

    /// <summary>
    /// <code>Offset: 0x00534F10
    /// bool __thiscall CGfxObj::TexVelocity(CGfxObj*,CVec2Duv)</code>
    /// </summary>
    public byte TexVelocity(ACBindings.Internal.CVec2Duv delta) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CGfxObj, ACBindings.Internal.CVec2Duv, byte>)0x00534F10)(ref this, delta);

    /// <summary>
    /// <code>Offset: 0x00534F40
    /// void __thiscall CGfxObj::init_end(CGfxObj*)</code>
    /// </summary>
    public void init_end() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CGfxObj, void>)0x00534F40)(ref this);

    /// <summary>
    /// <code>Offset: 0x005352C0
    /// void __thiscall CGfxObj::Destroy(CGfxObj*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CGfxObj, void>)0x005352C0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005353F0
    /// bool __thiscall CGfxObj::InitLoad(CGfxObj*)</code>
    /// </summary>
    public byte InitLoad() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CGfxObj, byte>)0x005353F0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00535440
    /// TransitionState __thiscall CGfxObj::find_obj_collisions(CGfxObj*,CTransition*,float)</code>
    /// </summary>
    public ACBindings.Internal.TransitionState find_obj_collisions(ACBindings.Internal.CTransition* transition, float scale) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CGfxObj, ACBindings.Internal.CTransition*, float, ACBindings.Internal.TransitionState>)0x00535440)(ref this, transition, scale);

    /// <summary>
    /// <code>Offset: 0x005355B0
    /// void __thiscall CGfxObj::GetSubDataIDs(CGfxObj*,QualifiedDataIDArray*)</code>
    /// </summary>
    public void GetSubDataIDs(ACBindings.Internal.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CGfxObj, ACBindings.Internal.QualifiedDataIDArray*, void>)0x005355B0)(ref this, id_array);

    /// <summary>
    /// <code>Offset: 0x005356B0
    /// void __thiscall CGfxObj::Serialize(CGfxObj*,Archive*)</code>
    /// </summary>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CGfxObj, ACBindings.Internal.Archive*, void>)0x005356B0)(ref this, io_archive);
}

