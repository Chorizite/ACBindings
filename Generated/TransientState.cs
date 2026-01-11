namespace ACBindings.Internal;

// TransientState
public enum TransientState : uint
{
    CONTACT_TS = 0x1,
    ON_WALKABLE_TS = 0x2,
    SLIDING_TS = 0x4,
    WATER_CONTACT_TS = 0x8,
    STATIONARY_FALL_TS = 0x10,
    STATIONARY_STOP_TS = 0x20,
    STATIONARY_STUCK_TS = 0x40,
    ACTIVE_TS = 0x80,
    CHECK_ETHEREAL_TS = 0x100,
    FORCE_TransientState_32_BIT = 0x7FFFFFFF
}

