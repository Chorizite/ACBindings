namespace ACBindings.Internal.Logger;

public unsafe struct ITextFileOutputHandler
{
    // Base Classes
    public ACBindings.Internal.Logger.ILoggingOutputHandler BaseClass_Logger_ILoggingOutputHandler; // ACBindings.Internal.Logger.ILoggingOutputHandler

    // Child Types
    public unsafe struct ITextFileOutputHandler_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Logger.ITextFileOutputHandler*, void> Logger; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Logger.ITextFileOutputHandler*, ACBindings.Internal.Logger.LoggingSeverity, uint, sbyte*, ACBindings.Internal.Logger.LoggerWriteResult> Write; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Logger.ITextFileOutputHandler*, void> Flush; // function pointer
        public System.IntPtr ChangeLogFile;
        public System.IntPtr GetLogFileName;

        // Methods
    }

    // Methods
}

