namespace ACBindings;

// SoundHook
public unsafe struct SoundHook
{
    // Base Classes
    public ACBindings.CAnimHook BaseClass_CAnimHook; // ACBindings.CAnimHook

    // Child Types
    // SoundHook_vtbl
    public unsafe struct SoundHook_vtbl
    {
        // Members
        public System.IntPtr SoundHook_dtor_0; // function pointer
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

    // Generated Constructor
    public SoundHook() {
        _ConstructorInternal();
    }

    // Methods
    // void __thiscall SoundHook::SoundHook(SoundHook*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.SoundHook, void>)0x00527600)(ref this);
    // void __thiscall SoundHook::Execute(SoundHook*,CPhysicsObj*)
    public void Execute(ACBindings.CPhysicsObj* physobj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SoundHook, ACBindings.CPhysicsObj*, void>)0x00527620)(ref this, physobj);
    // int __thiscall SoundHook::UnPack(SoundHook*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SoundHook, void**, uint, int>)0x005282C0)(ref this, addr, size);
}

