namespace ACBindings.Internal;


/// <summary>Specifies the visual characteristics of the sky during a particular period of the day. Stores directional light intensity, heading, pitch, colors, ambient brightness, world fog parameters, and a list of sky object replacements that modify the environment.</summary>
/// <remarks>Used by the rendering engine to configure lighting, fog, and associated objects for each time-of-day segment.</remarks>
public unsafe struct SkyTimeOfDay : System.IDisposable
{
    // Members
    public float begin;
    public float dir_bright;
    public float dir_heading;
    public float dir_pitch;
    public ACBindings.Internal.RGBAUnion dir_color;
    public float amb_bright;
    public ACBindings.Internal.RGBAUnion amb_color;
    public int world_fog;
    public float min_world_fog;
    public float max_world_fog;
    public ACBindings.Internal.RGBAUnion world_fog_color;
    public ACBindings.Internal.AC1Legacy.SmartArray___SkyObjectReplace_ptr sky_obj_replace;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Destroys a SkyTimeOfDay instance, freeing all dynamically allocated sky object replacements and the array that stores them. Each element in sky_obj_replace.m_data is deleted before the data buffer itself is released.
    /// <code>Offset: 0x00501D80
    /// void __thiscall SkyTimeOfDay::~SkyTimeOfDay(SkyTimeOfDay*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SkyTimeOfDay, void>)0x00501D80)(ref this);

    /// <summary>Serializes a SkyTimeOfDay instance into a contiguous binary buffer, writing each field and any associated sky object replacements while ensuring proper alignment and respecting the available space.
    /// <code>Offset: 0x00501DE0
    /// unsigned int __thiscall SkyTimeOfDay::Pack(SkyTimeOfDay*,void**,unsigned int*)</code>
    /// </summary>
    /// <param name="addr">The address of the output buffer; updated to point past the serialized data after packing.</param>
    /// <param name="size">Pointer to an unsigned int holding the number of bytes remaining in the buffer before packing; updated to reflect unused space after packing.</param>
    /// <returns>The number of unused bytes left in the buffer after packing the SkyTimeOfDay data and its associated sky objects.</returns>
    public uint Pack(void** addr, uint* size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SkyTimeOfDay, void**, uint*, uint>)0x00501DE0)(ref this, addr, size);

    /// <summary>Deserializes a SkyTimeOfDay instance from a binary buffer, populating its properties and an array of sky object replacements.
    /// <code>Offset: 0x00502100
    /// int __thiscall SkyTimeOfDay::UnPack(SkyTimeOfDay*,void**,unsigned int*)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current position in the source buffer; advanced as data is consumed.</param>
    /// <param name="size">Number of bytes remaining in the buffer; decreased by the amount read during unpacking.</param>
    /// <returns>Remaining byte count after deserialization, or 0 if no data remains.</returns>
    public int UnPack(void** addr, uint* size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SkyTimeOfDay, void**, uint*, int>)0x00502100)(ref this, addr, size);
}

