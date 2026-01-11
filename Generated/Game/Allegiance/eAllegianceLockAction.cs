namespace ACBindings.Internal;

// eAllegianceLockAction
public enum eAllegianceLockAction : uint
{
    Undef_AllegianceLockAction = 0x0,
    OffLock_AllegianceLockAction = 0x1,
    OnLock_AllegianceLockAction = 0x2,
    ToggleLock_AllegianceLockAction = 0x3,
    CheckLock_AllegianceLockAction = 0x4,
    CheckApproved_AllegianceLockAction = 0x5,
    ClearApproved_AllegianceLockAction = 0x6,
    NumberOfActions_AllegianceLockAction = 0x6,
    FORCE_AllegianceLockAction_32_BIT = 0x7FFFFFFF
}

