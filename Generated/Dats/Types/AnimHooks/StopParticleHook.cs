namespace ACBindings.Internal;


/// <summary>Stops a particle emitter identified by an ID when executed against a physics object, functioning as an animation hook in the system.</summary>
public unsafe struct StopParticleHook
{
    // Base Classes
    public ACBindings.Internal.CAnimHook BaseClass_CAnimHook; // ACBindings.Internal.CAnimHook

    // Child Types
    public unsafe struct StopParticleHook_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.StopParticleHook*, void> StopParticleHook_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.StopParticleHook*, ACBindings.Internal.CPhysicsObj*, void> Execute; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.StopParticleHook*, int> GetType; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.StopParticleHook*, ACBindings.Internal.QualifiedDataIDArray*, void> GetSubDataIDs; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.StopParticleHook*, uint> pack_size; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.StopParticleHook*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.StopParticleHook*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public uint emitter_id;

    // Methods

    /// <summary>Provides the type identifier for a StopParticleHook instance.
    /// <code>Offset: 0x005274B0
    /// unsigned int __thiscall StopParticleHook::GetType(DBWave*)</code>
    /// </summary>
    /// <returns>The numeric type code (15) representing a stop particle hook.</returns>
    public uint GetType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StopParticleHook, uint>)0x005274B0)(ref this);

    /// <summary>Stops a particle emitter identified by emitter_id on the supplied physics object.
    /// <code>Offset: 0x00527B20
    /// void __thiscall StopParticleHook::Execute(StopParticleHook*,CPhysicsObj*)</code>
    /// </summary>
    /// <param name="object">The physics object whose particle emitter should be stopped.</param>
    public void Execute(ACBindings.Internal.CPhysicsObj* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StopParticleHook, ACBindings.Internal.CPhysicsObj*, void>)0x00527B20)(ref this, object_);
}

