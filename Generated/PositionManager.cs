namespace ACBindings;

// PositionManager
public unsafe struct PositionManager
{
    // Members
    public ACBindings.InterpolationManager* interpolation_manager;
    public ACBindings.StickyManager* sticky_manager;
    public ACBindings.ConstraintManager* constraint_manager;
    public ACBindings.CPhysicsObj* physics_obj;

    // Methods
    // void __thiscall PositionManager::UseTime(PositionManager*)
    public void UseTime() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PositionManager, void>)0x00555D80)(ref this);
    // void __thiscall PositionManager::adjust_offset(PositionManager*,Frame*,long double)
    public void adjust_offset(ACBindings.Frame* offset, double quantum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PositionManager, ACBindings.Frame*, double, void>)0x00555DB0)(ref this, offset, quantum);
    // void __thiscall PositionManager::UnStick(PositionManager*)
    public void UnStick() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PositionManager, void>)0x00555E00)(ref this);
    // void __thiscall PositionManager::InterpolateTo(PositionManager*,const Position*,int)
    public void InterpolateTo(ACBindings.Position* p, int keep_heading) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PositionManager, ACBindings.Position*, int, void>)0x00555E10)(ref this, p, keep_heading);
    // void __thiscall PositionManager::StopInterpolating(PositionManager*)
    public void StopInterpolating() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PositionManager, void>)0x00555E40)(ref this);
    // void __thiscall PositionManager::StickTo(PositionManager*,unsigned int,float,float)
    public void StickTo(uint object_id, float radius, float height) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PositionManager, uint, float, float, void>)0x00555E50)(ref this, object_id, radius, height);
    // void __thiscall PositionManager::UnConstrain(PositionManager*)
    public void UnConstrain() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PositionManager, void>)0x00555ED0)(ref this);
    // PositionManager* __cdecl PositionManager::Create(CPhysicsObj*)
    public static ACBindings.PositionManager* Create(ACBindings.CPhysicsObj* physics_obj) => ((delegate* unmanaged[Cdecl]<ACBindings.CPhysicsObj*, ACBindings.PositionManager*>)0x00555EF0)(physics_obj);
    // void __thiscall PositionManager::Destroy(PositionManager*)
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PositionManager, void>)0x00555F60)(ref this);
    // void __thiscall PositionManager::HandleUpdateTarget(PositionManager*,TargetInfo)
    public void HandleUpdateTarget(ACBindings.TargetInfo target_info) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PositionManager, ACBindings.TargetInfo, void>)0x00555FF0)(ref this, target_info);
}

