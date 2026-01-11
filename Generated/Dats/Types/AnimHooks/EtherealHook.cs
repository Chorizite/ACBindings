namespace ACBindings.Internal;

public unsafe struct EtherealHook
{
    // Base Classes
    public ACBindings.Internal.CAnimHook BaseClass_CAnimHook; // ACBindings.Internal.CAnimHook

    // Child Types
    public unsafe struct EtherealHook_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.EtherealHook*, void> EtherealHook_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.EtherealHook*, ACBindings.Internal.CPhysicsObj*, void> Execute; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.EtherealHook*, int> GetType; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.EtherealHook*, ACBindings.Internal.QualifiedDataIDArray*, void> GetSubDataIDs; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.EtherealHook*, uint> pack_size; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.EtherealHook*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.EtherealHook*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public int ethereal;

    // Methods

    /// <summary>
    /// <code>Offset: 0x00525410
    /// unsigned int __cdecl EtherealHook::pack_size()</code>
    /// </summary>
    public static uint pack_size() => ((delegate* unmanaged[Cdecl]<uint>)0x00525410)();

    /// <summary>
    /// <code>Offset: 0x005277C0
    /// void __thiscall EtherealHook::Execute(EtherealHook*,CPhysicsObj*)</code>
    /// </summary>
    public void Execute(ACBindings.Internal.CPhysicsObj* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.EtherealHook, ACBindings.Internal.CPhysicsObj*, void>)0x005277C0)(ref this, object_);
}

