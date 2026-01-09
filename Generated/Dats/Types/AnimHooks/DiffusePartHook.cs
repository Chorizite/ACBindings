namespace ACBindings;

// DiffusePartHook
public unsafe struct DiffusePartHook
{
    // Base Classes
    public ACBindings.CAnimHook BaseClass_CAnimHook; // ACBindings.CAnimHook

    // Child Types
    // DiffusePartHook_vtbl
    public unsafe struct DiffusePartHook_vtbl
    {
        // Members
        public System.IntPtr DiffusePartHook_dtor_0; // function pointer
        public System.IntPtr Execute; // function pointer
        public System.IntPtr GetType; // function pointer
        public System.IntPtr GetSubDataIDs; // function pointer
        public System.IntPtr pack_size; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public uint part;
    public float start;
    public float end;
    public float time;

    // Methods
    // void __thiscall DiffusePartHook::Execute(DiffusePartHook*,CPhysicsObj*)
    public void Execute(ACBindings.CPhysicsObj* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.DiffusePartHook, ACBindings.CPhysicsObj*, void>)0x00527980)(ref this, object_);
    // unsigned int __thiscall DiffusePartHook::Pack(DiffusePartHook*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.DiffusePartHook, void**, uint, uint>)0x005279B0)(ref this, addr, size);
}

