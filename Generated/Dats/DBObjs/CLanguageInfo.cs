namespace ACBindings.Internal;


/// <summary>Holds language‑specific configuration data, including numeric formatting rules, number words, UI text for players and treasures, and IME settings. Derives from DBObj so it can be loaded, serialized, and reference‑counted within the application’s database system.</summary>
public unsafe struct CLanguageInfo : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.DBObj BaseClass_DBObj; // ACBindings.Internal.DBObj

    // Child Types
    public unsafe struct CLanguageInfo_vtbl
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
    public int version;
    public ushort base_;
    public ushort numDecimalDigits;
    public byte leadingZero;
    public ushort groupingSize;
    public ACBindings.Internal.PStringBase__ushort numerals;
    public ACBindings.Internal.PStringBase__ushort decimalSeperator;
    public ACBindings.Internal.PStringBase__ushort groupingSeperator;
    public ACBindings.Internal.PStringBase__ushort negativeNumberFormat;
    public byte isZeroSingular;
    public byte isOneSingular;
    public byte isNegativeOneSingular;
    public byte isTwoOrMoreSingular;
    public byte isNegativeTwoOrLessSingular;
    public ACBindings.Internal.PStringBase__ushort treasurePrefixLetters;
    public ACBindings.Internal.PStringBase__ushort treasureMiddleLetters;
    public ACBindings.Internal.PStringBase__ushort treasureSuffixLetters;
    public ACBindings.Internal.PStringBase__ushort malePlayerLetters;
    public ACBindings.Internal.PStringBase__ushort femalePlayerLetters;
    public uint m_ImeEnabledSetting;
    public uint m_symbolColor;
    public uint m_symbolColorText;
    public uint m_symbolHeight;
    public uint m_symbolTranslucence;
    public uint m_symbolPlacement;
    public uint m_candColorBase;
    public uint m_candColorBorder;
    public uint m_candColorText;
    public uint m_compColorInput;
    public uint m_compColorTargetConv;
    public uint m_compColorConverted;
    public uint m_compColorTargetNotConv;
    public uint m_compColorInputErr;
    public uint m_compTranslucence;
    public uint m_compColorText;
    public uint m_otherIME;
    public int m_wordWrapOnSpace;
    public ACBindings.Internal.PStringBase__ushort m_additionalSettings;
    public uint m_additionalFlags;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Releases all dynamically allocated strings and other resources held by a CLanguageInfo instance, then destroys its base DBObj component.
    /// <code>Offset: 0x00422380
    /// void __thiscall CLanguageInfo::~CLanguageInfo(CLanguageInfo*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLanguageInfo, void>)0x00422380)(ref this);

    /// <summary>Allocates a new CLanguageInfo object, initializing all string members to empty buffers and setting the virtual table.
    /// <code>Offset: 0x004224D0
    /// DBObj* __cdecl CLanguageInfo::Allocator()</code>
    /// </summary>
    /// <returns>A pointer to the newly constructed DBObj base of the allocated CLanguageInfo, or nullptr if memory allocation fails.</returns>
    public static ACBindings.Internal.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.DBObj*>)0x004224D0)();

    /// <summary>Serializes or deserializes the CLanguageInfo object to an Archive, applying proper alignment and reading or writing each field based on archive flags.
    /// <code>Offset: 0x00422870
    /// void __thiscall CLanguageInfo::Serialize(CLanguageInfo*,Archive*)</code>
    /// </summary>
    /// <param name="io_archive">Archive used for reading from or writing to; determines whether fields are serialized or deserialized.</param>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLanguageInfo, ACBindings.Internal.Archive*, void>)0x00422870)(ref this, io_archive);
}

