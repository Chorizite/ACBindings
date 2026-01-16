namespace ACBindings.Internal;


/// <summary>Provides sorting information for an object cell, holding the base cell data and an optional building reference for ordering decisions.</summary>
public unsafe struct CSortCell
{
    // Base Classes
    public ACBindings.Internal.CObjCell BaseClass_CObjCell; // ACBindings.Internal.CObjCell

    // Child Types
    public unsafe struct CSortCell_vtbl
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
        public fixed byte gap58[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CObjCell*, ACBindings.Internal.CEnvCell*> GetAsEnvCell; // function pointer
        public fixed byte gap60[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CObjCell*, ACBindings.Internal.CLandCell*> GetAsLandCell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CObjCell*, ACBindings.Internal.BoundingType> IsInView; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CObjCell*, ACBindings.Internal.AC1Legacy.Vector3*, float> GetViewerDistance; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CObjCell*, void> grab_visible_cells; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CObjCell*, void> release_cells; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CObjCell*, uint, ACBindings.Internal.CPhysicsObj*> get_object; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CObjCell*, ACBindings.Internal.Position*, uint, ACBindings.Internal.CSphere*, ACBindings.Internal.CELLARRAY*, ACBindings.Internal.SPHEREPATH*, void> find_transit_cells; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CObjCell*, ACBindings.Internal.AC1Legacy.Vector3*, int> point_in_cell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CObjCell*, ACBindings.Internal.CTransition*, ACBindings.Internal.TransitionState> find_collisions; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CObjCell*, ACBindings.Internal.CTransition*, ACBindings.Internal.TransitionState> find_env_collisions; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CObjCell*, ACBindings.Internal.CTransition*, int> handle_move_restriction; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CObjCell*, ACBindings.Internal.CPolygon*, ACBindings.Internal.Position*, ACBindings.Internal.SURFCHAR> walkable_surface_type; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CObjCell*, ACBindings.Internal.LOSParameters*, uint> Trace; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CObjCell*, void> init_static_objects; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.CBuildingObj* building;

    // Generated Constructor
    public CSortCell() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>Initializes a CSortCell object by constructing its base cell components and resetting the building pointer to null.
    /// <code>Offset: 0x00534CF0
    /// void __thiscall CSortCell::CSortCell(CSortCell*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSortCell, void>)0x00534CF0)(ref this);

    /// <summary>Determines whether the cell currently contains a building object.
    /// <code>Offset: 0x00534D40
    /// int __thiscall CSortCell::has_building(CSortCell*)</code>
    /// </summary>
    /// <returns>Non‑zero when a building is present; zero indicates no building.</returns>
    public int has_building() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSortCell, int>)0x00534D40)(ref this);

    /// <summary>Associates the specified building object with the sort cell, assigning it only if no building is currently linked.
    /// <code>Offset: 0x00534D70
    /// void __thiscall CSortCell::add_building(CSortCell*,CBuildingObj*)</code>
    /// </summary>
    /// <param name="object">The building object to associate with this sort cell.</param>
    public void add_building(ACBindings.Internal.CBuildingObj* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSortCell, ACBindings.Internal.CBuildingObj*, void>)0x00534D70)(ref this, object_);

    /// <summary>Removes a building from the sorting cell by clearing its internal reference.
    /// <code>Offset: 0x00534D90
    /// void __thiscall CSortCell::remove_building(CSortCell*,CBuildingObj*)</code>
    /// </summary>
    /// <param name="object">The building object that should be removed; currently unused in the implementation.</param>
    public void remove_building(ACBindings.Internal.CBuildingObj* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSortCell, ACBindings.Internal.CBuildingObj*, void>)0x00534D90)(ref this, object_);

    /// <summary>Locates transit cells for a building by evaluating the supplied sphere data, populating the cell array and path structures with the results.
    /// <code>Offset: 0x00534DA0
    /// void __thiscall CSortCell::find_transit_cells(CSortCell*,const Position*,const unsigned int,const CSphere*,CELLARRAY*,SPHEREPATH*)</code>
    /// </summary>
    /// <param name="p">The reference position from which to start searching for transit cells.</param>
    /// <param name="num_sphere">The count of spheres provided in the traversal sequence.</param>
    /// <param name="sphere">Pointer to the first sphere (or array) used to test transit conditions against the building.</param>
    /// <param name="cell_array">Container that receives the identified transit cells for further processing.</param>
    /// <param name="path">Structure that records detailed transit information, including path steps and collision data.</param>
    public void find_transit_cells(ACBindings.Internal.Position* p, uint num_sphere, ACBindings.Internal.CSphere* sphere, ACBindings.Internal.CELLARRAY* cell_array, ACBindings.Internal.SPHEREPATH* path) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSortCell, ACBindings.Internal.Position*, uint, ACBindings.Internal.CSphere*, ACBindings.Internal.CELLARRAY*, ACBindings.Internal.SPHEREPATH*, void>)0x00534DA0)(ref this, p, num_sphere, sphere, cell_array, path);

    /// <summary>Finds transit cells for specified physics parts by delegating to the associated building object when present.
    /// <code>Offset: 0x00534DC0
    /// void __thiscall CSortCell::find_transit_cells(CSortCell*,const unsigned int,CPhysicsPart**,CELLARRAY*)</code>
    /// </summary>
    /// <param name="num_parts">Number of physics parts being considered.</param>
    /// <param name="parts">Array of pointers to the physics parts.</param>
    /// <param name="cell_array">Output array populated with discovered transit cells.</param>
    public void find_transit_cells(uint num_parts, ACBindings.Internal.CPhysicsPart** parts, ACBindings.Internal.CELLARRAY* cell_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSortCell, uint, ACBindings.Internal.CPhysicsPart**, ACBindings.Internal.CELLARRAY*, void>)0x00534DC0)(ref this, num_parts, parts, cell_array);

    /// <summary>Determines whether the cell’s building collides with the given transition path, updating collision state as needed.
    /// <code>Offset: 0x00534DE0
    /// TransitionState __thiscall CSortCell::find_collisions(CSortCell*,CTransition*)</code>
    /// </summary>
    /// <param name="transition">Transition data containing sphere path, object information, and current collision status to be updated during detection.</param>
    /// <returns>Returns OK_TS when no critical error occurs; otherwise returns an error code (e.g., if the building is missing or a collision check fails).</returns>
    public ACBindings.Internal.TransitionState find_collisions(ACBindings.Internal.CTransition* transition) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSortCell, ACBindings.Internal.CTransition*, ACBindings.Internal.TransitionState>)0x00534DE0)(ref this, transition);

    /// <summary>Retrieves a physics object by identifier from the cell, searching first in its local object list and then within its associated building if present.
    /// <code>Offset: 0x00534E00
    /// CPhysicsObj* __thiscall CSortCell::get_object(CSortCell*,const unsigned int)</code>
    /// </summary>
    /// <param name="obj_iid">The unique identifier of the desired object.</param>
    /// <returns>A pointer to the found CPhysicsObj instance or null if no matching object exists.</returns>
    public ACBindings.Internal.CPhysicsObj* get_object(uint obj_iid) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSortCell, uint, ACBindings.Internal.CPhysicsObj*>)0x00534E00)(ref this, obj_iid);
}

