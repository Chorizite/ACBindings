namespace ACBindings;

// ExperienceHandlingType
public enum ExperienceHandlingType : uint
{
    Undef_ExperienceHandlingType = 0x0,
    ReceivedFromAllegiance_ExperienceHandlingType = 0x0,
    ApplyLevelMod_ExperienceHandlingType = 0x1,
    ShareWithFellows_ExperienceHandlingType = 0x2,
    AddFellowshipBonus_ExperienceHandlingType = 0x4,
    ShareWithAllegiance_ExperienceHandlingType = 0x8,
    ApplyToVitae_ExperienceHandlingType = 0x10,
    NoShareQuest_ExperienceHandlingType = 0x10,
    AdminRaiseXP_ExperienceHandlingType = 0x10,
    AdminRaiseSkillXP_ExperienceHandlingType = 0x10,
    PassupQuest_ExperienceHandlingType = 0x18,
    ReceivedFromFellowship_ExperienceHandlingType = 0x18,
    NormalQuest_ExperienceHandlingType = 0x1A,
    EarnsCP_ExperienceHandlingType = 0x20,
    ReducedByDistance_ExperienceHandlingType = 0x40,
    Monster_ExperienceHandlingType = 0x5F,
    PPEarnedFromUse_ExperienceHandlingType = 0x7F,
    FORCE_ExperienceHandlingType_32_BIT = 0x7FFFFFFF
}

