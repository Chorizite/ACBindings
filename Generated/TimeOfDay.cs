namespace ACBindings.Internal;


/// <summary>Named representation of a time period, storing its beginning point and whether it occurs during night hours.</summary>
public unsafe struct TimeOfDay
{
    // Members
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte time_of_day_name;
    public float begin;
    public int is_night;

    // Methods

    /// <summary>Deserializes a TimeOfDay object from a binary buffer, extracting begin time, night flag, and name string while advancing the buffer pointer and reducing the remaining size.
    /// <code>Offset: 0x005A7EE0
    /// int __thiscall TimeOfDay::UnPack(TimeOfDay*,void**,unsigned int*)</code>
    /// </summary>
    /// <param name="this">The TimeOfDay instance to populate.</param>
    /// <param name="addr">Reference to the current read position in the data stream; advanced as fields are unpacked.</param>
    /// <param name="size">Pointer to the remaining byte count in the buffer; decreased as bytes are consumed and aligned after unpacking.</param>
    /// <returns>Nonzero if the unpack succeeds, zero otherwise.</returns>
    public int UnPack(void** addr, uint* size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TimeOfDay, void**, uint*, int>)0x005A7EE0)(ref this, addr, size);
}

