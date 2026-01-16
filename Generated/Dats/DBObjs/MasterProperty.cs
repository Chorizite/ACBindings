namespace ACBindings.Internal;


/// <summary>Encapsulates property metadata, providing enumeration‑to‑descriptor mapping and hash‑based storage of base properties for rapid access within the system.</summary>
public unsafe struct MasterProperty : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.DBObj BaseClass_DBObj; // ACBindings.Internal.DBObj

    // Child Types
    public unsafe struct MasterProperty_vtbl
    {
        // Members
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, ACBindings.Internal._GUID*, void**, int> IUnknown_QueryInterface; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_AddRef; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_Release; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, ACBindings.Internal.TResult*, ACBindings.Internal.Turbine_GUID*, void**, ACBindings.Internal.TResult*> QueryInterface; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> AddRef; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> Release; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, void> DBObj_dtor_18; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.Archive*, void> Serialize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.QualifiedDataIDArray*, void> GetSubDataIDs; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> InitLoad; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> GetSubObjects; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> ReleaseSubObjects; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> NotifyFidelityLevel; // function pointer
        public System.IntPtr Refresh;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.DBObj*, byte> CopyInto; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, void> Destroy; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.IDataGraph*, void> FillDataGraph; // function pointer
        public System.IntPtr SetDID;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, uint> GetDBOType; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.DBObj*> Allocate; // function pointer
        public System.IntPtr SaveToDisk;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> ReloadFromDisk; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.EnumMapper m_emapper;
    public ACBindings.Internal.HashTable__uint___BasePropertyDesc_ptr m_properties;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Retrieves the name string for a property identified by an enumeration value and stores it in the provided output parameter.
    /// <code>Offset: 0x004268D0
    /// char __cdecl MasterProperty::InqPropertyNameStringStatic(int,volatile LONG**)</code>
    /// </summary>
    /// <param name="a1">Enumeration key that specifies which property's name to retrieve.</param>
    /// <param name="a2">Output pointer that receives the retrieved name string. The caller must not modify this memory after use.</param>
    /// <returns>Non‑zero on success; zero if no MasterProperty instance is available or lookup fails.</returns>
    public static sbyte InqPropertyNameStringStatic(int a1, int** a2) => ((delegate* unmanaged[Cdecl]<int, int**, sbyte>)0x004268D0)(a1, a2);

    /// <summary>Obtains the name of a property group from the master property table.
    /// <code>Offset: 0x00426910
    /// char __cdecl MasterProperty::InqPropertyGroupNameStringStatic(int,int*)</code>
    /// </summary>
    /// <param name="a1">Identifier for the desired property group.</param>
    /// <param name="a2">Pointer to receive additional information about the string retrieved.</param>
    /// <returns>A non‑zero character if the lookup succeeded; otherwise returns 0, or 0 when no MasterProperty is available.</returns>
    public static sbyte InqPropertyGroupNameStringStatic(int a1, int* a2) => ((delegate* unmanaged[Cdecl]<int, int*, sbyte>)0x00426910)(a1, a2);

    /// <summary>Retrieves the enumeration value associated with a MasterProperty identifier, storing it in the supplied output buffer while incrementing the reference count of the underlying database object.
    /// <code>Offset: 0x004271F0
    /// char __cdecl MasterProperty::InqPropertyNameEnumStatic(int*,_DWORD*)</code>
    /// </summary>
    /// <param name="a1">Pointer to an integer holding the property identifier; the function increments the reference counter of the corresponding DB object before querying.</param>
    /// <param name="a2">Output parameter that receives the enumeration value linked to the supplied property identifier.</param>
    /// <returns>Non‑zero character code on success; zero if no MasterProperty instance is available or lookup fails.</returns>
    public static sbyte InqPropertyNameEnumStatic(int* a1, int* a2) => ((delegate* unmanaged[Cdecl]<int*, int*, sbyte>)0x004271F0)(a1, a2);

    /// <summary>Queries all properties of this MasterProperty instance that belong to the specified property group and adds each matching property to the supplied AvailablePropertySet. The operation aborts and returns false if any addition fails; otherwise returns true.
    /// <code>Offset: 0x00427240
    /// bool __thiscall MasterProperty::InqAvailablePropertiesByPropertyGroup(MasterProperty*,unsigned int,AvailablePropertySet*)</code>
    /// </summary>
    /// <param name="group_name">Identifier of the property group to filter by.</param>
    /// <param name="set">The AvailablePropertySet instance that will receive all matched properties.</param>
    /// <returns>True if every matching property was added successfully; false if an AddProperty call failed.</returns>
    public byte InqAvailablePropertiesByPropertyGroup(uint group_name, ACBindings.Internal.AvailablePropertySet* set) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MasterProperty, uint, ACBindings.Internal.AvailablePropertySet*, byte>)0x00427240)(ref this, group_name, set);

    /// <summary>Collects all sub‑data identifiers from the master property's properties and appends them to the provided array.
    /// <code>Offset: 0x004272C0
    /// void __thiscall MasterProperty::GetSubDataIDs(MasterProperty*,QualifiedDataIDArray*)</code>
    /// </summary>
    /// <param name="id_array">The array to receive the collected data identifiers.</param>
    public void GetSubDataIDs(ACBindings.Internal.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MasterProperty, ACBindings.Internal.QualifiedDataIDArray*, void>)0x004272C0)(ref this, id_array);

    /// <summary>Retrieves the property descriptor for a specified property name from this master's property table, returning nullptr when no matching entry exists.
    /// <code>Offset: 0x004284B0
    /// BasePropertyDesc* __thiscall MasterProperty::AccessPropertyDesc(MasterProperty*,unsigned int)</code>
    /// </summary>
    /// <param name="name_enum">Enumeration value identifying the desired property.</param>
    /// <returns>Pointer to the corresponding BasePropertyDesc if found; otherwise null.</returns>
    public ACBindings.Internal.BasePropertyDesc* AccessPropertyDesc(uint name_enum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MasterProperty, uint, ACBindings.Internal.BasePropertyDesc*>)0x004284B0)(ref this, name_enum);

    /// <summary>Copies all property entries from this MasterProperty into the supplied DBObj by inserting them into its data category hash table, incrementing reference counts as necessary.
    /// <code>Offset: 0x00428C90
    /// bool __thiscall MasterProperty::CopyInto(MasterProperty*,DBObj*)</code>
    /// </summary>
    /// <param name="retval">The DBObj instance to receive copies of the properties.</param>
    /// <returns>True when copying completes successfully; always true in current implementation.</returns>
    public byte CopyInto(ACBindings.Internal.DBObj* retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MasterProperty, ACBindings.Internal.DBObj*, byte>)0x00428C90)(ref this, retval);

    /// <summary>Releases all property descriptors stored in the instance’s hash table, decrements their reference counts, and clears the table.
    /// <code>Offset: 0x00428D40
    /// void __thiscall MasterProperty::Destroy(MasterProperty*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MasterProperty, void>)0x00428D40)(ref this);

    /// <summary>Returns the database object type identifier for a MasterProperty instance.
    /// <code>Offset: 0x00428E20
    /// unsigned int __thiscall MasterProperty::GetDBOType(MasterProperty*)</code>
    /// </summary>
    /// <returns>A constant value of 45 representing the DBO type.</returns>
    public uint GetDBOType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MasterProperty, uint>)0x00428E20)(ref this);

    /// <summary>
    /// Destroys a MasterProperty instance by releasing its hash table, freeing allocated buckets, destroying enumerator mappings, and invoking destructors for base DBObj and other member objects.
    /// 
    /// <code>Offset: 0x00428E30
    /// void __thiscall MasterProperty::~MasterProperty(MasterProperty*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MasterProperty, void>)0x00428E30)(ref this);

    /// <summary>Serializes the MasterProperty instance, writing or reading its base data, enum mapper reference count, and property table to the supplied archive.
    /// <code>Offset: 0x00428E90
    /// void __thiscall MasterProperty::Serialize(MasterProperty*,Archive*)</code>
    /// </summary>
    /// <param name="io_archive">The Archive used for serialization.</param>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MasterProperty, ACBindings.Internal.Archive*, void>)0x00428E90)(ref this, io_archive);

    /// <summary>Allocates memory for a new MasterProperty object, initializes its base DBObj component, sets up vtables, and constructs internal EnumMapper and HashTable members.
    /// <code>Offset: 0x00428F50
    /// DBObj* __cdecl MasterProperty::Allocator()</code>
    /// </summary>
    /// <returns>Pointer to the newly constructed DBObj instance, or nullptr if allocation fails.</returns>
    public static ACBindings.Internal.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.DBObj*>)0x00428F50)();

    /// <summary>Allocates and initializes a new property value of the specified type, returning a pointer to BasePropertyValue.
    /// <code>Offset: 0x004293C0
    /// BasePropertyValue* __cdecl MasterProperty::AllocatePropertyValue(unsigned int)</code>
    /// </summary>
    /// <param name="type_enum">Enumeration identifying the property type to allocate.</param>
    /// <returns>Pointer to the newly allocated BasePropertyValue instance or null if allocation fails or the type is unsupported.</returns>
    public static ACBindings.Internal.BasePropertyValue* AllocatePropertyValue(uint type_enum) => ((delegate* unmanaged[Cdecl]<uint, ACBindings.Internal.BasePropertyValue*>)0x004293C0)(type_enum);
}

