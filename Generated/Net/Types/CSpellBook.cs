namespace ACBindings.Internal;


/// <summary>CSpellBook holds spell data for a character or system, using an internal hash table of SpellBookPage objects to manage individual spells. It provides functionality to add, remove, serialize, and validate spells, ensuring only valid entries remain in the collection.</summary>
public unsafe struct CSpellBook
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct CSpellBook_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CSpellBook*, void> CSpellBook_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CSpellBook*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CSpellBook*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CSpellBook*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.PackableHashTable__uint___SpellBookPage _spellbook;

    // Generated Constructor
    public CSpellBook() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>Copies all spell book pages from the spellbook's internal hash table into a newly allocated linked list, storing them in the structure pointed to by the second argument and updating its element count.
    /// <code>Offset: 0x00596470
    /// int __thiscall CSpellBook::TranscribeSpells(_DWORD*,_DWORD*)</code>
    /// </summary>
    /// <param name="a2">Pointer to the destination buffer that will receive the new page nodes. The function writes the head pointer, first node pointer, and item count into this array of DWORDs.</param>
    /// <returns>Always returns 1 to indicate successful completion.</returns>
    public int TranscribeSpells(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSpellBook, int*, int>)0x00596470)(ref this, a2);

    /// <summary>Adds a spell to the spellbook when a valid spell identifier is provided.
    /// <code>Offset: 0x00596790
    /// int __thiscall CSpellBook::AddSpell(CSpellBook*,const unsigned int,const SpellBookPage*)</code>
    /// </summary>
    /// <param name="newSpell">Identifier of the spell to add; must be non‑zero for addition.</param>
    /// <param name="page">Pointer to a SpellBookPage containing spell data; may be null if not needed.</param>
    /// <returns>Non‑zero value returned by the underlying hash table when the spell is added successfully; zero if the spell identifier is invalid or addition fails.</returns>
    public int AddSpell(uint newSpell, ACBindings.Internal.SpellBookPage* page) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSpellBook, uint, ACBindings.Internal.SpellBookPage*, int>)0x00596790)(ref this, newSpell, page);

    /// <summary>Removes a spell identified by its unique ID from the spellbook and stores its page data in the provided structure if available.
    /// <code>Offset: 0x005967C0
    /// int __thiscall CSpellBook::RemoveSpell(CSpellBook*,const unsigned int,SpellBookPage*)</code>
    /// </summary>
    /// <param name="newSpell">The unique identifier of the spell to remove.</param>
    /// <param name="page">Pointer to a SpellBookPage structure that receives information about the removed spell; may be nullptr.</param>
    /// <returns>Non‑zero on success, zero if no matching spell was found or removal failed.</returns>
    public int RemoveSpell(uint newSpell, ACBindings.Internal.SpellBookPage* page) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSpellBook, uint, ACBindings.Internal.SpellBookPage*, int>)0x005967C0)(ref this, newSpell, page);

    /// <summary>Removes entries from the spellbook whose UI object ID is zero, exceeds 0x2000, or refers to a UI object named “Unknown”, ensuring only valid pages remain.
    /// <code>Offset: 0x005967E0
    /// void __thiscall CSpellBook::Prune(CSpellBook*)</code>
    /// </summary>
    public void Prune() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSpellBook, void>)0x005967E0)(ref this);

    /// <summary>Initializes a new spell book object by setting up its virtual function table and preparing an internal hash table for storing spell pages with a default capacity.
    /// <code>Offset: 0x00596A80
    /// void __thiscall CSpellBook::CSpellBook(CSpellBook*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSpellBook, void>)0x00596A80)(ref this);

    /// <summary>Deserializes spellbook data from the provided buffer into the current object, clearing any existing entries before repopulation.
    /// <code>Offset: 0x00596AB0
    /// int __thiscall CSpellBook::UnPack(CSpellBook*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the source data buffer used for unpacking.</param>
    /// <param name="size">Size in bytes of the data buffer.</param>
    /// <returns>Number of bytes successfully unpacked; returns 0 if the operation fails or insufficient space is available.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSpellBook, void**, uint, int>)0x00596AB0)(ref this, addr, size);
}

