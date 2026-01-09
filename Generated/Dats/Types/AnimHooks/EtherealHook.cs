namespace ACBindings;

// EtherealHook
public unsafe struct EtherealHook
{
    // Base Classes
    public ACBindings.CAnimHook BaseClass_CAnimHook; // ACBindings.CAnimHook

    // Child Types
    // EtherealHook_vtbl
    public unsafe struct EtherealHook_vtbl
    {
        // Members
        public System.IntPtr EtherealHook_dtor_0; // function pointer
        public System.IntPtr Execute; // function pointer
        public System.IntPtr GetType; // function pointer
        public System.IntPtr GetSubDataIDs; // function pointer
        public System.IntPtr pack_size; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public int ethereal;

    // Methods
    // unsigned int __cdecl EtherealHook::pack_size()
    public static uint pack_size() => ((delegate* unmanaged[Cdecl]<uint>)0x00525410)();
    // void __thiscall EtherealHook::Execute(EtherealHook*,CPhysicsObj*)
    public void Execute(ACBindings.CPhysicsObj* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.EtherealHook, ACBindings.CPhysicsObj*, void>)0x005277C0)(ref this, object_);
}

