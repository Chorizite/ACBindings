namespace ACBindings.Internal;

public unsafe struct DefaultScriptHook
{
    // Base Classes
    public ACBindings.Internal.CAnimHook BaseClass_CAnimHook; // ACBindings.Internal.CAnimHook

    // Child Types
    public unsafe struct DefaultScriptHook_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DefaultScriptHook*, void> DefaultScriptHook_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DefaultScriptHook*, ACBindings.Internal.CPhysicsObj*, void> Execute; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DefaultScriptHook*, int> GetType; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DefaultScriptHook*, ACBindings.Internal.QualifiedDataIDArray*, void> GetSubDataIDs; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DefaultScriptHook*, uint> pack_size; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DefaultScriptHook*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DefaultScriptHook*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x00525400
    /// int __thiscall DefaultScriptHook::UnPack(DefaultScriptHook*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DefaultScriptHook, void**, uint, int>)0x00525400)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x00527810
    /// void __thiscall DefaultScriptHook::Execute(DefaultScriptHook*,CPhysicsObj*)</code>
    /// </summary>
    public void Execute(ACBindings.Internal.CPhysicsObj* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DefaultScriptHook, ACBindings.Internal.CPhysicsObj*, void>)0x00527810)(ref this, object_);
}

