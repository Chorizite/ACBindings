namespace ACBindings.Internal;


/// <summary>Holds a collection of sound data entries indexed by unique identifiers, enabling efficient lookup and management within the audio subsystem.</summary>
public unsafe struct SoundTableData
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj
    public ACBindings.Internal.IntrusiveHashData__uint___SoundTableData_ptr BaseClass_IntrusiveHashData; // ACBindings.Internal.IntrusiveHashData__uint___SoundTableData_ptr

    // Child Types
    public unsafe struct SoundTableData_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SoundTableData*, void> SoundTableData_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SoundTableData*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SoundTableData*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SoundTableData*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.IntrusiveHashTable__uint___SoundTableData_ptr sound_hash_;
    public uint num_stdatas_;
    public ACBindings.Internal.SoundData* data_;

    // Generated Constructor
    public SoundTableData() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>Collects all sound data identifiers belonging to this instance into the supplied array, traversing both its direct entries and any related entries stored in the internal hash table.
    /// <code>Offset: 0x00552980
    /// void __thiscall SoundTableData::GetSubDataIDs(SoundTableData*,QualifiedDataIDArray*)</code>
    /// </summary>
    /// <param name="id_array">Array that will receive the collected QualifiedDataID objects.</param>
    public void GetSubDataIDs(ACBindings.Internal.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SoundTableData, ACBindings.Internal.QualifiedDataIDArray*, void>)0x00552980)(ref this, id_array);

    /// <summary>Computes the total packed byte size required for this sound table, including its own data and any linked hash buckets.
    /// <code>Offset: 0x00552A40
    /// unsigned int __thiscall SoundTableData::pack_size(SoundTableData*)</code>
    /// </summary>
    /// <returns>The cumulative size in bytes necessary to serialize the object.</returns>
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SoundTableData, uint>)0x00552A40)(ref this);

    /// <summary>Packs the sound table data into a binary buffer, writing its hash key, the count of standard sounds, each sound’s ID, priority, probability, and volume, then recursively packs any nested hash entries. The output is aligned to a 4‑byte boundary.
    /// <code>Offset: 0x00552AD0
    /// unsigned int __thiscall SoundTableData::Pack(SoundTableData*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current write position in the buffer; after packing, it points to the byte following the last written datum.</param>
    /// <param name="size">Maximum number of bytes available for writing. If this value is smaller than the amount required by pack_size(this), no data is written and the function returns the needed size.</param>
    /// <returns>The total number of bytes that would have been written, i.e., the value returned by SoundTableData::pack_size(this). This value is also returned when the supplied buffer has sufficient space.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SoundTableData, void**, uint, uint>)0x00552AD0)(ref this, addr, size);

    /// <summary>Locates a sound table entry matching the specified type and reports success.
    /// <code>Offset: 0x00552D20
    /// int __thiscall SoundTableData::Lookup(SoundTableData*,SoundType,SoundTableData**)</code>
    /// </summary>
    /// <param name="stype">The sound type key used to search the hash table.</param>
    /// <param name="lookup_stdata">Receives the found SoundTableData pointer, or null if not found.</param>
    /// <returns>1 when an entry with the given type exists; 0 otherwise.</returns>
    public int Lookup(ACBindings.Internal.SoundType stype, ACBindings.Internal.SoundTableData** lookup_stdata) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SoundTableData, ACBindings.Internal.SoundType, ACBindings.Internal.SoundTableData**, int>)0x00552D20)(ref this, stype, lookup_stdata);

    /// <summary>Initializes a new sound table entry, setting up its hash structure and allocating a single default SoundData record with standard defaults (ID = 0, priority = 0, probability = 1, volume = 1).
    /// <code>Offset: 0x00552DC0
    /// void __thiscall SoundTableData::SoundTableData(SoundTableData*)</code>
    /// </summary>
    /// <param name="this">The instance to initialize.</param>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SoundTableData, void>)0x00552DC0)(ref this);

    /// <summary>Destroys the sound table data structure, freeing all stored sounds and deallocating associated resources.
    /// <code>Offset: 0x00552F20
    /// void __thiscall SoundTableData::Destroy(SoundTableData*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SoundTableData, void>)0x00552F20)(ref this);

    /// <summary>Deserializes a SoundTableData instance from binary data supplied through addr, initializing its hash key, sound entries, and nested tables.
    /// <code>Offset: 0x00552F90
    /// int __thiscall SoundTableData::UnPack(SoundTableData*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Reference to the current read position in the input buffer; advanced as data is consumed.</param>
    /// <param name="size">Remaining size of the input buffer used when reading sub‑tables.</param>
    /// <returns>Success flag (1 on success).</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SoundTableData, void**, uint, int>)0x00552F90)(ref this, addr, size);
}

