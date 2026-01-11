namespace ACBindings.Internal;

public unsafe struct SalvageOperationsResultData : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct SalvageOperationsResultData_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SalvageOperationsResultData*, void> SalvageOperationsResultData_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SalvageOperationsResultData*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SalvageOperationsResultData*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SalvageOperationsResultData*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public uint m_skillUsed;
    public ACBindings.Internal.PackableList__uint m_notSalvagable;
    public ACBindings.Internal.PackableList___SalvageResult m_salvageResults;
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

    /// <summary>
    /// <code>Offset: 0x005CA6D0
    /// char* __thiscall SalvageOperationsResultData::GetSalvageResults(char*)</code>
    /// </summary>
    public sbyte* GetSalvageResults() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SalvageOperationsResultData, sbyte*>)0x005CA6D0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005CA6E0
    /// unsigned int __thiscall SalvageOperationsResultData::Pack(SalvageOperationsResultData*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SalvageOperationsResultData, void**, uint, uint>)0x005CA6E0)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005CA770
    /// int __thiscall SalvageOperationsResultData::UnPack(SalvageOperationsResultData*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SalvageOperationsResultData, void**, uint, int>)0x005CA770)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005CAA80
    /// void __thiscall SalvageOperationsResultData::SalvageOperationsResultData(SalvageOperationsResultData*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SalvageOperationsResultData, void>)0x005CAA80)(ref this);

    /// <summary>
    /// <code>Offset: 0x006AD540
    /// void __thiscall SalvageOperationsResultData::~SalvageOperationsResultData(SalvageOperationsResultData*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SalvageOperationsResultData, void>)0x006AD540)(ref this);

    /// <summary>
    /// <code>Offset: 0x006B4B20
    /// int __thiscall SalvageOperationsResultData::GetAugBonus(SalvageOperationsResultData*)</code>
    /// </summary>
    public int GetAugBonus() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SalvageOperationsResultData, int>)0x006B4B20)(ref this);
}

