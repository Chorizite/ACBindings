namespace ACBindings.Internal;

public unsafe struct CreateBlockingParticleHook
{
    // Base Classes
    public ACBindings.Internal.CreateParticleHook BaseClass_CreateParticleHook; // ACBindings.Internal.CreateParticleHook

    // Child Types
    public unsafe struct CreateBlockingParticleHook_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CreateBlockingParticleHook*, void> CreateBlockingParticleHook_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CreateBlockingParticleHook*, ACBindings.Internal.CPhysicsObj*, void> Execute; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CreateBlockingParticleHook*, int> GetType; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CreateBlockingParticleHook*, ACBindings.Internal.QualifiedDataIDArray*, void> GetSubDataIDs; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CreateBlockingParticleHook*, uint> pack_size; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CreateBlockingParticleHook*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CreateBlockingParticleHook*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Generated Constructor
    public CreateBlockingParticleHook() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x00527AF0
    /// void __thiscall CreateBlockingParticleHook::Execute(CreateBlockingParticleHook*,CPhysicsObj*)</code>
    /// </summary>
    public void Execute(ACBindings.Internal.CPhysicsObj* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CreateBlockingParticleHook, ACBindings.Internal.CPhysicsObj*, void>)0x00527AF0)(ref this, object_);

    /// <summary>
    /// <code>Offset: 0x00527D80
    /// void __thiscall CreateBlockingParticleHook::CreateBlockingParticleHook(CreateBlockingParticleHook*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CreateBlockingParticleHook, void>)0x00527D80)(ref this);
}

