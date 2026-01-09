namespace ACBindings;

// CEnvCell
public unsafe struct CEnvCell
{
    // Base Classes
    public ACBindings.CObjCell BaseClass_CObjCell; // ACBindings.CObjCell

    // Statics
    public static int* master_incell_timestamp = (int*)0x0081ECC8;
    public static ACBindings.HashTable__uint__CEnvCell_ptr* visible_cell_table = (ACBindings.HashTable__uint__CEnvCell_ptr*)0x0081ED3C;
    public static ACBindings.HashTable__uint__CEnvCell_ptr* cell_flush_table = (ACBindings.HashTable__uint__CEnvCell_ptr*)0x0081EDB4;

    // Child Types
    // CEnvCell_vtbl
    public unsafe struct CEnvCell_vtbl
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
        public fixed byte gap58[4];
        public System.IntPtr GetAsEnvCell; // function pointer
        public fixed byte gap60[4];
        public System.IntPtr GetAsLandCell; // function pointer
        public System.IntPtr IsInView; // function pointer
        public System.IntPtr GetViewerDistance; // function pointer
        public System.IntPtr grab_visible_cells; // function pointer
        public System.IntPtr release_cells; // function pointer
        public System.IntPtr get_object; // function pointer
        public System.IntPtr find_transit_cells; // function pointer
        public System.IntPtr point_in_cell; // function pointer
        public System.IntPtr find_collisions; // function pointer
        public System.IntPtr find_env_collisions; // function pointer
        public System.IntPtr handle_move_restriction; // function pointer
        public System.IntPtr walkable_surface_type; // function pointer
        public System.IntPtr Trace; // function pointer
        public System.IntPtr init_static_objects; // function pointer

