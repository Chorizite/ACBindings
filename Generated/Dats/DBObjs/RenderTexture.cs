namespace ACBindings;

// RenderTexture
public unsafe struct RenderTexture : System.IDisposable
{
    // Base Classes
    public ACBindings.DBObj BaseClass_DBObj; // ACBindings.DBObj
    public ACBindings.GraphicsResource BaseClass_GraphicsResource; // ACBindings.GraphicsResource

    // Child Types
    // RenderTexture_vtbl
    public unsafe struct RenderTexture_vtbl
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
    public ACBindings.TextureType m_TextureType;
    public uint m_nNumLevels;
    public ACBindings.PixelFormatID m_PixelFormat;
    public uint m_Flags;
    public byte m_bDropLevelsCalled;
    public uint m_ManagedRefCount;
    public double m_LastManagedReleaseTime;
    public byte m_AllowManagement;
    public ACBindings.SmartArray__DBLevelInfo m_SourceLevels;
    public uint m_nWidth;
    public uint m_nHeight;
    public uint m_nEdgeLength;

    // Generated Constructor
    public RenderTexture() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // bool __thiscall RenderTexture::Create2D(RenderTexture*,const unsigned int,const unsigned int,const unsigned int,const PixelFormatID,const unsigned int)
    public byte Create2D(uint nWidth, uint nHeight, uint nNumLevels, ACBindings.PixelFormatID PixelFormat, uint Flags) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderTexture, uint, uint, uint, ACBindings.PixelFormatID, uint, byte>)0x0044B950)(ref this, nWidth, nHeight, nNumLevels, PixelFormat, Flags);
    // bool __thiscall RenderTexture::CreateCube(RenderTexture*,const unsigned int,const unsigned int,const PixelFormatID,const unsigned int)
    public byte CreateCube(uint nEdgeLength, uint nNumLevels, ACBindings.PixelFormatID PixelFormat, uint Flags) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderTexture, uint, uint, ACBindings.PixelFormatID, uint, byte>)0x0044B9A0)(ref this, nEdgeLength, nNumLevels, PixelFormat, Flags);
    // bool __cdecl RenderTexture::ShouldDropHighDetail()
    public static byte ShouldDropHighDetail() => ((delegate* unmanaged[Cdecl]<byte>)0x0044B9F0)();
    // bool __thiscall RenderTexture::Refresh(void*,int)
    public byte Refresh(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderTexture, int, byte>)0x0044BA10)(ref this, a2);
    // PixelFormatID __cdecl RenderTexture::SelectTextureFormat(const PixelFormatID)
    public static ACBindings.PixelFormatID SelectTextureFormat(ACBindings.PixelFormatID format) => ((delegate* unmanaged[Cdecl]<ACBindings.PixelFormatID, ACBindings.PixelFormatID>)0x0044BA40)(format);
    // void __thiscall RenderTexture::ReleaseSourceLevelReferences(RenderTexture*)
    public void ReleaseSourceLevelReferences() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderTexture, void>)0x0044BAC0)(ref this);
    // bool __thiscall RenderTexture::ReleaseSubObjects(RenderTexture*)
    public byte ReleaseSubObjects() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderTexture, byte>)0x0044BB20)(ref this);
    // bool __thiscall RenderTexture::LoadLevelResources(RenderTexture*)
    public byte LoadLevelResources() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderTexture, byte>)0x0044BB40)(ref this);
    // bool __thiscall RenderTexture::ConstructTexture(RenderTexture*)
    public byte ConstructTexture() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderTexture, byte>)0x0044BC30)(ref this);
    // bool __thiscall RenderTexture::GetSubObjects(RenderTexture*)
    public byte GetSubObjects() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderTexture, byte>)0x0044BF80)(ref this);
    // void __thiscall RenderTexture::RenderTexture(RenderTexture*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderTexture, void>)0x0044C430)(ref this);
    // unsigned int __thiscall RenderTexture::GetDBOType(RenderTexture*)
    public uint GetDBOType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderTexture, uint>)0x0044C4A0)(ref this);
    // void __thiscall RenderTexture::End(RenderTexture*)
    public void End() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderTexture, void>)0x0044C4C0)(ref this);
    // void __thiscall RenderTexture::Destroy(RenderTexture*)
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderTexture, void>)0x0044C4F0)(ref this);
    // bool __thiscall RenderTexture::DropUnwantedLevels(RenderTexture*)
    public byte DropUnwantedLevels() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderTexture, byte>)0x0044C550)(ref this);
    // DBObj* __thiscall RenderTexture::Allocate(RenderTexture*)
    public ACBindings.DBObj* Allocate() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderTexture, ACBindings.DBObj*>)0x0044C660)(ref this);
    // void __thiscall RenderTexture::~RenderTexture(RenderTexture*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderTexture, void>)0x0044C6C0)(ref this);
    // bool __thiscall RenderTexture::CopyInto(RenderTexture*,DBObj*)
    public byte CopyInto(ACBindings.DBObj* Retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderTexture, ACBindings.DBObj*, byte>)0x0044C710)(ref this, Retval);
    // void __thiscall RenderTexture::GetSubDataIDs(RenderTexture*,QualifiedDataIDArray*)
    public void GetSubDataIDs(ACBindings.QualifiedDataIDArray* aQDID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderTexture, ACBindings.QualifiedDataIDArray*, void>)0x0044C880)(ref this, aQDID);
    // bool __thiscall RenderTexture::InitLoad(RenderTexture*)
    public byte InitLoad() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderTexture, byte>)0x0044C920)(ref this);
    // void __thiscall RenderTexture::Serialize(RenderTexture*,Archive*)
    public void Serialize(ACBindings.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderTexture, ACBindings.Archive*, void>)0x0044C940)(ref this, io_archive);
}

