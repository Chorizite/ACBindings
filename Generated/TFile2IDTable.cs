namespace ACBindings;

// TFile2IDTable
public unsafe struct TFile2IDTable : System.IDisposable
{
    // Base Classes
    public ACBindings.TReadOnlyFile2IDTable BaseClass_TReadOnlyFile2IDTable; // ACBindings.TReadOnlyFile2IDTable

    // Child Types
    // TFile2IDTable_vtbl
    public unsafe struct TFile2IDTable_vtbl
    {
        // Members
        public System.IntPtr GetDIDByFileName;
        public System.IntPtr GetFileNameByDID;
        public System.IntPtr GetFullPathByDID;
        public System.IntPtr GetFullPathByFileName;
        public System.IntPtr GetDBTypeString;
        public System.IntPtr GetHighestDID;
        public System.IntPtr GetDBTypes;
        public System.IntPtr GetDIDs;
        public System.IntPtr GetFilePaths;
        public System.IntPtr Clear; // function pointer
        public System.IntPtr GetFileWriteTimeByFileName;
        public System.IntPtr GetFileWriteTimeByDID;
        public System.IntPtr AssignDIDToFileName;
        public System.IntPtr AssignNonAuthoritativePathToFileName;
        public System.IntPtr AssignSoonToExistFilePath;
        public System.IntPtr RemoveFilenameFromCache;
        public System.IntPtr RemoveDirectoryFromCache;
        public System.IntPtr RegisterDBType;
        public System.IntPtr IsDBTypeRegistered; // function pointer
        public System.IntPtr IsDBDirSearched; // function pointer
        public System.IntPtr AssignPathToFileNameInternal;
        public System.IntPtr FindEntryByName;
        public System.IntPtr FindEntryByDID;
        public System.IntPtr GetFullPathByEntry;
        public System.IntPtr GetFileWriteTimeByEntry; // function pointer
        public System.IntPtr GetDBTypeEntry; // function pointer

        // Methods
    }

    // Members
    public ACBindings.AutoGrowHashTable__CaseInsensitiveStringBase__PStringBase__sbyte__TFileEntry_ptr m_CacheByFileName;
    public ACBindings.AutoGrowHashTable__uint__TDBTypeEntry_ptr m_CacheByDID;

