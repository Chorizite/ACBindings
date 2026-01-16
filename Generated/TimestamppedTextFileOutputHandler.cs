namespace ACBindings.Internal;


/// <summary>Logs messages to a text file, prefixing each entry with the current timestamp and creating a fresh file when instantiated.</summary>
public unsafe struct TimestamppedTextFileOutputHandler
{
    // Base Classes
    public ACBindings.Internal.TextFileOutputHandler BaseClass_TextFileOutputHandler; // ACBindings.Internal.TextFileOutputHandler

    // Child Types
    public unsafe struct TimestamppedTextFileOutputHandler_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.TimestamppedTextFileOutputHandler*, void> TimestamppedTextFileOutputHandler_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.TimestamppedTextFileOutputHandler*, ACBindings.Internal.Logger.LoggingSeverity, uint, sbyte*, ACBindings.Internal.Logger.LoggerWriteResult> Write; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.TimestamppedTextFileOutputHandler*, void> Flush; // function pointer
        public System.IntPtr ChangeLogFile;
        public System.IntPtr GetLogFileName;

        // Methods
    }

    // Generated Constructor
    public TimestamppedTextFileOutputHandler(sbyte* szFilename) {
        _ConstructorInternal(szFilename);
    }

    // Methods

    /// <summary>Writes a timestamped message to the associated text file, opening the file on first use and returning a status indicating success.
    /// <code>Offset: 0x0040EDB0
    /// Logger::LoggerWriteResult __thiscall TimestamppedTextFileOutputHandler::Write(TimestamppedTextFileOutputHandler*,Logger::LoggingSeverity,unsigned int,const char*)</code>
    /// </summary>
    /// <param name="this">The output handler instance.</param>
    /// <param name="ls">Severity level of the log entry (unused in formatting).</param>
    /// <param name="lc">Log count or identifier (unused in this implementation).</param>
    /// <param name="szMsg">C-string containing the message to write.</param>
    /// <returns>Non‑zero value if the message was written successfully; zero otherwise.</returns>
    public ACBindings.Internal.Logger.LoggerWriteResult Write(ACBindings.Internal.Logger.LoggingSeverity ls, uint lc, sbyte* szMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TimestamppedTextFileOutputHandler, ACBindings.Internal.Logger.LoggingSeverity, uint, sbyte*, ACBindings.Internal.Logger.LoggerWriteResult>)0x0040EDB0)(ref this, ls, lc, szMsg);

    /// <summary>Creates a timestamped text file output handler that writes log entries to the supplied file name, resetting internal state and deleting any existing file with that name.
    /// <code>Offset: 0x0040F020
    /// void __thiscall TimestamppedTextFileOutputHandler::TimestamppedTextFileOutputHandler(TimestamppedTextFileOutputHandler*,const char*)</code>
    /// </summary>
    /// <param name="szFilename">Path of the log file to be used by the handler. Existing file is deleted during construction.</param>
    public void _ConstructorInternal(sbyte* szFilename) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TimestamppedTextFileOutputHandler, sbyte*, void>)0x0040F020)(ref this, szFilename);
}

