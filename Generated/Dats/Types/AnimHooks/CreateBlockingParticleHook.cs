namespace ACBindings.Internal;


/// <summary>Creates a blocking particle emitter attached to physics objects, extending the standard particle creation hook with block behavior.</summary>
/// <remarks>The emitter stops particles from passing through the attached object, enabling environmental effects such as barriers or protective shells.</remarks>
public unsafe struct CreateBlockingParticleHook
{
    // Base Classes
    public ACBindings.Internal.CreateParticleHook BaseClass_CreateParticleHook; // ACBindings.Internal.CreateParticleHook

    // Child Types
    public unsafe struct CreateBlockingParticleHook_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CreateBlockingParticleHook*, void> CreateBlockingParticleHook_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CreateBlockingParticleHook*, ACBindings.Internal.CPhysicsObj*, void> Execute; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CreateBlockingParticleHook*, int> GetType; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CreateBlockingParticleHook*, ACBindings.Internal.QualifiedDataIDArray*, void> GetSubDataIDs; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CreateBlockingParticleHook*, uint> pack_size; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CreateBlockingParticleHook*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CreateBlockingParticleHook*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Generated Constructor
    public CreateBlockingParticleHook() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>Creates a blocking particle emitter on the specified physics object using the hook’s configuration.
    /// <code>Offset: 0x00527AF0
    /// void __thiscall CreateBlockingParticleHook::Execute(CreateBlockingParticleHook*,CPhysicsObj*)</code>
    /// </summary>
    /// <param name="object">The physics object to which the emitter is attached.</param>
    public void Execute(ACBindings.Internal.CPhysicsObj* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CreateBlockingParticleHook, ACBindings.Internal.CPhysicsObj*, void>)0x00527AF0)(ref this, object_);

    /// <summary>Constructs a CreateBlockingParticleHook instance, initializing the underlying animation hook and frame offset to identity rotation and zero position.
    /// <code>Offset: 0x00527D80
    /// void __thiscall CreateBlockingParticleHook::CreateBlockingParticleHook(CreateBlockingParticleHook*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CreateBlockingParticleHook, void>)0x00527D80)(ref this);
}

