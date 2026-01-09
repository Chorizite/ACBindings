namespace ACBindings;

// NoDrawHook
public unsafe struct NoDrawHook
{
    // Base Classes
    public ACBindings.CAnimHook BaseClass_CAnimHook; // ACBindings.CAnimHook

    // Child Types
    // NoDrawHook_vtbl
    public unsafe struct NoDrawHook_vtbl
    {
        // Members
        public System.IntPtr NoDrawHook_dtor_0; // function pointer
        public System.IntPtr Execute; // function pointer
        public System.IntPtr GetType; // function pointer
        public System.IntPtr GetSubDataIDs; // function pointer
        public System.IntPtr pack_size; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public int _no_draw;

    // Methods
    // unsigned int __thiscall NoDrawHook::GetType(Position*)
    public uint GetType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.NoDrawHook, uint>)0x00527450)(ref this);
    // unsigned int __thiscall NoDrawHook::Pack(SetLightHook*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.NoDrawHook, void**, uint, uint>)0x00527780)(ref this, addr, size);
    // void __thiscall NoDrawHook::Execute(NoDrawHook*,CPhysicsObj*)
    public void Execute(ACBindings.CPhysicsObj* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.NoDrawHook, ACBindings.CPhysicsObj*, void>)0x005277E0)(ref this, object_);
}

