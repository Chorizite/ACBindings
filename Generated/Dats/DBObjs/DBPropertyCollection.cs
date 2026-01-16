namespace ACBindings.Internal;


/// <summary>Combines a PropertyCollection with a DBObj base, representing a database object’s set of properties and metadata. Supports storage, retrieval, and serialization within the application’s data graph.</summary>
public unsafe struct DBPropertyCollection
{
    // Base Classes
    public ACBindings.Internal.PropertyCollection BaseClass_PropertyCollection; // ACBindings.Internal.PropertyCollection
    public ACBindings.Internal.DBObj BaseClass_DBObj; // ACBindings.Internal.DBObj

    // Child Types
    public unsafe struct DBPropertyCollection_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBPropertyCollection*, void> DBPropertyCollection_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBPropertyCollection*, void> Destroy; // function pointer

        // Methods
    }

    // Generated Constructor
    public DBPropertyCollection() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>Allocates and constructs a new DBPropertyCollection instance, returning a pointer to its embedded DBObj base object. Returns nullptr if allocation or construction fails.
    /// <code>Offset: 0x004F7EF0
    /// DBObj* __cdecl DBPropertyCollection::Allocator()</code>
    /// </summary>
    /// <returns>A pointer to the constructed DBObj portion of the newly allocated DBPropertyCollection, or nullptr on failure.</returns>
    public static ACBindings.Internal.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.DBObj*>)0x004F7EF0)();

    /// <summary>Initializes a new DBPropertyCollection instance by constructing its PropertyCollection base class and DBObj base component, setting up the appropriate virtual tables.
    /// <code>Offset: 0x00682450
    /// void __thiscall DBPropertyCollection::DBPropertyCollection(DBPropertyCollection*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DBPropertyCollection, void>)0x00682450)(ref this);

    /// <summary>Retrieves the numeric identifier for the DBObject type represented by this property collection.
    /// <code>Offset: 0x00682480
    /// unsigned int __thiscall DBPropertyCollection::GetDBOType(DBPropertyCollection*)</code>
    /// </summary>
    /// <returns>The unsigned integer value identifying the DBO type (currently constant 49).</returns>
    public uint GetDBOType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DBPropertyCollection, uint>)0x00682480)(ref this);

    /// <summary>Serializes the DBPropertyCollection, including its database metadata and property entries, to or from the specified Archive.
    /// <code>Offset: 0x00682490
    /// void __thiscall DBPropertyCollection::Serialize(DBPropertyCollection*,Archive*)</code>
    /// </summary>
    /// <param name="io_archive">The Archive instance used for reading or writing the collection data.</param>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DBPropertyCollection, ACBindings.Internal.Archive*, void>)0x00682490)(ref this, io_archive);

    /// <summary>Collects identifiers for all sub‑objects held by this DBPropertyCollection into the supplied QualifiedDataIDArray.
    /// <code>Offset: 0x006824B0
    /// void __thiscall DBPropertyCollection::GetSubDataIDs(DBPropertyCollection*,QualifiedDataIDArray*)</code>
    /// </summary>
    /// <param name="id_array">The array that will receive qualified data IDs representing each sub‑object within the collection.</param>
    public void GetSubDataIDs(ACBindings.Internal.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DBPropertyCollection, ACBindings.Internal.QualifiedDataIDArray*, void>)0x006824B0)(ref this, id_array);

    /// <summary>Copies all properties from the current collection into the supplied DBObj's internal property hash table. If the target pointer is null, the routine still attempts to assign to a hard‑coded address, resulting in undefined behavior.
    /// <code>Offset: 0x00682540
    /// bool __thiscall DBPropertyCollection::CopyInto(DBPropertyCollection*,DBObj*)</code>
    /// </summary>
    /// <param name="retval">The DBObj that will receive the copied properties; must not be null.</param>
    /// <returns>True after the copy operation (the function always reports success).</returns>
    public byte CopyInto(ACBindings.Internal.DBObj* retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DBPropertyCollection, ACBindings.Internal.DBObj*, byte>)0x00682540)(ref this, retval);
}

