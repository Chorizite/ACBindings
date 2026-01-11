namespace ACBindings.Internal;

// AsyncResult
public enum AsyncResult : byte
{
    AsyncResult_Unknown = 0x0,
    AsyncResult_Success = 0x1,
    AsyncResult_PartialSuccess = 0x2,
    AsyncResult_Failure = 0x3
}

