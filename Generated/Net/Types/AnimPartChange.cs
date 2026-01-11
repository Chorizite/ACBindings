namespace ACBindings.Internal;

public unsafe struct AnimPartChange
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct AnimPartChange_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AnimPartChange*, void> AnimPartChange_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AnimPartChange*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AnimPartChange*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AnimPartChange*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public uint part_index;
    public ACBindings.Internal.IDClass____tagDataID part_id;
    public ACBindings.Internal.AnimPartChange* prev;
    public ACBindings.Internal.AnimPartChange* next;

    // Methods

    /// <summary>
    /// <code>Offset: 0x005AEA60
    /// unsigned int __thiscall AnimPartChange::Pack(AnimPartChange*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AnimPartChange, void**, uint, uint>)0x005AEA60)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005AEAC0
    /// int __thiscall AnimPartChange::UnPack(AnimPartChange*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AnimPartChange, void**, uint, int>)0x005AEAC0)(ref this, addr, size);
}

