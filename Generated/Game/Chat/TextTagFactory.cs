namespace ACBindings.Internal;


/// <summary>Parses encoded UTF‑16 text tags and returns a reference‑counted TextTag object, encapsulating the parsing logic, format handling, and resource cleanup required for tag creation.</summary>
public unsafe struct TextTagFactory
{
    // Methods

    /// <summary>Parses an encoded text tag from a UTF‑16 string and creates a corresponding TextTag instance, returning a reference‑counted pointer to it or null if the string is malformed.
    /// <code>Offset: 0x00478880
    /// volatile LONG* __cdecl TextTagFactory::MakeTag(__int16**)</code>
    /// </summary>
    /// <param name="a1">Pointer to a UTF‑16 string containing the tag data. The function may modify the string during parsing.</param>
    /// <returns>Reference‑counted pointer to the created TextTag object, or zero if parsing fails.</returns>
    public static int* MakeTag(short** a1) => ((delegate* unmanaged[Cdecl]<short**, int*>)0x00478880)(a1);
}

