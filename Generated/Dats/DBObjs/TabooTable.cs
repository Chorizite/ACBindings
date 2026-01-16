namespace ACBindings.Internal;


/// <summary>Maintains audience‑specific taboo word lists and supplies methods to verify text against those restrictions.</summary>
public unsafe struct TabooTable
{
    // Base Classes
    public ACBindings.Internal.DBObj BaseClass_DBObj; // ACBindings.Internal.DBObj

    // Child Types
    public unsafe struct TabooTable_vtbl
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
    public ACBindings.Internal.HashTable__uint___HashTable__uint___List___PStringBase__sbyte m_audienceToBannedPatterns;

    // Methods

    /// <summary>Allocates memory for a new TabooTable instance, constructs it as a DBObj, initializes its hash table of banned patterns, and returns the constructed object.
    /// <code>Offset: 0x004F7C80
    /// DBObj* __cdecl TabooTable::Allocator()</code>
    /// </summary>
    /// <returns>A pointer to the newly allocated TabooTable/DBObj object, or nullptr if allocation fails.</returns>
    public static ACBindings.Internal.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.DBObj*>)0x004F7C80)();

    /// <summary>Creates a filtered copy of <paramref name="baseStr"/> into <paramref name="strOut"/>, removing non‑alphabetic characters when <paramref name="chkType"/> = 2 or whitespace when <paramref name="chkType"/> = 3; otherwise copies the string unchanged. Returns true on success and false if inputs are invalid.
    /// <code>Offset: 0x00682570
    /// bool __thiscall TabooTable::CreateCheckString(TabooTable*,unsigned int,const char*,unsigned int,char*)</code>
    /// </summary>
    /// <param name="chkType">Specifies the filtering mode: 2 removes non‑alphabetic characters, 3 removes whitespace, any other value leaves all characters intact.</param>
    /// <param name="baseStr">Source string to filter.</param>
    /// <param name="baseStrLength">Number of characters in <paramref name="baseStr"/>; must be greater than zero for processing.</param>
    /// <param name="strOut">Buffer that receives the resulting null‑terminated string. Must be large enough to hold the filtered data.</param>
    /// <returns>True if the operation succeeds, false if any argument is invalid or zero length.</returns>
    public byte CreateCheckString(uint chkType, sbyte* baseStr, uint baseStrLength, sbyte* strOut) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TabooTable, uint, sbyte*, uint, sbyte*, byte>)0x00682570)(ref this, chkType, baseStr, baseStrLength, strOut);

    /// <summary>Determines whether a given string conforms to a filter pattern that may include '*' as a wildcard matching zero or more characters.
    /// <code>Offset: 0x00682600
    /// bool __thiscall TabooTable::StringMatchesFilter(TabooTable*,const char*,const char*)</code>
    /// </summary>
    /// <param name="string">The input string to test against the filter.</param>
    /// <param name="filter">A pattern containing optional '*' wildcards.</param>
    /// <returns>True if the string matches the filter; otherwise, false.</returns>
    public byte StringMatchesFilter(sbyte* string_, sbyte* filter) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TabooTable, sbyte*, sbyte*, byte>)0x00682600)(ref this, string_, filter);

    /// <summary>Examines a string against banned patterns for the specified audience and censor type, optionally returning the matched phrase.
    /// <code>Offset: 0x00683050
    /// int __thiscall TabooTable::CheckCensors(TabooTable*,char**,unsigned int,unsigned int,const char**)</code>
    /// </summary>
    /// <param name="this">TabooTable instance containing censorship rules.</param>
    /// <param name="a2">Pointer to the string to check; may be updated internally for reference counting but not replaced.</param>
    /// <param name="a3">Audience identifier whose pattern set is queried.</param>
    /// <param name="chkType">Censoring rule type used when creating the check string.</param>
    /// <param name="a5">Output parameter that, if a match occurs, will point to the banned phrase found.</param>
    /// <returns>Zero if no censorship applies; non‑zero codes indicate errors or censorship matches (e.g., 2 for invalid input, 3–6 for different match types).</returns>
    public int CheckCensors(sbyte** a2, uint a3, uint chkType, sbyte** a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TabooTable, sbyte**, uint, uint, sbyte**, int>)0x00683050)(ref this, a2, a3, chkType, a5);

    /// <summary>Evaluates a given string against the taboo table, updating censorship flags and returning the resulting status.
    /// <code>Offset: 0x00683350
    /// int __thiscall TabooTable::CheckCensorsW(TabooTable*,int*,unsigned int,int,int*)</code>
    /// </summary>
    /// <param name="a2">Pointer to the input string object that is subject to censorship checking.</param>
    /// <param name="a3">Size or length of the string data being processed.</param>
    /// <param name="a4">Current censorship flag that may be modified during the check.</param>
    /// <param name="a5">Output parameter receiving updated state information after processing.</param>
    /// <returns>Updated censorship flag value reflecting whether the input contains taboo content.</returns>
    public int CheckCensorsW(int* a2, uint a3, int a4, int* a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TabooTable, int*, uint, int, int*, int>)0x00683350)(ref this, a2, a3, a4, a5);

    /// <summary>Serializes the TabooTable's data, including its audience‑to‑banned‑patterns mapping, to or from an Archive.
    /// <code>Offset: 0x006839F0
    /// void __thiscall TabooTable::Serialize(TabooTable*,Archive*)</code>
    /// </summary>
    /// <param name="rArchive">The Archive object used for reading or writing the table’s state.</param>
    public void Serialize(ACBindings.Internal.Archive* rArchive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TabooTable, ACBindings.Internal.Archive*, void>)0x006839F0)(ref this, rArchive);
}

