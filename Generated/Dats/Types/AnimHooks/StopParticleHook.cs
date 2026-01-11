namespace ACBindings.Internal;

public unsafe struct StopParticleHook
{
    // Base Classes
    public ACBindings.Internal.CAnimHook BaseClass_CAnimHook; // ACBindings.Internal.CAnimHook

    // Child Types
    public unsafe struct StopParticleHook_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.StopParticleHook*, void> StopParticleHook_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.StopParticleHook*, ACBindings.Internal.CPhysicsObj*, void> Execute; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.StopParticleHook*, int> GetType; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.StopParticleHook*, ACBindings.Internal.QualifiedDataIDArray*, void> GetSubDataIDs; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.StopParticleHook*, uint> pack_size; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.StopParticleHook*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.StopParticleHook*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public uint emitter_id;

    // Methods

    /// <summary>
    /// <code>Offset: 0x005274B0
    /// unsigned int __thiscall StopParticleHook::GetType(DBWave*)</code>
    /// </summary>
    public uint GetType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StopParticleHook, uint>)0x005274B0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00527B20
    /// void __thiscall StopParticleHook::Execute(StopParticleHook*,CPhysicsObj*)</code>
    /// </summary>
    public void Execute(ACBindings.Internal.CPhysicsObj* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StopParticleHook, ACBindings.Internal.CPhysicsObj*, void>)0x00527B20)(ref this, object_);
}

