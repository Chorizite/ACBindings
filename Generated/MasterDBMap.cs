namespace ACBindings;

// MasterDBMap
public unsafe struct MasterDBMap
{
    // Statics
    public static ACBindings.HashTable__uint__DBTypeDef* sm_DBTypeDefHash = (ACBindings.HashTable__uint__DBTypeDef*)0x00818814;
    public static ACBindings.MasterDBMap* sm_mmap = (ACBindings.MasterDBMap*)0x00837C68;
    public static ACBindings.PStringBase__sbyte* sm_game_data_dir = (ACBindings.PStringBase__sbyte*)0x00837C70;
    public static ACBindings.PStringBase__sbyte* sm_engine_data_dir = (ACBindings.PStringBase__sbyte*)0x00837C74;

    // Child Types
    // MasterDBMap_vtbl
    public unsafe struct MasterDBMap_vtbl
    {
        // Members
        public System.IntPtr InitDBTypeDef_Internal; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr DivineType_Internal;
        public System.IntPtr InqTypeByString_Internal;
        public System.IntPtr InqStringByType_Internal;

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer

    // Methods
    // bool __cdecl MasterDBMap::Init(MasterDBMap*)
    public static byte Init(ACBindings.MasterDBMap* mapper) => ((delegate* unmanaged[Cdecl]<ACBindings.MasterDBMap*, byte>)0x0041C220)(mapper);
    // bool __cdecl MasterDBMap::Cleanup()
    public static byte Cleanup() => ((delegate* unmanaged[Cdecl]<byte>)0x0041C240)();
    // int __cdecl MasterDBMap::DivineType(int)
    public static int DivineType(int a1) => ((delegate* unmanaged[Cdecl]<int, int>)0x0041C260)(a1);
    // int __cdecl MasterDBMap::SetGameDataDir(void**)
    public static int SetGameDataDir(void** a1) => ((delegate* unmanaged[Cdecl]<void**, int>)0x0041C2E0)(a1);
    // int __cdecl MasterDBMap::SetEngineDataDir(void**)
    public static int SetEngineDataDir(void** a1) => ((delegate* unmanaged[Cdecl]<void**, int>)0x0041C330)(a1);
    // const DBTypeDef* __cdecl MasterDBMap::GetDBTypeDef(const unsigned int)
    public static ACBindings.DBTypeDef* GetDBTypeDef(uint dbtype) => ((delegate* unmanaged[Cdecl]<uint, ACBindings.DBTypeDef*>)0x0041C400)(dbtype);
    // bool __cdecl MasterDBMap::IsPortalType(const unsigned int)
    public static byte IsPortalType(uint dbtype) => ((delegate* unmanaged[Cdecl]<uint, byte>)0x0041C480)(dbtype);
    // bool __cdecl MasterDBMap::IsCellType(const unsigned int)
    public static byte IsCellType(uint dbtype) => ((delegate* unmanaged[Cdecl]<uint, byte>)0x0041C4A0)(dbtype);
    // bool __cdecl MasterDBMap::IsLocalType(const unsigned int)
    public static byte IsLocalType(uint dbtype) => ((delegate* unmanaged[Cdecl]<uint, byte>)0x0041C4C0)(dbtype);
    // bool __cdecl MasterDBMap::IsCategorized(const unsigned int)
    public static byte IsCategorized(uint dbtype) => ((delegate* unmanaged[Cdecl]<uint, byte>)0x0041C4E0)(dbtype);
    // const FreelistDef* __cdecl MasterDBMap::GetFreelistDef(const unsigned int)
    public static ACBindings.FreelistDef* GetFreelistDef(uint dbtype) => ((delegate* unmanaged[Cdecl]<uint, ACBindings.FreelistDef*>)0x0041C500)(dbtype);
    // char __cdecl MasterDBMap::VerifyDirectory(char*,unsigned int)
    public static sbyte VerifyDirectory(sbyte* a1, uint dbtype) => ((delegate* unmanaged[Cdecl]<sbyte*, uint, sbyte>)0x0041C520)(a1, dbtype);
    // int __stdcall MasterDBMap::DivineType_Internal(unsigned int)
    public static int DivineType_Internal(uint a1) => ((delegate* unmanaged[Stdcall]<uint, int>)0x0041C880)(a1);
    // int __stdcall MasterDBMap::DivineType_Internal(int)
    public static int DivineType_Internal(int a1) => ((delegate* unmanaged[Stdcall]<int, int>)0x0041CCE0)(a1);
    // char __stdcall MasterDBMap::InqTypeByString_Internal(char**,_DWORD*)
    public static sbyte InqTypeByString_Internal(sbyte** a1, int* a2) => ((delegate* unmanaged[Stdcall]<sbyte**, int*, sbyte>)0x0041E0C0)(a1, a2);
    // char __stdcall MasterDBMap::InqStringByType_Internal(int,void**)
    public static sbyte InqStringByType_Internal(int a1, void** a2) => ((delegate* unmanaged[Stdcall]<int, void**, sbyte>)0x0041F370)(a1, a2);
    // bool __thiscall MasterDBMap::InitDBTypeDef_Internal(MasterDBMap*)
    public byte InitDBTypeDef_Internal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.MasterDBMap, byte>)0x0041F9A0)(ref this);
}

