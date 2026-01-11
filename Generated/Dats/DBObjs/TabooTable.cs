namespace ACBindings.Internal;

public unsafe struct TabooTable
{
    // Base Classes
    public ACBindings.Internal.DBObj BaseClass_DBObj; // ACBindings.Internal.DBObj

    // Child Types
    public unsafe struct TabooTable_vtbl
    {
        // Members
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, ACBindings.Internal._GUID*, void**, int> IUnknown_QueryInterface; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_AddRef; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_Release; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, ACBindings.Internal.TResult*, ACBindings.Internal.Turbine_GUID*, void**, ACBindings.Internal.TResult*> QueryInterface; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> AddRef; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> Release; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, void> DBObj_dtor_18; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.Archive*, void> Serialize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.QualifiedDataIDArray*, void> GetSubDataIDs; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> InitLoad; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> GetSubObjects; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> ReleaseSubObjects; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> NotifyFidelityLevel; // function pointer
        public System.IntPtr Refresh;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.DBObj*, byte> CopyInto; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, void> Destroy; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.IDataGraph*, void> FillDataGraph; // function pointer
        public System.IntPtr SetDID;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, uint> GetDBOType; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.DBObj*> Allocate; // function pointer
        public System.IntPtr SaveToDisk;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> ReloadFromDisk; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.HashTable__uint___HashTable__uint___List___PStringBase__sbyte m_audienceToBannedPatterns;

    // Methods

    /// <summary>
    /// <code>Offset: 0x004F7C80
    /// DBObj* __cdecl TabooTable::Allocator()</code>
    /// </summary>
    public static ACBindings.Internal.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.DBObj*>)0x004F7C80)();

    /// <summary>
    /// <code>Offset: 0x00682570
    /// bool __thiscall TabooTable::CreateCheckString(TabooTable*,unsigned int,const char*,unsigned int,char*)</code>
    /// </summary>
    public byte CreateCheckString(uint chkType, sbyte* baseStr, uint baseStrLength, sbyte* strOut) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TabooTable, uint, sbyte*, uint, sbyte*, byte>)0x00682570)(ref this, chkType, baseStr, baseStrLength, strOut);

    /// <summary>
    /// <code>Offset: 0x00682600
    /// bool __thiscall TabooTable::StringMatchesFilter(TabooTable*,const char*,const char*)</code>
    /// </summary>
    public byte StringMatchesFilter(sbyte* string_, sbyte* filter) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TabooTable, sbyte*, sbyte*, byte>)0x00682600)(ref this, string_, filter);

    /// <summary>
    /// <code>Offset: 0x00683050
    /// int __thiscall TabooTable::CheckCensors(TabooTable*,char**,unsigned int,unsigned int,const char**)</code>
    /// </summary>
    public int CheckCensors(sbyte** a2, uint a3, uint chkType, sbyte** a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TabooTable, sbyte**, uint, uint, sbyte**, int>)0x00683050)(ref this, a2, a3, chkType, a5);

    /// <summary>
    /// <code>Offset: 0x00683350
    /// int __thiscall TabooTable::CheckCensorsW(TabooTable*,int*,unsigned int,int,int*)</code>
    /// </summary>
    public int CheckCensorsW(int* a2, uint a3, int a4, int* a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TabooTable, int*, uint, int, int*, int>)0x00683350)(ref this, a2, a3, a4, a5);

    /// <summary>
    /// <code>Offset: 0x006839F0
    /// void __thiscall TabooTable::Serialize(TabooTable*,Archive*)</code>
    /// </summary>
    public void Serialize(ACBindings.Internal.Archive* rArchive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TabooTable, ACBindings.Internal.Archive*, void>)0x006839F0)(ref this, rArchive);
}

