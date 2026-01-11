namespace ACBindings.Internal;

public unsafe struct DefaultScriptPartHook
{
    // Base Classes
    public ACBindings.Internal.CAnimHook BaseClass_CAnimHook; // ACBindings.Internal.CAnimHook

    // Child Types
    public unsafe struct DefaultScriptPartHook_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DefaultScriptPartHook*, void> DefaultScriptPartHook_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DefaultScriptPartHook*, ACBindings.Internal.CPhysicsObj*, void> Execute; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DefaultScriptPartHook*, int> GetType; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DefaultScriptPartHook*, ACBindings.Internal.QualifiedDataIDArray*, void> GetSubDataIDs; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DefaultScriptPartHook*, uint> pack_size; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DefaultScriptPartHook*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DefaultScriptPartHook*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public uint _part_index;

    // Methods

    /// <summary>
    /// <code>Offset: 0x00527460
    /// int __thiscall DefaultScriptPartHook::GetType(DefaultScriptPartHook*)</code>
    /// </summary>
    public int GetType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DefaultScriptPartHook, int>)0x00527460)(ref this);

    /// <summary>
    /// <code>Offset: 0x00527800
    /// void __thiscall DefaultScriptPartHook::Execute(DefaultScriptPartHook*,CPhysicsObj*)</code>
    /// </summary>
    public void Execute(ACBindings.Internal.CPhysicsObj* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DefaultScriptPartHook, ACBindings.Internal.CPhysicsObj*, void>)0x00527800)(ref this, object_);
}

