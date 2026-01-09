namespace ACBindings;

// RenderSurface
public unsafe struct RenderSurface : System.IDisposable
{
    // Base Classes
    public ACBindings.DBObj BaseClass_DBObj; // ACBindings.DBObj
    public ACBindings.GraphicsResource BaseClass_GraphicsResource; // ACBindings.GraphicsResource

    // Child Types
    // RenderSurface_vtbl
    public unsafe struct RenderSurface_vtbl
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
        public System.IntPtr Create; // function pointer
        public System.IntPtr CreateFromSourceData; // function pointer
        public System.IntPtr Lock; // function pointer
        public System.IntPtr Unlock; // function pointer
        public System.IntPtr Convert; // function pointer
        public System.IntPtr ConvertToNormalMap; // function pointer

        // Methods
    }

    // Members
    public ACBindings.RenderSurfaceSourceData sourceData;
    public uint width;
    public uint height;
    public uint size;
    public ACBindings.SurfaceWindow window;
    public byte locked;
    public ACBindings.PixelFormatDesc pfDesc;
    public System.IntPtr m_pSurfaceBits;
    public ACBindings.IDClass___tagDataID m_didPalatte;
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
    // bool __cdecl RenderSurface::IsD3DFormat(PixelFormatID)
    public static byte IsD3DFormat(ACBindings.PixelFormatID pf) => ((delegate* unmanaged[Cdecl]<ACBindings.PixelFormatID, byte>)0x00443AC0)(pf);
    // void __thiscall RenderSurface::Begin(RenderSurface*)
    public void Begin() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderSurface, void>)0x00443BC0)(ref this);
    // bool __thiscall RenderSurface::InitLoad(RenderSurface*)
    public byte InitLoad() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderSurface, byte>)0x00443C20)(ref this);
    // bool __thiscall RenderSurface::Lock(RenderSurface*,const tagRECT*,const unsigned int,int*,void**)
    public byte Lock(ACBindings.tagRECT* rect, uint flags, int* pitch, void** data) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderSurface, ACBindings.tagRECT*, uint, int*, void**, byte>)0x00443C40)(ref this, rect, flags, pitch, data);
    // void __thiscall RenderSurface::Unlock(RenderSurface*)
    public void Unlock() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderSurface, void>)0x00443CC0)(ref this);
    // PixelFormatID __thiscall RenderSurface::SelectSurfaceFormat(RenderSurface*,const PixelFormatID)
    public ACBindings.PixelFormatID SelectSurfaceFormat(ACBindings.PixelFormatID format) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderSurface, ACBindings.PixelFormatID, ACBindings.PixelFormatID>)0x00443CF0)(ref this, format);
    // char __thiscall RenderSurface::SaveJPG(_DWORD*,const char**)
    public sbyte SaveJPG(sbyte** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderSurface, sbyte**, sbyte>)0x00443DC0)(ref this, a2);
    // bool __thiscall RenderSurface::Convert(RenderSurface*,const RenderSurface*)
    public byte Convert(ACBindings.RenderSurface* source) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderSurface, ACBindings.RenderSurface*, byte>)0x00443F60)(ref this, source);
    // void __thiscall RenderSurface::DestroySourceSurfaceBits(RenderSurface*)
    public void DestroySourceSurfaceBits() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderSurface, void>)0x004440D0)(ref this);
    // void __thiscall RenderSurface::RenderSurface(RenderSurface*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderSurface, void>)0x004440F0)(ref this);
    // bool __thiscall RenderSurface::Create(RenderSurface*,unsigned int,unsigned int,PixelFormatID,bool)
    public byte Create(uint width, uint height, ACBindings.PixelFormatID pixelFormat, byte bLocalData) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderSurface, uint, uint, ACBindings.PixelFormatID, byte, byte>)0x00444150)(ref this, width, height, pixelFormat, bLocalData);
    // bool __thiscall RenderSurface::CreateFromSourceData(RenderSurface*)
    public byte CreateFromSourceData() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderSurface, byte>)0x00444200)(ref this);
    // DBObj* __thiscall RenderSurface::Allocator(RenderSurface*)
    public ACBindings.DBObj* Allocator() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderSurface, ACBindings.DBObj*>)0x00444500)(ref this);
    // void __thiscall RenderSurface::Destroy(RenderSurface*)
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderSurface, void>)0x00444540)(ref this);
    // void __thiscall RenderSurface::~RenderSurface(RenderSurface*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderSurface, void>)0x00444580)(ref this);
    // void __thiscall RenderSurface::GetSubDataIDs(RenderSurface*,QualifiedDataIDArray*)
    public void GetSubDataIDs(ACBindings.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderSurface, ACBindings.QualifiedDataIDArray*, void>)0x004445F0)(ref this, id_array);
    // void __thiscall RenderSurface::Serialize(RenderSurface*,Archive*)
    public void Serialize(ACBindings.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderSurface, ACBindings.Archive*, void>)0x00444640)(ref this, io_archive);
}

