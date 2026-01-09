namespace ACBindings;

// CLanguageInfo
public unsafe struct CLanguageInfo : System.IDisposable
{
    // Base Classes
    public ACBindings.DBObj BaseClass_DBObj; // ACBindings.DBObj

    // Child Types
    // CLanguageInfo_vtbl
    public unsafe struct CLanguageInfo_vtbl
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
    public int version;
    public ushort base_;
    public ushort numDecimalDigits;
    public byte leadingZero;
    public ushort groupingSize;
    public ACBindings.PStringBase__ushort numerals;
    public ACBindings.PStringBase__ushort decimalSeperator;
    public ACBindings.PStringBase__ushort groupingSeperator;
    public ACBindings.PStringBase__ushort negativeNumberFormat;
    public byte isZeroSingular;
    public byte isOneSingular;
    public byte isNegativeOneSingular;
    public byte isTwoOrMoreSingular;
    public byte isNegativeTwoOrLessSingular;
    public ACBindings.PStringBase__ushort treasurePrefixLetters;
    public ACBindings.PStringBase__ushort treasureMiddleLetters;
    public ACBindings.PStringBase__ushort treasureSuffixLetters;
    public ACBindings.PStringBase__ushort malePlayerLetters;
    public ACBindings.PStringBase__ushort femalePlayerLetters;
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
    public ACBindings.PStringBase__ushort m_additionalSettings;
    public uint m_additionalFlags;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall CLanguageInfo::~CLanguageInfo(CLanguageInfo*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLanguageInfo, void>)0x00422380)(ref this);
    // DBObj* __cdecl CLanguageInfo::Allocator()
    public static ACBindings.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.DBObj*>)0x004224D0)();
    // void __thiscall CLanguageInfo::Serialize(CLanguageInfo*,Archive*)
    public void Serialize(ACBindings.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLanguageInfo, ACBindings.Archive*, void>)0x00422870)(ref this, io_archive);
}

