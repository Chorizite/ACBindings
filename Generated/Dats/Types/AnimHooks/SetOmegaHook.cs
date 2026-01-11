namespace ACBindings.Internal;

public unsafe struct SetOmegaHook
{
    // Base Classes
    public ACBindings.Internal.CAnimHook BaseClass_CAnimHook; // ACBindings.Internal.CAnimHook

    // Child Types
    public unsafe struct SetOmegaHook_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SetOmegaHook*, void> SetOmegaHook_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SetOmegaHook*, ACBindings.Internal.CPhysicsObj*, void> Execute; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SetOmegaHook*, int> GetType; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SetOmegaHook*, ACBindings.Internal.QualifiedDataIDArray*, void> GetSubDataIDs; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SetOmegaHook*, uint> pack_size; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SetOmegaHook*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SetOmegaHook*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.AC1Legacy.Vector3 axis;

    // Methods

    /// <summary>
    /// <code>Offset: 0x00527B30
    /// void __thiscall SetOmegaHook::Execute(SetOmegaHook*,CPhysicsObj*)</code>
    /// </summary>
    public void Execute(ACBindings.Internal.CPhysicsObj* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SetOmegaHook, ACBindings.Internal.CPhysicsObj*, void>)0x00527B30)(ref this, object_);

    /// <summary>
    /// <code>Offset: 0x005284F0
    /// unsigned int __thiscall SetOmegaHook::Pack(SetOmegaHook*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SetOmegaHook, void**, uint, uint>)0x005284F0)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x00528540
    /// int __thiscall SetOmegaHook::UnPack(SetOmegaHook*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SetOmegaHook, void**, uint, int>)0x00528540)(ref this, addr, size);
}

