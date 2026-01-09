namespace ACBindings;

// VendorBuyUI
public unsafe struct VendorBuyUI
{
    // Base Classes
    public ACBindings.VendorSubUI BaseClass_VendorSubUI; // ACBindings.VendorSubUI

    // Child Types
    // VendorBuyUI_vtbl
    public unsafe struct VendorBuyUI_vtbl
    {
        // Members
        public System.IntPtr OpenVendor; // function pointer
        public System.IntPtr CloseVendor; // function pointer
        public System.IntPtr HandleSetSelectedItem; // function pointer

        // Methods
    }

    // Members
    public ACBindings.UIElement_ItemList* m_buyShopList;
    public ACBindings.UIElement_Text* m_buyListText;
    public ACBindings.UIElement_Text* m_buyPurseText;
    public ACBindings.UIElement* m_buyItemButton;
    public ACBindings.UIElement* m_buyAllButton;
    public ACBindings.UIElement* m_buyClearItemButton;
    public ACBindings.UIElement* m_buyClearListButton;
    public int m_transactionValue;

    // Generated Constructor
    public VendorBuyUI(ACBindings.gmVendorUI* parentElement) {
        _ConstructorInternal(parentElement);
    }

    // Methods
    // void __thiscall VendorBuyUI::CloseVendor(VendorBuyUI*)
    public void CloseVendor() => ((delegate* unmanaged[Thiscall]<ref ACBindings.VendorBuyUI, void>)0x004C10C0)(ref this);
    // void __thiscall VendorBuyUI::VendorBuyUI(VendorBuyUI*,gmVendorUI*)
    public void _ConstructorInternal(ACBindings.gmVendorUI* parentElement) => ((delegate* unmanaged[Thiscall]<ref ACBindings.VendorBuyUI, ACBindings.gmVendorUI*, void>)0x004C1310)(ref this, parentElement);
    // void __thiscall VendorBuyUI::UpdateBuyUI(VendorBuyUI*)
    public void UpdateBuyUI() => ((delegate* unmanaged[Thiscall]<ref ACBindings.VendorBuyUI, void>)0x004C1A00)(ref this);
    // void __thiscall VendorBuyUI::HandleSetSelectedItem(VendorBuyUI*,unsigned int,unsigned int)
    public void HandleSetSelectedItem(uint oldSelectedID, uint selectedID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.VendorBuyUI, uint, uint, void>)0x004C1A90)(ref this, oldSelectedID, selectedID);
    // void __thiscall VendorBuyUI::UpdateTransactionValue(VendorBuyUI*)
    public void UpdateTransactionValue() => ((delegate* unmanaged[Thiscall]<ref ACBindings.VendorBuyUI, void>)0x004C3D40)(ref this);
    // void __thiscall VendorBuyUI::UpdateTotalValue(VendorBuyUI*)
    public void UpdateTotalValue() => ((delegate* unmanaged[Thiscall]<ref ACBindings.VendorBuyUI, void>)0x004C3FC0)(ref this);
    // void __thiscall VendorBuyUI::Update(VendorBuyUI*)
    public void Update() => ((delegate* unmanaged[Thiscall]<ref ACBindings.VendorBuyUI, void>)0x004C4B60)(ref this);
}

