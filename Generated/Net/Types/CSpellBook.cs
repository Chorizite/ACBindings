namespace ACBindings.Internal;

public unsafe struct CSpellBook
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct CSpellBook_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CSpellBook*, void> CSpellBook_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CSpellBook*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CSpellBook*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CSpellBook*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.PackableHashTable__uint___SpellBookPage _spellbook;

    // Generated Constructor
    public CSpellBook() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x00596470
    /// int __thiscall CSpellBook::TranscribeSpells(_DWORD*,_DWORD*)</code>
    /// </summary>
    public int TranscribeSpells(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSpellBook, int*, int>)0x00596470)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x00596790
    /// int __thiscall CSpellBook::AddSpell(CSpellBook*,const unsigned int,const SpellBookPage*)</code>
    /// </summary>
    public int AddSpell(uint newSpell, ACBindings.Internal.SpellBookPage* page) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSpellBook, uint, ACBindings.Internal.SpellBookPage*, int>)0x00596790)(ref this, newSpell, page);

    /// <summary>
    /// <code>Offset: 0x005967C0
    /// int __thiscall CSpellBook::RemoveSpell(CSpellBook*,const unsigned int,SpellBookPage*)</code>
    /// </summary>
    public int RemoveSpell(uint newSpell, ACBindings.Internal.SpellBookPage* page) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSpellBook, uint, ACBindings.Internal.SpellBookPage*, int>)0x005967C0)(ref this, newSpell, page);

    /// <summary>
    /// <code>Offset: 0x005967E0
    /// void __thiscall CSpellBook::Prune(CSpellBook*)</code>
    /// </summary>
    public void Prune() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSpellBook, void>)0x005967E0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00596A80
    /// void __thiscall CSpellBook::CSpellBook(CSpellBook*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSpellBook, void>)0x00596A80)(ref this);

    /// <summary>
    /// <code>Offset: 0x00596AB0
    /// int __thiscall CSpellBook::UnPack(CSpellBook*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSpellBook, void**, uint, int>)0x00596AB0)(ref this, addr, size);
}

