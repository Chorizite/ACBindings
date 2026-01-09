namespace ACBindings;

// ConsoleOutputHandler
public unsafe struct ConsoleOutputHandler
{
    // Base Classes
    public ACBindings.Logger.ILoggingOutputHandler BaseClass_Logger_ILoggingOutputHandler; // ACBindings.Logger.ILoggingOutputHandler

    // Child Types
    // ConsoleOutputHandler_vtbl
    public unsafe struct ConsoleOutputHandler_vtbl
    {
        // Members
        public System.IntPtr ConsoleOutputHandler_dtor_0; // function pointer
        public System.IntPtr Write; // function pointer
        public System.IntPtr Flush; // function pointer

        // Methods
    }

    // Methods
    // Logger::LoggerWriteResult __thiscall ConsoleOutputHandler::Write(ConsoleOutputHandler*,Logger::LoggingSeverity,unsigned int,const char*)
    public ACBindings.Logger.LoggerWriteResult Write(ACBindings.Logger.LoggingSeverity ls, uint lc, sbyte* szMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ConsoleOutputHandler, ACBindings.Logger.LoggingSeverity, uint, sbyte*, ACBindings.Logger.LoggerWriteResult>)0x0040EA00)(ref this, ls, lc, szMsg);
}

