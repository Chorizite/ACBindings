namespace ACBindings.Internal;

// eChatTypes
public enum eChatTypes : byte
{
    eTextTypeDefault = 0x0,
    eTextTypeAllChannels = 0x1,
    eTextTypeSpeech = 0x2,
    eTextTypeSpeechDirect = 0x3,
    eTextTypeSpeechDirectSend = 0x4,
    eTextTypeSystemSvent = 0x5,
    eTextTypeCombat = 0x6,
    eTextTypeMagic = 0x7,
    eTextTypeChannel = 0x8,
    eTextTypeChannelCend = 0x9,
    eTextTypeSocialChannel = 0xA,
    eTextTypeSocialChannelSend = 0xB,
    eTextTypeEmote = 0xC,
    eTextTypeAdvancement = 0xD,
    eTextTypeAbuseChannel = 0xE,
    eTextTypeHelpChannel = 0xF,
    eTextTypeAppraisalChannel = 0x10,
    eTextTypeMagicCastingChannel = 0x11,
    eTextTypeAllegienceChannel = 0x12,
    eTextTypeFellowshipChannel = 0x13,
    eTextTypeWorld_broadcast = 0x14,
    eTextTypeCombatEnemy = 0x15,
    eTextTypeCombatSelf = 0x16,
    eTextTypeRecall = 0x17,
    eTextTypeCraft = 0x18,
    eTextTypeTotalNumChannels = 0x19
}

