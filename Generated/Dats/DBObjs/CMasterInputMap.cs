namespace ACBindings;

// CMasterInputMap
public unsafe struct CMasterInputMap : System.IDisposable
{
    // Base Classes
    public ACBindings.DBObj BaseClass_DBObj; // ACBindings.DBObj

    // Child Types
    // CMasterInputMap_vtbl
    public unsafe struct CMasterInputMap_vtbl
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
    public ACBindings.PStringBase__sbyte m_strName;
    public ACBindings.Turbine_GUID m_guidMap;
    public ACBindings.SmartArray__DeviceKeyMapEntry m_rgDevices;
    public ACBindings.HashList__ControlSpecification__uint m_listMetaKeys;
    public ACBindings.HashList__uint__CInputMap_ptr m_hashSections;
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
    // DBObj* __cdecl CMasterInputMap::Allocator()
    public static ACBindings.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.DBObj*>)0x004F7E00)();
    // CInputMap* __thiscall CMasterInputMap::GetInputMapByID(CMasterInputMap*,unsigned int)
    public ACBindings.CInputMap* GetInputMapByID(uint id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CMasterInputMap, uint, ACBindings.CInputMap*>)0x006887D0)(ref this, id);
    // bool __thiscall CMasterInputMap::ReadGuidFromFileNode(CMasterInputMap*,const PFileNode*,Turbine_GUID*)
    public byte ReadGuidFromFileNode(ACBindings.PFileNode* i_pNode, ACBindings.Turbine_GUID* o_guid) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CMasterInputMap, ACBindings.PFileNode*, ACBindings.Turbine_GUID*, byte>)0x0068DDB0)(ref this, i_pNode, o_guid);
    // bool __thiscall CMasterInputMap::WriteGuidToFileNode(CMasterInputMap*,const Turbine_GUID*,PFileNode*)
    public byte WriteGuidToFileNode(ACBindings.Turbine_GUID* i_guid, ACBindings.PFileNode* io_pNode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CMasterInputMap, ACBindings.Turbine_GUID*, ACBindings.PFileNode*, byte>)0x0068DFD0)(ref this, i_guid, io_pNode);
    // int __thiscall CMasterInputMap::AddDeviceEntry(CMasterInputMap*,const DeviceKeyMapEntry*)
    public int AddDeviceEntry(ACBindings.DeviceKeyMapEntry* device) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CMasterInputMap, ACBindings.DeviceKeyMapEntry*, int>)0x0068E0A0)(ref this, device);
    // bool __thiscall CMasterInputMap::ReadDevicesFromFileNode(CMasterInputMap*,const PFileNode*)
    public byte ReadDevicesFromFileNode(ACBindings.PFileNode* i_pNode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CMasterInputMap, ACBindings.PFileNode*, byte>)0x0068E600)(ref this, i_pNode);
    // bool __thiscall CMasterInputMap::IsMetaKey(CMasterInputMap*,ControlSpecification)
    public byte IsMetaKey(ACBindings.ControlSpecification key) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CMasterInputMap, ACBindings.ControlSpecification, byte>)0x0068E760)(ref this, key);
    // unsigned int __thiscall CMasterInputMap::MetaModeFromKey(CMasterInputMap*,ControlSpecification)
    public uint MetaModeFromKey(ACBindings.ControlSpecification key) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CMasterInputMap, ACBindings.ControlSpecification, uint>)0x0068E7A0)(ref this, key);
    // ControlSpecification* __thiscall CMasterInputMap::KeyFromMetaMode(CMasterInputMap*,ControlSpecification*,unsigned int)
    public ACBindings.ControlSpecification* KeyFromMetaMode(ACBindings.ControlSpecification* result, uint data) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CMasterInputMap, ACBindings.ControlSpecification*, uint, ACBindings.ControlSpecification*>)0x0068E7E0)(ref this, result, data);
    // bool __thiscall CMasterInputMap::ToFileNode(CMasterInputMap*,PFileNode*)
    public byte ToFileNode(ACBindings.PFileNode* pRootNode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CMasterInputMap, ACBindings.PFileNode*, byte>)0x0068E850)(ref this, pRootNode);
    // void __thiscall CMasterInputMap::CMasterInputMap(CMasterInputMap*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CMasterInputMap, void>)0x0068F710)(ref this);
    // unsigned int __thiscall CMasterInputMap::GetDBOType(CMasterInputMap*)
    public uint GetDBOType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CMasterInputMap, uint>)0x0068F770)(ref this);
    // void __thiscall CMasterInputMap::Clear(CMasterInputMap*)
    public void Clear() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CMasterInputMap, void>)0x0068FA90)(ref this);
    // void __thiscall CMasterInputMap::~CMasterInputMap(CMasterInputMap*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CMasterInputMap, void>)0x00690070)(ref this);
    // bool __thiscall CMasterInputMap::ReadMetaKeysFromFileNode(CMasterInputMap*,const PFileNode*)
    public byte ReadMetaKeysFromFileNode(ACBindings.PFileNode* i_pNode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CMasterInputMap, ACBindings.PFileNode*, byte>)0x00690130)(ref this, i_pNode);
    // CInputMap* __thiscall CMasterInputMap::CreateInputMap(CMasterInputMap*,unsigned int)
    public ACBindings.CInputMap* CreateInputMap(uint id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CMasterInputMap, uint, ACBindings.CInputMap*>)0x00690260)(ref this, id);
    // bool __thiscall CMasterInputMap::Merge(CMasterInputMap*,const CMasterInputMap*,bool)
    public byte Merge(ACBindings.CMasterInputMap* rhs, byte fForce) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CMasterInputMap, ACBindings.CMasterInputMap*, byte, byte>)0x00690640)(ref this, rhs, fForce);
    // bool __thiscall CMasterInputMap::ReadBindingsFromFileNode(CMasterInputMap*,const PFileNode*)
    public byte ReadBindingsFromFileNode(ACBindings.PFileNode* i_pNode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CMasterInputMap, ACBindings.PFileNode*, byte>)0x006909E0)(ref this, i_pNode);
    // bool __thiscall CMasterInputMap::CopyInto(CMasterInputMap*,DBObj*)
    public byte CopyInto(ACBindings.DBObj* retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CMasterInputMap, ACBindings.DBObj*, byte>)0x00690BC0)(ref this, retval);
    // void __thiscall CMasterInputMap::Serialize(CMasterInputMap*,Archive*)
    public void Serialize(ACBindings.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CMasterInputMap, ACBindings.Archive*, void>)0x00690C30)(ref this, io_archive);
    // bool __thiscall CMasterInputMap::FromFileNode(CMasterInputMap*,const PFileNode*)
    public byte FromFileNode(ACBindings.PFileNode* pRootNode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CMasterInputMap, ACBindings.PFileNode*, byte>)0x00690F30)(ref this, pRootNode);
}

