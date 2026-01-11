namespace ACBindings.Internal;

public unsafe struct SoundTweakedHook
{
    // Base Classes
    public ACBindings.Internal.CAnimHook BaseClass_CAnimHook; // ACBindings.Internal.CAnimHook

    // Child Types
    public unsafe struct SoundTweakedHook_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SoundTweakedHook*, void> SoundTweakedHook_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SoundTweakedHook*, ACBindings.Internal.CPhysicsObj*, void> Execute; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SoundTweakedHook*, int> GetType; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SoundTweakedHook*, ACBindings.Internal.QualifiedDataIDArray*, void> GetSubDataIDs; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SoundTweakedHook*, uint> pack_size; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SoundTweakedHook*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SoundTweakedHook*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.IDClass____tagDataID gid_;
    public float prio;
    public float prob;
    public float vol;

    // Generated Constructor
    public SoundTweakedHook() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x00527640
    /// void __thiscall SoundTweakedHook::SoundTweakedHook(SoundTweakedHook*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SoundTweakedHook, void>)0x00527640)(ref this);

    /// <summary>
    /// <code>Offset: 0x00527680
    /// void __thiscall SoundTweakedHook::Execute(SoundTweakedHook*,CPhysicsObj*)</code>
    /// </summary>
    public void Execute(ACBindings.Internal.CPhysicsObj* physobj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SoundTweakedHook, ACBindings.Internal.CPhysicsObj*, void>)0x00527680)(ref this, physobj);

    /// <summary>
    /// <code>Offset: 0x00528330
    /// unsigned int __thiscall SoundTweakedHook::Pack(SoundTweakedHook*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SoundTweakedHook, void**, uint, uint>)0x00528330)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x00528380
    /// int __thiscall SoundTweakedHook::UnPack(SoundTweakedHook*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SoundTweakedHook, void**, uint, int>)0x00528380)(ref this, addr, size);
}

