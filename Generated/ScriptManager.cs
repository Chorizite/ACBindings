namespace ACBindings;

// ScriptManager
public unsafe struct ScriptManager : System.IDisposable
{
    // Members
    public ACBindings.CPhysicsObj* physobj;
    public ACBindings.ScriptData* curr_data;
    public ACBindings.ScriptData* last_data;
    public int hook_index;
    public double next_hook_time;

    // Generated Constructor
    public ScriptManager(ACBindings.CPhysicsObj* physobj) {
        _ConstructorInternal(physobj);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall ScriptManager::ScriptManager(ScriptManager*,CPhysicsObj*)
    public void _ConstructorInternal(ACBindings.CPhysicsObj* physobj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ScriptManager, ACBindings.CPhysicsObj*, void>)0x0051BE20)(ref this, physobj);
    // int __thiscall ScriptManager::AddScriptInternal(ScriptManager*,const PhysicsScript*)
    public int AddScriptInternal(ACBindings.PhysicsScript* script) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ScriptManager, ACBindings.PhysicsScript*, int>)0x0051BE40)(ref this, script);
    // int __thiscall ScriptManager::AddScript(ScriptManager*,int)
    public int AddScript(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ScriptManager, int, int>)0x0051BED0)(ref this, a2);
    // const CAnimHook* __thiscall ScriptManager::NextHook(ScriptManager*)
    public ACBindings.CAnimHook* NextHook() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ScriptManager, ACBindings.CAnimHook*>)0x0051BF20)(ref this);
    // void __thiscall ScriptManager::UpdateScripts(ScriptManager*)
    public void UpdateScripts() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ScriptManager, void>)0x0051BFB0)(ref this);
    // void __thiscall ScriptManager::~ScriptManager(ScriptManager*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ScriptManager, void>)0x0051C040)(ref this);
}

