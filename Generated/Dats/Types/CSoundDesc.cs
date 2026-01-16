namespace ACBindings.Internal;


/// <summary>Represents a collection of ambient sound descriptors used by the audio engine to manage and serialize environmental sounds.</summary>
public unsafe struct CSoundDesc : System.IDisposable
{
    // Members
    public ACBindings.Internal.AC1Legacy.SmartArray___AmbientSTBDesc_ptr stb_desc;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Destroys all ambient sound descriptors stored in this CSoundDesc instance, releasing allocated memory and resetting the internal descriptor array to an empty state.
    /// <code>Offset: 0x005031F0
    /// void __thiscall CSoundDesc::Destroy(CSoundDesc*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSoundDesc, void>)0x005031F0)(ref this);

    /// <summary>Computes the packed byte size required for a CSoundDesc instance, including a 4‑byte header and all AmbientSTBDesc entries, rounded up to a multiple of four.
    /// <code>Offset: 0x00503250
    /// unsigned int __thiscall CSoundDesc::pack_size(CSoundDesc*)</code>
    /// </summary>
    /// <returns>The total size in bytes needed for packing the sound description.</returns>
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSoundDesc, uint>)0x00503250)(ref this);

    /// <summary>Packs a CSoundDesc into a binary stream by writing its count of ambient descriptors, when enough space exists, and then serializing each descriptor.
    /// <code>Offset: 0x005032A0
    /// unsigned int __thiscall CSoundDesc::Pack(CSoundDesc*,void**,unsigned int*)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current write position in the output buffer; updated as data is written.</param>
    /// <param name="size">Pointer to the remaining capacity of the buffer; decremented by the amount written whenever possible.</param>
    /// <returns>Remaining number of bytes available in the buffer after attempting to pack the descriptor list.</returns>
    public uint Pack(void** addr, uint* size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSoundDesc, void**, uint*, uint>)0x005032A0)(ref this, addr, size);

    /// <summary>Destroys the CSoundDesc instance, freeing its smart array resources.
    /// <code>Offset: 0x00503310
    /// void __thiscall CSoundDesc::~CSoundDesc(CSoundDesc*)</code>
    /// </summary>
    /// <param name="this">The CSoundDesc object being destroyed.</param>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSoundDesc, void>)0x00503310)(ref this);

    /// <summary>Collects the identifiers of all valid ambient STB descriptors in this CSoundDesc and appends them to the supplied QualifiedDataIDArray.
    /// <code>Offset: 0x00503330
    /// void __thiscall CSoundDesc::GetSubDataIDs(CSoundDesc*,QualifiedDataIDArray*)</code>
    /// </summary>
    /// <param name="id_array">The array that receives the collected data identifiers.</param>
    public void GetSubDataIDs(ACBindings.Internal.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSoundDesc, ACBindings.Internal.QualifiedDataIDArray*, void>)0x00503330)(ref this, id_array);

    /// <summary>Unpacks sound descriptor data from a binary stream into the object's stb_desc array, replacing any existing contents. Reads an optional 4‑byte header and then iteratively constructs AmbientSTBDesc objects until the stream is exhausted or an error occurs.
    /// <code>Offset: 0x00503380
    /// int __thiscall CSoundDesc::UnPack(CSoundDesc*,void**,unsigned int*)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current position in the input buffer; updated as data is consumed.</param>
    /// <param name="size">Remaining size of the input buffer; decremented as bytes are read.</param>
    /// <returns>Non‑zero on successful unpacking, zero if an error occurs during construction or reading.</returns>
    public int UnPack(void** addr, uint* size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSoundDesc, void**, uint*, int>)0x00503380)(ref this, addr, size);
}

