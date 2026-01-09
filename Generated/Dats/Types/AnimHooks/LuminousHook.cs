namespace ACBindings;

// LuminousHook
public unsafe struct LuminousHook
{
    // Base Classes
    public ACBindings.CAnimHook BaseClass_CAnimHook; // ACBindings.CAnimHook

    // Child Types
    // LuminousHook_vtbl
    public unsafe struct LuminousHook_vtbl
    {
        // Members
        public System.IntPtr LuminousHook_dtor_0; // function pointer
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
    // int __thiscall LuminousHook::UnPack(TextureVelocityPartHook*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.LuminousHook, void**, uint, int>)0x00527890)(ref this, addr, size);
    // void __thiscall LuminousHook::Execute(LuminousHook*,CPhysicsObj*)
    public void Execute(ACBindings.CPhysicsObj* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.LuminousHook, ACBindings.CPhysicsObj*, void>)0x00527960)(ref this, object_);
}

