namespace ACBindings;

// CObjCell
public unsafe struct CObjCell : System.IDisposable
{
    // Base Classes
    public ACBindings.SerializeUsingPackDBObj BaseClass_SerializeUsingPackDBObj; // ACBindings.SerializeUsingPackDBObj
    public ACBindings.CPartCell BaseClass_CPartCell; // ACBindings.CPartCell

    // Statics
    public static ACBindings.CObjectMaint* obj_maint = (ACBindings.CObjectMaint*)0x008456EC;
    public static ACBindings.LScape* landscape = (ACBindings.LScape*)0x008456F0;

    // Child Types
    // CObjCell_vtbl
    public unsafe struct CObjCell_vtbl
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
    public ACBindings.LandDefs.WaterType water_type;
    public ACBindings.Position pos;
    public uint num_objects;
    public ACBindings.DArray__CPhysicsObj_ptr object_list;
    public uint num_lights;
    public ACBindings.DArray__LIGHTOBJ_ptr light_list;
    public uint num_shadow_objects;
    public ACBindings.DArray__CShadowObj_ptr shadow_object_list;
    public uint restriction_obj;
    public ACBindings.ClipPlaneList** clip_planes;
    public uint num_stabs;
    public uint* stab_list;
    public int seen_outside;
    public System.IntPtr voyeur_table;
    public ACBindings.CLandBlock* myLandBlock_;

