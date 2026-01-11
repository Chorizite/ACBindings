namespace ACBindings.Internal;

public unsafe struct SalvageOperationData
{
    // Base Classes
    public ACBindings.Internal.PackableList__uint BaseClass_PackableList__uint; // ACBindings.Internal.PackableList__uint

    // Child Types
    public unsafe struct SalvageOperationData_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SalvageOperationData*, void> SalvageOperationData_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SalvageOperationData*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SalvageOperationData*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SalvageOperationData*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public uint m_material;
    public uint m_skillUsed;
    public int m_maxWorkmanship;
    public int m_minWorkmanship;
    public double m_percentageReturn;
    public int m_totalSalvageWorkmanship;
    public int m_totalSalvageValue;
    public int m_totalCombineWorkmanship;
    public int m_totalCombineValue;
    public int m_totalNumberItems;
    public int m_totalCombinePower;

    // Methods
}

