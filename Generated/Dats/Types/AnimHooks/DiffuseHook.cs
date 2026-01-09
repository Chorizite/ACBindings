namespace ACBindings;

// DiffuseHook
public unsafe struct DiffuseHook
{
    // Base Classes
    public ACBindings.CAnimHook BaseClass_CAnimHook; // ACBindings.CAnimHook

    // Child Types
    // DiffuseHook_vtbl
    public unsafe struct DiffuseHook_vtbl
    {
        // Members
        public System.IntPtr DiffuseHook_dtor_0; // function pointer
        public System.IntPtr Execute; // function pointer
        public System.IntPtr GetType; // function pointer
        public System.IntPtr GetSubDataIDs; // function pointer
        public System.IntPtr pack_size; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public float start;
    public float end;
    public float time;

    // Methods
    // unsigned int __thiscall DiffuseHook::Pack(DiffuseHook*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.DiffuseHook, void**, uint, uint>)0x00527850)(ref this, addr, size);
    // void __thiscall DiffuseHook::Execute(DiffuseHook*,CPhysicsObj*)
    public void Execute(ACBindings.CPhysicsObj* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.DiffuseHook, ACBindings.CPhysicsObj*, void>)0x00527A00)(ref this, object_);
}

