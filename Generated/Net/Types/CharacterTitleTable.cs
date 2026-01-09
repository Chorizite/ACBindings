namespace ACBindings;

// CharacterTitleTable
public unsafe struct CharacterTitleTable
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // CharacterTitleTable_vtbl
    public unsafe struct CharacterTitleTable_vtbl
    {
        // Members
        public System.IntPtr CharacterTitleTable_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public uint mDisplayTitle;
    public ACBindings.PList__uint mTitleList;

    // Generated Constructor
    public CharacterTitleTable() {
        _ConstructorInternal();
    }

    // Methods
    // unsigned int __thiscall CharacterTitleTable::GetPackSize(CharacterTitleTable*)
    public uint GetPackSize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CharacterTitleTable, uint>)0x005C7E00)(ref this);
    // unsigned int __thiscall CharacterTitleTable::Pack(CharacterTitleTable*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CharacterTitleTable, void**, uint, uint>)0x005C7E20)(ref this, addr, size);
    // int __thiscall CharacterTitleTable::UnPack(CharacterTitleTable*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CharacterTitleTable, void**, uint, int>)0x005C7E70)(ref this, addr, size);
    // int __cdecl CharacterTitleTable::GetCharacterTitleFromID(int,int*)
    public static int GetCharacterTitleFromID(int a1, int* a2) => ((delegate* unmanaged[Cdecl]<int, int*, int>)0x005C7EB0)(a1, a2);
    // void __thiscall CharacterTitleTable::CharacterTitleTable(CharacterTitleTable*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CharacterTitleTable, void>)0x005C7FC0)(ref this);
}

