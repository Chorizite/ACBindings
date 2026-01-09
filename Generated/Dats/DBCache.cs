namespace ACBindings;

// DBCache
public unsafe struct DBCache : System.IDisposable
{
    // Base Classes
    public ACBindings.Interface BaseClass_Interface; // ACBindings.Interface
    public ACBindings.AsyncCache BaseClass_AsyncCache; // ACBindings.AsyncCache

    // Statics
    public static int* s_EngDataPackVer = (int*)0x008185E8;
    public static int* s_EngCellPackVer = (int*)0x008185EC;
    public static int* s_GameDataPackVer = (int*)0x008185F0;
    public static int* s_GameCellPackVer = (int*)0x008185F4;
    public static int* s_GameDidPackVer = (int*)0x008185F8;
    public static ACBindings.HashTable__uint__DBOCache_ptr* s_ObjCache = (ACBindings.HashTable__uint__DBOCache_ptr*)0x0081860C;
    public static byte* s_bCacheInitialized = (byte*)0x00837BA8;
    public static ACBindings.DBCache* s_pCache = (ACBindings.DBCache*)0x00837BAC;

    // Child Types
    // DBCache_vtbl
    public unsafe struct DBCache_vtbl
    {
        // Members
        public System.IntPtr IUnknown_QueryInterface; // function pointer
        public System.IntPtr IUnknown_AddRef; // function pointer
        public System.IntPtr IUnknown_Release; // function pointer
        public System.IntPtr QueryInterface; // function pointer
        public System.IntPtr AddRef; // function pointer
        public System.IntPtr Release; // function pointer
        public System.IntPtr DBCache_dtor_18; // function pointer
        public System.IntPtr You_Must_Not_Have_Multiple_Implementations_Of_AddRef_In_A_Hierarchy; // function pointer
        public System.IntPtr ResetCache; // function pointer
        public System.IntPtr GetFromEnum; // function pointer
        public System.IntPtr GetDIDFromEnum;
        public System.IntPtr PreFetch; // function pointer
        public System.IntPtr InqDatIDStamp; // function pointer
        public System.IntPtr ReloadObject;
        public System.IntPtr SetShutdown; // function pointer
        public System.IntPtr IsLoader; // function pointer
        public System.IntPtr SetRegion; // function pointer
        public System.IntPtr UnloadCellData; // function pointer
        public System.IntPtr AskForLastWords; // function pointer
        public System.IntPtr SetLanguageInternal; // function pointer
        public System.IntPtr DestroyObjectCaches; // function pointer

        // Methods
    }
    // DBCache::Enum3
    public enum Enum3 : uint
    {
    }
    // DBCache::Enum4
    public enum Enum4 : uint
    {
    }

    // Members
    public ACBindings.Turbine_RefCount m_cTurbineRefCount;
    public ACBindings.IDClass___tagDataID m_MasterMapID;
    public uint m_CurrentRegion;
    public uint m_LocalLanguage;
    public byte m_bRuntime;
    public byte m_bIsClient;
    public byte m_bIsServer;
    public ACBindings.IDataGraph* m_pDataGraph;

