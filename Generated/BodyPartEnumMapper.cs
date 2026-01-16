namespace ACBindings.Internal;


/// <summary>Provides mapping between numeric body‑part identifiers and their textual names, enabling conversion for display or logging. Offers functionality to translate an integer code into a null‑terminated string safely within a supplied buffer.</summary>
public unsafe struct BodyPartEnumMapper
{
    // Methods

    /// <summary>Converts a numeric body‑part identifier into its textual representation, copying the result into a supplied buffer.
    /// <code>Offset: 0x005D1EA0
    /// unsigned int __cdecl BodyPartEnumMapper::BodyPartToString(const int,char*,const unsigned int)</code>
    /// </summary>
    /// <param name="bp">Body‑part enumeration value. -1 yields "UNDEFINED"; 27 uses an external string; values outside defined cases produce "Unknown".</param>
    /// <param name="buf">Destination buffer to receive the null‑terminated string.</param>
    /// <param name="size">Maximum number of bytes available in buf, including space for the terminating NUL character.</param>
    /// <returns>Zero if the string was successfully written; otherwise the total byte count required (including the terminating NUL) to hold the resulting representation.</returns>
    public static uint BodyPartToString(int bp, sbyte* buf, uint size) => ((delegate* unmanaged[Cdecl]<int, sbyte*, uint, uint>)0x005D1EA0)(bp, buf, size);
}

