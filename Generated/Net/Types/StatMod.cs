namespace ACBindings;

// StatMod
public unsafe struct StatMod
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // StatMod_vtbl
    public unsafe struct StatMod_vtbl
    {
        // Members
        public System.IntPtr StatMod_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public uint type;
    public uint key;
    public float val;

    // Methods
    // int __thiscall StatMod::UnPack(ShortCutData*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.StatMod, void**, uint, int>)0x005B75E0)(ref this, addr, size);
    // unsigned int __thiscall StatMod::Pack(StatMod*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.StatMod, void**, uint, uint>)0x005BE160)(ref this, addr, size);
}

