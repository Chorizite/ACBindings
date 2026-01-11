namespace ACBindings.Internal;

public unsafe struct CreateParticleHook
{
    // Base Classes
    public ACBindings.Internal.CAnimHook BaseClass_CAnimHook; // ACBindings.Internal.CAnimHook

    // Child Types
    public unsafe struct CreateParticleHook_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CreateParticleHook*, void> CreateParticleHook_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CreateParticleHook*, ACBindings.Internal.CPhysicsObj*, void> Execute; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CreateParticleHook*, int> GetType; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CreateParticleHook*, ACBindings.Internal.QualifiedDataIDArray*, void> GetSubDataIDs; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CreateParticleHook*, uint> pack_size; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CreateParticleHook*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CreateParticleHook*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.IDClass____tagDataID emitter_info_id;
    public uint part_index;
    public ACBindings.Internal.Frame offset;
    public uint emitter_id;

    // Generated Constructor
    public CreateParticleHook() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x00527AC0
    /// void __thiscall CreateParticleHook::Execute(CreateParticleHook*,CPhysicsObj*)</code>
    /// </summary>
    public void Execute(ACBindings.Internal.CPhysicsObj* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CreateParticleHook, ACBindings.Internal.CPhysicsObj*, void>)0x00527AC0)(ref this, object_);

    /// <summary>
    /// <code>Offset: 0x00527D30
    /// void __thiscall CreateParticleHook::CreateParticleHook(CreateParticleHook*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CreateParticleHook, void>)0x00527D30)(ref this);

    /// <summary>
    /// <code>Offset: 0x00528450
    /// unsigned int __thiscall CreateParticleHook::Pack(CreateParticleHook*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CreateParticleHook, void**, uint, uint>)0x00528450)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005284A0
    /// int __thiscall CreateParticleHook::UnPack(CreateParticleHook*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CreateParticleHook, void**, uint, int>)0x005284A0)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005285B0
    /// void __thiscall CreateParticleHook::GetSubDataIDs(CallPESHook*,QualifiedDataIDArray*)</code>
    /// </summary>
    public void GetSubDataIDs(ACBindings.Internal.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CreateParticleHook, ACBindings.Internal.QualifiedDataIDArray*, void>)0x005285B0)(ref this, id_array);
}

