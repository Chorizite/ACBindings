namespace ACBindings.Internal;


/// <summary>Encapsulates the user interface element linked to a shop vendor, storing a reference to its parent UI context and enabling operations such as retrieving vendor IDs or modifying item stacks.</summary>
public unsafe struct VendorSubUI
{
    // Child Types
    public unsafe struct VendorSubUI_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.VendorSubUI*, byte, void> OpenVendor; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.VendorSubUI*, void> CloseVendor; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.VendorSubUI*, uint, uint, void> HandleSetSelectedItem; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public ACBindings.Internal.gmVendorUI* m_parent;

    // Methods

    /// <summary>Retrieves the unique identifier of the shop vendor associated with this UI component.
    /// <code>Offset: 0x004C0E90
    /// unsigned int __thiscall VendorSubUI::GetShopVendorID(VendorSubUI*)</code>
    /// </summary>
    /// <returns>The unsigned integer representing the shop's vendor ID.</returns>
    public uint GetShopVendorID() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VendorSubUI, uint>)0x004C0E90)(ref this);

    /// <summary>Adjusts an object’s stack size, scaling its stored value proportionally to reflect the new quantity.
    /// <code>Offset: 0x004C1110
    /// void __thiscall VendorSubUI::SetObjectStackSize(VendorSubUI*,ACCWeenieObject*,int)</code>
    /// </summary>
    /// <param name="weenObj">The target item whose stack size and value are to be modified.</param>
    /// <param name="stackSize">The desired number of units in a single stack. If zero, treated as one.</param>
    public void SetObjectStackSize(ACBindings.Internal.ACCWeenieObject* weenObj, int stackSize) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VendorSubUI, ACBindings.Internal.ACCWeenieObject*, int, void>)0x004C1110)(ref this, weenObj, stackSize);
}

