namespace ACBindings.Internal;


/// <summary>Manages dynamic palette shifting for land textures, tracking the currently selected texture, its associated subpalettes, and terrain palette references.</summary>
/// <remarks>Provides functionality to create new surfaces with modified palettes, select rotations based on terrain suitability, serialize/deserialize texture data, and clean up allocated resources.</remarks>
public unsafe struct PalShift : System.IDisposable
{
    // Members
    public uint cur_tex;
    public ACBindings.Internal.AC1Legacy.SmartArray___PalShiftTex_ptr land_tex;
    public ACBindings.Internal.Subpalette* sub_pals;
    public uint maxsubs;

    // Generated Constructor
    public PalShift() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Releases the palette associated with the surface and frees its custom surface data.
    /// <code>Offset: 0x005004C0
    /// void __thiscall PalShift::CleanupSurface(PalShift*,CSurface*)</code>
    /// </summary>
    /// <param name="surf">The CSurface instance to clean up; may be null.</param>
    public void CleanupSurface(ACBindings.Internal.CSurface* surf) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PalShift, ACBindings.Internal.CSurface*, void>)0x005004C0)(ref this, surf);

    /// <summary>Computes a rotation index either by selecting the smallest code in the provided array when minimize_pal is true, or by evaluating a hash‑based formula from x and y coordinates otherwise.
    /// <code>Offset: 0x005004E0
    /// unsigned int __thiscall PalShift::GetBeginRotIx(PalShift*,int,int,unsigned int*,int)</code>
    /// </summary>
    /// <param name="this">The PalShift instance on which to operate.</param>
    /// <param name="x">Horizontal coordinate used for the hash calculation.</param>
    /// <param name="y">Vertical coordinate used for the hash calculation.</param>
    /// <param name="pcode">Array of four unsigned integer codes representing possible palette indices.</param>
    /// <param name="minimize_pal">If true, selects the smallest code; if false, calculates a deterministic index from x and y.</param>
    /// <returns>The selected or computed rotation index as an unsigned int.</returns>
    public uint GetBeginRotIx(int x, int y, uint* pcode, int minimize_pal) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PalShift, int, int, uint*, int, uint>)0x005004E0)(ref this, x, y, pcode, minimize_pal);

    /// <summary>Initializes a new PalShift instance by clearing its texture array and subpalette references.
    /// <code>Offset: 0x00500680
    /// void __thiscall PalShift::PalShift(PalShift*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PalShift, void>)0x00500680)(ref this);

    /// <summary>
    /// Creates or updates the collection of subpalettes for the current texture, allocating memory when necessary and populating each subpalette with data derived from the supplied palette source and lookup table.
    /// 
    /// <code>Offset: 0x005006A0
    /// unsigned int __thiscall PalShift::MakeSubPal(_DWORD*,int*,_DWORD*,char,int,int)</code>
    /// </summary>
    /// <param name="a2">Receives the number of subpalettes generated.</param>
    /// <param name="a3">Pointer to the storage that will hold the constructed subpalettes; it is allocated or resized as needed.</param>
    /// <param name="a4">Index used to select palette entries from the source data.</param>
    /// <param name="a5">Base address of the palette data used for constructing the subpalettes.</param>
    /// <param name="a6">Lookup index controlling how subpalette entries are composed.</param>
    /// <returns>The number of subpalettes processed, which equals the value written to *a2.</returns>
    public uint MakeSubPal(int* a2, int* a3, sbyte a4, int a5, int a6) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PalShift, int*, int*, sbyte, int, int, uint>)0x005006A0)(ref this, a2, a3, a4, a5, a6);

    /// <summary>Checks whether the supplied terrain data satisfies the constraints defined by the current palette shift and writes matched indices into the provided array.
    /// <code>Offset: 0x00500880
    /// int __thiscall PalShift::CheckTerrain(_DWORD*,unsigned int,_DWORD*)</code>
    /// </summary>
    /// <param name="a2">Bit‑encoded descriptor specifying required terrain properties for each direction.</param>
    /// <param name="a3">Array where the function stores subpalette indices for up to four directions and an optional fifth entry; caller should provide space for at least five elements.</param>
    /// <returns>Non‑zero if all checks succeed, otherwise zero.</returns>
    public int CheckTerrain(uint a2, int* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PalShift, uint, int*, int>)0x00500880)(ref this, a2, a3);

    /// <summary>Checks for a rotated road code matching the given pattern within the current land texture and returns its index.
    /// <code>Offset: 0x00500980
    /// int __thiscall PalShift::CheckRot(PalShift*,unsigned int,unsigned int*)</code>
    /// </summary>
    /// <param name="pcode">Bit field encoding rotation information used to compute the target road code.</param>
    /// <param name="rindex">Receives the zero‑based index of the matching road code if one is found; remains unchanged otherwise.</param>
    /// <returns>Non‑zero (1) when a matching road code exists, zero when it does not.</returns>
    public int CheckRot(uint pcode, uint* rindex) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PalShift, uint, uint*, int>)0x00500980)(ref this, pcode, rindex);

    /// <summary>Computes the byte count needed to serialize PalShift's land textures, including subpalettes and terrain palettes.
    /// <code>Offset: 0x005009F0
    /// unsigned int __thiscall PalShift::pack_size(PalShift*)</code>
    /// </summary>
    /// <returns>The total size in bytes required for packing.</returns>
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PalShift, uint>)0x005009F0)(ref this);

    /// <summary>Collects qualified data identifiers of all land textures and their associated terrain palette IDs into the supplied QualifiedDataIDArray.
    /// <code>Offset: 0x00500CE0
    /// void __thiscall PalShift::GetSubDataIDs(PalShift*,QualifiedDataIDArray*)</code>
    /// </summary>
    /// <param name="id_array">The array to receive the collected data identifiers.</param>
    public void GetSubDataIDs(ACBindings.Internal.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PalShift, ACBindings.Internal.QualifiedDataIDArray*, void>)0x00500CE0)(ref this, id_array);

    /// <summary>Chooses a texture rotation for the current PalShift based on coordinates, terrain suitability, and rotation validation, updating cur_tex and returning an appropriate palette code.
    /// <code>Offset: 0x00500D90
    /// unsigned int __thiscall PalShift::SelectRot(PalShift*,int,int,int*,unsigned int*,int,_DWORD*,unsigned int*,int)</code>
    /// </summary>
    /// <param name="x">X coordinate used in computing the initial texture index.</param>
    /// <param name="y">Y coordinate used together with x to determine the starting texture candidate.</param>
    /// <param name="a4">Receives the selected rotation index (0–3) after a successful CheckRot; set to 0 when no valid texture is found.</param>
    /// <param name="pcode">Array of candidate palette codes; one that passes terrain and rotation checks is returned.</param>
    /// <param name="a6">Unused parameter retained for API compatibility.</param>
    /// <param name="a7">Pointer to data supplied to CheckTerrain during validation.</param>
    /// <param name="rindex">Receives the index produced by CheckRot corresponding to the chosen rotation.</param>
    /// <param name="minimize_pal">Flag that influences the initial rotation selection in GetBeginRotIx.</param>
    /// <returns>Palette code from pcode array satisfying terrain and rotation tests; if none are valid, returns the first element of pcode while setting cur_tex to 0 and a4 to 0.</returns>
    public uint SelectRot(int x, int y, int* a4, uint* pcode, int a6, int* a7, uint* rindex, int minimize_pal) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PalShift, int, int, int*, uint*, int, int*, uint*, int, uint>)0x00500D90)(ref this, x, y, a4, pcode, a6, a7, rindex, minimize_pal);

    /// <summary>Creates a new surface that applies a palette shift to the current texture using a generated subpalette.
    /// <code>Offset: 0x00500EA0
    /// CSurface* __thiscall PalShift::MakeNewSurface(_DWORD*,int,char,int,int)</code>
    /// </summary>
    /// <param name="a2">Index of the base texture; currently unused but retained for compatibility.</param>
    /// <param name="a3">Flag controlling how the subpalette is applied.</param>
    /// <param name="a4">Additional modifier for subpalette selection (not directly used).</param>
    /// <param name="numSubs">Number of subpalettes to generate and apply.</param>
    /// <returns>A pointer to a newly created CSurface configured with the modified texture and palette.</returns>
    public ACBindings.Internal.CSurface* MakeNewSurface(int a2, sbyte a3, int a4, int numSubs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PalShift, int, sbyte, int, int, ACBindings.Internal.CSurface*>)0x00500EA0)(ref this, a2, a3, a4, numSubs);

    /// <summary>Packs the PalShift data into a binary buffer by writing the texture count followed by each individual texture’s packed representation.
    /// <code>Offset: 0x00500F20
    /// unsigned int __thiscall PalShift::Pack(PalShift*,void**,unsigned int*)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current write location within the destination buffer.</param>
    /// <param name="size">Pointer to the remaining space in the buffer; updated as bytes are written and returned value reflects unused bytes after packing.</param>
    /// <returns>Number of bytes left in the buffer after packing.</returns>
    public uint Pack(void** addr, uint* size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PalShift, void**, uint*, uint>)0x00500F20)(ref this, addr, size);

    /// <summary>Releases all textures and subpalette data owned by a PalShift instance, freeing allocated memory and resetting internal state.
    /// <code>Offset: 0x00501280
    /// void __thiscall PalShift::Destroy(PalShift*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PalShift, void>)0x00501280)(ref this);

    /// <summary>Unpacks texture shift data from a serialized buffer into this PalShift object.
    /// <code>Offset: 0x00501320
    /// int __thiscall PalShift::UnPack(PalShift*,void**,unsigned int*)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current read location in the input buffer; will be advanced as data is consumed.</param>
    /// <param name="size">Pointer to the number of bytes remaining in the buffer; updated to reflect bytes consumed during unpacking.</param>
    /// <returns>Non‑zero on successful completion of all texture entries, zero if an error occurs while allocating or unpacking a PalShiftTex instance.</returns>
    public int UnPack(void** addr, uint* size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PalShift, void**, uint*, int>)0x00501320)(ref this, addr, size);

    /// <summary>Destroys a PalShift instance by freeing its land texture array and performing cleanup via PalShift::Destroy.
    /// <code>Offset: 0x00501430
    /// void __thiscall PalShift::~PalShift(PalShift*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PalShift, void>)0x00501430)(ref this);
}

