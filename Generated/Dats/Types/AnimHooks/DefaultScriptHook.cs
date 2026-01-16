namespace ACBindings.Internal;


/// <summary>
/// Represents a hook that executes the default script of a physics object, composed with an underlying animation hook.
/// </summary>
public unsafe struct DefaultScriptHook
{
    // Base Classes
    public ACBindings.Internal.CAnimHook BaseClass_CAnimHook; // ACBindings.Internal.CAnimHook

    // Child Types
    public unsafe struct DefaultScriptHook_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DefaultScriptHook*, void> DefaultScriptHook_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DefaultScriptHook*, ACBindings.Internal.CPhysicsObj*, void> Execute; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DefaultScriptHook*, int> GetType; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DefaultScriptHook*, ACBindings.Internal.QualifiedDataIDArray*, void> GetSubDataIDs; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DefaultScriptHook*, uint> pack_size; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DefaultScriptHook*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DefaultScriptHook*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Methods

    /// <summary>Indicates successful completion of an unpack operation; currently a stub that always returns true.
    /// <code>Offset: 0x00525400
    /// int __thiscall DefaultScriptHook::UnPack(DefaultScriptHook*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer intended to receive the unpacked data (currently unused).</param>
    /// <param name="size">Size of the data to be unpacked (currently ignored).</param>
    /// <returns>Integer value indicating success; currently always 1.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DefaultScriptHook, void**, uint, int>)0x00525400)(ref this, addr, size);

    /// <summary>Executes the default script associated with a physics object.
    /// <code>Offset: 0x00527810
    /// void __thiscall DefaultScriptHook::Execute(DefaultScriptHook*,CPhysicsObj*)</code>
    /// </summary>
    /// <param name="object">The physics object whose default script should be executed.</param>
    public void Execute(ACBindings.Internal.CPhysicsObj* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DefaultScriptHook, ACBindings.Internal.CPhysicsObj*, void>)0x00527810)(ref this, object_);
}

