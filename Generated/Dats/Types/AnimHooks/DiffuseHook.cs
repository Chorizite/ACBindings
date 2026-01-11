namespace ACBindings.Internal;

public unsafe struct DiffuseHook
{
    // Base Classes
    public ACBindings.Internal.CAnimHook BaseClass_CAnimHook; // ACBindings.Internal.CAnimHook

    // Child Types
    public unsafe struct DiffuseHook_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DiffuseHook*, void> DiffuseHook_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DiffuseHook*, ACBindings.Internal.CPhysicsObj*, void> Execute; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DiffuseHook*, int> GetType; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DiffuseHook*, ACBindings.Internal.QualifiedDataIDArray*, void> GetSubDataIDs; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DiffuseHook*, uint> pack_size; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DiffuseHook*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DiffuseHook*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public float start;
    public float end;
    public float time;

    // Methods

    /// <summary>
    /// <code>Offset: 0x00527850
    /// unsigned int __thiscall DiffuseHook::Pack(DiffuseHook*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DiffuseHook, void**, uint, uint>)0x00527850)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x00527A00
    /// void __thiscall DiffuseHook::Execute(DiffuseHook*,CPhysicsObj*)</code>
    /// </summary>
    public void Execute(ACBindings.Internal.CPhysicsObj* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DiffuseHook, ACBindings.Internal.CPhysicsObj*, void>)0x00527A00)(ref this, object_);
}

