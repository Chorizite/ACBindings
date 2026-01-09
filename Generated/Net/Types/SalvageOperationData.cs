namespace ACBindings;

// SalvageOperationData
public unsafe struct SalvageOperationData
{
    // Base Classes
    public ACBindings.PackableList__uint BaseClass_PackableList__uint; // ACBindings.PackableList__uint

    // Child Types
    // SalvageOperationData_vtbl
    public unsafe struct SalvageOperationData_vtbl
    {
        // Members
        public System.IntPtr SalvageOperationData_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

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

