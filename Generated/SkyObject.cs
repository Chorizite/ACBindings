namespace ACBindings.Internal;


/// <summary>Represents an animated sky element with timing ranges, angular spans, texture scrolling velocity, and linked graphics and physics objects.</summary>
/// <remarks>Manages its own name string memory, supports packing/unpacking to binary streams, and resets state via Destroy.</remarks>
public unsafe struct SkyObject
{
    // Members
    public sbyte* object_name;
    public float begin_time;
    public float end_time;
    public float begin_angle;
    public float end_angle;
    public ACBindings.Internal.AC1Legacy.Vector3 tex_velocity;
    public uint properties;
    public ACBindings.Internal.IDClass____tagDataID default_gfx_object;
    public ACBindings.Internal.IDClass____tagDataID default_pes_object;

    // Methods

    /// <summary>Destroys a SkyObject instance by freeing its name string and resetting all fields to default values.
    /// <code>Offset: 0x005014D0
    /// void __thiscall SkyObject::Destroy(SkyObject*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SkyObject, void>)0x005014D0)(ref this);

    /// <summary>Serializes a SkyObject into a binary stream by writing its fields sequentially to the supplied buffer when sufficient space is available.
    /// <code>Offset: 0x00501A20
    /// unsigned int __thiscall SkyObject::Pack(SkyObject*,void**,unsigned int*)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current write position in the destination buffer; it is advanced as data is written.</param>
    /// <param name="size">Pointer to the remaining size of the buffer; decremented for each field written and updated after alignment.</param>
    /// <returns>Number of bytes left in the buffer after packing and aligning the data.</returns>
    public uint Pack(void** addr, uint* size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SkyObject, void**, uint*, uint>)0x00501A20)(ref this, addr, size);

    /// <summary>Deserializes a SkyObject from a binary stream, resetting its state and reading sequential values into its fields.
    /// <code>Offset: 0x00501B20
    /// int __thiscall SkyObject::UnPack(SkyObject*,void**,unsigned int*)</code>
    /// </summary>
    /// <param name="addr">The address of the pointer to the data buffer; advanced as bytes are consumed.</param>
    /// <param name="size">The remaining byte count in the buffer; decremented as data is read.</param>
    /// <returns>Always returns 1, indicating successful unpacking.</returns>
    public int UnPack(void** addr, uint* size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SkyObject, void**, uint*, int>)0x00501B20)(ref this, addr, size);
}

