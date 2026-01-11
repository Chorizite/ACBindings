namespace ACBindings.Internal;

public unsafe struct MaterialInstance : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.DBObj BaseClass_DBObj; // ACBindings.Internal.DBObj

    // Child Types
    public unsafe struct MaterialInstance_vtbl
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
    public ACBindings.Internal.PStringBase__sbyte m_materialName;
    public ACBindings.Internal.IDClass____tagDataID m_materialID;
    public ACBindings.Internal.PStringBase__sbyte m_materialTypeName;
    public uint m_materialType;
    public ACBindings.Internal.SmartArray___ModifierRef_ptr m_aModifierRefs;
    public byte m_AllowStencilShadows;
    public byte m_WantDiscardGeometry;
    public ACBindings.Internal.RenderMaterial* m_pMaterial;
    public ACBindings.Internal.SmartArray___MaterialModifier_ptr m_aModifiers;
    public ACBindings.Internal.RenderMaterial* m_pModifiedMaterial;
    public byte m_bNeedRefresh;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x0044D170
    /// char __thiscall MaterialInstance::Refresh(_BYTE*,int)</code>
    /// </summary>
    public sbyte Refresh(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MaterialInstance, int, sbyte>)0x0044D170)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x0044D180
    /// void __thiscall MaterialInstance::Begin(MaterialInstance*)</code>
    /// </summary>
    public void Begin() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MaterialInstance, void>)0x0044D180)(ref this);

    /// <summary>
    /// <code>Offset: 0x0044D250
    /// void __thiscall MaterialInstance::GetSubDataIDs(MaterialInstance*,QualifiedDataIDArray*)</code>
    /// </summary>
    public void GetSubDataIDs(ACBindings.Internal.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MaterialInstance, ACBindings.Internal.QualifiedDataIDArray*, void>)0x0044D250)(ref this, id_array);

    /// <summary>
    /// <code>Offset: 0x0044D2D0
    /// bool __thiscall MaterialInstance::ReleaseSubObjects(MaterialInstance*)</code>
    /// </summary>
    public byte ReleaseSubObjects() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MaterialInstance, byte>)0x0044D2D0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0044D3D0
    /// unsigned int __thiscall MaterialInstance::GetDBOType(MaterialInstance*)</code>
    /// </summary>
    public uint GetDBOType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MaterialInstance, uint>)0x0044D3D0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0044D410
    /// void __thiscall MaterialInstance::End(MaterialInstance*)</code>
    /// </summary>
    public void End() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MaterialInstance, void>)0x0044D410)(ref this);

    /// <summary>
    /// <code>Offset: 0x0044D4C0
    /// bool __thiscall MaterialInstance::CopyInto(MaterialInstance*,DBObj*)</code>
    /// </summary>
    public byte CopyInto(ACBindings.Internal.DBObj* retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MaterialInstance, ACBindings.Internal.DBObj*, byte>)0x0044D4C0)(ref this, retval);

    /// <summary>
    /// <code>Offset: 0x0044D790
    /// void __thiscall MaterialInstance::Destroy(MaterialInstance*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MaterialInstance, void>)0x0044D790)(ref this);

    /// <summary>
    /// <code>Offset: 0x0044D7A0
    /// bool __thiscall MaterialInstance::GetSubObjects(MaterialInstance*)</code>
    /// </summary>
    public byte GetSubObjects() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MaterialInstance, byte>)0x0044D7A0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0044D840
    /// void __thiscall MaterialInstance::Serialize(MaterialInstance*,Archive*)</code>
    /// </summary>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MaterialInstance, ACBindings.Internal.Archive*, void>)0x0044D840)(ref this, io_archive);

    /// <summary>
    /// <code>Offset: 0x0044DA30
    /// void __thiscall MaterialInstance::~MaterialInstance(MaterialInstance*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MaterialInstance, void>)0x0044DA30)(ref this);
}

