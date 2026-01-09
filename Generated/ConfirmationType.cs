namespace ACBindings;

// ConfirmationType
public enum ConfirmationType : uint
{
    UNDEF_CONFIRM = 0x0,
    ALLEGIANCE_SWEAR_CONFIRM = 0x1,
    ALTER_SKILL_CONFIRM = 0x2,
    ALTER_ATTRIBUTE_CONFIRM = 0x3,
    FELLOWSHIP_RECRUIT_CONFIRM = 0x4,
    CRAFT_INTERACTION_CONFIRM = 0x5,
    USE_AUGMENTATION_CONFIRM = 0x6,
    YESNO_CONFIRM = 0x7,
    FORCE_ConfirmationType_32_BIT = 0x7FFFFFFF
}

