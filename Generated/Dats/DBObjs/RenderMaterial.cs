namespace ACBindings;

// RenderMaterial
public unsafe struct RenderMaterial : System.IDisposable
{
    // Base Classes
    public ACBindings.DBObj BaseClass_DBObj; // ACBindings.DBObj

    // Child Types
    // RenderMaterial_vtbl
    public unsafe struct RenderMaterial_vtbl
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
    public byte m_IsInstance;
    public ACBindings.MaterialModifier properties;
    public ACBindings.SmartArray__MaterialLayer_ptr layers;
    public ACBindings.SmartArray__PStringBase__sbyte m_MaterialShaderConstantNames;
    public ACBindings.SmartArray__MaterialShaderConstant m_MaterialShaderConstants;
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
    // void __thiscall RenderMaterial::InsertLayer(RenderMaterial*,const unsigned int,MaterialLayer*)
    public void InsertLayer(uint index, ACBindings.MaterialLayer* pLayer) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderMaterial, uint, ACBindings.MaterialLayer*, void>)0x0043FFC0)(ref this, index, pLayer);
    // char __thiscall RenderMaterial::CheckOutputField(_DWORD*,int*,int,int,int,int)
    public sbyte CheckOutputField(int* a2, int a3, int a4, int a5, int a6) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderMaterial, int*, int, int, int, int, sbyte>)0x00449420)(ref this, a2, a3, a4, a5, a6);
    // void __thiscall RenderMaterial::Optimize(RenderMaterial*)
    public void Optimize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderMaterial, void>)0x004494E0)(ref this);
    // void __thiscall RenderMaterial::GetSubDataIDs(RenderMaterial*,QualifiedDataIDArray*)
    public void GetSubDataIDs(ACBindings.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderMaterial, ACBindings.QualifiedDataIDArray*, void>)0x00449710)(ref this, id_array);
    // void __thiscall RenderMaterial::RenderMaterial(RenderMaterial*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderMaterial, void>)0x004497E0)(ref this);
    // unsigned int __thiscall RenderMaterial::GetDBOType(RenderMaterial*)
    public uint GetDBOType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderMaterial, uint>)0x00449880)(ref this);
    // bool __thiscall RenderMaterial::ReleaseSubObjects(RenderMaterial*)
    public byte ReleaseSubObjects() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderMaterial, byte>)0x00449890)(ref this);
    // DBObj* __cdecl RenderMaterial::Allocator()
    public static ACBindings.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.DBObj*>)0x00449950)();
    // void __thiscall RenderMaterial::End(RenderMaterial*)
    public void End() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderMaterial, void>)0x00449970)(ref this);
    // bool __thiscall RenderMaterial::CopyInto(RenderMaterial*,DBObj*)
    public byte CopyInto(ACBindings.DBObj* retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderMaterial, ACBindings.DBObj*, byte>)0x00449A60)(ref this, retval);
    // void __thiscall RenderMaterial::Destroy(RenderMaterial*)
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderMaterial, void>)0x00449CF0)(ref this);
    // void __thiscall RenderMaterial::Serialize(RenderMaterial*,Archive*)
    public void Serialize(ACBindings.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderMaterial, ACBindings.Archive*, void>)0x00449D50)(ref this, io_archive);
    // void __thiscall RenderMaterial::~RenderMaterial(RenderMaterial*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderMaterial, void>)0x00449E50)(ref this);
    // bool __thiscall RenderMaterial::GetSubObjects(RenderMaterial*)
    public byte GetSubObjects() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderMaterial, byte>)0x00449ED0)(ref this);
    // char __thiscall RenderMaterial::CheckParseField(_DWORD*,volatile LONG*,int,_DWORD*,int,int)
    public sbyte CheckParseField(int* String1, int a3, int* a4, int a5, int a6) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderMaterial, int*, int, int*, int, int, sbyte>)0x0044A200)(ref this, String1, a3, a4, a5, a6);
}

