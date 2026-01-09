namespace ACBindings;

// StopParticleHook
public unsafe struct StopParticleHook
{
    // Base Classes
    public ACBindings.CAnimHook BaseClass_CAnimHook; // ACBindings.CAnimHook

    // Child Types
    // StopParticleHook_vtbl
    public unsafe struct StopParticleHook_vtbl
    {
        // Members
        public System.IntPtr StopParticleHook_dtor_0; // function pointer
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
    // unsigned int __thiscall StopParticleHook::GetType(DBWave*)
    public uint GetType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.StopParticleHook, uint>)0x005274B0)(ref this);
    // void __thiscall StopParticleHook::Execute(StopParticleHook*,CPhysicsObj*)
    public void Execute(ACBindings.CPhysicsObj* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.StopParticleHook, ACBindings.CPhysicsObj*, void>)0x00527B20)(ref this, object_);
}

