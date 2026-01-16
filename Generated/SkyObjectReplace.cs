namespace ACBindings.Internal;


/// <summary>Defines a sky object replacement entry used during rendering, holding an identifier, graphical resource ID, rotation, transparency, luminosity and brightness parameters.</summary>
/// <remarks>Serialization functions pack and unpack this struct to/from binary buffers for persistence or network transmission.</remarks>
public unsafe struct SkyObjectReplace
{
    // Members
    public uint object_index;
    public ACBindings.Internal.SkyObject* object_;
    public ACBindings.Internal.IDClass____tagDataID gfx_obj_id;
    public float rotate;
    public float transparent;
    public float luminosity;
    public float max_bright;

    // Methods

    /// <summary>Serializes a SkyObjectReplace instance into a binary buffer, writing its fields sequentially when sufficient space remains and updating the destination pointer and remaining size.
    /// <code>Offset: 0x00501C20
    /// unsigned int __thiscall SkyObjectReplace::Pack(SkyObjectReplace*,void**,unsigned int*)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current write location in the buffer; updated as data is written.</param>
    /// <param name="size">Pointer to the number of bytes available in the buffer; decreased by the amount written and aligned after packing.</param>
    /// <returns>Remaining buffer size (in bytes) after packing and alignment.</returns>
    public uint Pack(void** addr, uint* size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SkyObjectReplace, void**, uint*, uint>)0x00501C20)(ref this, addr, size);

    /// <summary>Deserializes a SkyObjectReplace instance from a byte stream, reading object_index, gfx_obj_id, rotate, transparent, luminosity, and max_bright sequentially if sufficient data remains.
    /// <code>Offset: 0x00501CD0
    /// int __thiscall SkyObjectReplace::UnPack(SkyObjectReplace*,void**,unsigned int*)</code>
    /// </summary>
    /// <param name="addr">Pointer to the buffer containing serialized data; updated to point after consumed bytes.</param>
    /// <param name="size">Size of remaining data in the buffer; decremented as fields are read and aligned at end.</param>
    /// <returns>Always returns 1, indicating successful unpacking.</returns>
    public int UnPack(void** addr, uint* size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SkyObjectReplace, void**, uint*, int>)0x00501CD0)(ref this, addr, size);
}

