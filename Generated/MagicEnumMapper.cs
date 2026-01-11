namespace ACBindings.Internal;

public unsafe struct MagicEnumMapper
{
    // Methods

    /// <summary>
    /// <code>Offset: 0x0056F040
    /// int __cdecl MagicEnumMapper::SpellComponentCategoryFromString(const char*,SpellComponentCategory*)</code>
    /// </summary>
    public static int SpellComponentCategoryFromString(sbyte* buf, ACBindings.Internal.SpellComponentCategory* st) => ((delegate* unmanaged[Cdecl]<sbyte*, ACBindings.Internal.SpellComponentCategory*, int>)0x0056F040)(buf, st);
}

