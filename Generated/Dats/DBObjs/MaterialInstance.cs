namespace ACBindings;

// MaterialInstance
public unsafe struct MaterialInstance : System.IDisposable
{
    // Base Classes
    public ACBindings.DBObj BaseClass_DBObj; // ACBindings.DBObj

    // Child Types
    // MaterialInstance_vtbl
    public unsafe struct MaterialInstance_vtbl
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
    public ACBindings.PStringBase__sbyte m_materialName;
    public ACBindings.IDClass___tagDataID m_materialID;
    public ACBindings.PStringBase__sbyte m_materialTypeName;
    public uint m_materialType;
    public ACBindings.SmartArray__ModifierRef_ptr m_aModifierRefs;
    public byte m_AllowStencilShadows;
    public byte m_WantDiscardGeometry;
    public ACBindings.RenderMaterial* m_pMaterial;
    public ACBindings.SmartArray__MaterialModifier_ptr m_aModifiers;
    public ACBindings.RenderMaterial* m_pModifiedMaterial;
    public byte m_bNeedRefresh;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // char __thiscall MaterialInstance::Refresh(_BYTE*,int)
    public sbyte Refresh(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MaterialInstance, int, sbyte>)0x0044D170)(ref this, a2);
    // void __thiscall MaterialInstance::Begin(MaterialInstance*)
    public void Begin() => ((delegate* unmanaged[Thiscall]<ref ACBindings.MaterialInstance, void>)0x0044D180)(ref this);
    // void __thiscall MaterialInstance::GetSubDataIDs(MaterialInstance*,QualifiedDataIDArray*)
    public void GetSubDataIDs(ACBindings.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MaterialInstance, ACBindings.QualifiedDataIDArray*, void>)0x0044D250)(ref this, id_array);
    // bool __thiscall MaterialInstance::ReleaseSubObjects(MaterialInstance*)
    public byte ReleaseSubObjects() => ((delegate* unmanaged[Thiscall]<ref ACBindings.MaterialInstance, byte>)0x0044D2D0)(ref this);
    // unsigned int __thiscall MaterialInstance::GetDBOType(MaterialInstance*)
    public uint GetDBOType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.MaterialInstance, uint>)0x0044D3D0)(ref this);
    // void __thiscall MaterialInstance::End(MaterialInstance*)
    public void End() => ((delegate* unmanaged[Thiscall]<ref ACBindings.MaterialInstance, void>)0x0044D410)(ref this);
    // bool __thiscall MaterialInstance::CopyInto(MaterialInstance*,DBObj*)
    public byte CopyInto(ACBindings.DBObj* retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MaterialInstance, ACBindings.DBObj*, byte>)0x0044D4C0)(ref this, retval);
    // void __thiscall MaterialInstance::Destroy(MaterialInstance*)
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.MaterialInstance, void>)0x0044D790)(ref this);
    // bool __thiscall MaterialInstance::GetSubObjects(MaterialInstance*)
    public byte GetSubObjects() => ((delegate* unmanaged[Thiscall]<ref ACBindings.MaterialInstance, byte>)0x0044D7A0)(ref this);
    // void __thiscall MaterialInstance::Serialize(MaterialInstance*,Archive*)
    public void Serialize(ACBindings.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MaterialInstance, ACBindings.Archive*, void>)0x0044D840)(ref this, io_archive);
    // void __thiscall MaterialInstance::~MaterialInstance(MaterialInstance*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.MaterialInstance, void>)0x0044DA30)(ref this);
}

