namespace ACBindings.Internal;

public unsafe struct OutputDebugStringOutputHandler
{
    // Base Classes
    public ACBindings.Internal.Logger.ILoggingOutputHandler BaseClass_Logger_ILoggingOutputHandler; // ACBindings.Internal.Logger.ILoggingOutputHandler

    // Child Types
    public unsafe struct OutputDebugStringOutputHandler_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.OutputDebugStringOutputHandler*, void> OutputDebugStringOutputHandler_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.OutputDebugStringOutputHandler*, ACBindings.Internal.Logger.LoggingSeverity, uint, sbyte*, ACBindings.Internal.Logger.LoggerWriteResult> Write; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.OutputDebugStringOutputHandler*, void> Flush; // function pointer

        // Methods
    }

    // Methods

    /// <summary>Sends the supplied log message to the debugger’s output window when a debugger is attached.
    /// <code>Offset: 0x0040EA20
    /// Logger::LoggerWriteResult __thiscall OutputDebugStringOutputHandler::Write(OutputDebugStringOutputHandler*,Logger::LoggingSeverity,unsigned int,const char*)</code>
    /// </summary>
    /// <param name="ls">Severity level of the logged event.</param>
    /// <param name="lc">Log count or sequence number associated with the event.</param>
    /// <param name="szMsg">Text of the log entry to be displayed.</param>
    /// <returns>Always returns 1, indicating that the message was processed successfully.</returns>
    public ACBindings.Internal.Logger.LoggerWriteResult Write(ACBindings.Internal.Logger.LoggingSeverity ls, uint lc, sbyte* szMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.OutputDebugStringOutputHandler, ACBindings.Internal.Logger.LoggingSeverity, uint, sbyte*, ACBindings.Internal.Logger.LoggerWriteResult>)0x0040EA20)(ref this, ls, lc, szMsg);
}

