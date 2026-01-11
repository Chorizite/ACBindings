namespace ACBindings.Internal;

public unsafe struct RenderTexture : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.DBObj BaseClass_DBObj; // ACBindings.Internal.DBObj
    public ACBindings.Internal.GraphicsResource BaseClass_GraphicsResource; // ACBindings.Internal.GraphicsResource

    // Child Types
    public unsafe struct RenderTexture_vtbl
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
    public ACBindings.Internal.TextureType m_TextureType;
    public uint m_nNumLevels;
    public ACBindings.Internal.PixelFormatID m_PixelFormat;
    public uint m_Flags;
    public byte m_bDropLevelsCalled;
    public uint m_ManagedRefCount;
    public double m_LastManagedReleaseTime;
    public byte m_AllowManagement;
    public ACBindings.Internal.SmartArray___DBLevelInfo m_SourceLevels;
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

    /// <summary>
    /// <code>Offset: 0x0044B950
    /// bool __thiscall RenderTexture::Create2D(RenderTexture*,const unsigned int,const unsigned int,const unsigned int,const PixelFormatID,const unsigned int)</code>
    /// </summary>
    public byte Create2D(uint nWidth, uint nHeight, uint nNumLevels, ACBindings.Internal.PixelFormatID PixelFormat, uint Flags) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderTexture, uint, uint, uint, ACBindings.Internal.PixelFormatID, uint, byte>)0x0044B950)(ref this, nWidth, nHeight, nNumLevels, PixelFormat, Flags);

    /// <summary>
    /// <code>Offset: 0x0044B9A0
    /// bool __thiscall RenderTexture::CreateCube(RenderTexture*,const unsigned int,const unsigned int,const PixelFormatID,const unsigned int)</code>
    /// </summary>
    public byte CreateCube(uint nEdgeLength, uint nNumLevels, ACBindings.Internal.PixelFormatID PixelFormat, uint Flags) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderTexture, uint, uint, ACBindings.Internal.PixelFormatID, uint, byte>)0x0044B9A0)(ref this, nEdgeLength, nNumLevels, PixelFormat, Flags);

    /// <summary>
    /// <code>Offset: 0x0044B9F0
    /// bool __cdecl RenderTexture::ShouldDropHighDetail()</code>
    /// </summary>
    public static byte ShouldDropHighDetail() => ((delegate* unmanaged[Cdecl]<byte>)0x0044B9F0)();

    /// <summary>
    /// <code>Offset: 0x0044BA10
    /// bool __thiscall RenderTexture::Refresh(void*,int)</code>
    /// </summary>
    public byte Refresh(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderTexture, int, byte>)0x0044BA10)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x0044BA40
    /// PixelFormatID __cdecl RenderTexture::SelectTextureFormat(const PixelFormatID)</code>
    /// </summary>
    public static ACBindings.Internal.PixelFormatID SelectTextureFormat(ACBindings.Internal.PixelFormatID format) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.PixelFormatID, ACBindings.Internal.PixelFormatID>)0x0044BA40)(format);

    /// <summary>
    /// <code>Offset: 0x0044BAC0
    /// void __thiscall RenderTexture::ReleaseSourceLevelReferences(RenderTexture*)</code>
    /// </summary>
    public void ReleaseSourceLevelReferences() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderTexture, void>)0x0044BAC0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0044BB20
    /// bool __thiscall RenderTexture::ReleaseSubObjects(RenderTexture*)</code>
    /// </summary>
    public byte ReleaseSubObjects() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderTexture, byte>)0x0044BB20)(ref this);

    /// <summary>
    /// <code>Offset: 0x0044BB40
    /// bool __thiscall RenderTexture::LoadLevelResources(RenderTexture*)</code>
    /// </summary>
    public byte LoadLevelResources() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderTexture, byte>)0x0044BB40)(ref this);

    /// <summary>
    /// <code>Offset: 0x0044BC30
    /// bool __thiscall RenderTexture::ConstructTexture(RenderTexture*)</code>
    /// </summary>
    public byte ConstructTexture() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderTexture, byte>)0x0044BC30)(ref this);

    /// <summary>
    /// <code>Offset: 0x0044BF80
    /// bool __thiscall RenderTexture::GetSubObjects(RenderTexture*)</code>
    /// </summary>
    public byte GetSubObjects() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderTexture, byte>)0x0044BF80)(ref this);

    /// <summary>
    /// <code>Offset: 0x0044C430
    /// void __thiscall RenderTexture::RenderTexture(RenderTexture*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderTexture, void>)0x0044C430)(ref this);

    /// <summary>
    /// <code>Offset: 0x0044C4A0
    /// unsigned int __thiscall RenderTexture::GetDBOType(RenderTexture*)</code>
    /// </summary>
    public uint GetDBOType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderTexture, uint>)0x0044C4A0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0044C4C0
    /// void __thiscall RenderTexture::End(RenderTexture*)</code>
    /// </summary>
    public void End() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderTexture, void>)0x0044C4C0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0044C4F0
    /// void __thiscall RenderTexture::Destroy(RenderTexture*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderTexture, void>)0x0044C4F0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0044C550
    /// bool __thiscall RenderTexture::DropUnwantedLevels(RenderTexture*)</code>
    /// </summary>
    public byte DropUnwantedLevels() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderTexture, byte>)0x0044C550)(ref this);

    /// <summary>
    /// <code>Offset: 0x0044C660
    /// DBObj* __thiscall RenderTexture::Allocate(RenderTexture*)</code>
    /// </summary>
    public ACBindings.Internal.DBObj* Allocate() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderTexture, ACBindings.Internal.DBObj*>)0x0044C660)(ref this);

    /// <summary>
    /// <code>Offset: 0x0044C6C0
    /// void __thiscall RenderTexture::~RenderTexture(RenderTexture*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderTexture, void>)0x0044C6C0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0044C710
    /// bool __thiscall RenderTexture::CopyInto(RenderTexture*,DBObj*)</code>
    /// </summary>
    public byte CopyInto(ACBindings.Internal.DBObj* Retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderTexture, ACBindings.Internal.DBObj*, byte>)0x0044C710)(ref this, Retval);

    /// <summary>
    /// <code>Offset: 0x0044C880
    /// void __thiscall RenderTexture::GetSubDataIDs(RenderTexture*,QualifiedDataIDArray*)</code>
    /// </summary>
    public void GetSubDataIDs(ACBindings.Internal.QualifiedDataIDArray* aQDID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderTexture, ACBindings.Internal.QualifiedDataIDArray*, void>)0x0044C880)(ref this, aQDID);

    /// <summary>
    /// <code>Offset: 0x0044C920
    /// bool __thiscall RenderTexture::InitLoad(RenderTexture*)</code>
    /// </summary>
    public byte InitLoad() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderTexture, byte>)0x0044C920)(ref this);

    /// <summary>
    /// <code>Offset: 0x0044C940
    /// void __thiscall RenderTexture::Serialize(RenderTexture*,Archive*)</code>
    /// </summary>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderTexture, ACBindings.Internal.Archive*, void>)0x0044C940)(ref this, io_archive);
}

