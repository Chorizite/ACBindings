namespace ACBindings.Internal;


/// <summary>WeekDay encapsulates a weekday name as a serialized string, enabling packing and unpacking of day‑of‑week data within the application’s communication protocol.</summary>
public unsafe struct WeekDay
{
    // Members
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte week_day_name;

    // Methods

    /// <summary>Extracts a weekday name from the serialized buffer, updates the buffer pointer and remaining size to account for the string data and required 4‑byte alignment padding.
    /// <code>Offset: 0x005A7E70
    /// int __thiscall WeekDay::UnPack(WeekDay*,void**,unsigned int*)</code>
    /// </summary>
    /// <param name="addr">Pointer to the buffer address; advanced past the unpacked data upon return.</param>
    /// <param name="size">Number of bytes available in the buffer; decreased by the length of the weekday name plus any padding added for alignment, then aligned. Updated after this call.</param>
    /// <returns>Non‑zero (true) if the weekday name was successfully read and at least one byte of data remains after alignment; zero otherwise or an error code from the underlying string unpack. </returns>
    public int UnPack(void** addr, uint* size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.WeekDay, void**, uint*, int>)0x005A7E70)(ref this, addr, size);
}

