namespace ACBindings.Internal;

// ActionStateChangeType
public enum ActionStateChangeType : byte
{
    asctActionStarted = 0x0,
    asctActionUpdated = 0x1,
    esctActionUnchanged = 0x2,
    asctActionStopped = 0x3
}

