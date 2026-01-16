namespace ACBindings.Internal;


/// <summary>Collects and manages properties identified by unique IDs, enabling efficient lookup via an auto‑growing hash table.</summary>
public unsafe struct PropertyCollection : System.IDisposable
{
    // Child Types

    /// <summary>VTable for PropertyCollection, holding function pointers that manage its lifecycle, including destructor and destroy operations.</summary>
    public unsafe struct PropertyCollection_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.PropertyCollection*, void> PropertyCollection_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.PropertyCollection*, void> Destroy; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public ACBindings.Internal.AutoGrowHashTable__uint___BaseProperty m_hashProperties;

    // Generated Constructor
    public PropertyCollection() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Determines whether the collection contains a property identified by the given unsigned integer key.
    /// <code>Offset: 0x004643E0
    /// bool __thiscall PropertyCollection::ContainsProperty(PropertyCollection*,const unsigned int)</code>
    /// </summary>
    /// <param name="propertyName">The identifier of the property to search for within the collection.</param>
    /// <returns>True if the property exists; otherwise, false.</returns>
    public byte ContainsProperty(uint propertyName) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PropertyCollection, uint, byte>)0x004643E0)(ref this, propertyName);

    /// <summary>Adds the given property to the collection using its name as a key.
    /// <code>Offset: 0x004753D0
    /// bool __thiscall PropertyCollection::AddProperty(PropertyCollection*,const BaseProperty*)</code>
    /// </summary>
    /// <param name="property">The property to add.</param>
    /// <returns>True if the property was added; false if an equivalent property already exists or insertion fails.</returns>
    public byte AddProperty(ACBindings.Internal.BaseProperty* property) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PropertyCollection, ACBindings.Internal.BaseProperty*, byte>)0x004753D0)(ref this, property);

    /// <summary>Recursively gathers all sub‑data identifiers from the properties in this collection into the supplied array.
    /// <code>Offset: 0x00680EB0
    /// void __thiscall PropertyCollection::GetSubDataIDs(PropertyCollection*,QualifiedDataIDArray*)</code>
    /// </summary>
    /// <param name="id_array">The QualifiedDataIDArray that will be populated with the collected data identifiers.</param>
    public void GetSubDataIDs(ACBindings.Internal.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PropertyCollection, ACBindings.Internal.QualifiedDataIDArray*, void>)0x00680EB0)(ref this, id_array);

    /// <summary>Copies properties from another PropertyCollection into this instance, updating existing entries or adding new ones based on a flag.
    /// <code>Offset: 0x006817E0
    /// bool __thiscall PropertyCollection::UpdateCollection(PropertyCollection*,const PropertyCollection*,const bool)</code>
    /// </summary>
    /// <param name="collection">The source collection whose properties are copied.</param>
    /// <param name="bAddNewProperties">If true, adds any properties that do not already exist in the current collection; if false, updates only existing properties.</param>
    /// <returns>True if all property insertions succeeded; otherwise false.</returns>
    public byte UpdateCollection(ACBindings.Internal.PropertyCollection* collection, byte bAddNewProperties) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PropertyCollection, ACBindings.Internal.PropertyCollection*, byte, byte>)0x006817E0)(ref this, collection, bAddNewProperties);

    /// <summary>Collects unique property group names from the collection, stores them in the provided array structure, and optionally sorts them using a supplied comparison function.
    /// <code>Offset: 0x006818B0
    /// char __thiscall PropertyCollection::InqPropertyGroupNames(_DWORD*,unsigned int**,PropertyGroupNameSort)</code>
    /// </summary>
    /// <param name="this">The PropertyCollection instance whose properties are queried.</param>
    /// <param name="a2">Pointer to an array structure that receives the group names. *a2 points to the data buffer; a2[1] holds the maximum capacity, and a2[2] tracks the current count, which is updated by this function.</param>
    /// <param name="a3">Optional comparator used to sort the collected group names. If null, no sorting occurs.</param>
    /// <returns>Always 1, indicating successful completion.</returns>
    public sbyte InqPropertyGroupNames(uint** a2, ACBindings.Internal.PropertyGroupNameSort a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PropertyCollection, uint**, ACBindings.Internal.PropertyGroupNameSort, sbyte>)0x006818B0)(ref this, a2, a3);

    /// <summary>Collects all properties that belong to the specified group into a dynamic array and optionally sorts them.
    /// <code>Offset: 0x006819F0
    /// char __thiscall PropertyCollection::InqPropertiesByGroup(_DWORD*,_DWORD*,BaseProperty**,BasePropertyNameSort)</code>
    /// </summary>
    /// <param name="a2">Pointer to the group identifier used to filter properties.</param>
    /// <param name="a3">Dynamic array of BaseProperty objects; the function appends matching entries and resizes it as needed.</param>
    /// <param name="a4">Optional comparison function. If provided, the collected properties are sorted using this comparator; otherwise no sorting is performed.</param>
    /// <returns>1 on success (the function always returns true).</returns>
    public sbyte InqPropertiesByGroup(int* a2, ACBindings.Internal.BaseProperty** a3, ACBindings.Internal.BasePropertyNameSort a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PropertyCollection, int*, ACBindings.Internal.BaseProperty**, ACBindings.Internal.BasePropertyNameSort, sbyte>)0x006819F0)(ref this, a2, a3, a4);

    /// <summary>Converts all properties in the collection into a hierarchical file node structure under the specified parent node.
    /// <code>Offset: 0x00681B30
    /// bool __thiscall PropertyCollection::ToFileNode(PropertyCollection*,PFileNode*)</code>
    /// </summary>
    /// <param name="node">The PFileNode to populate with property data.</param>
    /// <returns>True if conversion succeeded; otherwise false.</returns>
    public byte ToFileNode(ACBindings.Internal.PFileNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PropertyCollection, ACBindings.Internal.PFileNode*, byte>)0x00681B30)(ref this, node);

    /// <summary>Removes all properties flagged as client‑only from this collection, updating internal references and decrementing reference counts accordingly.
    /// <code>Offset: 0x00681D60
    /// void __thiscall PropertyCollection::PruneForServer(PropertyCollection*)</code>
    /// </summary>
    public void PruneForServer() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PropertyCollection, void>)0x00681D60)(ref this);

    /// <summary>Removes all server‑only properties from the collection, freeing associated resources and ensuring that a client retains only relevant data.
    /// <code>Offset: 0x00681E60
    /// void __thiscall PropertyCollection::PruneForClient(PropertyCollection*)</code>
    /// </summary>
    public void PruneForClient() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PropertyCollection, void>)0x00681E60)(ref this);

    /// <summary>Destroys a PropertyCollection, removing all stored properties and freeing the hash table’s bucket memory.
    /// <code>Offset: 0x00681F60
    /// void __thiscall PropertyCollection::~PropertyCollection(PropertyCollection*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PropertyCollection, void>)0x00681F60)(ref this);

    /// <summary>Parses the specified PFileNode and populates this PropertyCollection with its properties. The method iterates over property groups and individual properties, adding them to the internal hash table while reporting errors for invalid or duplicate entries.
    /// <code>Offset: 0x00681FB0
    /// bool __thiscall PropertyCollection::FromFileNode(PropertyCollection*,const PFileNode*)</code>
    /// </summary>
    /// <param name="node">The file node containing property group definitions.</param>
    /// <returns>True if all properties were processed successfully; otherwise false.</returns>
    public byte FromFileNode(ACBindings.Internal.PFileNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PropertyCollection, ACBindings.Internal.PFileNode*, byte>)0x00681FB0)(ref this, node);

    /// <summary>Initializes a PropertyCollection object, setting up its virtual function table and internal hash table to an empty state.
    /// <code>Offset: 0x006823D0
    /// void __thiscall PropertyCollection::PropertyCollection(PropertyCollection*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PropertyCollection, void>)0x006823D0)(ref this);

    /// <summary>Serializes the property collection into the specified archive, clearing the internal hash table if the archive’s retain‑flag is not set before serialization.
    /// <code>Offset: 0x00682420
    /// void __thiscall PropertyCollection::Serialize(PropertyCollection*,Archive*)</code>
    /// </summary>
    /// <param name="io_rcArchive">The archive that receives the serialized property data.</param>
    public void Serialize(ACBindings.Internal.Archive* io_rcArchive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PropertyCollection, ACBindings.Internal.Archive*, void>)0x00682420)(ref this, io_rcArchive);
}

