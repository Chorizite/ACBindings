namespace ACBindings.Internal;


/// <summary>Contains identifiers and collections needed to shift texture palettes during rendering. Stores a texture ID along with arrays of sub‑palettes, road codes, and terrain palettes that define palette changes for various environmental states.</summary>
public unsafe struct PalShiftTex
{
    // Members
    public ACBindings.Internal.IDClass____tagDataID tex_gid;
    public ACBindings.Internal.AC1Legacy.SmartArray___PalShiftSubPal_ptr sub_pal;
    public ACBindings.Internal.AC1Legacy.SmartArray___PalShiftRoadCode_ptr road_code;
    public ACBindings.Internal.AC1Legacy.SmartArray___PalShiftTerrainPal_ptr terrain_pal;

    // Methods

    /// <summary>Destroys all allocated resources associated with the palette shift texture, including sub palettes, road codes, and terrain palettes, then resets internal counters.
    /// <code>Offset: 0x00500A40
    /// void __thiscall PalShiftTex::Destroy(PalShiftTex*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PalShiftTex, void>)0x00500A40)(ref this);

    /// <summary>Packs texture shift data into a binary buffer, writing identifiers and associated arrays while advancing the write pointer and reducing the available size.
    /// <code>Offset: 0x00500B30
    /// unsigned int __thiscall PalShiftTex::Pack(PalShiftTex*,void**,unsigned int*)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current write location; will be updated to point after the newly written data.</param>
    /// <param name="size">Remaining byte count of the destination buffer; must be at least 4 before any write and is decreased by each write. The function returns this updated value.</param>
    /// <returns>The number of bytes left unfilled in the buffer after packing.</returns>
    public uint Pack(void** addr, uint* size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PalShiftTex, void**, uint*, uint>)0x00500B30)(ref this, addr, size);

    /// <summary>Unpacks a serialized PalShiftTex object from the supplied buffer, initializing texture ID, sub‑palettes, road codes, and terrain palettes.
    /// <code>Offset: 0x00500F70
    /// int __thiscall PalShiftTex::UnPack(PalShiftTex*,void**,unsigned int*)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current read position within the data buffer.</param>
    /// <param name="size">Pointer to the number of bytes remaining in the buffer.</param>
    /// <returns>Always returns 1, indicating successful unpacking.</returns>
    public int UnPack(void** addr, uint* size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PalShiftTex, void**, uint*, int>)0x00500F70)(ref this, addr, size);
}

