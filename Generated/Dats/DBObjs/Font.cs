namespace ACBindings.Internal;

public unsafe struct Font : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.DBObj BaseClass_DBObj; // ACBindings.Internal.DBObj

    // Child Types
    public unsafe struct Font_vtbl
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
    public uint maxCharHeight;
    public uint maxCharWidth;
    public uint numCharacters;
    public ACBindings.Internal.FontCharDesc* charDescs;
    public uint m_NumHorizontalBorderPixels;
    public uint m_NumVerticalBorderPixels;
    public int m_BaselineOffset;
    public ACBindings.Internal.PStringBase__sbyte m_ForegroundSurfaceFileName;
    public ACBindings.Internal.IDClass____tagDataID m_ForegroundSurfaceDataID;
    public ACBindings.Internal.RenderSurface* m_pForegroundSurface;
    public ACBindings.Internal.PStringBase__sbyte m_BackgroundSurfaceFileName;
    public ACBindings.Internal.IDClass____tagDataID m_BackgroundSurfaceDataID;
    public ACBindings.Internal.RenderSurface* m_pBackgroundSurface;
    public ushort minUnicodeChar;
    public ushort maxUnicodeChar;
    public uint unicodeRangeLength;
    public ushort* characterMap;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x00443450
    /// void __thiscall Font::End(Font*)</code>
    /// </summary>
    public void End() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Font, void>)0x00443450)(ref this);

    /// <summary>
    /// <code>Offset: 0x00443490
    /// bool __thiscall Font::ReleaseSubObjects(Font*)</code>
    /// </summary>
    public byte ReleaseSubObjects() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Font, byte>)0x00443490)(ref this);

    /// <summary>
    /// <code>Offset: 0x004434C0
    /// const FontCharDesc* __thiscall Font::GetCharDesc(Font*,const unsigned __int16)</code>
    /// </summary>
    public ACBindings.Internal.FontCharDesc* GetCharDesc(ushort chr) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Font, ushort, ACBindings.Internal.FontCharDesc*>)0x004434C0)(ref this, chr);

    /// <summary>
    /// <code>Offset: 0x00443550
    /// unsigned __int8 __thiscall Font::GetCharWidthA(Font*,const unsigned __int16)</code>
    /// </summary>
    public byte GetCharWidthA(ushort chr) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Font, ushort, byte>)0x00443550)(ref this, chr);

    /// <summary>
    /// <code>Offset: 0x00443580
    /// bool __thiscall Font::ContainsChar(Font*,const unsigned __int16)</code>
    /// </summary>
    public byte ContainsChar(ushort ch) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Font, ushort, byte>)0x00443580)(ref this, ch);

    /// <summary>
    /// <code>Offset: 0x004435D0
    /// bool __thiscall Font::GenerateCharacterMap(Font*)</code>
    /// </summary>
    public byte GenerateCharacterMap() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Font, byte>)0x004435D0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004436A0
    /// bool __thiscall Font::LockSurfaces(Font*)</code>
    /// </summary>
    public byte LockSurfaces() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Font, byte>)0x004436A0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004436E0
    /// bool __thiscall Font::UnlockSurfaces(Font*)</code>
    /// </summary>
    public byte UnlockSurfaces() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Font, byte>)0x004436E0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00443720
    /// bool __thiscall Font::InitLoad(Font*)</code>
    /// </summary>
    public byte InitLoad() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Font, byte>)0x00443720)(ref this);

    /// <summary>
    /// <code>Offset: 0x00443740
    /// bool __thiscall Font::GetSubObjects(Font*)</code>
    /// </summary>
    public byte GetSubObjects() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Font, byte>)0x00443740)(ref this);

    /// <summary>
    /// <code>Offset: 0x004437B0
    /// void __thiscall Font::Serialize(Font*,Archive*)</code>
    /// </summary>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Font, ACBindings.Internal.Archive*, void>)0x004437B0)(ref this, io_archive);

    /// <summary>
    /// <code>Offset: 0x00443960
    /// void __thiscall Font::Begin(Font*)</code>
    /// </summary>
    public void Begin() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Font, void>)0x00443960)(ref this);

    /// <summary>
    /// <code>Offset: 0x00443A20
    /// void __thiscall Font::Destroy(Font*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Font, void>)0x00443A20)(ref this);

    /// <summary>
    /// <code>Offset: 0x00443A60
    /// void __thiscall Font::GetSubDataIDs(Font*,QualifiedDataIDArray*)</code>
    /// </summary>
    public void GetSubDataIDs(ACBindings.Internal.QualifiedDataIDArray* aQDID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Font, ACBindings.Internal.QualifiedDataIDArray*, void>)0x00443A60)(ref this, aQDID);

    /// <summary>
    /// <code>Offset: 0x0044B660
    /// DBObj* __cdecl Font::Get(int)</code>
    /// </summary>
    public static ACBindings.Internal.DBObj* Get(int a1) => ((delegate* unmanaged[Cdecl]<int, ACBindings.Internal.DBObj*>)0x0044B660)(a1);

    /// <summary>
    /// <code>Offset: 0x004F8200
    /// unsigned int __thiscall Font::GetDBOType(Font*)</code>
    /// </summary>
    public uint GetDBOType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Font, uint>)0x004F8200)(ref this);

    /// <summary>
    /// <code>Offset: 0x004F8210
    /// void __thiscall Font::~Font(Font*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Font, void>)0x004F8210)(ref this);

    /// <summary>
    /// <code>Offset: 0x004F8270
    /// DBObj* __thiscall Font::Allocator(Font*)</code>
    /// </summary>
    public ACBindings.Internal.DBObj* Allocator() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Font, ACBindings.Internal.DBObj*>)0x004F8270)(ref this);
}

