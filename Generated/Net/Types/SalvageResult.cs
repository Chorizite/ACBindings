namespace ACBindings.Internal;

public unsafe struct SalvageResult
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct SalvageResult_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SalvageResult*, void> SalvageResult_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SalvageResult*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SalvageResult*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SalvageResult*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public uint m_material;
    public double m_workmanship;
    public int m_units;

    // Methods

    /// <summary>
    /// <code>Offset: 0x005CA810
    /// unsigned int __thiscall SalvageResult::Pack(SalvageResult*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SalvageResult, void**, uint, uint>)0x005CA810)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005CA850
    /// int __thiscall SalvageResult::UnPack(SalvageResult*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SalvageResult, void**, uint, int>)0x005CA850)(ref this, addr, size);
}

