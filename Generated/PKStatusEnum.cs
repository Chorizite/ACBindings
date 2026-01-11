namespace ACBindings.Internal;

// PKStatusEnum
public enum PKStatusEnum : uint
{
    Undef_PKStatus = 0x0,
    Protected_PKStatus = 0x1,
    NPC_PKStatus = 0x1,
    NPK_PKStatus = 0x2,
    PK_PKStatus = 0x4,
    Unprotected_PKStatus = 0x8,
    Creature_PKStatus = 0x8,
    Trap_PKStatus = 0x8,
    RubberGlue_PKStatus = 0x10,
    Vendor_PKStatus = 0x10,
    Free_PKStatus = 0x20,
    Baelzharon_PKStatus = 0x20,
    PKLite_PKStatus = 0x40,
    FORCE_PKStatusEnum_32_BIT = 0x7FFFFFFF
}

