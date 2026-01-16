namespace ACBindings.Internal;


/// <summary>Represents the configuration of an in‑game vendor, specifying which item types it accepts, price multipliers for buying and selling, and identifiers that define its trade interface.</summary>
public unsafe struct VendorProfile
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct VendorProfile_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.VendorProfile*, void> VendorProfile_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.VendorProfile*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.VendorProfile*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.VendorProfile*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public uint item_types;
    public int min_value;
    public int max_value;
    public int magic;
    public float buy_price;
    public float sell_price;
    public ACBindings.Internal.IDClass____tagDataID trade_id;
    public int trade_num;
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte trade_name;

    // Generated Constructor
    public VendorProfile() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>Checks an item against the vendor’s acceptability rules, validating type compatibility and value bounds.
    /// <code>Offset: 0x005D2A90
    /// unsigned int __thiscall VendorProfile::InqAcceptability(VendorProfile*,PublicWeenieDesc*)</code>
    /// </summary>
    /// <param name="item">Item descriptor being evaluated.</param>
    /// <returns>0 if acceptable; non‑zero codes indicate rejection reasons: 1 for incompatible type or restricted flag, 2 for zero per‑unit value, 3 for below the minimum value, and a vendor‑specific code when exceeding the maximum value.</returns>
    public uint InqAcceptability(ACBindings.Internal.PublicWeenieDesc* item) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VendorProfile, ACBindings.Internal.PublicWeenieDesc*, uint>)0x005D2A90)(ref this, item);

    /// <summary>Calculates the vendor's sell price for an item, considering its type and stack size.
    /// <code>Offset: 0x005D2B00
    /// int __thiscall VendorProfile::VendorSellPrice(VendorProfile*,PublicWeenieDesc*,unsigned int)</code>
    /// </summary>
    /// <param name="item">Descriptor of the item being sold.</param>
    /// <param name="subAmount">Number of units to use when computing the price.</param>
    /// <returns>The computed sell price in game currency units.</returns>
    public int VendorSellPrice(ACBindings.Internal.PublicWeenieDesc* item, uint subAmount) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VendorProfile, ACBindings.Internal.PublicWeenieDesc*, uint, int>)0x005D2B00)(ref this, item, subAmount);

    /// <summary>Determines whether the specified item meets the vendor's acceptance criteria.
    /// <code>Offset: 0x005D2B50
    /// int __thiscall VendorProfile::IsAcceptable(VendorProfile*,PublicWeenieDesc*)</code>
    /// </summary>
    /// <param name="item">The description of the item to evaluate.</param>
    /// <returns>Non‑zero if the item is acceptable; zero otherwise.</returns>
    public int IsAcceptable(ACBindings.Internal.PublicWeenieDesc* item) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VendorProfile, ACBindings.Internal.PublicWeenieDesc*, int>)0x005D2B50)(ref this, item);

    /// <summary>Computes the purchase price that this vendor profile will offer for a specified item.
    /// <code>Offset: 0x005D2B70
    /// int __thiscall VendorProfile::VendorBuyPrice(VendorProfile*,PublicWeenieDesc*,PublicWeenieDesc*)</code>
    /// </summary>
    /// <param name="vendor">The vendor's weenie descriptor (currently unused in the calculation).</param>
    /// <param name="item">The item to be bought, whose value and stack size influence the final price.</param>
    /// <returns>Zero if the vendor rejects the item; otherwise, an integer representing the amount of currency offered for the item or its stack.</returns>
    public int VendorBuyPrice(ACBindings.Internal.PublicWeenieDesc* vendor, ACBindings.Internal.PublicWeenieDesc* item) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VendorProfile, ACBindings.Internal.PublicWeenieDesc*, ACBindings.Internal.PublicWeenieDesc*, int>)0x005D2B70)(ref this, vendor, item);

    /// <summary>Copies the vendor's trade currency identifier into the supplied buffer and returns that buffer.
    /// <code>Offset: 0x005D2BD0
    /// _DWORD* __thiscall VendorProfile::VendorTradeCurrency(_DWORD*,_DWORD*)</code>
    /// </summary>
    /// <param name="a2">Pointer to a DWORD where the trade currency ID will be stored.</param>
    /// <returns>The same pointer provided in <paramref name="a2"/> after storing the value.</returns>
    public int* VendorTradeCurrency(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VendorProfile, int*, int*>)0x005D2BD0)(ref this, a2);

    /// <summary>Initializes a VendorProfile instance with default configuration: sets item_types and magic to zero, defines price boundaries, assigns an invalid trade identifier, and prepares the trade name buffer for use.
    /// <code>Offset: 0x005D2BE0
    /// void __thiscall VendorProfile::VendorProfile(VendorProfile*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VendorProfile, void>)0x005D2BE0)(ref this);

    /// <summary>Computes the number of bytes needed to serialize this vendor profile, encompassing its trade name and fixed-size components.
    /// <code>Offset: 0x005D2C60
    /// unsigned int __thiscall VendorProfile::GetPackSize(VendorProfile*)</code>
    /// </summary>
    /// <returns>The total pack size in bytes as an unsigned integer.</returns>
    public uint GetPackSize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VendorProfile, uint>)0x005D2C60)(ref this);

    /// <summary>Packs the vendor profile into a contiguous binary buffer.
    /// <code>Offset: 0x005D2C80
    /// unsigned int __thiscall VendorProfile::Pack(VendorProfile*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current write position in the destination buffer; updated as data is written.</param>
    /// <param name="size">Maximum number of bytes available for packing; data is written only if sufficient space exists.</param>
    /// <returns>The total size, in bytes, required to serialize the profile regardless of buffer capacity.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VendorProfile, void**, uint, uint>)0x005D2C80)(ref this, addr, size);

    /// <summary>Populates a VendorProfile instance by reading sequential values from a binary buffer.
    /// <code>Offset: 0x005D2D20
    /// int __thiscall VendorProfile::UnPack(VendorProfile*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current read position; updated past the unpacked data.</param>
    /// <param name="size">Total number of bytes available in the buffer for this operation.</param>
    /// <returns>1 if the unpack succeeds; 0 if the provided size is insufficient.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VendorProfile, void**, uint, int>)0x005D2D20)(ref this, addr, size);
}

