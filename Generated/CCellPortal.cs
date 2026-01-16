namespace ACBindings.Internal;


/// <summary>Defines a connection between two adjacent cells via a shared portal polygon, holding identifiers, pointers to the neighboring cell and portal geometry, and metadata used for traversal decisions.</summary>
public unsafe struct CCellPortal
{
    // Members
    public uint other_cell_id;
    public ACBindings.Internal.CEnvCell* other_cell_ptr;
    public ACBindings.Internal.CPolygon* portal;
    public int portal_side;
    public int other_portal_id;
    public int exact_match;

    // Generated Constructor
    public CCellPortal() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>Initializes a new CCellPortal instance with default values for cell references, portal geometry, and matching flags.
    /// <code>Offset: 0x0053C770
    /// void __thiscall CCellPortal::CCellPortal(CCellPortal*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CCellPortal, void>)0x0053C770)(ref this);

    /// <summary>Retrieves the environment cell connected through this portal via its stored identifier.
    /// <code>Offset: 0x0053C790
    /// CEnvCell* __thiscall CCellPortal::GetOtherCell(CCellPortal*,int)</code>
    /// </summary>
    /// <param name="do_not_load">Flag indicating whether to avoid loading the target cell; currently ignored by the implementation.</param>
    /// <returns>A pointer to the visible adjacent CEnvCell, or null if it is not visible.</returns>
    public ACBindings.Internal.CEnvCell* GetOtherCell(int do_not_load) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CCellPortal, int, ACBindings.Internal.CEnvCell*>)0x0053C790)(ref this, do_not_load);

    /// <summary>Packs portal information into a binary buffer, writing an 8‑byte header consisting of flags and identifiers for the connected cell and portal.
    /// <code>Offset: 0x0053C7A0
    /// unsigned int __thiscall CCellPortal::Pack(CCellPortal*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the destination buffer; after packing it points to the byte following the written data.</param>
    /// <param name="size">Size in bytes of the available buffer space; must be at least 8 for successful packing.</param>
    /// <returns>The number of bytes written (always 8).</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CCellPortal, void**, uint, uint>)0x0053C7A0)(ref this, addr, size);

    /// <summary>Unpacks portal data from a binary stream, filling the CCellPortal instance with polygon ID, side flags, and linked cell information.
    /// <code>Offset: 0x0053C810
    /// int __thiscall CCellPortal::UnPack(CCellPortal*,unsigned int,unsigned __int16*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="block_mask">Mask applied to other_cell_id when the link flag is unset; otherwise -1 is stored.</param>
    /// <param name="poly_id">Receives the identifier of the portal's polygon.</param>
    /// <param name="addr">Pointer to the current position in the input buffer; advanced as data is read.</param>
    /// <param name="size">Size of the remaining buffer (not used internally but provided for consistency).</param>
    /// <returns>1 if the unpacking succeeds; the function currently always returns success.</returns>
    public int UnPack(uint block_mask, ushort* poly_id, void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CCellPortal, uint, ushort*, void**, uint, int>)0x0053C810)(ref this, block_mask, poly_id, addr, size);
}

