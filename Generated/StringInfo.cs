namespace ACBindings;

// StringInfo
public unsafe struct StringInfo : System.IDisposable
{
    // Child Types
    // StringInfo::StringInfo_Override_Flag
    public enum StringInfo_Override_Flag : byte
    {
        SI_NONE = 0x0,
        SI_LITERAL = 0x1,
        SI_AUTOGEN = 0x2
    }

    // Members
    public ACBindings.PStringBase__sbyte m_strToken;
    public uint m_stringID;
    public ACBindings.IDClass___tagDataID m_tableID;
    public ACBindings.HashTable__uint__StringInfoData_ptr m_variables;
    public ACBindings.PStringBase__ushort m_LiteralValue;
    public byte m_Override;
    public ACBindings.PStringBase__sbyte m_strEnglish;
    public ACBindings.PStringBase__sbyte m_strComment;

    // Generated Constructor
    public StringInfo() {
        _ConstructorInternal();
    }
    public StringInfo(ACBindings.StringInfo* copy) {
        _ConstructorInternal(copy);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall StringInfo::SetTableEnum(StringInfo*,int)
    public void SetTableEnum(int strtableEnum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.StringInfo, int, void>)0x0042C980)(ref this, strtableEnum);
    // void __thiscall StringInfo::SetStringIDandTableEnum(StringInfo*,unsigned int,int)
    public void SetStringIDandTableEnum(uint stringID, int strtableEnum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.StringInfo, uint, int, void>)0x0042C9C0)(ref this, stringID, strtableEnum);
    // int __thiscall StringInfo::SetStringIDandTableID(_DWORD*,int,int)
    public int SetStringIDandTableID(int a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.StringInfo, int, int, int>)0x0042CA10)(ref this, a2, a3);
    // bool __thiscall StringInfo::InqStringTableFile(_DWORD*,volatile LONG**)
    public byte InqStringTableFile(int** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.StringInfo, int**, byte>)0x0042CA50)(ref this, a2);
    // int __thiscall StringInfo::SetLiteralValue(int,int*,wchar_t*)
    public int SetLiteralValue(int* a2, System.IntPtr a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.StringInfo, int*, System.IntPtr, int>)0x0042CBE0)(ref this, a2, a3);
    // _DWORD* __thiscall StringInfo::GetLiteralValue(_DWORD*,_DWORD*,int)
    public int* GetLiteralValue(int* a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.StringInfo, int*, int, int*>)0x0042CCB0)(ref this, a2, a3);
    // bool __thiscall StringInfo::IsValid(StringInfo*,bool)
    public byte IsValid(byte bValidateChildren) => ((delegate* unmanaged[Thiscall]<ref ACBindings.StringInfo, byte, byte>)0x0042CE00)(ref this, bValidateChildren);
    // void __thiscall StringInfo::GetSubDataIDs(StringInfo*,QualifiedDataIDArray*)
    public void GetSubDataIDs(ACBindings.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.StringInfo, ACBindings.QualifiedDataIDArray*, void>)0x0042CED0)(ref this, id_array);
    // int* __thiscall StringInfo::GetSubPrivateIDs(unsigned int*,QualifiedDataIDArray*,int)
    public int* GetSubPrivateIDs(ACBindings.QualifiedDataIDArray* a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.StringInfo, ACBindings.QualifiedDataIDArray*, int, int*>)0x0042CF60)(ref this, a2, a3);
    // bool __thiscall StringInfo::FromFileNode(StringInfo*,const PFileNode*)
    public byte FromFileNode(ACBindings.PFileNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.StringInfo, ACBindings.PFileNode*, byte>)0x0042D020)(ref this, node);
    // void __thiscall StringInfo::ClearVars(StringInfo*)
    public void ClearVars() => ((delegate* unmanaged[Thiscall]<ref ACBindings.StringInfo, void>)0x0042DAF0)(ref this);
    // void __thiscall StringInfo::AddVar(StringInfo*,StringInfoData*)
    public void AddVar(ACBindings.StringInfoData* i_pcNewData) => ((delegate* unmanaged[Thiscall]<ref ACBindings.StringInfo, ACBindings.StringInfoData*, void>)0x0042DB60)(ref this, i_pcNewData);
    // void __thiscall StringInfo::StringInfo(StringInfo*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.StringInfo, void>)0x0042DC80)(ref this);
    // void __thiscall StringInfo::Reset(StringInfo*)
    public void Reset() => ((delegate* unmanaged[Thiscall]<ref ACBindings.StringInfo, void>)0x0042DD10)(ref this);
    // void __thiscall StringInfo::AddVariable_Int(StringInfo*,unsigned int,__int64)
    public void AddVariable_Int(uint varID, long varValue) => ((delegate* unmanaged[Thiscall]<ref ACBindings.StringInfo, uint, long, void>)0x0042E000)(ref this, varID, varValue);
    // void __thiscall StringInfo::AddVariable_UInt(StringInfo*,unsigned int,unsigned __int64)
    public void AddVariable_UInt(uint varID, ulong varValue) => ((delegate* unmanaged[Thiscall]<ref ACBindings.StringInfo, uint, ulong, void>)0x0042E040)(ref this, varID, varValue);
    // void __thiscall StringInfo::AddVariable_Float(StringInfo*,unsigned int,long double,unsigned __int16)
    public void AddVariable_Float(uint varID, double varValue, ushort precision) => ((delegate* unmanaged[Thiscall]<ref ACBindings.StringInfo, uint, double, ushort, void>)0x0042E080)(ref this, varID, varValue, precision);
    // void __thiscall StringInfo::Serialize(StringInfo*,Archive*)
    public void Serialize(ACBindings.Archive* rArchive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.StringInfo, ACBindings.Archive*, void>)0x0042E0D0)(ref this, rArchive);
    // int __thiscall StringInfo::InqStringInternal(int,wchar_t*,char)
    public int InqStringInternal(System.IntPtr Source, sbyte a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.StringInfo, System.IntPtr, sbyte, int>)0x0042E240)(ref this, Source, a3);
    // void __thiscall StringInfo::StringInfo(StringInfo*,const StringInfo*)
    public void _ConstructorInternal(ACBindings.StringInfo* copy) => ((delegate* unmanaged[Thiscall]<ref ACBindings.StringInfo, ACBindings.StringInfo*, void>)0x0042E510)(ref this, copy);
    // void __thiscall StringInfo::~StringInfo(StringInfo*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.StringInfo, void>)0x0042E590)(ref this);
    // void __thiscall StringInfo::AddVariable_StringInfo(StringInfo*,unsigned int,const StringInfo*)
    public void AddVariable_StringInfo(uint varID, ACBindings.StringInfo* si) => ((delegate* unmanaged[Thiscall]<ref ACBindings.StringInfo, uint, ACBindings.StringInfo*, void>)0x0042E660)(ref this, varID, si);
    // char __thiscall StringInfo::InqString(void*,wchar_t*,int)
    public sbyte InqString(System.IntPtr a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.StringInfo, System.IntPtr, int, sbyte>)0x0042E6B0)(ref this, a2, a3);
    // int* __thiscall StringInfo::GetLogString(_DWORD*,int*,wchar_t*)
    public int* GetLogString(int* a2, System.IntPtr Destination) => ((delegate* unmanaged[Thiscall]<ref ACBindings.StringInfo, int*, System.IntPtr, int*>)0x0042E740)(ref this, a2, Destination);
    // LONG __thiscall StringInfo::AddVariable_String(StringInfo*,unsigned int,int)
    public int AddVariable_String(uint i_eVarID, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.StringInfo, uint, int, int>)0x0042E8E0)(ref this, i_eVarID, a3);
    // _DWORD* __thiscall StringInfo::GetString(void*,_DWORD*,int)
    public int* GetString(int* a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.StringInfo, int*, int, int*>)0x0042E980)(ref this, a2, a3);
}

