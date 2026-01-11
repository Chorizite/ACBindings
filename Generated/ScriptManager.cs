namespace ACBindings.Internal;

public unsafe struct ScriptManager : System.IDisposable
{
    // Members
    public ACBindings.Internal.CPhysicsObj* physobj;
    public ACBindings.Internal.ScriptData* curr_data;
    public ACBindings.Internal.ScriptData* last_data;
    public int hook_index;
    public double next_hook_time;

    // Generated Constructor
    public ScriptManager(ACBindings.Internal.CPhysicsObj* physobj) {
        _ConstructorInternal(physobj);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x0051BE20
    /// void __thiscall ScriptManager::ScriptManager(ScriptManager*,CPhysicsObj*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.CPhysicsObj* physobj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ScriptManager, ACBindings.Internal.CPhysicsObj*, void>)0x0051BE20)(ref this, physobj);

    /// <summary>
    /// <code>Offset: 0x0051BE40
    /// int __thiscall ScriptManager::AddScriptInternal(ScriptManager*,const PhysicsScript*)</code>
    /// </summary>
    public int AddScriptInternal(ACBindings.Internal.PhysicsScript* script) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ScriptManager, ACBindings.Internal.PhysicsScript*, int>)0x0051BE40)(ref this, script);

    /// <summary>
    /// <code>Offset: 0x0051BED0
    /// int __thiscall ScriptManager::AddScript(ScriptManager*,int)</code>
    /// </summary>
    public int AddScript(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ScriptManager, int, int>)0x0051BED0)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x0051BF20
    /// const CAnimHook* __thiscall ScriptManager::NextHook(ScriptManager*)</code>
    /// </summary>
    public ACBindings.Internal.CAnimHook* NextHook() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ScriptManager, ACBindings.Internal.CAnimHook*>)0x0051BF20)(ref this);

    /// <summary>
    /// <code>Offset: 0x0051BFB0
    /// void __thiscall ScriptManager::UpdateScripts(ScriptManager*)</code>
    /// </summary>
    public void UpdateScripts() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ScriptManager, void>)0x0051BFB0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0051C040
    /// void __thiscall ScriptManager::~ScriptManager(ScriptManager*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ScriptManager, void>)0x0051C040)(ref this);
}

