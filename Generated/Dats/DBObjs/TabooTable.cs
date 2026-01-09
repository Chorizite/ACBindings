namespace ACBindings;

// TabooTable
public unsafe struct TabooTable
{
    // Base Classes
    public ACBindings.DBObj BaseClass_DBObj; // ACBindings.DBObj

    // Child Types
    // TabooTable_vtbl
    public unsafe struct TabooTable_vtbl
    {
        // Members
        public System.IntPtr IUnknown_QueryInterface; // function pointer
        public System.IntPtr IUnknown_AddRef; // function pointer
        public System.IntPtr IUnknown_Release; // function pointer
        public System.IntPtr QueryInterface; // function pointer
        public System.IntPtr AddRef; // function pointer
        public System.IntPtr Release; // function pointer
        public System.IntPtr DBObj_dtor_18; // function pointer
        public System.IntPtr Serialize; // function pointer
        public System.IntPtr GetSubDataIDs; // function pointer
        public System.IntPtr InitLoad; // function pointer
        public System.IntPtr GetSubObjects; // function pointer
        public System.IntPtr ReleaseSubObjects; // function pointer
        public System.IntPtr NotifyFidelityLevel; // function pointer
        public System.IntPtr Refresh;
        public System.IntPtr CopyInto; // function pointer
        public System.IntPtr Destroy; // function pointer
        public System.IntPtr FillDataGraph; // function pointer
        public System.IntPtr SetDID;
        public System.IntPtr GetDBOType; // function pointer
        public System.IntPtr Allocate; // function pointer
        public System.IntPtr SaveToDisk;
        public System.IntPtr ReloadFromDisk; // function pointer

        // Methods
    }

    // Members
    public ACBindings.HashTable__uint__HashTable__uint__List__PStringBase__sbyte m_audienceToBannedPatterns;

    // Methods
    // DBObj* __cdecl TabooTable::Allocator()
    public static ACBindings.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.DBObj*>)0x004F7C80)();
    // bool __thiscall TabooTable::CreateCheckString(TabooTable*,unsigned int,const char*,unsigned int,char*)
    public byte CreateCheckString(uint chkType, sbyte* baseStr, uint baseStrLength, sbyte* strOut) => ((delegate* unmanaged[Thiscall]<ref ACBindings.TabooTable, uint, sbyte*, uint, sbyte*, byte>)0x00682570)(ref this, chkType, baseStr, baseStrLength, strOut);
    // bool __thiscall TabooTable::StringMatchesFilter(TabooTable*,const char*,const char*)
    public byte StringMatchesFilter(sbyte* string_, sbyte* filter) => ((delegate* unmanaged[Thiscall]<ref ACBindings.TabooTable, sbyte*, sbyte*, byte>)0x00682600)(ref this, string_, filter);
    // int __thiscall TabooTable::CheckCensors(TabooTable*,char**,unsigned int,unsigned int,const char**)
    public int CheckCensors(sbyte** a2, uint a3, uint chkType, sbyte** a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.TabooTable, sbyte**, uint, uint, sbyte**, int>)0x00683050)(ref this, a2, a3, chkType, a5);
    // int __thiscall TabooTable::CheckCensorsW(TabooTable*,int*,unsigned int,int,int*)
    public int CheckCensorsW(int* a2, uint a3, int a4, int* a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.TabooTable, int*, uint, int, int*, int>)0x00683350)(ref this, a2, a3, a4, a5);
    // void __thiscall TabooTable::Serialize(TabooTable*,Archive*)
    public void Serialize(ACBindings.Archive* rArchive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.TabooTable, ACBindings.Archive*, void>)0x006839F0)(ref this, rArchive);
}

