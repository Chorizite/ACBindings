namespace ACBindings.Internal;

public unsafe struct SoundHook
{
    // Base Classes
    public ACBindings.Internal.CAnimHook BaseClass_CAnimHook; // ACBindings.Internal.CAnimHook

    // Child Types
    public unsafe struct SoundHook_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SoundHook*, void> SoundHook_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SoundHook*, ACBindings.Internal.CPhysicsObj*, void> Execute; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SoundHook*, int> GetType; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SoundHook*, ACBindings.Internal.QualifiedDataIDArray*, void> GetSubDataIDs; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SoundHook*, uint> pack_size; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SoundHook*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SoundHook*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.IDClass____tagDataID gid_;

    // Generated Constructor
    public SoundHook() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x00527600
    /// void __thiscall SoundHook::SoundHook(SoundHook*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SoundHook, void>)0x00527600)(ref this);

    /// <summary>
    /// <code>Offset: 0x00527620
    /// void __thiscall SoundHook::Execute(SoundHook*,CPhysicsObj*)</code>
    /// </summary>
    public void Execute(ACBindings.Internal.CPhysicsObj* physobj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SoundHook, ACBindings.Internal.CPhysicsObj*, void>)0x00527620)(ref this, physobj);

    /// <summary>
    /// <code>Offset: 0x005282C0
    /// int __thiscall SoundHook::UnPack(SoundHook*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SoundHook, void**, uint, int>)0x005282C0)(ref this, addr, size);
}

