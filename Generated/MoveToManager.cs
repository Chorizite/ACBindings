namespace ACBindings;

// MoveToManager
public unsafe struct MoveToManager : System.IDisposable
{
    // Child Types
    // MoveToManager::MovementNode
    public unsafe struct MovementNode
    {
        // Base Classes
        public ACBindings.DLListData BaseClass_DLListData; // ACBindings.DLListData

        // Members
        public ACBindings.MovementTypes.Type type;
        public float heading;

        // Methods
    }

    // Members
    public ACBindings.MovementTypes.Type movement_type;
    public ACBindings.Position sought_position;
    public ACBindings.Position current_target_position;
    public ACBindings.Position starting_position;
    public ACBindings.MovementParameters movement_params;
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
    public ACBindings.DLList__MoveToManager_MovementNode pending_actions;
    public ACBindings.CPhysicsObj* physics_obj;
    public ACBindings.CWeenieObject* weenie_obj;

    // Generated Constructor
    public MoveToManager() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // unsigned int __thiscall MoveToManager::_DoMotion(MoveToManager*,unsigned int,MovementParameters*)
    public uint _DoMotion(uint motion, ACBindings.MovementParameters* params_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MoveToManager, uint, ACBindings.MovementParameters*, uint>)0x00529C20)(ref this, motion, params_);
    // unsigned int __thiscall MoveToManager::_StopMotion(MoveToManager*,unsigned int,MovementParameters*)
    public uint _StopMotion(uint motion, ACBindings.MovementParameters* params_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MoveToManager, uint, ACBindings.MovementParameters*, uint>)0x00529C90)(ref this, motion, params_);
    // int __thiscall MoveToManager::CheckProgressMade(MoveToManager*,float)
    public int CheckProgressMade(float curr_distance) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MoveToManager, float, int>)0x00529D00)(ref this, curr_distance);
    // float __thiscall MoveToManager::GetCurrentDistance(MoveToManager*)
    public float GetCurrentDistance() => ((delegate* unmanaged[Thiscall]<ref ACBindings.MoveToManager, float>)0x00529DC0)(ref this);
    // int __thiscall MoveToManager::is_moving_to(MoveToManager*)
    public int is_moving_to() => ((delegate* unmanaged[Thiscall]<ref ACBindings.MoveToManager, int>)0x00529E30)(ref this);
    // void __thiscall MoveToManager::SetWeenieObject(MoveToManager*,CWeenieObject*)
    public void SetWeenieObject(ACBindings.CWeenieObject* wobj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MoveToManager, ACBindings.CWeenieObject*, void>)0x00529E40)(ref this, wobj);
    // void __thiscall MoveToManager::SetPhysicsObject(MoveToManager*,CPhysicsObj*)
    public void SetPhysicsObject(ACBindings.CPhysicsObj* pobj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MoveToManager, ACBindings.CPhysicsObj*, void>)0x00529E50)(ref this, pobj);
    // void __thiscall MoveToManager::InitializeLocalVariables(MoveToManager*)
    public void InitializeLocalVariables() => ((delegate* unmanaged[Thiscall]<ref ACBindings.MoveToManager, void>)0x00529E60)(ref this);
    // void __thiscall MoveToManager::RemovePendingActionsHead(MoveToManager*)
    public void RemovePendingActionsHead() => ((delegate* unmanaged[Thiscall]<ref ACBindings.MoveToManager, void>)0x00529F90)(ref this);
    // void __thiscall MoveToManager::MoveToManager(MoveToManager*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.MoveToManager, void>)0x00529FC0)(ref this);
    // MoveToManager* __cdecl MoveToManager::Create(CPhysicsObj*,CWeenieObject*)
    public static ACBindings.MoveToManager* Create(ACBindings.CPhysicsObj* physics_obj, ACBindings.CWeenieObject* weenie_obj) => ((delegate* unmanaged[Cdecl]<ACBindings.CPhysicsObj*, ACBindings.CWeenieObject*, ACBindings.MoveToManager*>)0x0052A080)(physics_obj, weenie_obj);
    // void __thiscall MoveToManager::Destroy(MoveToManager*)
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.MoveToManager, void>)0x0052A0C0)(ref this);
    // void __thiscall MoveToManager::AddTurnToHeadingNode(MoveToManager*,float)
    public void AddTurnToHeadingNode(float global_heading) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MoveToManager, float, void>)0x0052A140)(ref this, global_heading);
    // void __thiscall MoveToManager::AddMoveToPositionNode(MoveToManager*)
    public void AddMoveToPositionNode() => ((delegate* unmanaged[Thiscall]<ref ACBindings.MoveToManager, void>)0x0052A190)(ref this);
    // void __thiscall MoveToManager::CleanUp(MoveToManager*)
    public void CleanUp() => ((delegate* unmanaged[Thiscall]<ref ACBindings.MoveToManager, void>)0x0052A1D0)(ref this);
    // void __thiscall MoveToManager::CleanUpAndCallWeenie(MoveToManager*,unsigned int)
    public void CleanUpAndCallWeenie(uint status) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MoveToManager, uint, void>)0x0052A260)(ref this, status);
    // void __thiscall MoveToManager::MoveToObject(MoveToManager*,unsigned int,unsigned int,float,float,const MovementParameters*)
    public void MoveToObject(uint object_id, uint top_level_id, float object_radius, float object_height, ACBindings.MovementParameters* params_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MoveToManager, uint, uint, float, float, ACBindings.MovementParameters*, void>)0x0052A290)(ref this, object_id, top_level_id, object_radius, object_height, params_);
    // void __thiscall MoveToManager::TurnToObject(MoveToManager*,unsigned int,unsigned int,const MovementParameters*)
    public void TurnToObject(uint object_id, uint top_level_id, ACBindings.MovementParameters* params_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MoveToManager, uint, uint, ACBindings.MovementParameters*, void>)0x0052A3E0)(ref this, object_id, top_level_id, params_);
    // void __thiscall MoveToManager::CancelMoveTo(MoveToManager*,unsigned int)
    public void CancelMoveTo(uint retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MoveToManager, uint, void>)0x0052A540)(ref this, retval);
    // void __thiscall MoveToManager::~MoveToManager(MoveToManager*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.MoveToManager, void>)0x0052A5E0)(ref this);
    // void __thiscall MoveToManager::BeginMoveForward(MoveToManager*)
    public void BeginMoveForward() => ((delegate* unmanaged[Thiscall]<ref ACBindings.MoveToManager, void>)0x0052A610)(ref this);
    // void __thiscall MoveToManager::BeginTurnToHeading(MoveToManager*)
    public void BeginTurnToHeading() => ((delegate* unmanaged[Thiscall]<ref ACBindings.MoveToManager, void>)0x0052A7A0)(ref this);
    // void __thiscall MoveToManager::BeginNextNode(MoveToManager*)
    public void BeginNextNode() => ((delegate* unmanaged[Thiscall]<ref ACBindings.MoveToManager, void>)0x0052A8C0)(ref this);
    // void __thiscall MoveToManager::HandleMoveToPosition(MoveToManager*)
    public void HandleMoveToPosition() => ((delegate* unmanaged[Thiscall]<ref ACBindings.MoveToManager, void>)0x0052A990)(ref this);
    // void __thiscall MoveToManager::HandleTurnToHeading(MoveToManager*)
    public void HandleTurnToHeading() => ((delegate* unmanaged[Thiscall]<ref ACBindings.MoveToManager, void>)0x0052ACD0)(ref this);
    // void __thiscall MoveToManager::MoveToPosition(MoveToManager*,const Position*,const MovementParameters*)
    public void MoveToPosition(ACBindings.Position* p, ACBindings.MovementParameters* params_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MoveToManager, ACBindings.Position*, ACBindings.MovementParameters*, void>)0x0052AE50)(ref this, p, params_);
    // void __thiscall MoveToManager::MoveToObject_Internal(MoveToManager*,const Position*,const Position*)
    public void MoveToObject_Internal(ACBindings.Position* target_position, ACBindings.Position* interpolated_position) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MoveToManager, ACBindings.Position*, ACBindings.Position*, void>)0x0052B010)(ref this, target_position, interpolated_position);
    // void __thiscall MoveToManager::TurnToObject_Internal(MoveToManager*,const Position*)
    public void TurnToObject_Internal(ACBindings.Position* target_position) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MoveToManager, ACBindings.Position*, void>)0x0052B160)(ref this, target_position);
    // void __thiscall MoveToManager::TurnToHeading(MoveToManager*,const MovementParameters*)
    public void TurnToHeading(ACBindings.MovementParameters* params_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MoveToManager, ACBindings.MovementParameters*, void>)0x0052B240)(ref this, params_);
    // void __thiscall MoveToManager::HandleUpdateTarget(MoveToManager*,const TargetInfo*)
    public void HandleUpdateTarget(ACBindings.TargetInfo* target_info) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MoveToManager, ACBindings.TargetInfo*, void>)0x0052B3E0)(ref this, target_info);
    // unsigned int __thiscall MoveToManager::PerformMovement(MoveToManager*,const MovementStruct*)
    public uint PerformMovement(ACBindings.MovementStruct* mvs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MoveToManager, ACBindings.MovementStruct*, uint>)0x0052B510)(ref this, mvs);
}

