namespace ACBindings;

// CSortCell
public unsafe struct CSortCell
{
    // Base Classes
    public ACBindings.CObjCell BaseClass_CObjCell; // ACBindings.CObjCell

    // Child Types
    // CSortCell_vtbl
    public unsafe struct CSortCell_vtbl
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
    public ACBindings.CBuildingObj* building;

    // Generated Constructor
    public CSortCell() {
        _ConstructorInternal();
    }

    // Methods
    // void __thiscall CSortCell::CSortCell(CSortCell*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSortCell, void>)0x00534CF0)(ref this);
    // int __thiscall CSortCell::has_building(CSortCell*)
    public int has_building() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSortCell, int>)0x00534D40)(ref this);
    // void __thiscall CSortCell::add_building(CSortCell*,CBuildingObj*)
    public void add_building(ACBindings.CBuildingObj* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSortCell, ACBindings.CBuildingObj*, void>)0x00534D70)(ref this, object_);
    // void __thiscall CSortCell::remove_building(CSortCell*,CBuildingObj*)
    public void remove_building(ACBindings.CBuildingObj* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSortCell, ACBindings.CBuildingObj*, void>)0x00534D90)(ref this, object_);
    // void __thiscall CSortCell::find_transit_cells(CSortCell*,const Position*,const unsigned int,const CSphere*,CELLARRAY*,SPHEREPATH*)
    public void find_transit_cells(ACBindings.Position* p, uint num_sphere, ACBindings.CSphere* sphere, ACBindings.CELLARRAY* cell_array, ACBindings.SPHEREPATH* path) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSortCell, ACBindings.Position*, uint, ACBindings.CSphere*, ACBindings.CELLARRAY*, ACBindings.SPHEREPATH*, void>)0x00534DA0)(ref this, p, num_sphere, sphere, cell_array, path);
    // void __thiscall CSortCell::find_transit_cells(CSortCell*,const unsigned int,CPhysicsPart**,CELLARRAY*)
    public void find_transit_cells(uint num_parts, ACBindings.CPhysicsPart** parts, ACBindings.CELLARRAY* cell_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSortCell, uint, ACBindings.CPhysicsPart**, ACBindings.CELLARRAY*, void>)0x00534DC0)(ref this, num_parts, parts, cell_array);
    // TransitionState __thiscall CSortCell::find_collisions(CSortCell*,CTransition*)
    public ACBindings.TransitionState find_collisions(ACBindings.CTransition* transition) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSortCell, ACBindings.CTransition*, ACBindings.TransitionState>)0x00534DE0)(ref this, transition);
    // CPhysicsObj* __thiscall CSortCell::get_object(CSortCell*,const unsigned int)
    public ACBindings.CPhysicsObj* get_object(uint obj_iid) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSortCell, uint, ACBindings.CPhysicsObj*>)0x00534E00)(ref this, obj_iid);
}

