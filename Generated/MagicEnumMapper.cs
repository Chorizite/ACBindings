namespace ACBindings;

// MagicEnumMapper
public unsafe struct MagicEnumMapper
{
    // Methods
    // int __cdecl MagicEnumMapper::SpellComponentCategoryFromString(const char*,SpellComponentCategory*)
    public static int SpellComponentCategoryFromString(sbyte* buf, ACBindings.SpellComponentCategory* st) => ((delegate* unmanaged[Cdecl]<sbyte*, ACBindings.SpellComponentCategory*, int>)0x0056F040)(buf, st);
}

