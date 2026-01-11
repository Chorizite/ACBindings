namespace ACBindings.Internal;

public unsafe struct VendorSubUI
{
    // Child Types
    public unsafe struct VendorSubUI_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VendorSubUI*, byte, void> OpenVendor; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VendorSubUI*, void> CloseVendor; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VendorSubUI*, uint, uint, void> HandleSetSelectedItem; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public ACBindings.Internal.gmVendorUI* m_parent;

    // Methods

    /// <summary>
    /// <code>Offset: 0x004C0E90
    /// unsigned int __thiscall VendorSubUI::GetShopVendorID(VendorSubUI*)</code>
    /// </summary>
    public uint GetShopVendorID() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VendorSubUI, uint>)0x004C0E90)(ref this);

    /// <summary>
    /// <code>Offset: 0x004C1110
    /// void __thiscall VendorSubUI::SetObjectStackSize(VendorSubUI*,ACCWeenieObject*,int)</code>
    /// </summary>
    public void SetObjectStackSize(ACBindings.Internal.ACCWeenieObject* weenObj, int stackSize) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VendorSubUI, ACBindings.Internal.ACCWeenieObject*, int, void>)0x004C1110)(ref this, weenObj, stackSize);
}

