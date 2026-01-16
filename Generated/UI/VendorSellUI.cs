namespace ACBindings.Internal;


/// <summary>Manages the vendor selling interface, handling item drag‑drop, stack splitting, transaction calculations, and updates to the sell list, purse amount, and control buttons.</summary>
/// <remarks>Inherits from VendorSubUI and ItemListDragHandler to integrate with the overall vendor UI system.</remarks>
public unsafe struct VendorSellUI
{
    // Base Classes
    public ACBindings.Internal.VendorSubUI BaseClass_VendorSubUI; // ACBindings.Internal.VendorSubUI
    public ACBindings.Internal.ItemListDragHandler BaseClass_ItemListDragHandler; // ACBindings.Internal.ItemListDragHandler

    // Child Types
    public unsafe struct VendorSellUI_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.VendorSellUI*, byte, void> OpenVendor; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.VendorSellUI*, void> CloseVendor; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.VendorSellUI*, uint, uint, void> HandleSetSelectedItem; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.UIElement_ItemList* m_sellShopList;
    public ACBindings.Internal.UIElement_Text* m_sellListText;
    public ACBindings.Internal.UIElement_Text* m_sellPurseText;
    public ACBindings.Internal.UIElement* m_sellItemButton;
    public ACBindings.Internal.UIElement* m_sellAllButton;
    public ACBindings.Internal.UIElement* m_sellClearItemButton;
    public ACBindings.Internal.UIElement* m_sellClearListButton;
    public int m_transactionValue;
    public ACBindings.Internal.UIElement_UIItem* m_splitItem;
    public ACBindings.Internal.IDClass____tagDataID m_splitItemClassID;
    public short m_splitItemStackSize;

    // Generated Constructor
    public VendorSellUI(ACBindings.Internal.gmVendorUI* parentElement) {
        _ConstructorInternal(parentElement);
    }

    // Methods

    /// <summary>Clears all items from the vendor's sell shop list.
    /// <code>Offset: 0x004C10D0
    /// void __thiscall VendorSellUI::CloseVendor(VendorSellUI*)</code>
    /// </summary>
    public void CloseVendor() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VendorSellUI, void>)0x004C10D0)(ref this);

    /// <summary>Initializes the VendorSellUI component, linking it to its gmVendorUI parent and locating required child UI elements such as the sell list, text fields, buttons, and drag handler.
    /// <code>Offset: 0x004C13D0
    /// void __thiscall VendorSellUI::VendorSellUI(VendorSellUI*,gmVendorUI*)</code>
    /// </summary>
    /// <param name="parentElement">The parent gmVendorUI object that owns this sell UI instance.</param>
    public void _ConstructorInternal(ACBindings.Internal.gmVendorUI* parentElement) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VendorSellUI, ACBindings.Internal.gmVendorUI*, void>)0x004C13D0)(ref this, parentElement);

    /// <summary>Updates vendor sell UI elements according to the current shop list contents and whether an item is selected in the list, enabling or disabling the clear‑list, clear‑item, all, and sell buttons as appropriate.
    /// <code>Offset: 0x004C1AB0
    /// void __thiscall VendorSellUI::UpdateSellUI(VendorSellUI*)</code>
    /// </summary>
    public void UpdateSellUI() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VendorSellUI, void>)0x004C1AB0)(ref this);

    /// <summary>Refreshes the sell UI when the player selects a different item from the vendor's inventory, provided a shop vendor is active.
    /// <code>Offset: 0x004C1B40
    /// void __thiscall VendorSellUI::HandleSetSelectedItem(VendorSellUI*,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="oldSelectedID">The ID of the previously selected item.</param>
    /// <param name="selectedID">The ID of the newly selected item.</param>
    public void HandleSetSelectedItem(uint oldSelectedID, uint selectedID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VendorSellUI, uint, uint, void>)0x004C1B40)(ref this, oldSelectedID, selectedID);

    /// <summary>Determines whether a specified item can be dragged into the vendor sell interface, checking ownership and vendor profile rules. If the item cannot be sold and silent is false, displays an appropriate notice to the player.
    /// <code>Offset: 0x004C2CB0
    /// bool __thiscall VendorSellUI::DragItemAcceptable(VendorSellUI*,unsigned int,bool)</code>
    /// </summary>
    /// <param name="itemID">The unique identifier of the item being dragged.</param>
    /// <param name="silent">When true, suppresses any UI messages about why the item cannot be sold.</param>
    /// <returns>True if the item is acceptable for sale in this vendor’s shop; otherwise false.</returns>
    public byte DragItemAcceptable(uint itemID, byte silent) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VendorSellUI, uint, byte, byte>)0x004C2CB0)(ref this, itemID, silent);

    /// <summary>
    /// Computes the total monetary value of all items selected in the vendor's shop list, updates the internal transaction value, and refreshes UI text fields to display the new amount with proper pluralization and comma formatting. The calculation sums each item's vendor buy price; stack size is only used for item count display.
    /// 
    /// <code>Offset: 0x004C41A0
    /// void __thiscall VendorSellUI::UpdateTransactionValue(VendorSellUI*)</code>
    /// </summary>
    public void UpdateTransactionValue() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VendorSellUI, void>)0x004C41A0)(ref this);

    /// <summary>Refreshes the displayed total value for the vendor’s purse by reading the parent UI’s m_totalValue field, formatting it with thousands separators, and setting the resulting string on the m_sellPurseText element.
    /// <code>Offset: 0x004C4340
    /// void __thiscall VendorSellUI::UpdateTotalValue(VendorSellUI*)</code>
    /// </summary>
    public void UpdateTotalValue() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VendorSellUI, void>)0x004C4340)(ref this);

    /// <summary>Refreshes the vendor selling interface by loading the current shop list into the UI, recalculating individual item sales information, updating the transaction amount, and displaying the total value.
    /// <code>Offset: 0x004C4B90
    /// void __thiscall VendorSellUI::Update(VendorSellUI*)</code>
    /// </summary>
    public void Update() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VendorSellUI, void>)0x004C4B90)(ref this);

    /// <summary>Adds the specified item to the vendor's selling list, opens the appropriate UI tab, and updates all related transaction values and totals.
    /// <code>Offset: 0x004C5610
    /// void __thiscall VendorSellUI::AddItemToSell(VendorSellUI*,unsigned int)</code>
    /// </summary>
    /// <param name="itemID">The unique identifier of the item to add to the sell list.</param>
    public void AddItemToSell(uint itemID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VendorSellUI, uint, void>)0x004C5610)(ref this, itemID);

    /// <summary>Accepts a dragged item into the vendor sell interface, verifies that it can be sold, and handles stack splitting when necessary. If the item is acceptable, it is added to the sell list and any split portion is prepared for sale.
    /// <code>Offset: 0x004C5AF0
    /// bool __thiscall VendorSellUI::AcceptDragObject(VendorSellUI*,unsigned int)</code>
    /// </summary>
    /// <p><param name="itemID">The unique identifier of the item being dragged onto the sell UI.</param></p>
    /// <returns>True if the item was accepted and processed; false if the item cannot be sold or splitting fails.</returns>
    public byte AcceptDragObject(uint itemID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VendorSellUI, uint, byte>)0x004C5AF0)(ref this, itemID);
}