        // Methods
    }

    // Members
    public uint num_surfaces;
    public ACBindings.CSurface** surfaces;
    public ACBindings.CCellStruct* structure;
    public ACBindings.CEnvironment* env;
    public uint num_portals;
    public ACBindings.CCellPortal* portals;
    public uint num_static_objects;
    public System.IntPtr static_object_ids;
    public ACBindings.Frame* static_object_frames;
    public ACBindings.CPhysicsObj** static_objects;
    public ACBindings.RGBColor* light_array;
    public int incell_timestamp;
    public ACBindings.MeshBuffer* constructed_mesh;
    public int use_built_mesh;
    public uint m_current_render_frame_num;
    public uint num_view;
    public ACBindings.DArray__portal_view_type_ptr portal_view;

    // Generated Constructor
    public CEnvCell() {
        _ConstructorInternal();
    }

    // Methods
    // DBObj* __cdecl CEnvCell::Allocator()
    public static ACBindings.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.DBObj*>)0x004F7AF0)();
    // bool __thiscall CEnvCell::GetDrawnThisFrame(CEnvCell*)
    public byte GetDrawnThisFrame() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CEnvCell, byte>)0x0052CCD0)(ref this);
    // void __thiscall CEnvCell::SetDrawnThisFrame(CEnvCell*)
    public void SetDrawnThisFrame() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CEnvCell, void>)0x0052CCF0)(ref this);
    // TransitionState __thiscall CEnvCell::find_collisions(CEnvCell*,CTransition*)
    public ACBindings.TransitionState find_collisions(ACBindings.CTransition* transition) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CEnvCell, ACBindings.CTransition*, ACBindings.TransitionState>)0x0052CD10)(ref this, transition);
    // TransitionState __thiscall CEnvCell::find_env_collisions(CEnvCell*,CTransition*)
    public ACBindings.TransitionState find_env_collisions(ACBindings.CTransition* transition) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CEnvCell, ACBindings.CTransition*, ACBindings.TransitionState>)0x0052CD40)(ref this, transition);
    // int __thiscall CEnvCell::handle_move_restriction(ACCWeenieObject*,const ObjCollisionProfile*)
    public int handle_move_restriction(ACBindings.ObjCollisionProfile* prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CEnvCell, ACBindings.ObjCollisionProfile*, int>)0x0052CDD0)(ref this, prof);
    // unsigned int __thiscall CEnvCell::pack_size(CEnvCell*)
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CEnvCell, uint>)0x0052CDE0)(ref this);
    // void __thiscall CEnvCell::CEnvCell(CEnvCell*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CEnvCell, void>)0x0052CE50)(ref this);
    // int __thiscall CEnvCell::point_in_cell(CEnvCell*,const AC1Legacy::Vector3*)
    public int point_in_cell(ACBindings.AC1Legacy.Vector3* point) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CEnvCell, ACBindings.AC1Legacy.Vector3*, int>)0x0052CF10)(ref this, point);
    // void __thiscall CEnvCell::init_static_objects(CEnvCell*)
    public void init_static_objects() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CEnvCell, void>)0x0052CF60)(ref this);
    // void __thiscall CEnvCell::setup_view(CEnvCell*,unsigned int)
    public void setup_view(uint pres_view) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CEnvCell, uint, void>)0x0052D040)(ref this, pres_view);
    // int __thiscall CEnvCell::PreFetchCells(CEnvCell*,unsigned int*)
    public int PreFetchCells(uint* num_waiting_elements) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CEnvCell, uint*, int>)0x0052D070)(ref this, num_waiting_elements);
    // void __thiscall CEnvCell::check_building_transit(CEnvCell*,int,const Position*,const unsigned int,const CSphere*,CELLARRAY*,SPHEREPATH*)
    public void check_building_transit(int portal_id, ACBindings.Position* p, uint num_sphere, ACBindings.CSphere* sphere, ACBindings.CELLARRAY* cell_array, ACBindings.SPHEREPATH* path) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CEnvCell, int, ACBindings.Position*, uint, ACBindings.CSphere*, ACBindings.CELLARRAY*, ACBindings.SPHEREPATH*, void>)0x0052D1E0)(ref this, portal_id, p, num_sphere, sphere, cell_array, path);
    // void __thiscall CEnvCell::check_building_transit(CEnvCell*,int,const unsigned int,CPhysicsPart**,CELLARRAY*)
    public void check_building_transit(int portal_id, uint num_parts, ACBindings.CPhysicsPart** parts, ACBindings.CELLARRAY* cell_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CEnvCell, int, uint, ACBindings.CPhysicsPart**, ACBindings.CELLARRAY*, void>)0x0052D290)(ref this, portal_id, num_parts, parts, cell_array);
    // void __thiscall CEnvCell::find_transit_cells(CEnvCell*,const Position*,const unsigned int,const CSphere*,CELLARRAY*,SPHEREPATH*)
    public void find_transit_cells(ACBindings.Position* p, uint num_sphere, ACBindings.CSphere* sphere, ACBindings.CELLARRAY* cell_array, ACBindings.SPHEREPATH* path) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CEnvCell, ACBindings.Position*, uint, ACBindings.CSphere*, ACBindings.CELLARRAY*, ACBindings.SPHEREPATH*, void>)0x0052D430)(ref this, p, num_sphere, sphere, cell_array, path);
    // void __thiscall CEnvCell::find_transit_cells(CEnvCell*,const unsigned int,CPhysicsPart**,CELLARRAY*)
    public void find_transit_cells(uint num_parts, ACBindings.CPhysicsPart** parts, ACBindings.CELLARRAY* cell_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CEnvCell, uint, ACBindings.CPhysicsPart**, ACBindings.CELLARRAY*, void>)0x0052D6F0)(ref this, num_parts, parts, cell_array);
    // unsigned int __thiscall CEnvCell::Pack(CEnvCell*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CEnvCell, void**, uint, uint>)0x0052D910)(ref this, addr, size);
    // void __thiscall CEnvCell::calc_clip_planes(CEnvCell*)
    public void calc_clip_planes() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CEnvCell, void>)0x0052DD50)(ref this);
    // int __cdecl CEnvCell::PreFetchCells(int,unsigned int*)
    public static int PreFetchCells(int a1, uint* num_waiting_elements) => ((delegate* unmanaged[Cdecl]<int, uint*, int>)0x0052DE40)(a1, num_waiting_elements);
    // void __thiscall CEnvCell::GetSubDataIDs(CEnvCell*,QualifiedDataIDArray*)
    public void GetSubDataIDs(ACBindings.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CEnvCell, ACBindings.QualifiedDataIDArray*, void>)0x0052DEC0)(ref this, id_array);
    // void __cdecl CEnvCell::add_dynamic_lights()
    public static void add_dynamic_lights() => ((delegate* unmanaged[Cdecl]<void>)0x0052E070)();
    // int __thiscall CEnvCell::UnPack(CEnvCell*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CEnvCell, void**, uint, int>)0x0052E0D0)(ref this, addr, size);
    // int __thiscall CEnvCell::recursively_get_object(_DWORD*,int,_DWORD*)
    public int recursively_get_object(int a2, int* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CEnvCell, int, int*, int>)0x0052E500)(ref this, a2, a3);
    // void __thiscall CEnvCell::Destroy(CEnvCell*)
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CEnvCell, void>)0x0052E5F0)(ref this);
    // CEnvCell* __cdecl CEnvCell::GetVisible(unsigned int)
    public static ACBindings.CEnvCell* GetVisible(uint cell_id) => ((delegate* unmanaged[Cdecl]<uint, ACBindings.CEnvCell*>)0x0052E870)(cell_id);
    // CEnvCell* __thiscall CEnvCell::find_visible_child_cell(CEnvCell*,const AC1Legacy::Vector3*,const int)
    public ACBindings.CEnvCell* find_visible_child_cell(ACBindings.AC1Legacy.Vector3* origin, int bSearchCells) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CEnvCell, ACBindings.AC1Legacy.Vector3*, int, ACBindings.CEnvCell*>)0x0052E8B0)(ref this, origin, bSearchCells);
    // CEnvCell* __cdecl CEnvCell::add_visible_cell(unsigned int)
    public static ACBindings.CEnvCell* add_visible_cell(uint cell_id) => ((delegate* unmanaged[Cdecl]<uint, ACBindings.CEnvCell*>)0x0052EAA0)(cell_id);
    // void __cdecl CEnvCell::flush_cells()
    public static void flush_cells() => ((delegate* unmanaged[Cdecl]<void>)0x0052EB50)();
    // void __cdecl CEnvCell::grab_visible(unsigned int,unsigned int*,CLandBlock*)
    public static void grab_visible(uint num_stabs, uint* stab_list, ACBindings.CLandBlock* block) => ((delegate* unmanaged[Cdecl]<uint, uint*, ACBindings.CLandBlock*, void>)0x0052ECA0)(num_stabs, stab_list, block);
    // void __cdecl CEnvCell::release_visible(unsigned int,unsigned int*)
    public static void release_visible(uint num_stabs, uint* stab_list) => ((delegate* unmanaged[Cdecl]<uint, uint*, void>)0x0052ECE0)(num_stabs, stab_list);
    // void __thiscall CEnvCell::grab_visible_cells(CEnvCell*)
    public void grab_visible_cells() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CEnvCell, void>)0x0052EE80)(ref this);
    // void __thiscall CEnvCell::release_cells(CEnvCell*)
    public void release_cells() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CEnvCell, void>)0x0052EEE0)(ref this);
    // void __thiscall CEnvCell::curr_view_push(CEnvCell*)
    public void curr_view_push() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CEnvCell, void>)0x005A61A0)(ref this);
    // unsigned int __thiscall CEnvCell::walkable_surface_type(OldPublicWeenieDesc*,void**,unsigned int)
    public uint walkable_surface_type(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CEnvCell, void**, uint, uint>)0x006B4D00)(ref this, addr, size);
}

