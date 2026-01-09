namespace ACBindings.Logger;

// Logger::ITextFileOutputHandler
public unsafe struct ITextFileOutputHandler
{
    // Base Classes
    public ACBindings.Logger.ILoggingOutputHandler BaseClass_Logger_ILoggingOutputHandler; // ACBindings.Logger.ILoggingOutputHandler

    // Child Types
    // Logger::ITextFileOutputHandler_vtbl
    public unsafe struct ITextFileOutputHandler_vtbl
    {
        // Members
        public System.IntPtr Logger; // function pointer
        public System.IntPtr Write; // function pointer
        public System.IntPtr Flush; // function pointer
        public System.IntPtr ChangeLogFile;
        public System.IntPtr GetLogFileName;

        // Methods
    }

    // Methods
}

