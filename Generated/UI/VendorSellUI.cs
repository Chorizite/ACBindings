namespace ACBindings;

// VendorSellUI
public unsafe struct VendorSellUI
{
    // Base Classes
    public ACBindings.VendorSubUI BaseClass_VendorSubUI; // ACBindings.VendorSubUI
    public ACBindings.ItemListDragHandler BaseClass_ItemListDragHandler; // ACBindings.ItemListDragHandler

    // Child Types
    // VendorSellUI_vtbl
    public unsafe struct VendorSellUI_vtbl
    {
        // Members
        public System.IntPtr OpenVendor; // function pointer
        public System.IntPtr CloseVendor; // function pointer
        public System.IntPtr HandleSetSelectedItem; // function pointer

        // Methods
    }

    // Members
    public ACBindings.UIElement_ItemList* m_sellShopList;
    public ACBindings.UIElement_Text* m_sellListText;
    public ACBindings.UIElement_Text* m_sellPurseText;
    public ACBindings.UIElement* m_sellItemButton;
    public ACBindings.UIElement* m_sellAllButton;
    public ACBindings.UIElement* m_sellClearItemButton;
    public ACBindings.UIElement* m_sellClearListButton;
    public int m_transactionValue;
    public ACBindings.UIElement_UIItem* m_splitItem;
    public ACBindings.IDClass___tagDataID m_splitItemClassID;
    public short m_splitItemStackSize;

    // Generated Constructor
    public VendorSellUI(ACBindings.gmVendorUI* parentElement) {
        _ConstructorInternal(parentElement);
    }

    // Methods
    // void __thiscall VendorSellUI::CloseVendor(VendorSellUI*)
    public void CloseVendor() => ((delegate* unmanaged[Thiscall]<ref ACBindings.VendorSellUI, void>)0x004C10D0)(ref this);
    // void __thiscall VendorSellUI::VendorSellUI(VendorSellUI*,gmVendorUI*)
    public void _ConstructorInternal(ACBindings.gmVendorUI* parentElement) => ((delegate* unmanaged[Thiscall]<ref ACBindings.VendorSellUI, ACBindings.gmVendorUI*, void>)0x004C13D0)(ref this, parentElement);
    // void __thiscall VendorSellUI::UpdateSellUI(VendorSellUI*)
    public void UpdateSellUI() => ((delegate* unmanaged[Thiscall]<ref ACBindings.VendorSellUI, void>)0x004C1AB0)(ref this);
    // void __thiscall VendorSellUI::HandleSetSelectedItem(VendorSellUI*,unsigned int,unsigned int)
    public void HandleSetSelectedItem(uint oldSelectedID, uint selectedID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.VendorSellUI, uint, uint, void>)0x004C1B40)(ref this, oldSelectedID, selectedID);
    // bool __thiscall VendorSellUI::DragItemAcceptable(VendorSellUI*,unsigned int,bool)
    public byte DragItemAcceptable(uint itemID, byte silent) => ((delegate* unmanaged[Thiscall]<ref ACBindings.VendorSellUI, uint, byte, byte>)0x004C2CB0)(ref this, itemID, silent);
    // void __thiscall VendorSellUI::UpdateTransactionValue(VendorSellUI*)
    public void UpdateTransactionValue() => ((delegate* unmanaged[Thiscall]<ref ACBindings.VendorSellUI, void>)0x004C41A0)(ref this);
    // void __thiscall VendorSellUI::UpdateTotalValue(VendorSellUI*)
    public void UpdateTotalValue() => ((delegate* unmanaged[Thiscall]<ref ACBindings.VendorSellUI, void>)0x004C4340)(ref this);
    // void __thiscall VendorSellUI::Update(VendorSellUI*)
    public void Update() => ((delegate* unmanaged[Thiscall]<ref ACBindings.VendorSellUI, void>)0x004C4B90)(ref this);
    // void __thiscall VendorSellUI::AddItemToSell(VendorSellUI*,unsigned int)
    public void AddItemToSell(uint itemID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.VendorSellUI, uint, void>)0x004C5610)(ref this, itemID);
    // bool __thiscall VendorSellUI::AcceptDragObject(VendorSellUI*,unsigned int)
    public byte AcceptDragObject(uint itemID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.VendorSellUI, uint, byte>)0x004C5AF0)(ref this, itemID);
}

