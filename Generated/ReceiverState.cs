namespace ACBindings.Internal;

// ReceiverState
public enum ReceiverState : uint
{
    UNDEF_STATE = 0x0,
    NAK_STATE = 0x1,
    NO_NAK_STATE = 0x2,
    NO_STATE = 0x3,
    FORCE_ReceiverState_32_BIT = 0x7FFFFFFF
}

