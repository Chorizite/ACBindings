namespace ACBindings.Internal;

public unsafe struct CBuildingObj : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.CPhysicsObj BaseClass_CPhysicsObj; // ACBindings.Internal.CPhysicsObj

    // Statics
    public static ACBindings.Internal.Position* curr_pos = (ACBindings.Internal.Position*)0x008FB9B8;
    public static ACBindings.Internal.CPartCell* curr_leaf_cells = (ACBindings.Internal.CPartCell*)0x008FB9BC;

    // Child Types
    public unsafe struct CBuildingObj_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CPhysicsObj*, void> CPhysicsObj_dtor_0; // function pointer

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

    /// <summary>
    /// <code>Offset: 0x006B60F0
    /// void __thiscall CBuildingObj::add_to_stablist(CBuildingObj*,unsigned int**,unsigned int*,unsigned int*)</code>
    /// </summary>
    public void add_to_stablist(uint** block_stab_list, uint* max_size, uint* stab_num) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CBuildingObj, uint**, uint*, uint*, void>)0x006B60F0)(ref this, block_stab_list, max_size, stab_num);

    /// <summary>
    /// <code>Offset: 0x006B6140
    /// void __thiscall CBuildingObj::remove(CBuildingObj*)</code>
    /// </summary>
    public void remove() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CBuildingObj, void>)0x006B6140)(ref this);

    /// <summary>
    /// <code>Offset: 0x006B6170
    /// void __thiscall CBuildingObj::find_building_transit_cells(CBuildingObj*,const Position*,const unsigned int,const CSphere*,CELLARRAY*,SPHEREPATH*)</code>
    /// </summary>
    public void find_building_transit_cells(ACBindings.Internal.Position* p, uint num_sphere, ACBindings.Internal.CSphere* sphere, ACBindings.Internal.CELLARRAY* cell_array, ACBindings.Internal.SPHEREPATH* path) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CBuildingObj, ACBindings.Internal.Position*, uint, ACBindings.Internal.CSphere*, ACBindings.Internal.CELLARRAY*, ACBindings.Internal.SPHEREPATH*, void>)0x006B6170)(ref this, p, num_sphere, sphere, cell_array, path);

    /// <summary>
    /// <code>Offset: 0x006B61E0
    /// void __thiscall CBuildingObj::find_building_transit_cells(CBuildingObj*,const unsigned int,CPhysicsPart**,CELLARRAY*)</code>
    /// </summary>
    public void find_building_transit_cells(uint num_parts, ACBindings.Internal.CPhysicsPart** parts, ACBindings.Internal.CELLARRAY* cell_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CBuildingObj, uint, ACBindings.Internal.CPhysicsPart**, ACBindings.Internal.CELLARRAY*, void>)0x006B61E0)(ref this, num_parts, parts, cell_array);

    /// <summary>
    /// <code>Offset: 0x006B6290
    /// void __thiscall CBuildingObj::CBuildingObj(CBuildingObj*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CBuildingObj, void>)0x006B6290)(ref this);

    /// <summary>
    /// <code>Offset: 0x006B62E0
    /// CPhysicsObj* __cdecl CBuildingObj::makeBuilding(int,void*,int,unsigned int)</code>
    /// </summary>
    public static ACBindings.Internal.CPhysicsObj* makeBuilding(int a1, System.IntPtr a2, int a3, uint a4) => ((delegate* unmanaged[Cdecl]<int, System.IntPtr, int, uint, ACBindings.Internal.CPhysicsObj*>)0x006B62E0)(a1, a2, a3, a4);

    /// <summary>
    /// <code>Offset: 0x006B63F0
    /// void __thiscall CBuildingObj::~CBuildingObj(CBuildingObj*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CBuildingObj, void>)0x006B63F0)(ref this);

    /// <summary>
    /// <code>Offset: 0x006B6490
    /// void __thiscall CBuildingObj::add_to_cell(CBuildingObj*,CSortCell*)</code>
    /// </summary>
    public void add_to_cell(ACBindings.Internal.CSortCell* new_cell) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CBuildingObj, ACBindings.Internal.CSortCell*, void>)0x006B6490)(ref this, new_cell);

    /// <summary>
    /// <code>Offset: 0x006B64E0
    /// CPhysicsObj* __thiscall CBuildingObj::get_object(CBuildingObj*,const unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.CPhysicsObj* get_object(uint obj_iid) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CBuildingObj, uint, ACBindings.Internal.CPhysicsObj*>)0x006B64E0)(ref this, obj_iid);
}

