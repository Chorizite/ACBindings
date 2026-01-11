namespace ACBindings.Internal;

public unsafe struct RenderSurfaceD3D : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.RenderSurface BaseClass_RenderSurface; // ACBindings.Internal.RenderSurface

    // Child Types
    public unsafe struct RenderSurfaceD3D_vtbl
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
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderSurface*, uint, uint, ACBindings.Internal.PixelFormatID, byte, byte> Create; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderSurface*, byte> CreateFromSourceData; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderSurface*, ACBindings.Internal.tagRECT*, uint, int*, void**, byte> Lock; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderSurface*, void> Unlock; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderSurface*, ACBindings.Internal.RenderSurface*, byte> Convert; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderSurface*, ACBindings.Internal.RenderSurface*, byte> ConvertToNormalMap; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderSurfaceD3D*, System.IntPtr, byte, byte, byte> CreateFromD3DSurface; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr m_pD3DSurface;
    public ACBindings.Internal._D3DPOOL m_pool;
    public byte m_CountAsSystemMemory;
    public byte m_CountAsVideoMemory;

    // Generated Constructor
    public RenderSurfaceD3D() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x00696BB0
    /// bool __thiscall RenderSurfaceD3D::CreateFromD3DSurface(RenderSurfaceD3D*,IDirect3DSurface9*,const bool,const bool)</code>
    /// </summary>
    public byte CreateFromD3DSurface(System.IntPtr pExistingSurface, byte CountAsSystemMemory, byte CountAsVideoMemory) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderSurfaceD3D, System.IntPtr, byte, byte, byte>)0x00696BB0)(ref this, pExistingSurface, CountAsSystemMemory, CountAsVideoMemory);

    /// <summary>
    /// <code>Offset: 0x00696C50
    /// IDirect3DSurface9* __thiscall RenderSurfaceD3D::GetDirect3DSurface(RenderSurfaceD3D*)</code>
    /// </summary>
    public System.IntPtr GetDirect3DSurface() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderSurfaceD3D, System.IntPtr>)0x00696C50)(ref this);

    /// <summary>
    /// <code>Offset: 0x00696CA0
    /// bool __thiscall RenderSurfaceD3D::Convert(RenderSurfaceD3D*,const RenderSurface*)</code>
    /// </summary>
    public byte Convert(ACBindings.Internal.RenderSurface* source) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderSurfaceD3D, ACBindings.Internal.RenderSurface*, byte>)0x00696CA0)(ref this, source);

    /// <summary>
    /// <code>Offset: 0x00696D00
    /// bool __thiscall RenderSurfaceD3D::CreateD3DSurface(RenderSurfaceD3D*)</code>
    /// </summary>
    public byte CreateD3DSurface() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderSurfaceD3D, byte>)0x00696D00)(ref this);

    /// <summary>
    /// <code>Offset: 0x00696D90
    /// bool __thiscall RenderSurfaceD3D::PurgeResource(RenderSurfaceD3D*)</code>
    /// </summary>
    public byte PurgeResource() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderSurfaceD3D, byte>)0x00696D90)(ref this);

    /// <summary>
    /// <code>Offset: 0x00696DE0
    /// void __thiscall RenderSurfaceD3D::RenderSurfaceD3D(RenderSurfaceD3D*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderSurfaceD3D, void>)0x00696DE0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00696E30
    /// bool __thiscall RenderSurfaceD3D::Create(RenderSurfaceD3D*,unsigned int,unsigned int,PixelFormatID,bool)</code>
    /// </summary>
    public byte Create(uint width, uint height, ACBindings.Internal.PixelFormatID pixelFormat, byte bLocalData) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderSurfaceD3D, uint, uint, ACBindings.Internal.PixelFormatID, byte, byte>)0x00696E30)(ref this, width, height, pixelFormat, bLocalData);

    /// <summary>
    /// <code>Offset: 0x00696EB0
    /// void __thiscall RenderSurfaceD3D::Destroy(RenderSurfaceD3D*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderSurfaceD3D, void>)0x00696EB0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00696F10
    /// bool __thiscall RenderSurfaceD3D::Lock(RenderSurfaceD3D*,const tagRECT*,const unsigned int,int*,void**)</code>
    /// </summary>
    public byte Lock(ACBindings.Internal.tagRECT* rect, uint flags, int* pitch, void** data) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderSurfaceD3D, ACBindings.Internal.tagRECT*, uint, int*, void**, byte>)0x00696F10)(ref this, rect, flags, pitch, data);

    /// <summary>
    /// <code>Offset: 0x00696FB0
    /// void __thiscall RenderSurfaceD3D::Unlock(RenderSurfaceD3D*)</code>
    /// </summary>
    public void Unlock() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderSurfaceD3D, void>)0x00696FB0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00696FE0
    /// bool __thiscall RenderSurfaceD3D::RestoreResource(RenderSurfaceD3D*)</code>
    /// </summary>
    public byte RestoreResource() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderSurfaceD3D, byte>)0x00696FE0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00697030
    /// void __thiscall RenderSurfaceD3D::~RenderSurfaceD3D(RenderSurfaceD3D*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderSurfaceD3D, void>)0x00697030)(ref this);
}

