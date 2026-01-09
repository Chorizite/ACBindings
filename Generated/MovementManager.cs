namespace ACBindings;

// MovementManager
public unsafe struct MovementManager
{
    // Members
    public ACBindings.CMotionInterp* motion_interpreter;
    public ACBindings.MoveToManager* moveto_manager;
    public ACBindings.CPhysicsObj* physics_obj;
    public ACBindings.CWeenieObject* weenie_obj;

    // Methods
    // void __thiscall MovementManager::MakeMoveToManager(MovementManager*)
    public void MakeMoveToManager() => ((delegate* unmanaged[Thiscall]<ref ACBindings.MovementManager, void>)0x00524C00)(ref this);
    // void __thiscall MovementManager::SetWeenieObject(MovementManager*,CWeenieObject*)
    public void SetWeenieObject(ACBindings.CWeenieObject* weenie_obj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MovementManager, ACBindings.CWeenieObject*, void>)0x00524C20)(ref this, weenie_obj);
    // MovementManager* __cdecl MovementManager::Create(CPhysicsObj*,CWeenieObject*)
    public static ACBindings.MovementManager* Create(ACBindings.CPhysicsObj* physics_obj, ACBindings.CWeenieObject* weenie_obj) => ((delegate* unmanaged[Cdecl]<ACBindings.CPhysicsObj*, ACBindings.CWeenieObject*, ACBindings.MovementManager*>)0x00524C50)(physics_obj, weenie_obj);
    // unsigned int __thiscall MovementManager::PerformMovement(MovementManager*,const MovementStruct*)
    public uint PerformMovement(ACBindings.MovementStruct* movement_struct) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MovementManager, ACBindings.MovementStruct*, uint>)0x00524CD0)(ref this, movement_struct);
    // void __thiscall MovementManager::move_to_interpreted_state(MovementManager*,const InterpretedMotionState*)
    public void move_to_interpreted_state(ACBindings.InterpretedMotionState* state) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MovementManager, ACBindings.InterpretedMotionState*, void>)0x00524D70)(ref this, state);
    // void __thiscall MovementManager::CancelMoveTo(MovementManager*,unsigned int)
    public void CancelMoveTo(uint err) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MovementManager, uint, void>)0x00524DB0)(ref this, err);
    // void __thiscall MovementManager::EnterDefaultState(MovementManager*)
    public void EnterDefaultState() => ((delegate* unmanaged[Thiscall]<ref ACBindings.MovementManager, void>)0x00524DC0)(ref this);
    // int __thiscall MovementManager::IsMovingTo(MovementManager*)
    public int IsMovingTo() => ((delegate* unmanaged[Thiscall]<ref ACBindings.MovementManager, int>)0x00524E60)(ref this);
    // int __thiscall MovementManager::motions_pending(MovementManager*)
    public int motions_pending() => ((delegate* unmanaged[Thiscall]<ref ACBindings.MovementManager, int>)0x00524E80)(ref this);
    // void __thiscall MovementManager::UseTime(MovementManager*)
    public void UseTime() => ((delegate* unmanaged[Thiscall]<ref ACBindings.MovementManager, void>)0x00524EF0)(ref this);
    // void __thiscall MovementManager::HitGround(MovementManager*)
    public void HitGround() => ((delegate* unmanaged[Thiscall]<ref ACBindings.MovementManager, void>)0x00524F00)(ref this);
    // void __thiscall MovementManager::LeaveGround(MovementManager*)
    public void LeaveGround() => ((delegate* unmanaged[Thiscall]<ref ACBindings.MovementManager, void>)0x00524F20)(ref this);
    // void __thiscall MovementManager::HandleEnterWorld(MovementManager*)
    public void HandleEnterWorld() => ((delegate* unmanaged[Thiscall]<ref ACBindings.MovementManager, void>)0x00524F40)(ref this);
    // void __thiscall MovementManager::HandleExitWorld(MovementManager*)
    public void HandleExitWorld() => ((delegate* unmanaged[Thiscall]<ref ACBindings.MovementManager, void>)0x00524F50)(ref this);
    // void __thiscall MovementManager::Destroy(MovementManager*)
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.MovementManager, void>)0x00524FF0)(ref this);
    // int __thiscall MovementManager::unpack_movement(MovementManager*,void**,unsigned int)
    public int unpack_movement(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MovementManager, void**, uint, int>)0x00525040)(ref this, addr, size);
    // void __thiscall MovementManager::HandleUpdateTarget(MovementManager*,TargetInfo)
    public void HandleUpdateTarget(ACBindings.TargetInfo target_info) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MovementManager, ACBindings.TargetInfo, void>)0x00525390)(ref this, target_info);
}

