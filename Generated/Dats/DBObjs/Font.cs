namespace ACBindings;

// Font
public unsafe struct Font : System.IDisposable
{
    // Base Classes
    public ACBindings.DBObj BaseClass_DBObj; // ACBindings.DBObj

    // Child Types
    // Font_vtbl
    public unsafe struct Font_vtbl
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
    public uint maxCharHeight;
    public uint maxCharWidth;
    public uint numCharacters;
    public ACBindings.FontCharDesc* charDescs;
    public uint m_NumHorizontalBorderPixels;
    public uint m_NumVerticalBorderPixels;
    public int m_BaselineOffset;
    public ACBindings.PStringBase__sbyte m_ForegroundSurfaceFileName;
    public ACBindings.IDClass___tagDataID m_ForegroundSurfaceDataID;
    public ACBindings.RenderSurface* m_pForegroundSurface;
    public ACBindings.PStringBase__sbyte m_BackgroundSurfaceFileName;
    public ACBindings.IDClass___tagDataID m_BackgroundSurfaceDataID;
    public ACBindings.RenderSurface* m_pBackgroundSurface;
    public ushort minUnicodeChar;
    public ushort maxUnicodeChar;
    public uint unicodeRangeLength;
    public ushort* characterMap;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall Font::End(Font*)
    public void End() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Font, void>)0x00443450)(ref this);
    // bool __thiscall Font::ReleaseSubObjects(Font*)
    public byte ReleaseSubObjects() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Font, byte>)0x00443490)(ref this);
    // const FontCharDesc* __thiscall Font::GetCharDesc(Font*,const unsigned __int16)
    public ACBindings.FontCharDesc* GetCharDesc(ushort chr) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Font, ushort, ACBindings.FontCharDesc*>)0x004434C0)(ref this, chr);
    // unsigned __int8 __thiscall Font::GetCharWidthA(Font*,const unsigned __int16)
    public byte GetCharWidthA(ushort chr) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Font, ushort, byte>)0x00443550)(ref this, chr);
    // bool __thiscall Font::ContainsChar(Font*,const unsigned __int16)
    public byte ContainsChar(ushort ch) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Font, ushort, byte>)0x00443580)(ref this, ch);
    // bool __thiscall Font::GenerateCharacterMap(Font*)
    public byte GenerateCharacterMap() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Font, byte>)0x004435D0)(ref this);
    // bool __thiscall Font::LockSurfaces(Font*)
    public byte LockSurfaces() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Font, byte>)0x004436A0)(ref this);
    // bool __thiscall Font::UnlockSurfaces(Font*)
    public byte UnlockSurfaces() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Font, byte>)0x004436E0)(ref this);
    // bool __thiscall Font::InitLoad(Font*)
    public byte InitLoad() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Font, byte>)0x00443720)(ref this);
    // bool __thiscall Font::GetSubObjects(Font*)
    public byte GetSubObjects() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Font, byte>)0x00443740)(ref this);
    // void __thiscall Font::Serialize(Font*,Archive*)
    public void Serialize(ACBindings.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Font, ACBindings.Archive*, void>)0x004437B0)(ref this, io_archive);
    // void __thiscall Font::Begin(Font*)
    public void Begin() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Font, void>)0x00443960)(ref this);
    // void __thiscall Font::Destroy(Font*)
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Font, void>)0x00443A20)(ref this);
    // void __thiscall Font::GetSubDataIDs(Font*,QualifiedDataIDArray*)
    public void GetSubDataIDs(ACBindings.QualifiedDataIDArray* aQDID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Font, ACBindings.QualifiedDataIDArray*, void>)0x00443A60)(ref this, aQDID);
    // DBObj* __cdecl Font::Get(int)
    public static ACBindings.DBObj* Get(int a1) => ((delegate* unmanaged[Cdecl]<int, ACBindings.DBObj*>)0x0044B660)(a1);
    // unsigned int __thiscall Font::GetDBOType(Font*)
    public uint GetDBOType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Font, uint>)0x004F8200)(ref this);
    // void __thiscall Font::~Font(Font*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Font, void>)0x004F8210)(ref this);
    // DBObj* __thiscall Font::Allocator(Font*)
    public ACBindings.DBObj* Allocator() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Font, ACBindings.DBObj*>)0x004F8270)(ref this);
}

