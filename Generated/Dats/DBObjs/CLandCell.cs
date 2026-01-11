namespace ACBindings.Internal;

public unsafe struct CLandCell : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.CSortCell BaseClass_CSortCell; // ACBindings.Internal.CSortCell

    // Child Types
    public unsafe struct CLandCell_vtbl
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
    public ACBindings.Internal.CPolygon** polygons;
    public ACBindings.Internal.BoundingType in_view;

    // Generated Constructor
    public CLandCell() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x005339B0
    /// void __thiscall CLandCell::CLandCell(CLandCell*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandCell, void>)0x005339B0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005339F0
    /// BoundingType __thiscall CLandCell::IsInView(CLandCell*)</code>
    /// </summary>
    public ACBindings.Internal.BoundingType IsInView() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandCell, ACBindings.Internal.BoundingType>)0x005339F0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00533A00
    /// void __thiscall CLandCell::~CLandCell(CLandCell*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandCell, void>)0x00533A00)(ref this);

    /// <summary>
    /// <code>Offset: 0x00533A30
    /// int __thiscall CLandCell::find_terrain_poly(CLandCell*,const AC1Legacy::Vector3*,const CPolygon**)</code>
    /// </summary>
    public int find_terrain_poly(ACBindings.Internal.AC1Legacy.Vector3* origin, ACBindings.Internal.CPolygon** walkable) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandCell, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.CPolygon**, int>)0x00533A30)(ref this, origin, walkable);

    /// <summary>
    /// <code>Offset: 0x00533A80
    /// int __thiscall CLandCell::point_in_cell(CLandCell*,const AC1Legacy::Vector3*)</code>
    /// </summary>
    public int point_in_cell(ACBindings.Internal.AC1Legacy.Vector3* point) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandCell, ACBindings.Internal.AC1Legacy.Vector3*, int>)0x00533A80)(ref this, point);

    /// <summary>
    /// <code>Offset: 0x00533AA0
    /// TransitionState __thiscall CLandCell::find_collisions(CLandCell*,CTransition*)</code>
    /// </summary>
    public ACBindings.Internal.TransitionState find_collisions(ACBindings.Internal.CTransition* transition) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandCell, ACBindings.Internal.CTransition*, ACBindings.Internal.TransitionState>)0x00533AA0)(ref this, transition);

    /// <summary>
    /// <code>Offset: 0x00533AD0
    /// void __thiscall CLandCell::grab_visible_cells(CLandCell*)</code>
    /// </summary>
    public void grab_visible_cells() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandCell, void>)0x00533AD0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00533AE0
    /// void __thiscall CLandCell::release_cells(CLandCell*)</code>
    /// </summary>
    public void release_cells() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandCell, void>)0x00533AE0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00533AF0
    /// CLandCell* __cdecl CLandCell::Get(unsigned int)</code>
    /// </summary>
    public static ACBindings.Internal.CLandCell* Get(uint cell_id) => ((delegate* unmanaged[Cdecl]<uint, ACBindings.Internal.CLandCell*>)0x00533AF0)(cell_id);

    /// <summary>
    /// <code>Offset: 0x00533B20
    /// unsigned int __thiscall CLandCell::Trace(CLandCell*,LOSParameters*)</code>
    /// </summary>
    public uint Trace(ACBindings.Internal.LOSParameters* los) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandCell, ACBindings.Internal.LOSParameters*, uint>)0x00533B20)(ref this, los);

    /// <summary>
    /// <code>Offset: 0x00533B60
    /// SURFCHAR __thiscall CLandCell::find_terrain(CLandCell*,const Position*)</code>
    /// </summary>
    public ACBindings.Internal.SURFCHAR find_terrain(ACBindings.Internal.Position* pos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandCell, ACBindings.Internal.Position*, ACBindings.Internal.SURFCHAR>)0x00533B60)(ref this, pos);

    /// <summary>
    /// <code>Offset: 0x00533C00
    /// void __cdecl CLandCell::add_outside_cell(CELLARRAY*,int,int)</code>
    /// </summary>
    public static void add_outside_cell(ACBindings.Internal.CELLARRAY* cell_array, int x, int y) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CELLARRAY*, int, int, void>)0x00533C00)(cell_array, x, y);

    /// <summary>
    /// <code>Offset: 0x00533C60
    /// TransitionState __thiscall CLandCell::find_env_collisions(CLandCell*,CTransition*)</code>
    /// </summary>
    public ACBindings.Internal.TransitionState find_env_collisions(ACBindings.Internal.CTransition* transition) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandCell, ACBindings.Internal.CTransition*, ACBindings.Internal.TransitionState>)0x00533C60)(ref this, transition);

    /// <summary>
    /// <code>Offset: 0x00533DB0
    /// int __thiscall CLandCell::handle_move_restriction(CLandCell*,CTransition*)</code>
    /// </summary>
    public int handle_move_restriction(ACBindings.Internal.CTransition* transition) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandCell, ACBindings.Internal.CTransition*, int>)0x00533DB0)(ref this, transition);

    /// <summary>
    /// <code>Offset: 0x00533E80
    /// float __thiscall CLandCell::GetViewerDistance(CLandCell*,AC1Legacy::Vector3*)</code>
    /// </summary>
    public float GetViewerDistance(ACBindings.Internal.AC1Legacy.Vector3* diff_vec) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandCell, ACBindings.Internal.AC1Legacy.Vector3*, float>)0x00533E80)(ref this, diff_vec);

    /// <summary>
    /// <code>Offset: 0x00533ED0
    /// SURFCHAR __thiscall CLandCell::walkable_surface_type(CLandCell*,const CPolygon*,const Position*)</code>
    /// </summary>
    public ACBindings.Internal.SURFCHAR walkable_surface_type(ACBindings.Internal.CPolygon* walkable, ACBindings.Internal.Position* pos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandCell, ACBindings.Internal.CPolygon*, ACBindings.Internal.Position*, ACBindings.Internal.SURFCHAR>)0x00533ED0)(ref this, walkable, pos);

    /// <summary>
    /// <code>Offset: 0x00533F10
    /// void __cdecl CLandCell::add_cell_block(int,int,int,int,CELLARRAY*)</code>
    /// </summary>
    public static void add_cell_block(int min_x, int min_y, int max_x, int max_y, ACBindings.Internal.CELLARRAY* cell_array) => ((delegate* unmanaged[Cdecl]<int, int, int, int, ACBindings.Internal.CELLARRAY*, void>)0x00533F10)(min_x, min_y, max_x, max_y, cell_array);

    /// <summary>
    /// <code>Offset: 0x00533FA0
    /// void __cdecl CLandCell::check_add_cell_boundary(CELLARRAY*,const Vec2D*,int,int,float,float)</code>
    /// </summary>
    public static void check_add_cell_boundary(ACBindings.Internal.CELLARRAY* cell_array, ACBindings.Internal.Vec2D* pt, int x, int y, float incell_max, float incell_min) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CELLARRAY*, ACBindings.Internal.Vec2D*, int, int, float, float, void>)0x00533FA0)(cell_array, pt, x, y, incell_max, incell_min);

    /// <summary>
    /// <code>Offset: 0x005340A0
    /// void __cdecl CLandCell::add_all_outside_cells(const unsigned int,CPhysicsPart**,CELLARRAY*)</code>
    /// </summary>
    public static void add_all_outside_cells(uint num_parts, ACBindings.Internal.CPhysicsPart** parts, ACBindings.Internal.CELLARRAY* cell_array) => ((delegate* unmanaged[Cdecl]<uint, ACBindings.Internal.CPhysicsPart**, ACBindings.Internal.CELLARRAY*, void>)0x005340A0)(num_parts, parts, cell_array);

    /// <summary>
    /// <code>Offset: 0x00534370
    /// void __cdecl CLandCell::add_all_outside_cells(const Position*,const unsigned int,const CSphere*,CELLARRAY*)</code>
    /// </summary>
    public static void add_all_outside_cells(ACBindings.Internal.Position* p, uint num_sphere, ACBindings.Internal.CSphere* sphere, ACBindings.Internal.CELLARRAY* cell_array) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.Position*, uint, ACBindings.Internal.CSphere*, ACBindings.Internal.CELLARRAY*, void>)0x00534370)(p, num_sphere, sphere, cell_array);

    /// <summary>
    /// <code>Offset: 0x00534540
    /// void __thiscall CLandCell::find_transit_cells(CLandCell*,const Position*,const unsigned int,const CSphere*,CELLARRAY*,SPHEREPATH*)</code>
    /// </summary>
    public void find_transit_cells(ACBindings.Internal.Position* p, uint num_sphere, ACBindings.Internal.CSphere* sphere, ACBindings.Internal.CELLARRAY* cell_array, ACBindings.Internal.SPHEREPATH* path) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandCell, ACBindings.Internal.Position*, uint, ACBindings.Internal.CSphere*, ACBindings.Internal.CELLARRAY*, ACBindings.Internal.SPHEREPATH*, void>)0x00534540)(ref this, p, num_sphere, sphere, cell_array, path);

    /// <summary>
    /// <code>Offset: 0x00534580
    /// void __thiscall CLandCell::find_transit_cells(CLandCell*,const unsigned int,CPhysicsPart**,CELLARRAY*)</code>
    /// </summary>
    public void find_transit_cells(uint num_parts, ACBindings.Internal.CPhysicsPart** parts, ACBindings.Internal.CELLARRAY* cell_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandCell, uint, ACBindings.Internal.CPhysicsPart**, ACBindings.Internal.CELLARRAY*, void>)0x00534580)(ref this, num_parts, parts, cell_array);
}

