namespace ACBindings;

// CLandCell
public unsafe struct CLandCell : System.IDisposable
{
    // Base Classes
    public ACBindings.CSortCell BaseClass_CSortCell; // ACBindings.CSortCell

    // Child Types
    // CLandCell_vtbl
    public unsafe struct CLandCell_vtbl
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
    public ACBindings.CPolygon** polygons;
    public ACBindings.BoundingType in_view;

    // Generated Constructor
    public CLandCell() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall CLandCell::CLandCell(CLandCell*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLandCell, void>)0x005339B0)(ref this);
    // BoundingType __thiscall CLandCell::IsInView(CLandCell*)
    public ACBindings.BoundingType IsInView() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLandCell, ACBindings.BoundingType>)0x005339F0)(ref this);
    // void __thiscall CLandCell::~CLandCell(CLandCell*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLandCell, void>)0x00533A00)(ref this);
    // int __thiscall CLandCell::find_terrain_poly(CLandCell*,const AC1Legacy::Vector3*,const CPolygon**)
    public int find_terrain_poly(ACBindings.AC1Legacy.Vector3* origin, ACBindings.CPolygon** walkable) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLandCell, ACBindings.AC1Legacy.Vector3*, ACBindings.CPolygon**, int>)0x00533A30)(ref this, origin, walkable);
    // int __thiscall CLandCell::point_in_cell(CLandCell*,const AC1Legacy::Vector3*)
    public int point_in_cell(ACBindings.AC1Legacy.Vector3* point) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLandCell, ACBindings.AC1Legacy.Vector3*, int>)0x00533A80)(ref this, point);
    // TransitionState __thiscall CLandCell::find_collisions(CLandCell*,CTransition*)
    public ACBindings.TransitionState find_collisions(ACBindings.CTransition* transition) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLandCell, ACBindings.CTransition*, ACBindings.TransitionState>)0x00533AA0)(ref this, transition);
    // void __thiscall CLandCell::grab_visible_cells(CLandCell*)
    public void grab_visible_cells() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLandCell, void>)0x00533AD0)(ref this);
    // void __thiscall CLandCell::release_cells(CLandCell*)
    public void release_cells() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLandCell, void>)0x00533AE0)(ref this);
    // CLandCell* __cdecl CLandCell::Get(unsigned int)
    public static ACBindings.CLandCell* Get(uint cell_id) => ((delegate* unmanaged[Cdecl]<uint, ACBindings.CLandCell*>)0x00533AF0)(cell_id);
    // unsigned int __thiscall CLandCell::Trace(CLandCell*,LOSParameters*)
    public uint Trace(ACBindings.LOSParameters* los) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLandCell, ACBindings.LOSParameters*, uint>)0x00533B20)(ref this, los);
    // SURFCHAR __thiscall CLandCell::find_terrain(CLandCell*,const Position*)
    public ACBindings.SURFCHAR find_terrain(ACBindings.Position* pos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLandCell, ACBindings.Position*, ACBindings.SURFCHAR>)0x00533B60)(ref this, pos);
    // void __cdecl CLandCell::add_outside_cell(CELLARRAY*,int,int)
    public static void add_outside_cell(ACBindings.CELLARRAY* cell_array, int x, int y) => ((delegate* unmanaged[Cdecl]<ACBindings.CELLARRAY*, int, int, void>)0x00533C00)(cell_array, x, y);
    // TransitionState __thiscall CLandCell::find_env_collisions(CLandCell*,CTransition*)
    public ACBindings.TransitionState find_env_collisions(ACBindings.CTransition* transition) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLandCell, ACBindings.CTransition*, ACBindings.TransitionState>)0x00533C60)(ref this, transition);
    // int __thiscall CLandCell::handle_move_restriction(CLandCell*,CTransition*)
    public int handle_move_restriction(ACBindings.CTransition* transition) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLandCell, ACBindings.CTransition*, int>)0x00533DB0)(ref this, transition);
    // float __thiscall CLandCell::GetViewerDistance(CLandCell*,AC1Legacy::Vector3*)
    public float GetViewerDistance(ACBindings.AC1Legacy.Vector3* diff_vec) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLandCell, ACBindings.AC1Legacy.Vector3*, float>)0x00533E80)(ref this, diff_vec);
    // SURFCHAR __thiscall CLandCell::walkable_surface_type(CLandCell*,const CPolygon*,const Position*)
    public ACBindings.SURFCHAR walkable_surface_type(ACBindings.CPolygon* walkable, ACBindings.Position* pos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLandCell, ACBindings.CPolygon*, ACBindings.Position*, ACBindings.SURFCHAR>)0x00533ED0)(ref this, walkable, pos);
    // void __cdecl CLandCell::add_cell_block(int,int,int,int,CELLARRAY*)
    public static void add_cell_block(int min_x, int min_y, int max_x, int max_y, ACBindings.CELLARRAY* cell_array) => ((delegate* unmanaged[Cdecl]<int, int, int, int, ACBindings.CELLARRAY*, void>)0x00533F10)(min_x, min_y, max_x, max_y, cell_array);
    // void __cdecl CLandCell::check_add_cell_boundary(CELLARRAY*,const Vec2D*,int,int,float,float)
    public static void check_add_cell_boundary(ACBindings.CELLARRAY* cell_array, ACBindings.Vec2D* pt, int x, int y, float incell_max, float incell_min) => ((delegate* unmanaged[Cdecl]<ACBindings.CELLARRAY*, ACBindings.Vec2D*, int, int, float, float, void>)0x00533FA0)(cell_array, pt, x, y, incell_max, incell_min);
    // void __cdecl CLandCell::add_all_outside_cells(const unsigned int,CPhysicsPart**,CELLARRAY*)
    public static void add_all_outside_cells(uint num_parts, ACBindings.CPhysicsPart** parts, ACBindings.CELLARRAY* cell_array) => ((delegate* unmanaged[Cdecl]<uint, ACBindings.CPhysicsPart**, ACBindings.CELLARRAY*, void>)0x005340A0)(num_parts, parts, cell_array);
    // void __cdecl CLandCell::add_all_outside_cells(const Position*,const unsigned int,const CSphere*,CELLARRAY*)
    public static void add_all_outside_cells(ACBindings.Position* p, uint num_sphere, ACBindings.CSphere* sphere, ACBindings.CELLARRAY* cell_array) => ((delegate* unmanaged[Cdecl]<ACBindings.Position*, uint, ACBindings.CSphere*, ACBindings.CELLARRAY*, void>)0x00534370)(p, num_sphere, sphere, cell_array);
    // void __thiscall CLandCell::find_transit_cells(CLandCell*,const Position*,const unsigned int,const CSphere*,CELLARRAY*,SPHEREPATH*)
    public void find_transit_cells(ACBindings.Position* p, uint num_sphere, ACBindings.CSphere* sphere, ACBindings.CELLARRAY* cell_array, ACBindings.SPHEREPATH* path) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLandCell, ACBindings.Position*, uint, ACBindings.CSphere*, ACBindings.CELLARRAY*, ACBindings.SPHEREPATH*, void>)0x00534540)(ref this, p, num_sphere, sphere, cell_array, path);
    // void __thiscall CLandCell::find_transit_cells(CLandCell*,const unsigned int,CPhysicsPart**,CELLARRAY*)
    public void find_transit_cells(uint num_parts, ACBindings.CPhysicsPart** parts, ACBindings.CELLARRAY* cell_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLandCell, uint, ACBindings.CPhysicsPart**, ACBindings.CELLARRAY*, void>)0x00534580)(ref this, num_parts, parts, cell_array);
}

