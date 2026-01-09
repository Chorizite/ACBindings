namespace ACBindings;

// TransparentPartHook
public unsafe struct TransparentPartHook
{
    // Base Classes
    public ACBindings.CAnimHook BaseClass_CAnimHook; // ACBindings.CAnimHook

    // Child Types
    // TransparentPartHook_vtbl
    public unsafe struct TransparentPartHook_vtbl
    {
        // Members
        public System.IntPtr TransparentPartHook_dtor_0; // function pointer
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
    // void __thiscall TransparentPartHook::Execute(TransparentPartHook*,CPhysicsObj*)
    public void Execute(ACBindings.CPhysicsObj* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.TransparentPartHook, ACBindings.CPhysicsObj*, void>)0x005278C0)(ref this, object_);
    // int __thiscall TransparentPartHook::UnPack(DiffusePartHook*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.TransparentPartHook, void**, uint, int>)0x005278F0)(ref this, addr, size);
}

