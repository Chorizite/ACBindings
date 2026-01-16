namespace ACBindings.Internal;


/// <summary>Encapsulates a PackObj instance together with an AutoStoreVersionArchive, managing serialization state and providing size information for pack operations.</summary>
public unsafe struct PackUsingSerialize___PackObj
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Members
    public byte m_fArchiveValid;
    public ACBindings.Internal.AutoStoreVersionArchive m_ar;

    // Methods

    /// <summary>Serializes the object's state into a temporary buffer, copies it to the caller‑supplied destination when space allows, then invalidates the internal archive.
    /// <code>Offset: 0x005D5FA0
    /// unsigned int __thiscall PackUsingSerialize&lt;PackObj&gt;::Pack(_DWORD*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="a2">Pointer to the destination buffer pointer. If non‑null, data is copied there and the pointer advanced by the number of bytes written.</param>
    /// <param name="a3">Size in bytes available at the destination buffer.</param>
    /// <returns>Number of bytes that would be written if sufficient space were available.</returns>
    // unsigned int __thiscall PackUsingSerialize<PackObj>::Pack(_DWORD*,void**,unsigned int) (template type method)

    /// <summary>Computes and returns the byte count of the serialized data, performing serialization on first call.
    /// <code>Offset: 0x005D6030
    /// unsigned int __thiscall PackUsingSerialize&lt;PackObj&gt;::GetPackSize(char*)</code>
    /// </summary>
    /// <returns>The number of bytes currently stored in the pack's archive.</returns>
    // unsigned int __thiscall PackUsingSerialize<PackObj>::GetPackSize(char*) (template type method)

    /// <summary>Deserializes the pack object from a binary buffer using an auto‑store archive, advances the buffer pointer past the consumed data, frees temporary storage, and returns whether unpacking succeeded.
    /// <code>Offset: 0x005D6220
    /// BOOL __thiscall PackUsingSerialize&lt;PackObj&gt;::UnPack(void*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="this">Instance of PackUsingSerialize to populate.</param>
    /// <param name="a2">Reference to the input buffer; will be advanced by the number of bytes read during unpacking.</param>
    /// <param name="size">Size in bytes of the data available at *a2.</param>
    /// <returns>True if unpacking completed without setting error flags; otherwise false.</returns>
    // BOOL __thiscall PackUsingSerialize<PackObj>::UnPack(void*,void**,unsigned int) (template type method)
}

