namespace ACBindings.Internal;


/// <summary>Represents a single inventory placement, holding its unique identifier, location flags within the UI, and display priority for sorting or selection.</summary>
public unsafe struct InventoryPlacement
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct InventoryPlacement_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.InventoryPlacement*, void> InventoryPlacement_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.InventoryPlacement*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.InventoryPlacement*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.InventoryPlacement*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public uint iid_;
    public uint loc_;
    public uint priority_;

    // Methods

    /// <summary>Packs the shortcut data (index, object ID, spell ID) into a contiguous memory buffer of at least 12 bytes.
    /// <code>Offset: 0x004A3880
    /// unsigned int __thiscall InventoryPlacement::Pack(ShortCutData*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current write position in the buffer; updated to point after the packed data.</param>
    /// <param name="size">Remaining size of the buffer in bytes; must be ≥12 for successful packing.</param>
    /// <returns>Number of bytes written (always 12).</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.InventoryPlacement, void**, uint, uint>)0x004A3880)(ref this, addr, size);

    /// <summary>Deserializes an InventoryPlacement object from a binary buffer.
    /// <code>Offset: 0x004A38C0
    /// int __thiscall InventoryPlacement::UnPack(InventoryPlacement*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current read position in the buffer; updated to point past the consumed data.</param>
    /// <param name="size">Size of the remaining data in the buffer (unused by this method).</param>
    /// <returns>Always returns 1 to indicate successful unpacking.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.InventoryPlacement, void**, uint, int>)0x004A38C0)(ref this, addr, size);

    /// <summary>Selects the InventoryPlacement with the higher effective priority between two candidates, optionally boosting priority for placements whose location matches a relevant bitmask and have no explicit priority.
    /// <code>Offset: 0x004A4820
    /// InventoryPlacement* __cdecl InventoryPlacement::DetermineHigherPriority(InventoryPlacement*,InventoryPlacement*,unsigned int)</code>
    /// </summary>
    /// <param name="ip1">The first candidate placement to compare.</param>
    /// <param name="ip2">The second candidate placement to compare.</param>
    /// <param name="releventLocations">A bitmask of locations used to determine whether a zero‑priority placement should be temporarily elevated to the maximum priority of 127.</param>
    /// <returns>A pointer to the placement with the higher effective priority; if both placements have equal or lower priorities, returns the first argument (ip1).</returns>
    public static ACBindings.Internal.InventoryPlacement* DetermineHigherPriority(ACBindings.Internal.InventoryPlacement* ip1, ACBindings.Internal.InventoryPlacement* ip2, uint releventLocations) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.InventoryPlacement*, ACBindings.Internal.InventoryPlacement*, uint, ACBindings.Internal.InventoryPlacement*>)0x004A4820)(ip1, ip2, releventLocations);
}

