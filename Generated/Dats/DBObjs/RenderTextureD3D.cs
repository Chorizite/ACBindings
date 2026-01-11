namespace ACBindings.Internal;

public unsafe struct RenderTextureD3D : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.RenderTexture BaseClass_RenderTexture; // ACBindings.Internal.RenderTexture

    // Child Types
    public unsafe struct RenderTextureD3D_vtbl
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
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderTexture*, uint, uint, uint, ACBindings.Internal.PixelFormatID, uint, byte> Create2D; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderTexture*, uint, uint, ACBindings.Internal.PixelFormatID, uint, byte> CreateCube; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderTexture*, ACBindings.Internal.RenderTexture*, byte> LoadTexture; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderTexture*, uint, uint, ACBindings.Internal.GraphicsResource*> GetLevelRef; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr m_p2DTextureD3D;
    public System.IntPtr m_pCubeTextureD3D;
    public ACBindings.Internal.SmartArray___D3DLevelResourceType m_D3DSurfaces;

    // Generated Constructor
    public RenderTextureD3D() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x00696060
    /// bool __thiscall RenderTextureD3D::GetSubObjects(RenderTextureD3D*)</code>
    /// </summary>
    public byte GetSubObjects() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderTextureD3D, byte>)0x00696060)(ref this);

    /// <summary>
    /// <code>Offset: 0x006961D0
    /// void __thiscall RenderTextureD3D::ReleaseD3DSurfaces(RenderTextureD3D*)</code>
    /// </summary>
    public void ReleaseD3DSurfaces() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderTextureD3D, void>)0x006961D0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00696240
    /// void __thiscall RenderTextureD3D::ReleaseD3DTexture(RenderTextureD3D*)</code>
    /// </summary>
    public void ReleaseD3DTexture() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderTextureD3D, void>)0x00696240)(ref this);

    /// <summary>
    /// <code>Offset: 0x006962D0
    /// bool __thiscall RenderTextureD3D::PurgeResource(RenderTextureD3D*)</code>
    /// </summary>
    public byte PurgeResource() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderTextureD3D, byte>)0x006962D0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00696380
    /// bool __thiscall RenderTextureD3D::CopyInto(RenderTextureD3D*,DBObj*)</code>
    /// </summary>
    public byte CopyInto(ACBindings.Internal.DBObj* retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderTextureD3D, ACBindings.Internal.DBObj*, byte>)0x00696380)(ref this, retval);

    /// <summary>
    /// <code>Offset: 0x00696440
    /// bool __thiscall RenderTextureD3D::ReleaseSubObjects(RenderTextureD3D*)</code>
    /// </summary>
    public byte ReleaseSubObjects() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderTextureD3D, byte>)0x00696440)(ref this);

    /// <summary>
    /// <code>Offset: 0x00696470
    /// bool __thiscall RenderTextureD3D::CreateD3DTexture(RenderTextureD3D*)</code>
    /// </summary>
    public byte CreateD3DTexture() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderTextureD3D, byte>)0x00696470)(ref this);

    /// <summary>
    /// <code>Offset: 0x00696840
    /// bool __thiscall RenderTextureD3D::RestoreResource(RenderTextureD3D*)</code>
    /// </summary>
    public byte RestoreResource() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderTextureD3D, byte>)0x00696840)(ref this);

    /// <summary>
    /// <code>Offset: 0x00696880
    /// void __thiscall RenderTextureD3D::Destroy(RenderTextureD3D*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderTextureD3D, void>)0x00696880)(ref this);

    /// <summary>
    /// <code>Offset: 0x006968D0
    /// IDirect3DTexture9* __thiscall RenderTextureD3D::Get2DTextureD3D(RenderTextureD3D*)</code>
    /// </summary>
    public System.IntPtr Get2DTextureD3D() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderTextureD3D, System.IntPtr>)0x006968D0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00696930
    /// IDirect3DCubeTexture9* __thiscall RenderTextureD3D::GetCubeTextureD3D(RenderTextureD3D*)</code>
    /// </summary>
    public System.IntPtr GetCubeTextureD3D() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderTextureD3D, System.IntPtr>)0x00696930)(ref this);

    /// <summary>
    /// <code>Offset: 0x00696990
    /// void __thiscall RenderTextureD3D::RenderTextureD3D(RenderTextureD3D*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderTextureD3D, void>)0x00696990)(ref this);

    /// <summary>
    /// <code>Offset: 0x006969E0
    /// void __thiscall RenderTextureD3D::~RenderTextureD3D(RenderTextureD3D*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderTextureD3D, void>)0x006969E0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00696A60
    /// GraphicsResource* __thiscall RenderTextureD3D::GetLevelRef(RenderTextureD3D*,const unsigned int,const unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.GraphicsResource* GetLevelRef(uint nLevel, uint Resource) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderTextureD3D, uint, uint, ACBindings.Internal.GraphicsResource*>)0x00696A60)(ref this, nLevel, Resource);

    /// <summary>
    /// <code>Offset: 0x00696B00
    /// bool __thiscall RenderTextureD3D::LoadTexture(RenderTextureD3D*,const RenderTexture*)</code>
    /// </summary>
    public byte LoadTexture(ACBindings.Internal.RenderTexture* Source) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderTextureD3D, ACBindings.Internal.RenderTexture*, byte>)0x00696B00)(ref this, Source);
}

