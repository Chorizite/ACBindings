namespace ACBindings.Internal;

public unsafe struct DestroyParticleHook
{
    // Base Classes
    public ACBindings.Internal.CAnimHook BaseClass_CAnimHook; // ACBindings.Internal.CAnimHook

    // Child Types
    public unsafe struct DestroyParticleHook_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DestroyParticleHook*, void> DestroyParticleHook_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DestroyParticleHook*, ACBindings.Internal.CPhysicsObj*, void> Execute; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DestroyParticleHook*, int> GetType; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DestroyParticleHook*, ACBindings.Internal.QualifiedDataIDArray*, void> GetSubDataIDs; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DestroyParticleHook*, uint> pack_size; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DestroyParticleHook*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DestroyParticleHook*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public uint emitter_id;

    // Methods

    /// <summary>
    /// <code>Offset: 0x005274A0
    /// int __thiscall DestroyParticleHook::GetType(DestroyParticleHook*)</code>
    /// </summary>
    public int GetType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DestroyParticleHook, int>)0x005274A0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005277A0
    /// int __thiscall DestroyParticleHook::UnPack(SetLightHook*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DestroyParticleHook, void**, uint, int>)0x005277A0)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x00527B10
    /// void __thiscall DestroyParticleHook::Execute(DestroyParticleHook*,CPhysicsObj*)</code>
    /// </summary>
    public void Execute(ACBindings.Internal.CPhysicsObj* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DestroyParticleHook, ACBindings.Internal.CPhysicsObj*, void>)0x00527B10)(ref this, object_);
}

