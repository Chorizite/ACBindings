namespace ACBindings;

// SpellCastSubMenu
public unsafe struct SpellCastSubMenu
{
    // Base Classes
    public ACBindings.ItemListDragHandler BaseClass_ItemListDragHandler; // ACBindings.ItemListDragHandler

    // Child Types
    // SpellCastSubMenu_vtbl
    public unsafe struct SpellCastSubMenu_vtbl
    {
        // Members
        public System.IntPtr OnItemListDragOver; // function pointer

        // Methods
    }

    // Members
    public ACBindings.UIElement_ItemList* m_spellItemList;
    public ACBindings.UIElement* m_spellTabElement;
    public uint m_selectedSpellID;
    public uint m_numSpells;
    public int m_tabIndex;
    public byte m_endowmentSelected;

    // Methods
    // void __thiscall SpellCastSubMenu::Init(SpellCastSubMenu*,UIElement*,unsigned int,unsigned int,int)
    public void Init(ACBindings.UIElement* parent, uint elementID, uint tabID, int index) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SpellCastSubMenu, ACBindings.UIElement*, uint, uint, int, void>)0x004C6680)(ref this, parent, elementID, tabID, index);
    // void __thiscall SpellCastSubMenu::SetSelected(SpellCastSubMenu*,unsigned int)
    public void SetSelected(uint selectedSpellID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SpellCastSubMenu, uint, void>)0x004C66F0)(ref this, selectedSpellID);
    // bool __thiscall SpellCastSubMenu::SelectSpellFromIndex(SpellCastSubMenu*,int)
    public byte SelectSpellFromIndex(int index) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SpellCastSubMenu, int, byte>)0x004C6780)(ref this, index);
    // void __thiscall SpellCastSubMenu::UpdateShortcutOverlays(SpellCastSubMenu*)
    public void UpdateShortcutOverlays() => ((delegate* unmanaged[Thiscall]<ref ACBindings.SpellCastSubMenu, void>)0x004C67D0)(ref this);
    // void __thiscall SpellCastSubMenu::RemoveSpellFromPlayerModule(SpellCastSubMenu*,unsigned int)
    public void RemoveSpellFromPlayerModule(uint spellID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SpellCastSubMenu, uint, void>)0x004C7000)(ref this, spellID);
    // void __thiscall SpellCastSubMenu::AddSpellToPlayerModule(SpellCastSubMenu*,unsigned int,unsigned int)
    public void AddSpellToPlayerModule(uint spellID, uint pos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SpellCastSubMenu, uint, uint, void>)0x004C70B0)(ref this, spellID, pos);
    // void __thiscall SpellCastSubMenu::UpdateFromPlayerModule(SpellCastSubMenu*)
    public void UpdateFromPlayerModule() => ((delegate* unmanaged[Thiscall]<ref ACBindings.SpellCastSubMenu, void>)0x004C7160)(ref this);
    // int __thiscall SpellCastSubMenu::RemoveSpellFromMenu(SpellCastSubMenu*,unsigned int)
    public int RemoveSpellFromMenu(uint spellID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SpellCastSubMenu, uint, int>)0x004C74E0)(ref this, spellID);
    // void __thiscall SpellCastSubMenu::AddFavorite(SpellCastSubMenu*,unsigned int,int,bool)
    public void AddFavorite(uint spellID, int pos, byte allowReplace) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SpellCastSubMenu, uint, int, byte, void>)0x004C7C50)(ref this, spellID, pos, allowReplace);
}

