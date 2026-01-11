namespace ACBindings.Internal;

public unsafe struct CEnvCell
{
    // Base Classes
    public ACBindings.Internal.CObjCell BaseClass_CObjCell; // ACBindings.Internal.CObjCell

    // Statics
    public static int* master_incell_timestamp = (int*)0x0081ECC8;

    // Child Types
    public unsafe struct CEnvCell_vtbl
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
        public fixed byte gap58[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CObjCell*, ACBindings.Internal.CEnvCell*> GetAsEnvCell; // function pointer
        public fixed byte gap60[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CObjCell*, ACBindings.Internal.CLandCell*> GetAsLandCell; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CObjCell*, ACBindings.Internal.BoundingType> IsInView; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CObjCell*, ACBindings.Internal.AC1Legacy.Vector3*, float> GetViewerDistance; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CObjCell*, void> grab_visible_cells; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CObjCell*, void> release_cells; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CObjCell*, uint, ACBindings.Internal.CPhysicsObj*> get_object; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CObjCell*, ACBindings.Internal.Position*, uint, ACBindings.Internal.CSphere*, ACBindings.Internal.CELLARRAY*, ACBindings.Internal.SPHEREPATH*, void> find_transit_cells; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CObjCell*, ACBindings.Internal.AC1Legacy.Vector3*, int> point_in_cell; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CObjCell*, ACBindings.Internal.CTransition*, ACBindings.Internal.TransitionState> find_collisions; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CObjCell*, ACBindings.Internal.CTransition*, ACBindings.Internal.TransitionState> find_env_collisions; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CObjCell*, ACBindings.Internal.CTransition*, int> handle_move_restriction; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CObjCell*, ACBindings.Internal.CPolygon*, ACBindings.Internal.Position*, ACBindings.Internal.SURFCHAR> walkable_surface_type; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CObjCell*, ACBindings.Internal.LOSParameters*, uint> Trace; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CObjCell*, void> init_static_objects; // function pointer

        // Methods
    }

    // Members
    public uint num_surfaces;
    public ACBindings.Internal.CSurface** surfaces;
    public ACBindings.Internal.CCellStruct* structure;
    public ACBindings.Internal.CEnvironment* env;
    public uint num_portals;
    public ACBindings.Internal.CCellPortal* portals;
    public uint num_static_objects;
    public System.IntPtr static_object_ids;
    public ACBindings.Internal.Frame* static_object_frames;
    public ACBindings.Internal.CPhysicsObj** static_objects;
    public ACBindings.Internal.RGBColor* light_array;
    public int incell_timestamp;
    public ACBindings.Internal.MeshBuffer* ructed_mesh;
    public int use_built_mesh;
    public uint m_current_render_frame_num;
    public uint num_view;
    public ACBindings.Internal.DArray___portal_view_type_ptr portal_view;

    // Generated Constructor
    public CEnvCell() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x004F7AF0
    /// DBObj* __cdecl CEnvCell::Allocator()</code>
    /// </summary>
    public static ACBindings.Internal.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.DBObj*>)0x004F7AF0)();

    /// <summary>
    /// <code>Offset: 0x0052CCD0
    /// bool __thiscall CEnvCell::GetDrawnThisFrame(CEnvCell*)</code>
    /// </summary>
    public byte GetDrawnThisFrame() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CEnvCell, byte>)0x0052CCD0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0052CCF0
    /// void __thiscall CEnvCell::SetDrawnThisFrame(CEnvCell*)</code>
    /// </summary>
    public void SetDrawnThisFrame() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CEnvCell, void>)0x0052CCF0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0052CD10
    /// TransitionState __thiscall CEnvCell::find_collisions(CEnvCell*,CTransition*)</code>
    /// </summary>
    public ACBindings.Internal.TransitionState find_collisions(ACBindings.Internal.CTransition* transition) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CEnvCell, ACBindings.Internal.CTransition*, ACBindings.Internal.TransitionState>)0x0052CD10)(ref this, transition);

    /// <summary>
    /// <code>Offset: 0x0052CD40
    /// TransitionState __thiscall CEnvCell::find_env_collisions(CEnvCell*,CTransition*)</code>
    /// </summary>
    public ACBindings.Internal.TransitionState find_env_collisions(ACBindings.Internal.CTransition* transition) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CEnvCell, ACBindings.Internal.CTransition*, ACBindings.Internal.TransitionState>)0x0052CD40)(ref this, transition);

    /// <summary>
    /// <code>Offset: 0x0052CDD0
    /// int __thiscall CEnvCell::handle_move_restriction(ACCWeenieObject*,const ObjCollisionProfile*)</code>
    /// </summary>
    public int handle_move_restriction(ACBindings.Internal.ObjCollisionProfile* prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CEnvCell, ACBindings.Internal.ObjCollisionProfile*, int>)0x0052CDD0)(ref this, prof);

    /// <summary>
    /// <code>Offset: 0x0052CDE0
    /// unsigned int __thiscall CEnvCell::pack_size(CEnvCell*)</code>
    /// </summary>
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CEnvCell, uint>)0x0052CDE0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0052CE50
    /// void __thiscall CEnvCell::CEnvCell(CEnvCell*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CEnvCell, void>)0x0052CE50)(ref this);

    /// <summary>
    /// <code>Offset: 0x0052CF10
    /// int __thiscall CEnvCell::point_in_cell(CEnvCell*,const AC1Legacy::Vector3*)</code>
    /// </summary>
    public int point_in_cell(ACBindings.Internal.AC1Legacy.Vector3* point) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CEnvCell, ACBindings.Internal.AC1Legacy.Vector3*, int>)0x0052CF10)(ref this, point);

    /// <summary>
    /// <code>Offset: 0x0052CF60
    /// void __thiscall CEnvCell::init_static_objects(CEnvCell*)</code>
    /// </summary>
    public void init_static_objects() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CEnvCell, void>)0x0052CF60)(ref this);

    /// <summary>
    /// <code>Offset: 0x0052D040
    /// void __thiscall CEnvCell::setup_view(CEnvCell*,unsigned int)</code>
    /// </summary>
    public void setup_view(uint pres_view) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CEnvCell, uint, void>)0x0052D040)(ref this, pres_view);

    /// <summary>
    /// <code>Offset: 0x0052D070
    /// int __thiscall CEnvCell::PreFetchCells(CEnvCell*,unsigned int*)</code>
    /// </summary>
    public int PreFetchCells(uint* num_waiting_elements) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CEnvCell, uint*, int>)0x0052D070)(ref this, num_waiting_elements);

    /// <summary>
    /// <code>Offset: 0x0052D1E0
    /// void __thiscall CEnvCell::check_building_transit(CEnvCell*,int,const Position*,const unsigned int,const CSphere*,CELLARRAY*,SPHEREPATH*)</code>
    /// </summary>
    public void check_building_transit(int portal_id, ACBindings.Internal.Position* p, uint num_sphere, ACBindings.Internal.CSphere* sphere, ACBindings.Internal.CELLARRAY* cell_array, ACBindings.Internal.SPHEREPATH* path) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CEnvCell, int, ACBindings.Internal.Position*, uint, ACBindings.Internal.CSphere*, ACBindings.Internal.CELLARRAY*, ACBindings.Internal.SPHEREPATH*, void>)0x0052D1E0)(ref this, portal_id, p, num_sphere, sphere, cell_array, path);

    /// <summary>
    /// <code>Offset: 0x0052D290
    /// void __thiscall CEnvCell::check_building_transit(CEnvCell*,int,const unsigned int,CPhysicsPart**,CELLARRAY*)</code>
    /// </summary>
    public void check_building_transit(int portal_id, uint num_parts, ACBindings.Internal.CPhysicsPart** parts, ACBindings.Internal.CELLARRAY* cell_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CEnvCell, int, uint, ACBindings.Internal.CPhysicsPart**, ACBindings.Internal.CELLARRAY*, void>)0x0052D290)(ref this, portal_id, num_parts, parts, cell_array);

    /// <summary>
    /// <code>Offset: 0x0052D430
    /// void __thiscall CEnvCell::find_transit_cells(CEnvCell*,const Position*,const unsigned int,const CSphere*,CELLARRAY*,SPHEREPATH*)</code>
    /// </summary>
    public void find_transit_cells(ACBindings.Internal.Position* p, uint num_sphere, ACBindings.Internal.CSphere* sphere, ACBindings.Internal.CELLARRAY* cell_array, ACBindings.Internal.SPHEREPATH* path) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CEnvCell, ACBindings.Internal.Position*, uint, ACBindings.Internal.CSphere*, ACBindings.Internal.CELLARRAY*, ACBindings.Internal.SPHEREPATH*, void>)0x0052D430)(ref this, p, num_sphere, sphere, cell_array, path);

    /// <summary>
    /// <code>Offset: 0x0052D6F0
    /// void __thiscall CEnvCell::find_transit_cells(CEnvCell*,const unsigned int,CPhysicsPart**,CELLARRAY*)</code>
    /// </summary>
    public void find_transit_cells(uint num_parts, ACBindings.Internal.CPhysicsPart** parts, ACBindings.Internal.CELLARRAY* cell_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CEnvCell, uint, ACBindings.Internal.CPhysicsPart**, ACBindings.Internal.CELLARRAY*, void>)0x0052D6F0)(ref this, num_parts, parts, cell_array);

    /// <summary>
    /// <code>Offset: 0x0052D910
    /// unsigned int __thiscall CEnvCell::Pack(CEnvCell*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CEnvCell, void**, uint, uint>)0x0052D910)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x0052DD50
    /// void __thiscall CEnvCell::calc_clip_planes(CEnvCell*)</code>
    /// </summary>
    public void calc_clip_planes() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CEnvCell, void>)0x0052DD50)(ref this);

    /// <summary>
    /// <code>Offset: 0x0052DE40
    /// int __cdecl CEnvCell::PreFetchCells(int,unsigned int*)</code>
    /// </summary>
    public static int PreFetchCells(int a1, uint* num_waiting_elements) => ((delegate* unmanaged[Cdecl]<int, uint*, int>)0x0052DE40)(a1, num_waiting_elements);

    /// <summary>
    /// <code>Offset: 0x0052DEC0
    /// void __thiscall CEnvCell::GetSubDataIDs(CEnvCell*,QualifiedDataIDArray*)</code>
    /// </summary>
    public void GetSubDataIDs(ACBindings.Internal.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CEnvCell, ACBindings.Internal.QualifiedDataIDArray*, void>)0x0052DEC0)(ref this, id_array);

    /// <summary>
    /// <code>Offset: 0x0052E070
    /// void __cdecl CEnvCell::add_dynamic_lights()</code>
    /// </summary>
    public static void add_dynamic_lights() => ((delegate* unmanaged[Cdecl]<void>)0x0052E070)();

    /// <summary>
    /// <code>Offset: 0x0052E0D0
    /// int __thiscall CEnvCell::UnPack(CEnvCell*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CEnvCell, void**, uint, int>)0x0052E0D0)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x0052E500
    /// int __thiscall CEnvCell::recursively_get_object(_DWORD*,int,_DWORD*)</code>
    /// </summary>
    public int recursively_get_object(int a2, int* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CEnvCell, int, int*, int>)0x0052E500)(ref this, a2, a3);

    /// <summary>
    /// <code>Offset: 0x0052E5F0
    /// void __thiscall CEnvCell::Destroy(CEnvCell*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CEnvCell, void>)0x0052E5F0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0052E870
    /// CEnvCell* __cdecl CEnvCell::GetVisible(unsigned int)</code>
    /// </summary>
    public static ACBindings.Internal.CEnvCell* GetVisible(uint cell_id) => ((delegate* unmanaged[Cdecl]<uint, ACBindings.Internal.CEnvCell*>)0x0052E870)(cell_id);

    /// <summary>
    /// <code>Offset: 0x0052E8B0
    /// CEnvCell* __thiscall CEnvCell::find_visible_child_cell(CEnvCell*,const AC1Legacy::Vector3*,const int)</code>
    /// </summary>
    public ACBindings.Internal.CEnvCell* find_visible_child_cell(ACBindings.Internal.AC1Legacy.Vector3* origin, int bSearchCells) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CEnvCell, ACBindings.Internal.AC1Legacy.Vector3*, int, ACBindings.Internal.CEnvCell*>)0x0052E8B0)(ref this, origin, bSearchCells);

    /// <summary>
    /// <code>Offset: 0x0052EAA0
    /// CEnvCell* __cdecl CEnvCell::add_visible_cell(unsigned int)</code>
    /// </summary>
    public static ACBindings.Internal.CEnvCell* add_visible_cell(uint cell_id) => ((delegate* unmanaged[Cdecl]<uint, ACBindings.Internal.CEnvCell*>)0x0052EAA0)(cell_id);

    /// <summary>
    /// <code>Offset: 0x0052EB50
    /// void __cdecl CEnvCell::flush_cells()</code>
    /// </summary>
    public static void flush_cells() => ((delegate* unmanaged[Cdecl]<void>)0x0052EB50)();

    /// <summary>
    /// <code>Offset: 0x0052ECA0
    /// void __cdecl CEnvCell::grab_visible(unsigned int,unsigned int*,CLandBlock*)</code>
    /// </summary>
    public static void grab_visible(uint num_stabs, uint* stab_list, ACBindings.Internal.CLandBlock* block) => ((delegate* unmanaged[Cdecl]<uint, uint*, ACBindings.Internal.CLandBlock*, void>)0x0052ECA0)(num_stabs, stab_list, block);

    /// <summary>
    /// <code>Offset: 0x0052ECE0
    /// void __cdecl CEnvCell::release_visible(unsigned int,unsigned int*)</code>
    /// </summary>
    public static void release_visible(uint num_stabs, uint* stab_list) => ((delegate* unmanaged[Cdecl]<uint, uint*, void>)0x0052ECE0)(num_stabs, stab_list);

    /// <summary>
    /// <code>Offset: 0x0052EE80
    /// void __thiscall CEnvCell::grab_visible_cells(CEnvCell*)</code>
    /// </summary>
    public void grab_visible_cells() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CEnvCell, void>)0x0052EE80)(ref this);

    /// <summary>
    /// <code>Offset: 0x0052EEE0
    /// void __thiscall CEnvCell::release_cells(CEnvCell*)</code>
    /// </summary>
    public void release_cells() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CEnvCell, void>)0x0052EEE0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005A61A0
    /// void __thiscall CEnvCell::curr_view_push(CEnvCell*)</code>
    /// </summary>
    public void curr_view_push() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CEnvCell, void>)0x005A61A0)(ref this);

    /// <summary>
    /// <code>Offset: 0x006B4D00
    /// unsigned int __thiscall CEnvCell::walkable_surface_type(OldPublicWeenieDesc*,void**,unsigned int)</code>
    /// </summary>
    public uint walkable_surface_type(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CEnvCell, void**, uint, uint>)0x006B4D00)(ref this, addr, size);
}

