namespace ACBindings;

// EnumMapper
public unsafe struct EnumMapper : System.IDisposable
{
    // Base Classes
    public ACBindings.DBObj BaseClass_DBObj; // ACBindings.DBObj

    // Child Types
    // EnumMapper_vtbl
    public unsafe struct EnumMapper_vtbl
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
    // EnumMapper::iterator
    public unsafe struct iterator
    {
        // Members
        public ACBindings.EnumMapper* m_mapper;
        public ACBindings.HashIterator__uint__CaseInsensitiveStringBase__PStringBase__sbyte m_iter;

        // Generated Constructor
        public iterator(int a2, int* a3) {
            _ConstructorInternal(a2, a3);
        }

        // Methods
        // unsigned int __thiscall EnumMapper::iterator::get_enum(EnumMapper::iterator*)
        public uint get_enum() => ((delegate* unmanaged[Thiscall]<ref ACBindings.EnumMapper.iterator, uint>)0x0041AB50)(ref this);
        // _DWORD* __thiscall EnumMapper::iterator::get_string(_DWORD*,_DWORD*)
        public int* get_string(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.EnumMapper.iterator, int*, int*>)0x0041AB60)(ref this, a2);
        // _DWORD* __thiscall EnumMapper::iterator::iterator(_DWORD*,int,_DWORD*)
        public int* _ConstructorInternal(int a2, int* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.EnumMapper.iterator, int, int*, int*>)0x0041AC60)(ref this, a2, a3);
    }

    // Members
    public ACBindings.IDClass___tagDataID m_base_emp_did;
    public ACBindings.EnumMapper* m_base_emp;
    public ACBindings.AutoGrowHashTable__uint__CaseInsensitiveStringBase__PStringBase__sbyte m_id_to_string_map;
    public ACBindings.AutoGrowHashTable__CaseInsensitiveStringBase__PStringBase__sbyte__uint m_string_to_id_map;

    // Generated Constructor
    public EnumMapper() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // bool __thiscall EnumMapper::ReleaseSubObjects(EnumMapper*)
    public byte ReleaseSubObjects() => ((delegate* unmanaged[Thiscall]<ref ACBindings.EnumMapper, byte>)0x0041A970)(ref this);
    // bool __thiscall EnumMapper::GetSubObjects(EnumMapper*)
    public byte GetSubObjects() => ((delegate* unmanaged[Thiscall]<ref ACBindings.EnumMapper, byte>)0x0041A990)(ref this);
    // void __thiscall EnumMapper::GetSubDataIDs(EnumMapper*,QualifiedDataIDArray*)
    public void GetSubDataIDs(ACBindings.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.EnumMapper, ACBindings.QualifiedDataIDArray*, void>)0x0041AAD0)(ref this, id_array);
    // EnumMapper::iterator* __thiscall EnumMapper::end(EnumMapper*,EnumMapper::iterator*)
    public ACBindings.EnumMapper.iterator* end(ACBindings.EnumMapper.iterator* result) => ((delegate* unmanaged[Thiscall]<ref ACBindings.EnumMapper, ACBindings.EnumMapper.iterator*, ACBindings.EnumMapper.iterator*>)0x0041AC30)(ref this, result);
    // EnumMapper::iterator* __thiscall EnumMapper::begin(EnumMapper*,EnumMapper::iterator*)
    public ACBindings.EnumMapper.iterator* begin(ACBindings.EnumMapper.iterator* result) => ((delegate* unmanaged[Thiscall]<ref ACBindings.EnumMapper, ACBindings.EnumMapper.iterator*, ACBindings.EnumMapper.iterator*>)0x0041AD00)(ref this, result);
    // char __thiscall EnumMapper::GetString(_DWORD*,int,volatile LONG**)
    public sbyte GetString(int a2, int** a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.EnumMapper, int, int**, sbyte>)0x0041AF60)(ref this, a2, a3);
    // char __cdecl EnumMapper::GetString(int,int,int*)
    public static sbyte GetString(int a1, int a2, int* a3) => ((delegate* unmanaged[Cdecl]<int, int, int*, sbyte>)0x0041B060)(a1, a2, a3);
    // char __cdecl EnumMapper::InqString(int,int,int*)
    public static sbyte InqString(int a1, int a2, int* a3) => ((delegate* unmanaged[Cdecl]<int, int, int*, sbyte>)0x0041B160)(a1, a2, a3);
    // char __cdecl EnumMapper::GetStringByDID(int,int,int*)
    public static sbyte GetStringByDID(int a1, int a2, int* a3) => ((delegate* unmanaged[Cdecl]<int, int, int*, sbyte>)0x0041B220)(a1, a2, a3);
    // int __thiscall EnumMapper::GetEnum(_DWORD*,_DWORD*)
    public int GetEnum(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.EnumMapper, int*, int>)0x0041B490)(ref this, a2);
    // char __thiscall EnumMapper::GetEnum(_DWORD*,int,_DWORD*)
    public sbyte GetEnum(int a2, int* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.EnumMapper, int, int*, sbyte>)0x0041B7E0)(ref this, a2, a3);
    // bool __cdecl EnumMapper::GetEnum(int,int,_DWORD*)
    public static byte GetEnum(int a1, int a2, int* a3) => ((delegate* unmanaged[Cdecl]<int, int, int*, byte>)0x0041B8F0)(a1, a2, a3);
    // bool __cdecl EnumMapper::InqEnum(int,int,_DWORD*)
    public static byte InqEnum(int a1, int a2, int* a3) => ((delegate* unmanaged[Cdecl]<int, int, int*, byte>)0x0041BA30)(a1, a2, a3);
    // bool __cdecl EnumMapper::GetEnumByDID(int,int,_DWORD*)
    public static byte GetEnumByDID(int a1, int a2, int* a3) => ((delegate* unmanaged[Cdecl]<int, int, int*, byte>)0x0041BAC0)(a1, a2, a3);
    // void __thiscall EnumMapper::Destroy(EnumMapper*)
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.EnumMapper, void>)0x0041BEE0)(ref this);
    // void __thiscall EnumMapper::~EnumMapper(EnumMapper*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.EnumMapper, void>)0x0041BF80)(ref this);
    // unsigned int __thiscall EnumMapper::GetDBOType(AllegianceHierarchy*)
    public uint GetDBOType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.EnumMapper, uint>)0x0041C040)(ref this);
    // void __thiscall EnumMapper::EnumMapper(EnumMapper*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.EnumMapper, void>)0x0041C050)(ref this);
    // DBObj* __cdecl EnumMapper::Allocator()
    public static ACBindings.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.DBObj*>)0x0041C0F0)();
    // void __thiscall EnumMapper::Serialize(EnumMapper*,Archive*)
    public void Serialize(ACBindings.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.EnumMapper, ACBindings.Archive*, void>)0x0041C110)(ref this, io_archive);
}

