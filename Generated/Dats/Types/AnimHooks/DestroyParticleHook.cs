namespace ACBindings;

// DestroyParticleHook
public unsafe struct DestroyParticleHook
{
    // Base Classes
    public ACBindings.CAnimHook BaseClass_CAnimHook; // ACBindings.CAnimHook

    // Child Types
    // DestroyParticleHook_vtbl
    public unsafe struct DestroyParticleHook_vtbl
    {
        // Members
        public System.IntPtr DestroyParticleHook_dtor_0; // function pointer
        public System.IntPtr Execute; // function pointer
        public System.IntPtr GetType; // function pointer
        public System.IntPtr GetSubDataIDs; // function pointer
        public System.IntPtr pack_size; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public uint emitter_id;

    // Methods
    // int __thiscall DestroyParticleHook::GetType(DestroyParticleHook*)
    public int GetType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.DestroyParticleHook, int>)0x005274A0)(ref this);
    // int __thiscall DestroyParticleHook::UnPack(SetLightHook*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.DestroyParticleHook, void**, uint, int>)0x005277A0)(ref this, addr, size);
    // void __thiscall DestroyParticleHook::Execute(DestroyParticleHook*,CPhysicsObj*)
    public void Execute(ACBindings.CPhysicsObj* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.DestroyParticleHook, ACBindings.CPhysicsObj*, void>)0x00527B10)(ref this, object_);
}

