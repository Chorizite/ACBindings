namespace ACBindings.Internal;

// TransitionState
public enum TransitionState : uint
{
    INVALID_TS = 0x0,
    OK_TS = 0x1,
    COLLIDED_TS = 0x2,
    ADJUSTED_TS = 0x3,
    SLID_TS = 0x4,
    FORCE_TransitionState_32_BIT = 0x7FFFFFFF
}

