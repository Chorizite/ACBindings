namespace ACBindings.Internal;


/// <summary>Stores configuration data for a game region, including map identifiers and clearing parameters used during initialization and auto‑testing phases.</summary>
public unsafe struct RegionMisc
{
    // Members
    public uint version;
    public ACBindings.Internal.IDClass____tagDataID game_map;
    public ACBindings.Internal.IDClass____tagDataID autotest_map;
    public uint autotest_map_size;
    public ACBindings.Internal.IDClass____tagDataID clear_cell;
    public ACBindings.Internal.IDClass____tagDataID clear_monster;

    // Methods

    /// <summary>Serializes the RegionMisc data into a contiguous block of 4‑byte values, advancing the write pointer and reducing the available buffer size for each field written.
    /// <code>Offset: 0x004FF5A0
    /// unsigned int __thiscall RegionMisc::Pack(RegionMisc*,void**,unsigned int*)</code>
    /// </summary>
    /// <param name="addr">Pointer to current position in the output buffer; advanced by four bytes for every field serialized.</param>
    /// <param name="size">Pointer to remaining byte count of the buffer; decremented by four after each field is written.</param>
    /// <returns>Number of unused bytes left in the buffer after attempting to pack all fields.</returns>
    public uint Pack(void** addr, uint* size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RegionMisc, void**, uint*, uint>)0x004FF5A0)(ref this, addr, size);

    /// <summary>Deserializes RegionMisc data from a binary buffer, updating the struct's fields sequentially.
    /// <code>Offset: 0x004FF640
    /// int __thiscall RegionMisc::UnPack(RegionMisc*,void**,unsigned int*)</code>
    /// </summary>
    /// <param name="addr">Reference to a pointer pointing to the current position in the input buffer; updated as data is read.</param>
    /// <param name="size">Pointer to the remaining size of the buffer; decremented accordingly after each field is extracted.</param>
    /// <returns>Always returns 1 to indicate successful unpacking.</returns>
    public int UnPack(void** addr, uint* size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RegionMisc, void**, uint*, int>)0x004FF640)(ref this, addr, size);
}

