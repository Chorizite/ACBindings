namespace ACBindings;

// CAnimHook
public unsafe struct CAnimHook
{
    // Child Types
    // CAnimHook_vtbl
    public unsafe struct CAnimHook_vtbl
    {
        // Members
        public System.IntPtr CAnimHook_dtor_0; // function pointer
        public System.IntPtr Execute; // function pointer
        public System.IntPtr GetType; // function pointer
        public System.IntPtr GetSubDataIDs; // function pointer
        public System.IntPtr pack_size; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

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
    public ACBindings.CAnimHook* next_hook;
    public int direction_;

    // Methods
    // void __thiscall CAnimHook::add_to_list(CAnimHook*,CAnimHook**)
    public void add_to_list(ACBindings.CAnimHook** start) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CAnimHook, ACBindings.CAnimHook**, void>)0x00527540)(ref this, start);
    // unsigned int __cdecl CAnimHook::PackSize(CAnimHook*)
    public static uint PackSize(ACBindings.CAnimHook* hook) => ((delegate* unmanaged[Cdecl]<ACBindings.CAnimHook*, uint>)0x00527570)(hook);
    // void __cdecl CAnimHook::PackHook(CAnimHook*,void**,unsigned int)
    public static void PackHook(ACBindings.CAnimHook* hook, void** addr, uint size) => ((delegate* unmanaged[Cdecl]<ACBindings.CAnimHook*, void**, uint, void>)0x005275A0)(hook, addr, size);
    // CAnimHook* __cdecl CAnimHook::UnPackHook(void**,unsigned int)
    public static ACBindings.CAnimHook* UnPackHook(void** addr, uint size) => ((delegate* unmanaged[Cdecl]<void**, uint, ACBindings.CAnimHook*>)0x00527DD0)(addr, size);
}

