namespace ACBindings.Internal;


/// <summary>Handles the scheduling and execution of scripting behavior for a physics object, maintaining current and previous script states while tracking hook indices and timing.</summary>
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

    /// <summary>Create a ScriptManager instance, associate it with the provided physics object, and reset internal script tracking fields.
    /// <code>Offset: 0x0051BE20
    /// void __thiscall ScriptManager::ScriptManager(ScriptManager*,CPhysicsObj*)</code>
    /// </summary>
    /// <param name="physobj">The CPhysicsObj to be managed by this ScriptManager.</param>
    public void _ConstructorInternal(ACBindings.Internal.CPhysicsObj* physobj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ScriptManager, ACBindings.Internal.CPhysicsObj*, void>)0x0051BE20)(ref this, physobj);

    /// <summary>Adds a physics script to the manager’s internal sequence, setting its start time relative to previous scripts or the current time and preparing the first hook schedule if it is the first entry.
    /// <code>Offset: 0x0051BE40
    /// int __thiscall ScriptManager::AddScriptInternal(ScriptManager*,const PhysicsScript*)</code>
    /// </summary>
    /// <param name="script">The physics script to enqueue.</param>
    /// <returns>Always 1 to indicate successful addition.</returns>
    public int AddScriptInternal(ACBindings.Internal.PhysicsScript* script) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ScriptManager, ACBindings.Internal.PhysicsScript*, int>)0x0051BE40)(ref this, script);

    /// <summary>Adds a physics script identified by the given ID to this manager, returning success status.
    /// <code>Offset: 0x0051BED0
    /// int __thiscall ScriptManager::AddScript(ScriptManager*,int)</code>
    /// </summary>
    /// <param name="a2">Identifier of the script to add.</param>
    /// <returns>Non‑zero if the script was added successfully; zero otherwise.</returns>
    public int AddScript(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ScriptManager, int, int>)0x0051BED0)(ref this, a2);

    /// <summary>Retrieves the next animation hook in the current script sequence, advancing the internal hook index and computing the time until the following hook. If no further hooks exist, returns nullptr.
    /// <code>Offset: 0x0051BF20
    /// const CAnimHook* __thiscall ScriptManager::NextHook(ScriptManager*)</code>
    /// </summary>
    /// <returns>A pointer to the CAnimHook representing the next hook, or nullptr when the script has finished. The method updates ScriptManager::hook_index and next_hook_time accordingly.</returns>
    public ACBindings.Internal.CAnimHook* NextHook() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ScriptManager, ACBindings.Internal.CAnimHook*>)0x0051BF20)(ref this);

    /// <summary>Advances the execution of animation hooks tied to a physics object, progressing through queued script data segments in order and transitioning between them according to elapsed time.
    /// <code>Offset: 0x0051BFB0
    /// void __thiscall ScriptManager::UpdateScripts(ScriptManager*)</code>
    /// </summary>
    public void UpdateScripts() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ScriptManager, void>)0x0051BFB0)(ref this);

    /// <summary>Destroys the ScriptManager by releasing all linked ScriptData objects and their associated scripts, freeing memory, and resetting internal pointers and timers.
    /// <code>Offset: 0x0051C040
    /// void __thiscall ScriptManager::~ScriptManager(ScriptManager*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ScriptManager, void>)0x0051C040)(ref this);
}

