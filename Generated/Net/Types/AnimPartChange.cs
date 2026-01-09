namespace ACBindings;

// AnimPartChange
public unsafe struct AnimPartChange
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // AnimPartChange_vtbl
    public unsafe struct AnimPartChange_vtbl
    {
        // Members
        public System.IntPtr AnimPartChange_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public uint part_index;
    public ACBindings.IDClass___tagDataID part_id;
    public ACBindings.AnimPartChange* prev;
    public ACBindings.AnimPartChange* next;

    // Methods
    // unsigned int __thiscall AnimPartChange::Pack(AnimPartChange*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AnimPartChange, void**, uint, uint>)0x005AEA60)(ref this, addr, size);
    // int __thiscall AnimPartChange::UnPack(AnimPartChange*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AnimPartChange, void**, uint, int>)0x005AEAC0)(ref this, addr, size);
}

