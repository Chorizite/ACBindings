namespace ACBindings;

// CreateBlockingParticleHook
public unsafe struct CreateBlockingParticleHook
{
    // Base Classes
    public ACBindings.CreateParticleHook BaseClass_CreateParticleHook; // ACBindings.CreateParticleHook

    // Child Types
    // CreateBlockingParticleHook_vtbl
    public unsafe struct CreateBlockingParticleHook_vtbl
    {
        // Members
        public System.IntPtr CreateBlockingParticleHook_dtor_0; // function pointer
        public System.IntPtr Execute; // function pointer
        public System.IntPtr GetType; // function pointer
        public System.IntPtr GetSubDataIDs; // function pointer
        public System.IntPtr pack_size; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Generated Constructor
    public CreateBlockingParticleHook() {
        _ConstructorInternal();
    }

    // Methods
    // void __thiscall CreateBlockingParticleHook::Execute(CreateBlockingParticleHook*,CPhysicsObj*)
    public void Execute(ACBindings.CPhysicsObj* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CreateBlockingParticleHook, ACBindings.CPhysicsObj*, void>)0x00527AF0)(ref this, object_);
    // void __thiscall CreateBlockingParticleHook::CreateBlockingParticleHook(CreateBlockingParticleHook*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CreateBlockingParticleHook, void>)0x00527D80)(ref this);
}

