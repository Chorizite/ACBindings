namespace ACBindings;

// NetStatus
public enum NetStatus : byte
{
    Net_Initializing = 0x0,
    Net_LoginAuthenticating = 0x1,
    Net_LoginConnecting = 0x2,
    Net_LoginConnected = 0x3,
    Net_LoginConnectionError = 0x4,
    Net_WorldConnectionError = 0x5
}

