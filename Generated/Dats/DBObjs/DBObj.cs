namespace ACBindings;

// DBObj
public unsafe struct DBObj : System.IDisposable
{
    // Base Classes
    public ACBindings.Interface BaseClass_Interface; // ACBindings.Interface

    // Child Types
    // DBObj_vtbl
    public unsafe struct DBObj_vtbl
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
    public uint m_dataCategory;
    public byte m_bLoaded;
    public double m_timeStamp;
    public ACBindings.DBObj* m_pNext;
    public ACBindings.DBObj* m_pLast;
    public ACBindings.DBOCache* m_pMaintainer;
    public int m_numLinks;
    public ACBindings.IDClass___tagDataID m_DID;
    public byte m_AllowedInFreeList;

    // Generated Constructor
    public DBObj(void** a2) {
        _ConstructorInternal(a2);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall DBObj::AddToDataGraph(DBObj*)
    public void AddToDataGraph() => ((delegate* unmanaged[Thiscall]<ref ACBindings.DBObj, void>)0x004153C0)(ref this);
    // unsigned int __thiscall DBObj::AddRef(DBObj*)
    public uint AddRef() => ((delegate* unmanaged[Thiscall]<ref ACBindings.DBObj, uint>)0x004153D0)(ref this);
    // unsigned int __thiscall DBObj::Release(DBObj*)
    public uint Release() => ((delegate* unmanaged[Thiscall]<ref ACBindings.DBObj, uint>)0x00415400)(ref this);
    // DBObj* __cdecl DBObj::Get(const QualifiedDataID*)
    public static ACBindings.DBObj* Get(ACBindings.QualifiedDataID* qdid) => ((delegate* unmanaged[Cdecl]<ACBindings.QualifiedDataID*, ACBindings.DBObj*>)0x00415430)(qdid);
    // void*** __thiscall DBObj::DBObj(void***,void**)
    public void*** _ConstructorInternal(void** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.DBObj, void**, void***>)0x00415460)(ref this, a2);
    // bool __cdecl DBObj::InitLoad()
    public static byte InitLoad() => ((delegate* unmanaged[Cdecl]<byte>)0x004154A0)();
    // void __thiscall DBObj::~DBObj(DBObj*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.DBObj, void>)0x004154B0)(ref this);
    // TResult* __thiscall DBObj::QueryInterface(DBObj*,TResult*,const Turbine_GUID*,void**)
    public ACBindings.TResult* QueryInterface(ACBindings.TResult* result, ACBindings.Turbine_GUID* i_rcInterface, void** o_ppObject) => ((delegate* unmanaged[Thiscall]<ref ACBindings.DBObj, ACBindings.TResult*, ACBindings.Turbine_GUID*, void**, ACBindings.TResult*>)0x004154C0)(ref this, result, i_rcInterface, o_ppObject);
    // bool __thiscall DBObj::ReloadFromDisk(DBObj*)
    public byte ReloadFromDisk() => ((delegate* unmanaged[Thiscall]<ref ACBindings.DBObj, byte>)0x00415520)(ref this);
    // char __thiscall DBObj::SaveToDisk(DBObj*,const PreprocHeader*)
    public sbyte SaveToDisk(ACBindings.PreprocHeader* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.DBObj, ACBindings.PreprocHeader*, sbyte>)0x00415550)(ref this, a2);
    // void __thiscall DBObj::Serialize(DBObj*,Archive*)
    public void Serialize(ACBindings.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.DBObj, ACBindings.Archive*, void>)0x00415590)(ref this, io_archive);
    // void __cdecl DBObj::Remove(const DBObj*)
    public static void Remove(ACBindings.DBObj* pObj) => ((delegate* unmanaged[Cdecl]<ACBindings.DBObj*, void>)0x00415610)(pObj);
    // IDClass<_tagDataID,32,0>* __cdecl DBObj::GetDIDByEnum(IDClass<_tagDataID,32,0>*,int,int)
    public static ACBindings.IDClass___tagDataID* GetDIDByEnum(ACBindings.IDClass___tagDataID* a1, int a2, int a3) => ((delegate* unmanaged[Cdecl]<ACBindings.IDClass___tagDataID*, int, int, ACBindings.IDClass___tagDataID*>)0x00415640)(a1, a2, a3);
    // DBObj* __cdecl DBObj::GetByEnum(int,int,unsigned int)
    public static ACBindings.DBObj* GetByEnum(int enum_id, int enum_group, uint MyType) => ((delegate* unmanaged[Cdecl]<int, int, uint, ACBindings.DBObj*>)0x00415730)(enum_id, enum_group, MyType);
    // void __thiscall DBObj::FillDataGraph(DBObj*,IDataGraph*)
    public void FillDataGraph(ACBindings.IDataGraph* graph) => ((delegate* unmanaged[Thiscall]<ref ACBindings.DBObj, ACBindings.IDataGraph*, void>)0x00415760)(ref this, graph);
}

