namespace ACBindings.Internal;


/// <summary>Ambient sound table descriptor, storing identifier, associated sounds, and runtime metadata for lookup and playback.</summary>
/// <remarks>Manages a dynamic array of AmbientSoundDesc objects, tracks play count, and provides serialization support via Pack/UnPack. Initializes the sound table reference by ID through InitSoundTable.</remarks>
public unsafe struct AmbientSTBDesc : System.IDisposable
{
    // Members
    public ACBindings.Internal.IDClass____tagDataID stb_id;
    public int stb_not_found;
    public ACBindings.Internal.AC1Legacy.SmartArray___AmbientSoundDesc_ptr ambient_sounds;
    public ACBindings.Internal.CSoundTable* sound_table;
    public uint play_count;

    // Generated Constructor
    public AmbientSTBDesc() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Initializes the sound table for this descriptor by looking up the table via its ID; marks not found and returns failure if lookup fails.
    /// <code>Offset: 0x004FF4E0
    /// int __thiscall AmbientSTBDesc::InitSoundTable(AmbientSTBDesc*)</code>
    /// </summary>
    /// <returns>An integer indicating success (1) or failure (0).</returns>
    public int InitSoundTable() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AmbientSTBDesc, int>)0x004FF4E0)(ref this);

    /// <summary>Initializes an AmbientSTBDesc instance with default values.
    /// <code>Offset: 0x00551DC0
    /// void __thiscall AmbientSTBDesc::AmbientSTBDesc(AmbientSTBDesc*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AmbientSTBDesc, void>)0x00551DC0)(ref this);

    /// <summary>Destroys an AmbientSTBDesc instance, freeing all allocated AmbientSoundDesc objects and deallocating the internal dynamic array of sound descriptors.
    /// <code>Offset: 0x00551DE0
    /// void __thiscall AmbientSTBDesc::~AmbientSTBDesc(AmbientSTBDesc*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AmbientSTBDesc, void>)0x00551DE0)(ref this);

    /// <summary>Packs the AmbientSTBDesc data into a contiguous binary buffer at the location pointed to by addr, consuming up to *size bytes.
    /// <code>Offset: 0x00551E40
    /// unsigned int __thiscall AmbientSTBDesc::Pack(AmbientSTBDesc*,void**,unsigned int*)</code>
    /// </summary>
    /// <param name="addr">A pointer to the current write position within the destination buffer; it is advanced as data is written.</param>
    /// <param name="size">The number of bytes remaining in the buffer before packing; on return contains the number of unused bytes after serialization.</param>
    /// <returns>The remaining size (bytes) left in the buffer after writing the descriptor, indicating how many bytes were not used by this operation.</returns>
    public uint Pack(void** addr, uint* size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AmbientSTBDesc, void**, uint*, uint>)0x00551E40)(ref this, addr, size);

    /// <summary>Calculates the byte count needed to pack an AmbientSTBDesc object.
    /// <code>Offset: 0x00551F20
    /// unsigned int __thiscall AmbientSTBDesc::pack_size(AmbientSTBDesc*)</code>
    /// </summary>
    /// <returns>The total number of bytes required when serializing the instance, accounting for each ambient sound and a fixed overhead.</returns>
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AmbientSTBDesc, uint>)0x00551F20)(ref this);

    /// <summary>Deserializes an AmbientSTBDesc object from a binary data stream.
    /// <code>Offset: 0x00552510
    /// int __thiscall AmbientSTBDesc::UnPack(AmbientSTBDesc*,void**,unsigned int*)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current position within the source buffer; updated as bytes are consumed.</param>
    /// <param name="size">Number of bytes remaining in the buffer; decremented during unpacking.</param>
    /// <returns>Non‑zero if unpacking succeeds, zero on failure or insufficient data.</returns>
    public int UnPack(void** addr, uint* size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AmbientSTBDesc, void**, uint*, int>)0x00552510)(ref this, addr, size);
}

