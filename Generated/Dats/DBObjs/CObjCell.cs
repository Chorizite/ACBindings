namespace ACBindings.Internal;

public unsafe struct CObjCell : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.SerializeUsingPackDBObj BaseClass_SerializeUsingPackDBObj; // ACBindings.Internal.SerializeUsingPackDBObj
    public ACBindings.Internal.CPartCell BaseClass_CPartCell; // ACBindings.Internal.CPartCell

    // Statics
    public static ACBindings.Internal.CObjectMaint* obj_maint = (ACBindings.Internal.CObjectMaint*)0x008456EC;
    public static ACBindings.Internal.LScape* landscape = (ACBindings.Internal.LScape*)0x008456F0;

    // Child Types
    public unsafe struct CObjCell_vtbl
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
    public ACBindings.Internal.LandDefs.WaterType water_type;
    public ACBindings.Internal.Position pos;
    public uint num_objects;
    public ACBindings.Internal.DArray___CPhysicsObj_ptr object_list;
    public uint num_lights;
    public ACBindings.Internal.DArray___LIGHTOBJ_ptr light_list;
    public uint num_shadow_objects;
    public ACBindings.Internal.DArray___CShadowObj_ptr shadow_object_list;
    public uint restriction_obj;
    public ACBindings.Internal.ClipPlaneList** clip_planes;
    public uint num_stabs;
    public uint* stab_list;
    public int seen_outside;
    public System.IntPtr voyeur_table;
    public ACBindings.Internal.CLandBlock* myLandBlock_;

    // Generated Constructor
    public CObjCell() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x0052B950
    /// CObjCell* __cdecl CObjCell::GetVisible(unsigned int)</code>
    /// </summary>
    public static ACBindings.Internal.CObjCell* GetVisible(uint cell_id) => ((delegate* unmanaged[Cdecl]<uint, ACBindings.Internal.CObjCell*>)0x0052B950)(cell_id);

    /// <summary>
    /// <code>Offset: 0x0052B980
    /// void __cdecl CObjCell::SetObjectMaintainer(CObjectMaint*)</code>
    /// </summary>
    public static void SetObjectMaintainer(ACBindings.Internal.CObjectMaint* obj_maint) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CObjectMaint*, void>)0x0052B980)(obj_maint);

    /// <summary>
    /// <code>Offset: 0x0052B9A0
    /// LandDefs::WaterType __thiscall CObjCell::get_block_water_type(CObjCell*)</code>
    /// </summary>
    public ACBindings.Internal.LandDefs.WaterType get_block_water_type() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjCell, ACBindings.Internal.LandDefs.WaterType>)0x0052B9A0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0052BB80
    /// void __thiscall CObjCell::CObjCell(CObjCell*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjCell, void>)0x0052BB80)(ref this);

    /// <summary>
    /// <code>Offset: 0x0052BC80
    /// void __thiscall CObjCell::find_transit_cells(CObjCell*,const Position*,const unsigned int,const CSphere*,CELLARRAY*,SPHEREPATH*)</code>
    /// </summary>
    public void find_transit_cells(ACBindings.Internal.Position* p, uint num_sphere, ACBindings.Internal.CSphere* sphere, ACBindings.Internal.CELLARRAY* cell_array, ACBindings.Internal.SPHEREPATH* path) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjCell, ACBindings.Internal.Position*, uint, ACBindings.Internal.CSphere*, ACBindings.Internal.CELLARRAY*, ACBindings.Internal.SPHEREPATH*, void>)0x0052BC80)(ref this, p, num_sphere, sphere, cell_array, path);

    /// <summary>
    /// <code>Offset: 0x0052BC90
    /// void __thiscall CObjCell::find_transit_cells(CObjCell*,const unsigned int,CPhysicsPart**,CELLARRAY*)</code>
    /// </summary>
    public void find_transit_cells(uint num_parts, ACBindings.Internal.CPhysicsPart** parts, ACBindings.Internal.CELLARRAY* cell_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjCell, uint, ACBindings.Internal.CPhysicsPart**, ACBindings.Internal.CELLARRAY*, void>)0x0052BC90)(ref this, num_parts, parts, cell_array);

    /// <summary>
    /// <code>Offset: 0x0052BCD0
    /// void __thiscall CObjCell::~CObjCell(CObjCell*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjCell, void>)0x0052BCD0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0052BD90
    /// CObjCell* __cdecl CObjCell::Get(unsigned int)</code>
    /// </summary>
    public static ACBindings.Internal.CObjCell* Get(uint cell_id) => ((delegate* unmanaged[Cdecl]<uint, ACBindings.Internal.CObjCell*>)0x0052BD90)(cell_id);

    /// <summary>
    /// <code>Offset: 0x0052BDE0
    /// void __thiscall CObjCell::add_light(CObjCell*,const LIGHTOBJ*)</code>
    /// </summary>
    public void add_light(ACBindings.Internal.LIGHTOBJ* light) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjCell, ACBindings.Internal.LIGHTOBJ*, void>)0x0052BDE0)(ref this, light);

    /// <summary>
    /// <code>Offset: 0x0052BE20
    /// void __thiscall CObjCell::remove_light(CObjCell*,const LIGHTOBJ*)</code>
    /// </summary>
    public void remove_light(ACBindings.Internal.LIGHTOBJ* light) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjCell, ACBindings.Internal.LIGHTOBJ*, void>)0x0052BE20)(ref this, light);

    /// <summary>
    /// <code>Offset: 0x0052BE90
    /// void __thiscall CObjCell::add_shadow_object(CObjCell*,CShadowObj*,unsigned int)</code>
    /// </summary>
    public void add_shadow_object(ACBindings.Internal.CShadowObj* object_, uint num_shadow_cells) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjCell, ACBindings.Internal.CShadowObj*, uint, void>)0x0052BE90)(ref this, object_, num_shadow_cells);

    /// <summary>
    /// <code>Offset: 0x0052BEE0
    /// void __thiscall CObjCell::remove_shadow_object(CObjCell*,CShadowObj*)</code>
    /// </summary>
    public void remove_shadow_object(ACBindings.Internal.CShadowObj* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjCell, ACBindings.Internal.CShadowObj*, void>)0x0052BEE0)(ref this, object_);

    /// <summary>
    /// <code>Offset: 0x0052BF60
    /// void __thiscall CObjCell::add_static_to_global_lights(CObjCell*)</code>
    /// </summary>
    public void add_static_to_global_lights() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjCell, void>)0x0052BF60)(ref this);

    /// <summary>
    /// <code>Offset: 0x0052BFA0
    /// void __thiscall CObjCell::add_dynamic_to_global_lights(CObjCell*)</code>
    /// </summary>
    public void add_dynamic_to_global_lights() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjCell, void>)0x0052BFA0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0052BFF0
    /// float __thiscall CObjCell::GetViewerDistance(CObjCell*,AC1Legacy::Vector3*)</code>
    /// </summary>
    public float GetViewerDistance(ACBindings.Internal.AC1Legacy.Vector3* diff_vec) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjCell, ACBindings.Internal.AC1Legacy.Vector3*, float>)0x0052BFF0)(ref this, diff_vec);

    /// <summary>
    /// <code>Offset: 0x0052C030
    /// void __thiscall CObjCell::init_objects(CObjCell*)</code>
    /// </summary>
    public void init_objects() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjCell, void>)0x0052C030)(ref this);

    /// <summary>
    /// <code>Offset: 0x0052C0A0
    /// void __thiscall CObjCell::release_objects(CObjCell*)</code>
    /// </summary>
    public void release_objects() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjCell, void>)0x0052C0A0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0052C0F0
    /// void __cdecl CObjCell::find_cell_list(const Position*,const unsigned int,const CSphere*,CELLARRAY*,CObjCell**,SPHEREPATH*)</code>
    /// </summary>
    public static void find_cell_list(ACBindings.Internal.Position* p, uint num_sphere, ACBindings.Internal.CSphere* sphere, ACBindings.Internal.CELLARRAY* cell_array, ACBindings.Internal.CObjCell** curr_cell, ACBindings.Internal.SPHEREPATH* path) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.Position*, uint, ACBindings.Internal.CSphere*, ACBindings.Internal.CELLARRAY*, ACBindings.Internal.CObjCell**, ACBindings.Internal.SPHEREPATH*, void>)0x0052C0F0)(p, num_sphere, sphere, cell_array, curr_cell, path);

    /// <summary>
    /// <code>Offset: 0x0052C2E0
    /// TransitionState __thiscall CObjCell::check_entry_restrictions(CObjCell*,CTransition*)</code>
    /// </summary>
    public ACBindings.Internal.TransitionState check_entry_restrictions(ACBindings.Internal.CTransition* transition) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjCell, ACBindings.Internal.CTransition*, ACBindings.Internal.TransitionState>)0x0052C2E0)(ref this, transition);

    /// <summary>
    /// <code>Offset: 0x0052C360
    /// TransitionState __thiscall CObjCell::find_obj_collisions(CObjCell*,CTransition*)</code>
    /// </summary>
    public ACBindings.Internal.TransitionState find_obj_collisions(ACBindings.Internal.CTransition* transition) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjCell, ACBindings.Internal.CTransition*, ACBindings.Internal.TransitionState>)0x0052C360)(ref this, transition);

    /// <summary>
    /// <code>Offset: 0x0052C3C0
    /// int __thiscall CObjCell::check_collisions(CObjCell*,const CPhysicsObj*)</code>
    /// </summary>
    public int check_collisions(ACBindings.Internal.CPhysicsObj* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjCell, ACBindings.Internal.CPhysicsObj*, int>)0x0052C3C0)(ref this, object_);

    /// <summary>
    /// <code>Offset: 0x0052C420
    /// void __thiscall CObjCell::check_attack(CObjCell*,const unsigned int,const Position*,const float,const AttackCone*,AttackInfo*)</code>
    /// </summary>
    public void check_attack(uint attacker_id, ACBindings.Internal.Position* attacker_pos, float attacker_scale, ACBindings.Internal.AttackCone* attack_cone, ACBindings.Internal.AttackInfo* attack_info) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjCell, uint, ACBindings.Internal.Position*, float, ACBindings.Internal.AttackCone*, ACBindings.Internal.AttackInfo*, void>)0x0052C420)(ref this, attacker_id, attacker_pos, attacker_scale, attack_cone, attack_info);

    /// <summary>
    /// <code>Offset: 0x0052C4B0
    /// float __thiscall CObjCell::get_water_depth(CObjCell*,const AC1Legacy::Vector3*)</code>
    /// </summary>
    public float get_water_depth(ACBindings.Internal.AC1Legacy.Vector3* point) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjCell, ACBindings.Internal.AC1Legacy.Vector3*, float>)0x0052C4B0)(ref this, point);

    /// <summary>
    /// <code>Offset: 0x0052C500
    /// CPhysicsObj* __thiscall CObjCell::get_object(CObjCell*,const unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.CPhysicsObj* get_object(uint obj_iid) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjCell, uint, ACBindings.Internal.CPhysicsObj*>)0x0052C500)(ref this, obj_iid);

    /// <summary>
    /// <code>Offset: 0x0052C560
    /// void __thiscall CObjCell::add_lights(CObjCell*)</code>
    /// </summary>
    public void add_lights() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjCell, void>)0x0052C560)(ref this);

    /// <summary>
    /// <code>Offset: 0x0052C570
    /// void __cdecl CObjCell::find_cell_list(CELLARRAY*,CObjCell**,SPHEREPATH*)</code>
    /// </summary>
    public static void find_cell_list(ACBindings.Internal.CELLARRAY* cell_array, ACBindings.Internal.CObjCell** check_cell, ACBindings.Internal.SPHEREPATH* path) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CELLARRAY*, ACBindings.Internal.CObjCell**, ACBindings.Internal.SPHEREPATH*, void>)0x0052C570)(cell_array, check_cell, path);

    /// <summary>
    /// <code>Offset: 0x0052C5A0
    /// void __cdecl CObjCell::find_cell_list(const Position*,const CSphere*,CELLARRAY*,SPHEREPATH*)</code>
    /// </summary>
    public static void find_cell_list(ACBindings.Internal.Position* p, ACBindings.Internal.CSphere* sphere, ACBindings.Internal.CELLARRAY* cell_array, ACBindings.Internal.SPHEREPATH* path) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.Position*, ACBindings.Internal.CSphere*, ACBindings.Internal.CELLARRAY*, ACBindings.Internal.SPHEREPATH*, void>)0x0052C5A0)(p, sphere, cell_array, path);

    /// <summary>
    /// <code>Offset: 0x0052C600
    /// void __cdecl CObjCell::find_cell_list(const Position*,const unsigned int,const CCylSphere*,CELLARRAY*,SPHEREPATH*)</code>
    /// </summary>
    public static void find_cell_list(ACBindings.Internal.Position* p, uint num_cylsphere, ACBindings.Internal.CCylSphere* cylsphere, ACBindings.Internal.CELLARRAY* cell_array, ACBindings.Internal.SPHEREPATH* path) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.Position*, uint, ACBindings.Internal.CCylSphere*, ACBindings.Internal.CELLARRAY*, ACBindings.Internal.SPHEREPATH*, void>)0x0052C600)(p, num_cylsphere, cylsphere, cell_array, path);

    /// <summary>
    /// <code>Offset: 0x0052C770
    /// int __thiscall CObjCell::add_voyeur(CObjCell*,unsigned int,const DetectionCylsphere*)</code>
    /// </summary>
    public int add_voyeur(uint voyeur_id, ACBindings.Internal.DetectionCylsphere* detcyl) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjCell, uint, ACBindings.Internal.DetectionCylsphere*, int>)0x0052C770)(ref this, voyeur_id, detcyl);

    /// <summary>
    /// <code>Offset: 0x0052C8A0
    /// int __thiscall CObjCell::remove_voyeur(CObjCell*,unsigned int,const DetectionCylsphere*)</code>
    /// </summary>
    public int remove_voyeur(uint voyeur_id, ACBindings.Internal.DetectionCylsphere* detcyl) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjCell, uint, ACBindings.Internal.DetectionCylsphere*, int>)0x0052C8A0)(ref this, voyeur_id, detcyl);

    /// <summary>
    /// <code>Offset: 0x0052C990
    /// void __thiscall CObjCell::update_all_voyeur(CObjCell*,CPhysicsObj*,DetectionType)</code>
    /// </summary>
    public void update_all_voyeur(ACBindings.Internal.CPhysicsObj* object_, ACBindings.Internal.DetectionType type) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjCell, ACBindings.Internal.CPhysicsObj*, ACBindings.Internal.DetectionType, void>)0x0052C990)(ref this, object_, type);

    /// <summary>
    /// <code>Offset: 0x0052CA40
    /// void __thiscall CObjCell::hide_object(CObjCell*,CPhysicsObj*)</code>
    /// </summary>
    public void hide_object(ACBindings.Internal.CPhysicsObj* obj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjCell, ACBindings.Internal.CPhysicsObj*, void>)0x0052CA40)(ref this, obj);

    /// <summary>
    /// <code>Offset: 0x0052CA50
    /// void __thiscall CObjCell::unhide_object(CObjCell*,CPhysicsObj*)</code>
    /// </summary>
    public void unhide_object(ACBindings.Internal.CPhysicsObj* obj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjCell, ACBindings.Internal.CPhysicsObj*, void>)0x0052CA50)(ref this, obj);

    /// <summary>
    /// <code>Offset: 0x0052CB70
    /// void __thiscall CObjCell::add_object(CObjCell*,CPhysicsObj*)</code>
    /// </summary>
    public void add_object(ACBindings.Internal.CPhysicsObj* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjCell, ACBindings.Internal.CPhysicsObj*, void>)0x0052CB70)(ref this, object_);

    /// <summary>
    /// <code>Offset: 0x0052CC50
    /// void __thiscall CObjCell::remove_object(CObjCell*,CPhysicsObj*)</code>
    /// </summary>
    public void remove_object(ACBindings.Internal.CPhysicsObj* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjCell, ACBindings.Internal.CPhysicsObj*, void>)0x0052CC50)(ref this, object_);
}

