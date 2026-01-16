namespace ACBindings.Internal;


/// <summary>Represents a performance monitoring counter, storing its type and language‑specific names and help strings.</summary>
public unsafe struct PerfMonCounterInfo : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.ReferenceCountTemplate BaseClass_ReferenceCountTemplate; // ACBindings.Internal.ReferenceCountTemplate

    // Child Types
    public unsafe struct PerfMonCounterInfo_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.PerfMonCounterInfo*, void> PerfMonCounterInfo_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.PerfMonCounterInfo*, long> GetValueAsInt64; // function pointer
        public System.IntPtr LookupByLanguage;

        // Methods
    }
    // PerfMonCounterInfo::EPerfCounterType
    public enum EPerfCounterType : byte
    {
        NORMAL = 0x0,
        NORMAL_HEX = 0x1,
        PER_SEC = 0x2
    }

    /// <summary>Holds the language ID along with localized name and help text for a performance monitor counter.</summary>
    public unsafe struct PerfMonCounterNameHelp : System.IDisposable
    {
        // Members
        public ushort m_languageID;
        public ACBindings.Internal.PStringBase__ushort m_name;
        public ACBindings.Internal.PStringBase__ushort m_help;

        // Generated Dispose
        public void Dispose() {
            _DestructorInternal();
        }

        // Methods

        /// <summary>Releases resources used by a PerfMonCounterNameHelp object, decrementing reference counts for its name and help strings and freeing the associated memory when no longer referenced.
        /// <code>Offset: 0x00541F40
        /// void __thiscall PerfMonCounterInfo::PerfMonCounterNameHelp::~PerfMonCounterNameHelp(PerfMonCounterInfo::PerfMonCounterNameHelp*)</code>
        /// </summary>
        public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PerfMonCounterInfo.PerfMonCounterNameHelp, void>)0x00541F40)(ref this);
    }

    // Members
    public uint m_CounterType;
    public ACBindings.Internal.List___PerfMonCounterInfo_PerfMonCounterNameHelp m_CounterNamesList;
    public byte m_fCounterExistedPreviously;

    // Generated Constructor
    public PerfMonCounterInfo(int a2, int* a3, int* a4, short a5) {
        _ConstructorInternal(a2, a3, a4, a5);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Destroys a PerfMonCounterInfo instance, clearing its counter names list and resetting related resources.
    /// <code>Offset: 0x00542300
    /// void __thiscall PerfMonCounterInfo::~PerfMonCounterInfo(PerfMonCounterInfo*)</code>
    /// </summary>
    /// <param name="this">Pointer to the object that is being destructed.</param>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PerfMonCounterInfo, void>)0x00542300)(ref this);

    /// <summary>Locates an existing performance counter based on supplied name components and returns its identifier.
    /// <code>Offset: 0x00683A80
    /// int __cdecl PerfMonCounterInfo::LookupExistingCounterByName(const wchar_t**,int)</code>
    /// </summary>
    /// <param name="a1">Array of wide-character strings that identify the counter.</param>
    /// <param name="a2">Number of elements in the name array.</param>
    /// <returns>Identifier of the found counter, or 0 if no matching counter exists or the manager is unavailable.</returns>
    public static int LookupExistingCounterByName(System.IntPtr a1, int a2) => ((delegate* unmanaged[Cdecl]<System.IntPtr, int, int>)0x00683A80)(a1, a2);

    /// <summary>Retrieves the first counter name associated with this performance monitor counter info, providing both the string pointer and its length.
    /// <code>Offset: 0x00683AF0
    /// void** __thiscall PerfMonCounterInfo::GetFirstName(_DWORD*,void**,_WORD*)</code>
    /// </summary>
    /// <param name="a2">Receives a pointer to the first name string. The caller should manage the reference count of the returned object.</param>
    /// <param name="a3">Receives the length (or identifier) of the first name string as a 16‑bit value.</param>
    /// <returns>Returns the same pointer that was assigned to *a2, allowing convenient chaining or direct use.</returns>
    public void** GetFirstName(void** a2, System.IntPtr a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PerfMonCounterInfo, void**, System.IntPtr, void**>)0x00683AF0)(ref this, a2, a3);

    /// <summary>Retrieves counter name and help information for the specified language.
    /// <code>Offset: 0x00683B40
    /// char __thiscall PerfMonCounterInfo::LookupByLanguage(_DWORD*,unsigned __int16,void**)</code>
    /// </summary>
    /// <param name="languageId">Identifier of the target language.</param>
    /// <param name="outputInfo">Receives a pointer to the counter information structure if found.</param>
    /// <returns>True if the counter exists for the given language; otherwise, false.</returns>
    public sbyte LookupByLanguage(ushort a2, void** a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PerfMonCounterInfo, ushort, void**, sbyte>)0x00683B40)(ref this, a2, a3);

    /// <summary>Adds a language‑specific name and help entry to the counter list if one does not already exist, maintaining the list in sorted order.
    /// <code>Offset: 0x00683DA0
    /// char __thiscall PerfMonCounterInfo::AddLanguageNameAndHelp(_DWORD*,__int16,int*,int*)</code>
    /// </summary>
    /// <param name="a2">Language identifier for which the counter name/help should be added.</param>
    /// <param name="a3">Pointer to a reference‑counted object associated with the counter (e.g., a name string); its reference count is incremented on entry and decremented before exit.</param>
    /// <param name="a4">Pointer to another reference‑counted object related to the counter (e.g., help text); its reference count undergoes the same management as a3.</param>
    /// <returns>Non‑zero if a new entry was inserted; zero if an equivalent language entry already existed.</returns>
    public sbyte AddLanguageNameAndHelp(short a2, int* a3, int* a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PerfMonCounterInfo, short, int*, int*, sbyte>)0x00683DA0)(ref this, a2, a3, a4);

    /// <summary>Initializes a PerfMonCounterInfo object, setting its reference count, determining counter type from the supplied flag, adding language‑specific names and help text, and registering the counter with the global manager if it is not already present.
    /// <code>Offset: 0x00683E60
    /// PerfMonCounterInfo* __thiscall PerfMonCounterInfo::PerfMonCounterInfo(PerfMonCounterInfo*,int,int*,int*,__int16)</code>
    /// </summary>
    /// <param name="counter">The instance of PerfMonCounterInfo to be initialized.</param>
    /// <param name="a2">Specifies a preset counter type; values 1 and 2 override the default type.</param>
    /// <param name="a3">Pointer to an array of language‑specific names associated with the counter.</param>
    /// <param name="a4">Pointer to an array of help strings corresponding to each language entry.</param>
    /// <param name="a5">Language identifier used when adding names and help text.</param>
    /// <returns>Returns the initialized PerfMonCounterInfo pointer.</returns>
    public ACBindings.Internal.PerfMonCounterInfo* _ConstructorInternal(int a2, int* a3, int* a4, short a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PerfMonCounterInfo, int, int*, int*, short, ACBindings.Internal.PerfMonCounterInfo*>)0x00683E60)(ref this, a2, a3, a4, a5);
}

