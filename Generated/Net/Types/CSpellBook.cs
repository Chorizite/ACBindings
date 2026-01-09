namespace ACBindings;

// CSpellBook
public unsafe struct CSpellBook
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // CSpellBook_vtbl
    public unsafe struct CSpellBook_vtbl
    {
        // Members
        public System.IntPtr CSpellBook_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.PackableHashTable__uint__SpellBookPage _spellbook;

    // Generated Constructor
    public CSpellBook() {
        _ConstructorInternal();
    }

    // Methods
    // int __thiscall CSpellBook::TranscribeSpells(_DWORD*,_DWORD*)
    public int TranscribeSpells(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSpellBook, int*, int>)0x00596470)(ref this, a2);
    // int __thiscall CSpellBook::AddSpell(CSpellBook*,const unsigned int,const SpellBookPage*)
    public int AddSpell(uint newSpell, ACBindings.SpellBookPage* page) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSpellBook, uint, ACBindings.SpellBookPage*, int>)0x00596790)(ref this, newSpell, page);
    // int __thiscall CSpellBook::RemoveSpell(CSpellBook*,const unsigned int,SpellBookPage*)
    public int RemoveSpell(uint newSpell, ACBindings.SpellBookPage* page) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSpellBook, uint, ACBindings.SpellBookPage*, int>)0x005967C0)(ref this, newSpell, page);
    // void __thiscall CSpellBook::Prune(CSpellBook*)
    public void Prune() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSpellBook, void>)0x005967E0)(ref this);
    // void __thiscall CSpellBook::CSpellBook(CSpellBook*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSpellBook, void>)0x00596A80)(ref this);
    // int __thiscall CSpellBook::UnPack(CSpellBook*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSpellBook, void**, uint, int>)0x00596AB0)(ref this, addr, size);
}

