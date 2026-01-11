namespace ACBindings.Internal;

public unsafe struct NoDrawHook
{
    // Base Classes
    public ACBindings.Internal.CAnimHook BaseClass_CAnimHook; // ACBindings.Internal.CAnimHook

    // Child Types
    public unsafe struct NoDrawHook_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.NoDrawHook*, void> NoDrawHook_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.NoDrawHook*, ACBindings.Internal.CPhysicsObj*, void> Execute; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.NoDrawHook*, int> GetType; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.NoDrawHook*, ACBindings.Internal.QualifiedDataIDArray*, void> GetSubDataIDs; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.NoDrawHook*, uint> pack_size; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.NoDrawHook*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.NoDrawHook*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public int _no_draw;

    // Methods

    /// <summary>
    /// <code>Offset: 0x00527450
    /// unsigned int __thiscall NoDrawHook::GetType(Position*)</code>
    /// </summary>
    public uint GetType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NoDrawHook, uint>)0x00527450)(ref this);

    /// <summary>
    /// <code>Offset: 0x00527780
    /// unsigned int __thiscall NoDrawHook::Pack(SetLightHook*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NoDrawHook, void**, uint, uint>)0x00527780)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005277E0
    /// void __thiscall NoDrawHook::Execute(NoDrawHook*,CPhysicsObj*)</code>
    /// </summary>
    public void Execute(ACBindings.Internal.CPhysicsObj* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NoDrawHook, ACBindings.Internal.CPhysicsObj*, void>)0x005277E0)(ref this, object_);
}

