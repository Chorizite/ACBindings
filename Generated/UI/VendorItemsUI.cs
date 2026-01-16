namespace ACBindings.Internal;


/// <summary>Manages the vendor’s item list, type filters and purchase controls within the UI. Handles item selection, quantity updates and interacts with the underlying shop data. Provides a bridge between user actions and vendor inventory logic.</summary>
public unsafe struct VendorItemsUI
{
    // Base Classes
    public ACBindings.Internal.VendorSubUI BaseClass_VendorSubUI; // ACBindings.Internal.VendorSubUI

    // Child Types
    public unsafe struct VendorItemsUI_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.VendorItemsUI*, byte, void> OpenVendor; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.VendorItemsUI*, void> CloseVendor; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.VendorItemsUI*, uint, uint, void> HandleSetSelectedItem; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.UIElement_ItemList* m_shopList;
    public ACBindings.Internal.UIElement_Menu* m_itemTypeMenu;
    public ACBindings.Internal.UIElement_Text* m_itemNameText;
    public ACBindings.Internal.UIElement_Text* m_itemCostText;
    public ACBindings.Internal.UIElement* m_buyButton;
    public ACBindings.Internal.UIElement* m_addButton;
    public int m_numTypeFilters;

    // Generated Constructor
    public VendorItemsUI(ACBindings.Internal.gmVendorUI* parentElement) {
        _ConstructorInternal(parentElement);
    }

    // Methods

