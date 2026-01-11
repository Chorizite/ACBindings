namespace ACBindings.Internal;

// SpellbookFilter
public enum SpellbookFilter : uint
{
    Undef_SpellbookFilter = 0x0,
    Creature_SpellbookFilter = 0x1,
    Item_SpellbookFilter = 0x2,
    Life_SpellbookFilter = 0x4,
    War_SpellbookFilter = 0x8,
    Level_1_SpellbookFilter = 0x10,
    Level_2_SpellbookFilter = 0x20,
    Level_3_SpellbookFilter = 0x40,
    Level_4_SpellbookFilter = 0x80,
    Level_5_SpellbookFilter = 0x100,
    Level_6_SpellbookFilter = 0x200,
    Level_7_SpellbookFilter = 0x400,
    Level_8_SpellbookFilter = 0x800,
    Level_9_SpellbookFilter = 0x1000,
    Void_SpellbookFilter = 0x2000,
    Default_SpellbookFilter = 0x3FFF,
    FORCE_SpellbookFilter_32_BIT = 0x7FFFFFFF
}

