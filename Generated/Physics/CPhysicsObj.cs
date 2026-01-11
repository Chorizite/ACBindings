namespace ACBindings.Internal;

public unsafe struct CPhysicsObj : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.LongHashData BaseClass_LongHashData; // ACBindings.Internal.LongHashData

    // Statics
    public static ACBindings.Internal.CObjectMaint* obj_maint = (ACBindings.Internal.CObjectMaint*)0x00844D64;
    public static ACBindings.Internal.CPhysicsObj* player_object = (ACBindings.Internal.CPhysicsObj*)0x00844D68;

    // Child Types
    public unsafe struct CPhysicsObj_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CPhysicsObj*, void> CPhysicsObj_dtor_0; // function pointer

        // Methods
    }
    public unsafe struct CollisionRecord
    {
        // Members
        public double touched_time;
        public int ethereal;

        // Methods
    }

    // Members
    public System.IntPtr netblob_list;
    public ACBindings.Internal.CPartArray* part_array;
    public ACBindings.Internal.AC1Legacy.Vector3 player_vector;
    public float player_distance;
    public float CYpt;
    public ACBindings.Internal.CSoundTable* sound_table;
    public byte m_bExaminationObject;
    public ACBindings.Internal.ScriptManager* script_manager;
    public ACBindings.Internal.PhysicsScriptTable* physics_script_table;
    public ACBindings.Internal.PScriptType default_script;
    public float default_script_intensity;
    public ACBindings.Internal.CPhysicsObj* parent;
    public ACBindings.Internal.CHILDLIST* children;
    public ACBindings.Internal.Position m_position;
    public ACBindings.Internal.CObjCell* cell;
    public uint num_shadow_objects;
    public ACBindings.Internal.DArray___CShadowObj shadow_objects;
    public uint state;
    public uint transient_state;
    public float elasticity;
    public float translucency;
    public float translucencyOriginal;
    public float friction;
    public float massinv;
    public ACBindings.Internal.MovementManager* movement_manager;
    public ACBindings.Internal.PositionManager* position_manager;
    public int last_move_was_autonomous;
    public int jumped_this_frame;
    public double update_time;
    public ACBindings.Internal.AC1Legacy.Vector3 m_velocityVector;
    public ACBindings.Internal.AC1Legacy.Vector3 m_accelerationVector;
    public ACBindings.Internal.AC1Legacy.Vector3 m_omegaVector;
    public ACBindings.Internal.PhysicsObjHook* hooks;
    public ACBindings.Internal.AC1Legacy.SmartArray___CAnimHook_ptr anim_hooks;
    public float m_scale;
    public float attack_radius;
    public ACBindings.Internal.DetectionManager* detection_manager;
    public ACBindings.Internal.AttackManager* attack_manager;
    public ACBindings.Internal.TargetManager* target_manager;
    public ACBindings.Internal.ParticleManager* particle_manager;
    public ACBindings.Internal.CWeenieObject* weenie_obj;
    public ACBindings.Internal.Plane contact_plane;
    public uint contact_plane_cell_id;
    public ACBindings.Internal.AC1Legacy.Vector3 sliding_normal;
    public ACBindings.Internal.AC1Legacy.Vector3 cached_velocity;
    public System.IntPtr collision_table;
    public int colliding_with_environment;
    public fixed ushort update_times[9];

    // Generated Constructor
    public CPhysicsObj() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x00451B10
    /// int __cdecl CPhysicsObj::is_newer(unsigned __int16,unsigned __int16)</code>
    /// </summary>
    public static int is_newer(ushort timestamp, ushort new_time) => ((delegate* unmanaged[Cdecl]<ushort, ushort, int>)0x00451B10)(timestamp, new_time);

    /// <summary>
    /// <code>Offset: 0x00451B50
    /// int __thiscall CPhysicsObj::newer_event(CPhysicsObj*,PhysicsTimeStamp,unsigned __int16)</code>
    /// </summary>
    public int newer_event(ACBindings.Internal.PhysicsTimeStamp stamp, ushort new_time) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.PhysicsTimeStamp, ushort, int>)0x00451B50)(ref this, stamp, new_time);

    /// <summary>
    /// <code>Offset: 0x00452950
    /// const Frame* __thiscall CPhysicsObj::get_frame(CPhysicsObj*)</code>
    /// </summary>
    public ACBindings.Internal.Frame* get_frame() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.Frame*>)0x00452950)(ref this);

    /// <summary>
    /// <code>Offset: 0x0050F400
    /// BOOL __thiscall CPhysicsObj::makeAnimObject(CPhysicsObj*,int,int)</code>
    /// </summary>
    public byte makeAnimObject(int a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, int, int, byte>)0x0050F400)(ref this, a2, a3);

    /// <summary>
    /// <code>Offset: 0x0050F430
    /// unsigned int* __thiscall CPhysicsObj::GetSetupID(_DWORD*,unsigned int*)</code>
    /// </summary>
    public uint* GetSetupID(uint* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, uint*, uint*>)0x0050F430)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x0050F460
    /// unsigned int* __thiscall CPhysicsObj::GetDataID(_DWORD*,unsigned int*)</code>
    /// </summary>
    public uint* GetDataID(uint* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, uint*, uint*>)0x0050F460)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x0050F490
    /// float __thiscall CPhysicsObj::GetRadius(CPhysicsObj*)</code>
    /// </summary>
    public float GetRadius() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, float>)0x0050F490)(ref this);

    /// <summary>
    /// <code>Offset: 0x0050F4B0
    /// float __thiscall CPhysicsObj::GetHeight(CPhysicsObj*)</code>
    /// </summary>
    public float GetHeight() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, float>)0x0050F4B0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0050F4D0
    /// float __thiscall CPhysicsObj::GetStepUpHeight(CPhysicsObj*)</code>
    /// </summary>
    public float GetStepUpHeight() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, float>)0x0050F4D0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0050F4F0
    /// float __thiscall CPhysicsObj::GetStepDownHeight(CPhysicsObj*)</code>
    /// </summary>
    public float GetStepDownHeight() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, float>)0x0050F4F0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0050F510
    /// int __thiscall CPhysicsObj::GetSelectionSphere(CPhysicsObj*,CSphere*)</code>
    /// </summary>
    public int GetSelectionSphere(ACBindings.Internal.CSphere* selection_sphere) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.CSphere*, int>)0x0050F510)(ref this, selection_sphere);

    /// <summary>
    /// <code>Offset: 0x0050F530
    /// void __thiscall CPhysicsObj::InitializeMotionTables(CPhysicsObj*)</code>
    /// </summary>
    public void InitializeMotionTables() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, void>)0x0050F530)(ref this);

    /// <summary>
    /// <code>Offset: 0x0050F540
    /// unsigned int __thiscall CPhysicsObj::DoInterpretedMotion(CPhysicsObj*,unsigned int,const MovementParameters*)</code>
    /// </summary>
    public uint DoInterpretedMotion(uint motion, ACBindings.Internal.MovementParameters* params_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, uint, ACBindings.Internal.MovementParameters*, uint>)0x0050F540)(ref this, motion, params_);

    /// <summary>
    /// <code>Offset: 0x0050F560
    /// unsigned int __thiscall CPhysicsObj::StopInterpretedMotion(CPhysicsObj*,unsigned int,const MovementParameters*)</code>
    /// </summary>
    public uint StopInterpretedMotion(uint motion, ACBindings.Internal.MovementParameters* params_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, uint, ACBindings.Internal.MovementParameters*, uint>)0x0050F560)(ref this, motion, params_);

    /// <summary>
    /// <code>Offset: 0x0050F580
    /// int __thiscall CPhysicsObj::motions_pending(CPhysicsObj*)</code>
    /// </summary>
    public int motions_pending() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, int>)0x0050F580)(ref this);

    /// <summary>
    /// <code>Offset: 0x0050F5A0
    /// void __thiscall CPhysicsObj::StopCompletely_Internal(CPhysicsObj*)</code>
    /// </summary>
    public void StopCompletely_Internal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, void>)0x0050F5A0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0050F5B0
    /// void __thiscall CPhysicsObj::unstick_from_object(CPhysicsObj*)</code>
    /// </summary>
    public void unstick_from_object() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, void>)0x0050F5B0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0050F5C0
    /// unsigned int __thiscall CPhysicsObj::get_sticky_object_id(CPhysicsObj*)</code>
    /// </summary>
    public uint get_sticky_object_id() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, uint>)0x0050F5C0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0050F5E0
    /// int __thiscall CPhysicsObj::IsMovingTo(CPhysicsObj*)</code>
    /// </summary>
    public int IsMovingTo() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, int>)0x0050F5E0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0050F600
    /// int __thiscall CPhysicsObj::movement_is_autonomous(CPhysicsObj*)</code>
    /// </summary>
    public int movement_is_autonomous() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, int>)0x0050F600)(ref this);

    /// <summary>
    /// <code>Offset: 0x0050F610
    /// void __thiscall CPhysicsObj::StopInterpolating(CPhysicsObj*)</code>
    /// </summary>
    public void StopInterpolating() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, void>)0x0050F610)(ref this);

    /// <summary>
    /// <code>Offset: 0x0050F620
    /// int __thiscall CPhysicsObj::IsInterpolating(CPhysicsObj*)</code>
    /// </summary>
    public int IsInterpolating() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, int>)0x0050F620)(ref this);

    /// <summary>
    /// <code>Offset: 0x0050F640
    /// float __thiscall CPhysicsObj::GetAutonomyBlipDistance(CPhysicsObj*)</code>
    /// </summary>
    public float GetAutonomyBlipDistance() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, float>)0x0050F640)(ref this);

    /// <summary>
    /// <code>Offset: 0x0050F690
    /// float __thiscall CPhysicsObj::GetStartConstraintDistance(CPhysicsObj*)</code>
    /// </summary>
    public float GetStartConstraintDistance() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, float>)0x0050F690)(ref this);

    /// <summary>
    /// <code>Offset: 0x0050F6E0
    /// float __thiscall CPhysicsObj::GetMaxConstraintDistance(CPhysicsObj*)</code>
    /// </summary>
    public float GetMaxConstraintDistance() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, float>)0x0050F6E0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0050F730
    /// int __thiscall CPhysicsObj::IsFullyConstrained(CPhysicsObj*)</code>
    /// </summary>
    public int IsFullyConstrained() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, int>)0x0050F730)(ref this);

    /// <summary>
    /// <code>Offset: 0x0050F750
    /// unsigned int __thiscall CPhysicsObj::check_attack(CPhysicsObj*,const Position*,const float,const AttackCone*,float)</code>
    /// </summary>
    public uint check_attack(ACBindings.Internal.Position* attacker_pos, float attacker_scale, ACBindings.Internal.AttackCone* attack_cone, float attacker_attack_radius) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.Position*, float, ACBindings.Internal.AttackCone*, float, uint>)0x0050F750)(ref this, attacker_pos, attacker_scale, attack_cone, attacker_attack_radius);

    /// <summary>
    /// <code>Offset: 0x0050F800
    /// void __thiscall CPhysicsObj::set_target(CPhysicsObj*,unsigned int,unsigned int,float,long double)</code>
    /// </summary>
    public void set_target(uint context_id, uint object_id, float radius, double quantum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, uint, uint, float, double, void>)0x0050F800)(ref this, context_id, object_id, radius, quantum);

    /// <summary>
    /// <code>Offset: 0x0050F860
    /// void __thiscall CPhysicsObj::clear_target(CPhysicsObj*)</code>
    /// </summary>
    public void clear_target() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, void>)0x0050F860)(ref this);

    /// <summary>
    /// <code>Offset: 0x0050F870
    /// void __thiscall CPhysicsObj::set_target_quantum(CPhysicsObj*,long double)</code>
    /// </summary>
    public void set_target_quantum(double new_quantum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, double, void>)0x0050F870)(ref this, new_quantum);

    /// <summary>
    /// <code>Offset: 0x0050F890
    /// float __thiscall CPhysicsObj::get_target_quantum(CPhysicsObj*)</code>
    /// </summary>
    public float get_target_quantum() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, float>)0x0050F890)(ref this);

    /// <summary>
    /// <code>Offset: 0x0050F8B0
    /// void __thiscall CPhysicsObj::receive_target_update(CPhysicsObj*,const TargetInfo*)</code>
    /// </summary>
    public void receive_target_update(ACBindings.Internal.TargetInfo* info) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.TargetInfo*, void>)0x0050F8B0)(ref this, info);

    /// <summary>
    /// <code>Offset: 0x0050F8D0
    /// void __thiscall CPhysicsObj::add_voyeur(CPhysicsObj*,unsigned int,float,float)</code>
    /// </summary>
    public void add_voyeur(uint object_id, float radius, float quantum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, uint, float, float, void>)0x0050F8D0)(ref this, object_id, radius, quantum);

    /// <summary>
    /// <code>Offset: 0x0050F920
    /// int __thiscall CPhysicsObj::remove_voyeur(CPhysicsObj*,unsigned int)</code>
    /// </summary>
    public int remove_voyeur(uint object_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, uint, int>)0x0050F920)(ref this, object_id);

    /// <summary>
    /// <code>Offset: 0x0050F940
    /// void __thiscall CPhysicsObj::calc_friction(CPhysicsObj*,float,float)</code>
    /// </summary>
    public void calc_friction(float quantum, float velocity_mag2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, float, float, void>)0x0050F940)(ref this, quantum, velocity_mag2);

    /// <summary>
    /// <code>Offset: 0x0050FB20
    /// TransitionState __thiscall CPhysicsObj::FindObjCollisions(CPhysicsObj*,CTransition*)</code>
    /// </summary>
    public ACBindings.Internal.TransitionState FindObjCollisions(ACBindings.Internal.CTransition* transition) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.CTransition*, ACBindings.Internal.TransitionState>)0x0050FB20)(ref this, transition);

    /// <summary>
    /// <code>Offset: 0x0050FE10
    /// void __thiscall CPhysicsObj::UpdateViewerDistance(CPhysicsObj*,float,const AC1Legacy::Vector3*)</code>
    /// </summary>
    public void UpdateViewerDistance(float CYpt, ACBindings.Internal.AC1Legacy.Vector3* viewer_heading) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, float, ACBindings.Internal.AC1Legacy.Vector3*, void>)0x0050FE10)(ref this, CYpt, viewer_heading);

    /// <summary>
    /// <code>Offset: 0x0050FE30
    /// unsigned int __thiscall CPhysicsObj::create_particle_emitter(CPhysicsObj*,int,unsigned int,Frame*,unsigned int)</code>
    /// </summary>
    public uint create_particle_emitter(int a2, uint a3, ACBindings.Internal.Frame* a4, uint a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, int, uint, ACBindings.Internal.Frame*, uint, uint>)0x0050FE30)(ref this, a2, a3, a4, a5);

    /// <summary>
    /// <code>Offset: 0x0050FE80
    /// unsigned int __thiscall CPhysicsObj::create_blocking_particle_emitter(CPhysicsObj*,int,unsigned int,Frame*,unsigned int)</code>
    /// </summary>
    public uint create_blocking_particle_emitter(int a2, uint a3, ACBindings.Internal.Frame* a4, uint a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, int, uint, ACBindings.Internal.Frame*, uint, uint>)0x0050FE80)(ref this, a2, a3, a4, a5);

    /// <summary>
    /// <code>Offset: 0x0050FED0
    /// int __thiscall CPhysicsObj::destroy_particle_emitter(CPhysicsObj*,unsigned int)</code>
    /// </summary>
    public int destroy_particle_emitter(uint emitter_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, uint, int>)0x0050FED0)(ref this, emitter_id);

    /// <summary>
    /// <code>Offset: 0x0050FEF0
    /// int __thiscall CPhysicsObj::stop_particle_emitter(CPhysicsObj*,unsigned int)</code>
    /// </summary>
    public int stop_particle_emitter(uint emitter_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, uint, int>)0x0050FEF0)(ref this, emitter_id);

    /// <summary>
    /// <code>Offset: 0x0050FF30
    /// int __thiscall CPhysicsObj::play_sound(CPhysicsObj*,SoundType,float)</code>
    /// </summary>
    public int play_sound(ACBindings.Internal.SoundType sound_type, float volume) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.SoundType, float, int>)0x0050FF30)(ref this, sound_type, volume);

    /// <summary>
    /// <code>Offset: 0x0050FF60
    /// CPhysicsObj* __cdecl CPhysicsObj::GetObjectA(unsigned int)</code>
    /// </summary>
    public static ACBindings.Internal.CPhysicsObj* GetObjectA(uint object_id) => ((delegate* unmanaged[Cdecl]<uint, ACBindings.Internal.CPhysicsObj*>)0x0050FF60)(object_id);

    /// <summary>
    /// <code>Offset: 0x0050FF80
    /// void __cdecl CPhysicsObj::SetObjectMaintainer(CObjectMaint*)</code>
    /// </summary>
    public static void SetObjectMaintainer(ACBindings.Internal.CObjectMaint* obj_maint) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CObjectMaint*, void>)0x0050FF80)(obj_maint);

    /// <summary>
    /// <code>Offset: 0x0050FF90
    /// void __cdecl CPhysicsObj::SetPlayer(CPhysicsObj*)</code>
    /// </summary>
    public static void SetPlayer(ACBindings.Internal.CPhysicsObj* new_player_object) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CPhysicsObj*, void>)0x0050FF90)(new_player_object);

    /// <summary>
    /// <code>Offset: 0x0050FFA0
    /// void __thiscall CPhysicsObj::set_weenie_obj_ptr(CPhysicsObj*,CWeenieObject*)</code>
    /// </summary>
    public void set_weenie_obj_ptr(ACBindings.Internal.CWeenieObject* wobj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.CWeenieObject*, void>)0x0050FFA0)(ref this, wobj);

    /// <summary>
    /// <code>Offset: 0x0050FFC0
    /// void __thiscall CPhysicsObj::set_cell_id(CPhysicsObj*,unsigned int)</code>
    /// </summary>
    public void set_cell_id(uint new_cell_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, uint, void>)0x0050FFC0)(ref this, new_cell_id);

    /// <summary>
    /// <code>Offset: 0x0050FFF0
    /// void __thiscall CPhysicsObj::remove_parts(CPhysicsObj*,CObjCell*)</code>
    /// </summary>
    public void remove_parts(ACBindings.Internal.CObjCell* obj_cell) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.CObjCell*, void>)0x0050FFF0)(ref this, obj_cell);

    /// <summary>
    /// <code>Offset: 0x00510000
    /// int __thiscall CPhysicsObj::is_valid_walkable(CPhysicsObj*,const AC1Legacy::Vector3*)</code>
    /// </summary>
    public int is_valid_walkable(ACBindings.Internal.AC1Legacy.Vector3* normal) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.AC1Legacy.Vector3*, int>)0x00510000)(ref this, normal);

    /// <summary>
    /// <code>Offset: 0x00510040
    /// int __thiscall CPhysicsObj::CacheHasPhysicsBSP(CPhysicsObj*)</code>
    /// </summary>
    public int CacheHasPhysicsBSP() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, int>)0x00510040)(ref this);

    /// <summary>
    /// <code>Offset: 0x00510080
    /// int __thiscall CPhysicsObj::check_contact(CPhysicsObj*,int)</code>
    /// </summary>
    public int check_contact(int contact) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, int, int>)0x00510080)(ref this, contact);

    /// <summary>
    /// <code>Offset: 0x005100D0
    /// int __thiscall CPhysicsObj::build_collision_profile(CPhysicsObj*,ObjCollisionProfile*,const CPhysicsObj*,const AC1Legacy::Vector3*,const int,const int,const int)</code>
    /// </summary>
    public int build_collision_profile(ACBindings.Internal.ObjCollisionProfile* prof, ACBindings.Internal.CPhysicsObj* obj, ACBindings.Internal.AC1Legacy.Vector3* vel, int amIInContact, int objIsMissile, int objHasContact) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.ObjCollisionProfile*, ACBindings.Internal.CPhysicsObj*, ACBindings.Internal.AC1Legacy.Vector3*, int, int, int, int>)0x005100D0)(ref this, prof, obj, vel, amIInContact, objIsMissile, objHasContact);

    /// <summary>
    /// <code>Offset: 0x00510140
    /// void __thiscall CPhysicsObj::UpdatePartsInternal(CPhysicsObj*)</code>
    /// </summary>
    public void UpdatePartsInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, void>)0x00510140)(ref this);

    /// <summary>
    /// <code>Offset: 0x00510160
    /// int __thiscall CPhysicsObj::SetPlacementFrameInternal(CPhysicsObj*,unsigned int)</code>
    /// </summary>
    public int SetPlacementFrameInternal(uint frame_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, uint, int>)0x00510160)(ref this, frame_id);

    /// <summary>
    /// <code>Offset: 0x005101A0
    /// void __thiscall CPhysicsObj::set_omega(CPhysicsObj*,const AC1Legacy::Vector3*,int)</code>
    /// </summary>
    public void set_omega(ACBindings.Internal.AC1Legacy.Vector3* new_omega, int send_event) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.AC1Legacy.Vector3*, int, void>)0x005101A0)(ref this, new_omega, send_event);

    /// <summary>
    /// <code>Offset: 0x005101C0
    /// void __thiscall CPhysicsObj::set_sequence_animation(_DWORD*,unsigned int,int,int,float)</code>
    /// </summary>
    public void set_sequence_animation(uint a2, int a3, int a4, float a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, uint, int, int, float, void>)0x005101C0)(ref this, a2, a3, a4, a5);

    /// <summary>
    /// <code>Offset: 0x00510230
    /// void __thiscall CPhysicsObj::clear_sequence_anims(CPhysicsObj*)</code>
    /// </summary>
    public void clear_sequence_anims() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, void>)0x00510230)(ref this);

    /// <summary>
    /// <code>Offset: 0x00510240
    /// int __thiscall CPhysicsObj::HasAnims(CPhysicsObj*)</code>
    /// </summary>
    public int HasAnims() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, int>)0x00510240)(ref this);

    /// <summary>
    /// <code>Offset: 0x00510250
    /// unsigned int __thiscall CPhysicsObj::get_curr_frame_number(CPhysicsObj*)</code>
    /// </summary>
    public uint get_curr_frame_number() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, uint>)0x00510250)(ref this);

    /// <summary>
    /// <code>Offset: 0x00510270
    /// float __thiscall CPhysicsObj::get_distance_to_object(CPhysicsObj*,CPhysicsObj*,int)</code>
    /// </summary>
    public float get_distance_to_object(ACBindings.Internal.CPhysicsObj* object_, int use_cyls) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.CPhysicsObj*, int, float>)0x00510270)(ref this, object_, use_cyls);

    /// <summary>
    /// <code>Offset: 0x00510340
    /// int __thiscall CPhysicsObj::add_child(CPhysicsObj*,CPhysicsObj*,unsigned int)</code>
    /// </summary>
    public int add_child(ACBindings.Internal.CPhysicsObj* obj, uint where) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.CPhysicsObj*, uint, int>)0x00510340)(ref this, obj, where);

    /// <summary>
    /// <code>Offset: 0x005103C0
    /// int __thiscall CPhysicsObj::add_child(CPhysicsObj*,CPhysicsObj*,unsigned int,const Frame*)</code>
    /// </summary>
    public int add_child(ACBindings.Internal.CPhysicsObj* obj, uint part_index, ACBindings.Internal.Frame* frame) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.CPhysicsObj*, uint, ACBindings.Internal.Frame*, int>)0x005103C0)(ref this, obj, part_index, frame);

    /// <summary>
    /// <code>Offset: 0x00510430
    /// void __thiscall CPhysicsObj::SetTranslucencyInternal(CPhysicsObj*,float)</code>
    /// </summary>
    public void SetTranslucencyInternal(float translucency) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, float, void>)0x00510430)(ref this, translucency);

    /// <summary>
    /// <code>Offset: 0x00510470
    /// void __thiscall CPhysicsObj::SetNoDraw(CPhysicsObj*,int)</code>
    /// </summary>
    public void SetNoDraw(int no_draw) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, int, void>)0x00510470)(ref this, no_draw);

    /// <summary>
    /// <code>Offset: 0x00510480
    /// int __thiscall CPhysicsObj::DoObjDescChangesFromDefault(CPhysicsObj*,const ObjDesc*)</code>
    /// </summary>
    public int DoObjDescChangesFromDefault(ACBindings.Internal.ObjDesc* objdesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.ObjDesc*, int>)0x00510480)(ref this, objdesc);

    /// <summary>
    /// <code>Offset: 0x00510500
    /// int __thiscall CPhysicsObj::DoObjDescChanges(CPhysicsObj*,const ObjDesc*)</code>
    /// </summary>
    public int DoObjDescChanges(ACBindings.Internal.ObjDesc* objdesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.ObjDesc*, int>)0x00510500)(ref this, objdesc);

    /// <summary>
    /// <code>Offset: 0x00510580
    /// int __thiscall CPhysicsObj::MorphToExistingObject(CPhysicsObj*,const CPhysicsObj*)</code>
    /// </summary>
    public int MorphToExistingObject(ACBindings.Internal.CPhysicsObj* pObj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.CPhysicsObj*, int>)0x00510580)(ref this, pObj);

    /// <summary>
    /// <code>Offset: 0x00510620
    /// void __thiscall CPhysicsObj::SetTranslucency2(CPhysicsObj*,float,float,long double)</code>
    /// </summary>
    public void SetTranslucency2(float start_translucency, float end_translucency, double delta) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, float, float, double, void>)0x00510620)(ref this, start_translucency, end_translucency, delta);

    /// <summary>
    /// <code>Offset: 0x005106F0
    /// void __thiscall CPhysicsObj::SetTextureVelocity(CPhysicsObj*,float,float)</code>
    /// </summary>
    public void SetTextureVelocity(float du, float dv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, float, float, void>)0x005106F0)(ref this, du, dv);

    /// <summary>
    /// <code>Offset: 0x00510700
    /// void __thiscall CPhysicsObj::SetPartTextureVelocity(CPhysicsObj*,unsigned int,float,float)</code>
    /// </summary>
    public void SetPartTextureVelocity(uint part_index, float du, float dv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, uint, float, float, void>)0x00510700)(ref this, part_index, du, dv);

    /// <summary>
    /// <code>Offset: 0x00510710
    /// int __thiscall CPhysicsObj::set_active(CPhysicsObj*,int)</code>
    /// </summary>
    public int set_active(int active) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, int, int>)0x00510710)(ref this, active);

    /// <summary>
    /// <code>Offset: 0x00510770
    /// int __thiscall CPhysicsObj::set_nodraw(CPhysicsObj*,int,int)</code>
    /// </summary>
    public int set_nodraw(int nodraw, int send_event) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, int, int, int>)0x00510770)(ref this, nodraw, send_event);

    /// <summary>
    /// <code>Offset: 0x005107C0
    /// void __thiscall CPhysicsObj::set_lights(CPhysicsObj*,int,int)</code>
    /// </summary>
    public void set_lights(int lights_on, int send_event) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, int, int, void>)0x005107C0)(ref this, lights_on, send_event);

    /// <summary>
    /// <code>Offset: 0x00510810
    /// int __thiscall CPhysicsObj::set_elasticity(CPhysicsObj*,float)</code>
    /// </summary>
    public int set_elasticity(float elasticity) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, float, int>)0x00510810)(ref this, elasticity);

    /// <summary>
    /// <code>Offset: 0x00510870
    /// void __thiscall CPhysicsObj::Hook_AnimDone(CPhysicsObj*)</code>
    /// </summary>
    public void Hook_AnimDone() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, void>)0x00510870)(ref this);

    /// <summary>
    /// <code>Offset: 0x00510880
    /// void __thiscall CPhysicsObj::MotionDone(CPhysicsObj*,unsigned int,int)</code>
    /// </summary>
    public void MotionDone(uint motion, int success) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, uint, int, void>)0x00510880)(ref this, motion, success);

    /// <summary>
    /// <code>Offset: 0x005108B0
    /// const RawMotionState* __thiscall CPhysicsObj::InqRawMotionState(CPhysicsObj*)</code>
    /// </summary>
    public ACBindings.Internal.RawMotionState* InqRawMotionState() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.RawMotionState*>)0x005108B0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005108D0
    /// const InterpretedMotionState* __thiscall CPhysicsObj::InqInterpretedMotionState(CPhysicsObj*)</code>
    /// </summary>
    public ACBindings.Internal.InterpretedMotionState* InqInterpretedMotionState() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.InterpretedMotionState*>)0x005108D0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005108F0
    /// void __thiscall CPhysicsObj::RemoveLinkAnimations(CPhysicsObj*)</code>
    /// </summary>
    public void RemoveLinkAnimations() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, void>)0x005108F0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00510900
    /// void __thiscall CPhysicsObj::CheckForCompletedMotions(CPhysicsObj*)</code>
    /// </summary>
    public void CheckForCompletedMotions() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, void>)0x00510900)(ref this);

    /// <summary>
    /// <code>Offset: 0x00510910
    /// bool __thiscall CPhysicsObj::GetBoundingBox(CPhysicsObj*,BBox*)</code>
    /// </summary>
    public byte GetBoundingBox(ACBindings.Internal.BBox* o_bbox) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.BBox*, byte>)0x00510910)(ref this, o_bbox);

    /// <summary>
    /// <code>Offset: 0x00510930
    /// bool __thiscall CPhysicsObj::ShouldDrawParticles(CPhysicsObj*,float)</code>
    /// </summary>
    public byte ShouldDrawParticles(float i_fDegradeDistance) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, float, byte>)0x00510930)(ref this, i_fDegradeDistance);

    /// <summary>
    /// <code>Offset: 0x00510A50
    /// int __thiscall CPhysicsObj::InitObjectBegin(CPhysicsObj*,unsigned int,int)</code>
    /// </summary>
    public int InitObjectBegin(uint object_iid, int bDynamic) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, uint, int, int>)0x00510A50)(ref this, object_iid, bDynamic);

    /// <summary>
    /// <code>Offset: 0x00510AB0
    /// int __thiscall CPhysicsObj::InitObjectEnd(CPhysicsObj*)</code>
    /// </summary>
    public int InitObjectEnd() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, int>)0x00510AB0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00510AF0
    /// unsigned int __thiscall CPhysicsObj::DoMotion(CPhysicsObj*,unsigned int,const MovementParameters*,int)</code>
    /// </summary>
    public uint DoMotion(uint motion, ACBindings.Internal.MovementParameters* params_, int send_event) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, uint, ACBindings.Internal.MovementParameters*, int, uint>)0x00510AF0)(ref this, motion, params_, send_event);

    /// <summary>
    /// <code>Offset: 0x00510BA0
    /// unsigned int __thiscall CPhysicsObj::StopMotion(CPhysicsObj*,unsigned int,const MovementParameters*,int)</code>
    /// </summary>
    public uint StopMotion(uint motion, ACBindings.Internal.MovementParameters* params_, int send_event) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, uint, ACBindings.Internal.MovementParameters*, int, uint>)0x00510BA0)(ref this, motion, params_, send_event);

    /// <summary>
    /// <code>Offset: 0x00510C50
    /// void __thiscall CPhysicsObj::StopCompletely(CPhysicsObj*,int)</code>
    /// </summary>
    public void StopCompletely(int send_event) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, int, void>)0x00510C50)(ref this, send_event);

    /// <summary>
    /// <code>Offset: 0x00510CC0
    /// void __thiscall CPhysicsObj::cancel_moveto(CPhysicsObj*)</code>
    /// </summary>
    public void cancel_moveto() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, void>)0x00510CC0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00510CE0
    /// void __thiscall CPhysicsObj::MakePositionManager(CPhysicsObj*)</code>
    /// </summary>
    public void MakePositionManager() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, void>)0x00510CE0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00510D40
    /// void __thiscall CPhysicsObj::MakeMovementManager(CPhysicsObj*,int)</code>
    /// </summary>
    public void MakeMovementManager(int init_motion) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, int, void>)0x00510D40)(ref this, init_motion);

    /// <summary>
    /// <code>Offset: 0x00510DB0
    /// void __thiscall CPhysicsObj::MoveToObject_Internal(CPhysicsObj*,unsigned int,unsigned int,float,float,const MovementParameters*)</code>
    /// </summary>
    public void MoveToObject_Internal(uint object_id, uint top_level_id, float object_radius, float object_height, ACBindings.Internal.MovementParameters* params_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, uint, uint, float, float, ACBindings.Internal.MovementParameters*, void>)0x00510DB0)(ref this, object_id, top_level_id, object_radius, object_height, params_);

    /// <summary>
    /// <code>Offset: 0x00510EC0
    /// void __thiscall CPhysicsObj::TurnToObject_Internal(CPhysicsObj*,unsigned int,unsigned int,const MovementParameters*)</code>
    /// </summary>
    public void TurnToObject_Internal(uint object_id, uint top_level_id, ACBindings.Internal.MovementParameters* params_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, uint, uint, ACBindings.Internal.MovementParameters*, void>)0x00510EC0)(ref this, object_id, top_level_id, params_);

    /// <summary>
    /// <code>Offset: 0x00510FC0
    /// void __thiscall CPhysicsObj::InterpolateTo(CPhysicsObj*,const Position*,int)</code>
    /// </summary>
    public void InterpolateTo(ACBindings.Internal.Position* p, int keep_heading) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.Position*, int, void>)0x00510FC0)(ref this, p, keep_heading);

    /// <summary>
    /// <code>Offset: 0x00510FF0
    /// void __thiscall CPhysicsObj::ConstrainTo(CPhysicsObj*,const Position*,float,float)</code>
    /// </summary>
    public void ConstrainTo(ACBindings.Internal.Position* p, float start_distance, float max_distance) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.Position*, float, float, void>)0x00510FF0)(ref this, p, start_distance, max_distance);

    /// <summary>
    /// <code>Offset: 0x00511010
    /// void __thiscall CPhysicsObj::report_attacks(CPhysicsObj*,AttackInfo*)</code>
    /// </summary>
    public void report_attacks(ACBindings.Internal.AttackInfo* attack_info) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.AttackInfo*, void>)0x00511010)(ref this, attack_info);

    /// <summary>
    /// <code>Offset: 0x005110A0
    /// void __thiscall CPhysicsObj::receive_detection_update(CPhysicsObj*,const DetectionInfo*)</code>
    /// </summary>
    public void receive_detection_update(ACBindings.Internal.DetectionInfo* info) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.DetectionInfo*, void>)0x005110A0)(ref this, info);

    /// <summary>
    /// <code>Offset: 0x005111D0
    /// void __thiscall CPhysicsObj::UpdatePhysicsInternal(CPhysicsObj*,float,Frame*)</code>
    /// </summary>
    public void UpdatePhysicsInternal(float quantum, ACBindings.Internal.Frame* offset_frame) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, float, ACBindings.Internal.Frame*, void>)0x005111D0)(ref this, quantum, offset_frame);

    /// <summary>
    /// <code>Offset: 0x00511420
    /// void __thiscall CPhysicsObj::calc_acceleration(CPhysicsObj*)</code>
    /// </summary>
    public void calc_acceleration() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, void>)0x00511420)(ref this);

    /// <summary>
    /// <code>Offset: 0x00511510
    /// int __thiscall CPhysicsObj::ethereal_check_for_collisions(CPhysicsObj*)</code>
    /// </summary>
    public int ethereal_check_for_collisions() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, int>)0x00511510)(ref this);

    /// <summary>
    /// <code>Offset: 0x00511560
    /// int __thiscall CPhysicsObj::report_object_collision_end(CPhysicsObj*,const unsigned int)</code>
    /// </summary>
    public int report_object_collision_end(uint object_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, uint, int>)0x00511560)(ref this, object_id);

    /// <summary>
    /// <code>Offset: 0x00511600
    /// void __thiscall CPhysicsObj::UpdateViewerDistance(CPhysicsObj*)</code>
    /// </summary>
    public void UpdateViewerDistance() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, void>)0x00511600)(ref this);

    /// <summary>
    /// <code>Offset: 0x00511720
    /// void __thiscall CPhysicsObj::UpdateViewerDistanceRecursive(CPhysicsObj*)</code>
    /// </summary>
    public void UpdateViewerDistanceRecursive() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, void>)0x00511720)(ref this);

    /// <summary>
    /// <code>Offset: 0x00511760
    /// void __thiscall CPhysicsObj::DrawRecursive(CPhysicsObj*)</code>
    /// </summary>
    public void DrawRecursive() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, void>)0x00511760)(ref this);

    /// <summary>
    /// <code>Offset: 0x005117A0
    /// int __thiscall CPhysicsObj::play_script_internal(CPhysicsObj*,int)</code>
    /// </summary>
    public int play_script_internal(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, int, int>)0x005117A0)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x00511800
    /// int __thiscall CPhysicsObj::play_script(CPhysicsObj*,int)</code>
    /// </summary>
    public int play_script(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, int, int>)0x00511800)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x00511820
    /// void __thiscall CPhysicsObj::destroy_particle_manager(CPhysicsObj*)</code>
    /// </summary>
    public void destroy_particle_manager() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, void>)0x00511820)(ref this);

    /// <summary>
    /// <code>Offset: 0x00511850
    /// int __thiscall CPhysicsObj::get_landscape_coord(CPhysicsObj*,int*,int*)</code>
    /// </summary>
    public int get_landscape_coord(int* x, int* y) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, int*, int*, int>)0x00511850)(ref this, x, y);

    /// <summary>
    /// <code>Offset: 0x00511870
    /// void __thiscall CPhysicsObj::set_cell_id_recursive(CPhysicsObj*,unsigned int)</code>
    /// </summary>
    public void set_cell_id_recursive(uint new_cell_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, uint, void>)0x00511870)(ref this, new_cell_id);

    /// <summary>
    /// <code>Offset: 0x005118D0
    /// void __thiscall CPhysicsObj::AddPartToShadowCells(CPhysicsObj*,CPhysicsPart*)</code>
    /// </summary>
    public void AddPartToShadowCells(ACBindings.Internal.CPhysicsPart* part) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.CPhysicsPart*, void>)0x005118D0)(ref this, part);

    /// <summary>
    /// <code>Offset: 0x00511940
    /// void __thiscall CPhysicsObj::RemovePartFromShadowCells(CPhysicsObj*,CPhysicsPart*)</code>
    /// </summary>
    public void RemovePartFromShadowCells(ACBindings.Internal.CPhysicsPart* part) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.CPhysicsPart*, void>)0x00511940)(ref this, part);

    /// <summary>
    /// <code>Offset: 0x005119A0
    /// void __thiscall CPhysicsObj::enter_cell(CPhysicsObj*,CObjCell*)</code>
    /// </summary>
    public void enter_cell(ACBindings.Internal.CObjCell* new_cell) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.CObjCell*, void>)0x005119A0)(ref this, new_cell);

    /// <summary>
    /// <code>Offset: 0x00511A20
    /// void __thiscall CPhysicsObj::leave_cell(CPhysicsObj*,int)</code>
    /// </summary>
    public void leave_cell(int is_changing_cell) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, int, void>)0x00511A20)(ref this, is_changing_cell);

    /// <summary>
    /// <code>Offset: 0x00511A90
    /// void __thiscall CPhysicsObj::find_bbox_cell_list(CPhysicsObj*,CELLARRAY*)</code>
    /// </summary>
    public void find_bbox_cell_list(ACBindings.Internal.CELLARRAY* cell_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.CELLARRAY*, void>)0x00511A90)(ref this, cell_array);

    /// <summary>
    /// <code>Offset: 0x00511B00
    /// int __thiscall CPhysicsObj::obj_within_block(CPhysicsObj*)</code>
    /// </summary>
    public int obj_within_block() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, int>)0x00511B00)(ref this);

    /// <summary>
    /// <code>Offset: 0x00511D00
    /// void __thiscall CPhysicsObj::remove_shadows_from_cells(CPhysicsObj*)</code>
    /// </summary>
    public void remove_shadows_from_cells() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, void>)0x00511D00)(ref this);

    /// <summary>
    /// <code>Offset: 0x00511D90
    /// int __thiscall CPhysicsObj::is_completely_visible(CPhysicsObj*)</code>
    /// </summary>
    public int is_completely_visible() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, int>)0x00511D90)(ref this);

    /// <summary>
    /// <code>Offset: 0x00511DE0
    /// void __thiscall CPhysicsObj::set_on_walkable(CPhysicsObj*,int)</code>
    /// </summary>
    public void set_on_walkable(int is_on_walkable) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, int, void>)0x00511DE0)(ref this, is_on_walkable);

    /// <summary>
    /// <code>Offset: 0x00511E50
    /// int __thiscall CPhysicsObj::SetPlacementFrame(CPhysicsObj*,unsigned int,int)</code>
    /// </summary>
    public int SetPlacementFrame(uint frame_id, int send_event) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, uint, int, int>)0x00511E50)(ref this, frame_id, send_event);

    /// <summary>
    /// <code>Offset: 0x00511E90
    /// AC1Legacy::Vector3* __thiscall CPhysicsObj::get_velocity(CPhysicsObj*,AC1Legacy::Vector3*)</code>
    /// </summary>
    public ACBindings.Internal.AC1Legacy.Vector3* get_velocity(ACBindings.Internal.AC1Legacy.Vector3* result) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.AC1Legacy.Vector3*>)0x00511E90)(ref this, result);

    /// <summary>
    /// <code>Offset: 0x00511EC0
    /// void __thiscall CPhysicsObj::set_velocity(CPhysicsObj*,const AC1Legacy::Vector3*,int)</code>
    /// </summary>
    public void set_velocity(ACBindings.Internal.AC1Legacy.Vector3* new_velocity, int send_event) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.AC1Legacy.Vector3*, int, void>)0x00511EC0)(ref this, new_velocity, send_event);

    /// <summary>
    /// <code>Offset: 0x00511FA0
    /// void __thiscall CPhysicsObj::set_local_velocity(CPhysicsObj*,const AC1Legacy::Vector3*,int)</code>
    /// </summary>
    public void set_local_velocity(ACBindings.Internal.AC1Legacy.Vector3* new_velocity, int send_event) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.AC1Legacy.Vector3*, int, void>)0x00511FA0)(ref this, new_velocity, send_event);

    /// <summary>
    /// <code>Offset: 0x00512010
    /// float __thiscall CPhysicsObj::get_heading(CPhysicsObj*)</code>
    /// </summary>
    public float get_heading() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, float>)0x00512010)(ref this);

    /// <summary>
    /// <code>Offset: 0x00512020
    /// void __thiscall CPhysicsObj::process_hooks(CPhysicsObj*)</code>
    /// </summary>
    public void process_hooks() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, void>)0x00512020)(ref this);

    /// <summary>
    /// <code>Offset: 0x005120C0
    /// void __thiscall CPhysicsObj::SetTranslucency(CPhysicsObj*,float,long double)</code>
    /// </summary>
    public void SetTranslucency(float translucency, double delta) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, float, double, void>)0x005120C0)(ref this, translucency, delta);

    /// <summary>
    /// <code>Offset: 0x00512190
    /// void __thiscall CPhysicsObj::SetTranslucencyHierarchical(CPhysicsObj*,float)</code>
    /// </summary>
    public void SetTranslucencyHierarchical(float translucency) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, float, void>)0x00512190)(ref this, translucency);

    /// <summary>
    /// <code>Offset: 0x00512200
    /// void __thiscall CPhysicsObj::SetPartTranslucency(CPhysicsObj*,unsigned int,float,float,long double)</code>
    /// </summary>
    public void SetPartTranslucency(uint part_index, float start_trans, float end_trans, double delta) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, uint, float, float, double, void>)0x00512200)(ref this, part_index, start_trans, end_trans, delta);

    /// <summary>
    /// <code>Offset: 0x005122B0
    /// void __thiscall CPhysicsObj::SetPartLuminosity(CPhysicsObj*,unsigned int,float,float,long double)</code>
    /// </summary>
    public void SetPartLuminosity(uint part, float start, float end, double delta) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, uint, float, float, double, void>)0x005122B0)(ref this, part, start, end, delta);

    /// <summary>
    /// <code>Offset: 0x00512360
    /// void __thiscall CPhysicsObj::SetLuminosity(CPhysicsObj*,float,float,long double)</code>
    /// </summary>
    public void SetLuminosity(float start, float end, double delta) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, float, float, double, void>)0x00512360)(ref this, start, end, delta);

    /// <summary>
    /// <code>Offset: 0x00512400
    /// void __thiscall CPhysicsObj::SetPartDiffusion(CPhysicsObj*,unsigned int,float,float,long double)</code>
    /// </summary>
    public void SetPartDiffusion(uint part, float start, float end, double delta) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, uint, float, float, double, void>)0x00512400)(ref this, part, start, end, delta);

    /// <summary>
    /// <code>Offset: 0x005124B0
    /// void __thiscall CPhysicsObj::SetDiffusion(CPhysicsObj*,float,float,long double)</code>
    /// </summary>
    public void SetDiffusion(float start, float end, double delta) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, float, float, double, void>)0x005124B0)(ref this, start, end, delta);

    /// <summary>
    /// <code>Offset: 0x00512550
    /// void __thiscall CPhysicsObj::SetLighting(CPhysicsObj*,float,float)</code>
    /// </summary>
    public void SetLighting(float luminosity, float diffuse) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, float, float, void>)0x00512550)(ref this, luminosity, diffuse);

    /// <summary>
    /// <code>Offset: 0x00512560
    /// int __thiscall CPhysicsObj::SetPartLighting(CPhysicsObj*,unsigned int,float,float)</code>
    /// </summary>
    public int SetPartLighting(uint part_index, float luminosity, float diffuse) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, uint, float, float, int>)0x00512560)(ref this, part_index, luminosity, diffuse);

    /// <summary>
    /// <code>Offset: 0x00512580
    /// void __thiscall CPhysicsObj::RestoreLighting(CPhysicsObj*)</code>
    /// </summary>
    public void RestoreLighting() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, void>)0x00512580)(ref this);

    /// <summary>
    /// <code>Offset: 0x00512590
    /// void __thiscall CPhysicsObj::CallPESInternal(CPhysicsObj*,int,float)</code>
    /// </summary>
    public void CallPESInternal(int a2, float a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, int, float, void>)0x00512590)(ref this, a2, a3);

    /// <summary>
    /// <code>Offset: 0x005125C0
    /// void __thiscall CPhysicsObj::CallPES(CPhysicsObj*,void*,double)</code>
    /// </summary>
    public void CallPES(System.IntPtr user_data, double a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, System.IntPtr, double, void>)0x005125C0)(ref this, user_data, a3);

    /// <summary>
    /// <code>Offset: 0x00512680
    /// void __thiscall CPhysicsObj::SetScaleStatic(CPhysicsObj*,float)</code>
    /// </summary>
    public void SetScaleStatic(float new_scale) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, float, void>)0x00512680)(ref this, new_scale);

    /// <summary>
    /// <code>Offset: 0x00512710
    /// int __thiscall CPhysicsObj::set_ethereal(CPhysicsObj*,int,int)</code>
    /// </summary>
    public int set_ethereal(int ethereal, int send_event) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, int, int, int>)0x00512710)(ref this, ethereal, send_event);

    /// <summary>
    /// <code>Offset: 0x00512790
    /// unsigned int __thiscall CPhysicsObj::get_object_info(CPhysicsObj*,CTransition*,int)</code>
    /// </summary>
    public uint get_object_info(ACBindings.Internal.CTransition* transit, int admin_move) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.CTransition*, int, uint>)0x00512790)(ref this, transit, admin_move);

    /// <summary>
    /// <code>Offset: 0x00512850
    /// int __cdecl CPhysicsObj::AdjustPosition(Position*,const AC1Legacy::Vector3*,CObjCell**,int,int)</code>
    /// </summary>
    public static int AdjustPosition(ACBindings.Internal.Position* p, ACBindings.Internal.AC1Legacy.Vector3* low_pt, ACBindings.Internal.CObjCell** new_cell, int bDontCreateCells, int bSearchCells) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.Position*, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.CObjCell**, int, int, int>)0x00512850)(p, low_pt, new_cell, bDontCreateCells, bSearchCells);

    /// <summary>
    /// <code>Offset: 0x00512960
    /// int __thiscall CPhysicsObj::CheckPositionInternal(CPhysicsObj*,CObjCell*,Position*,CTransition*,const SetPositionStruct*)</code>
    /// </summary>
    public int CheckPositionInternal(ACBindings.Internal.CObjCell* new_cell, ACBindings.Internal.Position* new_pos, ACBindings.Internal.CTransition* transit, ACBindings.Internal.SetPositionStruct* sps) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.CObjCell*, ACBindings.Internal.Position*, ACBindings.Internal.CTransition*, ACBindings.Internal.SetPositionStruct*, int>)0x00512960)(ref this, new_cell, new_pos, transit, sps);

    /// <summary>
    /// <code>Offset: 0x00512A10
    /// int __thiscall CPhysicsObj::prepare_to_leave_visibility(CPhysicsObj*)</code>
    /// </summary>
    public int prepare_to_leave_visibility() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, int>)0x00512A10)(ref this);

    /// <summary>
    /// <code>Offset: 0x00512A70
    /// void __thiscall CPhysicsObj::prepare_to_enter_world(CPhysicsObj*)</code>
    /// </summary>
    public void prepare_to_enter_world() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, void>)0x00512A70)(ref this);

    /// <summary>
    /// <code>Offset: 0x00512B10
    /// void __thiscall CPhysicsObj::unpack_movement(CPhysicsObj*,void**,unsigned int)</code>
    /// </summary>
    public void unpack_movement(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, void**, uint, void>)0x00512B10)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x00512B90
    /// CMotionInterp* __thiscall CPhysicsObj::get_minterp(CPhysicsObj*)</code>
    /// </summary>
    public ACBindings.Internal.CMotionInterp* get_minterp() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.CMotionInterp*>)0x00512B90)(ref this);

    /// <summary>
    /// <code>Offset: 0x00512C00
    /// PositionManager* __thiscall CPhysicsObj::get_position_manager(CPhysicsObj*)</code>
    /// </summary>
    public ACBindings.Internal.PositionManager* get_position_manager() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.PositionManager*>)0x00512C00)(ref this);

    /// <summary>
    /// <code>Offset: 0x00512C10
    /// void __thiscall CPhysicsObj::get_local_physics_velocity(CPhysicsObj*,AC1Legacy::Vector3*)</code>
    /// </summary>
    public void get_local_physics_velocity(ACBindings.Internal.AC1Legacy.Vector3* retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.AC1Legacy.Vector3*, void>)0x00512C10)(ref this, retval);

    /// <summary>
    /// <code>Offset: 0x00512EF0
    /// void __thiscall CPhysicsObj::CPhysicsObj(CPhysicsObj*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, void>)0x00512EF0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00513100
    /// CPhysicsObj* __cdecl CPhysicsObj::makeNullObject(unsigned int,int)</code>
    /// </summary>
    public static ACBindings.Internal.CPhysicsObj* makeNullObject(uint object_iid, int bDynamic) => ((delegate* unmanaged[Cdecl]<uint, int, ACBindings.Internal.CPhysicsObj*>)0x00513100)(object_iid, bDynamic);

    /// <summary>
    /// <code>Offset: 0x00513140
    /// CPhysicsObj* __cdecl CPhysicsObj::makeParticleObject(unsigned int,const CSphere*)</code>
    /// </summary>
    public static ACBindings.Internal.CPhysicsObj* makeParticleObject(uint num_parts, ACBindings.Internal.CSphere* sorting_sphere) => ((delegate* unmanaged[Cdecl]<uint, ACBindings.Internal.CSphere*, ACBindings.Internal.CPhysicsObj*>)0x00513140)(num_parts, sorting_sphere);

    /// <summary>
    /// <code>Offset: 0x005131B0
    /// int __thiscall CPhysicsObj::InitPartArrayObject(CPhysicsObj*,int,int)</code>
    /// </summary>
    public int InitPartArrayObject(int a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, int, int, int>)0x005131B0)(ref this, a2, a3);

    /// <summary>
    /// <code>Offset: 0x00513280
    /// int __thiscall CPhysicsObj::SetMotionTableID(CPhysicsObj*,int)</code>
    /// </summary>
    public int SetMotionTableID(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, int, int>)0x00513280)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x005132E0
    /// void __thiscall CPhysicsObj::stick_to_object(CPhysicsObj*,unsigned int)</code>
    /// </summary>
    public void stick_to_object(uint object_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, uint, void>)0x005132E0)(ref this, object_id);

    /// <summary>
    /// <code>Offset: 0x00513360
    /// void __thiscall CPhysicsObj::MoveToObject(CPhysicsObj*,unsigned int,const MovementParameters*)</code>
    /// </summary>
    public void MoveToObject(uint object_id, ACBindings.Internal.MovementParameters* params_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, uint, ACBindings.Internal.MovementParameters*, void>)0x00513360)(ref this, object_id, params_);

    /// <summary>
    /// <code>Offset: 0x00513440
    /// void __thiscall CPhysicsObj::TurnToObject(CPhysicsObj*,unsigned int,const MovementParameters*)</code>
    /// </summary>
    public void TurnToObject(uint object_id, ACBindings.Internal.MovementParameters* params_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, uint, ACBindings.Internal.MovementParameters*, void>)0x00513440)(ref this, object_id, params_);

    /// <summary>
    /// <code>Offset: 0x00513480
    /// void __thiscall CPhysicsObj::TurnToHeading(CPhysicsObj*,const MovementParameters*)</code>
    /// </summary>
    public void TurnToHeading(ACBindings.Internal.MovementParameters* params_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.MovementParameters*, void>)0x00513480)(ref this, params_);

    /// <summary>
    /// <code>Offset: 0x00513570
    /// void __thiscall CPhysicsObj::attack(CPhysicsObj*,const AttackCone*)</code>
    /// </summary>
    public void attack(ACBindings.Internal.AttackCone* attack_cone) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.AttackCone*, void>)0x00513570)(ref this, attack_cone);

    /// <summary>
    /// <code>Offset: 0x005136C0
    /// void __thiscall CPhysicsObj::HandleUpdateTarget(CPhysicsObj*,TargetInfo)</code>
    /// </summary>
    public void HandleUpdateTarget(ACBindings.Internal.TargetInfo target_info) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.TargetInfo, void>)0x005136C0)(ref this, target_info);

    /// <summary>
    /// <code>Offset: 0x00513730
    /// void __thiscall CPhysicsObj::UpdatePositionInternal(CPhysicsObj*,float,Frame*)</code>
    /// </summary>
    public void UpdatePositionInternal(float quantum, ACBindings.Internal.Frame* o_newFrame) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, float, ACBindings.Internal.Frame*, void>)0x00513730)(ref this, quantum, o_newFrame);

    /// <summary>
    /// <code>Offset: 0x00513850
    /// void __thiscall CPhysicsObj::UpdateChild(CPhysicsObj*,CPhysicsObj*,unsigned int,const Frame*)</code>
    /// </summary>
    public void UpdateChild(ACBindings.Internal.CPhysicsObj* child_obj, uint part_index, ACBindings.Internal.Frame* child_frame) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.CPhysicsObj*, uint, ACBindings.Internal.Frame*, void>)0x00513850)(ref this, child_obj, part_index, child_frame);

    /// <summary>
    /// <code>Offset: 0x005138C0
    /// const CTransition* __thiscall CPhysicsObj::transition(CPhysicsObj*,const Position*,const Position*,int)</code>
    /// </summary>
    public ACBindings.Internal.CTransition* transition(ACBindings.Internal.Position* old_pos, ACBindings.Internal.Position* new_pos, int admin_move) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.Position*, ACBindings.Internal.Position*, int, ACBindings.Internal.CTransition*>)0x005138C0)(ref this, old_pos, new_pos, admin_move);

    /// <summary>
    /// <code>Offset: 0x005139D0
    /// int __thiscall CPhysicsObj::check_collision(CPhysicsObj*,const CPhysicsObj*)</code>
    /// </summary>
    public int check_collision(ACBindings.Internal.CPhysicsObj* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.CPhysicsObj*, int>)0x005139D0)(ref this, object_);

    /// <summary>
    /// <code>Offset: 0x00513AC0
    /// int __thiscall CPhysicsObj::report_environment_collision(CPhysicsObj*,int)</code>
    /// </summary>
    public int report_environment_collision(int prev_has_contact) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, int, int>)0x00513AC0)(ref this, prev_has_contact);

    /// <summary>
    /// <code>Offset: 0x00513B60
    /// int __thiscall CPhysicsObj::report_object_collision(CPhysicsObj*,const CPhysicsObj*,int)</code>
    /// </summary>
    public int report_object_collision(ACBindings.Internal.CPhysicsObj* object_, int prev_has_contact) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.CPhysicsObj*, int, int>)0x00513B60)(ref this, object_, prev_has_contact);

    /// <summary>
    /// <code>Offset: 0x00513D60
    /// int __thiscall CPhysicsObj::play_script(CPhysicsObj*,PScriptType,float)</code>
    /// </summary>
    public int play_script(ACBindings.Internal.PScriptType script_type, float mod) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.PScriptType, float, int>)0x00513D60)(ref this, script_type, mod);

    /// <summary>
    /// <code>Offset: 0x00513DB0
    /// int __thiscall CPhysicsObj::play_default_script(CPhysicsObj*)</code>
    /// </summary>
    public int play_default_script() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, int>)0x00513DB0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00513E00
    /// int __thiscall CPhysicsObj::play_default_script(CPhysicsObj*,unsigned int)</code>
    /// </summary>
    public int play_default_script(uint part_index) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, uint, int>)0x00513E00)(ref this, part_index);

    /// <summary>
    /// <code>Offset: 0x00513E90
    /// void __thiscall CPhysicsObj::change_cell(CPhysicsObj*,CObjCell*)</code>
    /// </summary>
    public void change_cell(ACBindings.Internal.CObjCell* new_cell) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.CObjCell*, void>)0x00513E90)(ref this, new_cell);

    /// <summary>
    /// <code>Offset: 0x00513EF0
    /// void __thiscall CPhysicsObj::RemoveObjectFromSingleCell(CPhysicsObj*,CObjCell*)</code>
    /// </summary>
    public void RemoveObjectFromSingleCell(ACBindings.Internal.CObjCell* obj_cell) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.CObjCell*, void>)0x00513EF0)(ref this, obj_cell);

    /// <summary>
    /// <code>Offset: 0x00513F70
    /// void __thiscall CPhysicsObj::unset_parent(CPhysicsObj*)</code>
    /// </summary>
    public void unset_parent() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, void>)0x00513F70)(ref this);

    /// <summary>
    /// <code>Offset: 0x00513FE0
    /// void __thiscall CPhysicsObj::unparent_children(CPhysicsObj*)</code>
    /// </summary>
    public void unparent_children() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, void>)0x00513FE0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005140C0
    /// void __thiscall CPhysicsObj::process_fp_hook(CPhysicsObj*,int,float,void*)</code>
    /// </summary>
    public void process_fp_hook(int type, float curr_value, System.IntPtr user_data) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, int, float, System.IntPtr, void>)0x005140C0)(ref this, type, curr_value, user_data);

    /// <summary>
    /// <code>Offset: 0x005141A0
    /// void __thiscall CPhysicsObj::SetScale(CPhysicsObj*,float,long double)</code>
    /// </summary>
    public void SetScale(float new_scale, double delta) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, float, double, void>)0x005141A0)(ref this, new_scale, delta);

    /// <summary>
    /// <code>Offset: 0x00514270
    /// void __thiscall CPhysicsObj::queue_netblob(CPhysicsObj*,NetBlob*)</code>
    /// </summary>
    public void queue_netblob(ACBindings.Internal.NetBlob* blob) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.NetBlob*, void>)0x00514270)(ref this, blob);

    /// <summary>
    /// <code>Offset: 0x00514410
    /// int __thiscall CPhysicsObj::InitNullObject(CPhysicsObj*,int)</code>
    /// </summary>
    public int InitNullObject(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, int, int>)0x00514410)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x00514470
    /// CPhysicsObj* __cdecl CPhysicsObj::makeObject(int,unsigned int,int)</code>
    /// </summary>
    public static ACBindings.Internal.CPhysicsObj* makeObject(int a1, uint object_iid, int bDynamic) => ((delegate* unmanaged[Cdecl]<int, uint, int, ACBindings.Internal.CPhysicsObj*>)0x00514470)(a1, object_iid, bDynamic);

    /// <summary>
    /// <code>Offset: 0x005144D0
    /// void __thiscall CPhysicsObj::InitDefaults(CPhysicsObj*,const CSetup*)</code>
    /// </summary>
    public void InitDefaults(ACBindings.Internal.CSetup* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.CSetup*, void>)0x005144D0)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x005145D0
    /// void __thiscall CPhysicsObj::Destroy(CPhysicsObj*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, void>)0x005145D0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00514830
    /// void __thiscall CPhysicsObj::~CPhysicsObj(CPhysicsObj*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, void>)0x00514830)(ref this);

    /// <summary>
    /// <code>Offset: 0x005148A0
    /// void __thiscall CPhysicsObj::UpdateChildrenInternal(CPhysicsObj*)</code>
    /// </summary>
    public void UpdateChildrenInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, void>)0x005148A0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005148F0
    /// void __thiscall CPhysicsObj::animate_static_object(CPhysicsObj*)</code>
    /// </summary>
    public void animate_static_object() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, void>)0x005148F0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00514A10
    /// int __thiscall CPhysicsObj::track_object_collision(CPhysicsObj*,const CPhysicsObj*,int)</code>
    /// </summary>
    public int track_object_collision(ACBindings.Internal.CPhysicsObj* object_, int prev_has_contact) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.CPhysicsObj*, int, int>)0x00514A10)(ref this, object_, prev_has_contact);

    /// <summary>
    /// <code>Offset: 0x00514AD0
    /// void __thiscall CPhysicsObj::report_collision_start(CPhysicsObj*)</code>
    /// </summary>
    public void report_collision_start() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, void>)0x00514AD0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00514B90
    /// void __thiscall CPhysicsObj::set_frame(CPhysicsObj*,const Frame*)</code>
    /// </summary>
    public void set_frame(ACBindings.Internal.Frame* i_frame) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.Frame*, void>)0x00514B90)(ref this, i_frame);

    /// <summary>
    /// <code>Offset: 0x00514C20
    /// void __thiscall CPhysicsObj::set_initial_frame(CPhysicsObj*,const Frame*)</code>
    /// </summary>
    public void set_initial_frame(ACBindings.Internal.Frame* frame) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.Frame*, void>)0x00514C20)(ref this, frame);

    /// <summary>
    /// <code>Offset: 0x00514C60
    /// void __thiscall CPhysicsObj::set_heading(CPhysicsObj*,float,int)</code>
    /// </summary>
    public void set_heading(float degrees, int send_event) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, float, int, void>)0x00514C60)(ref this, degrees, send_event);

    /// <summary>
    /// <code>Offset: 0x00514CA0
    /// void __thiscall CPhysicsObj::store_position(CPhysicsObj*,const Position*)</code>
    /// </summary>
    public void store_position(ACBindings.Internal.Position* p) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.Position*, void>)0x00514CA0)(ref this, p);

    /// <summary>
    /// <code>Offset: 0x00514D20
    /// void __thiscall CPhysicsObj::leave_visibility(CPhysicsObj*)</code>
    /// </summary>
    public void leave_visibility() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, void>)0x00514D20)(ref this);

    /// <summary>
    /// <code>Offset: 0x00514FB0
    /// CPhysicsObj* __cdecl CPhysicsObj::makeObject(const CPhysicsObj*)</code>
    /// </summary>
    public static ACBindings.Internal.CPhysicsObj* makeObject(ACBindings.Internal.CPhysicsObj* pTemplate) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CPhysicsObj*, ACBindings.Internal.CPhysicsObj*>)0x00514FB0)(pTemplate);

    /// <summary>
    /// <code>Offset: 0x00515020
    /// void __thiscall CPhysicsObj::update_position(CPhysicsObj*)</code>
    /// </summary>
    public void update_position() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, void>)0x00515020)(ref this);

    /// <summary>
    /// <code>Offset: 0x00515120
    /// void __thiscall CPhysicsObj::report_collision_end(CPhysicsObj*,const int)</code>
    /// </summary>
    public void report_collision_end(int force_end) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, int, void>)0x00515120)(ref this, force_end);

    /// <summary>
    /// <code>Offset: 0x00515280
    /// int __thiscall CPhysicsObj::handle_all_collisions(CPhysicsObj*,const COLLISIONINFO*,int,int)</code>
    /// </summary>
    public int handle_all_collisions(ACBindings.Internal.COLLISIONINFO* collisions, int prev_has_contact, int prev_on_walkable) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.COLLISIONINFO*, int, int, int>)0x00515280)(ref this, collisions, prev_has_contact, prev_on_walkable);

    /// <summary>
    /// <code>Offset: 0x005154E0
    /// void __thiscall CPhysicsObj::AddObjectToSingleCell(CPhysicsObj*,CObjCell*)</code>
    /// </summary>
    public void AddObjectToSingleCell(ACBindings.Internal.CObjCell* obj_cell) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.CObjCell*, void>)0x005154E0)(ref this, obj_cell);

    /// <summary>
    /// <code>Offset: 0x00515570
    /// void __thiscall CPhysicsObj::add_particle_shadow_to_cell(CPhysicsObj*)</code>
    /// </summary>
    public void add_particle_shadow_to_cell() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, void>)0x00515570)(ref this);

    /// <summary>
    /// <code>Offset: 0x005155E0
    /// void __thiscall CPhysicsObj::add_shadows_to_cells(CPhysicsObj*,const CELLARRAY*)</code>
    /// </summary>
    public void add_shadows_to_cells(ACBindings.Internal.CELLARRAY* cell_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.CELLARRAY*, void>)0x005155E0)(ref this, cell_array);

    /// <summary>
    /// <code>Offset: 0x00515720
    /// void __thiscall CPhysicsObj::add_anim_hook(CPhysicsObj*,CAnimHook*)</code>
    /// </summary>
    public void add_anim_hook(ACBindings.Internal.CAnimHook* hook) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.CAnimHook*, void>)0x00515720)(ref this, hook);

    /// <summary>
    /// <code>Offset: 0x00515760
    /// void __thiscall CPhysicsObj::set_hidden(CPhysicsObj*,int,int)</code>
    /// </summary>
    public void set_hidden(int hidden, int send_event) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, int, int, void>)0x00515760)(ref this, hidden, send_event);

    /// <summary>
    /// <code>Offset: 0x005158D0
    /// int __thiscall CPhysicsObj::set_state(CPhysicsObj*,unsigned int,int)</code>
    /// </summary>
    public int set_state(uint new_state, int send_event) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, uint, int, int>)0x005158D0)(ref this, new_state, send_event);

    /// <summary>
    /// <code>Offset: 0x00515960
    /// void __thiscall CPhysicsObj::exit_world(CPhysicsObj*)</code>
    /// </summary>
    public void exit_world() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, void>)0x00515960)(ref this);

    /// <summary>
    /// <code>Offset: 0x005159D0
    /// void __thiscall CPhysicsObj::teleport_hook(CPhysicsObj*,int)</code>
    /// </summary>
    public void teleport_hook(int hide) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, int, void>)0x005159D0)(ref this, hide);

    /// <summary>
    /// <code>Offset: 0x00515A40
    /// int __thiscall CPhysicsObj::set_description(CPhysicsObj*,const PhysicsDesc*,int)</code>
    /// </summary>
    public int set_description(ACBindings.Internal.PhysicsDesc* desc, int set_movement) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.PhysicsDesc*, int, int>)0x00515A40)(ref this, desc, set_movement);

    /// <summary>
    /// <code>Offset: 0x00515C60
    /// void __thiscall CPhysicsObj::calc_cross_cells_static(CPhysicsObj*)</code>
    /// </summary>
    public void calc_cross_cells_static() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, void>)0x00515C60)(ref this);

    /// <summary>
    /// <code>Offset: 0x00515D30
    /// void __thiscall CPhysicsObj::calc_cross_cells(CPhysicsObj*)</code>
    /// </summary>
    public void calc_cross_cells() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, void>)0x00515D30)(ref this);

    /// <summary>
    /// <code>Offset: 0x00515E30
    /// int __thiscall CPhysicsObj::SetPositionInternal(CPhysicsObj*,const CTransition*)</code>
    /// </summary>
    public int SetPositionInternal(ACBindings.Internal.CTransition* transit) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.CTransition*, int>)0x00515E30)(ref this, transit);

    /// <summary>
    /// <code>Offset: 0x005160A0
    /// void __thiscall CPhysicsObj::leave_world(CPhysicsObj*)</code>
    /// </summary>
    public void leave_world() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, void>)0x005160A0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00516160
    /// SetPositionError __thiscall CPhysicsObj::ForceIntoCell(CPhysicsObj*,CObjCell*,const Position*)</code>
    /// </summary>
    public ACBindings.Internal.SetPositionError ForceIntoCell(ACBindings.Internal.CObjCell* pNewCell, ACBindings.Internal.Position* pos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.CObjCell*, ACBindings.Internal.Position*, ACBindings.Internal.SetPositionError>)0x00516160)(ref this, pNewCell, pos);

    /// <summary>
    /// <code>Offset: 0x005161B0
    /// void __thiscall CPhysicsObj::UpdateObjectInternal(CPhysicsObj*,float)</code>
    /// </summary>
    public void UpdateObjectInternal(float quantum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, float, void>)0x005161B0)(ref this, quantum);

    /// <summary>
    /// <code>Offset: 0x005164E0
    /// void __thiscall CPhysicsObj::add_obj_to_cell(CPhysicsObj*,CObjCell*,const Frame*)</code>
    /// </summary>
    public void add_obj_to_cell(ACBindings.Internal.CObjCell* new_cell, ACBindings.Internal.Frame* new_frame) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.CObjCell*, ACBindings.Internal.Frame*, void>)0x005164E0)(ref this, new_cell, new_frame);

    /// <summary>
    /// <code>Offset: 0x00516530
    /// void __thiscall CPhysicsObj::recalc_cross_cells(CPhysicsObj*)</code>
    /// </summary>
    public void recalc_cross_cells() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, void>)0x00516530)(ref this);

    /// <summary>
    /// <code>Offset: 0x00516590
    /// int __thiscall CPhysicsObj::set_parent(CPhysicsObj*,CPhysicsObj*,unsigned int)</code>
    /// </summary>
    public int set_parent(ACBindings.Internal.CPhysicsObj* obj, uint where) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.CPhysicsObj*, uint, int>)0x00516590)(ref this, obj, where);

    /// <summary>
    /// <code>Offset: 0x00516650
    /// int __thiscall CPhysicsObj::set_parent(CPhysicsObj*,CPhysicsObj*,unsigned int,const Frame*)</code>
    /// </summary>
    public int set_parent(ACBindings.Internal.CPhysicsObj* obj, uint part_index, ACBindings.Internal.Frame* frame) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.CPhysicsObj*, uint, ACBindings.Internal.Frame*, int>)0x00516650)(ref this, obj, part_index, frame);

    /// <summary>
    /// <code>Offset: 0x005166D0
    /// SetPositionError __thiscall CPhysicsObj::SetPositionInternal(CPhysicsObj*,Position*,const SetPositionStruct*,CTransition*)</code>
    /// </summary>
    public ACBindings.Internal.SetPositionError SetPositionInternal(ACBindings.Internal.Position* p, ACBindings.Internal.SetPositionStruct* sps, ACBindings.Internal.CTransition* transit) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.Position*, ACBindings.Internal.SetPositionStruct*, ACBindings.Internal.CTransition*, ACBindings.Internal.SetPositionError>)0x005166D0)(ref this, p, sps, transit);

    /// <summary>
    /// <code>Offset: 0x00516810
    /// void __thiscall CPhysicsObj::update_object(CPhysicsObj*)</code>
    /// </summary>
    public void update_object() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, void>)0x00516810)(ref this);

    /// <summary>
    /// <code>Offset: 0x00516A00
    /// SetPositionError __thiscall CPhysicsObj::SetScatterPositionInternal(CPhysicsObj*,const SetPositionStruct*,CTransition*)</code>
    /// </summary>
    public ACBindings.Internal.SetPositionError SetScatterPositionInternal(ACBindings.Internal.SetPositionStruct* sps, ACBindings.Internal.CTransition* transit) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.SetPositionStruct*, ACBindings.Internal.CTransition*, ACBindings.Internal.SetPositionError>)0x00516A00)(ref this, sps, transit);

    /// <summary>
    /// <code>Offset: 0x00516B40
    /// SetPositionError __thiscall CPhysicsObj::SetPositionInternal(CPhysicsObj*,const SetPositionStruct*,CTransition*)</code>
    /// </summary>
    public ACBindings.Internal.SetPositionError SetPositionInternal(ACBindings.Internal.SetPositionStruct* sps, ACBindings.Internal.CTransition* transit) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.SetPositionStruct*, ACBindings.Internal.CTransition*, ACBindings.Internal.SetPositionError>)0x00516B40)(ref this, sps, transit);

    /// <summary>
    /// <code>Offset: 0x00516BC0
    /// SetPositionError __thiscall CPhysicsObj::SetPosition(CPhysicsObj*,SetPositionStruct*)</code>
    /// </summary>
    public ACBindings.Internal.SetPositionError SetPosition(ACBindings.Internal.SetPositionStruct* sps) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.SetPositionStruct*, ACBindings.Internal.SetPositionError>)0x00516BC0)(ref this, sps);

    /// <summary>
    /// <code>Offset: 0x00516C70
    /// int __thiscall CPhysicsObj::enter_world(CPhysicsObj*,const int)</code>
    /// </summary>
    public int enter_world(int slide) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, int, int>)0x00516C70)(ref this, slide);

    /// <summary>
    /// <code>Offset: 0x00516D50
    /// int __thiscall CPhysicsObj::reenter_visibility(CPhysicsObj*)</code>
    /// </summary>
    public int reenter_visibility() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, int>)0x00516D50)(ref this);

    /// <summary>
    /// <code>Offset: 0x00516DB0
    /// SetPositionError __thiscall CPhysicsObj::SetPositionSimple(CPhysicsObj*,const Position*,int)</code>
    /// </summary>
    public ACBindings.Internal.SetPositionError SetPositionSimple(ACBindings.Internal.Position* p, int sliding) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.Position*, int, ACBindings.Internal.SetPositionError>)0x00516DB0)(ref this, p, sliding);

    /// <summary>
    /// <code>Offset: 0x00516E10
    /// int __thiscall CPhysicsObj::enter_world(CPhysicsObj*,const Position*)</code>
    /// </summary>
    public int enter_world(ACBindings.Internal.Position* p) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.Position*, int>)0x00516E10)(ref this, p);

    /// <summary>
    /// <code>Offset: 0x00516E30
    /// int __thiscall CPhysicsObj::MoveOrTeleport(CPhysicsObj*,Position*,unsigned __int16,int,const AC1Legacy::Vector3*)</code>
    /// </summary>
    public int MoveOrTeleport(ACBindings.Internal.Position* p, ushort teleport_timestamp, int contact, ACBindings.Internal.AC1Legacy.Vector3* velocity) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.Position*, ushort, int, ACBindings.Internal.AC1Legacy.Vector3*, int>)0x00516E30)(ref this, p, teleport_timestamp, contact, velocity);

    /// <summary>
    /// <code>Offset: 0x00528730
    /// int __thiscall CPhysicsObj::on_ground(CPhysicsObj*)</code>
    /// </summary>
    public int on_ground() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, int>)0x00528730)(ref this);
}

