namespace ACBindings.Internal;


/// <summary>Contains metadata for a localized string token: identifier, table reference, variable mappings, literal value, override flag, English text, and comment. Facilitates dynamic string resolution and localization within the application.</summary>
/// <remarks>Serves as a data structure in the resource management subsystem to support internationalization, runtime formatting, and developer annotations.</remarks>
public unsafe struct StringInfo : System.IDisposable
{
    // Child Types
    // StringInfo::StringInfo_Override_Flag
    public enum StringInfo_Override_Flag : byte
    {
        SI_NONE = 0x0,
        SI_LITERAL = 0x1,
        SI_AUTOGEN = 0x2
    }

    // Members
    public ACBindings.Internal.PStringBase__sbyte m_strToken;
    public uint m_stringID;
    public ACBindings.Internal.IDClass____tagDataID m_tableID;
    public ACBindings.Internal.HashTable__uint___StringInfoData_ptr m_variables;
    public ACBindings.Internal.PStringBase__ushort m_LiteralValue;
    public byte m_Override;
    public ACBindings.Internal.PStringBase__sbyte m_strEnglish;
    public ACBindings.Internal.PStringBase__sbyte m_strComment;

    // Generated Constructor
    public StringInfo() {
        _ConstructorInternal();
    }
    public StringInfo(ACBindings.Internal.StringInfo* copy) {
        _ConstructorInternal(copy);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Maps an enumeration value to its associated data ID, storing it in <c>m_tableID</c> if the ID corresponds to a divine type; otherwise sets <c>m_tableID</c> to an invalid placeholder.
    /// <code>Offset: 0x0042C980
    /// void __thiscall StringInfo::SetTableEnum(StringInfo*,int)</code>
    /// </summary>
    /// <param name="strtableEnum">Enumeration identifying a string table entry.</param>
    public void SetTableEnum(int strtableEnum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StringInfo, int, void>)0x0042C980)(ref this, strtableEnum);

