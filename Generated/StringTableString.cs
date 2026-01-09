namespace ACBindings;

// StringTableString
public unsafe struct StringTableString : System.IDisposable
{
    // Members
    public ACBindings.IDClass___tagDataID m_table;
    public ACBindings.PStringBase__sbyte m_name;
    public ACBindings.SmartArray__PStringBase__ushort m_comments;
    public ACBindings.SmartArray__PStringBase__ushort m_strings;
    public ACBindings.SmartArray__uint m_variables;
    public ACBindings.SmartArray__PStringBase__ushort m_varNames;
    public uint m_numWords;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall StringTableString::~StringTableString(StringTableString*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.StringTableString, void>)0x0042FD70)(ref this);
    // bool __thiscall StringTableString::IsVarNameTableWorthPacking(StringTableString*)
    public byte IsVarNameTableWorthPacking() => ((delegate* unmanaged[Thiscall]<ref ACBindings.StringTableString, byte>)0x0042FE10)(ref this);
    // void __thiscall StringTableString::Serialize(StringTableString*,Archive*)
    public void Serialize(ACBindings.Archive* rArchive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.StringTableString, ACBindings.Archive*, void>)0x00430620)(ref this, rArchive);
}

