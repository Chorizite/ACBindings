namespace ACBindings.Internal;


/// <summary>Central repository linking input devices to control specifications, storing device configurations, meta keys, and sections identified by a GUID.</summary>
public unsafe struct CMasterInputMap : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.DBObj BaseClass_DBObj; // ACBindings.Internal.DBObj

    // Child Types
    public unsafe struct CMasterInputMap_vtbl
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
    public ACBindings.Internal.PStringBase__sbyte m_strName;
    public ACBindings.Internal.Turbine_GUID m_guidMap;
    public ACBindings.Internal.SmartArray___DeviceKeyMapEntry m_rgDevices;
    public ACBindings.Internal.HashList___ControlSpecification__uint m_listMetaKeys;
    public ACBindings.Internal.HashList__uint___CInputMap_ptr m_hashSections;
    public uint m_dwUsedMetaKeys;

    // Generated Constructor
    public CMasterInputMap() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Creates a new CMasterInputMap instance and returns it as a DBObj pointer.
    /// <code>Offset: 0x004F7E00
    /// DBObj* __cdecl CMasterInputMap::Allocator()</code>
    /// </summary>
    /// <returns>A pointer to the newly allocated DBObj representing the CMasterInputMap, or nullptr if allocation fails.</returns>
    public static ACBindings.Internal.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.DBObj*>)0x004F7E00)();

    /// <summary>Retrieves an input map by its unique identifier from the master mapping structure.
    /// <code>Offset: 0x006887D0
    /// CInputMap* __thiscall CMasterInputMap::GetInputMapByID(CMasterInputMap*,unsigned int)</code>
    /// </summary>
    /// <param name="id">The identifier of the desired input map.</param>
    /// <returns>A pointer to the matching CInputMap instance, or nullptr if no match exists.</returns>
    public ACBindings.Internal.CInputMap* GetInputMapByID(uint id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMasterInputMap, uint, ACBindings.Internal.CInputMap*>)0x006887D0)(ref this, id);

    /// <summary>Parses a GUID from the supplied file node, interpreting special names for system mouse, keyboard, and virtual devices or extracting a GUID string.
    /// <code>Offset: 0x0068DDB0
    /// bool __thiscall CMasterInputMap::ReadGuidFromFileNode(CMasterInputMap*,const PFileNode*,Turbine_GUID*)</code>
    /// </summary>
    /// <param name="i_pNode">File node containing the GUID information.</param>
    /// <param name="o_guid">Output parameter that receives the parsed GUID on success.</param>
    /// <returns>True if the GUID was successfully read; otherwise false.</returns>
    public byte ReadGuidFromFileNode(ACBindings.Internal.PFileNode* i_pNode, ACBindings.Internal.Turbine_GUID* o_guid) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMasterInputMap, ACBindings.Internal.PFileNode*, ACBindings.Internal.Turbine_GUID*, byte>)0x0068DDB0)(ref this, i_pNode, o_guid);

    /// <summary>Creates a subnode under the specified file node representing the given GUID; uses predefined names for known system GUIDs, otherwise writes the raw GUID.
    /// <code>Offset: 0x0068DFD0
    /// bool __thiscall CMasterInputMap::WriteGuidToFileNode(CMasterInputMap*,const Turbine_GUID*,PFileNode*)</code>
    /// </summary>
    /// <param name="i_guid">The GUID to be written to the file node.</param>
    /// <param name="io_pNode">The file node that will receive the new subnode.</param>
    /// <returns>True if the subnode was successfully created; otherwise false.</returns>
    public byte WriteGuidToFileNode(ACBindings.Internal.Turbine_GUID* i_guid, ACBindings.Internal.PFileNode* io_pNode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMasterInputMap, ACBindings.Internal.Turbine_GUID*, ACBindings.Internal.PFileNode*, byte>)0x0068DFD0)(ref this, i_guid, io_pNode);

    /// <summary>Adds a device entry to the input map if it is not already present and returns its zero‑based index in the internal device list.
    /// <code>Offset: 0x0068E0A0
    /// int __thiscall CMasterInputMap::AddDeviceEntry(CMasterInputMap*,const DeviceKeyMapEntry*)</code>
    /// </summary>
    /// <param name="device">The device entry to add or locate within the map.</param>
    /// <returns>The index of the specified device in the map's device array; if the device was already present, the existing index is returned, otherwise the new index after insertion.</returns>
    public int AddDeviceEntry(ACBindings.Internal.DeviceKeyMapEntry* device) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMasterInputMap, ACBindings.Internal.DeviceKeyMapEntry*, int>)0x0068E0A0)(ref this, device);

    /// <summary>Parses device definitions from the supplied file node and populates the input map's device list.
    /// <code>Offset: 0x0068E600
    /// bool __thiscall CMasterInputMap::ReadDevicesFromFileNode(CMasterInputMap*,const PFileNode*)</code>
    /// </summary>
    /// <param name="i_pNode">File node containing device child nodes to read.</param>
    /// <returns>True if all devices were successfully parsed; false on error, with an error reported via the file node system.</returns>
    public byte ReadDevicesFromFileNode(ACBindings.Internal.PFileNode* i_pNode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMasterInputMap, ACBindings.Internal.PFileNode*, byte>)0x0068E600)(ref this, i_pNode);

    /// <summary>Determines if a control specification represents a meta key defined within the input map.
    /// <code>Offset: 0x0068E760
    /// bool __thiscall CMasterInputMap::IsMetaKey(CMasterInputMap*,ControlSpecification)</code>
    /// </summary>
    /// <param name="key">ControlSpecification to test for membership in the map's meta key list.</param>
    /// <returns>True when the control specification exists as a meta key; otherwise false.</returns>
    public byte IsMetaKey(ACBindings.Internal.ControlSpecification key) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMasterInputMap, ACBindings.Internal.ControlSpecification, byte>)0x0068E760)(ref this, key);

    /// <summary>Retrieves the meta mode associated with a control specification from the map’s internal hash list.
    /// <code>Offset: 0x0068E7A0
    /// unsigned int __thiscall CMasterInputMap::MetaModeFromKey(CMasterInputMap*,ControlSpecification)</code>
    /// </summary>
    /// <param name="key">The ControlSpecification identifying the desired meta key.</param>
    /// <returns>The unsigned integer representing the meta mode, or 0 when the key is not present.</returns>
    public uint MetaModeFromKey(ACBindings.Internal.ControlSpecification key) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMasterInputMap, ACBindings.Internal.ControlSpecification, uint>)0x0068E7A0)(ref this, key);

    /// <summary>Searches the map’s meta‑key list for an entry matching the given identifier and writes the associated key into the supplied ControlSpecification, or sets the key field to –1 if none exists.
    /// <code>Offset: 0x0068E7E0
    /// ControlSpecification* __thiscall CMasterInputMap::KeyFromMetaMode(CMasterInputMap*,ControlSpecification*,unsigned int)</code>
    /// </summary>
    /// <param name="result">The ControlSpecification instance whose m_dwKey field will receive the found key or –1 when not matched.</param>
    /// <param name="data">Identifier used to locate a matching meta‑key entry.</param>
    /// <returns>The same ControlSpecification pointer passed in, now populated with the retrieved key value.</returns>
    public ACBindings.Internal.ControlSpecification* KeyFromMetaMode(ACBindings.Internal.ControlSpecification* result, uint data) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMasterInputMap, ACBindings.Internal.ControlSpecification*, uint, ACBindings.Internal.ControlSpecification*>)0x0068E7E0)(ref this, result, data);

    /// <summary>Serialises this input map into the specified file node hierarchy, creating sub‑nodes for devices, meta keys and bindings.
    /// <code>Offset: 0x0068E850
    /// bool __thiscall CMasterInputMap::ToFileNode(CMasterInputMap*,PFileNode*)</code>
    /// </summary>
    /// <param name="pRootNode">The root node under which the mapping data will be written.</param>
    /// <returns>True if all components were successfully converted to file nodes; otherwise false.</returns>
    public byte ToFileNode(ACBindings.Internal.PFileNode* pRootNode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMasterInputMap, ACBindings.Internal.PFileNode*, byte>)0x0068E850)(ref this, pRootNode);

    /// <summary>Initializes a new master input map with default configuration, setting up base class data, assigning the name string “User Defined Keymap”, and clearing device list, meta key and section tables along with usage counters.
    /// <code>Offset: 0x0068F710
    /// void __thiscall CMasterInputMap::CMasterInputMap(CMasterInputMap*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMasterInputMap, void>)0x0068F710)(ref this);

    /// <summary>Retrieves the database object type for this input map instance.
    /// <code>Offset: 0x0068F770
    /// unsigned int __thiscall CMasterInputMap::GetDBOType(CMasterInputMap*)</code>
    /// </summary>
    /// <returns>The numeric identifier representing the object's type in the database system.</returns>
    public uint GetDBOType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMasterInputMap, uint>)0x0068F770)(ref this);

    /// <summary>Removes every section and associated meta‑key entry from the input map, releasing allocated memory.
    /// <code>Offset: 0x0068FA90
    /// void __thiscall CMasterInputMap::Clear(CMasterInputMap*)</code>
    /// </summary>
    public void Clear() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMasterInputMap, void>)0x0068FA90)(ref this);

    /// <summary>Destroys a CMasterInputMap instance, freeing all internal data structures such as device mappings, meta‑key lists, section hashes, and the input map name. It also calls the base class destructor to finalize cleanup.
    /// <code>Offset: 0x00690070
    /// void __thiscall CMasterInputMap::~CMasterInputMap(CMasterInputMap*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMasterInputMap, void>)0x00690070)(ref this);

    /// <summary>
    /// Reads meta key definitions from a file node, validating each entry’s index (1–32) and associated device before adding it to the input map.
    /// 
    /// <code>Offset: 0x00690130
    /// bool __thiscall CMasterInputMap::ReadMetaKeysFromFileNode(CMasterInputMap*,const PFileNode*)</code>
    /// </summary>
    /// <param name="i_pNode">The file node containing subnodes that describe meta keys.</param>
    /// <returns>True if all entries were successfully processed; otherwise false when an invalid index or device is encountered.</returns>
    public byte ReadMetaKeysFromFileNode(ACBindings.Internal.PFileNode* i_pNode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMasterInputMap, ACBindings.Internal.PFileNode*, byte>)0x00690130)(ref this, i_pNode);

    /// <summary>Retrieves the input map associated with the specified identifier, creating a new one if none exists.
    /// <code>Offset: 0x00690260
    /// CInputMap* __thiscall CMasterInputMap::CreateInputMap(CMasterInputMap*,unsigned int)</code>
    /// </summary>
    /// <param name="id">Identifier used to locate the desired input map within the master collection.</param>
    /// <returns>Pointer to the existing or newly created CInputMap; null if memory allocation fails.</returns>
    public ACBindings.Internal.CInputMap* CreateInputMap(uint id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMasterInputMap, uint, ACBindings.Internal.CInputMap*>)0x00690260)(ref this, id);

    /// <summary>Integrates another input map into the current one by combining its device key entries, metadata keys, and input sections. When duplicate identifiers are encountered, existing mappings are preserved unless forced overwrite is requested.
    /// <code>Offset: 0x00690640
    /// bool __thiscall CMasterInputMap::Merge(CMasterInputMap*,const CMasterInputMap*,bool)</code>
    /// </summary>
    /// <param name="rhs">Source input map whose contents will be merged into this map.</param>
    /// <param name="fForce">If true, conflicting entries from the source overwrite those in the destination; otherwise they are skipped.</param>
    /// <returns>True if all entries were merged successfully; false when a conflict prevented merging and force mode was not enabled.</returns>
    public byte Merge(ACBindings.Internal.CMasterInputMap* rhs, byte fForce) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMasterInputMap, ACBindings.Internal.CMasterInputMap*, byte, byte>)0x00690640)(ref this, rhs, fForce);

    /// <summary>Reads input binding definitions from a file node, creating new input maps for each unique valid section name and adding them to the master map. Reports an error if a section has an invalid name or duplicates an existing entry.
    /// <code>Offset: 0x006909E0
    /// bool __thiscall CMasterInputMap::ReadBindingsFromFileNode(CMasterInputMap*,const PFileNode*)</code>
    /// </summary>
    /// <param name="i_pNode">The root PFileNode containing subnodes that define individual input maps.</param>
    /// <returns>True if all sections were processed successfully; false if any duplicate or invalid names were encountered.</returns>
    public byte ReadBindingsFromFileNode(ACBindings.Internal.PFileNode* i_pNode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMasterInputMap, ACBindings.Internal.PFileNode*, byte>)0x006909E0)(ref this, i_pNode);

    /// <summary>Copies the current input map's name and GUID values into a supplied DBObj, then merges section data into it.
    /// <code>Offset: 0x00690BC0
    /// bool __thiscall CMasterInputMap::CopyInto(CMasterInputMap*,DBObj*)</code>
    /// </summary>
    /// <param name="retval">Destination object that receives the copied data.</param>
    /// <returns>True if merge operation succeeds; otherwise false.</returns>
    public byte CopyInto(ACBindings.Internal.DBObj* retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMasterInputMap, ACBindings.Internal.DBObj*, byte>)0x00690BC0)(ref this, retval);

    /// <summary>Serializes or deserializes a CMasterInputMap, writing its base data, name, GUID, device mappings, meta‑key specifications, and contained input maps to an Archive, or reading them back when in read mode.
    /// <code>Offset: 0x00690C30
    /// void __thiscall CMasterInputMap::Serialize(CMasterInputMap*,Archive*)</code>
    /// </summary>
    /// <param name="io_archive">Archive used for serialization; contains the object's state after write or supplies data for deserialization.</param>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMasterInputMap, ACBindings.Internal.Archive*, void>)0x00690C30)(ref this, io_archive);

    /// <summary>Populates the input map from the specified file node hierarchy, reading name, GUID, devices, meta‑keys and bindings in that order.
    /// <code>Offset: 0x00690F30
    /// bool __thiscall CMasterInputMap::FromFileNode(CMasterInputMap*,const PFileNode*)</code>
    /// </summary>
    /// <param name="pRootNode">Root node containing four subnodes: Name, Devices, MetaKeys, Bindings.</param>
    /// <returns>True if all components were successfully loaded; otherwise false and an error is reported when the structure is incorrect or a component fails to load.</returns>
    public byte FromFileNode(ACBindings.Internal.PFileNode* pRootNode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMasterInputMap, ACBindings.Internal.PFileNode*, byte>)0x00690F30)(ref this, pRootNode);
}

