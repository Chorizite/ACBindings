namespace ACBindings;

// SoundTableHook
public unsafe struct SoundTableHook
{
    // Base Classes
    public ACBindings.CAnimHook BaseClass_CAnimHook; // ACBindings.CAnimHook

    // Child Types
    // SoundTableHook_vtbl
    public unsafe struct SoundTableHook_vtbl
    {
        // Members
        public System.IntPtr SoundTableHook_dtor_0; // function pointer
        public System.IntPtr Execute; // function pointer
        public System.IntPtr GetType; // function pointer
        public System.IntPtr GetSubDataIDs; // function pointer
        public System.IntPtr pack_size; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.SoundType sound_type_;

    // Methods
    // void __thiscall SoundTableHook::Execute(SoundTableHook*,CPhysicsObj*)
    public void Execute(ACBindings.CPhysicsObj* physobj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SoundTableHook, ACBindings.CPhysicsObj*, void>)0x005276B0)(ref this, physobj);
    // unsigned int __thiscall SoundTableHook::Pack(SoundHook*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SoundTableHook, void**, uint, uint>)0x005276D0)(ref this, addr, size);
    // int __thiscall SoundTableHook::UnPack(SoundTableHook*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SoundTableHook, void**, uint, int>)0x005276F0)(ref this, addr, size);
}

