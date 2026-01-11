namespace ACBindings.Internal;

// AsyncStateMachineStatus
public enum AsyncStateMachineStatus : byte
{
    AsyncStateMachine_Unknown = 0x0,
    AsyncStateMachine_Running = 0x1,
    AsyncStateMachine_Succeeded = 0x2,
    AsyncStateMachine_TimedOut = 0x3,
    AsyncStateMachine_Failed = 0x4,
    AsyncStateMachine_InternalError = 0x5
}

