namespace ACBindings;

// AnimDoneHook
public unsafe struct AnimDoneHook
{
    // Base Classes
    public ACBindings.CAnimHook BaseClass_CAnimHook; // ACBindings.CAnimHook

    // Child Types
    // AnimDoneHook_vtbl
    public unsafe struct AnimDoneHook_vtbl
    {
        // Members
        public System.IntPtr AnimDoneHook_dtor_0; // function pointer
        public System.IntPtr Execute; // function pointer
        public System.IntPtr GetType; // function pointer
        public System.IntPtr GetSubDataIDs; // function pointer
        public System.IntPtr pack_size; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Methods
    // void __thiscall AnimDoneHook::Execute(AnimDoneHook*,CPhysicsObj*)
    public void Execute(ACBindings.CPhysicsObj* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AnimDoneHook, ACBindings.CPhysicsObj*, void>)0x00527820)(ref this, object_);
}

