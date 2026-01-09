namespace ACBindings;

// CreateParticleHook
public unsafe struct CreateParticleHook
{
    // Base Classes
    public ACBindings.CAnimHook BaseClass_CAnimHook; // ACBindings.CAnimHook

    // Child Types
    // CreateParticleHook_vtbl
    public unsafe struct CreateParticleHook_vtbl
    {
        // Members
        public System.IntPtr CreateParticleHook_dtor_0; // function pointer
        public System.IntPtr Execute; // function pointer
        public System.IntPtr GetType; // function pointer
        public System.IntPtr GetSubDataIDs; // function pointer
        public System.IntPtr pack_size; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.IDClass___tagDataID emitter_info_id;
    public uint part_index;
    public ACBindings.Frame offset;
    public uint emitter_id;

    // Generated Constructor
    public CreateParticleHook() {
        _ConstructorInternal();
    }

    // Methods
    // void __thiscall CreateParticleHook::Execute(CreateParticleHook*,CPhysicsObj*)
    public void Execute(ACBindings.CPhysicsObj* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CreateParticleHook, ACBindings.CPhysicsObj*, void>)0x00527AC0)(ref this, object_);
    // void __thiscall CreateParticleHook::CreateParticleHook(CreateParticleHook*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CreateParticleHook, void>)0x00527D30)(ref this);
    // unsigned int __thiscall CreateParticleHook::Pack(CreateParticleHook*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CreateParticleHook, void**, uint, uint>)0x00528450)(ref this, addr, size);
    // int __thiscall CreateParticleHook::UnPack(CreateParticleHook*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CreateParticleHook, void**, uint, int>)0x005284A0)(ref this, addr, size);
    // void __thiscall CreateParticleHook::GetSubDataIDs(CallPESHook*,QualifiedDataIDArray*)
    public void GetSubDataIDs(ACBindings.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CreateParticleHook, ACBindings.QualifiedDataIDArray*, void>)0x005285B0)(ref this, id_array);
}

