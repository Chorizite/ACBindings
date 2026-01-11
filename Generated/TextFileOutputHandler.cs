namespace ACBindings.Internal;

public unsafe struct TextFileOutputHandler : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.Logger.ITextFileOutputHandler BaseClass_Logger_ITextFileOutputHandler; // ACBindings.Internal.Logger.ITextFileOutputHandler

    // Child Types
    public unsafe struct TextFileOutputHandler_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.TextFileOutputHandler*, void> TextFileOutputHandler_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.TextFileOutputHandler*, ACBindings.Internal.Logger.LoggingSeverity, uint, sbyte*, ACBindings.Internal.Logger.LoggerWriteResult> Write; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.TextFileOutputHandler*, void> Flush; // function pointer
        public System.IntPtr ChangeLogFile;
        public System.IntPtr GetLogFileName;

        // Methods
    }

    // Members
    public byte* m_fileLog;
    public byte m_fFirstWrite;
    public ACBindings.Internal.PStringBase__sbyte m_strFilename;
    public ACBindings.Internal.InstanceDiviner* m_pidLogInstance;

    // Generated Constructor
    public TextFileOutputHandler(byte fPlaceFileInCurrentDirectory) {
        _ConstructorInternal(fPlaceFileInCurrentDirectory);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Flushes the internal text file log, writing any buffered data to disk.
    /// <code>Offset: 0x0040E8E0
    /// void __thiscall TextFileOutputHandler::Flush(TextFileOutputHandler*)</code>
    /// </summary>
    public void Flush() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TextFileOutputHandler, void>)0x0040E8E0)(ref this);

    /// <summary>Provides access to the internal storage used for the log file name.
    /// <code>Offset: 0x0040E8F0
    /// char* __thiscall TextFileOutputHandler::GetLogFileName(char*)</code>
    /// </summary>
    /// <returns>A pointer offset from this instance (at +16) that points to the member holding the log filename.</returns>
    public sbyte* GetLogFileName() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TextFileOutputHandler, sbyte*>)0x0040E8F0)(ref this);

    /// <summary>Opens a log file named by the string pointed to by a2, closing any previously opened file with a different name.
    /// <code>Offset: 0x0040ED10
    /// bool __thiscall TextFileOutputHandler::OpenLogFile(int,const char**)</code>
    /// </summary>
    /// <param name="a2">Pointer to a null‑terminated string containing the desired log file path.</param>
    /// <returns>True if the requested file is already open or was successfully opened; otherwise false (e.g., empty filename or opening failed).</returns>
    public byte OpenLogFile(sbyte** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TextFileOutputHandler, sbyte**, byte>)0x0040ED10)(ref this, a2);

    /// <summary>Destroys a TextFileOutputHandler instance, closing its log file handle, releasing any associated mutexes or reference-counted objects, and cleaning up internal resources.
    /// <code>Offset: 0x0040EEE0
    /// void __thiscall TextFileOutputHandler::~TextFileOutputHandler(TextFileOutputHandler*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TextFileOutputHandler, void>)0x0040EEE0)(ref this);

    /// <summary>Writes a message to the log file, opening the file lazily on first use and delegating post‑write processing to the base handler.
    /// <code>Offset: 0x0040EF70
    /// Logger::LoggerWriteResult __thiscall TextFileOutputHandler::Write(TextFileOutputHandler*,Logger::LoggingSeverity,unsigned int,const char*)</code>
    /// </summary>
    /// <param name="this">Instance of TextFileOutputHandler managing the log stream.</param>
    /// <param name="ls">Severity level of the log entry.</param>
    /// <param name="lc">Log counter or sequence number (currently unused).</param>
    /// <param name="szMsg">Null‑terminated string containing the text to write.</param>
    /// <returns>Non‑zero on successful write; zero if the file could not be opened or is null.</returns>
    public ACBindings.Internal.Logger.LoggerWriteResult Write(ACBindings.Internal.Logger.LoggingSeverity ls, uint lc, sbyte* szMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TextFileOutputHandler, ACBindings.Internal.Logger.LoggingSeverity, uint, sbyte*, ACBindings.Internal.Logger.LoggerWriteResult>)0x0040EF70)(ref this, ls, lc, szMsg);

    /// <summary>Switches the handler’s active log file when the supplied name differs from the current one, updating reference counts as needed.
    /// <code>Offset: 0x0040EFC0
    /// bool __thiscall TextFileOutputHandler::ChangeLogFile(int,const char**)</code>
    /// </summary>
    /// <param name="a2">Address of a pointer to a null‑terminated C string that specifies the desired log file name.</param>
    /// <returns>True if the file was already open or successfully switched; otherwise false (e.g., when opening fails).</returns>
    public byte ChangeLogFile(sbyte** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TextFileOutputHandler, sbyte**, byte>)0x0040EFC0)(ref this, a2);

    /// <summary>Initializes a new TextFileOutputHandler, creating a log file name derived from the current process and optionally placing it in the working directory.
    /// <code>Offset: 0x0040F180
    /// void __thiscall TextFileOutputHandler::TextFileOutputHandler(TextFileOutputHandler*,bool)</code>
    /// </summary>
    /// <param name="fPlaceFileInCurrentDirectory">If true, strips the executable path so the log file resides in the current working directory; otherwise includes full path.</param>
    public void _ConstructorInternal(byte fPlaceFileInCurrentDirectory) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TextFileOutputHandler, byte, void>)0x0040F180)(ref this, fPlaceFileInCurrentDirectory);
}

