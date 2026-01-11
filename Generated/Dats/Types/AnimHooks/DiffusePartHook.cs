namespace ACBindings.Internal;

public unsafe struct DiffusePartHook
{
    // Base Classes
    public ACBindings.Internal.CAnimHook BaseClass_CAnimHook; // ACBindings.Internal.CAnimHook

    // Child Types
    public unsafe struct DiffusePartHook_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DiffusePartHook*, void> DiffusePartHook_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DiffusePartHook*, ACBindings.Internal.CPhysicsObj*, void> Execute; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DiffusePartHook*, int> GetType; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DiffusePartHook*, ACBindings.Internal.QualifiedDataIDArray*, void> GetSubDataIDs; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DiffusePartHook*, uint> pack_size; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DiffusePartHook*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DiffusePartHook*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public uint part;
    public float start;
    public float end;
    public float time;

    // Methods

    /// <summary>
    /// <code>Offset: 0x00527980
    /// void __thiscall DiffusePartHook::Execute(DiffusePartHook*,CPhysicsObj*)</code>
    /// </summary>
    public void Execute(ACBindings.Internal.CPhysicsObj* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DiffusePartHook, ACBindings.Internal.CPhysicsObj*, void>)0x00527980)(ref this, object_);

    /// <summary>
    /// <code>Offset: 0x005279B0
    /// unsigned int __thiscall DiffusePartHook::Pack(DiffusePartHook*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DiffusePartHook, void**, uint, uint>)0x005279B0)(ref this, addr, size);
}

