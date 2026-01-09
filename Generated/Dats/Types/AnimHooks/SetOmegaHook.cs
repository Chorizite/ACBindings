namespace ACBindings;

// SetOmegaHook
public unsafe struct SetOmegaHook
{
    // Base Classes
    public ACBindings.CAnimHook BaseClass_CAnimHook; // ACBindings.CAnimHook

    // Child Types
    // SetOmegaHook_vtbl
    public unsafe struct SetOmegaHook_vtbl
    {
        // Members
        public System.IntPtr SetOmegaHook_dtor_0; // function pointer
        public System.IntPtr Execute; // function pointer
        public System.IntPtr GetType; // function pointer
        public System.IntPtr GetSubDataIDs; // function pointer
        public System.IntPtr pack_size; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.AC1Legacy.Vector3 axis;

    // Methods
    // void __thiscall SetOmegaHook::Execute(SetOmegaHook*,CPhysicsObj*)
    public void Execute(ACBindings.CPhysicsObj* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SetOmegaHook, ACBindings.CPhysicsObj*, void>)0x00527B30)(ref this, object_);
    // unsigned int __thiscall SetOmegaHook::Pack(SetOmegaHook*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SetOmegaHook, void**, uint, uint>)0x005284F0)(ref this, addr, size);
    // int __thiscall SetOmegaHook::UnPack(SetOmegaHook*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SetOmegaHook, void**, uint, int>)0x00528540)(ref this, addr, size);
}

