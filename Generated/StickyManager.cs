namespace ACBindings.Internal;

public unsafe struct StickyManager : System.IDisposable
{
    // Members
    public uint target_id;
    public float target_radius;
    public ACBindings.Internal.Position target_position;
    public ACBindings.Internal.CPhysicsObj* physics_obj;
    public int initialized;
    public double sticky_timeout_time;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x00556050
    /// void __thiscall StickyManager::adjust_offset(StickyManager*,Frame*,long double)</code>
    /// </summary>
    public void adjust_offset(ACBindings.Internal.Frame* offset, double quantum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StickyManager, ACBindings.Internal.Frame*, double, void>)0x00556050)(ref this, offset, quantum);

    /// <summary>
    /// <code>Offset: 0x00556270
    /// void __thiscall StickyManager::Destroy(StickyManager*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StickyManager, void>)0x00556270)(ref this);

    /// <summary>
    /// <code>Offset: 0x00556300
    /// void __thiscall StickyManager::SetPhysicsObject(StickyManager*,CPhysicsObj*)</code>
    /// </summary>
    public void SetPhysicsObject(ACBindings.Internal.CPhysicsObj* new_physobj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StickyManager, ACBindings.Internal.CPhysicsObj*, void>)0x00556300)(ref this, new_physobj);

    /// <summary>
    /// <code>Offset: 0x00556330
    /// void __thiscall StickyManager::StickTo(StickyManager*,unsigned int,float,float)</code>
    /// </summary>
    public void StickTo(uint target_id, float target_radius, float target_height) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StickyManager, uint, float, float, void>)0x00556330)(ref this, target_id, target_radius, target_height);

    /// <summary>
    /// <code>Offset: 0x005563A0
    /// void __thiscall StickyManager::HandleUpdateTarget(StickyManager*,TargetInfo)</code>
    /// </summary>
    public void HandleUpdateTarget(ACBindings.Internal.TargetInfo target_info) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StickyManager, ACBindings.Internal.TargetInfo, void>)0x005563A0)(ref this, target_info);

    /// <summary>
    /// <code>Offset: 0x00556400
    /// void __thiscall StickyManager::~StickyManager(StickyManager*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StickyManager, void>)0x00556400)(ref this);

    /// <summary>
    /// <code>Offset: 0x00556420
    /// StickyManager* __cdecl StickyManager::Create(CPhysicsObj*)</code>
    /// </summary>
    public static ACBindings.Internal.StickyManager* Create(ACBindings.Internal.CPhysicsObj* physics_obj) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CPhysicsObj*, ACBindings.Internal.StickyManager*>)0x00556420)(physics_obj);
}

