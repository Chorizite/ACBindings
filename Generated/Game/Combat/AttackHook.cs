namespace ACBindings.Internal;

public unsafe struct AttackHook
{
    // Base Classes
    public ACBindings.Internal.CAnimHook BaseClass_CAnimHook; // ACBindings.Internal.CAnimHook

    // Child Types
    public unsafe struct AttackHook_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AttackHook*, void> AttackHook_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AttackHook*, ACBindings.Internal.CPhysicsObj*, void> Execute; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AttackHook*, int> GetType; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AttackHook*, ACBindings.Internal.QualifiedDataIDArray*, void> GetSubDataIDs; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AttackHook*, uint> pack_size; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AttackHook*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AttackHook*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.AttackCone attack_cone;

    // Generated Constructor
    public AttackHook() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x005273D0
    /// void __thiscall AttackHook::AttackHook(AttackHook*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AttackHook, void>)0x005273D0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00527750
    /// unsigned int __thiscall AttackHook::pack_size(AttackHook*)</code>
    /// </summary>
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AttackHook, uint>)0x00527750)(ref this);

    /// <summary>
    /// <code>Offset: 0x00527770
    /// void __thiscall AttackHook::Execute(AttackHook*,CPhysicsObj*)</code>
    /// </summary>
    public void Execute(ACBindings.Internal.CPhysicsObj* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AttackHook, ACBindings.Internal.CPhysicsObj*, void>)0x00527770)(ref this, object_);

    /// <summary>
    /// <code>Offset: 0x005283D0
    /// unsigned int __thiscall AttackHook::Pack(AttackHook*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AttackHook, void**, uint, uint>)0x005283D0)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005283E0
    /// int __thiscall AttackHook::UnPack(AttackHook*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AttackHook, void**, uint, int>)0x005283E0)(ref this, addr, size);
}

