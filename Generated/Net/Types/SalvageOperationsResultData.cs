namespace ACBindings;

// SalvageOperationsResultData
public unsafe struct SalvageOperationsResultData : System.IDisposable
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // SalvageOperationsResultData_vtbl
    public unsafe struct SalvageOperationsResultData_vtbl
    {
        // Members
        public System.IntPtr SalvageOperationsResultData_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public uint m_skillUsed;
    public ACBindings.PackableList__uint m_notSalvagable;
    public ACBindings.PackableList__SalvageResult m_salvageResults;
    public double m_percentReturn;
    public int m_augBonus;

    // Generated Constructor
    public SalvageOperationsResultData() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // char* __thiscall SalvageOperationsResultData::GetSalvageResults(char*)
    public sbyte* GetSalvageResults() => ((delegate* unmanaged[Thiscall]<ref ACBindings.SalvageOperationsResultData, sbyte*>)0x005CA6D0)(ref this);
    // unsigned int __thiscall SalvageOperationsResultData::Pack(SalvageOperationsResultData*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SalvageOperationsResultData, void**, uint, uint>)0x005CA6E0)(ref this, addr, size);
    // int __thiscall SalvageOperationsResultData::UnPack(SalvageOperationsResultData*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SalvageOperationsResultData, void**, uint, int>)0x005CA770)(ref this, addr, size);
    // void __thiscall SalvageOperationsResultData::SalvageOperationsResultData(SalvageOperationsResultData*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.SalvageOperationsResultData, void>)0x005CAA80)(ref this);
    // void __thiscall SalvageOperationsResultData::~SalvageOperationsResultData(SalvageOperationsResultData*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.SalvageOperationsResultData, void>)0x006AD540)(ref this);
    // int __thiscall SalvageOperationsResultData::GetAugBonus(SalvageOperationsResultData*)
    public int GetAugBonus() => ((delegate* unmanaged[Thiscall]<ref ACBindings.SalvageOperationsResultData, int>)0x006B4B20)(ref this);
}

