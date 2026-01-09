namespace ACBindings;

// DefaultScriptPartHook
public unsafe struct DefaultScriptPartHook
{
    // Base Classes
    public ACBindings.CAnimHook BaseClass_CAnimHook; // ACBindings.CAnimHook

    // Child Types
    // DefaultScriptPartHook_vtbl
    public unsafe struct DefaultScriptPartHook_vtbl
    {
        // Members
        public System.IntPtr DefaultScriptPartHook_dtor_0; // function pointer
        public System.IntPtr Execute; // function pointer
        public System.IntPtr GetType; // function pointer
        public System.IntPtr GetSubDataIDs; // function pointer
        public System.IntPtr pack_size; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public uint _part_index;

    // Methods
    // int __thiscall DefaultScriptPartHook::GetType(DefaultScriptPartHook*)
    public int GetType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.DefaultScriptPartHook, int>)0x00527460)(ref this);
    // void __thiscall DefaultScriptPartHook::Execute(DefaultScriptPartHook*,CPhysicsObj*)
    public void Execute(ACBindings.CPhysicsObj* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.DefaultScriptPartHook, ACBindings.CPhysicsObj*, void>)0x00527800)(ref this, object_);
}

