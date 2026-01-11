namespace ACBindings.Internal;

public unsafe struct VendorSellUI
{
    // Base Classes
    public ACBindings.Internal.VendorSubUI BaseClass_VendorSubUI; // ACBindings.Internal.VendorSubUI
    public ACBindings.Internal.ItemListDragHandler BaseClass_ItemListDragHandler; // ACBindings.Internal.ItemListDragHandler

    // Child Types
    public unsafe struct VendorSellUI_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VendorSellUI*, byte, void> OpenVendor; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VendorSellUI*, void> CloseVendor; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VendorSellUI*, uint, uint, void> HandleSetSelectedItem; // function pointer

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

    /// <summary>
    /// <code>Offset: 0x004C10D0
    /// void __thiscall VendorSellUI::CloseVendor(VendorSellUI*)</code>
    /// </summary>
    public void CloseVendor() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VendorSellUI, void>)0x004C10D0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004C13D0
    /// void __thiscall VendorSellUI::VendorSellUI(VendorSellUI*,gmVendorUI*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.gmVendorUI* parentElement) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VendorSellUI, ACBindings.Internal.gmVendorUI*, void>)0x004C13D0)(ref this, parentElement);

    /// <summary>
    /// <code>Offset: 0x004C1AB0
    /// void __thiscall VendorSellUI::UpdateSellUI(VendorSellUI*)</code>
    /// </summary>
    public void UpdateSellUI() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VendorSellUI, void>)0x004C1AB0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004C1B40
    /// void __thiscall VendorSellUI::HandleSetSelectedItem(VendorSellUI*,unsigned int,unsigned int)</code>
    /// </summary>
    public void HandleSetSelectedItem(uint oldSelectedID, uint selectedID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VendorSellUI, uint, uint, void>)0x004C1B40)(ref this, oldSelectedID, selectedID);

    /// <summary>
    /// <code>Offset: 0x004C2CB0
    /// bool __thiscall VendorSellUI::DragItemAcceptable(VendorSellUI*,unsigned int,bool)</code>
    /// </summary>
    public byte DragItemAcceptable(uint itemID, byte silent) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VendorSellUI, uint, byte, byte>)0x004C2CB0)(ref this, itemID, silent);

    /// <summary>
    /// <code>Offset: 0x004C41A0
    /// void __thiscall VendorSellUI::UpdateTransactionValue(VendorSellUI*)</code>
    /// </summary>
    public void UpdateTransactionValue() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VendorSellUI, void>)0x004C41A0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004C4340
    /// void __thiscall VendorSellUI::UpdateTotalValue(VendorSellUI*)</code>
    /// </summary>
    public void UpdateTotalValue() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VendorSellUI, void>)0x004C4340)(ref this);

    /// <summary>
    /// <code>Offset: 0x004C4B90
    /// void __thiscall VendorSellUI::Update(VendorSellUI*)</code>
    /// </summary>
    public void Update() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VendorSellUI, void>)0x004C4B90)(ref this);

    /// <summary>
    /// <code>Offset: 0x004C5610
    /// void __thiscall VendorSellUI::AddItemToSell(VendorSellUI*,unsigned int)</code>
    /// </summary>
    public void AddItemToSell(uint itemID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VendorSellUI, uint, void>)0x004C5610)(ref this, itemID);

    /// <summary>
    /// <code>Offset: 0x004C5AF0
    /// bool __thiscall VendorSellUI::AcceptDragObject(VendorSellUI*,unsigned int)</code>
    /// </summary>
    public byte AcceptDragObject(uint itemID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VendorSellUI, uint, byte>)0x004C5AF0)(ref this, itemID);
}

