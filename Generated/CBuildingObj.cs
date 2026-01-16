namespace ACBindings.Internal;


/// <summary>Defines a building object in the simulation, encapsulating its physics base, portal network, leaf cell organization for spatial partitioning, and shadow components. Serves as a container linking geometry to game logic.</summary>
public unsafe struct CBuildingObj : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.CPhysicsObj BaseClass_CPhysicsObj; // ACBindings.Internal.CPhysicsObj

    // Statics
    public static ACBindings.Internal.Position** curr_pos = (ACBindings.Internal.Position**)0x008FB9B8;
    public static ACBindings.Internal.CPartCell*** curr_leaf_cells = (ACBindings.Internal.CPartCell***)0x008FB9BC;

    // Child Types
    public unsafe struct CBuildingObj_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CPhysicsObj*, void> CPhysicsObj_dtor_0; // function pointer

        // Methods
    }

    // Members
    public uint num_portals;
    public ACBindings.Internal.CBldPortal** portals;
    public uint num_leaves;
    public ACBindings.Internal.CPartCell** leaf_cells;
    public uint num_shadow;
    public ACBindings.Internal.DArray___CShadowPart_ptr shadow_list;

    // Generated Constructor
    public CBuildingObj() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Iterates through all portals of this building, adding each portal’s stab list entries to the supplied block stab list and updating the current count.
    /// <code>Offset: 0x006B60F0
    /// void __thiscall CBuildingObj::add_to_stablist(CBuildingObj*,unsigned int**,unsigned int*,unsigned int*)</code>
    /// </summary>
    /// <param name="block_stab_list">Pointer to an array where portal stab list data will be appended.</param>
    /// <param name="max_size">Maximum number of entries allowed in the stab list; used to prevent overflow.</param>
    /// <param name="stab_num">Current count of stab list entries, updated as new portals are added.</param>
    public void add_to_stablist(uint** block_stab_list, uint* max_size, uint* stab_num) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CBuildingObj, uint**, uint*, uint*, void>)0x006B60F0)(ref this, block_stab_list, max_size, stab_num);

    /// <summary>Detaches the building object from its current spatial cell and clears related references.
    /// <code>Offset: 0x006B6140
    /// void __thiscall CBuildingObj::remove(CBuildingObj*)</code>
    /// </summary>
    public void remove() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CBuildingObj, void>)0x006B6140)(ref this);

    /// <summary>Collects transit cells reachable from a building’s portals using a given position and set of spheres, updating an output cell array and path data structure.
    /// <code>Offset: 0x006B6170
    /// void __thiscall CBuildingObj::find_building_transit_cells(CBuildingObj*,const Position*,const unsigned int,const CSphere*,CELLARRAY*,SPHEREPATH*)</code>
    /// </summary>
    /// <param name="p">The starting position used to evaluate portal access.</param>
    /// <param name="num_sphere">The number of sphere entries to consider during traversal checks.</param>
    /// <param name="sphere">Pointer to the first CSphere in an array describing collision volumes.</param>
    /// <param name="cell_array">Container that receives cells identified as potential transit targets and related flags.</param>
    /// <param name="path">Structure populated with detailed path information for navigating between cells.</param>
    public void find_building_transit_cells(ACBindings.Internal.Position* p, uint num_sphere, ACBindings.Internal.CSphere* sphere, ACBindings.Internal.CELLARRAY* cell_array, ACBindings.Internal.SPHEREPATH* path) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CBuildingObj, ACBindings.Internal.Position*, uint, ACBindings.Internal.CSphere*, ACBindings.Internal.CELLARRAY*, ACBindings.Internal.SPHEREPATH*, void>)0x006B6170)(ref this, p, num_sphere, sphere, cell_array, path);

    /// <summary>Collects transit cells for the building by examining each portal’s connected cell with respect to a set of physics parts, storing results in the supplied CELLARRAY.
    /// <code>Offset: 0x006B61E0
    /// void __thiscall CBuildingObj::find_building_transit_cells(CBuildingObj*,const unsigned int,CPhysicsPart**,CELLARRAY*)</code>
    /// </summary>
    /// <param name="num_parts">The number of physics part pointers provided in the parts array.</param>
    /// <param name="parts">Array of CPhysicsPart* pointers used to determine relevant transition cells.</param>
    /// <param name="cell_array">Output container that receives discovered transit cells; should be initialized by the caller.</param>
    public void find_building_transit_cells(uint num_parts, ACBindings.Internal.CPhysicsPart** parts, ACBindings.Internal.CELLARRAY* cell_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CBuildingObj, uint, ACBindings.Internal.CPhysicsPart**, ACBindings.Internal.CELLARRAY*, void>)0x006B61E0)(ref this, num_parts, parts, cell_array);

    /// <summary>Initializes a new building object, constructing its physics base and resetting portal, leaf, and shadow lists to empty defaults.
    /// <code>Offset: 0x006B6290
    /// void __thiscall CBuildingObj::CBuildingObj(CBuildingObj*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CBuildingObj, void>)0x006B6290)(ref this);

    /// <summary>Creates and initializes a building physics object with the given number of parts, hash table size, initial hash values, and assigns it an identifier.
    /// <code>Offset: 0x006B62E0
    /// CPhysicsObj* __cdecl CBuildingObj::makeBuilding(int,void*,int,unsigned int)</code>
    /// </summary>
    /// <param name="a1">The number of physical parts that compose the building.</param>
    /// <param name="a2">The number of hash slots used for internal hashing; this value also determines the size of the hash array.</param>
    /// <param name="a3">Pointer to an array containing initial values for each hash slot. The array length must equal the value supplied in a2.</param>
    /// <param name="a4">A unique identifier assigned to the newly created building object.</param>
    /// <returns>Pointer to the initialized CPhysicsObj on success; otherwise, null after performing cleanup of any partially constructed resources.</returns>
    public static ACBindings.Internal.CPhysicsObj* makeBuilding(int a1, System.IntPtr a2, int a3, uint a4) => ((delegate* unmanaged[Cdecl]<int, System.IntPtr, int, uint, ACBindings.Internal.CPhysicsObj*>)0x006B62E0)(a1, a2, a3, a4);

    /// <summary>Destroys a CBuildingObj instance, releasing its portal, leaf cell, and shadow resources, resetting the associated counters to zero, and invoking the base CPhysicsObj destructor.
    /// <code>Offset: 0x006B63F0
    /// void __thiscall CBuildingObj::~CBuildingObj(CBuildingObj*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CBuildingObj, void>)0x006B63F0)(ref this);

    /// <summary>Adds the building object to a sort cell, updating its cell identifier and linking the object to the cell.
    /// <code>Offset: 0x006B6490
    /// void __thiscall CBuildingObj::add_to_cell(CBuildingObj*,CSortCell*)</code>
    /// </summary>
    /// <param name="new_cell">The target sort cell that will contain the building object.</param>
    public void add_to_cell(ACBindings.Internal.CSortCell* new_cell) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CBuildingObj, ACBindings.Internal.CSortCell*, void>)0x006B6490)(ref this, new_cell);

    /// <summary>Retrieves a physics object with the specified ID from any cell reachable through the building’s portals, searching recursively across connected environment cells.
    /// <code>Offset: 0x006B64E0
    /// CPhysicsObj* __thiscall CBuildingObj::get_object(CBuildingObj*,const unsigned int)</code>
    /// </summary>
    /// <param name="obj_iid">The unique identifier of the physics object to locate.</param>
    /// <returns>A pointer to the found CPhysicsObj instance; returns null if no matching object exists within the building’s connected cells.</returns>
    public ACBindings.Internal.CPhysicsObj* get_object(uint obj_iid) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CBuildingObj, uint, ACBindings.Internal.CPhysicsObj*>)0x006B64E0)(ref this, obj_iid);
}

