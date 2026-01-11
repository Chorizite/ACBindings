namespace ACBindings.Internal;

// TargetStatus
public enum TargetStatus : uint
{
    Undef_TargetStatus = 0x0,
    Ok_TargetStatus = 0x1,
    ExitWorld_TargetStatus = 0x2,
    Teleported_TargetStatus = 0x3,
    Contained_TargetStatus = 0x4,
    Parented_TargetStatus = 0x5,
    TimedOut_TargetStatus = 0x6,
    FORCE_TargetStatus_32_BIT = 0x7FFFFFFF
}

