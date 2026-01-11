namespace ACBindings.Internal;

public unsafe struct LayoutDesc : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.DBObj BaseClass_DBObj; // ACBindings.Internal.DBObj

    // Child Types
    public unsafe struct LayoutDesc_vtbl
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
    public uint m_displayWidth;
    public uint m_displayHeight;
    public ACBindings.Internal.HashTable__uint___ElementDesc m_elements;
    public ACBindings.Internal.PStringBase__sbyte m_strElementHeader;
    public ACBindings.Internal.PStringBase__sbyte m_strElementWHeader;
    public ACBindings.Internal.PStringBase__sbyte m_strStateHeader;
    public ACBindings.Internal.PStringBase__sbyte m_strStateWHeader;

    // Generated Constructor
    public LayoutDesc() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x00459340
    /// DBObj* __cdecl LayoutDesc::Allocator()</code>
    /// </summary>
    public static ACBindings.Internal.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.DBObj*>)0x00459340)();

    /// <summary>
    /// <code>Offset: 0x00459360
    /// unsigned int __thiscall LayoutDesc::GetDBOType(LayoutDesc*)</code>
    /// </summary>
    public uint GetDBOType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LayoutDesc, uint>)0x00459360)(ref this);

    /// <summary>
    /// <code>Offset: 0x0069A7A0
    /// void __thiscall LayoutDesc::GetSubDataIDs(LayoutDesc*,QualifiedDataIDArray*)</code>
    /// </summary>
    public void GetSubDataIDs(ACBindings.Internal.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LayoutDesc, ACBindings.Internal.QualifiedDataIDArray*, void>)0x0069A7A0)(ref this, id_array);

    /// <summary>
    /// <code>Offset: 0x0069A850
    /// ElementDesc* __thiscall LayoutDesc::AccessElementDesc(LayoutDesc*,unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.ElementDesc* AccessElementDesc(uint elementID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LayoutDesc, uint, ACBindings.Internal.ElementDesc*>)0x0069A850)(ref this, elementID);

    /// <summary>
    /// <code>Offset: 0x0069AD50
    /// void __thiscall LayoutDesc::Destroy(LayoutDesc*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LayoutDesc, void>)0x0069AD50)(ref this);

    /// <summary>
    /// <code>Offset: 0x0069B060
    /// void __thiscall LayoutDesc::LayoutDesc(LayoutDesc*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LayoutDesc, void>)0x0069B060)(ref this);

    /// <summary>
    /// <code>Offset: 0x0069B0F0
    /// void __thiscall LayoutDesc::~LayoutDesc(LayoutDesc*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LayoutDesc, void>)0x0069B0F0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0069B370
    /// void __thiscall LayoutDesc::Serialize(LayoutDesc*,Archive*)</code>
    /// </summary>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LayoutDesc, ACBindings.Internal.Archive*, void>)0x0069B370)(ref this, io_archive);

    /// <summary>
    /// <code>Offset: 0x0069B400
    /// bool __cdecl LayoutDesc::InqFullDesc(ElementDesc*,ElementDesc*,int*)</code>
    /// </summary>
    public static byte InqFullDesc(ACBindings.Internal.ElementDesc* rhs, ACBindings.Internal.ElementDesc* a2, int* a3) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.ElementDesc*, ACBindings.Internal.ElementDesc*, int*, byte>)0x0069B400)(rhs, a2, a3);
}

