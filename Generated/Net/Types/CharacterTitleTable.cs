namespace ACBindings.Internal;

public unsafe struct CharacterTitleTable
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct CharacterTitleTable_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CharacterTitleTable*, void> CharacterTitleTable_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CharacterTitleTable*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CharacterTitleTable*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CharacterTitleTable*, void**, uint, int> UnPack; // function pointer

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

    /// <summary>
    /// <code>Offset: 0x005C7E00
    /// unsigned int __thiscall CharacterTitleTable::GetPackSize(CharacterTitleTable*)</code>
    /// </summary>
    public uint GetPackSize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharacterTitleTable, uint>)0x005C7E00)(ref this);

    /// <summary>
    /// <code>Offset: 0x005C7E20
    /// unsigned int __thiscall CharacterTitleTable::Pack(CharacterTitleTable*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharacterTitleTable, void**, uint, uint>)0x005C7E20)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005C7E70
    /// int __thiscall CharacterTitleTable::UnPack(CharacterTitleTable*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharacterTitleTable, void**, uint, int>)0x005C7E70)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005C7EB0
    /// int __cdecl CharacterTitleTable::GetCharacterTitleFromID(int,int*)</code>
    /// </summary>
    public static int GetCharacterTitleFromID(int a1, int* a2) => ((delegate* unmanaged[Cdecl]<int, int*, int>)0x005C7EB0)(a1, a2);

    /// <summary>
    /// <code>Offset: 0x005C7FC0
    /// void __thiscall CharacterTitleTable::CharacterTitleTable(CharacterTitleTable*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharacterTitleTable, void>)0x005C7FC0)(ref this);
}

