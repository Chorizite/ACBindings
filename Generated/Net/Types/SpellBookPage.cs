namespace ACBindings;

// SpellBookPage
public unsafe struct SpellBookPage
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // SpellBookPage_vtbl
    public unsafe struct SpellBookPage_vtbl
    {
        // Members
        public System.IntPtr SpellBookPage_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public float _casting_likelihood;

    // Methods
    // unsigned int __thiscall SpellBookPage::Pack(SpellBookPage*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SpellBookPage, void**, uint, uint>)0x005CD180)(ref this, addr, size);
    // int __thiscall SpellBookPage::UnPack(SpellBookPage*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SpellBookPage, void**, uint, int>)0x005CD1B0)(ref this, addr, size);
}

