namespace ACBindings.Internal;

public unsafe struct OrderHdr
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct OrderHdr_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.OrderHdr*, void> OrderHdr_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.OrderHdr*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.OrderHdr*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.OrderHdr*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public uint stamp_;

    // Methods

    /// <summary>
    /// <code>Offset: 0x006B4010
    /// unsigned int __thiscall OrderHdr::Pack(OrderHdr*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.OrderHdr, void**, uint, uint>)0x006B4010)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x006B4040
    /// int __thiscall OrderHdr::UnPack(OrderHdr*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.OrderHdr, void**, uint, int>)0x006B4040)(ref this, addr, size);
}

