namespace ACBindings.Internal;

public unsafe struct SpellCastSubMenu
{
    // Base Classes
    public ACBindings.Internal.ItemListDragHandler BaseClass_ItemListDragHandler; // ACBindings.Internal.ItemListDragHandler

    // Child Types
    public unsafe struct SpellCastSubMenu_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SpellCastSubMenu*, ACBindings.Internal.UIElement_UIItem*, uint, uint, ACBindings.Internal.DropItemFlags, byte> OnItemListDragOver; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.UIElement_ItemList* m_spellItemList;
    public ACBindings.Internal.UIElement* m_spellTabElement;
    public uint m_selectedSpellID;
    public uint m_numSpells;
    public int m_tabIndex;
    public byte m_endowmentSelected;

    // Methods

    /// <summary>
    /// <code>Offset: 0x004C6680
    /// void __thiscall SpellCastSubMenu::Init(SpellCastSubMenu*,UIElement*,unsigned int,unsigned int,int)</code>
    /// </summary>
    public void Init(ACBindings.Internal.UIElement* parent, uint elementID, uint tabID, int index) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SpellCastSubMenu, ACBindings.Internal.UIElement*, uint, uint, int, void>)0x004C6680)(ref this, parent, elementID, tabID, index);

    /// <summary>
    /// <code>Offset: 0x004C66F0
    /// void __thiscall SpellCastSubMenu::SetSelected(SpellCastSubMenu*,unsigned int)</code>
    /// </summary>
    public void SetSelected(uint selectedSpellID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SpellCastSubMenu, uint, void>)0x004C66F0)(ref this, selectedSpellID);

    /// <summary>
    /// <code>Offset: 0x004C6780
    /// bool __thiscall SpellCastSubMenu::SelectSpellFromIndex(SpellCastSubMenu*,int)</code>
    /// </summary>
    public byte SelectSpellFromIndex(int index) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SpellCastSubMenu, int, byte>)0x004C6780)(ref this, index);

    /// <summary>
    /// <code>Offset: 0x004C67D0
    /// void __thiscall SpellCastSubMenu::UpdateShortcutOverlays(SpellCastSubMenu*)</code>
    /// </summary>
    public void UpdateShortcutOverlays() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SpellCastSubMenu, void>)0x004C67D0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004C7000
    /// void __thiscall SpellCastSubMenu::RemoveSpellFromPlayerModule(SpellCastSubMenu*,unsigned int)</code>
    /// </summary>
    public void RemoveSpellFromPlayerModule(uint spellID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SpellCastSubMenu, uint, void>)0x004C7000)(ref this, spellID);

    /// <summary>
    /// <code>Offset: 0x004C70B0
    /// void __thiscall SpellCastSubMenu::AddSpellToPlayerModule(SpellCastSubMenu*,unsigned int,unsigned int)</code>
    /// </summary>
    public void AddSpellToPlayerModule(uint spellID, uint pos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SpellCastSubMenu, uint, uint, void>)0x004C70B0)(ref this, spellID, pos);

    /// <summary>
    /// <code>Offset: 0x004C7160
    /// void __thiscall SpellCastSubMenu::UpdateFromPlayerModule(SpellCastSubMenu*)</code>
    /// </summary>
    public void UpdateFromPlayerModule() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SpellCastSubMenu, void>)0x004C7160)(ref this);

    /// <summary>
    /// <code>Offset: 0x004C74E0
    /// int __thiscall SpellCastSubMenu::RemoveSpellFromMenu(SpellCastSubMenu*,unsigned int)</code>
    /// </summary>
    public int RemoveSpellFromMenu(uint spellID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SpellCastSubMenu, uint, int>)0x004C74E0)(ref this, spellID);

    /// <summary>
    /// <code>Offset: 0x004C7C50
    /// void __thiscall SpellCastSubMenu::AddFavorite(SpellCastSubMenu*,unsigned int,int,bool)</code>
    /// </summary>
    public void AddFavorite(uint spellID, int pos, byte allowReplace) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SpellCastSubMenu, uint, int, byte, void>)0x004C7C50)(ref this, spellID, pos, allowReplace);
}

