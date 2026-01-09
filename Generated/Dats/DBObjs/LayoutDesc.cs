namespace ACBindings;

// LayoutDesc
public unsafe struct LayoutDesc : System.IDisposable
{
    // Base Classes
    public ACBindings.DBObj BaseClass_DBObj; // ACBindings.DBObj

    // Statics
    public static byte* s_bUseDescCache = (byte*)0x00835A70;
    public static ACBindings.HashTable__IDClass___tagDataID__HashTable__uint__ElementDesc* s_DescCache = (ACBindings.HashTable__IDClass___tagDataID__HashTable__uint__ElementDesc*)0x00835A78;

    // Child Types
    // LayoutDesc_vtbl
    public unsafe struct LayoutDesc_vtbl
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
    public uint m_displayWidth;
    public uint m_displayHeight;
    public ACBindings.HashTable__uint__ElementDesc m_elements;
    public ACBindings.PStringBase__sbyte m_strElementHeader;
    public ACBindings.PStringBase__sbyte m_strElementWHeader;
    public ACBindings.PStringBase__sbyte m_strStateHeader;
    public ACBindings.PStringBase__sbyte m_strStateWHeader;

    // Generated Constructor
    public LayoutDesc() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // DBObj* __cdecl LayoutDesc::Allocator()
    public static ACBindings.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.DBObj*>)0x00459340)();
    // unsigned int __thiscall LayoutDesc::GetDBOType(LayoutDesc*)
    public uint GetDBOType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.LayoutDesc, uint>)0x00459360)(ref this);
    // void __thiscall LayoutDesc::GetSubDataIDs(LayoutDesc*,QualifiedDataIDArray*)
    public void GetSubDataIDs(ACBindings.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.LayoutDesc, ACBindings.QualifiedDataIDArray*, void>)0x0069A7A0)(ref this, id_array);
    // ElementDesc* __thiscall LayoutDesc::AccessElementDesc(LayoutDesc*,unsigned int)
    public ACBindings.ElementDesc* AccessElementDesc(uint elementID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.LayoutDesc, uint, ACBindings.ElementDesc*>)0x0069A850)(ref this, elementID);
    // void __thiscall LayoutDesc::Destroy(LayoutDesc*)
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.LayoutDesc, void>)0x0069AD50)(ref this);
    // void __thiscall LayoutDesc::LayoutDesc(LayoutDesc*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.LayoutDesc, void>)0x0069B060)(ref this);
    // void __thiscall LayoutDesc::~LayoutDesc(LayoutDesc*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.LayoutDesc, void>)0x0069B0F0)(ref this);
    // void __thiscall LayoutDesc::Serialize(LayoutDesc*,Archive*)
    public void Serialize(ACBindings.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.LayoutDesc, ACBindings.Archive*, void>)0x0069B370)(ref this, io_archive);
    // bool __cdecl LayoutDesc::InqFullDesc(ElementDesc*,ElementDesc*,int*)
    public static byte InqFullDesc(ACBindings.ElementDesc* rhs, ACBindings.ElementDesc* a2, int* a3) => ((delegate* unmanaged[Cdecl]<ACBindings.ElementDesc*, ACBindings.ElementDesc*, int*, byte>)0x0069B400)(rhs, a2, a3);
}

