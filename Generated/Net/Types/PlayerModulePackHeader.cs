namespace ACBindings.Internal;

// PlayerModulePackHeader
public enum PlayerModulePackHeader : uint
{
    PM_Packed_None = 0x0,
    PM_Packed_ShortCutManager = 0x1,
    PM_Packed_SquelchList = 0x2,
    PM_Packed_MultiSpellLists = 0x4,
    PM_Packed_DesiredComps = 0x8,
    PM_Packed_ExtendedMultiSpellLists = 0x10,
    PM_Packed_SpellbookFilters = 0x20,
    PM_Packed_2ndCharacterOptions = 0x40,
    PM_Packed_TimeStampFormat = 0x80,
    PM_Packed_GenericQualitiesData = 0x100,
    PM_Packed_GameplayOptions = 0x200,
    PM_Packed_8_SpellLists = 0x400,
    FORCE_PlayerModulePackHeader_32_BIT = 0x7FFFFFFF
}

