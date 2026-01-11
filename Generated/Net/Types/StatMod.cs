namespace ACBindings.Internal;

public unsafe struct StatMod
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct StatMod_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.StatMod*, void> StatMod_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.StatMod*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.StatMod*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.StatMod*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public uint type;
    public uint key;
    public float val;

    // Methods

    /// <summary>
    /// <code>Offset: 0x005B75E0
    /// int __thiscall StatMod::UnPack(ShortCutData*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StatMod, void**, uint, int>)0x005B75E0)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005BE160
    /// unsigned int __thiscall StatMod::Pack(StatMod*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StatMod, void**, uint, uint>)0x005BE160)(ref this, addr, size);
}

