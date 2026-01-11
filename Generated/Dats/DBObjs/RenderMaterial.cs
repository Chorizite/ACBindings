namespace ACBindings.Internal;

public unsafe struct RenderMaterial : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.DBObj BaseClass_DBObj; // ACBindings.Internal.DBObj

    // Child Types
    public unsafe struct RenderMaterial_vtbl
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
    public byte m_IsInstance;
    public ACBindings.Internal.MaterialModifier properties;
    public ACBindings.Internal.SmartArray___MaterialLayer_ptr layers;
    public ACBindings.Internal.SmartArray___PStringBase__sbyte m_MaterialShaderConstantNames;
    public ACBindings.Internal.SmartArray___MaterialShaderConstant m_MaterialShaderConstants;
    public byte m_IsOptimized;
    public byte m_SupportsLighting;
    public byte m_SupportsMultiPassLighting;
    public byte m_SupportsCombinedAmbientPass;
    public byte m_SupportsGlowing;
    public byte m_NeedsAlphaBlendPass;
    public byte m_UsesVideoPost;
    public float m_Opacity;
    public fixed byte m_LayerIndices[45];

    // Generated Constructor
    public RenderMaterial() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x0043FFC0
    /// void __thiscall RenderMaterial::InsertLayer(RenderMaterial*,const unsigned int,MaterialLayer*)</code>
    /// </summary>
    public void InsertLayer(uint index, ACBindings.Internal.MaterialLayer* pLayer) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderMaterial, uint, ACBindings.Internal.MaterialLayer*, void>)0x0043FFC0)(ref this, index, pLayer);

    /// <summary>
    /// <code>Offset: 0x00449420
    /// char __thiscall RenderMaterial::CheckOutputField(_DWORD*,int*,int,int,int,int)</code>
    /// </summary>
    public sbyte CheckOutputField(int* a2, int a3, int a4, int a5, int a6) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderMaterial, int*, int, int, int, int, sbyte>)0x00449420)(ref this, a2, a3, a4, a5, a6);

    /// <summary>
    /// <code>Offset: 0x004494E0
    /// void __thiscall RenderMaterial::Optimize(RenderMaterial*)</code>
    /// </summary>
    public void Optimize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderMaterial, void>)0x004494E0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00449710
    /// void __thiscall RenderMaterial::GetSubDataIDs(RenderMaterial*,QualifiedDataIDArray*)</code>
    /// </summary>
    public void GetSubDataIDs(ACBindings.Internal.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderMaterial, ACBindings.Internal.QualifiedDataIDArray*, void>)0x00449710)(ref this, id_array);

    /// <summary>
    /// <code>Offset: 0x004497E0
    /// void __thiscall RenderMaterial::RenderMaterial(RenderMaterial*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderMaterial, void>)0x004497E0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00449880
    /// unsigned int __thiscall RenderMaterial::GetDBOType(RenderMaterial*)</code>
    /// </summary>
    public uint GetDBOType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderMaterial, uint>)0x00449880)(ref this);

    /// <summary>
    /// <code>Offset: 0x00449890
    /// bool __thiscall RenderMaterial::ReleaseSubObjects(RenderMaterial*)</code>
    /// </summary>
    public byte ReleaseSubObjects() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderMaterial, byte>)0x00449890)(ref this);

    /// <summary>
    /// <code>Offset: 0x00449950
    /// DBObj* __cdecl RenderMaterial::Allocator()</code>
    /// </summary>
    public static ACBindings.Internal.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.DBObj*>)0x00449950)();

    /// <summary>
    /// <code>Offset: 0x00449970
    /// void __thiscall RenderMaterial::End(RenderMaterial*)</code>
    /// </summary>
    public void End() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderMaterial, void>)0x00449970)(ref this);

    /// <summary>
    /// <code>Offset: 0x00449A60
    /// bool __thiscall RenderMaterial::CopyInto(RenderMaterial*,DBObj*)</code>
    /// </summary>
    public byte CopyInto(ACBindings.Internal.DBObj* retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderMaterial, ACBindings.Internal.DBObj*, byte>)0x00449A60)(ref this, retval);

    /// <summary>
    /// <code>Offset: 0x00449CF0
    /// void __thiscall RenderMaterial::Destroy(RenderMaterial*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderMaterial, void>)0x00449CF0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00449D50
    /// void __thiscall RenderMaterial::Serialize(RenderMaterial*,Archive*)</code>
    /// </summary>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderMaterial, ACBindings.Internal.Archive*, void>)0x00449D50)(ref this, io_archive);

    /// <summary>
    /// <code>Offset: 0x00449E50
    /// void __thiscall RenderMaterial::~RenderMaterial(RenderMaterial*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderMaterial, void>)0x00449E50)(ref this);

    /// <summary>
    /// <code>Offset: 0x00449ED0
    /// bool __thiscall RenderMaterial::GetSubObjects(RenderMaterial*)</code>
    /// </summary>
    public byte GetSubObjects() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderMaterial, byte>)0x00449ED0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0044A200
    /// char __thiscall RenderMaterial::CheckParseField(_DWORD*,volatile LONG*,int,_DWORD*,int,int)</code>
    /// </summary>
    public sbyte CheckParseField(int* String1, int a3, int* a4, int a5, int a6) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderMaterial, int*, int, int*, int, int, sbyte>)0x0044A200)(ref this, String1, a3, a4, a5, a6);
}

