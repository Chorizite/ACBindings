namespace ACBindings;

// TextFileOutputHandler
public unsafe struct TextFileOutputHandler : System.IDisposable
{
    // Base Classes
    public ACBindings.Logger.ITextFileOutputHandler BaseClass_Logger_ITextFileOutputHandler; // ACBindings.Logger.ITextFileOutputHandler

    // Child Types
    // TextFileOutputHandler_vtbl
    public unsafe struct TextFileOutputHandler_vtbl
    {
        // Members
        public System.IntPtr TextFileOutputHandler_dtor_0; // function pointer
        public System.IntPtr Write; // function pointer
        public System.IntPtr Flush; // function pointer
        public System.IntPtr ChangeLogFile;
        public System.IntPtr GetLogFileName;

        // Methods
    }

    // Members
    public byte* m_fileLog;
    public byte m_fFirstWrite;
    public ACBindings.PStringBase__sbyte m_strFilename;
    public ACBindings.InstanceDiviner* m_pidLogInstance;

    // Generated Constructor
    public TextFileOutputHandler(byte fPlaceFileInCurrentDirectory) {
        _ConstructorInternal(fPlaceFileInCurrentDirectory);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall TextFileOutputHandler::Flush(TextFileOutputHandler*)
    public void Flush() => ((delegate* unmanaged[Thiscall]<ref ACBindings.TextFileOutputHandler, void>)0x0040E8E0)(ref this);
    // char* __thiscall TextFileOutputHandler::GetLogFileName(char*)
    public sbyte* GetLogFileName() => ((delegate* unmanaged[Thiscall]<ref ACBindings.TextFileOutputHandler, sbyte*>)0x0040E8F0)(ref this);
    // bool __thiscall TextFileOutputHandler::OpenLogFile(int,const char**)
    public byte OpenLogFile(sbyte** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.TextFileOutputHandler, sbyte**, byte>)0x0040ED10)(ref this, a2);
    // void __thiscall TextFileOutputHandler::~TextFileOutputHandler(TextFileOutputHandler*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.TextFileOutputHandler, void>)0x0040EEE0)(ref this);
    // Logger::LoggerWriteResult __thiscall TextFileOutputHandler::Write(TextFileOutputHandler*,Logger::LoggingSeverity,unsigned int,const char*)
    public ACBindings.Logger.LoggerWriteResult Write(ACBindings.Logger.LoggingSeverity ls, uint lc, sbyte* szMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.TextFileOutputHandler, ACBindings.Logger.LoggingSeverity, uint, sbyte*, ACBindings.Logger.LoggerWriteResult>)0x0040EF70)(ref this, ls, lc, szMsg);
    // bool __thiscall TextFileOutputHandler::ChangeLogFile(int,const char**)
    public byte ChangeLogFile(sbyte** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.TextFileOutputHandler, sbyte**, byte>)0x0040EFC0)(ref this, a2);
    // void __thiscall TextFileOutputHandler::TextFileOutputHandler(TextFileOutputHandler*,bool)
    public void _ConstructorInternal(byte fPlaceFileInCurrentDirectory) => ((delegate* unmanaged[Thiscall]<ref ACBindings.TextFileOutputHandler, byte, void>)0x0040F180)(ref this, fPlaceFileInCurrentDirectory);
}

