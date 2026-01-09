namespace ACBindings;

// StickyManager
public unsafe struct StickyManager : System.IDisposable
{
    // Members
    public uint target_id;
    public float target_radius;
    public ACBindings.Position target_position;
    public ACBindings.CPhysicsObj* physics_obj;
    public int initialized;
    public double sticky_timeout_time;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall StickyManager::adjust_offset(StickyManager*,Frame*,long double)
    public void adjust_offset(ACBindings.Frame* offset, double quantum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.StickyManager, ACBindings.Frame*, double, void>)0x00556050)(ref this, offset, quantum);
    // void __thiscall StickyManager::Destroy(StickyManager*)
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.StickyManager, void>)0x00556270)(ref this);
    // void __thiscall StickyManager::SetPhysicsObject(StickyManager*,CPhysicsObj*)
    public void SetPhysicsObject(ACBindings.CPhysicsObj* new_physobj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.StickyManager, ACBindings.CPhysicsObj*, void>)0x00556300)(ref this, new_physobj);
    // void __thiscall StickyManager::StickTo(StickyManager*,unsigned int,float,float)
    public void StickTo(uint target_id, float target_radius, float target_height) => ((delegate* unmanaged[Thiscall]<ref ACBindings.StickyManager, uint, float, float, void>)0x00556330)(ref this, target_id, target_radius, target_height);
    // void __thiscall StickyManager::HandleUpdateTarget(StickyManager*,TargetInfo)
    public void HandleUpdateTarget(ACBindings.TargetInfo target_info) => ((delegate* unmanaged[Thiscall]<ref ACBindings.StickyManager, ACBindings.TargetInfo, void>)0x005563A0)(ref this, target_info);
    // void __thiscall StickyManager::~StickyManager(StickyManager*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.StickyManager, void>)0x00556400)(ref this);
    // StickyManager* __cdecl StickyManager::Create(CPhysicsObj*)
    public static ACBindings.StickyManager* Create(ACBindings.CPhysicsObj* physics_obj) => ((delegate* unmanaged[Cdecl]<ACBindings.CPhysicsObj*, ACBindings.StickyManager*>)0x00556420)(physics_obj);
}

