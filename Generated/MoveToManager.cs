namespace ACBindings.Internal;

public unsafe struct MoveToManager : System.IDisposable
{
    // Child Types
    public unsafe struct MovementNode
    {
        // Base Classes
        public ACBindings.Internal.DLListData BaseClass_DLListData; // ACBindings.Internal.DLListData

        // Members
        public ACBindings.Internal.MovementTypes.Type type;
        public float heading;

        // Methods
    }

    // Members
    public ACBindings.Internal.MovementTypes.Type movement_type;
    public ACBindings.Internal.Position sought_position;
    public ACBindings.Internal.Position current_target_position;
    public ACBindings.Internal.Position starting_position;
    public ACBindings.Internal.MovementParameters movement_params;
    public float previous_heading;
    public float previous_distance;
    public double previous_distance_time;
    public float original_distance;
    public double original_distance_time;
    public uint fail_progress_count;
    public uint sought_object_id;
    public uint top_level_object_id;
    public float sought_object_radius;
    public float sought_object_height;
    public uint current_command;
    public uint aux_command;
    public int moving_away;
    public int initialized;
    public ACBindings.Internal.DLList___MoveToManager_MovementNode pending_actions;
    public ACBindings.Internal.CPhysicsObj* physics_obj;
    public ACBindings.Internal.CWeenieObject* weenie_obj;