    /// <summary>Assigns the supplied string identifier and determines the corresponding table ID from the provided enumeration; if the derived database ID matches type 37 it stores that ID in m_tableID, otherwise marks m_tableID as invalid.
    /// <code>Offset: 0x0042C9C0
    /// void __thiscall StringInfo::SetStringIDandTableEnum(StringInfo*,unsigned int,int)</code>
    /// </summary>
    /// <param name="stringID">The numeric identifier for the string.</param>
    /// <param name="strtableEnum">Enumeration value used to look up the related database ID.</param>
    public void SetStringIDandTableEnum(uint stringID, int strtableEnum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StringInfo, uint, int, void>)0x0042C9C0)(ref this, stringID, strtableEnum);

    /// <summary>Sets the string identifier and validates the table identifier for the StringInfo instance, storing a fallback when validation fails.
    /// <code>Offset: 0x0042CA10
    /// int __thiscall StringInfo::SetStringIDandTableID(_DWORD*,int,int)</code>
    /// </summary>
    /// <param name="a2">The new string ID to assign to m_stringID.</param>
    /// <param name="a3">Candidate table ID to validate via MasterDBMap::DivineType.</param>
    /// <returns>The type indicator returned by MasterDBMap::DivineType, which also determines whether the provided table ID is accepted.</returns>
    public int SetStringIDandTableID(int a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StringInfo, int, int, int>)0x0042CA10)(ref this, a2, a3);

    /// <summary>Checks whether this StringInfo instance refers to a valid string table file and updates the supplied reference‑counted handle accordingly.
    /// <code>Offset: 0x0042CA50
    /// bool __thiscall StringInfo::InqStringTableFile(_DWORD*,volatile LONG**)</code>
    /// </summary>
    /// <param name="a2">A reference to a pointer that will be set to point at the refcounted file path of this string’s table. The function adjusts reference counts for both the previous and new handles.</param>
    /// <returns>True if the string has an associated table file; otherwise false (e.g., when the string ID is invalid or no table file exists).</returns>
    public byte InqStringTableFile(int** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StringInfo, int**, byte>)0x0042CA50)(ref this, a2);

    /// <summary>Sets the literal value for this StringInfo instance, updating or clearing the stored string while managing reference counts.
    /// <code>Offset: 0x0042CBE0
    /// int __thiscall StringInfo::SetLiteralValue(int,int*,wchar_t*)</code>
    /// </summary>
    /// <param name="this">Pointer to the current StringInfo object.</param>
    /// <param name="a2">Address of an integer that identifies the new literal ID when a3 is null; otherwise holds a placeholder used during escaping.</param>
    /// <param name="a3">Wide‑character string containing the new literal value. If null, the existing literal is cleared or replaced by the ID in a2.</param>
    /// <returns>After setting the literal, returns the updated reference count of the affected string (zero if it was deallocated).</returns>
    public int SetLiteralValue(int* a2, System.IntPtr a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StringInfo, int*, System.IntPtr, int>)0x0042CBE0)(ref this, a2, a3);

    /// <summary>Retrieves the literal string for this instance, applying meta‑letter stripping and unescaping on the supplied source text while managing reference counts.
    /// <code>Offset: 0x0042CCB0
    /// _DWORD* __thiscall StringInfo::GetLiteralValue(_DWORD*,_DWORD*,int)</code>
    /// </summary>
    /// <param name="output">Pointer that receives the resulting wide‑character string.</param>
    /// <param name="sourceText">Source wide‑character string to process; may contain metadata characters.</param>
    /// <returns>Same as output, a pointer to the processed string.</returns>
    public int* GetLiteralValue(int* a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StringInfo, int*, int, int*>)0x0042CCB0)(ref this, a2, a3);

    /// <summary>Determines whether a StringInfo object refers to a valid entry in its associated string table, optionally validating referenced child properties.
    /// <code>Offset: 0x0042CE00
    /// bool __thiscall StringInfo::IsValid(StringInfo*,bool)</code>
    /// </summary>
    /// <param name="bValidateChildren">If true, recursively verifies all property objects stored in the m_variables hash table; otherwise only checks the primary string reference.</param>
    /// <returns>True when the string ID and table are valid (or overridden); false if missing or invalid. Overrides set to 1 or 2 cause immediate success while a zero or invalid table ID results in failure.</returns>
    public byte IsValid(byte bValidateChildren) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StringInfo, byte, byte>)0x0042CE00)(ref this, bValidateChildren);

    /// <summary>Collects all QualifiedDataID entries associated with this StringInfo instance, including the base table ID (unless overridden) and those of its variables, adding them to the supplied array.
    /// <code>Offset: 0x0042CED0
    /// void __thiscall StringInfo::GetSubDataIDs(StringInfo*,QualifiedDataIDArray*)</code>
    /// </summary>
    /// <param name="id_array">Array to receive the collected data IDs.</param>
    public void GetSubDataIDs(ACBindings.Internal.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StringInfo, ACBindings.Internal.QualifiedDataIDArray*, void>)0x0042CED0)(ref this, id_array);

    /// <summary>Recursively collects sub‑private data identifiers for this StringInfo instance into the supplied QualifiedDataIDArray, optionally including the string table entry when a3 matches the instance’s primary ID.
    /// <code>Offset: 0x0042CF60
    /// int* __thiscall StringInfo::GetSubPrivateIDs(unsigned int*,QualifiedDataIDArray*,int)</code>
    /// </summary>
    /// <param name="a2">The array that will receive the collected QualifiedDataID entries.</param>
    /// <param name="a3">Identifier used for filtering; if equal to this instance’s primary ID, triggers inclusion of the corresponding string table entry.</param>
    public int* GetSubPrivateIDs(ACBindings.Internal.QualifiedDataIDArray* a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StringInfo, ACBindings.Internal.QualifiedDataIDArray*, int, int*>)0x0042CF60)(ref this, a2, a3);

    /// <summary>Parses a file node representing a string definition, extracting token, English text, comment, and literal value into the StringInfo object while performing validation checks.
    /// <code>Offset: 0x0042D020
    /// bool __thiscall StringInfo::FromFileNode(StringInfo*,const PFileNode*)</code>
    /// </summary>
    /// <param name="node">The PFileNode to parse.</param>
    /// <returns>True if parsing was successful; otherwise false.</returns>
    public byte FromFileNode(ACBindings.Internal.PFileNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StringInfo, ACBindings.Internal.PFileNode*, byte>)0x0042D020)(ref this, node);

    /// <summary>Cleans up all variable entries stored in the StringInfo object's hash table, freeing associated resources and resetting internal state.
    /// <code>Offset: 0x0042DAF0
    /// void __thiscall StringInfo::ClearVars(StringInfo*)</code>
    /// </summary>
    public void ClearVars() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StringInfo, void>)0x0042DAF0)(ref this);

    /// <summary>Adds or updates a variable entry in the StringInfo instance, associating the provided StringInfoData with its identifier while ensuring any previous entry with that ID is removed.
    /// <code>Offset: 0x0042DB60
    /// void __thiscall StringInfo::AddVar(StringInfo*,StringInfoData*)</code>
    /// </summary>
    /// <param name="i_pcNewData">Pointer to a StringInfoData object containing the variable's type and unique identifier; if non‑null, the data will be stored in the internal hash table under its ID.</param>
    public void AddVar(ACBindings.Internal.StringInfoData* i_pcNewData) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StringInfo, ACBindings.Internal.StringInfoData*, void>)0x0042DB60)(ref this, i_pcNewData);

    /// <summary>Initializes a StringInfo object with default values by assigning shared null string buffers, resetting identifiers to zero or invalid values, and constructing an empty hash table for variables. Reference counts for the shared buffers are incremented accordingly.
    /// <code>Offset: 0x0042DC80
    /// void __thiscall StringInfo::StringInfo(StringInfo*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StringInfo, void>)0x0042DC80)(ref this);

    /// <summary>Reinitializes a StringInfo instance by clearing identifiers, resetting all string members to the null buffer, releasing any reference counts, and clearing its variable table.
    /// <code>Offset: 0x0042DD10
    /// void __thiscall StringInfo::Reset(StringInfo*)</code>
    /// </summary>
    public void Reset() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StringInfo, void>)0x0042DD10)(ref this);

    /// <summary>Adds an integer variable identified by <paramref name="varID"/> with value <paramref name="varValue"/> to the StringInfo's variables collection.
    /// <code>Offset: 0x0042E000
    /// void __thiscall StringInfo::AddVariable_Int(StringInfo*,unsigned int,__int64)</code>
    /// </summary>
    /// <param name="varID">The identifier for the variable to add or update.</param>
    /// <param name="varValue">The 64‑bit integer value associated with the variable.</param>
    public void AddVariable_Int(uint varID, long varValue) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StringInfo, uint, long, void>)0x0042E000)(ref this, varID, varValue);

    /// <summary>Adds an unsigned 64-bit integer variable identified by varID to the StringInfo instance, storing it in the internal hash table.
    /// <code>Offset: 0x0042E040
    /// void __thiscall StringInfo::AddVariable_UInt(StringInfo*,unsigned int,unsigned __int64)</code>
    /// </summary>
    /// <param name="varID">The identifier of the variable to add or update.</param>
    /// <param name="varValue">The 64‑bit unsigned value associated with the variable.</param>
    public void AddVariable_UInt(uint varID, ulong varValue) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StringInfo, uint, ulong, void>)0x0042E040)(ref this, varID, varValue);

    /// <summary>Adds a floating‑point variable identified by varID to the string's variable table, storing the supplied value and precision.
    /// <code>Offset: 0x0042E080
    /// void __thiscall StringInfo::AddVariable_Float(StringInfo*,unsigned int,long double,unsigned __int16)</code>
    /// </summary>
    /// <param name="varID">Identifier for the variable to be added.</param>
    /// <param name="varValue">Numeric value of the variable.</param>
    /// <param name="precision">Number of decimal places to store for the variable.</param>
    public void AddVariable_Float(uint varID, double varValue, ushort precision) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StringInfo, uint, double, ushort, void>)0x0042E080)(ref this, varID, varValue, precision);

    /// <summary>Serializes a StringInfo object to or from an Archive, managing overrides and optional string fields based on program type and archive flags.
    /// <code>Offset: 0x0042E0D0
    /// void __thiscall StringInfo::Serialize(StringInfo*,Archive*)</code>
    /// </summary>
    /// <param name="this">The StringInfo instance to serialize.</param>
    /// <param name="rArchive">The Archive used for reading or writing the object's data.</param>
    public void Serialize(ACBindings.Internal.Archive* rArchive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StringInfo, ACBindings.Internal.Archive*, void>)0x0042E0D0)(ref this, rArchive);

    /// <summary>Retrieves the localized string associated with this StringInfo instance and writes it into the supplied wide‑character buffer. The returned value indicates success or the type of failure encountered.
    /// <code>Offset: 0x0042E240
    /// int __thiscall StringInfo::InqStringInternal(int,wchar_t*,char)</code>
    /// </summary>
    /// <param name="Source">Pointer to a wide‑character buffer that receives the resolved string. The buffer must be large enough to hold the result.</param>
    /// <param name="a3">If zero, removes meta‑language markers from the retrieved string before returning it; non‑zero leaves them untouched.</param>
    /// <returns>Zero on success; a positive value indicates an error (e.g., missing table or invalid token).</returns>
    public int InqStringInternal(System.IntPtr Source, sbyte a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StringInfo, System.IntPtr, sbyte, int>)0x0042E240)(ref this, Source, a3);

    /// <summary>Creates a new StringInfo by initializing internal buffers and then copying the contents of an existing instance.
    /// <code>Offset: 0x0042E510
    /// void __thiscall StringInfo::StringInfo(StringInfo*,const StringInfo*)</code>
    /// </summary>
    /// <param name="copy">Source StringInfo whose data will be copied into the new object.</param>
    public void _ConstructorInternal(ACBindings.Internal.StringInfo* copy) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StringInfo, ACBindings.Internal.StringInfo*, void>)0x0042E510)(ref this, copy);

    /// <summary>Destroys a StringInfo instance, releasing reference-counted string buffers, clearing the variable hash table, and freeing any allocated bucket storage.
    /// <code>Offset: 0x0042E590
    /// void __thiscall StringInfo::~StringInfo(StringInfo*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StringInfo, void>)0x0042E590)(ref this);

    /// <summary>Adds a copy of another StringInfo instance as a variable entry identified by varID to the current StringInfo object.
    /// <code>Offset: 0x0042E660
    /// void __thiscall StringInfo::AddVariable_StringInfo(StringInfo*,unsigned int,const StringInfo*)</code>
    /// </summary>
    /// <param name="varID">Identifier for the new variable entry.</param>
    /// <param name="si">StringInfo instance whose data will be copied into the new variable.</param>
    public void AddVariable_StringInfo(uint varID, ACBindings.Internal.StringInfo* si) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StringInfo, uint, ACBindings.Internal.StringInfo*, void>)0x0042E660)(ref this, varID, si);

    /// <summary>
    /// Retrieves a localized string for this StringInfo instance. If an internal lookup succeeds it returns 0; otherwise it unescapes the stored literal identified by a3 into buffer a2 and returns 1.
    /// 
    /// <code>Offset: 0x0042E6B0
    /// char __thiscall StringInfo::InqString(void*,wchar_t*,int)</code>
    /// </summary>
    /// <param name="a2">Wide‑string buffer that receives the resulting text.</param>
    /// <param name="a3">Integer identifier or literal used to locate the string; may be updated during unescaping.</param>
    /// <returns>Zero if an internal lookup already succeeded; one after successful unescape and processing.</returns>
    public sbyte InqString(System.IntPtr a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StringInfo, System.IntPtr, int, sbyte>)0x0042E6B0)(ref this, a2, a3);

    /// <summary>Builds a wide‑character string that represents the StringInfo instance for logging purposes, wrapping the rendered content in parentheses or reporting an error if rendering fails.
    /// <code>Offset: 0x0042E740
    /// int* __thiscall StringInfo::GetLogString(_DWORD*,int*,wchar_t*)</code>
    /// </summary>
    /// <param name="a2">Pointer to store the address of the constructed log string buffer.</param>
    /// <param name="Destination">Scratch buffer used internally during construction; callers need not provide a valid value.</param>
    /// <returns>Same pointer as passed in via a2, pointing to the stored log string.</returns>
    public int* GetLogString(int* a2, System.IntPtr Destination) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StringInfo, int*, System.IntPtr, int*>)0x0042E740)(ref this, a2, Destination);

    /// <summary>Adds a string variable identified by i_eVarID to this StringInfo instance using the supplied string value, handling reference counting and invoking cleanup if necessary.
    /// <code>Offset: 0x0042E8E0
    /// LONG __thiscall StringInfo::AddVariable_String(StringInfo*,unsigned int,int)</code>
    /// </summary>
    /// <param name="i_eVarID">Identifier of the variable to add.</param>
    /// <param name="a3">Reference‑counted string containing the literal value for the new variable; its reference count is decremented by this method.</param>
    /// <returns>The updated reference count after decrementing a3's count. If the count reaches zero, a cleanup callback may be invoked and its result returned instead of 0.</returns>
    public int AddVariable_String(uint i_eVarID, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StringInfo, uint, int, int>)0x0042E8E0)(ref this, i_eVarID, a3);

    /// <summary>Retrieves a string from this <c>StringInfo</c> instance based on the supplied identifier and writes a pointer to its data into the output parameter.
    /// <code>Offset: 0x0042E980
    /// _DWORD* __thiscall StringInfo::GetString(void*,_DWORD*,int)</code>
    /// </summary>
    /// <param name="a2">Output argument that receives a pointer to the requested string's buffer.</param>
    /// <param name="a3">Identifier or index of the desired string within this <c>StringInfo</c>.</param>
    /// <returns>The same pointer passed in as <c>a2</c>, facilitating call chaining.</returns>
    public int* GetString(int* a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StringInfo, int*, int, int*>)0x0042E980)(ref this, a2, a3);

    /// <summary>Adds a string variable to the StringInfo instance and updates an associated reference counter. If the counter reaches zero, invokes an optional cleanup callback stored in the resource.
    /// <code>Offset: 0x0042E9F0
    /// LONG __thiscall StringInfo::AddVariable_String_1(StringInfo*,unsigned int,int)</code>
    /// </summary>
    /// <param name="a2">Identifier of the string variable to add.</param>
    /// <param name="a3">Pointer to a reference‑counted resource whose counter is decremented after adding the variable; if the counter drops to zero and the pointer is non‑null, a cleanup function may be called.</param>
    /// <returns>Updated reference count after decrementing; if a cleanup callback was invoked, returns its result instead.</returns>
    public int AddVariable_String_1(uint a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StringInfo, uint, int, int>)0x0042E9F0)(ref this, a2, a3);
}

