namespace ACBindings;

// ScaleHook
public unsafe struct ScaleHook
{
    // Base Classes
    public ACBindings.CAnimHook BaseClass_CAnimHook; // ACBindings.CAnimHook

    // Child Types
    // ScaleHook_vtbl
    public unsafe struct ScaleHook_vtbl
    {
        // Members
        public System.IntPtr ScaleHook_dtor_0; // function pointer
        public System.IntPtr Execute; // function pointer
        public System.IntPtr GetType; // function pointer
        public System.IntPtr GetSubDataIDs; // function pointer
        public System.IntPtr pack_size; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public float end;
    public float time;

    // Methods
    // void __thiscall ScaleHook::Execute(ScaleHook*,CPhysicsObj*)
    public void Execute(ACBindings.CPhysicsObj* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ScaleHook, ACBindings.CPhysicsObj*, void>)0x00527A40)(ref this, object_);
    // int __thiscall ScaleHook::UnPack(TextureVelocityHook*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ScaleHook, void**, uint, int>)0x00527A90)(ref this, addr, size);
}

