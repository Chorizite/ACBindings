namespace ACBindings;

// WOrderHdr
public unsafe struct WOrderHdr
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // WOrderHdr_vtbl
    public unsafe struct WOrderHdr_vtbl
    {
        // Members
        public System.IntPtr WOrderHdr_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public int isFromWeenie_;
    public uint iid_;
    public uint stamp_;

    // Methods
    // unsigned int __thiscall WOrderHdr::Pack(WOrderHdr*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.WOrderHdr, void**, uint, uint>)0x006B1970)(ref this, addr, size);
    // int __thiscall WOrderHdr::UnPack(WOrderHdr*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.WOrderHdr, void**, uint, int>)0x006B19B0)(ref this, addr, size);
}

