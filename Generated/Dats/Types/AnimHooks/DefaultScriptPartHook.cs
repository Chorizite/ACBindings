namespace ACBindings.Internal;


/// <summary>Provides a default script hook that triggers execution of an animation for a specific part of a physics object. Stores common hook data and the zero‑based index identifying which body component to animate.</summary>
/// <remarks>The embedded CAnimHook holds shared information such as type and direction, while _part_index selects the target part during Execute. This struct is used by systems that need to invoke built‑in scripts without explicit scripting code.</remarks>
public unsafe struct DefaultScriptPartHook
{
    // Base Classes
    public ACBindings.Internal.CAnimHook BaseClass_CAnimHook; // ACBindings.Internal.CAnimHook

    // Child Types
    public unsafe struct DefaultScriptPartHook_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DefaultScriptPartHook*, void> DefaultScriptPartHook_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DefaultScriptPartHook*, ACBindings.Internal.CPhysicsObj*, void> Execute; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DefaultScriptPartHook*, int> GetType; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DefaultScriptPartHook*, ACBindings.Internal.QualifiedDataIDArray*, void> GetSubDataIDs; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DefaultScriptPartHook*, uint> pack_size; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DefaultScriptPartHook*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DefaultScriptPartHook*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public uint _part_index;

    // Methods

    /// <summary>Retrieves the numeric identifier for a DefaultScriptPartHook instance.
    /// <code>Offset: 0x00527460
    /// int __thiscall DefaultScriptPartHook::GetType(DefaultScriptPartHook*)</code>
    /// </summary>
    /// <returns>An integer constant representing this hook’s type (always 18).</returns>
    public int GetType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DefaultScriptPartHook, int>)0x00527460)(ref this);

    /// <summary>Triggers execution of the default script associated with the hook's part index on the provided physics object.
    /// <code>Offset: 0x00527800
    /// void __thiscall DefaultScriptPartHook::Execute(DefaultScriptPartHook*,CPhysicsObj*)</code>
    /// </summary>
    /// <param name="object">The physics object whose default script should run for the specified part.</param>
    public void Execute(ACBindings.Internal.CPhysicsObj* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DefaultScriptPartHook, ACBindings.Internal.CPhysicsObj*, void>)0x00527800)(ref this, object_);
}

