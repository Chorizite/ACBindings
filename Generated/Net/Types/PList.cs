namespace ACBindings.Internal;


/// <summary>
/// Represents a specialized list of unsigned long integers with optimized alignment and packing for legacy systems. Encapsulates underlying AC1Legacy::List functionality while incorporating PackObj to handle memory layout.
/// </summary>
public unsafe struct PList__uint
{
    // Base Classes
    public ACBindings.Internal.AC1Legacy.List__uint BaseClass_AC1Legacy_List; // ACBindings.Internal.AC1Legacy.List__uint
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Methods
}


/// <summary>Combines a linked list of FriendData with packing functionality for efficient serialization and memory alignment. Used to manage friend relationships within the application, ensuring data consistency when storing or transmitting lists.</summary>
public unsafe struct PList___FriendData
{
    // Base Classes
    public ACBindings.Internal.AC1Legacy.List___FriendData BaseClass_AC1Legacy_List; // ACBindings.Internal.AC1Legacy.List___FriendData
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Methods
}

public unsafe struct PList___SpellSetTierList
{
    // Base Classes
    public ACBindings.Internal.AC1Legacy.List___SpellSetTierList BaseClass_AC1Legacy_List; // ACBindings.Internal.AC1Legacy.List___SpellSetTierList
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Methods

    /// <summary>Packs the SpellSetTierList into an array, storing its element count followed by each entry’s serialized data. Packing proceeds only when the supplied limit a3 is not less than the list size.
    /// <code>Offset: 0x00598CB0
    /// unsigned int __thiscall PList&lt;SpellSetTierList&gt;::Pack(_DWORD*,_DWORD**,unsigned int)</code>
    /// </summary>
    /// <param name="a2">Address of a pointer that receives the output buffer; the pointer is advanced as values are written.</param>
    /// <param name="a3">Maximum allowed count; packing occurs only if this value is greater than or equal to the number of elements in the list.</param>
    /// <returns>The total number of elements in the list.</returns>
    // unsigned int __thiscall PList<SpellSetTierList>::Pack(_DWORD*,_DWORD**,unsigned int) (template type method)

    /// <summary>Calculates the total network packet size required for serializing the SpellSetTierList collection, including per-element data and a fixed header overhead.
    /// <code>Offset: 0x00598D00
    /// int __thiscall PList&lt;SpellSetTierList&gt;::GetPackSize(_DWORD*)</code>
    /// </summary>
    /// <returns>The combined packet size in bytes as an integer.</returns>
    // int __thiscall PList<SpellSetTierList>::GetPackSize(_DWORD*) (template type method)

    /// <summary>Deserializes a sequence of SpellSetTierList objects from the supplied buffer into this PList instance.
    /// <code>Offset: 0x00598D40
    /// int __thiscall PList&lt;SpellSetTierList&gt;::UnPack(_DWORD*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="a2">Reference to a pointer that tracks current read position; advanced as data is consumed.</param>
    /// <param name="a3">Number of bytes remaining in the input buffer.</param>
    /// <returns>1 if all elements were successfully unpacked and added, 0 otherwise.</returns>
    // int __thiscall PList<SpellSetTierList>::UnPack(_DWORD*,void**,unsigned int) (template type method)
}

