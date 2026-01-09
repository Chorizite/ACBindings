namespace ACBindings;

// ConnectionState
public enum ConnectionState : byte
{
    cs_Disconnected = 0x0,
    cs_AwaitingWorldAuth = 0x1,
    cs_AuthSent = 0x2,
    cs_ConnectionRequestSent = 0x3,
    cs_ConnectionRequestAcked = 0x4,
    cs_Connected = 0x5,
    cs_DisconnectReceived = 0x6,
    cs_DisconnectSent = 0x7
}

