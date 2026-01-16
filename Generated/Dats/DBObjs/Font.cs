namespace ACBindings.Internal;


/// <summary>Defines font metrics and resources for rendering text, storing character dimensions, mapping tables, and associated surface data for foreground and background rendering.</summary>
public unsafe struct Font : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.DBObj BaseClass_DBObj; // ACBindings.Internal.DBObj

    // Child Types
    public unsafe struct Font_vtbl
    {
        // Members
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, ACBindings.Internal._GUID*, void**, int> IUnknown_QueryInterface; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_AddRef; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_Release; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, ACBindings.Internal.TResult*, ACBindings.Internal.Turbine_GUID*, void**, ACBindings.Internal.TResult*> QueryInterface; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> AddRef; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> Release; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, void> DBObj_dtor_18; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.Archive*, void> Serialize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.QualifiedDataIDArray*, void> GetSubDataIDs; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> InitLoad; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> GetSubObjects; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> ReleaseSubObjects; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> NotifyFidelityLevel; // function pointer
        public System.IntPtr Refresh;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.DBObj*, byte> CopyInto; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, void> Destroy; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.IDataGraph*, void> FillDataGraph; // function pointer
        public System.IntPtr SetDID;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, uint> GetDBOType; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.DBObj*> Allocate; // function pointer
        public System.IntPtr SaveToDisk;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> ReloadFromDisk; // function pointer

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

    /// <summary>Releases the font object's interface and frees any allocated character mapping and description data. After deletion, it resets internal pointers to null.
    /// <code>Offset: 0x00443450
    /// void __thiscall Font::End(Font*)</code>
    /// </summary>
    public void End() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Font, void>)0x00443450)(ref this);

    /// <summary>Releases the font's foreground and background render surfaces, clearing associated resources and resetting surface pointers.
    /// <code>Offset: 0x00443490
    /// bool __thiscall Font::ReleaseSubObjects(Font*)</code>
    /// </summary>
    /// <returns>True after releasing sub‑objects; indicates successful release.</returns>
    public byte ReleaseSubObjects() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Font, byte>)0x00443490)(ref this);

    /// <summary>Retrieves the description of a glyph in the font for the given Unicode code point. Returns nullptr when the requested character is not present.
    /// <code>Offset: 0x004434C0
    /// const FontCharDesc* __thiscall Font::GetCharDesc(Font*,const unsigned __int16)</code>
    /// </summary>
    /// <param name="chr">The Unicode code point of the desired character.</param>
    /// <returns>A pointer to the FontCharDesc that describes the glyph, or null if no mapping exists.</returns>
    public ACBindings.Internal.FontCharDesc* GetCharDesc(ushort chr) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Font, ushort, ACBindings.Internal.FontCharDesc*>)0x004434C0)(ref this, chr);

    /// <summary>Returns the total horizontal pixel width of the specified character, including any before and after offsets. If the character is not defined within the font, zero is returned.
    /// <code>Offset: 0x00443550
    /// unsigned __int8 __thiscall Font::GetCharWidthA(Font*,const unsigned __int16)</code>
    /// </summary>
    /// <param name="chr">Unicode code point of the character to measure.</param>
    /// <returns>The width in pixels as an 8‑bit unsigned integer.</returns>
    public byte GetCharWidthA(ushort chr) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Font, ushort, byte>)0x00443550)(ref this, chr);

    /// <summary>Checks whether a specified Unicode code point is present in this Font's character set.
    /// <code>Offset: 0x00443580
    /// bool __thiscall Font::ContainsChar(Font*,const unsigned __int16)</code>
    /// </summary>
    /// <param name="ch">The Unicode code point to look up.</param>
    /// <returns>True if the font includes the character; otherwise, false.</returns>
    public byte ContainsChar(ushort ch) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Font, ushort, byte>)0x00443580)(ref this, ch);

    /// <summary>Builds a lookup table that maps Unicode code points to character indices for the font's glyph set.
    /// <code>Offset: 0x004435D0
    /// bool __thiscall Font::GenerateCharacterMap(Font*)</code>
    /// </summary>
    /// <returns>True when the map is successfully created; otherwise, false if no characters are defined or the unicode range is invalid.</returns>
    public byte GenerateCharacterMap() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Font, byte>)0x004435D0)(ref this);

    /// <summary>Locks the foreground and background render surfaces of the font for subsequent drawing operations.
    /// <code>Offset: 0x004436A0
    /// bool __thiscall Font::LockSurfaces(Font*)</code>
    /// </summary>
    /// <returns>True if both surfaces are successfully locked or are not present; otherwise false.</returns>
    public byte LockSurfaces() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Font, byte>)0x004436A0)(ref this);

    /// <summary>Releases the render surface windows used by the font, unlocking any foreground and background surfaces that are currently loaded.
    /// <code>Offset: 0x004436E0
    /// bool __thiscall Font::UnlockSurfaces(Font*)</code>
    /// </summary>
    /// <returns>True when all existing surfaces have been unlocked successfully; false if an unlock operation fails.</returns>
    public byte UnlockSurfaces() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Font, byte>)0x004436E0)(ref this);

    /// <summary>Initializes the font by generating its character mapping.
    /// <code>Offset: 0x00443720
    /// bool __thiscall Font::InitLoad(Font*)</code>
    /// </summary>
    /// <returns>True if the character map was successfully generated; otherwise false.</returns>
    public byte InitLoad() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Font, byte>)0x00443720)(ref this);

    /// <summary>Loads the font’s foreground surface and, if specified, its background surface from the resource cache. Updates internal surface pointers and reports whether both required surfaces were successfully retrieved.
    /// <code>Offset: 0x00443740
    /// bool __thiscall Font::GetSubObjects(Font*)</code>
    /// </summary>
    /// <returns>True when the foreground surface is present and a background surface exists only if indicated; otherwise false.</returns>
    public byte GetSubObjects() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Font, byte>)0x00443740)(ref this);

    /// <summary>Serializes the font's properties and character descriptors to or from an archive, handling both writing and reading based on the archive mode.
    /// <code>Offset: 0x004437B0
    /// void __thiscall Font::Serialize(Font*,Archive*)</code>
    /// </summary>
    /// <param name="this">The Font instance whose data is being serialized.</param>
    /// <param name="io_archive">Archive used for storing or retrieving font information.</param>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Font, ACBindings.Internal.Archive*, void>)0x004437B0)(ref this, io_archive);

    /// <summary>Initializes a Font instance by resetting character metrics, Unicode ranges, and releasing foreground and background surfaces.
    /// <code>Offset: 0x00443960
    /// void __thiscall Font::Begin(Font*)</code>
    /// </summary>
    public void Begin() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Font, void>)0x00443960)(ref this);

    /// <summary>Releases the font’s resources, deallocates internal character maps and descriptions, then resets its state by calling Font::Begin.
    /// <code>Offset: 0x00443A20
    /// void __thiscall Font::Destroy(Font*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Font, void>)0x00443A20)(ref this);

    /// <summary>Collects the data identifiers for a font's foreground and background surfaces, adding them to the provided array when valid.
    /// <code>Offset: 0x00443A60
    /// void __thiscall Font::GetSubDataIDs(Font*,QualifiedDataIDArray*)</code>
    /// </summary>
    /// <param name="aQDID">The QualifiedDataIDArray into which discovered IDs are added.</param>
    public void GetSubDataIDs(ACBindings.Internal.QualifiedDataIDArray* aQDID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Font, ACBindings.Internal.QualifiedDataIDArray*, void>)0x00443A60)(ref this, aQDID);

    /// <summary>Retrieves the database object corresponding to the specified identifier within this font.
    /// <code>Offset: 0x0044B660
    /// DBObj* __cdecl Font::Get(int)</code>
    /// </summary>
    /// <param name="a1">The numeric identifier used to locate the desired DBObj.</param>
    /// <returns>A pointer to the retrieved DBObj, or nullptr if not found.</returns>
    public static ACBindings.Internal.DBObj* Get(int a1) => ((delegate* unmanaged[Cdecl]<int, ACBindings.Internal.DBObj*>)0x0044B660)(a1);

    /// <summary>Returns the database object type identifier for this Font instance.
    /// <code>Offset: 0x004F8200
    /// unsigned int __thiscall Font::GetDBOType(Font*)</code>
    /// </summary>
    /// <returns>The DBO type code, which is currently always 46.</returns>
    public uint GetDBOType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Font, uint>)0x004F8200)(ref this);

    /// <summary>Releases resources held by a Font object, including its foreground and background surfaces, character descriptors, and associated string buffers.
    /// <code>Offset: 0x004F8210
    /// void __thiscall Font::~Font(Font*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Font, void>)0x004F8210)(ref this);

    /// <summary>Allocates and constructs a new Font object, initializing its base class and default surface filenames before invoking the class's Begin method.
    /// <code>Offset: 0x004F8270
    /// DBObj* __thiscall Font::Allocator(Font*)</code>
    /// </summary>
    /// <returns>A pointer to the newly created object's DBObj base class.</returns>
    public ACBindings.Internal.DBObj* Allocator() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Font, ACBindings.Internal.DBObj*>)0x004F8270)(ref this);
}

