namespace ACBindings.Internal;


/// <summary>Portal linking two building cells, containing side identifiers, connectivity details, geometric stab references, and a sidedness metric.</summary>
public unsafe struct CBldPortal : System.IDisposable
{
    // Members
    public int portal_side;
    public uint other_cell_id;
    public int other_portal_id;
    public int exact_match;
    public uint num_stabs;
    public uint* stab_list;
    public float sidedness;

    // Generated Constructor
    public CBldPortal() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Initializes a new portal instance with default values for its properties.
    /// <code>Offset: 0x0053C890
    /// void __thiscall CBldPortal::CBldPortal(CBldPortal*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CBldPortal, void>)0x0053C890)(ref this);

    /// <summary>Destroys a CBldPortal instance and releases its dynamic stab list array.
    /// <code>Offset: 0x0053C8B0
    /// void __thiscall CBldPortal::~CBldPortal(CBldPortal*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CBldPortal, void>)0x0053C8B0)(ref this);

    /// <summary>Adds the portal's stabs to a caller‑supplied list, preventing duplicates and expanding the buffer as needed.
    /// <code>Offset: 0x0053C8C0
    /// void __thiscall CBldPortal::add_to_stablist(CBldPortal*,unsigned int**,unsigned int*,unsigned int*)</code>
    /// </summary>
    /// <param name="block_stab_list">Reference to an array of unsigned integers that will receive the stabs. The function may reallocate this array if it is full.</param>
    /// <param name="max_size">Pointer to the current allocated size (in elements) of *block_stab_list. If new stabs are added beyond this size, the buffer grows by ten elements.</param>
    /// <param name="stab_num">Pointer to the number of stabs already stored in *block_stab_list; it will be incremented for each new stab added.</param>
    public void add_to_stablist(uint** block_stab_list, uint* max_size, uint* stab_num) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CBldPortal, uint**, uint*, uint*, void>)0x0053C8C0)(ref this, block_stab_list, max_size, stab_num);

    /// <summary>Retrieves the environmental cell on the opposite side of this portal using its stored identifier.
    /// <code>Offset: 0x0053C990
    /// CEnvCell* __thiscall CBldPortal::GetOtherCell(CBldPortal*)</code>
    /// </summary>
    /// <returns>A pointer to the CEnvCell instance corresponding to the portal's other side, or nullptr if no such cell is visible.</returns>
    public ACBindings.Internal.CEnvCell* GetOtherCell() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CBldPortal, ACBindings.Internal.CEnvCell*>)0x0053C990)(ref this);

    /// <summary>Extracts portal information from a binary stream, setting flags and identifiers while allocating an optional list of stabs.
    /// <code>Offset: 0x0053C9A0
    /// int __thiscall CBldPortal::UnPack(CBldPortal*,unsigned int,void**,unsigned int)</code>
    /// </summary>
    /// <param name="block_mask">Mask combined with each read value to form full identifiers.</param>
    /// <param name="addr">Pointer to the current position in the input buffer; advanced as data is consumed.</param>
    /// <param name="size">Total size of the input buffer (unused by this implementation).</param>
    /// <returns>Always returns 1 to indicate successful unpacking.</returns>
    public int UnPack(uint block_mask, void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CBldPortal, uint, void**, uint, int>)0x0053C9A0)(ref this, block_mask, addr, size);

    /// <summary>Attempts to preload static objects referenced by the portal’s stab list. Returns a non‑zero value when every requested object is available in memory or file; returns 0 if any prefetch fails.
    /// <code>Offset: 0x0053CA60
    /// int __thiscall CBldPortal::PreFetchCells(CBldPortal*)</code>
    /// </summary>
    /// <returns>An integer indicating success (non‑zero) or failure (zero).</returns>
    public int PreFetchCells() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CBldPortal, int>)0x0053CA60)(ref this);

    /// <summary>Computes the byte count required to serialize this portal, including header and stab entries, aligning to 4‑byte boundaries.
    /// <code>Offset: 0x0053CAB0
    /// unsigned int __thiscall CBldPortal::pack_size(CBldPortal*)</code>
    /// </summary>
    /// <returns>The total packed size in bytes.</returns>
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CBldPortal, uint>)0x0053CAB0)(ref this);

    /// <summary>Serializes portal information into a binary buffer, advancing the buffer pointer as data is written.
    /// <code>Offset: 0x0053CAD0
    /// unsigned int __thiscall CBldPortal::Pack(CBldPortal*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Reference to a pointer to the destination buffer; updated to point after the serialized data.</param>
    /// <param name="size">Number of bytes available in the destination buffer.</param>
    /// <returns>Byte count required for serialization (including padding for alignment).</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CBldPortal, void**, uint, uint>)0x0053CAD0)(ref this, addr, size);
}

