namespace ACBindings.Internal;


/// <summary>Represents a table of character titles, containing a default display title ID and a list of additional title IDs for lookup and serialization purposes.</summary>
public unsafe struct CharacterTitleTable
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct CharacterTitleTable_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CharacterTitleTable*, void> CharacterTitleTable_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CharacterTitleTable*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CharacterTitleTable*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CharacterTitleTable*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public uint mDisplayTitle;
    public ACBindings.Internal.PList__uint mTitleList;

    // Generated Constructor
    public CharacterTitleTable() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>Returns the total number of bytes required to pack the CharacterTitleTable for transmission or storage, accounting for its internal title list and associated overhead.
    /// <code>Offset: 0x005C7E00
    /// unsigned int __thiscall CharacterTitleTable::GetPackSize(CharacterTitleTable*)</code>
    /// </summary>
    /// <returns>The packet size in bytes needed to serialize this object.</returns>
    public uint GetPackSize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharacterTitleTable, uint>)0x005C7E00)(ref this);

    /// <summary>Serializes a CharacterTitleTable into the provided buffer when sufficient space exists.
    /// <code>Offset: 0x005C7E20
    /// unsigned int __thiscall CharacterTitleTable::Pack(CharacterTitleTable*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current write position in the buffer, updated as data is written.</param>
    /// <param name="size">Size of remaining buffer space; serialization proceeds only if this value meets or exceeds the required pack size.</param>
    /// <returns>The total number of bytes needed to serialize the CharacterTitleTable.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharacterTitleTable, void**, uint, uint>)0x005C7E20)(ref this, addr, size);

    /// <summary>Unpacks a CharacterTitleTable from a binary buffer, initializing its display title and list of titles.
    /// <code>Offset: 0x005C7E70
    /// int __thiscall CharacterTitleTable::UnPack(CharacterTitleTable*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current position in the source buffer; advanced as data is consumed.</param>
    /// <param name="size">Number of bytes remaining in the buffer for unpacking.</param>
    /// <returns>1 if the buffer contains sufficient data and the table was fully unpacked; otherwise 0.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharacterTitleTable, void**, uint, int>)0x005C7E70)(ref this, addr, size);

    /// <summary>Retrieves the localized name for a character title identified by its ID and stores it in an output string buffer.
    /// <code>Offset: 0x005C7EB0
    /// int __cdecl CharacterTitleTable::GetCharacterTitleFromID(int,int*)</code>
    /// </summary>
    /// <param name="a1">The numeric identifier of the desired character title.</param>
    /// <param name="a2">A pointer to a string buffer where the retrieved title will be written.</param>
    /// <returns>Returns 1 if the title was successfully found and stored; otherwise returns 0.</returns>
    public static int GetCharacterTitleFromID(int a1, int* a2) => ((delegate* unmanaged[Cdecl]<int, int*, int>)0x005C7EB0)(a1, a2);

    /// <summary>Initializes a new CharacterTitleTable, setting the display title to zero and clearing the title list.
    /// <code>Offset: 0x005C7FC0
    /// void __thiscall CharacterTitleTable::CharacterTitleTable(CharacterTitleTable*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharacterTitleTable, void>)0x005C7FC0)(ref this);
}

