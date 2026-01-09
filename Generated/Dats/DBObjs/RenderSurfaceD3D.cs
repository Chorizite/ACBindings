namespace ACBindings;

// RenderSurfaceD3D
public unsafe struct RenderSurfaceD3D : System.IDisposable
{
    // Base Classes
    public ACBindings.RenderSurface BaseClass_RenderSurface; // ACBindings.RenderSurface

    // Child Types
    // RenderSurfaceD3D_vtbl
    public unsafe struct RenderSurfaceD3D_vtbl
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
        public System.IntPtr CreateFromD3DSurface; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr m_pD3DSurface;
    public ACBindings._D3DPOOL m_pool;
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
    // bool __thiscall RenderSurfaceD3D::CreateFromD3DSurface(RenderSurfaceD3D*,IDirect3DSurface9*,const bool,const bool)
    public byte CreateFromD3DSurface(System.IntPtr pExistingSurface, byte CountAsSystemMemory, byte CountAsVideoMemory) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderSurfaceD3D, System.IntPtr, byte, byte, byte>)0x00696BB0)(ref this, pExistingSurface, CountAsSystemMemory, CountAsVideoMemory);
    // IDirect3DSurface9* __thiscall RenderSurfaceD3D::GetDirect3DSurface(RenderSurfaceD3D*)
    public System.IntPtr GetDirect3DSurface() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderSurfaceD3D, System.IntPtr>)0x00696C50)(ref this);
    // bool __thiscall RenderSurfaceD3D::Convert(RenderSurfaceD3D*,const RenderSurface*)
    public byte Convert(ACBindings.RenderSurface* source) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderSurfaceD3D, ACBindings.RenderSurface*, byte>)0x00696CA0)(ref this, source);
    // bool __thiscall RenderSurfaceD3D::CreateD3DSurface(RenderSurfaceD3D*)
    public byte CreateD3DSurface() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderSurfaceD3D, byte>)0x00696D00)(ref this);
    // bool __thiscall RenderSurfaceD3D::PurgeResource(RenderSurfaceD3D*)
    public byte PurgeResource() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderSurfaceD3D, byte>)0x00696D90)(ref this);
    // void __thiscall RenderSurfaceD3D::RenderSurfaceD3D(RenderSurfaceD3D*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderSurfaceD3D, void>)0x00696DE0)(ref this);
    // bool __thiscall RenderSurfaceD3D::Create(RenderSurfaceD3D*,unsigned int,unsigned int,PixelFormatID,bool)
    public byte Create(uint width, uint height, ACBindings.PixelFormatID pixelFormat, byte bLocalData) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderSurfaceD3D, uint, uint, ACBindings.PixelFormatID, byte, byte>)0x00696E30)(ref this, width, height, pixelFormat, bLocalData);
    // void __thiscall RenderSurfaceD3D::Destroy(RenderSurfaceD3D*)
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderSurfaceD3D, void>)0x00696EB0)(ref this);
    // bool __thiscall RenderSurfaceD3D::Lock(RenderSurfaceD3D*,const tagRECT*,const unsigned int,int*,void**)
    public byte Lock(ACBindings.tagRECT* rect, uint flags, int* pitch, void** data) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderSurfaceD3D, ACBindings.tagRECT*, uint, int*, void**, byte>)0x00696F10)(ref this, rect, flags, pitch, data);
    // void __thiscall RenderSurfaceD3D::Unlock(RenderSurfaceD3D*)
    public void Unlock() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderSurfaceD3D, void>)0x00696FB0)(ref this);
    // bool __thiscall RenderSurfaceD3D::RestoreResource(RenderSurfaceD3D*)
    public byte RestoreResource() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderSurfaceD3D, byte>)0x00696FE0)(ref this);
    // void __thiscall RenderSurfaceD3D::~RenderSurfaceD3D(RenderSurfaceD3D*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderSurfaceD3D, void>)0x00697030)(ref this);
}

