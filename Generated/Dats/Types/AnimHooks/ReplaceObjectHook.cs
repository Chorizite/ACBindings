namespace ACBindings.Internal;

public unsafe struct ReplaceObjectHook
{
    // Base Classes
    public ACBindings.Internal.CAnimHook BaseClass_CAnimHook; // ACBindings.Internal.CAnimHook

    // Child Types
    public unsafe struct ReplaceObjectHook_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ReplaceObjectHook*, void> ReplaceObjectHook_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ReplaceObjectHook*, ACBindings.Internal.CPhysicsObj*, void> Execute; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ReplaceObjectHook*, int> GetType; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ReplaceObjectHook*, ACBindings.Internal.QualifiedDataIDArray*, void> GetSubDataIDs; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ReplaceObjectHook*, uint> pack_size; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ReplaceObjectHook*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ReplaceObjectHook*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.AnimPartChange ap_change;

    // Generated Constructor
    public ReplaceObjectHook() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x00527710
    /// unsigned int __thiscall ReplaceObjectHook::pack_size(ReplaceObjectHook*)</code>
    /// </summary>
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ReplaceObjectHook, uint>)0x00527710)(ref this);

    /// <summary>
    /// <code>Offset: 0x00527730
    /// unsigned int __thiscall ReplaceObjectHook::Pack(ReplaceObjectHook*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ReplaceObjectHook, void**, uint, uint>)0x00527730)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x00527740
    /// int __thiscall ReplaceObjectHook::UnPack(ReplaceObjectHook*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ReplaceObjectHook, void**, uint, int>)0x00527740)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x00527CC0
    /// void __thiscall ReplaceObjectHook::ReplaceObjectHook(ReplaceObjectHook*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ReplaceObjectHook, void>)0x00527CC0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00527CF0
    /// int __thiscall ReplaceObjectHook::GetType(ReplaceObjectHook*)</code>
    /// </summary>
    public int GetType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ReplaceObjectHook, int>)0x00527CF0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00528580
    /// void __thiscall ReplaceObjectHook::GetSubDataIDs(ReplaceObjectHook*,QualifiedDataIDArray*)</code>
    /// </summary>
    public void GetSubDataIDs(ACBindings.Internal.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ReplaceObjectHook, ACBindings.Internal.QualifiedDataIDArray*, void>)0x00528580)(ref this, id_array);
}

