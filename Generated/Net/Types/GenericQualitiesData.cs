namespace ACBindings.Internal;

public unsafe struct GenericQualitiesData : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct GenericQualitiesData_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.GenericQualitiesData*, void> GenericQualitiesData_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.GenericQualitiesData*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.GenericQualitiesData*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.GenericQualitiesData*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr m_pIntStatsTable;
    public System.IntPtr m_pBoolStatsTable;
    public System.IntPtr m_pFloatStatsTable;
    public System.IntPtr m_pStrStatsTable;

    // Generated Constructor
    public GenericQualitiesData() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x006B8740
    /// void __thiscall GenericQualitiesData::GenericQualitiesData(GenericQualitiesData*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GenericQualitiesData, void>)0x006B8740)(ref this);

    /// <summary>
    /// <code>Offset: 0x006B8760
    /// void __thiscall GenericQualitiesData::~GenericQualitiesData(GenericQualitiesData*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GenericQualitiesData, void>)0x006B8760)(ref this);

    /// <summary>
    /// <code>Offset: 0x006B87C0
    /// unsigned int __thiscall GenericQualitiesData::Pack(GenericQualitiesData*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GenericQualitiesData, void**, uint, uint>)0x006B87C0)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x006B8880
    /// int __thiscall GenericQualitiesData::UnPack(GenericQualitiesData*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GenericQualitiesData, void**, uint, int>)0x006B8880)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x006B8A30
    /// int __thiscall GenericQualitiesData::InqString(_DWORD*,int,int*)</code>
    /// </summary>
    public int InqString(int a2, int* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GenericQualitiesData, int, int*, int>)0x006B8A30)(ref this, a2, a3);

    /// <summary>
    /// <code>Offset: 0x006B8A60
    /// int __thiscall GenericQualitiesData::SetString(_DWORD*,unsigned int,int*)</code>
    /// </summary>
    public int SetString(uint a2, int* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GenericQualitiesData, uint, int*, int>)0x006B8A60)(ref this, a2, a3);
}