    // Generated Constructor
    public TFile2IDTable(uint ExpectedTableSize) {
        _ConstructorInternal(ExpectedTableSize);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // bool __thiscall TFile2IDTable::GetFileWriteTimeByEntry(TFile2IDTable*,TFileEntry*,int*)
    public byte GetFileWriteTimeByEntry(ACBindings.TFileEntry* pEntry, int* FileWriteTime) => ((delegate* unmanaged[Thiscall]<ref ACBindings.TFile2IDTable, ACBindings.TFileEntry*, int*, byte>)0x00679320)(ref this, pEntry, FileWriteTime);
    // char __thiscall TFile2IDTable::GetFileWriteTimeByDID(int*,int,int,_DWORD*)
    public sbyte GetFileWriteTimeByDID(int a2, int a3, int* a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.TFile2IDTable, int, int, int*, sbyte>)0x00679340)(ref this, a2, a3, a4);
    // unsigned int* __thiscall TFile2IDTable::GetHighestDID(void*,unsigned int*,int)
    public uint* GetHighestDID(uint* a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.TFile2IDTable, uint*, int, uint*>)0x006793A0)(ref this, a2, a3);
    // unsigned int* __thiscall TFile2IDTable::GetDIDByFileName(void*,unsigned int*,int,int)
    public uint* GetDIDByFileName(uint* a2, int a3, int a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.TFile2IDTable, uint*, int, int, uint*>)0x00679670)(ref this, a2, a3, a4);
    // char __thiscall TFile2IDTable::GetFileNameByDID(_DWORD*,int,int,int*)
    public sbyte GetFileNameByDID(int a2, int a3, int* a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.TFile2IDTable, int, int, int*, sbyte>)0x00679730)(ref this, a2, a3, a4);
    // char __thiscall TFile2IDTable::GetFullPathByDID(int*,int,int,void**)
    public sbyte GetFullPathByDID(int a2, int a3, void** a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.TFile2IDTable, int, int, void**, sbyte>)0x006797D0)(ref this, a2, a3, a4);
    // char __thiscall TFile2IDTable::GetFullPathByFileName(void*,int,int,PStringBase<char>*)
    public sbyte GetFullPathByFileName(int a2, int a3, ACBindings.PStringBase__sbyte* a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.TFile2IDTable, int, int, ACBindings.PStringBase__sbyte*, sbyte>)0x00679860)(ref this, a2, a3, a4);
    // char __thiscall TFile2IDTable::GetFileWriteTimeByFileName(void*,int,int,_DWORD*)
    public sbyte GetFileWriteTimeByFileName(int a2, int a3, int* a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.TFile2IDTable, int, int, int*, sbyte>)0x006799C0)(ref this, a2, a3, a4);
    // void** __thiscall TFile2IDTable::GetDBTypeString(void*,void**,int)
    public void** GetDBTypeString(void** a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.TFile2IDTable, void**, int, void**>)0x00679A90)(ref this, a2, a3);
    // char __stdcall TFile2IDTable::SanitizeEntry(LPCSTR*,_DWORD**)
    public static sbyte SanitizeEntry(sbyte** a1, int** a2) => ((delegate* unmanaged[Stdcall]<sbyte**, int**, sbyte>)0x00679AE0)(a1, a2);
    // bool __stdcall TFile2IDTable::ReformatDirectoryName(char*,_BYTE*)
    public static byte ReformatDirectoryName(sbyte* a1, byte* a2) => ((delegate* unmanaged[Stdcall]<sbyte*, byte*, byte>)0x00679BF0)(a1, a2);
    // bool __thiscall TFile2IDTable::AssignSoonToExistFilePath(void*,int)
    public byte AssignSoonToExistFilePath(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.TFile2IDTable, int, byte>)0x00679C80)(ref this, a2);
    // char __thiscall TFile2IDTable::RegisterDBType(int*,int,int,char*,char*)
    public sbyte RegisterDBType(int a2, int a3, sbyte* a4, sbyte* a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.TFile2IDTable, int, int, sbyte*, sbyte*, sbyte>)0x00679DA0)(ref this, a2, a3, a4, a5);
    // char __stdcall TFile2IDTable::GetFullPathByEntry(int,char*)
    public static sbyte GetFullPathByEntry(int a1, sbyte* Source) => ((delegate* unmanaged[Stdcall]<int, sbyte*, sbyte>)0x0067A010)(a1, Source);
    // bool __thiscall TFile2IDTable::IsDBTypeRegistered(TFile2IDTable*,unsigned int)
    public byte IsDBTypeRegistered(uint dbtype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.TFile2IDTable, uint, byte>)0x0067A110)(ref this, dbtype);
    // bool __thiscall TFile2IDTable::IsDBDirSearched(TFile2IDTable*,unsigned int)
    public byte IsDBDirSearched(uint dbtype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.TFile2IDTable, uint, byte>)0x0067A160)(ref this, dbtype);
    // char __thiscall TFile2IDTable::FindEntryByDID(void*,unsigned int,int,_DWORD*)
    public sbyte FindEntryByDID(uint a2, int a3, int* a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.TFile2IDTable, uint, int, int*, sbyte>)0x0067A2A0)(ref this, a2, a3, a4);
    // char __thiscall TFile2IDTable::GetDBTypes(_DWORD*,_DWORD*)
    public sbyte GetDBTypes(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.TFile2IDTable, int*, sbyte>)0x0067A590)(ref this, a2);
    // char __thiscall TFile2IDTable::GetDIDs(_DWORD*,_DWORD*,unsigned int)
    public sbyte GetDIDs(int* a2, uint a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.TFile2IDTable, int*, uint, sbyte>)0x0067A6B0)(ref this, a2, a3);
    // char __thiscall TFile2IDTable::GetFilePaths(_DWORD*,_DWORD*)
    public sbyte GetFilePaths(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.TFile2IDTable, int*, sbyte>)0x0067A800)(ref this, a2);
    // char __thiscall TFile2IDTable::RemoveFilenameFromCache(_DWORD*,int*)
    public sbyte RemoveFilenameFromCache(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.TFile2IDTable, int*, sbyte>)0x0067A990)(ref this, a2);
    // char __thiscall TFile2IDTable::RemoveDirectoryFromCache(_DWORD*,const char**)
    public sbyte RemoveDirectoryFromCache(sbyte** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.TFile2IDTable, sbyte**, sbyte>)0x0067AA70)(ref this, a2);
    // char __thiscall TFile2IDTable::AssignDIDToFileName(void*,int,unsigned int,_DWORD*)
    public sbyte AssignDIDToFileName(int a2, uint a3, int* a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.TFile2IDTable, int, uint, int*, sbyte>)0x0067B300)(ref this, a2, a3, a4);
    // char __thiscall TFile2IDTable::AssignNonAuthoritativePathToFileName(_DWORD*,char*,char*)
    public sbyte AssignNonAuthoritativePathToFileName(sbyte* a2, sbyte* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.TFile2IDTable, sbyte*, sbyte*, sbyte>)0x0067B4F0)(ref this, a2, a3);
    // bool __thiscall TFile2IDTable::FindEntryByName(_DWORD*,char*,IDClass<_tagDataID,32,0>**,char*)
    public byte FindEntryByName(sbyte* a2, ACBindings.IDClass___tagDataID** a3, sbyte* a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.TFile2IDTable, sbyte*, ACBindings.IDClass___tagDataID**, sbyte*, byte>)0x0067B6B0)(ref this, a2, a3, a4);
    // char __thiscall TFile2IDTable::AssignPathToFileNameInternal(_DWORD*,volatile LONG*,char*,char*)
    public sbyte AssignPathToFileNameInternal(int* a2, sbyte* a3, sbyte* String1) => ((delegate* unmanaged[Thiscall]<ref ACBindings.TFile2IDTable, int*, sbyte*, sbyte*, sbyte>)0x0067B9A0)(ref this, a2, a3, String1);
    // void __thiscall TFile2IDTable::Clear(TFile2IDTable*)
    public void Clear() => ((delegate* unmanaged[Thiscall]<ref ACBindings.TFile2IDTable, void>)0x0067BEE0)(ref this);
    // TDBTypeEntry* __thiscall TFile2IDTable::GetDBTypeEntry(TFile2IDTable*,unsigned int)
    public ACBindings.TDBTypeEntry* GetDBTypeEntry(uint dbtype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.TFile2IDTable, uint, ACBindings.TDBTypeEntry*>)0x0067C080)(ref this, dbtype);
    // void __thiscall TFile2IDTable::~TFile2IDTable(TFile2IDTable*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.TFile2IDTable, void>)0x0067C1F0)(ref this);
    // void __thiscall TFile2IDTable::TFile2IDTable(TFile2IDTable*,unsigned int)
    public void _ConstructorInternal(uint ExpectedTableSize) => ((delegate* unmanaged[Thiscall]<ref ACBindings.TFile2IDTable, uint, void>)0x0067C280)(ref this, ExpectedTableSize);
}

