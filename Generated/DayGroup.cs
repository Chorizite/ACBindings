namespace ACBindings.Internal;


/// <summary>Represents a set of sky configuration data for a particular day, containing the day's name, its likelihood of occurring, and linked arrays of sky times and sky objects.</summary>
public unsafe struct DayGroup
{
    // Members
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte day_name;
    public float chance_of_occur;
    public ACBindings.Internal.AC1Legacy.SmartArray___SkyTimeOfDay_ptr sky_time;
    public ACBindings.Internal.AC1Legacy.SmartArray___SkyObject_ptr sky_objects;

    // Methods

    /// <summary>
    /// Finds the two SkyTimeOfDay entries that bracket a specified time of day and calculates an interpolation ratio between them.
    /// 
    /// <code>Offset: 0x00501530
    /// int __thiscall DayGroup::GetTimeOfDay(DayGroup*,float,SkyTimeOfDay**,SkyTimeOfDay**,float*)</code>
    /// </summary>
    /// <param name="time_of_day">The current time of day as a fractional value.</param>
    /// <param name="before_time">Pointer to receive the SkyTimeOfDay entry whose begin time is at or before the specified time.</param>
    /// <param name="after_time">Pointer to receive the next SkyTimeOfDay entry, wrapping to the first if the specified time falls after the last entry.</param>
    /// <param name="ratio">Receives a value between 0 and 1 indicating the relative position of the specified time within the interval defined by before_time and after_time.</param>
    /// <returns>Non‑zero when a valid interval is found; zero when the group contains no sky time entries.</returns>
    public int GetTimeOfDay(float time_of_day, ACBindings.Internal.SkyTimeOfDay** before_time, ACBindings.Internal.SkyTimeOfDay** after_time, float* ratio) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DayGroup, float, ACBindings.Internal.SkyTimeOfDay**, ACBindings.Internal.SkyTimeOfDay**, float*, int>)0x00501530)(ref this, time_of_day, before_time, after_time, ratio);

    /// <summary>Destroys the day group by deallocating all SkyTimeOfDay and SkyObject instances, clearing their arrays, and resetting internal state.
    /// <code>Offset: 0x005022D0
    /// void __thiscall DayGroup::Destroy(DayGroup*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DayGroup, void>)0x005022D0)(ref this);

    /// <summary>Computes the number of bytes required to serialize a DayGroup instance, accounting for its name string, sky time and sky object arrays with appropriate padding for alignment.
    /// <code>Offset: 0x005023C0
    /// unsigned int __thiscall DayGroup::pack_size(DayGroup*)</code>
    /// </summary>
    /// <returns>The total packed size in bytes.</returns>
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DayGroup, uint>)0x005023C0)(ref this);

    /// <summary>Packs the DayGroup instance into a binary buffer by writing its fields sequentially: chance of occurrence, name string, sky objects, and times of day.
    /// <code>Offset: 0x00502450
    /// unsigned int __thiscall DayGroup::Pack(DayGroup*,void**,unsigned int*)</code>
    /// </summary>
    /// <param name="addr">Reference to a pointer indicating the current write location in the destination buffer; it is updated as data is written.</param>
    /// <param name="size">Pointer to the number of bytes remaining in the buffer; this value is decremented accordingly during packing and must be checked before each write operation.</param>
    /// <returns>Number of bytes left unused after packing. If insufficient space is available, zero may be returned.</returns>
    public uint Pack(void** addr, uint* size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DayGroup, void**, uint*, uint>)0x00502450)(ref this, addr, size);

    /// <summary>Deserializes a DayGroup from binary data, populating its fields and associated arrays of sky objects and times.
    /// <code>Offset: 0x005025C0
    /// int __thiscall DayGroup::UnPack(DayGroup*,void**,unsigned int*)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current position in the input buffer; will be advanced as data is read.</param>
    /// <param name="size">Number of bytes remaining in the buffer; updated during unpacking.</param>
    /// <returns>Non‑zero on success, zero or negative error code if deserialization fails.</returns>
    public int UnPack(void** addr, uint* size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DayGroup, void**, uint*, int>)0x005025C0)(ref this, addr, size);
}

