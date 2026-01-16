namespace ACBindings.Internal;


/// <summary>Represents the spell selection interface in the game client, managing a list of favorite spells per tab and handling user interactions such as selection, addition, removal, and drag‑drop operations.</summary>
public unsafe struct SpellCastSubMenu
{
    // Base Classes
    public ACBindings.Internal.ItemListDragHandler BaseClass_ItemListDragHandler; // ACBindings.Internal.ItemListDragHandler

    // Child Types
    public unsafe struct SpellCastSubMenu_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SpellCastSubMenu*, ACBindings.Internal.UIElement_UIItem*, uint, uint, ACBindings.Internal.DropItemFlags, byte> OnItemListDragOver; // function pointer

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

    /// <summary>Initializes a SpellCastSubMenu by locating its spell list and tab elements within a parent UI hierarchy, setting the active tab index, and registering an item‑list drag handler when available.
    /// <code>Offset: 0x004C6680
    /// void __thiscall SpellCastSubMenu::Init(SpellCastSubMenu*,UIElement*,unsigned int,unsigned int,int)</code>
    /// </summary>
    /// <param name="parent">The root UIElement that contains the submenu components.</param>
    /// <param name="elementID">Identifier of the child element that holds the spell list items.</param>
    /// <param name="tabID">Identifier of the child element representing the tab control for spell categories.</param>
    /// <param name="index">Index value assigned to m_tabIndex, indicating the currently selected tab.</param>
    public void Init(ACBindings.Internal.UIElement* parent, uint elementID, uint tabID, int index) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SpellCastSubMenu, ACBindings.Internal.UIElement*, uint, uint, int, void>)0x004C6680)(ref this, parent, elementID, tabID, index);

    /// <summary>Selects the spell with the given ID in the submenu's item list, updating visual selection state and scrolling that entry into view; if no items are present it simply stores the requested ID.
    /// <code>Offset: 0x004C66F0
    /// void __thiscall SpellCastSubMenu::SetSelected(SpellCastSubMenu*,unsigned int)</code>
    /// </summary>
    /// <param name="selectedSpellID">The unique identifier of the spell to select.</param>
    public void SetSelected(uint selectedSpellID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SpellCastSubMenu, uint, void>)0x004C66F0)(ref this, selectedSpellID);

    /// <summary>Selects a spell from the submenu's item list by its zero‑based index and sets it as the current selection.
    /// <code>Offset: 0x004C6780
    /// bool __thiscall SpellCastSubMenu::SelectSpellFromIndex(SpellCastSubMenu*,int)</code>
    /// </summary>
    /// <param name="index">The position in the spell list to activate; indices are 0‑based.</param>
    /// <returns>True when a valid spell is found, activated, and set as selected; otherwise false.</returns>
    public byte SelectSpellFromIndex(int index) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SpellCastSubMenu, int, byte>)0x004C6780)(ref this, index);

    /// <summary>Refreshes the shortcut key indicators for each spell in the submenu, assigning numbers 0–8 to the first nine items and hiding shortcuts for additional entries.
    /// <code>Offset: 0x004C67D0
    /// void __thiscall SpellCastSubMenu::UpdateShortcutOverlays(SpellCastSubMenu*)</code>
    /// </summary>
    public void UpdateShortcutOverlays() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SpellCastSubMenu, void>)0x004C67D0)(ref this);

    /// <summary>Removes a spell identified by <paramref name="spellID"/> from the player’s favorite list for the active tab.
    /// <code>Offset: 0x004C7000
    /// void __thiscall SpellCastSubMenu::RemoveSpellFromPlayerModule(SpellCastSubMenu*,unsigned int)</code>
    /// </summary>
    /// <p>This operation queries the player module via the interface system, then deletes the specified favorite and triggers the corresponding character event.</p>
    /// <param name="spellID">The unique identifier of the spell to remove from favorites.</param>
    public void RemoveSpellFromPlayerModule(uint spellID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SpellCastSubMenu, uint, void>)0x004C7000)(ref this, spellID);

    /// <summary>Adds a spell to the player’s favorite list at the given position within the active tab.
    /// <code>Offset: 0x004C70B0
    /// void __thiscall SpellCastSubMenu::AddSpellToPlayerModule(SpellCastSubMenu*,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="spellID">Identifier of the spell to add.</param>
    /// <param name="pos">Zero‑based index specifying where in the favorites list to insert the spell.</param>
    public void AddSpellToPlayerModule(uint spellID, uint pos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SpellCastSubMenu, uint, uint, void>)0x004C70B0)(ref this, spellID, pos);

    /// <summary>Refreshes the spell cast submenu to reflect the player's current favorite spells for the active tab. Retrieves the list of favorite spells from the player module, filters out unknown spells, and populates the UI item list with shortcuts, updating tooltips and selection state.
    /// <code>Offset: 0x004C7160
    /// void __thiscall SpellCastSubMenu::UpdateFromPlayerModule(SpellCastSubMenu*)</code>
    /// </summary>
    public void UpdateFromPlayerModule() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SpellCastSubMenu, void>)0x004C7160)(ref this);

    /// <summary>Removes a spell identified by ID from the submenu’s UI list and updates internal state. Returns the index of the removed item or –1 when the spell is not present or the ID is zero.
    /// <code>Offset: 0x004C74E0
    /// int __thiscall SpellCastSubMenu::RemoveSpellFromMenu(SpellCastSubMenu*,unsigned int)</code>
    /// </summary>
    /// <param name="spellID">The identifier of the spell to remove.</param>
    /// <returns>The index of the removed spell within the UI list, or –1 if removal fails.</returns>
    public int RemoveSpellFromMenu(uint spellID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SpellCastSubMenu, uint, int>)0x004C74E0)(ref this, spellID);

    /// <summary>Adds a spell shortcut to the favorites list for the current tab, inserting it at the specified position unless replacement is disallowed and the spell already exists. Updates internal counts, UI tooltips, and synchronizes with the player module.
    /// <code>Offset: 0x004C7C50
    /// void __thiscall SpellCastSubMenu::AddFavorite(SpellCastSubMenu*,unsigned int,int,bool)</code>
    /// </summary>
    /// <param name="spellID">Identifier of the spell to add.</param>
    /// <param name="pos">Desired index in the favorites list; if greater than current size it appends.</param>
    /// <param name="allowReplace">If false, prevents adding duplicate spells; true allows replacing an existing entry.</param>
    public void AddFavorite(uint spellID, int pos, byte allowReplace) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SpellCastSubMenu, uint, int, byte, void>)0x004C7C50)(ref this, spellID, pos, allowReplace);
}

