namespace ACBindings;

// GenericQualitiesData
public unsafe struct GenericQualitiesData : System.IDisposable
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // GenericQualitiesData_vtbl
    public unsafe struct GenericQualitiesData_vtbl
    {
        // Members
        public System.IntPtr GenericQualitiesData_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

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
    // void __thiscall GenericQualitiesData::GenericQualitiesData(GenericQualitiesData*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.GenericQualitiesData, void>)0x006B8740)(ref this);
    // void __thiscall GenericQualitiesData::~GenericQualitiesData(GenericQualitiesData*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.GenericQualitiesData, void>)0x006B8760)(ref this);
    // unsigned int __thiscall GenericQualitiesData::Pack(GenericQualitiesData*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.GenericQualitiesData, void**, uint, uint>)0x006B87C0)(ref this, addr, size);
    // int __thiscall GenericQualitiesData::UnPack(GenericQualitiesData*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.GenericQualitiesData, void**, uint, int>)0x006B8880)(ref this, addr, size);
    // int __thiscall GenericQualitiesData::InqString(_DWORD*,int,int*)
    public int InqString(int a2, int* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.GenericQualitiesData, int, int*, int>)0x006B8A30)(ref this, a2, a3);
    // int __thiscall GenericQualitiesData::SetString(_DWORD*,unsigned int,int*)
    public int SetString(uint a2, int* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.GenericQualitiesData, uint, int*, int>)0x006B8A60)(ref this, a2, a3);
}