    /// <summary>Creates a VendorItemsUI object and establishes links to its child UI components within the given gmVendorUI container.
    /// <code>Offset: 0x004C1150
    /// void __thiscall VendorItemsUI::VendorItemsUI(VendorItemsUI*,gmVendorUI*)</code>
    /// </summary>
    /// <param name="parentElement">The parent vendor UI element from which child UI elements are retrieved.</param>
    public void _ConstructorInternal(ACBindings.Internal.gmVendorUI* parentElement) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VendorItemsUI, ACBindings.Internal.gmVendorUI*, void>)0x004C1150)(ref this, parentElement);

    /// <summary>Closes the vendor UI by clearing the shop list, resetting its scroll position if items existed, and flushing the item type menu in preparation for subsequent use.
    /// <code>Offset: 0x004C1210
    /// void __thiscall VendorItemsUI::CloseVendor(VendorItemsUI*)</code>
    /// </summary>
    public void CloseVendor() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VendorItemsUI, void>)0x004C1210)(ref this);

    /// <summary>Adds a new type filter entry to the vendor items UI menu using the supplied display text and filter identifier, updating the internal count of filters.
    /// <code>Offset: 0x004C1240
    /// void __thiscall VendorItemsUI::AddTypeFilter(VendorItemsUI*,const StringInfo*,unsigned int)</code>
    /// </summary>
    /// <param name="text">Display information for the filter item.</param>
    /// <param name="filter">Identifier associated with the filter property.</param>
    public void AddTypeFilter(ACBindings.Internal.StringInfo* text, uint filter) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VendorItemsUI, ACBindings.Internal.StringInfo*, uint, void>)0x004C1240)(ref this, text, filter);

    /// <summary>Refreshes the quantity overlay for a vendor's item display to match the current stock level retrieved from the shop’s inventory list, based on the globally selected item ID.
    /// <code>Offset: 0x004C18B0
    /// void __thiscall VendorItemsUI::UpdateQuantityOverlay(VendorItemsUI*)</code>
    /// </summary>
    public void UpdateQuantityOverlay() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VendorItemsUI, void>)0x004C18B0)(ref this);

    /// <summary>Determines whether any item in the vendor's inventory matches a specified type mask.
    /// <code>Offset: 0x004C1980
    /// char __stdcall VendorItemsUI::ListContainsType(int,int)</code>
    /// </summary>
    /// <param name="a1">Pointer to the VendorItemsUI instance whose item list is examined.</param>
    /// <param name="a2">Bitmask representing one or more item types to search for.</param>
    /// <returns>Non-zero if at least one matching item exists; zero otherwise.</returns>
    public static sbyte ListContainsType(int a1, int a2) => ((delegate* unmanaged[Stdcall]<int, int, sbyte>)0x004C1980)(a1, a2);

    /// <summary>Reinitializes the vendor UI by clearing its item list, rebuilding type filters from the vendor’s shopItemProfileList, restoring the scroll position, and selecting an appropriate filter entry.
    /// <code>Offset: 0x004C22C0
    /// void __thiscall VendorItemsUI::OpenVendor(VendorItemsUI*,bool)</code>
    /// </summary>
    /// <param name="updating">Currently unused; the function rebuilds the UI regardless of this flag.</param>
    public void OpenVendor(byte updating) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VendorItemsUI, byte, void>)0x004C22C0)(ref this, updating);

    /// <summary>Refreshes the vendor’s shop item list according to an optional type filter, updates stack sizes, sets sell states, and scrolls the list into view.
    /// <code>Offset: 0x004C2A90
    /// void __thiscall VendorItemsUI::UpdateItemsList(VendorItemsUI*,int,bool)</code>
    /// </summary>
    /// <param name="item_type">Bitmask of item types to include; if zero, the currently selected menu item supplies the mask.</param>
    /// <param name="selectFirst">When true, selects the first matching item after the list is rebuilt.</param>
    public void UpdateItemsList(int item_type, byte selectFirst) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VendorItemsUI, int, byte, void>)0x004C2A90)(ref this, item_type, selectFirst);

    /// <summary>Refreshes the vendor items panel to reflect the currently selected inventory item. If no item is chosen or the list is empty, it clears the display and disables purchase actions.
    /// <code>Offset: 0x004C44D0
    /// void __thiscall VendorItemsUI::UpdateItemsUI(VendorItemsUI*)</code>
    /// </summary>
    public void UpdateItemsUI() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VendorItemsUI, void>)0x004C44D0)(ref this);

    /// <summary>Removes a specified quantity of an item from the vendor's shop inventory after purchase. If the resulting quantity reaches zero, deletes the item entry; otherwise updates its stack size in the UI.
    /// <code>Offset: 0x004C48D0
    /// void __thiscall VendorItemsUI::RemoveFromShop(VendorItemsUI*,ACCWeenieObject*,int)</code>
    /// </summary>
    /// <param name="weenObj">The item object being removed from stock.</param>
    /// <param name="amountBought">The number of units purchased and to be subtracted from the vendor's inventory.</param>
    public void RemoveFromShop(ACBindings.Internal.ACCWeenieObject* weenObj, int amountBought) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VendorItemsUI, ACBindings.Internal.ACCWeenieObject*, int, void>)0x004C48D0)(ref this, weenObj, amountBought);

    /// <summary>Adds the specified item to the vendor’s buy list or increases its quantity if already present, ensuring the total does not exceed 5 000 units; otherwise displays an error notice.
    /// <code>Offset: 0x004C49B0
    /// void __thiscall VendorItemsUI::AddToBuyList(VendorItemsUI*,ACCWeenieObject*,int)</code>
    /// </summary>
    /// <param name="weenObj">The object representing the item being purchased.</param>
    /// <param name="amountBuyingNow">Number of items to add to the list.</param>
    public void AddToBuyList(ACBindings.Internal.ACCWeenieObject* weenObj, int amountBuyingNow) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VendorItemsUI, ACBindings.Internal.ACCWeenieObject*, int, void>)0x004C49B0)(ref this, weenObj, amountBuyingNow);

    /// <summary>Refreshes the vendor interface to reflect the newly selected item, updating the list view and quantity display.
    /// <code>Offset: 0x004C55A0
    /// void __thiscall VendorItemsUI::HandleSetSelectedItem(VendorItemsUI*,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="oldSelectedID">Identifier of the previously selected item.</param>
    /// <param name="selectedID">Identifier of the new item chosen by the player.</param>
    public void HandleSetSelectedItem(uint oldSelectedID, uint selectedID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VendorItemsUI, uint, uint, void>)0x004C55A0)(ref this, oldSelectedID, selectedID);
}

