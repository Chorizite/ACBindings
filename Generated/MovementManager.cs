namespace ACBindings.Internal;

public unsafe struct MovementManager
{
    // Members
    public ACBindings.Internal.CMotionInterp* motion_interpreter;
    public ACBindings.Internal.MoveToManager* moveto_manager;
    public ACBindings.Internal.CPhysicsObj* physics_obj;
    public ACBindings.Internal.CWeenieObject* weenie_obj;

    // Methods

    /// <summary>
    /// <code>Offset: 0x00524C00
    /// void __thiscall MovementManager::MakeMoveToManager(MovementManager*)</code>
    /// </summary>
    public void MakeMoveToManager() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MovementManager, void>)0x00524C00)(ref this);

    /// <summary>
    /// <code>Offset: 0x00524C20
    /// void __thiscall MovementManager::SetWeenieObject(MovementManager*,CWeenieObject*)</code>
    /// </summary>
    public void SetWeenieObject(ACBindings.Internal.CWeenieObject* weenie_obj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MovementManager, ACBindings.Internal.CWeenieObject*, void>)0x00524C20)(ref this, weenie_obj);

    /// <summary>
    /// <code>Offset: 0x00524C50
    /// MovementManager* __cdecl MovementManager::Create(CPhysicsObj*,CWeenieObject*)</code>
    /// </summary>
    public static ACBindings.Internal.MovementManager* Create(ACBindings.Internal.CPhysicsObj* physics_obj, ACBindings.Internal.CWeenieObject* weenie_obj) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CPhysicsObj*, ACBindings.Internal.CWeenieObject*, ACBindings.Internal.MovementManager*>)0x00524C50)(physics_obj, weenie_obj);

    /// <summary>
    /// <code>Offset: 0x00524CD0
    /// unsigned int __thiscall MovementManager::PerformMovement(MovementManager*,const MovementStruct*)</code>
    /// </summary>
    public uint PerformMovement(ACBindings.Internal.MovementStruct* movement_struct) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MovementManager, ACBindings.Internal.MovementStruct*, uint>)0x00524CD0)(ref this, movement_struct);

    /// <summary>
    /// <code>Offset: 0x00524D70
    /// void __thiscall MovementManager::move_to_interpreted_state(MovementManager*,const InterpretedMotionState*)</code>
    /// </summary>
    public void move_to_interpreted_state(ACBindings.Internal.InterpretedMotionState* state) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MovementManager, ACBindings.Internal.InterpretedMotionState*, void>)0x00524D70)(ref this, state);

    /// <summary>
    /// <code>Offset: 0x00524DB0
    /// void __thiscall MovementManager::CancelMoveTo(MovementManager*,unsigned int)</code>
    /// </summary>
    public void CancelMoveTo(uint err) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MovementManager, uint, void>)0x00524DB0)(ref this, err);

    /// <summary>
    /// <code>Offset: 0x00524DC0
    /// void __thiscall MovementManager::EnterDefaultState(MovementManager*)</code>
    /// </summary>
    public void EnterDefaultState() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MovementManager, void>)0x00524DC0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00524E60
    /// int __thiscall MovementManager::IsMovingTo(MovementManager*)</code>
    /// </summary>
    public int IsMovingTo() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MovementManager, int>)0x00524E60)(ref this);

    /// <summary>
    /// <code>Offset: 0x00524E80
    /// int __thiscall MovementManager::motions_pending(MovementManager*)</code>
    /// </summary>
    public int motions_pending() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MovementManager, int>)0x00524E80)(ref this);

    /// <summary>
    /// <code>Offset: 0x00524EF0
    /// void __thiscall MovementManager::UseTime(MovementManager*)</code>
    /// </summary>
    public void UseTime() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MovementManager, void>)0x00524EF0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00524F00
    /// void __thiscall MovementManager::HitGround(MovementManager*)</code>
    /// </summary>
    public void HitGround() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MovementManager, void>)0x00524F00)(ref this);

    /// <summary>
    /// <code>Offset: 0x00524F20
    /// void __thiscall MovementManager::LeaveGround(MovementManager*)</code>
    /// </summary>
    public void LeaveGround() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MovementManager, void>)0x00524F20)(ref this);

    /// <summary>
    /// <code>Offset: 0x00524F40
    /// void __thiscall MovementManager::HandleEnterWorld(MovementManager*)</code>
    /// </summary>
    public void HandleEnterWorld() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MovementManager, void>)0x00524F40)(ref this);

    /// <summary>
    /// <code>Offset: 0x00524F50
    /// void __thiscall MovementManager::HandleExitWorld(MovementManager*)</code>
    /// </summary>
    public void HandleExitWorld() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MovementManager, void>)0x00524F50)(ref this);

    /// <summary>
    /// <code>Offset: 0x00524FF0
    /// void __thiscall MovementManager::Destroy(MovementManager*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MovementManager, void>)0x00524FF0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00525040
    /// int __thiscall MovementManager::unpack_movement(MovementManager*,void**,unsigned int)</code>
    /// </summary>
    public int unpack_movement(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MovementManager, void**, uint, int>)0x00525040)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x00525390
    /// void __thiscall MovementManager::HandleUpdateTarget(MovementManager*,TargetInfo)</code>
    /// </summary>
    public void HandleUpdateTarget(ACBindings.Internal.TargetInfo target_info) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MovementManager, ACBindings.Internal.TargetInfo, void>)0x00525390)(ref this, target_info);
}

