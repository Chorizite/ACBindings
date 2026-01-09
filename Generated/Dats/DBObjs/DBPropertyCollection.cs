namespace ACBindings;

// DBPropertyCollection
public unsafe struct DBPropertyCollection
{
    // Base Classes
    public ACBindings.PropertyCollection BaseClass_PropertyCollection; // ACBindings.PropertyCollection
    public ACBindings.DBObj BaseClass_DBObj; // ACBindings.DBObj

    // Child Types
    // DBPropertyCollection_vtbl
    public unsafe struct DBPropertyCollection_vtbl
    {
        // Members
        public System.IntPtr DBPropertyCollection_dtor_0; // function pointer
        public System.IntPtr Destroy; // function pointer

        // Methods
    }

    // Generated Constructor
    public DBPropertyCollection() {
        _ConstructorInternal();
    }

    // Methods
    // DBObj* __cdecl DBPropertyCollection::Allocator()
    public static ACBindings.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.DBObj*>)0x004F7EF0)();
    // void __thiscall DBPropertyCollection::DBPropertyCollection(DBPropertyCollection*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.DBPropertyCollection, void>)0x00682450)(ref this);
    // unsigned int __thiscall DBPropertyCollection::GetDBOType(DBPropertyCollection*)
    public uint GetDBOType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.DBPropertyCollection, uint>)0x00682480)(ref this);
    // void __thiscall DBPropertyCollection::Serialize(DBPropertyCollection*,Archive*)
    public void Serialize(ACBindings.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.DBPropertyCollection, ACBindings.Archive*, void>)0x00682490)(ref this, io_archive);
    // void __thiscall DBPropertyCollection::GetSubDataIDs(DBPropertyCollection*,QualifiedDataIDArray*)
    public void GetSubDataIDs(ACBindings.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.DBPropertyCollection, ACBindings.QualifiedDataIDArray*, void>)0x006824B0)(ref this, id_array);
    // bool __thiscall DBPropertyCollection::CopyInto(DBPropertyCollection*,DBObj*)
    public byte CopyInto(ACBindings.DBObj* retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.DBPropertyCollection, ACBindings.DBObj*, byte>)0x00682540)(ref this, retval);
}

