namespace ACBindings;

// OrderHdr
public unsafe struct OrderHdr
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // OrderHdr_vtbl
    public unsafe struct OrderHdr_vtbl
    {
        // Members
        public System.IntPtr OrderHdr_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public uint stamp_;

    // Methods
    // unsigned int __thiscall OrderHdr::Pack(OrderHdr*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.OrderHdr, void**, uint, uint>)0x006B4010)(ref this, addr, size);
    // int __thiscall OrderHdr::UnPack(OrderHdr*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.OrderHdr, void**, uint, int>)0x006B4040)(ref this, addr, size);
}

