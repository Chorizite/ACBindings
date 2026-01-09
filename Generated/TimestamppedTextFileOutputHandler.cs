namespace ACBindings;

// TimestamppedTextFileOutputHandler
public unsafe struct TimestamppedTextFileOutputHandler
{
    // Base Classes
    public ACBindings.TextFileOutputHandler BaseClass_TextFileOutputHandler; // ACBindings.TextFileOutputHandler

    // Child Types
    // TimestamppedTextFileOutputHandler_vtbl
    public unsafe struct TimestamppedTextFileOutputHandler_vtbl
    {
        // Members
        public System.IntPtr TimestamppedTextFileOutputHandler_dtor_0; // function pointer
        public System.IntPtr Write; // function pointer
        public System.IntPtr Flush; // function pointer
        public System.IntPtr ChangeLogFile;
        public System.IntPtr GetLogFileName;

        // Methods
    }

    // Generated Constructor
    public TimestamppedTextFileOutputHandler(sbyte* szFilename) {
        _ConstructorInternal(szFilename);
    }

    // Methods
    // Logger::LoggerWriteResult __thiscall TimestamppedTextFileOutputHandler::Write(TimestamppedTextFileOutputHandler*,Logger::LoggingSeverity,unsigned int,const char*)
    public ACBindings.Logger.LoggerWriteResult Write(ACBindings.Logger.LoggingSeverity ls, uint lc, sbyte* szMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.TimestamppedTextFileOutputHandler, ACBindings.Logger.LoggingSeverity, uint, sbyte*, ACBindings.Logger.LoggerWriteResult>)0x0040EDB0)(ref this, ls, lc, szMsg);
    // void __thiscall TimestamppedTextFileOutputHandler::TimestamppedTextFileOutputHandler(TimestamppedTextFileOutputHandler*,const char*)
    public void _ConstructorInternal(sbyte* szFilename) => ((delegate* unmanaged[Thiscall]<ref ACBindings.TimestamppedTextFileOutputHandler, sbyte*, void>)0x0040F020)(ref this, szFilename);
}

