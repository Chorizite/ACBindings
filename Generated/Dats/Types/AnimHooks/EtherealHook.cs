namespace ACBindings.Internal;


/// <summary>Represents an animation hook that toggles the ethereal state of a physics object during gameplay.</summary>
public unsafe struct EtherealHook
{
    // Base Classes
    public ACBindings.Internal.CAnimHook BaseClass_CAnimHook; // ACBindings.Internal.CAnimHook

    // Child Types
    public unsafe struct EtherealHook_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.EtherealHook*, void> EtherealHook_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.EtherealHook*, ACBindings.Internal.CPhysicsObj*, void> Execute; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.EtherealHook*, int> GetType; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.EtherealHook*, ACBindings.Internal.QualifiedDataIDArray*, void> GetSubDataIDs; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.EtherealHook*, uint> pack_size; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.EtherealHook*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.EtherealHook*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public int ethereal;

    // Methods

    /// <summary>Provides the byte length of a serialized EtherealHook instance.
    /// <code>Offset: 0x00525410
    /// unsigned int __cdecl EtherealHook::pack_size()</code>
    /// </summary>
    /// <returns>The packet size in bytes, which is always 4.</returns>
    public static uint pack_size() => ((delegate* unmanaged[Cdecl]<uint>)0x00525410)();

    /// <summary>Applies the hook’s ethereal state to a physics object.
    /// <code>Offset: 0x005277C0
    /// void __thiscall EtherealHook::Execute(EtherealHook*,CPhysicsObj*)</code>
    /// </summary>
    /// <param name="this">Hook instance holding the desired ethereal flag.</param>
    /// <param name="object">Physics object whose ethereal status will be updated.</param>
    public void Execute(ACBindings.Internal.CPhysicsObj* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.EtherealHook, ACBindings.Internal.CPhysicsObj*, void>)0x005277C0)(ref this, object_);
}

