namespace ACBindings.Internal;


/// <summary>Handles the buying panel of a vendor dialog, storing references to the item list, purchase controls, and related text displays while maintaining the current transaction value.</summary>
public unsafe struct VendorBuyUI
{
    // Base Classes
    public ACBindings.Internal.VendorSubUI BaseClass_VendorSubUI; // ACBindings.Internal.VendorSubUI

    // Child Types
    public unsafe struct VendorBuyUI_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.VendorBuyUI*, byte, void> OpenVendor; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.VendorBuyUI*, void> CloseVendor; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.VendorBuyUI*, uint, uint, void> HandleSetSelectedItem; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.UIElement_ItemList* m_buyShopList;
    public ACBindings.Internal.UIElement_Text* m_buyListText;
    public ACBindings.Internal.UIElement_Text* m_buyPurseText;
    public ACBindings.Internal.UIElement* m_buyItemButton;
    public ACBindings.Internal.UIElement* m_buyAllButton;
    public ACBindings.Internal.UIElement* m_buyClearItemButton;
    public ACBindings.Internal.UIElement* m_buyClearListButton;
    public int m_transactionValue;

    // Generated Constructor
    public VendorBuyUI(ACBindings.Internal.gmVendorUI* parentElement) {
        _ConstructorInternal(parentElement);
    }

    // Methods

    /// <summary>Clears the displayed item list in the vendor UI, removing all entries from the shop list.
    /// <code>Offset: 0x004C10C0
    /// void __thiscall VendorBuyUI::CloseVendor(VendorBuyUI*)</code>
    /// </summary>
    public void CloseVendor() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VendorBuyUI, void>)0x004C10C0)(ref this);

    /// <summary>Initializes a VendorBuyUI instance by linking it to its parent gmVendorUI and retrieving references to the vendor's buy list, text fields, and action buttons.
    /// <code>Offset: 0x004C1310
    /// void __thiscall VendorBuyUI::VendorBuyUI(VendorBuyUI*,gmVendorUI*)</code>
    /// </summary>
    /// <param name="parentElement">The gmVendorUI object that owns this UI component.</param>
    public void _ConstructorInternal(ACBindings.Internal.gmVendorUI* parentElement) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VendorBuyUI, ACBindings.Internal.gmVendorUI*, void>)0x004C1310)(ref this, parentElement);

    /// <summary>Updates the vendor purchase UI by enabling or disabling action buttons based on whether items are present in the shop list and whether an item is currently selected.
    /// <code>Offset: 0x004C1A00
    /// void __thiscall VendorBuyUI::UpdateBuyUI(VendorBuyUI*)</code>
    /// </summary>
    public void UpdateBuyUI() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VendorBuyUI, void>)0x004C1A00)(ref this);

    /// <summary>Updates the vendor buy UI when the selected item changes, ensuring that the interface only refreshes if the new selection differs from the previous one.
    /// <code>Offset: 0x004C1A90
    /// void __thiscall VendorBuyUI::HandleSetSelectedItem(VendorBuyUI*,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="oldSelectedID">The identifier of the previously selected item.</param>
    /// <param name="selectedID">The identifier of the newly selected item.</param>
    public void HandleSetSelectedItem(uint oldSelectedID, uint selectedID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VendorBuyUI, uint, uint, void>)0x004C1A90)(ref this, oldSelectedID, selectedID);

    /// <summary>Recalculates the total quantity and monetary value of items selected in the vendor's buy list, updates the internal transaction value, and refreshes UI text to reflect the number of items being purchased and their cost, handling both default and custom currency names.
    /// <code>Offset: 0x004C3D40
    /// void __thiscall VendorBuyUI::UpdateTransactionValue(VendorBuyUI*)</code>
    /// </summary>
    public void UpdateTransactionValue() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VendorBuyUI, void>)0x004C3D40)(ref this);

    /// <summary>Refreshes the vendor UI’s total purchase value display by formatting the numeric amount with commas and updating the purse text to reflect the vendor’s trade currency or default silver.
    /// <code>Offset: 0x004C3FC0
    /// void __thiscall VendorBuyUI::UpdateTotalValue(VendorBuyUI*)</code>
    /// </summary>
    public void UpdateTotalValue() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VendorBuyUI, void>)0x004C3FC0)(ref this);

    /// <summary>Refreshes the vendor buy interface by repopulating the item list and updating purchase controls, transaction totals, and total value display.
    /// <code>Offset: 0x004C4B60
    /// void __thiscall VendorBuyUI::Update(VendorBuyUI*)</code>
    /// </summary>
    public void Update() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VendorBuyUI, void>)0x004C4B60)(ref this);
}

