namespace ACBindings;

// CPhysicsObj
public unsafe struct CPhysicsObj : System.IDisposable
{
    // Base Classes
    public ACBindings.LongHashData BaseClass_LongHashData; // ACBindings.LongHashData

    // Statics
    public static ACBindings.CObjectMaint* obj_maint = (ACBindings.CObjectMaint*)0x00844D64;
    public static ACBindings.CPhysicsObj* player_object = (ACBindings.CPhysicsObj*)0x00844D68;

    // Child Types
    // CPhysicsObj_vtbl
    public unsafe struct CPhysicsObj_vtbl
    {
        // Members
        public System.IntPtr CPhysicsObj_dtor_0; // function pointer

        // Methods
    }
    // CPhysicsObj::CollisionRecord
    public unsafe struct CollisionRecord
    {
        // Members
        public double touched_time;
        public int ethereal;

        // Methods
    }

    // Members
    public System.IntPtr netblob_list;
    public ACBindings.CPartArray* part_array;
    public ACBindings.AC1Legacy.Vector3 player_vector;
    public float player_distance;
    public float CYpt;
    public ACBindings.CSoundTable* sound_table;
    public byte m_bExaminationObject;
    public ACBindings.ScriptManager* script_manager;
    public ACBindings.PhysicsScriptTable* physics_script_table;
    public ACBindings.PScriptType default_script;
    public float default_script_intensity;
    public ACBindings.CPhysicsObj* parent;
    public ACBindings.CHILDLIST* children;
    public ACBindings.Position m_position;
    public ACBindings.CObjCell* cell;
    public uint num_shadow_objects;
    public ACBindings.DArray__CShadowObj shadow_objects;
    public uint state;
    public uint transient_state;
    public float elasticity;
    public float translucency;
    public float translucencyOriginal;
    public float friction;
    public float massinv;
    public ACBindings.MovementManager* movement_manager;
    public ACBindings.PositionManager* position_manager;
    public int last_move_was_autonomous;
    public int jumped_this_frame;
    public double update_time;
    public ACBindings.AC1Legacy.Vector3 m_velocityVector;
    public ACBindings.AC1Legacy.Vector3 m_accelerationVector;
    public ACBindings.AC1Legacy.Vector3 m_omegaVector;
    public ACBindings.PhysicsObjHook* hooks;
    public ACBindings.AC1Legacy.SmartArray__CAnimHook_ptr anim_hooks;
    public float m_scale;
    public float attack_radius;
    public ACBindings.DetectionManager* detection_manager;
    public ACBindings.AttackManager* attack_manager;
    public ACBindings.TargetManager* target_manager;
    public ACBindings.ParticleManager* particle_manager;
    public ACBindings.CWeenieObject* weenie_obj;
    public ACBindings.Plane contact_plane;
    public uint contact_plane_cell_id;
    public ACBindings.AC1Legacy.Vector3 sliding_normal;
    public ACBindings.AC1Legacy.Vector3 cached_velocity;
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
    // int __cdecl CPhysicsObj::is_newer(unsigned __int16,unsigned __int16)
    public static int is_newer(ushort timestamp, ushort new_time) => ((delegate* unmanaged[Cdecl]<ushort, ushort, int>)0x00451B10)(timestamp, new_time);
    // int __thiscall CPhysicsObj::newer_event(CPhysicsObj*,PhysicsTimeStamp,unsigned __int16)
    public int newer_event(ACBindings.PhysicsTimeStamp stamp, ushort new_time) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, ACBindings.PhysicsTimeStamp, ushort, int>)0x00451B50)(ref this, stamp, new_time);
    // const Frame* __thiscall CPhysicsObj::get_frame(CPhysicsObj*)
    public ACBindings.Frame* get_frame() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, ACBindings.Frame*>)0x00452950)(ref this);
    // BOOL __thiscall CPhysicsObj::makeAnimObject(CPhysicsObj*,int,int)
    public byte makeAnimObject(int a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, int, int, byte>)0x0050F400)(ref this, a2, a3);
    // unsigned int* __thiscall CPhysicsObj::GetSetupID(_DWORD*,unsigned int*)
    public uint* GetSetupID(uint* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, uint*, uint*>)0x0050F430)(ref this, a2);
    // unsigned int* __thiscall CPhysicsObj::GetDataID(_DWORD*,unsigned int*)
    public uint* GetDataID(uint* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, uint*, uint*>)0x0050F460)(ref this, a2);
    // float __thiscall CPhysicsObj::GetRadius(CPhysicsObj*)
    public float GetRadius() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, float>)0x0050F490)(ref this);
    // float __thiscall CPhysicsObj::GetHeight(CPhysicsObj*)
    public float GetHeight() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, float>)0x0050F4B0)(ref this);
    // float __thiscall CPhysicsObj::GetStepUpHeight(CPhysicsObj*)
    public float GetStepUpHeight() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, float>)0x0050F4D0)(ref this);
    // float __thiscall CPhysicsObj::GetStepDownHeight(CPhysicsObj*)
    public float GetStepDownHeight() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, float>)0x0050F4F0)(ref this);
    // int __thiscall CPhysicsObj::GetSelectionSphere(CPhysicsObj*,CSphere*)
    public int GetSelectionSphere(ACBindings.CSphere* selection_sphere) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, ACBindings.CSphere*, int>)0x0050F510)(ref this, selection_sphere);
    // void __thiscall CPhysicsObj::InitializeMotionTables(CPhysicsObj*)
    public void InitializeMotionTables() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, void>)0x0050F530)(ref this);
    // unsigned int __thiscall CPhysicsObj::DoInterpretedMotion(CPhysicsObj*,unsigned int,const MovementParameters*)
    public uint DoInterpretedMotion(uint motion, ACBindings.MovementParameters* params_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, uint, ACBindings.MovementParameters*, uint>)0x0050F540)(ref this, motion, params_);
    // unsigned int __thiscall CPhysicsObj::StopInterpretedMotion(CPhysicsObj*,unsigned int,const MovementParameters*)
    public uint StopInterpretedMotion(uint motion, ACBindings.MovementParameters* params_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, uint, ACBindings.MovementParameters*, uint>)0x0050F560)(ref this, motion, params_);
    // int __thiscall CPhysicsObj::motions_pending(CPhysicsObj*)
    public int motions_pending() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, int>)0x0050F580)(ref this);
    // void __thiscall CPhysicsObj::StopCompletely_Internal(CPhysicsObj*)
    public void StopCompletely_Internal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, void>)0x0050F5A0)(ref this);
    // void __thiscall CPhysicsObj::unstick_from_object(CPhysicsObj*)
    public void unstick_from_object() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, void>)0x0050F5B0)(ref this);
    // unsigned int __thiscall CPhysicsObj::get_sticky_object_id(CPhysicsObj*)
    public uint get_sticky_object_id() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, uint>)0x0050F5C0)(ref this);
    // int __thiscall CPhysicsObj::IsMovingTo(CPhysicsObj*)
    public int IsMovingTo() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, int>)0x0050F5E0)(ref this);
    // int __thiscall CPhysicsObj::movement_is_autonomous(CPhysicsObj*)
    public int movement_is_autonomous() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, int>)0x0050F600)(ref this);
    // void __thiscall CPhysicsObj::StopInterpolating(CPhysicsObj*)
    public void StopInterpolating() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, void>)0x0050F610)(ref this);
    // int __thiscall CPhysicsObj::IsInterpolating(CPhysicsObj*)
    public int IsInterpolating() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, int>)0x0050F620)(ref this);
    // float __thiscall CPhysicsObj::GetAutonomyBlipDistance(CPhysicsObj*)
    public float GetAutonomyBlipDistance() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, float>)0x0050F640)(ref this);
    // float __thiscall CPhysicsObj::GetStartConstraintDistance(CPhysicsObj*)
    public float GetStartConstraintDistance() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, float>)0x0050F690)(ref this);
    // float __thiscall CPhysicsObj::GetMaxConstraintDistance(CPhysicsObj*)
    public float GetMaxConstraintDistance() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, float>)0x0050F6E0)(ref this);
    // int __thiscall CPhysicsObj::IsFullyConstrained(CPhysicsObj*)
    public int IsFullyConstrained() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, int>)0x0050F730)(ref this);
    // unsigned int __thiscall CPhysicsObj::check_attack(CPhysicsObj*,const Position*,const float,const AttackCone*,float)
    public uint check_attack(ACBindings.Position* attacker_pos, float attacker_scale, ACBindings.AttackCone* attack_cone, float attacker_attack_radius) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, ACBindings.Position*, float, ACBindings.AttackCone*, float, uint>)0x0050F750)(ref this, attacker_pos, attacker_scale, attack_cone, attacker_attack_radius);
    // void __thiscall CPhysicsObj::set_target(CPhysicsObj*,unsigned int,unsigned int,float,long double)
    public void set_target(uint context_id, uint object_id, float radius, double quantum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, uint, uint, float, double, void>)0x0050F800)(ref this, context_id, object_id, radius, quantum);
    // void __thiscall CPhysicsObj::clear_target(CPhysicsObj*)
    public void clear_target() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, void>)0x0050F860)(ref this);
    // void __thiscall CPhysicsObj::set_target_quantum(CPhysicsObj*,long double)
    public void set_target_quantum(double new_quantum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, double, void>)0x0050F870)(ref this, new_quantum);
    // float __thiscall CPhysicsObj::get_target_quantum(CPhysicsObj*)
    public float get_target_quantum() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, float>)0x0050F890)(ref this);
    // void __thiscall CPhysicsObj::receive_target_update(CPhysicsObj*,const TargetInfo*)
    public void receive_target_update(ACBindings.TargetInfo* info) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, ACBindings.TargetInfo*, void>)0x0050F8B0)(ref this, info);
    // void __thiscall CPhysicsObj::add_voyeur(CPhysicsObj*,unsigned int,float,float)
    public void add_voyeur(uint object_id, float radius, float quantum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, uint, float, float, void>)0x0050F8D0)(ref this, object_id, radius, quantum);
    // int __thiscall CPhysicsObj::remove_voyeur(CPhysicsObj*,unsigned int)
    public int remove_voyeur(uint object_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, uint, int>)0x0050F920)(ref this, object_id);
    // void __thiscall CPhysicsObj::calc_friction(CPhysicsObj*,float,float)
    public void calc_friction(float quantum, float velocity_mag2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, float, float, void>)0x0050F940)(ref this, quantum, velocity_mag2);
    // TransitionState __thiscall CPhysicsObj::FindObjCollisions(CPhysicsObj*,CTransition*)
    public ACBindings.TransitionState FindObjCollisions(ACBindings.CTransition* transition) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, ACBindings.CTransition*, ACBindings.TransitionState>)0x0050FB20)(ref this, transition);
    // void __thiscall CPhysicsObj::UpdateViewerDistance(CPhysicsObj*,float,const AC1Legacy::Vector3*)
    public void UpdateViewerDistance(float CYpt, ACBindings.AC1Legacy.Vector3* viewer_heading) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, float, ACBindings.AC1Legacy.Vector3*, void>)0x0050FE10)(ref this, CYpt, viewer_heading);
    // unsigned int __thiscall CPhysicsObj::create_particle_emitter(CPhysicsObj*,int,unsigned int,Frame*,unsigned int)
    public uint create_particle_emitter(int a2, uint a3, ACBindings.Frame* a4, uint a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, int, uint, ACBindings.Frame*, uint, uint>)0x0050FE30)(ref this, a2, a3, a4, a5);
    // unsigned int __thiscall CPhysicsObj::create_blocking_particle_emitter(CPhysicsObj*,int,unsigned int,Frame*,unsigned int)
    public uint create_blocking_particle_emitter(int a2, uint a3, ACBindings.Frame* a4, uint a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, int, uint, ACBindings.Frame*, uint, uint>)0x0050FE80)(ref this, a2, a3, a4, a5);
    // int __thiscall CPhysicsObj::destroy_particle_emitter(CPhysicsObj*,unsigned int)
    public int destroy_particle_emitter(uint emitter_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, uint, int>)0x0050FED0)(ref this, emitter_id);
    // int __thiscall CPhysicsObj::stop_particle_emitter(CPhysicsObj*,unsigned int)
    public int stop_particle_emitter(uint emitter_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, uint, int>)0x0050FEF0)(ref this, emitter_id);
    // int __thiscall CPhysicsObj::play_sound(CPhysicsObj*,SoundType,float)
    public int play_sound(ACBindings.SoundType sound_type, float volume) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, ACBindings.SoundType, float, int>)0x0050FF30)(ref this, sound_type, volume);
    // CPhysicsObj* __cdecl CPhysicsObj::GetObjectA(unsigned int)
    public static ACBindings.CPhysicsObj* GetObjectA(uint object_id) => ((delegate* unmanaged[Cdecl]<uint, ACBindings.CPhysicsObj*>)0x0050FF60)(object_id);
    // void __cdecl CPhysicsObj::SetObjectMaintainer(CObjectMaint*)
    public static void SetObjectMaintainer(ACBindings.CObjectMaint* obj_maint) => ((delegate* unmanaged[Cdecl]<ACBindings.CObjectMaint*, void>)0x0050FF80)(obj_maint);
    // void __cdecl CPhysicsObj::SetPlayer(CPhysicsObj*)
    public static void SetPlayer(ACBindings.CPhysicsObj* new_player_object) => ((delegate* unmanaged[Cdecl]<ACBindings.CPhysicsObj*, void>)0x0050FF90)(new_player_object);
    // void __thiscall CPhysicsObj::set_weenie_obj_ptr(CPhysicsObj*,CWeenieObject*)
    public void set_weenie_obj_ptr(ACBindings.CWeenieObject* wobj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, ACBindings.CWeenieObject*, void>)0x0050FFA0)(ref this, wobj);
    // void __thiscall CPhysicsObj::set_cell_id(CPhysicsObj*,unsigned int)
    public void set_cell_id(uint new_cell_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, uint, void>)0x0050FFC0)(ref this, new_cell_id);
    // void __thiscall CPhysicsObj::remove_parts(CPhysicsObj*,CObjCell*)
    public void remove_parts(ACBindings.CObjCell* obj_cell) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, ACBindings.CObjCell*, void>)0x0050FFF0)(ref this, obj_cell);
    // int __thiscall CPhysicsObj::is_valid_walkable(CPhysicsObj*,const AC1Legacy::Vector3*)
    public int is_valid_walkable(ACBindings.AC1Legacy.Vector3* normal) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, ACBindings.AC1Legacy.Vector3*, int>)0x00510000)(ref this, normal);
    // int __thiscall CPhysicsObj::CacheHasPhysicsBSP(CPhysicsObj*)
    public int CacheHasPhysicsBSP() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, int>)0x00510040)(ref this);
    // int __thiscall CPhysicsObj::check_contact(CPhysicsObj*,int)
    public int check_contact(int contact) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, int, int>)0x00510080)(ref this, contact);
    // int __thiscall CPhysicsObj::build_collision_profile(CPhysicsObj*,ObjCollisionProfile*,const CPhysicsObj*,const AC1Legacy::Vector3*,const int,const int,const int)
    public int build_collision_profile(ACBindings.ObjCollisionProfile* prof, ACBindings.CPhysicsObj* obj, ACBindings.AC1Legacy.Vector3* vel, int amIInContact, int objIsMissile, int objHasContact) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, ACBindings.ObjCollisionProfile*, ACBindings.CPhysicsObj*, ACBindings.AC1Legacy.Vector3*, int, int, int, int>)0x005100D0)(ref this, prof, obj, vel, amIInContact, objIsMissile, objHasContact);
    // void __thiscall CPhysicsObj::UpdatePartsInternal(CPhysicsObj*)
    public void UpdatePartsInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, void>)0x00510140)(ref this);
    // int __thiscall CPhysicsObj::SetPlacementFrameInternal(CPhysicsObj*,unsigned int)
    public int SetPlacementFrameInternal(uint frame_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, uint, int>)0x00510160)(ref this, frame_id);
    // void __thiscall CPhysicsObj::set_omega(CPhysicsObj*,const AC1Legacy::Vector3*,int)
    public void set_omega(ACBindings.AC1Legacy.Vector3* new_omega, int send_event) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, ACBindings.AC1Legacy.Vector3*, int, void>)0x005101A0)(ref this, new_omega, send_event);
    // void __thiscall CPhysicsObj::set_sequence_animation(_DWORD*,unsigned int,int,int,float)
    public void set_sequence_animation(uint a2, int a3, int a4, float a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, uint, int, int, float, void>)0x005101C0)(ref this, a2, a3, a4, a5);
    // void __thiscall CPhysicsObj::clear_sequence_anims(CPhysicsObj*)
    public void clear_sequence_anims() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, void>)0x00510230)(ref this);
    // int __thiscall CPhysicsObj::HasAnims(CPhysicsObj*)
    public int HasAnims() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, int>)0x00510240)(ref this);
    // unsigned int __thiscall CPhysicsObj::get_curr_frame_number(CPhysicsObj*)
    public uint get_curr_frame_number() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, uint>)0x00510250)(ref this);
    // float __thiscall CPhysicsObj::get_distance_to_object(CPhysicsObj*,CPhysicsObj*,int)
    public float get_distance_to_object(ACBindings.CPhysicsObj* object_, int use_cyls) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, ACBindings.CPhysicsObj*, int, float>)0x00510270)(ref this, object_, use_cyls);
    // int __thiscall CPhysicsObj::add_child(CPhysicsObj*,CPhysicsObj*,unsigned int)
    public int add_child(ACBindings.CPhysicsObj* obj, uint where) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, ACBindings.CPhysicsObj*, uint, int>)0x00510340)(ref this, obj, where);
    // int __thiscall CPhysicsObj::add_child(CPhysicsObj*,CPhysicsObj*,unsigned int,const Frame*)
    public int add_child(ACBindings.CPhysicsObj* obj, uint part_index, ACBindings.Frame* frame) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, ACBindings.CPhysicsObj*, uint, ACBindings.Frame*, int>)0x005103C0)(ref this, obj, part_index, frame);
    // void __thiscall CPhysicsObj::SetTranslucencyInternal(CPhysicsObj*,float)
    public void SetTranslucencyInternal(float translucency) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, float, void>)0x00510430)(ref this, translucency);
    // void __thiscall CPhysicsObj::SetNoDraw(CPhysicsObj*,int)
    public void SetNoDraw(int no_draw) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, int, void>)0x00510470)(ref this, no_draw);
    // int __thiscall CPhysicsObj::DoObjDescChangesFromDefault(CPhysicsObj*,const ObjDesc*)
    public int DoObjDescChangesFromDefault(ACBindings.ObjDesc* objdesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, ACBindings.ObjDesc*, int>)0x00510480)(ref this, objdesc);
    // int __thiscall CPhysicsObj::DoObjDescChanges(CPhysicsObj*,const ObjDesc*)
    public int DoObjDescChanges(ACBindings.ObjDesc* objdesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, ACBindings.ObjDesc*, int>)0x00510500)(ref this, objdesc);
    // int __thiscall CPhysicsObj::MorphToExistingObject(CPhysicsObj*,const CPhysicsObj*)
    public int MorphToExistingObject(ACBindings.CPhysicsObj* pObj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, ACBindings.CPhysicsObj*, int>)0x00510580)(ref this, pObj);
    // void __thiscall CPhysicsObj::SetTranslucency2(CPhysicsObj*,float,float,long double)
    public void SetTranslucency2(float start_translucency, float end_translucency, double delta) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, float, float, double, void>)0x00510620)(ref this, start_translucency, end_translucency, delta);
    // void __thiscall CPhysicsObj::SetTextureVelocity(CPhysicsObj*,float,float)
    public void SetTextureVelocity(float du, float dv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, float, float, void>)0x005106F0)(ref this, du, dv);
    // void __thiscall CPhysicsObj::SetPartTextureVelocity(CPhysicsObj*,unsigned int,float,float)
    public void SetPartTextureVelocity(uint part_index, float du, float dv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, uint, float, float, void>)0x00510700)(ref this, part_index, du, dv);
    // int __thiscall CPhysicsObj::set_active(CPhysicsObj*,int)
    public int set_active(int active) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, int, int>)0x00510710)(ref this, active);
    // int __thiscall CPhysicsObj::set_nodraw(CPhysicsObj*,int,int)
    public int set_nodraw(int nodraw, int send_event) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, int, int, int>)0x00510770)(ref this, nodraw, send_event);
    // void __thiscall CPhysicsObj::set_lights(CPhysicsObj*,int,int)
    public void set_lights(int lights_on, int send_event) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, int, int, void>)0x005107C0)(ref this, lights_on, send_event);
    // int __thiscall CPhysicsObj::set_elasticity(CPhysicsObj*,float)
    public int set_elasticity(float elasticity) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, float, int>)0x00510810)(ref this, elasticity);
    // void __thiscall CPhysicsObj::Hook_AnimDone(CPhysicsObj*)
    public void Hook_AnimDone() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, void>)0x00510870)(ref this);
    // void __thiscall CPhysicsObj::MotionDone(CPhysicsObj*,unsigned int,int)
    public void MotionDone(uint motion, int success) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, uint, int, void>)0x00510880)(ref this, motion, success);
    // const RawMotionState* __thiscall CPhysicsObj::InqRawMotionState(CPhysicsObj*)
    public ACBindings.RawMotionState* InqRawMotionState() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, ACBindings.RawMotionState*>)0x005108B0)(ref this);
    // const InterpretedMotionState* __thiscall CPhysicsObj::InqInterpretedMotionState(CPhysicsObj*)
    public ACBindings.InterpretedMotionState* InqInterpretedMotionState() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, ACBindings.InterpretedMotionState*>)0x005108D0)(ref this);
    // void __thiscall CPhysicsObj::RemoveLinkAnimations(CPhysicsObj*)
    public void RemoveLinkAnimations() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, void>)0x005108F0)(ref this);
    // void __thiscall CPhysicsObj::CheckForCompletedMotions(CPhysicsObj*)
    public void CheckForCompletedMotions() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, void>)0x00510900)(ref this);
    // bool __thiscall CPhysicsObj::GetBoundingBox(CPhysicsObj*,BBox*)
    public byte GetBoundingBox(ACBindings.BBox* o_bbox) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, ACBindings.BBox*, byte>)0x00510910)(ref this, o_bbox);
    // bool __thiscall CPhysicsObj::ShouldDrawParticles(CPhysicsObj*,float)
    public byte ShouldDrawParticles(float i_fDegradeDistance) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, float, byte>)0x00510930)(ref this, i_fDegradeDistance);
    // int __thiscall CPhysicsObj::InitObjectBegin(CPhysicsObj*,unsigned int,int)
    public int InitObjectBegin(uint object_iid, int bDynamic) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, uint, int, int>)0x00510A50)(ref this, object_iid, bDynamic);
    // int __thiscall CPhysicsObj::InitObjectEnd(CPhysicsObj*)
    public int InitObjectEnd() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, int>)0x00510AB0)(ref this);
    // unsigned int __thiscall CPhysicsObj::DoMotion(CPhysicsObj*,unsigned int,const MovementParameters*,int)
    public uint DoMotion(uint motion, ACBindings.MovementParameters* params_, int send_event) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, uint, ACBindings.MovementParameters*, int, uint>)0x00510AF0)(ref this, motion, params_, send_event);
    // unsigned int __thiscall CPhysicsObj::StopMotion(CPhysicsObj*,unsigned int,const MovementParameters*,int)
    public uint StopMotion(uint motion, ACBindings.MovementParameters* params_, int send_event) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, uint, ACBindings.MovementParameters*, int, uint>)0x00510BA0)(ref this, motion, params_, send_event);
    // void __thiscall CPhysicsObj::StopCompletely(CPhysicsObj*,int)
    public void StopCompletely(int send_event) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, int, void>)0x00510C50)(ref this, send_event);
    // void __thiscall CPhysicsObj::cancel_moveto(CPhysicsObj*)
    public void cancel_moveto() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, void>)0x00510CC0)(ref this);
    // void __thiscall CPhysicsObj::MakePositionManager(CPhysicsObj*)
    public void MakePositionManager() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, void>)0x00510CE0)(ref this);
    // void __thiscall CPhysicsObj::MakeMovementManager(CPhysicsObj*,int)
    public void MakeMovementManager(int init_motion) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, int, void>)0x00510D40)(ref this, init_motion);
    // void __thiscall CPhysicsObj::MoveToObject_Internal(CPhysicsObj*,unsigned int,unsigned int,float,float,const MovementParameters*)
    public void MoveToObject_Internal(uint object_id, uint top_level_id, float object_radius, float object_height, ACBindings.MovementParameters* params_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, uint, uint, float, float, ACBindings.MovementParameters*, void>)0x00510DB0)(ref this, object_id, top_level_id, object_radius, object_height, params_);
    // void __thiscall CPhysicsObj::TurnToObject_Internal(CPhysicsObj*,unsigned int,unsigned int,const MovementParameters*)
    public void TurnToObject_Internal(uint object_id, uint top_level_id, ACBindings.MovementParameters* params_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, uint, uint, ACBindings.MovementParameters*, void>)0x00510EC0)(ref this, object_id, top_level_id, params_);
    // void __thiscall CPhysicsObj::InterpolateTo(CPhysicsObj*,const Position*,int)
    public void InterpolateTo(ACBindings.Position* p, int keep_heading) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, ACBindings.Position*, int, void>)0x00510FC0)(ref this, p, keep_heading);
    // void __thiscall CPhysicsObj::ConstrainTo(CPhysicsObj*,const Position*,float,float)
    public void ConstrainTo(ACBindings.Position* p, float start_distance, float max_distance) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, ACBindings.Position*, float, float, void>)0x00510FF0)(ref this, p, start_distance, max_distance);
    // void __thiscall CPhysicsObj::report_attacks(CPhysicsObj*,AttackInfo*)
    public void report_attacks(ACBindings.AttackInfo* attack_info) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, ACBindings.AttackInfo*, void>)0x00511010)(ref this, attack_info);
    // void __thiscall CPhysicsObj::receive_detection_update(CPhysicsObj*,const DetectionInfo*)
    public void receive_detection_update(ACBindings.DetectionInfo* info) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, ACBindings.DetectionInfo*, void>)0x005110A0)(ref this, info);
    // void __thiscall CPhysicsObj::UpdatePhysicsInternal(CPhysicsObj*,float,Frame*)
    public void UpdatePhysicsInternal(float quantum, ACBindings.Frame* offset_frame) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, float, ACBindings.Frame*, void>)0x005111D0)(ref this, quantum, offset_frame);
    // void __thiscall CPhysicsObj::calc_acceleration(CPhysicsObj*)
    public void calc_acceleration() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, void>)0x00511420)(ref this);
    // int __thiscall CPhysicsObj::ethereal_check_for_collisions(CPhysicsObj*)
    public int ethereal_check_for_collisions() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, int>)0x00511510)(ref this);
    // int __thiscall CPhysicsObj::report_object_collision_end(CPhysicsObj*,const unsigned int)
    public int report_object_collision_end(uint object_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, uint, int>)0x00511560)(ref this, object_id);
    // void __thiscall CPhysicsObj::UpdateViewerDistance(CPhysicsObj*)
    public void UpdateViewerDistance() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, void>)0x00511600)(ref this);
    // void __thiscall CPhysicsObj::UpdateViewerDistanceRecursive(CPhysicsObj*)
    public void UpdateViewerDistanceRecursive() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, void>)0x00511720)(ref this);
    // void __thiscall CPhysicsObj::DrawRecursive(CPhysicsObj*)
    public void DrawRecursive() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, void>)0x00511760)(ref this);
    // int __thiscall CPhysicsObj::play_script_internal(CPhysicsObj*,int)
    public int play_script_internal(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, int, int>)0x005117A0)(ref this, a2);
    // int __thiscall CPhysicsObj::play_script(CPhysicsObj*,int)
    public int play_script(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, int, int>)0x00511800)(ref this, a2);
    // void __thiscall CPhysicsObj::destroy_particle_manager(CPhysicsObj*)
    public void destroy_particle_manager() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, void>)0x00511820)(ref this);
    // int __thiscall CPhysicsObj::get_landscape_coord(CPhysicsObj*,int*,int*)
    public int get_landscape_coord(int* x, int* y) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, int*, int*, int>)0x00511850)(ref this, x, y);
    // void __thiscall CPhysicsObj::set_cell_id_recursive(CPhysicsObj*,unsigned int)
    public void set_cell_id_recursive(uint new_cell_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, uint, void>)0x00511870)(ref this, new_cell_id);
    // void __thiscall CPhysicsObj::AddPartToShadowCells(CPhysicsObj*,CPhysicsPart*)
    public void AddPartToShadowCells(ACBindings.CPhysicsPart* part) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, ACBindings.CPhysicsPart*, void>)0x005118D0)(ref this, part);
    // void __thiscall CPhysicsObj::RemovePartFromShadowCells(CPhysicsObj*,CPhysicsPart*)
    public void RemovePartFromShadowCells(ACBindings.CPhysicsPart* part) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, ACBindings.CPhysicsPart*, void>)0x00511940)(ref this, part);
    // void __thiscall CPhysicsObj::enter_cell(CPhysicsObj*,CObjCell*)
    public void enter_cell(ACBindings.CObjCell* new_cell) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, ACBindings.CObjCell*, void>)0x005119A0)(ref this, new_cell);
    // void __thiscall CPhysicsObj::leave_cell(CPhysicsObj*,int)
    public void leave_cell(int is_changing_cell) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, int, void>)0x00511A20)(ref this, is_changing_cell);
    // void __thiscall CPhysicsObj::find_bbox_cell_list(CPhysicsObj*,CELLARRAY*)
    public void find_bbox_cell_list(ACBindings.CELLARRAY* cell_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, ACBindings.CELLARRAY*, void>)0x00511A90)(ref this, cell_array);
    // int __thiscall CPhysicsObj::obj_within_block(CPhysicsObj*)
    public int obj_within_block() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, int>)0x00511B00)(ref this);
    // void __thiscall CPhysicsObj::remove_shadows_from_cells(CPhysicsObj*)
    public void remove_shadows_from_cells() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, void>)0x00511D00)(ref this);
    // int __thiscall CPhysicsObj::is_completely_visible(CPhysicsObj*)
    public int is_completely_visible() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, int>)0x00511D90)(ref this);
    // void __thiscall CPhysicsObj::set_on_walkable(CPhysicsObj*,int)
    public void set_on_walkable(int is_on_walkable) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, int, void>)0x00511DE0)(ref this, is_on_walkable);
    // int __thiscall CPhysicsObj::SetPlacementFrame(CPhysicsObj*,unsigned int,int)
    public int SetPlacementFrame(uint frame_id, int send_event) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, uint, int, int>)0x00511E50)(ref this, frame_id, send_event);
    // AC1Legacy::Vector3* __thiscall CPhysicsObj::get_velocity(CPhysicsObj*,AC1Legacy::Vector3*)
    public ACBindings.AC1Legacy.Vector3* get_velocity(ACBindings.AC1Legacy.Vector3* result) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, ACBindings.AC1Legacy.Vector3*, ACBindings.AC1Legacy.Vector3*>)0x00511E90)(ref this, result);
    // void __thiscall CPhysicsObj::set_velocity(CPhysicsObj*,const AC1Legacy::Vector3*,int)
    public void set_velocity(ACBindings.AC1Legacy.Vector3* new_velocity, int send_event) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, ACBindings.AC1Legacy.Vector3*, int, void>)0x00511EC0)(ref this, new_velocity, send_event);
    // void __thiscall CPhysicsObj::set_local_velocity(CPhysicsObj*,const AC1Legacy::Vector3*,int)
    public void set_local_velocity(ACBindings.AC1Legacy.Vector3* new_velocity, int send_event) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, ACBindings.AC1Legacy.Vector3*, int, void>)0x00511FA0)(ref this, new_velocity, send_event);
    // float __thiscall CPhysicsObj::get_heading(CPhysicsObj*)
    public float get_heading() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, float>)0x00512010)(ref this);
    // void __thiscall CPhysicsObj::process_hooks(CPhysicsObj*)
    public void process_hooks() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, void>)0x00512020)(ref this);
    // void __thiscall CPhysicsObj::SetTranslucency(CPhysicsObj*,float,long double)
    public void SetTranslucency(float translucency, double delta) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, float, double, void>)0x005120C0)(ref this, translucency, delta);
    // void __thiscall CPhysicsObj::SetTranslucencyHierarchical(CPhysicsObj*,float)
    public void SetTranslucencyHierarchical(float translucency) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, float, void>)0x00512190)(ref this, translucency);
    // void __thiscall CPhysicsObj::SetPartTranslucency(CPhysicsObj*,unsigned int,float,float,long double)
    public void SetPartTranslucency(uint part_index, float start_trans, float end_trans, double delta) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, uint, float, float, double, void>)0x00512200)(ref this, part_index, start_trans, end_trans, delta);
    // void __thiscall CPhysicsObj::SetPartLuminosity(CPhysicsObj*,unsigned int,float,float,long double)
    public void SetPartLuminosity(uint part, float start, float end, double delta) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, uint, float, float, double, void>)0x005122B0)(ref this, part, start, end, delta);
    // void __thiscall CPhysicsObj::SetLuminosity(CPhysicsObj*,float,float,long double)
    public void SetLuminosity(float start, float end, double delta) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, float, float, double, void>)0x00512360)(ref this, start, end, delta);
    // void __thiscall CPhysicsObj::SetPartDiffusion(CPhysicsObj*,unsigned int,float,float,long double)
    public void SetPartDiffusion(uint part, float start, float end, double delta) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, uint, float, float, double, void>)0x00512400)(ref this, part, start, end, delta);
    // void __thiscall CPhysicsObj::SetDiffusion(CPhysicsObj*,float,float,long double)
    public void SetDiffusion(float start, float end, double delta) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, float, float, double, void>)0x005124B0)(ref this, start, end, delta);
    // void __thiscall CPhysicsObj::SetLighting(CPhysicsObj*,float,float)
    public void SetLighting(float luminosity, float diffuse) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, float, float, void>)0x00512550)(ref this, luminosity, diffuse);
    // int __thiscall CPhysicsObj::SetPartLighting(CPhysicsObj*,unsigned int,float,float)
    public int SetPartLighting(uint part_index, float luminosity, float diffuse) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, uint, float, float, int>)0x00512560)(ref this, part_index, luminosity, diffuse);
    // void __thiscall CPhysicsObj::RestoreLighting(CPhysicsObj*)
    public void RestoreLighting() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, void>)0x00512580)(ref this);
    // void __thiscall CPhysicsObj::CallPESInternal(CPhysicsObj*,int,float)
    public void CallPESInternal(int a2, float a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, int, float, void>)0x00512590)(ref this, a2, a3);
    // void __thiscall CPhysicsObj::CallPES(CPhysicsObj*,void*,double)
    public void CallPES(System.IntPtr user_data, double a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, System.IntPtr, double, void>)0x005125C0)(ref this, user_data, a3);
    // void __thiscall CPhysicsObj::SetScaleStatic(CPhysicsObj*,float)
    public void SetScaleStatic(float new_scale) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, float, void>)0x00512680)(ref this, new_scale);
    // int __thiscall CPhysicsObj::set_ethereal(CPhysicsObj*,int,int)
    public int set_ethereal(int ethereal, int send_event) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, int, int, int>)0x00512710)(ref this, ethereal, send_event);
    // unsigned int __thiscall CPhysicsObj::get_object_info(CPhysicsObj*,CTransition*,int)
    public uint get_object_info(ACBindings.CTransition* transit, int admin_move) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, ACBindings.CTransition*, int, uint>)0x00512790)(ref this, transit, admin_move);
    // int __cdecl CPhysicsObj::AdjustPosition(Position*,const AC1Legacy::Vector3*,CObjCell**,int,int)
    public static int AdjustPosition(ACBindings.Position* p, ACBindings.AC1Legacy.Vector3* low_pt, ACBindings.CObjCell** new_cell, int bDontCreateCells, int bSearchCells) => ((delegate* unmanaged[Cdecl]<ACBindings.Position*, ACBindings.AC1Legacy.Vector3*, ACBindings.CObjCell**, int, int, int>)0x00512850)(p, low_pt, new_cell, bDontCreateCells, bSearchCells);
    // int __thiscall CPhysicsObj::CheckPositionInternal(CPhysicsObj*,CObjCell*,Position*,CTransition*,const SetPositionStruct*)
    public int CheckPositionInternal(ACBindings.CObjCell* new_cell, ACBindings.Position* new_pos, ACBindings.CTransition* transit, ACBindings.SetPositionStruct* sps) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, ACBindings.CObjCell*, ACBindings.Position*, ACBindings.CTransition*, ACBindings.SetPositionStruct*, int>)0x00512960)(ref this, new_cell, new_pos, transit, sps);
    // int __thiscall CPhysicsObj::prepare_to_leave_visibility(CPhysicsObj*)
    public int prepare_to_leave_visibility() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, int>)0x00512A10)(ref this);
    // void __thiscall CPhysicsObj::prepare_to_enter_world(CPhysicsObj*)
    public void prepare_to_enter_world() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, void>)0x00512A70)(ref this);
    // void __thiscall CPhysicsObj::unpack_movement(CPhysicsObj*,void**,unsigned int)
    public void unpack_movement(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, void**, uint, void>)0x00512B10)(ref this, addr, size);
    // CMotionInterp* __thiscall CPhysicsObj::get_minterp(CPhysicsObj*)
    public ACBindings.CMotionInterp* get_minterp() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, ACBindings.CMotionInterp*>)0x00512B90)(ref this);
    // PositionManager* __thiscall CPhysicsObj::get_position_manager(CPhysicsObj*)
    public ACBindings.PositionManager* get_position_manager() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, ACBindings.PositionManager*>)0x00512C00)(ref this);
    // void __thiscall CPhysicsObj::get_local_physics_velocity(CPhysicsObj*,AC1Legacy::Vector3*)
    public void get_local_physics_velocity(ACBindings.AC1Legacy.Vector3* retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, ACBindings.AC1Legacy.Vector3*, void>)0x00512C10)(ref this, retval);
    // void __thiscall CPhysicsObj::CPhysicsObj(CPhysicsObj*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, void>)0x00512EF0)(ref this);
    // CPhysicsObj* __cdecl CPhysicsObj::makeNullObject(unsigned int,int)
    public static ACBindings.CPhysicsObj* makeNullObject(uint object_iid, int bDynamic) => ((delegate* unmanaged[Cdecl]<uint, int, ACBindings.CPhysicsObj*>)0x00513100)(object_iid, bDynamic);
    // CPhysicsObj* __cdecl CPhysicsObj::makeParticleObject(unsigned int,const CSphere*)
    public static ACBindings.CPhysicsObj* makeParticleObject(uint num_parts, ACBindings.CSphere* sorting_sphere) => ((delegate* unmanaged[Cdecl]<uint, ACBindings.CSphere*, ACBindings.CPhysicsObj*>)0x00513140)(num_parts, sorting_sphere);
    // int __thiscall CPhysicsObj::InitPartArrayObject(CPhysicsObj*,int,int)
    public int InitPartArrayObject(int a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, int, int, int>)0x005131B0)(ref this, a2, a3);
    // int __thiscall CPhysicsObj::SetMotionTableID(CPhysicsObj*,int)
    public int SetMotionTableID(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, int, int>)0x00513280)(ref this, a2);
    // void __thiscall CPhysicsObj::stick_to_object(CPhysicsObj*,unsigned int)
    public void stick_to_object(uint object_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, uint, void>)0x005132E0)(ref this, object_id);
    // void __thiscall CPhysicsObj::MoveToObject(CPhysicsObj*,unsigned int,const MovementParameters*)
    public void MoveToObject(uint object_id, ACBindings.MovementParameters* params_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, uint, ACBindings.MovementParameters*, void>)0x00513360)(ref this, object_id, params_);
    // void __thiscall CPhysicsObj::TurnToObject(CPhysicsObj*,unsigned int,const MovementParameters*)
    public void TurnToObject(uint object_id, ACBindings.MovementParameters* params_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, uint, ACBindings.MovementParameters*, void>)0x00513440)(ref this, object_id, params_);
    // void __thiscall CPhysicsObj::TurnToHeading(CPhysicsObj*,const MovementParameters*)
    public void TurnToHeading(ACBindings.MovementParameters* params_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, ACBindings.MovementParameters*, void>)0x00513480)(ref this, params_);
    // void __thiscall CPhysicsObj::attack(CPhysicsObj*,const AttackCone*)
    public void attack(ACBindings.AttackCone* attack_cone) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, ACBindings.AttackCone*, void>)0x00513570)(ref this, attack_cone);
    // void __thiscall CPhysicsObj::HandleUpdateTarget(CPhysicsObj*,TargetInfo)
    public void HandleUpdateTarget(ACBindings.TargetInfo target_info) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, ACBindings.TargetInfo, void>)0x005136C0)(ref this, target_info);
    // void __thiscall CPhysicsObj::UpdatePositionInternal(CPhysicsObj*,float,Frame*)
    public void UpdatePositionInternal(float quantum, ACBindings.Frame* o_newFrame) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, float, ACBindings.Frame*, void>)0x00513730)(ref this, quantum, o_newFrame);
    // void __thiscall CPhysicsObj::UpdateChild(CPhysicsObj*,CPhysicsObj*,unsigned int,const Frame*)
    public void UpdateChild(ACBindings.CPhysicsObj* child_obj, uint part_index, ACBindings.Frame* child_frame) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, ACBindings.CPhysicsObj*, uint, ACBindings.Frame*, void>)0x00513850)(ref this, child_obj, part_index, child_frame);
    // const CTransition* __thiscall CPhysicsObj::transition(CPhysicsObj*,const Position*,const Position*,int)
    public ACBindings.CTransition* transition(ACBindings.Position* old_pos, ACBindings.Position* new_pos, int admin_move) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, ACBindings.Position*, ACBindings.Position*, int, ACBindings.CTransition*>)0x005138C0)(ref this, old_pos, new_pos, admin_move);
    // int __thiscall CPhysicsObj::check_collision(CPhysicsObj*,const CPhysicsObj*)
    public int check_collision(ACBindings.CPhysicsObj* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, ACBindings.CPhysicsObj*, int>)0x005139D0)(ref this, object_);
    // int __thiscall CPhysicsObj::report_environment_collision(CPhysicsObj*,int)
    public int report_environment_collision(int prev_has_contact) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, int, int>)0x00513AC0)(ref this, prev_has_contact);
    // int __thiscall CPhysicsObj::report_object_collision(CPhysicsObj*,const CPhysicsObj*,int)
    public int report_object_collision(ACBindings.CPhysicsObj* object_, int prev_has_contact) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, ACBindings.CPhysicsObj*, int, int>)0x00513B60)(ref this, object_, prev_has_contact);
    // int __thiscall CPhysicsObj::play_script(CPhysicsObj*,PScriptType,float)
    public int play_script(ACBindings.PScriptType script_type, float mod) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, ACBindings.PScriptType, float, int>)0x00513D60)(ref this, script_type, mod);
    // int __thiscall CPhysicsObj::play_default_script(CPhysicsObj*)
    public int play_default_script() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, int>)0x00513DB0)(ref this);
    // int __thiscall CPhysicsObj::play_default_script(CPhysicsObj*,unsigned int)
    public int play_default_script(uint part_index) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, uint, int>)0x00513E00)(ref this, part_index);
    // void __thiscall CPhysicsObj::change_cell(CPhysicsObj*,CObjCell*)
    public void change_cell(ACBindings.CObjCell* new_cell) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, ACBindings.CObjCell*, void>)0x00513E90)(ref this, new_cell);
    // void __thiscall CPhysicsObj::RemoveObjectFromSingleCell(CPhysicsObj*,CObjCell*)
    public void RemoveObjectFromSingleCell(ACBindings.CObjCell* obj_cell) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, ACBindings.CObjCell*, void>)0x00513EF0)(ref this, obj_cell);
    // void __thiscall CPhysicsObj::unset_parent(CPhysicsObj*)
    public void unset_parent() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, void>)0x00513F70)(ref this);
    // void __thiscall CPhysicsObj::unparent_children(CPhysicsObj*)
    public void unparent_children() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, void>)0x00513FE0)(ref this);
    // void __thiscall CPhysicsObj::process_fp_hook(CPhysicsObj*,int,float,void*)
    public void process_fp_hook(int type, float curr_value, System.IntPtr user_data) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, int, float, System.IntPtr, void>)0x005140C0)(ref this, type, curr_value, user_data);
    // void __thiscall CPhysicsObj::SetScale(CPhysicsObj*,float,long double)
    public void SetScale(float new_scale, double delta) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, float, double, void>)0x005141A0)(ref this, new_scale, delta);
    // void __thiscall CPhysicsObj::queue_netblob(CPhysicsObj*,NetBlob*)
    public void queue_netblob(ACBindings.NetBlob* blob) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, ACBindings.NetBlob*, void>)0x00514270)(ref this, blob);
    // int __thiscall CPhysicsObj::InitNullObject(CPhysicsObj*,int)
    public int InitNullObject(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, int, int>)0x00514410)(ref this, a2);
    // CPhysicsObj* __cdecl CPhysicsObj::makeObject(int,unsigned int,int)
    public static ACBindings.CPhysicsObj* makeObject(int a1, uint object_iid, int bDynamic) => ((delegate* unmanaged[Cdecl]<int, uint, int, ACBindings.CPhysicsObj*>)0x00514470)(a1, object_iid, bDynamic);
    // void __thiscall CPhysicsObj::InitDefaults(CPhysicsObj*,const CSetup*)
    public void InitDefaults(ACBindings.CSetup* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, ACBindings.CSetup*, void>)0x005144D0)(ref this, a2);
    // void __thiscall CPhysicsObj::Destroy(CPhysicsObj*)
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, void>)0x005145D0)(ref this);
    // void __thiscall CPhysicsObj::~CPhysicsObj(CPhysicsObj*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, void>)0x00514830)(ref this);
    // void __thiscall CPhysicsObj::UpdateChildrenInternal(CPhysicsObj*)
    public void UpdateChildrenInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, void>)0x005148A0)(ref this);
    // void __thiscall CPhysicsObj::animate_static_object(CPhysicsObj*)
    public void animate_static_object() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, void>)0x005148F0)(ref this);
    // int __thiscall CPhysicsObj::track_object_collision(CPhysicsObj*,const CPhysicsObj*,int)
    public int track_object_collision(ACBindings.CPhysicsObj* object_, int prev_has_contact) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, ACBindings.CPhysicsObj*, int, int>)0x00514A10)(ref this, object_, prev_has_contact);
    // void __thiscall CPhysicsObj::report_collision_start(CPhysicsObj*)
    public void report_collision_start() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, void>)0x00514AD0)(ref this);
    // void __thiscall CPhysicsObj::set_frame(CPhysicsObj*,const Frame*)
    public void set_frame(ACBindings.Frame* i_frame) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, ACBindings.Frame*, void>)0x00514B90)(ref this, i_frame);
    // void __thiscall CPhysicsObj::set_initial_frame(CPhysicsObj*,const Frame*)
    public void set_initial_frame(ACBindings.Frame* frame) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, ACBindings.Frame*, void>)0x00514C20)(ref this, frame);
    // void __thiscall CPhysicsObj::set_heading(CPhysicsObj*,float,int)
    public void set_heading(float degrees, int send_event) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, float, int, void>)0x00514C60)(ref this, degrees, send_event);
    // void __thiscall CPhysicsObj::store_position(CPhysicsObj*,const Position*)
    public void store_position(ACBindings.Position* p) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, ACBindings.Position*, void>)0x00514CA0)(ref this, p);
    // void __thiscall CPhysicsObj::leave_visibility(CPhysicsObj*)
    public void leave_visibility() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, void>)0x00514D20)(ref this);
    // CPhysicsObj* __cdecl CPhysicsObj::makeObject(const CPhysicsObj*)
    public static ACBindings.CPhysicsObj* makeObject(ACBindings.CPhysicsObj* pTemplate) => ((delegate* unmanaged[Cdecl]<ACBindings.CPhysicsObj*, ACBindings.CPhysicsObj*>)0x00514FB0)(pTemplate);
    // void __thiscall CPhysicsObj::update_position(CPhysicsObj*)
    public void update_position() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, void>)0x00515020)(ref this);
    // void __thiscall CPhysicsObj::report_collision_end(CPhysicsObj*,const int)
    public void report_collision_end(int force_end) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, int, void>)0x00515120)(ref this, force_end);
    // int __thiscall CPhysicsObj::handle_all_collisions(CPhysicsObj*,const COLLISIONINFO*,int,int)
    public int handle_all_collisions(ACBindings.COLLISIONINFO* collisions, int prev_has_contact, int prev_on_walkable) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, ACBindings.COLLISIONINFO*, int, int, int>)0x00515280)(ref this, collisions, prev_has_contact, prev_on_walkable);
    // void __thiscall CPhysicsObj::AddObjectToSingleCell(CPhysicsObj*,CObjCell*)
    public void AddObjectToSingleCell(ACBindings.CObjCell* obj_cell) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, ACBindings.CObjCell*, void>)0x005154E0)(ref this, obj_cell);
    // void __thiscall CPhysicsObj::add_particle_shadow_to_cell(CPhysicsObj*)
    public void add_particle_shadow_to_cell() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, void>)0x00515570)(ref this);
    // void __thiscall CPhysicsObj::add_shadows_to_cells(CPhysicsObj*,const CELLARRAY*)
    public void add_shadows_to_cells(ACBindings.CELLARRAY* cell_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, ACBindings.CELLARRAY*, void>)0x005155E0)(ref this, cell_array);
    // void __thiscall CPhysicsObj::add_anim_hook(CPhysicsObj*,CAnimHook*)
    public void add_anim_hook(ACBindings.CAnimHook* hook) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, ACBindings.CAnimHook*, void>)0x00515720)(ref this, hook);
    // void __thiscall CPhysicsObj::set_hidden(CPhysicsObj*,int,int)
    public void set_hidden(int hidden, int send_event) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, int, int, void>)0x00515760)(ref this, hidden, send_event);
    // int __thiscall CPhysicsObj::set_state(CPhysicsObj*,unsigned int,int)
    public int set_state(uint new_state, int send_event) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, uint, int, int>)0x005158D0)(ref this, new_state, send_event);
    // void __thiscall CPhysicsObj::exit_world(CPhysicsObj*)
    public void exit_world() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, void>)0x00515960)(ref this);
    // void __thiscall CPhysicsObj::teleport_hook(CPhysicsObj*,int)
    public void teleport_hook(int hide) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, int, void>)0x005159D0)(ref this, hide);
    // int __thiscall CPhysicsObj::set_description(CPhysicsObj*,const PhysicsDesc*,int)
    public int set_description(ACBindings.PhysicsDesc* desc, int set_movement) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, ACBindings.PhysicsDesc*, int, int>)0x00515A40)(ref this, desc, set_movement);
    // void __thiscall CPhysicsObj::calc_cross_cells_static(CPhysicsObj*)
    public void calc_cross_cells_static() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, void>)0x00515C60)(ref this);
    // void __thiscall CPhysicsObj::calc_cross_cells(CPhysicsObj*)
    public void calc_cross_cells() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, void>)0x00515D30)(ref this);
    // int __thiscall CPhysicsObj::SetPositionInternal(CPhysicsObj*,const CTransition*)
    public int SetPositionInternal(ACBindings.CTransition* transit) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, ACBindings.CTransition*, int>)0x00515E30)(ref this, transit);
    // void __thiscall CPhysicsObj::leave_world(CPhysicsObj*)
    public void leave_world() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, void>)0x005160A0)(ref this);
    // SetPositionError __thiscall CPhysicsObj::ForceIntoCell(CPhysicsObj*,CObjCell*,const Position*)
    public ACBindings.SetPositionError ForceIntoCell(ACBindings.CObjCell* pNewCell, ACBindings.Position* pos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, ACBindings.CObjCell*, ACBindings.Position*, ACBindings.SetPositionError>)0x00516160)(ref this, pNewCell, pos);
    // void __thiscall CPhysicsObj::UpdateObjectInternal(CPhysicsObj*,float)
    public void UpdateObjectInternal(float quantum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, float, void>)0x005161B0)(ref this, quantum);
    // void __thiscall CPhysicsObj::add_obj_to_cell(CPhysicsObj*,CObjCell*,const Frame*)
    public void add_obj_to_cell(ACBindings.CObjCell* new_cell, ACBindings.Frame* new_frame) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, ACBindings.CObjCell*, ACBindings.Frame*, void>)0x005164E0)(ref this, new_cell, new_frame);
    // void __thiscall CPhysicsObj::recalc_cross_cells(CPhysicsObj*)
    public void recalc_cross_cells() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, void>)0x00516530)(ref this);
    // int __thiscall CPhysicsObj::set_parent(CPhysicsObj*,CPhysicsObj*,unsigned int)
    public int set_parent(ACBindings.CPhysicsObj* obj, uint where) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, ACBindings.CPhysicsObj*, uint, int>)0x00516590)(ref this, obj, where);
    // int __thiscall CPhysicsObj::set_parent(CPhysicsObj*,CPhysicsObj*,unsigned int,const Frame*)
    public int set_parent(ACBindings.CPhysicsObj* obj, uint part_index, ACBindings.Frame* frame) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, ACBindings.CPhysicsObj*, uint, ACBindings.Frame*, int>)0x00516650)(ref this, obj, part_index, frame);
    // SetPositionError __thiscall CPhysicsObj::SetPositionInternal(CPhysicsObj*,Position*,const SetPositionStruct*,CTransition*)
    public ACBindings.SetPositionError SetPositionInternal(ACBindings.Position* p, ACBindings.SetPositionStruct* sps, ACBindings.CTransition* transit) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, ACBindings.Position*, ACBindings.SetPositionStruct*, ACBindings.CTransition*, ACBindings.SetPositionError>)0x005166D0)(ref this, p, sps, transit);
    // void __thiscall CPhysicsObj::update_object(CPhysicsObj*)
    public void update_object() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, void>)0x00516810)(ref this);
    // SetPositionError __thiscall CPhysicsObj::SetScatterPositionInternal(CPhysicsObj*,const SetPositionStruct*,CTransition*)
    public ACBindings.SetPositionError SetScatterPositionInternal(ACBindings.SetPositionStruct* sps, ACBindings.CTransition* transit) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, ACBindings.SetPositionStruct*, ACBindings.CTransition*, ACBindings.SetPositionError>)0x00516A00)(ref this, sps, transit);
    // SetPositionError __thiscall CPhysicsObj::SetPositionInternal(CPhysicsObj*,const SetPositionStruct*,CTransition*)
    public ACBindings.SetPositionError SetPositionInternal(ACBindings.SetPositionStruct* sps, ACBindings.CTransition* transit) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, ACBindings.SetPositionStruct*, ACBindings.CTransition*, ACBindings.SetPositionError>)0x00516B40)(ref this, sps, transit);
    // SetPositionError __thiscall CPhysicsObj::SetPosition(CPhysicsObj*,SetPositionStruct*)
    public ACBindings.SetPositionError SetPosition(ACBindings.SetPositionStruct* sps) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, ACBindings.SetPositionStruct*, ACBindings.SetPositionError>)0x00516BC0)(ref this, sps);
    // int __thiscall CPhysicsObj::enter_world(CPhysicsObj*,const int)
    public int enter_world(int slide) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, int, int>)0x00516C70)(ref this, slide);
    // int __thiscall CPhysicsObj::reenter_visibility(CPhysicsObj*)
    public int reenter_visibility() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, int>)0x00516D50)(ref this);
    // SetPositionError __thiscall CPhysicsObj::SetPositionSimple(CPhysicsObj*,const Position*,int)
    public ACBindings.SetPositionError SetPositionSimple(ACBindings.Position* p, int sliding) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, ACBindings.Position*, int, ACBindings.SetPositionError>)0x00516DB0)(ref this, p, sliding);
    // int __thiscall CPhysicsObj::enter_world(CPhysicsObj*,const Position*)
    public int enter_world(ACBindings.Position* p) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, ACBindings.Position*, int>)0x00516E10)(ref this, p);
    // int __thiscall CPhysicsObj::MoveOrTeleport(CPhysicsObj*,Position*,unsigned __int16,int,const AC1Legacy::Vector3*)
    public int MoveOrTeleport(ACBindings.Position* p, ushort teleport_timestamp, int contact, ACBindings.AC1Legacy.Vector3* velocity) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, ACBindings.Position*, ushort, int, ACBindings.AC1Legacy.Vector3*, int>)0x00516E30)(ref this, p, teleport_timestamp, contact, velocity);
    // int __thiscall CPhysicsObj::on_ground(CPhysicsObj*)
    public int on_ground() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsObj, int>)0x00528730)(ref this);
}

