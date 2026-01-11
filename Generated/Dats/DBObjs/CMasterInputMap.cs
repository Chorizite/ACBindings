namespace ACBindings.Internal;

public unsafe struct CMasterInputMap : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.DBObj BaseClass_DBObj; // ACBindings.Internal.DBObj

    // Child Types
    public unsafe struct CMasterInputMap_vtbl
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

    /// <summary>
    /// <code>Offset: 0x004F7E00
    /// DBObj* __cdecl CMasterInputMap::Allocator()</code>
    /// </summary>
    public static ACBindings.Internal.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.DBObj*>)0x004F7E00)();

    /// <summary>
    /// <code>Offset: 0x006887D0
    /// CInputMap* __thiscall CMasterInputMap::GetInputMapByID(CMasterInputMap*,unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.CInputMap* GetInputMapByID(uint id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMasterInputMap, uint, ACBindings.Internal.CInputMap*>)0x006887D0)(ref this, id);

    /// <summary>
    /// <code>Offset: 0x0068DDB0
    /// bool __thiscall CMasterInputMap::ReadGuidFromFileNode(CMasterInputMap*,const PFileNode*,Turbine_GUID*)</code>
    /// </summary>
    public byte ReadGuidFromFileNode(ACBindings.Internal.PFileNode* i_pNode, ACBindings.Internal.Turbine_GUID* o_guid) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMasterInputMap, ACBindings.Internal.PFileNode*, ACBindings.Internal.Turbine_GUID*, byte>)0x0068DDB0)(ref this, i_pNode, o_guid);

    /// <summary>
    /// <code>Offset: 0x0068DFD0
    /// bool __thiscall CMasterInputMap::WriteGuidToFileNode(CMasterInputMap*,const Turbine_GUID*,PFileNode*)</code>
    /// </summary>
    public byte WriteGuidToFileNode(ACBindings.Internal.Turbine_GUID* i_guid, ACBindings.Internal.PFileNode* io_pNode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMasterInputMap, ACBindings.Internal.Turbine_GUID*, ACBindings.Internal.PFileNode*, byte>)0x0068DFD0)(ref this, i_guid, io_pNode);

    /// <summary>
    /// <code>Offset: 0x0068E0A0
    /// int __thiscall CMasterInputMap::AddDeviceEntry(CMasterInputMap*,const DeviceKeyMapEntry*)</code>
    /// </summary>
    public int AddDeviceEntry(ACBindings.Internal.DeviceKeyMapEntry* device) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMasterInputMap, ACBindings.Internal.DeviceKeyMapEntry*, int>)0x0068E0A0)(ref this, device);

    /// <summary>
    /// <code>Offset: 0x0068E600
    /// bool __thiscall CMasterInputMap::ReadDevicesFromFileNode(CMasterInputMap*,const PFileNode*)</code>
    /// </summary>
    public byte ReadDevicesFromFileNode(ACBindings.Internal.PFileNode* i_pNode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMasterInputMap, ACBindings.Internal.PFileNode*, byte>)0x0068E600)(ref this, i_pNode);

    /// <summary>
    /// <code>Offset: 0x0068E760
    /// bool __thiscall CMasterInputMap::IsMetaKey(CMasterInputMap*,ControlSpecification)</code>
    /// </summary>
    public byte IsMetaKey(ACBindings.Internal.ControlSpecification key) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMasterInputMap, ACBindings.Internal.ControlSpecification, byte>)0x0068E760)(ref this, key);

    /// <summary>
    /// <code>Offset: 0x0068E7A0
    /// unsigned int __thiscall CMasterInputMap::MetaModeFromKey(CMasterInputMap*,ControlSpecification)</code>
    /// </summary>
    public uint MetaModeFromKey(ACBindings.Internal.ControlSpecification key) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMasterInputMap, ACBindings.Internal.ControlSpecification, uint>)0x0068E7A0)(ref this, key);

    /// <summary>
    /// <code>Offset: 0x0068E7E0
    /// ControlSpecification* __thiscall CMasterInputMap::KeyFromMetaMode(CMasterInputMap*,ControlSpecification*,unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.ControlSpecification* KeyFromMetaMode(ACBindings.Internal.ControlSpecification* result, uint data) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMasterInputMap, ACBindings.Internal.ControlSpecification*, uint, ACBindings.Internal.ControlSpecification*>)0x0068E7E0)(ref this, result, data);

    /// <summary>
    /// <code>Offset: 0x0068E850
    /// bool __thiscall CMasterInputMap::ToFileNode(CMasterInputMap*,PFileNode*)</code>
    /// </summary>
    public byte ToFileNode(ACBindings.Internal.PFileNode* pRootNode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMasterInputMap, ACBindings.Internal.PFileNode*, byte>)0x0068E850)(ref this, pRootNode);

    /// <summary>
    /// <code>Offset: 0x0068F710
    /// void __thiscall CMasterInputMap::CMasterInputMap(CMasterInputMap*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMasterInputMap, void>)0x0068F710)(ref this);

    /// <summary>
    /// <code>Offset: 0x0068F770
    /// unsigned int __thiscall CMasterInputMap::GetDBOType(CMasterInputMap*)</code>
    /// </summary>
    public uint GetDBOType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMasterInputMap, uint>)0x0068F770)(ref this);

    /// <summary>
    /// <code>Offset: 0x0068FA90
    /// void __thiscall CMasterInputMap::Clear(CMasterInputMap*)</code>
    /// </summary>
    public void Clear() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMasterInputMap, void>)0x0068FA90)(ref this);

    /// <summary>
    /// <code>Offset: 0x00690070
    /// void __thiscall CMasterInputMap::~CMasterInputMap(CMasterInputMap*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMasterInputMap, void>)0x00690070)(ref this);

    /// <summary>
    /// <code>Offset: 0x00690130
    /// bool __thiscall CMasterInputMap::ReadMetaKeysFromFileNode(CMasterInputMap*,const PFileNode*)</code>
    /// </summary>
    public byte ReadMetaKeysFromFileNode(ACBindings.Internal.PFileNode* i_pNode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMasterInputMap, ACBindings.Internal.PFileNode*, byte>)0x00690130)(ref this, i_pNode);

    /// <summary>
    /// <code>Offset: 0x00690260
    /// CInputMap* __thiscall CMasterInputMap::CreateInputMap(CMasterInputMap*,unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.CInputMap* CreateInputMap(uint id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMasterInputMap, uint, ACBindings.Internal.CInputMap*>)0x00690260)(ref this, id);

    /// <summary>
    /// <code>Offset: 0x00690640
    /// bool __thiscall CMasterInputMap::Merge(CMasterInputMap*,const CMasterInputMap*,bool)</code>
    /// </summary>
    public byte Merge(ACBindings.Internal.CMasterInputMap* rhs, byte fForce) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMasterInputMap, ACBindings.Internal.CMasterInputMap*, byte, byte>)0x00690640)(ref this, rhs, fForce);

    /// <summary>
    /// <code>Offset: 0x006909E0
    /// bool __thiscall CMasterInputMap::ReadBindingsFromFileNode(CMasterInputMap*,const PFileNode*)</code>
    /// </summary>
    public byte ReadBindingsFromFileNode(ACBindings.Internal.PFileNode* i_pNode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMasterInputMap, ACBindings.Internal.PFileNode*, byte>)0x006909E0)(ref this, i_pNode);

    /// <summary>
    /// <code>Offset: 0x00690BC0
    /// bool __thiscall CMasterInputMap::CopyInto(CMasterInputMap*,DBObj*)</code>
    /// </summary>
    public byte CopyInto(ACBindings.Internal.DBObj* retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMasterInputMap, ACBindings.Internal.DBObj*, byte>)0x00690BC0)(ref this, retval);

    /// <summary>
    /// <code>Offset: 0x00690C30
    /// void __thiscall CMasterInputMap::Serialize(CMasterInputMap*,Archive*)</code>
    /// </summary>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMasterInputMap, ACBindings.Internal.Archive*, void>)0x00690C30)(ref this, io_archive);

    /// <summary>
    /// <code>Offset: 0x00690F30
    /// bool __thiscall CMasterInputMap::FromFileNode(CMasterInputMap*,const PFileNode*)</code>
    /// </summary>
    public byte FromFileNode(ACBindings.Internal.PFileNode* pRootNode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMasterInputMap, ACBindings.Internal.PFileNode*, byte>)0x00690F30)(ref this, pRootNode);
}

