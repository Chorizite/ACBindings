namespace ACBindings;

// ReplaceObjectHook
public unsafe struct ReplaceObjectHook
{
    // Base Classes
    public ACBindings.CAnimHook BaseClass_CAnimHook; // ACBindings.CAnimHook

    // Child Types
    // ReplaceObjectHook_vtbl
    public unsafe struct ReplaceObjectHook_vtbl
    {
        // Members
        public System.IntPtr ReplaceObjectHook_dtor_0; // function pointer
        public System.IntPtr Execute; // function pointer
        public System.IntPtr GetType; // function pointer
        public System.IntPtr GetSubDataIDs; // function pointer
        public System.IntPtr pack_size; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.AnimPartChange ap_change;

    // Generated Constructor
    public ReplaceObjectHook() {
        _ConstructorInternal();
    }

    // Methods
    // unsigned int __thiscall ReplaceObjectHook::pack_size(ReplaceObjectHook*)
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ReplaceObjectHook, uint>)0x00527710)(ref this);
    // unsigned int __thiscall ReplaceObjectHook::Pack(ReplaceObjectHook*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ReplaceObjectHook, void**, uint, uint>)0x00527730)(ref this, addr, size);
    // int __thiscall ReplaceObjectHook::UnPack(ReplaceObjectHook*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ReplaceObjectHook, void**, uint, int>)0x00527740)(ref this, addr, size);
    // void __thiscall ReplaceObjectHook::ReplaceObjectHook(ReplaceObjectHook*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ReplaceObjectHook, void>)0x00527CC0)(ref this);
    // int __thiscall ReplaceObjectHook::GetType(ReplaceObjectHook*)
    public int GetType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ReplaceObjectHook, int>)0x00527CF0)(ref this);
    // void __thiscall ReplaceObjectHook::GetSubDataIDs(ReplaceObjectHook*,QualifiedDataIDArray*)
    public void GetSubDataIDs(ACBindings.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ReplaceObjectHook, ACBindings.QualifiedDataIDArray*, void>)0x00528580)(ref this, id_array);
}

