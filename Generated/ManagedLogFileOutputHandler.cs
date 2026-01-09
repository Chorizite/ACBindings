namespace ACBindings;

// ManagedLogFileOutputHandler
public unsafe struct ManagedLogFileOutputHandler
{
    // Base Classes
    public ACBindings.Logger.ITextFileOutputHandler BaseClass_Logger_ITextFileOutputHandler; // ACBindings.Logger.ITextFileOutputHandler

    // Child Types
    // ManagedLogFileOutputHandler_vtbl
    public unsafe struct ManagedLogFileOutputHandler_vtbl
    {
        // Members
        public System.IntPtr ManagedLogFileOutputHandler_dtor_0; // function pointer
        public System.IntPtr Write; // function pointer
        public System.IntPtr Flush; // function pointer
        public System.IntPtr ChangeLogFile;
        public System.IntPtr GetLogFileName;
        public System.IntPtr GetLogRootName;
        public System.IntPtr ChangeDescription;
        public System.IntPtr UsePeriodicRealTimeEntries; // function pointer

        // Methods
    }
    // ManagedLogFileOutputHandler::AsyncIOString
    public unsafe struct AsyncIOString
    {
        // Base Classes
        public ACBindings.PStringBase__sbyte BaseClass_PStringBase__sbyte; // ACBindings.PStringBase__sbyte

        // Methods
    }
    // ManagedLogFileOutputHandler::ReclaimBufferEnum
    public enum ReclaimBufferEnum : byte
    {
        ReclaimBuffer = 0x0
    }

    // Members
    public ACBindings.PStringBase__sbyte m_strRootName;
    public ACBindings.PStringBase__sbyte m_strUniqueKey;
    public ACBindings.PStringBase__sbyte m_strFileName;
    public ACBindings.PStringBase__sbyte m_strDescription;
    public System.IntPtr m_hLogFile;
    public uint m_cWrites;
    public uint m_cbWritten;
    public uint m_cTimesWrapped;
    public fixed sbyte m_szTimeLogCreated[26];
    public double m_timePrintRealTime;
    public byte m_fTimestampedOutput;
    public uint m_cbMaxSize;
    public ACBindings.LOG_TRUNCATE_OP m_truncop;
    public uint m_dwCurrentFilePos;

    // Methods
}