    // Generated Constructor
    public DBCache() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall DBCache::ResetCache(DBCache*)
    public void ResetCache() => ((delegate* unmanaged[Thiscall]<ref ACBindings.DBCache, void>)0x004139D0)(ref this);
    // DBObj* __cdecl DBCache::GetFromEnumStatic(int,int,unsigned int)
    public static ACBindings.DBObj* GetFromEnumStatic(int enum_id, int enum_group, uint cache_index) => ((delegate* unmanaged[Cdecl]<int, int, uint, ACBindings.DBObj*>)0x00413A00)(enum_id, enum_group, cache_index);
    // CACHE_OBJECT_CODES __cdecl DBCache::PreFetchStatic(const QualifiedDataID*)
    public static ACBindings.CACHE_OBJECT_CODES PreFetchStatic(ACBindings.QualifiedDataID* qdid) => ((delegate* unmanaged[Cdecl]<ACBindings.QualifiedDataID*, ACBindings.CACHE_OBJECT_CODES>)0x00413A30)(qdid);
    // bool __cdecl DBCache::GetCurrentRegion(unsigned int*)
    public static byte GetCurrentRegion(uint* region_num) => ((delegate* unmanaged[Cdecl]<uint*, byte>)0x00413A50)(region_num);
    // bool __cdecl DBCache::IsRunTime()
    public static byte IsRunTime() => ((delegate* unmanaged[Cdecl]<byte>)0x00413A70)();
    // bool __cdecl DBCache::IsClient()
    public static byte IsClient() => ((delegate* unmanaged[Cdecl]<byte>)0x00413A90)();
    // bool __cdecl DBCache::IsServer()
    public static byte IsServer() => ((delegate* unmanaged[Cdecl]<byte>)0x00413AB0)();
    // bool __thiscall DBCache::SetRegion(DBCache*,unsigned int)
    public byte SetRegion(uint rid) => ((delegate* unmanaged[Thiscall]<ref ACBindings.DBCache, uint, byte>)0x00413AD0)(ref this, rid);
    // bool __cdecl DBCache::SetLocalLanguage(unsigned int,bool)
    public static byte SetLocalLanguage(uint language_l, byte engine_only) => ((delegate* unmanaged[Cdecl]<uint, byte, byte>)0x00413AE0)(language_l, engine_only);
    // unsigned int __cdecl DBCache::GetLocalLanguage()
    public static uint GetLocalLanguage() => ((delegate* unmanaged[Cdecl]<uint>)0x00413B00)();
    // _DWORD* __thiscall DBCache::SetMasterMapDID(_DWORD*,_DWORD*,int)
    public int* SetMasterMapDID(int* a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.DBCache, int*, int, int*>)0x00413B60)(ref this, a2, a3);
    // int __cdecl DBCache::Get(int,int)
    public static int Get(int a1, int a2) => ((delegate* unmanaged[Cdecl]<int, int, int>)0x00413B80)(a1, a2);
    // IDClass<_tagDataID,32,0>* __cdecl DBCache::GetDIDFromEnumStatic(IDClass<_tagDataID,32,0>*,int,int)
    public static ACBindings.IDClass___tagDataID* GetDIDFromEnumStatic(ACBindings.IDClass___tagDataID* a1, int a2, int a3) => ((delegate* unmanaged[Cdecl]<ACBindings.IDClass___tagDataID*, int, int, ACBindings.IDClass___tagDataID*>)0x00413BC0)(a1, a2, a3);
    // IDClass<_tagDataID,32,0>* __thiscall DBCache::GetDIDFromEnum(_DWORD*,IDClass<_tagDataID,32,0>*,unsigned int,unsigned int)
    public ACBindings.IDClass___tagDataID* GetDIDFromEnum(ACBindings.IDClass___tagDataID* a2, uint a3, uint a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.DBCache, ACBindings.IDClass___tagDataID*, uint, uint, ACBindings.IDClass___tagDataID*>)0x00413BF0)(ref this, a2, a3, a4);
    // DBObj* __thiscall DBCache::GetFromEnum(DBCache*,int,int,unsigned int)
    public ACBindings.DBObj* GetFromEnum(int enum_id, int enum_group, uint dbtype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.DBCache, int, int, uint, ACBindings.DBObj*>)0x00413CC0)(ref this, enum_id, enum_group, dbtype);
    // char __thiscall DBCache::ReloadObject(_DWORD*,int,int)
    public sbyte ReloadObject(int a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.DBCache, int, int, sbyte>)0x00413D20)(ref this, a2, a3);
    // void __cdecl DBCache::AddToDataGraph(const DBObj*)
    public static void AddToDataGraph(ACBindings.DBObj* obj) => ((delegate* unmanaged[Cdecl]<ACBindings.DBObj*, void>)0x00413DE0)(obj);
    // bool __stdcall DBCache::Init(int,int)
    public static byte Init(int a1, int a2) => ((delegate* unmanaged[Stdcall]<int, int, byte>)0x004141E0)(a1, a2);
    // void __thiscall DBCache::UseTime(DBCache*)
    public void UseTime() => ((delegate* unmanaged[Thiscall]<ref ACBindings.DBCache, void>)0x00414390)(ref this);
    // bool __thiscall DBCache::UnloadCellData(DBCache*)
    public byte UnloadCellData() => ((delegate* unmanaged[Thiscall]<ref ACBindings.DBCache, byte>)0x004143F0)(ref this);
    // void __thiscall DBCache::AskForLastWords(DBCache*)
    public void AskForLastWords() => ((delegate* unmanaged[Thiscall]<ref ACBindings.DBCache, void>)0x00414480)(ref this);
    // void __thiscall DBCache::FlushFreeObjects(DBCache*,unsigned int)
    public void FlushFreeObjects(uint db_type) => ((delegate* unmanaged[Thiscall]<ref ACBindings.DBCache, uint, void>)0x004144E0)(ref this, db_type);
    // DBOCache* __cdecl DBCache::GetDBOCache(unsigned int)
    public static ACBindings.DBOCache* GetDBOCache(uint dbtype) => ((delegate* unmanaged[Cdecl]<uint, ACBindings.DBOCache*>)0x00414590)(dbtype);
    // bool __thiscall DBCache::KeepFreeObjects(DBCache*,bool,unsigned int)
    public byte KeepFreeObjects(byte keep_f, uint db_type) => ((delegate* unmanaged[Thiscall]<ref ACBindings.DBCache, byte, uint, byte>)0x00414620)(ref this, keep_f, db_type);
    // DBOCache* __thiscall DBCache::GetDBOCache(DBCache*,const QualifiedDataID*)
    public ACBindings.DBOCache* GetDBOCache(ACBindings.QualifiedDataID* qdid) => ((delegate* unmanaged[Thiscall]<ref ACBindings.DBCache, ACBindings.QualifiedDataID*, ACBindings.DBOCache*>)0x004146B0)(ref this, qdid);
    // CACHE_OBJECT_CODES __thiscall DBCache::PreFetch(DBCache*,const QualifiedDataID*)
    public ACBindings.CACHE_OBJECT_CODES PreFetch(ACBindings.QualifiedDataID* qdid) => ((delegate* unmanaged[Thiscall]<ref ACBindings.DBCache, ACBindings.QualifiedDataID*, ACBindings.CACHE_OBJECT_CODES>)0x00414FE0)(ref this, qdid);
    // void __thiscall DBCache::DestroyObjectCaches(DBCache*)
    public void DestroyObjectCaches() => ((delegate* unmanaged[Thiscall]<ref ACBindings.DBCache, void>)0x00415040)(ref this);
    // void __thiscall DBCache::~DBCache(DBCache*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.DBCache, void>)0x004151B0)(ref this);
    // TResult* __thiscall DBCache::QueryInterface(DBCache*,TResult*,const Turbine_GUID*,void**)
    public ACBindings.TResult* QueryInterface(ACBindings.TResult* result, ACBindings.Turbine_GUID* i_rcInterface, void** o_ppObject) => ((delegate* unmanaged[Thiscall]<ref ACBindings.DBCache, ACBindings.TResult*, ACBindings.Turbine_GUID*, void**, ACBindings.TResult*>)0x00415210)(ref this, result, i_rcInterface, o_ppObject);
    // unsigned int __thiscall DBCache::AddRef(DBCache*)
    public uint AddRef() => ((delegate* unmanaged[Thiscall]<ref ACBindings.DBCache, uint>)0x00415270)(ref this);
    // unsigned int __thiscall DBCache::Release(DBCache*)
    public uint Release() => ((delegate* unmanaged[Thiscall]<ref ACBindings.DBCache, uint>)0x00415280)(ref this);
    // bool __thiscall DBCache::SetShutdown(DBCache*,bool)
    public byte SetShutdown(byte shut_f) => ((delegate* unmanaged[Thiscall]<ref ACBindings.DBCache, byte, byte>)0x004152B0)(ref this, shut_f);
    // void __thiscall DBCache::DBCache(DBCache*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.DBCache, void>)0x00415320)(ref this);
    // bool __thiscall DBCache::IsLoader(gmNoticeHandler*)
    public byte IsLoader() => ((delegate* unmanaged[Thiscall]<ref ACBindings.DBCache, byte>)0x006A1050)(ref this);
}

