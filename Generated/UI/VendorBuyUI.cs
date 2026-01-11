namespace ACBindings.Internal;

public unsafe struct VendorBuyUI
{
    // Base Classes
    public ACBindings.Internal.VendorSubUI BaseClass_VendorSubUI; // ACBindings.Internal.VendorSubUI

    // Child Types
    public unsafe struct VendorBuyUI_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VendorBuyUI*, byte, void> OpenVendor; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VendorBuyUI*, void> CloseVendor; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VendorBuyUI*, uint, uint, void> HandleSetSelectedItem; // function pointer

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

    /// <summary>
    /// <code>Offset: 0x004C10C0
    /// void __thiscall VendorBuyUI::CloseVendor(VendorBuyUI*)</code>
    /// </summary>
    public void CloseVendor() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VendorBuyUI, void>)0x004C10C0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004C1310
    /// void __thiscall VendorBuyUI::VendorBuyUI(VendorBuyUI*,gmVendorUI*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.gmVendorUI* parentElement) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VendorBuyUI, ACBindings.Internal.gmVendorUI*, void>)0x004C1310)(ref this, parentElement);

    /// <summary>
    /// <code>Offset: 0x004C1A00
    /// void __thiscall VendorBuyUI::UpdateBuyUI(VendorBuyUI*)</code>
    /// </summary>
    public void UpdateBuyUI() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VendorBuyUI, void>)0x004C1A00)(ref this);

    /// <summary>
    /// <code>Offset: 0x004C1A90
    /// void __thiscall VendorBuyUI::HandleSetSelectedItem(VendorBuyUI*,unsigned int,unsigned int)</code>
    /// </summary>
    public void HandleSetSelectedItem(uint oldSelectedID, uint selectedID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VendorBuyUI, uint, uint, void>)0x004C1A90)(ref this, oldSelectedID, selectedID);

    /// <summary>
    /// <code>Offset: 0x004C3D40
    /// void __thiscall VendorBuyUI::UpdateTransactionValue(VendorBuyUI*)</code>
    /// </summary>
    public void UpdateTransactionValue() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VendorBuyUI, void>)0x004C3D40)(ref this);

    /// <summary>
    /// <code>Offset: 0x004C3FC0
    /// void __thiscall VendorBuyUI::UpdateTotalValue(VendorBuyUI*)</code>
    /// </summary>
    public void UpdateTotalValue() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VendorBuyUI, void>)0x004C3FC0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004C4B60
    /// void __thiscall VendorBuyUI::Update(VendorBuyUI*)</code>
    /// </summary>
    public void Update() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VendorBuyUI, void>)0x004C4B60)(ref this);
}

