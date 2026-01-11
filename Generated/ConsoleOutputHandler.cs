namespace ACBindings.Internal;

public unsafe struct ConsoleOutputHandler
{
    // Base Classes
    public ACBindings.Internal.Logger.ILoggingOutputHandler BaseClass_Logger_ILoggingOutputHandler; // ACBindings.Internal.Logger.ILoggingOutputHandler

    // Child Types
    public unsafe struct ConsoleOutputHandler_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ConsoleOutputHandler*, void> ConsoleOutputHandler_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ConsoleOutputHandler*, ACBindings.Internal.Logger.LoggingSeverity, uint, sbyte*, ACBindings.Internal.Logger.LoggerWriteResult> Write; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ConsoleOutputHandler*, void> Flush; // function pointer

        // Methods
    }

    // Methods

    /// <summary>Outputs the supplied message string directly to standard output.
    /// <code>Offset: 0x0040EA00
    /// Logger::LoggerWriteResult __thiscall ConsoleOutputHandler::Write(ConsoleOutputHandler*,Logger::LoggingSeverity,unsigned int,const char*)</code>
    /// </summary>
    /// <param name="ls">The severity level of the log entry, currently unused by this handler.</param>
    /// <param name="lc">A numeric code associated with the log event, ignored in this implementation.</param>
    /// <param name="szMsg">The text of the log message to write.</param>
    /// <returns>Always returns a success indicator (1).</returns>
    public ACBindings.Internal.Logger.LoggerWriteResult Write(ACBindings.Internal.Logger.LoggingSeverity ls, uint lc, sbyte* szMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ConsoleOutputHandler, ACBindings.Internal.Logger.LoggingSeverity, uint, sbyte*, ACBindings.Internal.Logger.LoggerWriteResult>)0x0040EA00)(ref this, ls, lc, szMsg);
}

