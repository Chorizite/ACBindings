namespace ACBindings.Internal;


/// <summary>Converts textual identifiers of spell component categories into their corresponding enumeration values, enabling consistent parsing of configuration data and user input across the application.</summary>
/// <remarks>Provides a static method SpellComponentCategoryFromString that performs case‑insensitive matching against known category names such as Scarab, Herb, PowderedGem, AlchemicalSubstance, Talisman, Taper, and Pea. Returns 1 on success with the enum value set; otherwise returns 0.</remarks>
public unsafe struct MagicEnumMapper
{
    // Methods

    /// <summary>Parses the supplied string into a SpellComponentCategory enumeration value.
    /// <code>Offset: 0x0056F040
    /// int __cdecl MagicEnumMapper::SpellComponentCategoryFromString(const char*,SpellComponentCategory*)</code>
    /// </summary>
    /// <param name="buf">The input C‑string representing the component category; may be null.</param>
    /// <param name="st">Pointer to a SpellComponentCategory where the parsed enum will be stored on success.</param>
    /// <returns>1 if parsing succeeds and *st is set; 0 if buf is null or does not match any known category.</returns>
    public static int SpellComponentCategoryFromString(sbyte* buf, ACBindings.Internal.SpellComponentCategory* st) => ((delegate* unmanaged[Cdecl]<sbyte*, ACBindings.Internal.SpellComponentCategory*, int>)0x0056F040)(buf, st);
}

