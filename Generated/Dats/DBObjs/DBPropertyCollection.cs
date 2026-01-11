namespace ACBindings.Internal;

public unsafe struct DBPropertyCollection
{
    // Base Classes
    public ACBindings.Internal.PropertyCollection BaseClass_PropertyCollection; // ACBindings.Internal.PropertyCollection
    public ACBindings.Internal.DBObj BaseClass_DBObj; // ACBindings.Internal.DBObj

    // Child Types
    public unsafe struct DBPropertyCollection_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBPropertyCollection*, void> DBPropertyCollection_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBPropertyCollection*, void> Destroy; // function pointer

        // Methods
    }

    // Generated Constructor
    public DBPropertyCollection() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x004F7EF0
    /// DBObj* __cdecl DBPropertyCollection::Allocator()</code>
    /// </summary>
    public static ACBindings.Internal.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.DBObj*>)0x004F7EF0)();

    /// <summary>
    /// <code>Offset: 0x00682450
    /// void __thiscall DBPropertyCollection::DBPropertyCollection(DBPropertyCollection*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DBPropertyCollection, void>)0x00682450)(ref this);

    /// <summary>
    /// <code>Offset: 0x00682480
    /// unsigned int __thiscall DBPropertyCollection::GetDBOType(DBPropertyCollection*)</code>
    /// </summary>
    public uint GetDBOType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DBPropertyCollection, uint>)0x00682480)(ref this);

    /// <summary>
    /// <code>Offset: 0x00682490
    /// void __thiscall DBPropertyCollection::Serialize(DBPropertyCollection*,Archive*)</code>
    /// </summary>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DBPropertyCollection, ACBindings.Internal.Archive*, void>)0x00682490)(ref this, io_archive);

    /// <summary>
    /// <code>Offset: 0x006824B0
    /// void __thiscall DBPropertyCollection::GetSubDataIDs(DBPropertyCollection*,QualifiedDataIDArray*)</code>
    /// </summary>
    public void GetSubDataIDs(ACBindings.Internal.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DBPropertyCollection, ACBindings.Internal.QualifiedDataIDArray*, void>)0x006824B0)(ref this, id_array);

    /// <summary>
    /// <code>Offset: 0x00682540
    /// bool __thiscall DBPropertyCollection::CopyInto(DBPropertyCollection*,DBObj*)</code>
    /// </summary>
    public byte CopyInto(ACBindings.Internal.DBObj* retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DBPropertyCollection, ACBindings.Internal.DBObj*, byte>)0x00682540)(ref this, retval);
}

