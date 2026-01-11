namespace ACBindings.Internal;

public unsafe struct TFile2IDTable : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.TReadOnlyFile2IDTable BaseClass_TReadOnlyFile2IDTable; // ACBindings.Internal.TReadOnlyFile2IDTable

    // Child Types
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
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.TFile2IDTable*, void> Clear; // function pointer
        public System.IntPtr GetFileWriteTimeByFileName;
        public System.IntPtr GetFileWriteTimeByDID;
        public System.IntPtr AssignDIDToFileName;
        public System.IntPtr AssignNonAuthoritativePathToFileName;
        public System.IntPtr AssignSoonToExistFilePath;
        public System.IntPtr RemoveFilenameFromCache;
        public System.IntPtr RemoveDirectoryFromCache;
        public System.IntPtr RegisterDBType;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.TFile2IDTable*, uint, byte> IsDBTypeRegistered; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.TFile2IDTable*, uint, byte> IsDBDirSearched; // function pointer
        public System.IntPtr AssignPathToFileNameInternal;
        public System.IntPtr FindEntryByName;
        public System.IntPtr FindEntryByDID;
        public System.IntPtr GetFullPathByEntry;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.TFile2IDTable*, ACBindings.Internal.TFileEntry*, int*, byte> GetFileWriteTimeByEntry; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.TFile2IDTable*, uint, ACBindings.Internal.TDBTypeEntry*> GetDBTypeEntry; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.AutoGrowHashTable___CaseInsensitiveStringBase___PStringBase__sbyte___TFileEntry_ptr m_CacheByFileName;
    public ACBindings.Internal.AutoGrowHashTable__uint___TDBTypeEntry_ptr m_CacheByDID;

    // Generated Constructor
    public TFile2IDTable(uint ExpectedTableSize) {
        _ConstructorInternal(ExpectedTableSize);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x00679320
    /// bool __thiscall TFile2IDTable::GetFileWriteTimeByEntry(TFile2IDTable*,TFileEntry*,int*)</code>
    /// </summary>
    public byte GetFileWriteTimeByEntry(ACBindings.Internal.TFileEntry* pEntry, int* FileWriteTime) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TFile2IDTable, ACBindings.Internal.TFileEntry*, int*, byte>)0x00679320)(ref this, pEntry, FileWriteTime);

    /// <summary>
    /// <code>Offset: 0x00679340
    /// char __thiscall TFile2IDTable::GetFileWriteTimeByDID(int*,int,int,_DWORD*)</code>
    /// </summary>
    public sbyte GetFileWriteTimeByDID(int a2, int a3, int* a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TFile2IDTable, int, int, int*, sbyte>)0x00679340)(ref this, a2, a3, a4);

    /// <summary>
    /// <code>Offset: 0x006793A0
    /// unsigned int* __thiscall TFile2IDTable::GetHighestDID(void*,unsigned int*,int)</code>
    /// </summary>
    public uint* GetHighestDID(uint* a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TFile2IDTable, uint*, int, uint*>)0x006793A0)(ref this, a2, a3);

    /// <summary>
    /// <code>Offset: 0x00679670
    /// unsigned int* __thiscall TFile2IDTable::GetDIDByFileName(void*,unsigned int*,int,int)</code>
    /// </summary>
    public uint* GetDIDByFileName(uint* a2, int a3, int a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TFile2IDTable, uint*, int, int, uint*>)0x00679670)(ref this, a2, a3, a4);

    /// <summary>
    /// <code>Offset: 0x00679730
    /// char __thiscall TFile2IDTable::GetFileNameByDID(_DWORD*,int,int,int*)</code>
    /// </summary>
    public sbyte GetFileNameByDID(int a2, int a3, int* a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TFile2IDTable, int, int, int*, sbyte>)0x00679730)(ref this, a2, a3, a4);

    /// <summary>
    /// <code>Offset: 0x006797D0
    /// char __thiscall TFile2IDTable::GetFullPathByDID(int*,int,int,void**)</code>
    /// </summary>
    public sbyte GetFullPathByDID(int a2, int a3, void** a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TFile2IDTable, int, int, void**, sbyte>)0x006797D0)(ref this, a2, a3, a4);

    /// <summary>
    /// <code>Offset: 0x00679860
    /// char __thiscall TFile2IDTable::GetFullPathByFileName(void*,int,int,PStringBase&lt;char&gt;*)</code>
    /// </summary>
    public sbyte GetFullPathByFileName(int a2, int a3, ACBindings.Internal.PStringBase__sbyte* a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TFile2IDTable, int, int, ACBindings.Internal.PStringBase__sbyte*, sbyte>)0x00679860)(ref this, a2, a3, a4);

    /// <summary>
    /// <code>Offset: 0x006799C0
    /// char __thiscall TFile2IDTable::GetFileWriteTimeByFileName(void*,int,int,_DWORD*)</code>
    /// </summary>
    public sbyte GetFileWriteTimeByFileName(int a2, int a3, int* a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TFile2IDTable, int, int, int*, sbyte>)0x006799C0)(ref this, a2, a3, a4);

    /// <summary>
    /// <code>Offset: 0x00679A90
    /// void** __thiscall TFile2IDTable::GetDBTypeString(void*,void**,int)</code>
    /// </summary>
    public void** GetDBTypeString(void** a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TFile2IDTable, void**, int, void**>)0x00679A90)(ref this, a2, a3);

    /// <summary>
    /// <code>Offset: 0x00679AE0
    /// char __stdcall TFile2IDTable::SanitizeEntry(LPCSTR*,_DWORD**)</code>
    /// </summary>
    public static sbyte SanitizeEntry(sbyte** a1, int** a2) => ((delegate* unmanaged[Stdcall]<sbyte**, int**, sbyte>)0x00679AE0)(a1, a2);

    /// <summary>
    /// <code>Offset: 0x00679BF0
    /// bool __stdcall TFile2IDTable::ReformatDirectoryName(char*,_BYTE*)</code>
    /// </summary>
    public static byte ReformatDirectoryName(sbyte* a1, byte* a2) => ((delegate* unmanaged[Stdcall]<sbyte*, byte*, byte>)0x00679BF0)(a1, a2);

    /// <summary>
    /// <code>Offset: 0x00679C80
    /// bool __thiscall TFile2IDTable::AssignSoonToExistFilePath(void*,int)</code>
    /// </summary>
    public byte AssignSoonToExistFilePath(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TFile2IDTable, int, byte>)0x00679C80)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x00679DA0
    /// char __thiscall TFile2IDTable::RegisterDBType(int*,int,int,char*,char*)</code>
    /// </summary>
    public sbyte RegisterDBType(int a2, int a3, sbyte* a4, sbyte* a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TFile2IDTable, int, int, sbyte*, sbyte*, sbyte>)0x00679DA0)(ref this, a2, a3, a4, a5);

    /// <summary>
    /// <code>Offset: 0x0067A010
    /// char __stdcall TFile2IDTable::GetFullPathByEntry(int,char*)</code>
    /// </summary>
    public static sbyte GetFullPathByEntry(int a1, sbyte* Source) => ((delegate* unmanaged[Stdcall]<int, sbyte*, sbyte>)0x0067A010)(a1, Source);

    /// <summary>
    /// <code>Offset: 0x0067A110
    /// bool __thiscall TFile2IDTable::IsDBTypeRegistered(TFile2IDTable*,unsigned int)</code>
    /// </summary>
    public byte IsDBTypeRegistered(uint dbtype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TFile2IDTable, uint, byte>)0x0067A110)(ref this, dbtype);

    /// <summary>
    /// <code>Offset: 0x0067A160
    /// bool __thiscall TFile2IDTable::IsDBDirSearched(TFile2IDTable*,unsigned int)</code>
    /// </summary>
    public byte IsDBDirSearched(uint dbtype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TFile2IDTable, uint, byte>)0x0067A160)(ref this, dbtype);

    /// <summary>
    /// <code>Offset: 0x0067A2A0
    /// char __thiscall TFile2IDTable::FindEntryByDID(void*,unsigned int,int,_DWORD*)</code>
    /// </summary>
    public sbyte FindEntryByDID(uint a2, int a3, int* a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TFile2IDTable, uint, int, int*, sbyte>)0x0067A2A0)(ref this, a2, a3, a4);

    /// <summary>
    /// <code>Offset: 0x0067A590
    /// char __thiscall TFile2IDTable::GetDBTypes(_DWORD*,_DWORD*)</code>
    /// </summary>
    public sbyte GetDBTypes(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TFile2IDTable, int*, sbyte>)0x0067A590)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x0067A6B0
    /// char __thiscall TFile2IDTable::GetDIDs(_DWORD*,_DWORD*,unsigned int)</code>
    /// </summary>
    public sbyte GetDIDs(int* a2, uint a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TFile2IDTable, int*, uint, sbyte>)0x0067A6B0)(ref this, a2, a3);

    /// <summary>
    /// <code>Offset: 0x0067A800
    /// char __thiscall TFile2IDTable::GetFilePaths(_DWORD*,_DWORD*)</code>
    /// </summary>
    public sbyte GetFilePaths(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TFile2IDTable, int*, sbyte>)0x0067A800)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x0067A990
    /// char __thiscall TFile2IDTable::RemoveFilenameFromCache(_DWORD*,int*)</code>
    /// </summary>
    public sbyte RemoveFilenameFromCache(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TFile2IDTable, int*, sbyte>)0x0067A990)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x0067AA70
    /// char __thiscall TFile2IDTable::RemoveDirectoryFromCache(_DWORD*,const char**)</code>
    /// </summary>
    public sbyte RemoveDirectoryFromCache(sbyte** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TFile2IDTable, sbyte**, sbyte>)0x0067AA70)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x0067B300
    /// char __thiscall TFile2IDTable::AssignDIDToFileName(void*,int,unsigned int,_DWORD*)</code>
    /// </summary>
    public sbyte AssignDIDToFileName(int a2, uint a3, int* a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TFile2IDTable, int, uint, int*, sbyte>)0x0067B300)(ref this, a2, a3, a4);

    /// <summary>
    /// <code>Offset: 0x0067B4F0
    /// char __thiscall TFile2IDTable::AssignNonAuthoritativePathToFileName(_DWORD*,char*,char*)</code>
    /// </summary>
    public sbyte AssignNonAuthoritativePathToFileName(sbyte* a2, sbyte* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TFile2IDTable, sbyte*, sbyte*, sbyte>)0x0067B4F0)(ref this, a2, a3);

    /// <summary>
    /// <code>Offset: 0x0067B6B0
    /// bool __thiscall TFile2IDTable::FindEntryByName(_DWORD*,char*,IDClass&lt;_tagDataID,32,0&gt;**,char*)</code>
    /// </summary>
    public byte FindEntryByName(sbyte* a2, ACBindings.Internal.IDClass____tagDataID** a3, sbyte* a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TFile2IDTable, sbyte*, ACBindings.Internal.IDClass____tagDataID**, sbyte*, byte>)0x0067B6B0)(ref this, a2, a3, a4);

    /// <summary>
    /// <code>Offset: 0x0067B9A0
    /// char __thiscall TFile2IDTable::AssignPathToFileNameInternal(_DWORD*,volatile LONG*,char*,char*)</code>
    /// </summary>
    public sbyte AssignPathToFileNameInternal(int* a2, sbyte* a3, sbyte* String1) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TFile2IDTable, int*, sbyte*, sbyte*, sbyte>)0x0067B9A0)(ref this, a2, a3, String1);

    /// <summary>
    /// <code>Offset: 0x0067BEE0
    /// void __thiscall TFile2IDTable::Clear(TFile2IDTable*)</code>
    /// </summary>
    public void Clear() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TFile2IDTable, void>)0x0067BEE0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0067C080
    /// TDBTypeEntry* __thiscall TFile2IDTable::GetDBTypeEntry(TFile2IDTable*,unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.TDBTypeEntry* GetDBTypeEntry(uint dbtype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TFile2IDTable, uint, ACBindings.Internal.TDBTypeEntry*>)0x0067C080)(ref this, dbtype);

    /// <summary>
    /// <code>Offset: 0x0067C1F0
    /// void __thiscall TFile2IDTable::~TFile2IDTable(TFile2IDTable*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TFile2IDTable, void>)0x0067C1F0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0067C280
    /// void __thiscall TFile2IDTable::TFile2IDTable(TFile2IDTable*,unsigned int)</code>
    /// </summary>
    public void _ConstructorInternal(uint ExpectedTableSize) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TFile2IDTable, uint, void>)0x0067C280)(ref this, ExpectedTableSize);
}

