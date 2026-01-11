namespace ACBindings.Internal.Logger;

// Logger::LoggerWriteResult
public enum LoggerWriteResult : byte
{
    res_WriteFailed = 0x0,
    res_WriteSucceeded = 0x1,
    res_NotHandled = 0x2
}

