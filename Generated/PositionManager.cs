namespace ACBindings.Internal;

public unsafe struct PositionManager
{
    // Members
    public ACBindings.Internal.InterpolationManager* interpolation_manager;
    public ACBindings.Internal.StickyManager* sticky_manager;
    public ACBindings.Internal.ConstraintManager* raint_manager;
    public ACBindings.Internal.CPhysicsObj* physics_obj;

    // Methods

    /// <summary>
    /// <code>Offset: 0x00555D80
    /// void __thiscall PositionManager::UseTime(PositionManager*)</code>
    /// </summary>
    public void UseTime() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PositionManager, void>)0x00555D80)(ref this);

    /// <summary>
    /// <code>Offset: 0x00555DB0
    /// void __thiscall PositionManager::adjust_offset(PositionManager*,Frame*,long double)</code>
    /// </summary>
    public void adjust_offset(ACBindings.Internal.Frame* offset, double quantum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PositionManager, ACBindings.Internal.Frame*, double, void>)0x00555DB0)(ref this, offset, quantum);

    /// <summary>
    /// <code>Offset: 0x00555E00
    /// void __thiscall PositionManager::UnStick(PositionManager*)</code>
    /// </summary>
    public void UnStick() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PositionManager, void>)0x00555E00)(ref this);

    /// <summary>
    /// <code>Offset: 0x00555E10
    /// void __thiscall PositionManager::InterpolateTo(PositionManager*,const Position*,int)</code>
    /// </summary>
    public void InterpolateTo(ACBindings.Internal.Position* p, int keep_heading) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PositionManager, ACBindings.Internal.Position*, int, void>)0x00555E10)(ref this, p, keep_heading);

    /// <summary>
    /// <code>Offset: 0x00555E40
    /// void __thiscall PositionManager::StopInterpolating(PositionManager*)</code>
    /// </summary>
    public void StopInterpolating() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PositionManager, void>)0x00555E40)(ref this);

    /// <summary>
    /// <code>Offset: 0x00555E50
    /// void __thiscall PositionManager::StickTo(PositionManager*,unsigned int,float,float)</code>
    /// </summary>
    public void StickTo(uint object_id, float radius, float height) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PositionManager, uint, float, float, void>)0x00555E50)(ref this, object_id, radius, height);

    /// <summary>
    /// <code>Offset: 0x00555ED0
    /// void __thiscall PositionManager::UnConstrain(PositionManager*)</code>
    /// </summary>
    public void UnConstrain() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PositionManager, void>)0x00555ED0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00555EF0
    /// PositionManager* __cdecl PositionManager::Create(CPhysicsObj*)</code>
    /// </summary>
    public static ACBindings.Internal.PositionManager* Create(ACBindings.Internal.CPhysicsObj* physics_obj) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CPhysicsObj*, ACBindings.Internal.PositionManager*>)0x00555EF0)(physics_obj);

    /// <summary>
    /// <code>Offset: 0x00555F60
    /// void __thiscall PositionManager::Destroy(PositionManager*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PositionManager, void>)0x00555F60)(ref this);

    /// <summary>
    /// <code>Offset: 0x00555FF0
    /// void __thiscall PositionManager::HandleUpdateTarget(PositionManager*,TargetInfo)</code>
    /// </summary>
    public void HandleUpdateTarget(ACBindings.Internal.TargetInfo target_info) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PositionManager, ACBindings.Internal.TargetInfo, void>)0x00555FF0)(ref this, target_info);
}

