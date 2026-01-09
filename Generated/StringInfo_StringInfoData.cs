namespace ACBindings;

// StringInfo_StringInfoData
public unsafe struct StringInfo_StringInfoData
{
    // Base Classes
    public ACBindings.StringInfoData BaseClass_StringInfoData; // ACBindings.StringInfoData

    // Child Types
    // StringInfo_StringInfoData_vtbl
    public unsafe struct StringInfo_StringInfoData_vtbl
    {
        // Members
        public System.IntPtr StringInfo_StringInfoData_dtor_0; // function pointer
        public System.IntPtr GetSubDataIDs; // function pointer
        public System.IntPtr GetSubPrivateIDs;
        public System.IntPtr IsValid; // function pointer
        public System.IntPtr Serialize; // function pointer
        public System.IntPtr ToString;

        // Methods
    }

    // Members
    public ACBindings.StringInfo m_cVal;

    // Generated Constructor
    public StringInfo_StringInfoData(uint i_eVarID) {
        _ConstructorInternal(i_eVarID);
    }

    // Methods
    // void __thiscall StringInfo_StringInfoData::StringInfo_StringInfoData(StringInfo_StringInfoData*,unsigned int)
    public void _ConstructorInternal(uint i_eVarID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.StringInfo_StringInfoData, uint, void>)0x0042EA40)(ref this, i_eVarID);
    // void __thiscall StringInfo_StringInfoData::GetSubDataIDs(StringInfo_StringInfoData*,QualifiedDataIDArray*)
    public void GetSubDataIDs(ACBindings.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.StringInfo_StringInfoData, ACBindings.QualifiedDataIDArray*, void>)0x0042EAE0)(ref this, id_array);
    // bool __thiscall StringInfo_StringInfoData::IsValid(StringInfo_StringInfoData*,bool)
    public byte IsValid(byte i_bValidateChildren) => ((delegate* unmanaged[Thiscall]<ref ACBindings.StringInfo_StringInfoData, byte, byte>)0x0042EAF0)(ref this, i_bValidateChildren);
    // void __thiscall StringInfo_StringInfoData::Serialize(StringInfo_StringInfoData*,Archive*)
    public void Serialize(ACBindings.Archive* io_rcArchive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.StringInfo_StringInfoData, ACBindings.Archive*, void>)0x0042F150)(ref this, io_rcArchive);
    // int* __thiscall StringInfo_StringInfoData::GetSubPrivateIDs(unsigned int*,QualifiedDataIDArray*,int)
    public int* GetSubPrivateIDs(ACBindings.QualifiedDataIDArray* a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.StringInfo_StringInfoData, ACBindings.QualifiedDataIDArray*, int, int*>)0x0042F170)(ref this, a2, a3);
    // volatile LONG** __thiscall StringInfo_StringInfoData::ToString(_DWORD*,volatile LONG**)
    public int** ToString(int** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.StringInfo_StringInfoData, int**, int**>)0x0042F920)(ref this, a2);
}

