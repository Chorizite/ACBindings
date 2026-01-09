namespace ACBindings;

// VendorItemsUI
public unsafe struct VendorItemsUI
{
    // Base Classes
    public ACBindings.VendorSubUI BaseClass_VendorSubUI; // ACBindings.VendorSubUI

    // Child Types
    // VendorItemsUI_vtbl
    public unsafe struct VendorItemsUI_vtbl
    {
        // Members
        public System.IntPtr OpenVendor; // function pointer
        public System.IntPtr CloseVendor; // function pointer
        public System.IntPtr HandleSetSelectedItem; // function pointer

        // Methods
    }

    // Members
    public ACBindings.UIElement_ItemList* m_shopList;
    public ACBindings.UIElement_Menu* m_itemTypeMenu;
    public ACBindings.UIElement_Text* m_itemNameText;
    public ACBindings.UIElement_Text* m_itemCostText;
    public ACBindings.UIElement* m_buyButton;
    public ACBindings.UIElement* m_addButton;
    public int m_numTypeFilters;

    // Generated Constructor
    public VendorItemsUI(ACBindings.gmVendorUI* parentElement) {
        _ConstructorInternal(parentElement);
    }

    // Methods
    // void __thiscall VendorItemsUI::VendorItemsUI(VendorItemsUI*,gmVendorUI*)
    public void _ConstructorInternal(ACBindings.gmVendorUI* parentElement) => ((delegate* unmanaged[Thiscall]<ref ACBindings.VendorItemsUI, ACBindings.gmVendorUI*, void>)0x004C1150)(ref this, parentElement);
    // void __thiscall VendorItemsUI::CloseVendor(VendorItemsUI*)
    public void CloseVendor() => ((delegate* unmanaged[Thiscall]<ref ACBindings.VendorItemsUI, void>)0x004C1210)(ref this);
    // void __thiscall VendorItemsUI::AddTypeFilter(VendorItemsUI*,const StringInfo*,unsigned int)
    public void AddTypeFilter(ACBindings.StringInfo* text, uint filter) => ((delegate* unmanaged[Thiscall]<ref ACBindings.VendorItemsUI, ACBindings.StringInfo*, uint, void>)0x004C1240)(ref this, text, filter);
    // void __thiscall VendorItemsUI::UpdateQuantityOverlay(VendorItemsUI*)
    public void UpdateQuantityOverlay() => ((delegate* unmanaged[Thiscall]<ref ACBindings.VendorItemsUI, void>)0x004C18B0)(ref this);
    // char __stdcall VendorItemsUI::ListContainsType(int,int)
    public static sbyte ListContainsType(int a1, int a2) => ((delegate* unmanaged[Stdcall]<int, int, sbyte>)0x004C1980)(a1, a2);
    // void __thiscall VendorItemsUI::OpenVendor(VendorItemsUI*,bool)
    public void OpenVendor(byte updating) => ((delegate* unmanaged[Thiscall]<ref ACBindings.VendorItemsUI, byte, void>)0x004C22C0)(ref this, updating);
    // void __thiscall VendorItemsUI::UpdateItemsList(VendorItemsUI*,int,bool)
    public void UpdateItemsList(int item_type, byte selectFirst) => ((delegate* unmanaged[Thiscall]<ref ACBindings.VendorItemsUI, int, byte, void>)0x004C2A90)(ref this, item_type, selectFirst);
    // void __thiscall VendorItemsUI::UpdateItemsUI(VendorItemsUI*)
    public void UpdateItemsUI() => ((delegate* unmanaged[Thiscall]<ref ACBindings.VendorItemsUI, void>)0x004C44D0)(ref this);
    // void __thiscall VendorItemsUI::RemoveFromShop(VendorItemsUI*,ACCWeenieObject*,int)
    public void RemoveFromShop(ACBindings.ACCWeenieObject* weenObj, int amountBought) => ((delegate* unmanaged[Thiscall]<ref ACBindings.VendorItemsUI, ACBindings.ACCWeenieObject*, int, void>)0x004C48D0)(ref this, weenObj, amountBought);
    // void __thiscall VendorItemsUI::AddToBuyList(VendorItemsUI*,ACCWeenieObject*,int)
    public void AddToBuyList(ACBindings.ACCWeenieObject* weenObj, int amountBuyingNow) => ((delegate* unmanaged[Thiscall]<ref ACBindings.VendorItemsUI, ACBindings.ACCWeenieObject*, int, void>)0x004C49B0)(ref this, weenObj, amountBuyingNow);
    // void __thiscall VendorItemsUI::HandleSetSelectedItem(VendorItemsUI*,unsigned int,unsigned int)
    public void HandleSetSelectedItem(uint oldSelectedID, uint selectedID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.VendorItemsUI, uint, uint, void>)0x004C55A0)(ref this, oldSelectedID, selectedID);
}