    // Generated Constructor
    public CObjCell() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // CObjCell* __cdecl CObjCell::GetVisible(unsigned int)
    public static ACBindings.CObjCell* GetVisible(uint cell_id) => ((delegate* unmanaged[Cdecl]<uint, ACBindings.CObjCell*>)0x0052B950)(cell_id);
    // void __cdecl CObjCell::SetObjectMaintainer(CObjectMaint*)
    public static void SetObjectMaintainer(ACBindings.CObjectMaint* obj_maint) => ((delegate* unmanaged[Cdecl]<ACBindings.CObjectMaint*, void>)0x0052B980)(obj_maint);
    // LandDefs::WaterType __thiscall CObjCell::get_block_water_type(CObjCell*)
    public ACBindings.LandDefs.WaterType get_block_water_type() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CObjCell, ACBindings.LandDefs.WaterType>)0x0052B9A0)(ref this);
    // void __thiscall CObjCell::CObjCell(CObjCell*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CObjCell, void>)0x0052BB80)(ref this);
    // void __thiscall CObjCell::find_transit_cells(CObjCell*,const Position*,const unsigned int,const CSphere*,CELLARRAY*,SPHEREPATH*)
    public void find_transit_cells(ACBindings.Position* p, uint num_sphere, ACBindings.CSphere* sphere, ACBindings.CELLARRAY* cell_array, ACBindings.SPHEREPATH* path) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CObjCell, ACBindings.Position*, uint, ACBindings.CSphere*, ACBindings.CELLARRAY*, ACBindings.SPHEREPATH*, void>)0x0052BC80)(ref this, p, num_sphere, sphere, cell_array, path);
    // void __thiscall CObjCell::find_transit_cells(CObjCell*,const unsigned int,CPhysicsPart**,CELLARRAY*)
    public void find_transit_cells(uint num_parts, ACBindings.CPhysicsPart** parts, ACBindings.CELLARRAY* cell_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CObjCell, uint, ACBindings.CPhysicsPart**, ACBindings.CELLARRAY*, void>)0x0052BC90)(ref this, num_parts, parts, cell_array);
    // void __thiscall CObjCell::~CObjCell(CObjCell*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CObjCell, void>)0x0052BCD0)(ref this);
    // CObjCell* __cdecl CObjCell::Get(unsigned int)
    public static ACBindings.CObjCell* Get(uint cell_id) => ((delegate* unmanaged[Cdecl]<uint, ACBindings.CObjCell*>)0x0052BD90)(cell_id);
    // void __thiscall CObjCell::add_light(CObjCell*,const LIGHTOBJ*)
    public void add_light(ACBindings.LIGHTOBJ* light) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CObjCell, ACBindings.LIGHTOBJ*, void>)0x0052BDE0)(ref this, light);
    // void __thiscall CObjCell::remove_light(CObjCell*,const LIGHTOBJ*)
    public void remove_light(ACBindings.LIGHTOBJ* light) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CObjCell, ACBindings.LIGHTOBJ*, void>)0x0052BE20)(ref this, light);
    // void __thiscall CObjCell::add_shadow_object(CObjCell*,CShadowObj*,unsigned int)
    public void add_shadow_object(ACBindings.CShadowObj* object_, uint num_shadow_cells) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CObjCell, ACBindings.CShadowObj*, uint, void>)0x0052BE90)(ref this, object_, num_shadow_cells);
    // void __thiscall CObjCell::remove_shadow_object(CObjCell*,CShadowObj*)
    public void remove_shadow_object(ACBindings.CShadowObj* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CObjCell, ACBindings.CShadowObj*, void>)0x0052BEE0)(ref this, object_);
    // void __thiscall CObjCell::add_static_to_global_lights(CObjCell*)
    public void add_static_to_global_lights() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CObjCell, void>)0x0052BF60)(ref this);
    // void __thiscall CObjCell::add_dynamic_to_global_lights(CObjCell*)
    public void add_dynamic_to_global_lights() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CObjCell, void>)0x0052BFA0)(ref this);
    // float __thiscall CObjCell::GetViewerDistance(CObjCell*,AC1Legacy::Vector3*)
    public float GetViewerDistance(ACBindings.AC1Legacy.Vector3* diff_vec) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CObjCell, ACBindings.AC1Legacy.Vector3*, float>)0x0052BFF0)(ref this, diff_vec);
    // void __thiscall CObjCell::init_objects(CObjCell*)
    public void init_objects() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CObjCell, void>)0x0052C030)(ref this);
    // void __thiscall CObjCell::release_objects(CObjCell*)
    public void release_objects() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CObjCell, void>)0x0052C0A0)(ref this);
    // void __cdecl CObjCell::find_cell_list(const Position*,const unsigned int,const CSphere*,CELLARRAY*,CObjCell**,SPHEREPATH*)
    public static void find_cell_list(ACBindings.Position* p, uint num_sphere, ACBindings.CSphere* sphere, ACBindings.CELLARRAY* cell_array, ACBindings.CObjCell** curr_cell, ACBindings.SPHEREPATH* path) => ((delegate* unmanaged[Cdecl]<ACBindings.Position*, uint, ACBindings.CSphere*, ACBindings.CELLARRAY*, ACBindings.CObjCell**, ACBindings.SPHEREPATH*, void>)0x0052C0F0)(p, num_sphere, sphere, cell_array, curr_cell, path);
    // TransitionState __thiscall CObjCell::check_entry_restrictions(CObjCell*,CTransition*)
    public ACBindings.TransitionState check_entry_restrictions(ACBindings.CTransition* transition) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CObjCell, ACBindings.CTransition*, ACBindings.TransitionState>)0x0052C2E0)(ref this, transition);
    // TransitionState __thiscall CObjCell::find_obj_collisions(CObjCell*,CTransition*)
    public ACBindings.TransitionState find_obj_collisions(ACBindings.CTransition* transition) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CObjCell, ACBindings.CTransition*, ACBindings.TransitionState>)0x0052C360)(ref this, transition);
    // int __thiscall CObjCell::check_collisions(CObjCell*,const CPhysicsObj*)
    public int check_collisions(ACBindings.CPhysicsObj* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CObjCell, ACBindings.CPhysicsObj*, int>)0x0052C3C0)(ref this, object_);
    // void __thiscall CObjCell::check_attack(CObjCell*,const unsigned int,const Position*,const float,const AttackCone*,AttackInfo*)
    public void check_attack(uint attacker_id, ACBindings.Position* attacker_pos, float attacker_scale, ACBindings.AttackCone* attack_cone, ACBindings.AttackInfo* attack_info) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CObjCell, uint, ACBindings.Position*, float, ACBindings.AttackCone*, ACBindings.AttackInfo*, void>)0x0052C420)(ref this, attacker_id, attacker_pos, attacker_scale, attack_cone, attack_info);
    // float __thiscall CObjCell::get_water_depth(CObjCell*,const AC1Legacy::Vector3*)
    public float get_water_depth(ACBindings.AC1Legacy.Vector3* point) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CObjCell, ACBindings.AC1Legacy.Vector3*, float>)0x0052C4B0)(ref this, point);
    // CPhysicsObj* __thiscall CObjCell::get_object(CObjCell*,const unsigned int)
    public ACBindings.CPhysicsObj* get_object(uint obj_iid) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CObjCell, uint, ACBindings.CPhysicsObj*>)0x0052C500)(ref this, obj_iid);
    // void __thiscall CObjCell::add_lights(CObjCell*)
    public void add_lights() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CObjCell, void>)0x0052C560)(ref this);
    // void __cdecl CObjCell::find_cell_list(CELLARRAY*,CObjCell**,SPHEREPATH*)
    public static void find_cell_list(ACBindings.CELLARRAY* cell_array, ACBindings.CObjCell** check_cell, ACBindings.SPHEREPATH* path) => ((delegate* unmanaged[Cdecl]<ACBindings.CELLARRAY*, ACBindings.CObjCell**, ACBindings.SPHEREPATH*, void>)0x0052C570)(cell_array, check_cell, path);
    // void __cdecl CObjCell::find_cell_list(const Position*,const CSphere*,CELLARRAY*,SPHEREPATH*)
    public static void find_cell_list(ACBindings.Position* p, ACBindings.CSphere* sphere, ACBindings.CELLARRAY* cell_array, ACBindings.SPHEREPATH* path) => ((delegate* unmanaged[Cdecl]<ACBindings.Position*, ACBindings.CSphere*, ACBindings.CELLARRAY*, ACBindings.SPHEREPATH*, void>)0x0052C5A0)(p, sphere, cell_array, path);
    // void __cdecl CObjCell::find_cell_list(const Position*,const unsigned int,const CCylSphere*,CELLARRAY*,SPHEREPATH*)
    public static void find_cell_list(ACBindings.Position* p, uint num_cylsphere, ACBindings.CCylSphere* cylsphere, ACBindings.CELLARRAY* cell_array, ACBindings.SPHEREPATH* path) => ((delegate* unmanaged[Cdecl]<ACBindings.Position*, uint, ACBindings.CCylSphere*, ACBindings.CELLARRAY*, ACBindings.SPHEREPATH*, void>)0x0052C600)(p, num_cylsphere, cylsphere, cell_array, path);
    // int __thiscall CObjCell::add_voyeur(CObjCell*,unsigned int,const DetectionCylsphere*)
    public int add_voyeur(uint voyeur_id, ACBindings.DetectionCylsphere* detcyl) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CObjCell, uint, ACBindings.DetectionCylsphere*, int>)0x0052C770)(ref this, voyeur_id, detcyl);
    // int __thiscall CObjCell::remove_voyeur(CObjCell*,unsigned int,const DetectionCylsphere*)
    public int remove_voyeur(uint voyeur_id, ACBindings.DetectionCylsphere* detcyl) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CObjCell, uint, ACBindings.DetectionCylsphere*, int>)0x0052C8A0)(ref this, voyeur_id, detcyl);
    // void __thiscall CObjCell::update_all_voyeur(CObjCell*,CPhysicsObj*,DetectionType)
    public void update_all_voyeur(ACBindings.CPhysicsObj* object_, ACBindings.DetectionType type) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CObjCell, ACBindings.CPhysicsObj*, ACBindings.DetectionType, void>)0x0052C990)(ref this, object_, type);
    // void __thiscall CObjCell::hide_object(CObjCell*,CPhysicsObj*)
    public void hide_object(ACBindings.CPhysicsObj* obj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CObjCell, ACBindings.CPhysicsObj*, void>)0x0052CA40)(ref this, obj);
    // void __thiscall CObjCell::unhide_object(CObjCell*,CPhysicsObj*)
    public void unhide_object(ACBindings.CPhysicsObj* obj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CObjCell, ACBindings.CPhysicsObj*, void>)0x0052CA50)(ref this, obj);
    // void __thiscall CObjCell::add_object(CObjCell*,CPhysicsObj*)
    public void add_object(ACBindings.CPhysicsObj* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CObjCell, ACBindings.CPhysicsObj*, void>)0x0052CB70)(ref this, object_);
    // void __thiscall CObjCell::remove_object(CObjCell*,CPhysicsObj*)
    public void remove_object(ACBindings.CPhysicsObj* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CObjCell, ACBindings.CPhysicsObj*, void>)0x0052CC50)(ref this, object_);
}

