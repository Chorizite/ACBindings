namespace ACBindings.Internal;

public unsafe struct Turbine_GUID
{
    // Members
    public uint m_data1;
    public ushort m_data2;
    public ushort m_data3;
    public fixed byte m_data4[8];

    // Methods

    /// <summary>Parses a string containing a GUID in the form “xxxxxxxx‑xxxx‑xxxx‑xxxx‑xxxxxxxxxxxx” into this Turbine_GUID instance, converting from textual representation to binary data.
    /// <code>Offset: 0x0040FD30
    /// bool __thiscall Turbine_GUID::Convert(Turbine_GUID*,const char*)</code>
    /// </summary>
    /// <param name="pString">The null-terminated GUID string to parse.</param>
    /// <returns>True if parsing and conversion succeeded; otherwise false, with all fields cleared.</returns>
    public byte Convert(sbyte* pString) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Turbine_GUID, sbyte*, byte>)0x0040FD30)(ref this, pString);

    /// <summary>Converts the Turbine_GUID instance into its canonical UUID string representation and stores the resulting null‑terminated string in the location pointed to by a2.
    /// <code>Offset: 0x0040FDE0
    /// int* __thiscall Turbine_GUID::ToString(unsigned __int16*,int*)</code>
    /// </summary>
    /// <param name="this">The GUID object to format.</param>
    /// <param name="a2">Pointer that will receive the address of the newly created string containing the formatted GUID.</param>
    /// <returns>The same pointer passed as a2, now pointing to the generated string.</returns>
    public int* ToString(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Turbine_GUID, int*, int*>)0x0040FDE0)(ref this, a2);
}

