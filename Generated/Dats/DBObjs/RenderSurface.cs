namespace ACBindings.Internal;

public unsafe struct RenderSurface : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.DBObj BaseClass_DBObj; // ACBindings.Internal.DBObj
    public ACBindings.Internal.GraphicsResource BaseClass_GraphicsResource; // ACBindings.Internal.GraphicsResource

    // Child Types
    public unsafe struct RenderSurface_vtbl
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

        // Methods
    }

    // Members
    public ACBindings.Internal.RenderSurfaceSourceData sourceData;
    public uint width;
    public uint height;
    public uint size;
    public ACBindings.Internal.SurfaceWindow window;
    public byte locked;
    public ACBindings.Internal.PixelFormatDesc pfDesc;
    public System.IntPtr m_pSurfaceBits;
    public ACBindings.Internal.IDClass____tagDataID m_didPalatte;
    public byte m_IsDirty;
    public byte m_ReadOnlyLock;

    // Generated Constructor
    public RenderSurface() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x00443AC0
    /// bool __cdecl RenderSurface::IsD3DFormat(PixelFormatID)</code>
    /// </summary>
    public static byte IsD3DFormat(ACBindings.Internal.PixelFormatID pf) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.PixelFormatID, byte>)0x00443AC0)(pf);

    /// <summary>
    /// <code>Offset: 0x00443BC0
    /// void __thiscall RenderSurface::Begin(RenderSurface*)</code>
    /// </summary>
    public void Begin() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderSurface, void>)0x00443BC0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00443C20
    /// bool __thiscall RenderSurface::InitLoad(RenderSurface*)</code>
    /// </summary>
    public byte InitLoad() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderSurface, byte>)0x00443C20)(ref this);

    /// <summary>
    /// <code>Offset: 0x00443C40
    /// bool __thiscall RenderSurface::Lock(RenderSurface*,const tagRECT*,const unsigned int,int*,void**)</code>
    /// </summary>
    public byte Lock(ACBindings.Internal.tagRECT* rect, uint flags, int* pitch, void** data) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderSurface, ACBindings.Internal.tagRECT*, uint, int*, void**, byte>)0x00443C40)(ref this, rect, flags, pitch, data);

    /// <summary>
    /// <code>Offset: 0x00443CC0
    /// void __thiscall RenderSurface::Unlock(RenderSurface*)</code>
    /// </summary>
    public void Unlock() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderSurface, void>)0x00443CC0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00443CF0
    /// PixelFormatID __thiscall RenderSurface::SelectSurfaceFormat(RenderSurface*,const PixelFormatID)</code>
    /// </summary>
    public ACBindings.Internal.PixelFormatID SelectSurfaceFormat(ACBindings.Internal.PixelFormatID format) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderSurface, ACBindings.Internal.PixelFormatID, ACBindings.Internal.PixelFormatID>)0x00443CF0)(ref this, format);

    /// <summary>
    /// <code>Offset: 0x00443DC0
    /// char __thiscall RenderSurface::SaveJPG(_DWORD*,const char**)</code>
    /// </summary>
    public sbyte SaveJPG(sbyte** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderSurface, sbyte**, sbyte>)0x00443DC0)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x00443F60
    /// bool __thiscall RenderSurface::Convert(RenderSurface*,const RenderSurface*)</code>
    /// </summary>
    public byte Convert(ACBindings.Internal.RenderSurface* source) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderSurface, ACBindings.Internal.RenderSurface*, byte>)0x00443F60)(ref this, source);

    /// <summary>
    /// <code>Offset: 0x004440D0
    /// void __thiscall RenderSurface::DestroySourceSurfaceBits(RenderSurface*)</code>
    /// </summary>
    public void DestroySourceSurfaceBits() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderSurface, void>)0x004440D0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004440F0
    /// void __thiscall RenderSurface::RenderSurface(RenderSurface*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderSurface, void>)0x004440F0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00444150
    /// bool __thiscall RenderSurface::Create(RenderSurface*,unsigned int,unsigned int,PixelFormatID,bool)</code>
    /// </summary>
    public byte Create(uint width, uint height, ACBindings.Internal.PixelFormatID pixelFormat, byte bLocalData) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderSurface, uint, uint, ACBindings.Internal.PixelFormatID, byte, byte>)0x00444150)(ref this, width, height, pixelFormat, bLocalData);

    /// <summary>
    /// <code>Offset: 0x00444200
    /// bool __thiscall RenderSurface::CreateFromSourceData(RenderSurface*)</code>
    /// </summary>
    public byte CreateFromSourceData() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderSurface, byte>)0x00444200)(ref this);

    /// <summary>
    /// <code>Offset: 0x00444500
    /// DBObj* __thiscall RenderSurface::Allocator(RenderSurface*)</code>
    /// </summary>
    public ACBindings.Internal.DBObj* Allocator() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderSurface, ACBindings.Internal.DBObj*>)0x00444500)(ref this);

    /// <summary>
    /// <code>Offset: 0x00444540
    /// void __thiscall RenderSurface::Destroy(RenderSurface*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderSurface, void>)0x00444540)(ref this);

    /// <summary>
    /// <code>Offset: 0x00444580
    /// void __thiscall RenderSurface::~RenderSurface(RenderSurface*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderSurface, void>)0x00444580)(ref this);

    /// <summary>
    /// <code>Offset: 0x004445F0
    /// void __thiscall RenderSurface::GetSubDataIDs(RenderSurface*,QualifiedDataIDArray*)</code>
    /// </summary>
    public void GetSubDataIDs(ACBindings.Internal.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderSurface, ACBindings.Internal.QualifiedDataIDArray*, void>)0x004445F0)(ref this, id_array);

    /// <summary>
    /// <code>Offset: 0x00444640
    /// void __thiscall RenderSurface::Serialize(RenderSurface*,Archive*)</code>
    /// </summary>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderSurface, ACBindings.Internal.Archive*, void>)0x00444640)(ref this, io_archive);
}

