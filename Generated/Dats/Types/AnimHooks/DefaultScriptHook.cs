namespace ACBindings;

// DefaultScriptHook
public unsafe struct DefaultScriptHook
{
    // Base Classes
    public ACBindings.CAnimHook BaseClass_CAnimHook; // ACBindings.CAnimHook

    // Child Types
    // DefaultScriptHook_vtbl
    public unsafe struct DefaultScriptHook_vtbl
    {
        // Members
        public System.IntPtr DefaultScriptHook_dtor_0; // function pointer
        public System.IntPtr Execute; // function pointer
        public System.IntPtr GetType; // function pointer
        public System.IntPtr GetSubDataIDs; // function pointer
        public System.IntPtr pack_size; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Methods
    // int __thiscall DefaultScriptHook::UnPack(DefaultScriptHook*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.DefaultScriptHook, void**, uint, int>)0x00525400)(ref this, addr, size);
    // void __thiscall DefaultScriptHook::Execute(DefaultScriptHook*,CPhysicsObj*)
    public void Execute(ACBindings.CPhysicsObj* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.DefaultScriptHook, ACBindings.CPhysicsObj*, void>)0x00527810)(ref this, object_);
}

