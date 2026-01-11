namespace ACBindings.Internal;

public unsafe struct StringTableString : System.IDisposable
{
    // Members
    public ACBindings.Internal.IDClass____tagDataID m_table;
    public ACBindings.Internal.PStringBase__sbyte m_name;
    public ACBindings.Internal.SmartArray___PStringBase__ushort m_comments;
    public ACBindings.Internal.SmartArray___PStringBase__ushort m_strings;
    public ACBindings.Internal.SmartArray__uint m_variables;
    public ACBindings.Internal.SmartArray___PStringBase__ushort m_varNames;
    public uint m_numWords;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Releases all dynamically allocated resources held by the StringTableString, including variable names, variables, strings, comments, and the name’s character buffer.
    /// <code>Offset: 0x0042FD70
    /// void __thiscall StringTableString::~StringTableString(StringTableString*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StringTableString, void>)0x0042FD70)(ref this);

    /// <summary>Checks whether the variable name list contains two or more entries that match any of the predefined prefixes (“PRE”, “NAME”, “MID”, “POST”).
    /// <code>Offset: 0x0042FE10
    /// bool __thiscall StringTableString::IsVarNameTableWorthPacking(StringTableString*)</code>
    /// </summary>
    /// <returns>True if at least two matches are found; otherwise, false.</returns>
    public byte IsVarNameTableWorthPacking() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StringTableString, byte>)0x0042FE10)(ref this);

    /// <summary>Serializes a string table entry to or from an archive, storing its identifier, associated strings, variable values, and optionally the variable name list when packing is warranted.
    /// <code>Offset: 0x00430620
    /// void __thiscall StringTableString::Serialize(StringTableString*,Archive*)</code>
    /// </summary>
    /// <param name="this">The StringTableString instance being processed.</param>
    /// <param name="rArchive">The archive used for reading or writing the serialized data.</param>
    public void Serialize(ACBindings.Internal.Archive* rArchive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StringTableString, ACBindings.Internal.Archive*, void>)0x00430620)(ref this, rArchive);
}

