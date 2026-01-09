namespace ACBindings;

// SoundTweakedHook
public unsafe struct SoundTweakedHook
{
    // Base Classes
    public ACBindings.CAnimHook BaseClass_CAnimHook; // ACBindings.CAnimHook

    // Child Types
    // SoundTweakedHook_vtbl
    public unsafe struct SoundTweakedHook_vtbl
    {
        // Members
        public System.IntPtr SoundTweakedHook_dtor_0; // function pointer
        public System.IntPtr Execute; // function pointer
        public System.IntPtr GetType; // function pointer
        public System.IntPtr GetSubDataIDs; // function pointer
        public System.IntPtr pack_size; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.IDClass___tagDataID gid_;
    public float prio;
    public float prob;
    public float vol;

    // Generated Constructor
    public SoundTweakedHook() {
        _ConstructorInternal();
    }

    // Methods
    // void __thiscall SoundTweakedHook::SoundTweakedHook(SoundTweakedHook*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.SoundTweakedHook, void>)0x00527640)(ref this);
    // void __thiscall SoundTweakedHook::Execute(SoundTweakedHook*,CPhysicsObj*)
    public void Execute(ACBindings.CPhysicsObj* physobj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SoundTweakedHook, ACBindings.CPhysicsObj*, void>)0x00527680)(ref this, physobj);
    // unsigned int __thiscall SoundTweakedHook::Pack(SoundTweakedHook*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SoundTweakedHook, void**, uint, uint>)0x00528330)(ref this, addr, size);
    // int __thiscall SoundTweakedHook::UnPack(SoundTweakedHook*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SoundTweakedHook, void**, uint, int>)0x00528380)(ref this, addr, size);
}

