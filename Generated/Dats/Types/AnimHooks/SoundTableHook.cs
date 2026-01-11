namespace ACBindings.Internal;

public unsafe struct SoundTableHook
{
    // Base Classes
    public ACBindings.Internal.CAnimHook BaseClass_CAnimHook; // ACBindings.Internal.CAnimHook

    // Child Types
    public unsafe struct SoundTableHook_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SoundTableHook*, void> SoundTableHook_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SoundTableHook*, ACBindings.Internal.CPhysicsObj*, void> Execute; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SoundTableHook*, int> GetType; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SoundTableHook*, ACBindings.Internal.QualifiedDataIDArray*, void> GetSubDataIDs; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SoundTableHook*, uint> pack_size; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SoundTableHook*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SoundTableHook*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.SoundType sound_type_;

    // Methods

    /// <summary>
    /// <code>Offset: 0x005276B0
    /// void __thiscall SoundTableHook::Execute(SoundTableHook*,CPhysicsObj*)</code>
    /// </summary>
    public void Execute(ACBindings.Internal.CPhysicsObj* physobj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SoundTableHook, ACBindings.Internal.CPhysicsObj*, void>)0x005276B0)(ref this, physobj);

    /// <summary>
    /// <code>Offset: 0x005276D0
    /// unsigned int __thiscall SoundTableHook::Pack(SoundHook*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SoundTableHook, void**, uint, uint>)0x005276D0)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005276F0
    /// int __thiscall SoundTableHook::UnPack(SoundTableHook*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SoundTableHook, void**, uint, int>)0x005276F0)(ref this, addr, size);
}

