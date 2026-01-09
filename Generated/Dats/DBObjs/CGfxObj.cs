namespace ACBindings;

// CGfxObj
public unsafe struct CGfxObj
{
    // Base Classes
    public ACBindings.DBObj BaseClass_DBObj; // ACBindings.DBObj

    // Child Types
    // CGfxObj_vtbl
    public unsafe struct CGfxObj_vtbl
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

        // Methods
    }

    // Members
    public ACBindings.CMaterial* material;
    public uint num_surfaces;
    public ACBindings.CSurface** m_rgSurfaces;
    public ACBindings.CVertexArray vertex_array;
    public uint num_physics_polygons;
    public ACBindings.CPolygon* physics_polygons;
    public ACBindings.MeshBuffer* constructed_mesh;
    public int use_built_mesh;
    public ACBindings.CSphere* physics_sphere;
    public ACBindings.BSPTREE* physics_bsp;
    public ACBindings.AC1Legacy.Vector3 sort_center;
    public uint num_polygons;
    public ACBindings.CPolygon* polygons;
    public ACBindings.CSphere* drawing_sphere;
    public ACBindings.BSPTREE* drawing_bsp;
    public ACBindings.BBox gfx_bound_box;
    public ACBindings.IDClass___tagDataID m_didDegrade;

    // Methods
    // DBObj* __cdecl CGfxObj::Allocator()
    public static ACBindings.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.DBObj*>)0x004F7B10)();
    // bool __thiscall CGfxObj::TexVelocity(CGfxObj*,CVec2Duv)
    public byte TexVelocity(ACBindings.CVec2Duv delta) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CGfxObj, ACBindings.CVec2Duv, byte>)0x00534F10)(ref this, delta);
    // void __thiscall CGfxObj::init_end(CGfxObj*)
    public void init_end() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CGfxObj, void>)0x00534F40)(ref this);
    // void __thiscall CGfxObj::Destroy(CGfxObj*)
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CGfxObj, void>)0x005352C0)(ref this);
    // bool __thiscall CGfxObj::InitLoad(CGfxObj*)
    public byte InitLoad() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CGfxObj, byte>)0x005353F0)(ref this);
    // TransitionState __thiscall CGfxObj::find_obj_collisions(CGfxObj*,CTransition*,float)
    public ACBindings.TransitionState find_obj_collisions(ACBindings.CTransition* transition, float scale) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CGfxObj, ACBindings.CTransition*, float, ACBindings.TransitionState>)0x00535440)(ref this, transition, scale);
    // void __thiscall CGfxObj::GetSubDataIDs(CGfxObj*,QualifiedDataIDArray*)
    public void GetSubDataIDs(ACBindings.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CGfxObj, ACBindings.QualifiedDataIDArray*, void>)0x005355B0)(ref this, id_array);
    // void __thiscall CGfxObj::Serialize(CGfxObj*,Archive*)
    public void Serialize(ACBindings.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CGfxObj, ACBindings.Archive*, void>)0x005356B0)(ref this, io_archive);
}

