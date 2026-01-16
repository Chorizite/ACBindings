namespace ACBindings.Internal;


/// <summary>Named season storing a descriptive name and a numeric start marker used to identify the period.</summary>
public unsafe struct Season
{
    // Members
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte season_name;
    public int begin;

    // Methods

    /// <summary>Deserializes a Season object from binary data. Reads the begin time and season name, advancing the buffer pointer and reducing the remaining size accordingly.
    /// <code>Offset: 0x005A7DF0
    /// int __thiscall Season::UnPack(Season*,void**,unsigned int*)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current read position in the source buffer; advanced past unpacked fields.</param>
    /// <param name="size">Pointer to the count of remaining bytes; decremented as data is consumed and aligned after unpacking.</param>
    /// <returns>Non-zero if unpack succeeded and at least one byte remains after alignment; otherwise zero.</returns>
    public int UnPack(void** addr, uint* size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Season, void**, uint*, int>)0x005A7DF0)(ref this, addr, size);
}

