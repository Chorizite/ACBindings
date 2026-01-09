namespace ACBindings;

// MasterProperty
public unsafe struct MasterProperty : System.IDisposable
{
    // Base Classes
    public ACBindings.DBObj BaseClass_DBObj; // ACBindings.DBObj

    // Child Types
    // MasterProperty_vtbl
    public unsafe struct MasterProperty_vtbl
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
    public ACBindings.EnumMapper m_emapper;
    public ACBindings.HashTable__uint__BasePropertyDesc_ptr m_properties;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // char __cdecl MasterProperty::InqPropertyNameStringStatic(int,volatile LONG**)
    public static sbyte InqPropertyNameStringStatic(int a1, int** a2) => ((delegate* unmanaged[Cdecl]<int, int**, sbyte>)0x004268D0)(a1, a2);
    // char __cdecl MasterProperty::InqPropertyGroupNameStringStatic(int,int*)
    public static sbyte InqPropertyGroupNameStringStatic(int a1, int* a2) => ((delegate* unmanaged[Cdecl]<int, int*, sbyte>)0x00426910)(a1, a2);
    // char __cdecl MasterProperty::InqPropertyNameEnumStatic(int*,_DWORD*)
    public static sbyte InqPropertyNameEnumStatic(int* a1, int* a2) => ((delegate* unmanaged[Cdecl]<int*, int*, sbyte>)0x004271F0)(a1, a2);
    // bool __thiscall MasterProperty::InqAvailablePropertiesByPropertyGroup(MasterProperty*,unsigned int,AvailablePropertySet*)
    public byte InqAvailablePropertiesByPropertyGroup(uint group_name, ACBindings.AvailablePropertySet* set) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MasterProperty, uint, ACBindings.AvailablePropertySet*, byte>)0x00427240)(ref this, group_name, set);
    // void __thiscall MasterProperty::GetSubDataIDs(MasterProperty*,QualifiedDataIDArray*)
    public void GetSubDataIDs(ACBindings.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MasterProperty, ACBindings.QualifiedDataIDArray*, void>)0x004272C0)(ref this, id_array);
    // BasePropertyDesc* __thiscall MasterProperty::AccessPropertyDesc(MasterProperty*,unsigned int)
    public ACBindings.BasePropertyDesc* AccessPropertyDesc(uint name_enum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MasterProperty, uint, ACBindings.BasePropertyDesc*>)0x004284B0)(ref this, name_enum);
    // bool __thiscall MasterProperty::CopyInto(MasterProperty*,DBObj*)
    public byte CopyInto(ACBindings.DBObj* retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MasterProperty, ACBindings.DBObj*, byte>)0x00428C90)(ref this, retval);
    // void __thiscall MasterProperty::Destroy(MasterProperty*)
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.MasterProperty, void>)0x00428D40)(ref this);
    // unsigned int __thiscall MasterProperty::GetDBOType(MasterProperty*)
    public uint GetDBOType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.MasterProperty, uint>)0x00428E20)(ref this);
    // void __thiscall MasterProperty::~MasterProperty(MasterProperty*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.MasterProperty, void>)0x00428E30)(ref this);
    // void __thiscall MasterProperty::Serialize(MasterProperty*,Archive*)
    public void Serialize(ACBindings.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MasterProperty, ACBindings.Archive*, void>)0x00428E90)(ref this, io_archive);
    // DBObj* __cdecl MasterProperty::Allocator()
    public static ACBindings.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.DBObj*>)0x00428F50)();
    // BasePropertyValue* __cdecl MasterProperty::AllocatePropertyValue(unsigned int)
    public static ACBindings.BasePropertyValue* AllocatePropertyValue(uint type_enum) => ((delegate* unmanaged[Cdecl]<uint, ACBindings.BasePropertyValue*>)0x004293C0)(type_enum);
}