    // Generated Constructor
    public MoveToManager() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x00529C20
    /// unsigned int __thiscall MoveToManager::_DoMotion(MoveToManager*,unsigned int,MovementParameters*)</code>
    /// </summary>
    public uint _DoMotion(uint motion, ACBindings.Internal.MovementParameters* params_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MoveToManager, uint, ACBindings.Internal.MovementParameters*, uint>)0x00529C20)(ref this, motion, params_);

    /// <summary>
    /// <code>Offset: 0x00529C90
    /// unsigned int __thiscall MoveToManager::_StopMotion(MoveToManager*,unsigned int,MovementParameters*)</code>
    /// </summary>
    public uint _StopMotion(uint motion, ACBindings.Internal.MovementParameters* params_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MoveToManager, uint, ACBindings.Internal.MovementParameters*, uint>)0x00529C90)(ref this, motion, params_);

    /// <summary>
    /// <code>Offset: 0x00529D00
    /// int __thiscall MoveToManager::CheckProgressMade(MoveToManager*,float)</code>
    /// </summary>
    public int CheckProgressMade(float curr_distance) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MoveToManager, float, int>)0x00529D00)(ref this, curr_distance);

    /// <summary>
    /// <code>Offset: 0x00529DC0
    /// float __thiscall MoveToManager::GetCurrentDistance(MoveToManager*)</code>
    /// </summary>
    public float GetCurrentDistance() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MoveToManager, float>)0x00529DC0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00529E30
    /// int __thiscall MoveToManager::is_moving_to(MoveToManager*)</code>
    /// </summary>
    public int is_moving_to() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MoveToManager, int>)0x00529E30)(ref this);

    /// <summary>
    /// <code>Offset: 0x00529E40
    /// void __thiscall MoveToManager::SetWeenieObject(MoveToManager*,CWeenieObject*)</code>
    /// </summary>
    public void SetWeenieObject(ACBindings.Internal.CWeenieObject* wobj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MoveToManager, ACBindings.Internal.CWeenieObject*, void>)0x00529E40)(ref this, wobj);

    /// <summary>
    /// <code>Offset: 0x00529E50
    /// void __thiscall MoveToManager::SetPhysicsObject(MoveToManager*,CPhysicsObj*)</code>
    /// </summary>
    public void SetPhysicsObject(ACBindings.Internal.CPhysicsObj* pobj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MoveToManager, ACBindings.Internal.CPhysicsObj*, void>)0x00529E50)(ref this, pobj);

    /// <summary>
    /// <code>Offset: 0x00529E60
    /// void __thiscall MoveToManager::InitializeLocalVariables(MoveToManager*)</code>
    /// </summary>
    public void InitializeLocalVariables() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MoveToManager, void>)0x00529E60)(ref this);

    /// <summary>
    /// <code>Offset: 0x00529F90
    /// void __thiscall MoveToManager::RemovePendingActionsHead(MoveToManager*)</code>
    /// </summary>
    public void RemovePendingActionsHead() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MoveToManager, void>)0x00529F90)(ref this);

    /// <summary>
    /// <code>Offset: 0x00529FC0
    /// void __thiscall MoveToManager::MoveToManager(MoveToManager*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MoveToManager, void>)0x00529FC0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0052A080
    /// MoveToManager* __cdecl MoveToManager::Create(CPhysicsObj*,CWeenieObject*)</code>
    /// </summary>
    public static ACBindings.Internal.MoveToManager* Create(ACBindings.Internal.CPhysicsObj* physics_obj, ACBindings.Internal.CWeenieObject* weenie_obj) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CPhysicsObj*, ACBindings.Internal.CWeenieObject*, ACBindings.Internal.MoveToManager*>)0x0052A080)(physics_obj, weenie_obj);

    /// <summary>
    /// <code>Offset: 0x0052A0C0
    /// void __thiscall MoveToManager::Destroy(MoveToManager*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MoveToManager, void>)0x0052A0C0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0052A140
    /// void __thiscall MoveToManager::AddTurnToHeadingNode(MoveToManager*,float)</code>
    /// </summary>
    public void AddTurnToHeadingNode(float global_heading) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MoveToManager, float, void>)0x0052A140)(ref this, global_heading);

    /// <summary>
    /// <code>Offset: 0x0052A190
    /// void __thiscall MoveToManager::AddMoveToPositionNode(MoveToManager*)</code>
    /// </summary>
    public void AddMoveToPositionNode() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MoveToManager, void>)0x0052A190)(ref this);

    /// <summary>
    /// <code>Offset: 0x0052A1D0
    /// void __thiscall MoveToManager::CleanUp(MoveToManager*)</code>
    /// </summary>
    public void CleanUp() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MoveToManager, void>)0x0052A1D0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0052A260
    /// void __thiscall MoveToManager::CleanUpAndCallWeenie(MoveToManager*,unsigned int)</code>
    /// </summary>
    public void CleanUpAndCallWeenie(uint status) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MoveToManager, uint, void>)0x0052A260)(ref this, status);

    /// <summary>
    /// <code>Offset: 0x0052A290
    /// void __thiscall MoveToManager::MoveToObject(MoveToManager*,unsigned int,unsigned int,float,float,const MovementParameters*)</code>
    /// </summary>
    public void MoveToObject(uint object_id, uint top_level_id, float object_radius, float object_height, ACBindings.Internal.MovementParameters* params_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MoveToManager, uint, uint, float, float, ACBindings.Internal.MovementParameters*, void>)0x0052A290)(ref this, object_id, top_level_id, object_radius, object_height, params_);

    /// <summary>
    /// <code>Offset: 0x0052A3E0
    /// void __thiscall MoveToManager::TurnToObject(MoveToManager*,unsigned int,unsigned int,const MovementParameters*)</code>
    /// </summary>
    public void TurnToObject(uint object_id, uint top_level_id, ACBindings.Internal.MovementParameters* params_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MoveToManager, uint, uint, ACBindings.Internal.MovementParameters*, void>)0x0052A3E0)(ref this, object_id, top_level_id, params_);

    /// <summary>
    /// <code>Offset: 0x0052A540
    /// void __thiscall MoveToManager::CancelMoveTo(MoveToManager*,unsigned int)</code>
    /// </summary>
    public void CancelMoveTo(uint retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MoveToManager, uint, void>)0x0052A540)(ref this, retval);

    /// <summary>
    /// <code>Offset: 0x0052A5E0
    /// void __thiscall MoveToManager::~MoveToManager(MoveToManager*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MoveToManager, void>)0x0052A5E0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0052A610
    /// void __thiscall MoveToManager::BeginMoveForward(MoveToManager*)</code>
    /// </summary>
    public void BeginMoveForward() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MoveToManager, void>)0x0052A610)(ref this);

    /// <summary>
    /// <code>Offset: 0x0052A7A0
    /// void __thiscall MoveToManager::BeginTurnToHeading(MoveToManager*)</code>
    /// </summary>
    public void BeginTurnToHeading() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MoveToManager, void>)0x0052A7A0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0052A8C0
    /// void __thiscall MoveToManager::BeginNextNode(MoveToManager*)</code>
    /// </summary>
    public void BeginNextNode() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MoveToManager, void>)0x0052A8C0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0052A990
    /// void __thiscall MoveToManager::HandleMoveToPosition(MoveToManager*)</code>
    /// </summary>
    public void HandleMoveToPosition() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MoveToManager, void>)0x0052A990)(ref this);

    /// <summary>
    /// <code>Offset: 0x0052ACD0
    /// void __thiscall MoveToManager::HandleTurnToHeading(MoveToManager*)</code>
    /// </summary>
    public void HandleTurnToHeading() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MoveToManager, void>)0x0052ACD0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0052AE50
    /// void __thiscall MoveToManager::MoveToPosition(MoveToManager*,const Position*,const MovementParameters*)</code>
    /// </summary>
    public void MoveToPosition(ACBindings.Internal.Position* p, ACBindings.Internal.MovementParameters* params_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MoveToManager, ACBindings.Internal.Position*, ACBindings.Internal.MovementParameters*, void>)0x0052AE50)(ref this, p, params_);

    /// <summary>
    /// <code>Offset: 0x0052B010
    /// void __thiscall MoveToManager::MoveToObject_Internal(MoveToManager*,const Position*,const Position*)</code>
    /// </summary>
    public void MoveToObject_Internal(ACBindings.Internal.Position* target_position, ACBindings.Internal.Position* interpolated_position) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MoveToManager, ACBindings.Internal.Position*, ACBindings.Internal.Position*, void>)0x0052B010)(ref this, target_position, interpolated_position);

    /// <summary>
    /// <code>Offset: 0x0052B160
    /// void __thiscall MoveToManager::TurnToObject_Internal(MoveToManager*,const Position*)</code>
    /// </summary>
    public void TurnToObject_Internal(ACBindings.Internal.Position* target_position) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MoveToManager, ACBindings.Internal.Position*, void>)0x0052B160)(ref this, target_position);

    /// <summary>
    /// <code>Offset: 0x0052B240
    /// void __thiscall MoveToManager::TurnToHeading(MoveToManager*,const MovementParameters*)</code>
    /// </summary>
    public void TurnToHeading(ACBindings.Internal.MovementParameters* params_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MoveToManager, ACBindings.Internal.MovementParameters*, void>)0x0052B240)(ref this, params_);

    /// <summary>
    /// <code>Offset: 0x0052B3E0
    /// void __thiscall MoveToManager::HandleUpdateTarget(MoveToManager*,const TargetInfo*)</code>
    /// </summary>
    public void HandleUpdateTarget(ACBindings.Internal.TargetInfo* target_info) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MoveToManager, ACBindings.Internal.TargetInfo*, void>)0x0052B3E0)(ref this, target_info);

    /// <summary>
    /// <code>Offset: 0x0052B510
    /// unsigned int __thiscall MoveToManager::PerformMovement(MoveToManager*,const MovementStruct*)</code>
    /// </summary>
    public uint PerformMovement(ACBindings.Internal.MovementStruct* mvs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MoveToManager, ACBindings.Internal.MovementStruct*, uint>)0x0052B510)(ref this, mvs);
}

