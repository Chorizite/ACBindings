namespace ACBindings.Internal;

public unsafe struct VendorItemsUI
{
    // Base Classes
    public ACBindings.Internal.VendorSubUI BaseClass_VendorSubUI; // ACBindings.Internal.VendorSubUI

    // Child Types
    public unsafe struct VendorItemsUI_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VendorItemsUI*, byte, void> OpenVendor; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VendorItemsUI*, void> CloseVendor; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VendorItemsUI*, uint, uint, void> HandleSetSelectedItem; // function pointer

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

    /// <summary>
    /// <code>Offset: 0x004C1150
    /// void __thiscall VendorItemsUI::VendorItemsUI(VendorItemsUI*,gmVendorUI*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.gmVendorUI* parentElement) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VendorItemsUI, ACBindings.Internal.gmVendorUI*, void>)0x004C1150)(ref this, parentElement);

    /// <summary>
    /// <code>Offset: 0x004C1210
    /// void __thiscall VendorItemsUI::CloseVendor(VendorItemsUI*)</code>
    /// </summary>
    public void CloseVendor() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VendorItemsUI, void>)0x004C1210)(ref this);

    /// <summary>
    /// <code>Offset: 0x004C1240
    /// void __thiscall VendorItemsUI::AddTypeFilter(VendorItemsUI*,const StringInfo*,unsigned int)</code>
    /// </summary>
    public void AddTypeFilter(ACBindings.Internal.StringInfo* text, uint filter) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VendorItemsUI, ACBindings.Internal.StringInfo*, uint, void>)0x004C1240)(ref this, text, filter);

    /// <summary>
    /// <code>Offset: 0x004C18B0
    /// void __thiscall VendorItemsUI::UpdateQuantityOverlay(VendorItemsUI*)</code>
    /// </summary>
    public void UpdateQuantityOverlay() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VendorItemsUI, void>)0x004C18B0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004C1980
    /// char __stdcall VendorItemsUI::ListContainsType(int,int)</code>
    /// </summary>
    public static sbyte ListContainsType(int a1, int a2) => ((delegate* unmanaged[Stdcall]<int, int, sbyte>)0x004C1980)(a1, a2);

    /// <summary>
    /// <code>Offset: 0x004C22C0
    /// void __thiscall VendorItemsUI::OpenVendor(VendorItemsUI*,bool)</code>
    /// </summary>
    public void OpenVendor(byte updating) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VendorItemsUI, byte, void>)0x004C22C0)(ref this, updating);

    /// <summary>
    /// <code>Offset: 0x004C2A90
    /// void __thiscall VendorItemsUI::UpdateItemsList(VendorItemsUI*,int,bool)</code>
    /// </summary>
    public void UpdateItemsList(int item_type, byte selectFirst) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VendorItemsUI, int, byte, void>)0x004C2A90)(ref this, item_type, selectFirst);

    /// <summary>
    /// <code>Offset: 0x004C44D0
    /// void __thiscall VendorItemsUI::UpdateItemsUI(VendorItemsUI*)</code>
    /// </summary>
    public void UpdateItemsUI() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VendorItemsUI, void>)0x004C44D0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004C48D0
    /// void __thiscall VendorItemsUI::RemoveFromShop(VendorItemsUI*,ACCWeenieObject*,int)</code>
    /// </summary>
    public void RemoveFromShop(ACBindings.Internal.ACCWeenieObject* weenObj, int amountBought) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VendorItemsUI, ACBindings.Internal.ACCWeenieObject*, int, void>)0x004C48D0)(ref this, weenObj, amountBought);

    /// <summary>
    /// <code>Offset: 0x004C49B0
    /// void __thiscall VendorItemsUI::AddToBuyList(VendorItemsUI*,ACCWeenieObject*,int)</code>
    /// </summary>
    public void AddToBuyList(ACBindings.Internal.ACCWeenieObject* weenObj, int amountBuyingNow) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VendorItemsUI, ACBindings.Internal.ACCWeenieObject*, int, void>)0x004C49B0)(ref this, weenObj, amountBuyingNow);

    /// <summary>
    /// <code>Offset: 0x004C55A0
    /// void __thiscall VendorItemsUI::HandleSetSelectedItem(VendorItemsUI*,unsigned int,unsigned int)</code>
    /// </summary>
    public void HandleSetSelectedItem(uint oldSelectedID, uint selectedID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VendorItemsUI, uint, uint, void>)0x004C55A0)(ref this, oldSelectedID, selectedID);
}

