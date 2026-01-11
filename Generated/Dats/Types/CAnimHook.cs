namespace ACBindings.Internal;

public unsafe struct CAnimHook
{
    // Child Types
    public unsafe struct CAnimHook_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CAnimHook*, void> CAnimHook_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CAnimHook*, ACBindings.Internal.CPhysicsObj*, void> Execute; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CAnimHook*, int> GetType; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CAnimHook*, ACBindings.Internal.QualifiedDataIDArray*, void> GetSubDataIDs; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CAnimHook*, uint> pack_size; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CAnimHook*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CAnimHook*, void**, uint, int> UnPack; // function pointer

        // Methods
    }
    // CAnimHook::AnimHookDir
    public enum AnimHookDir : uint
    {
        BOTH_ANIMHOOK = 0x0,
        FORWARD_ANIMHOOK = 0x1,
        FORCE_AnimHookDir_32_BIT = 0x7FFFFFFF,
        UNKNOWN_ANIMHOOK = 0xFFFFFFFE,
        BACKWARD_ANIMHOOK = 0xFFFFFFFF
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public ACBindings.Internal.CAnimHook* next_hook;
    public int direction_;

    // Methods

    /// <summary>
    /// <code>Offset: 0x00527540
    /// void __thiscall CAnimHook::add_to_list(CAnimHook*,CAnimHook**)</code>
    /// </summary>
    public void add_to_list(ACBindings.Internal.CAnimHook** start) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CAnimHook, ACBindings.Internal.CAnimHook**, void>)0x00527540)(ref this, start);

    /// <summary>
    /// <code>Offset: 0x00527570
    /// unsigned int __cdecl CAnimHook::PackSize(CAnimHook*)</code>
    /// </summary>
    public static uint PackSize(ACBindings.Internal.CAnimHook* hook) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CAnimHook*, uint>)0x00527570)(hook);

    /// <summary>
    /// <code>Offset: 0x005275A0
    /// void __cdecl CAnimHook::PackHook(CAnimHook*,void**,unsigned int)</code>
    /// </summary>
    public static void PackHook(ACBindings.Internal.CAnimHook* hook, void** addr, uint size) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CAnimHook*, void**, uint, void>)0x005275A0)(hook, addr, size);

    /// <summary>
    /// <code>Offset: 0x00527DD0
    /// CAnimHook* __cdecl CAnimHook::UnPackHook(void**,unsigned int)</code>
    /// </summary>
    public static ACBindings.Internal.CAnimHook* UnPackHook(void** addr, uint size) => ((delegate* unmanaged[Cdecl]<void**, uint, ACBindings.Internal.CAnimHook*>)0x00527DD0)(addr, size);
}

