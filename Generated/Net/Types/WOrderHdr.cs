namespace ACBindings.Internal;

public unsafe struct WOrderHdr
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct WOrderHdr_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.WOrderHdr*, void> WOrderHdr_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.WOrderHdr*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.WOrderHdr*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.WOrderHdr*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public int isFromWeenie_;
    public uint iid_;
    public uint stamp_;

    // Methods

    /// <summary>
    /// <code>Offset: 0x006B1970
    /// unsigned int __thiscall WOrderHdr::Pack(WOrderHdr*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.WOrderHdr, void**, uint, uint>)0x006B1970)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x006B19B0
    /// int __thiscall WOrderHdr::UnPack(WOrderHdr*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.WOrderHdr, void**, uint, int>)0x006B19B0)(ref this, addr, size);
}

