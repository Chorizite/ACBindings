namespace ACBindings;

// RenderTextureD3D
public unsafe struct RenderTextureD3D : System.IDisposable
{
    // Base Classes
    public ACBindings.RenderTexture BaseClass_RenderTexture; // ACBindings.RenderTexture

    // Child Types
    // RenderTextureD3D_vtbl
    public unsafe struct RenderTextureD3D_vtbl
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
        public System.IntPtr Create2D; // function pointer
        public System.IntPtr CreateCube; // function pointer
        public System.IntPtr LoadTexture; // function pointer
        public System.IntPtr GetLevelRef; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr m_p2DTextureD3D;
    public System.IntPtr m_pCubeTextureD3D;
    public ACBindings.SmartArray__D3DLevelResourceType m_D3DSurfaces;

    // Generated Constructor
    public RenderTextureD3D() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // bool __thiscall RenderTextureD3D::GetSubObjects(RenderTextureD3D*)
    public byte GetSubObjects() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderTextureD3D, byte>)0x00696060)(ref this);
    // void __thiscall RenderTextureD3D::ReleaseD3DSurfaces(RenderTextureD3D*)
    public void ReleaseD3DSurfaces() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderTextureD3D, void>)0x006961D0)(ref this);
    // void __thiscall RenderTextureD3D::ReleaseD3DTexture(RenderTextureD3D*)
    public void ReleaseD3DTexture() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderTextureD3D, void>)0x00696240)(ref this);
    // bool __thiscall RenderTextureD3D::PurgeResource(RenderTextureD3D*)
    public byte PurgeResource() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderTextureD3D, byte>)0x006962D0)(ref this);
    // bool __thiscall RenderTextureD3D::CopyInto(RenderTextureD3D*,DBObj*)
    public byte CopyInto(ACBindings.DBObj* retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderTextureD3D, ACBindings.DBObj*, byte>)0x00696380)(ref this, retval);
    // bool __thiscall RenderTextureD3D::ReleaseSubObjects(RenderTextureD3D*)
    public byte ReleaseSubObjects() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderTextureD3D, byte>)0x00696440)(ref this);
    // bool __thiscall RenderTextureD3D::CreateD3DTexture(RenderTextureD3D*)
    public byte CreateD3DTexture() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderTextureD3D, byte>)0x00696470)(ref this);
    // bool __thiscall RenderTextureD3D::RestoreResource(RenderTextureD3D*)
    public byte RestoreResource() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderTextureD3D, byte>)0x00696840)(ref this);
    // void __thiscall RenderTextureD3D::Destroy(RenderTextureD3D*)
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderTextureD3D, void>)0x00696880)(ref this);
    // IDirect3DTexture9* __thiscall RenderTextureD3D::Get2DTextureD3D(RenderTextureD3D*)
    public System.IntPtr Get2DTextureD3D() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderTextureD3D, System.IntPtr>)0x006968D0)(ref this);
    // IDirect3DCubeTexture9* __thiscall RenderTextureD3D::GetCubeTextureD3D(RenderTextureD3D*)
    public System.IntPtr GetCubeTextureD3D() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderTextureD3D, System.IntPtr>)0x00696930)(ref this);
    // void __thiscall RenderTextureD3D::RenderTextureD3D(RenderTextureD3D*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderTextureD3D, void>)0x00696990)(ref this);
    // void __thiscall RenderTextureD3D::~RenderTextureD3D(RenderTextureD3D*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderTextureD3D, void>)0x006969E0)(ref this);
    // GraphicsResource* __thiscall RenderTextureD3D::GetLevelRef(RenderTextureD3D*,const unsigned int,const unsigned int)
    public ACBindings.GraphicsResource* GetLevelRef(uint nLevel, uint Resource) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderTextureD3D, uint, uint, ACBindings.GraphicsResource*>)0x00696A60)(ref this, nLevel, Resource);
    // bool __thiscall RenderTextureD3D::LoadTexture(RenderTextureD3D*,const RenderTexture*)
    public byte LoadTexture(ACBindings.RenderTexture* Source) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderTextureD3D, ACBindings.RenderTexture*, byte>)0x00696B00)(ref this, Source);
}

