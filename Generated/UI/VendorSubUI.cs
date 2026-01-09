namespace ACBindings;

// VendorSubUI
public unsafe struct VendorSubUI
{
    // Child Types
    // VendorSubUI_vtbl
    public unsafe struct VendorSubUI_vtbl
    {
        // Members
        public System.IntPtr OpenVendor; // function pointer
        public System.IntPtr CloseVendor; // function pointer
        public System.IntPtr HandleSetSelectedItem; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public ACBindings.gmVendorUI* m_parent;

    // Methods
    // unsigned int __thiscall VendorSubUI::GetShopVendorID(VendorSubUI*)
    public uint GetShopVendorID() => ((delegate* unmanaged[Thiscall]<ref ACBindings.VendorSubUI, uint>)0x004C0E90)(ref this);
    // void __thiscall VendorSubUI::SetObjectStackSize(VendorSubUI*,ACCWeenieObject*,int)
    public void SetObjectStackSize(ACBindings.ACCWeenieObject* weenObj, int stackSize) => ((delegate* unmanaged[Thiscall]<ref ACBindings.VendorSubUI, ACBindings.ACCWeenieObject*, int, void>)0x004C1110)(ref this, weenObj, stackSize);
}

