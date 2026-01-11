namespace ACBindings.Internal.Logger;

// Logger::LoggingSeverity
public enum LoggingSeverity : byte
{
    sev_CriticalError = 0x0,
    sev_Error = 0x1,
    sev_Warning = 0x2,
    sev_Informational = 0x3,
    sev_Runtime = 0x4,
    sev_Important = 0x5,
    NumSeverities = 0x6
}

