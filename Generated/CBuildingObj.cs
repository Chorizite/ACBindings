namespace ACBindings;

// CBuildingObj
public unsafe struct CBuildingObj : System.IDisposable
{
    // Base Classes
    public ACBindings.CPhysicsObj BaseClass_CPhysicsObj; // ACBindings.CPhysicsObj

    // Statics
    public static ACBindings.Position* curr_pos = (ACBindings.Position*)0x008FB9B8;
    public static ACBindings.CPartCell* curr_leaf_cells = (ACBindings.CPartCell*)0x008FB9BC;

    // Child Types
    // CBuildingObj_vtbl
    public unsafe struct CBuildingObj_vtbl
    {
        // Members
        public System.IntPtr CPhysicsObj_dtor_0; // function pointer

        // Methods
    }

    // Members
    public uint num_portals;
    public ACBindings.CBldPortal** portals;
    public uint num_leaves;
    public ACBindings.CPartCell** leaf_cells;
    public uint num_shadow;
    public ACBindings.DArray__CShadowPart_ptr shadow_list;

    // Generated Constructor
    public CBuildingObj() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall CBuildingObj::add_to_stablist(CBuildingObj*,unsigned int**,unsigned int*,unsigned int*)
    public void add_to_stablist(uint** block_stab_list, uint* max_size, uint* stab_num) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CBuildingObj, uint**, uint*, uint*, void>)0x006B60F0)(ref this, block_stab_list, max_size, stab_num);
    // void __thiscall CBuildingObj::remove(CBuildingObj*)
    public void remove() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CBuildingObj, void>)0x006B6140)(ref this);
    // void __thiscall CBuildingObj::find_building_transit_cells(CBuildingObj*,const Position*,const unsigned int,const CSphere*,CELLARRAY*,SPHEREPATH*)
    public void find_building_transit_cells(ACBindings.Position* p, uint num_sphere, ACBindings.CSphere* sphere, ACBindings.CELLARRAY* cell_array, ACBindings.SPHEREPATH* path) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CBuildingObj, ACBindings.Position*, uint, ACBindings.CSphere*, ACBindings.CELLARRAY*, ACBindings.SPHEREPATH*, void>)0x006B6170)(ref this, p, num_sphere, sphere, cell_array, path);
    // void __thiscall CBuildingObj::find_building_transit_cells(CBuildingObj*,const unsigned int,CPhysicsPart**,CELLARRAY*)
    public void find_building_transit_cells(uint num_parts, ACBindings.CPhysicsPart** parts, ACBindings.CELLARRAY* cell_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CBuildingObj, uint, ACBindings.CPhysicsPart**, ACBindings.CELLARRAY*, void>)0x006B61E0)(ref this, num_parts, parts, cell_array);
    // void __thiscall CBuildingObj::CBuildingObj(CBuildingObj*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CBuildingObj, void>)0x006B6290)(ref this);
    // CPhysicsObj* __cdecl CBuildingObj::makeBuilding(int,void*,int,unsigned int)
    public static ACBindings.CPhysicsObj* makeBuilding(int a1, System.IntPtr a2, int a3, uint a4) => ((delegate* unmanaged[Cdecl]<int, System.IntPtr, int, uint, ACBindings.CPhysicsObj*>)0x006B62E0)(a1, a2, a3, a4);
    // void __thiscall CBuildingObj::~CBuildingObj(CBuildingObj*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CBuildingObj, void>)0x006B63F0)(ref this);
    // void __thiscall CBuildingObj::add_to_cell(CBuildingObj*,CSortCell*)
    public void add_to_cell(ACBindings.CSortCell* new_cell) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CBuildingObj, ACBindings.CSortCell*, void>)0x006B6490)(ref this, new_cell);
    // CPhysicsObj* __thiscall CBuildingObj::get_object(CBuildingObj*,const unsigned int)
    public ACBindings.CPhysicsObj* get_object(uint obj_iid) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CBuildingObj, uint, ACBindings.CPhysicsObj*>)0x006B64E0)(ref this, obj_iid);
}

