namespace ACBindings.Internal;

public unsafe struct ManagedLogFileOutputHandler
{
    // Base Classes
    public ACBindings.Internal.Logger.ITextFileOutputHandler BaseClass_Logger_ITextFileOutputHandler; // ACBindings.Internal.Logger.ITextFileOutputHandler

    // Child Types
    public unsafe struct ManagedLogFileOutputHandler_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ManagedLogFileOutputHandler*, void> ManagedLogFileOutputHandler_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ManagedLogFileOutputHandler*, ACBindings.Internal.Logger.LoggingSeverity, uint, sbyte*, ACBindings.Internal.Logger.LoggerWriteResult> Write; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ManagedLogFileOutputHandler*, void> Flush; // function pointer
        public System.IntPtr ChangeLogFile;
        public System.IntPtr GetLogFileName;
        public System.IntPtr GetLogRootName;
        public System.IntPtr ChangeDescription;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ManagedLogFileOutputHandler*, byte, void> UsePeriodicRealTimeEntries; // function pointer

        // Methods
    }
    public unsafe struct AsyncIOString
    {
        // Base Classes
        public ACBindings.Internal.PStringBase__sbyte BaseClass_PStringBase__sbyte; // ACBindings.Internal.PStringBase__sbyte

        // Methods
    }
    // ManagedLogFileOutputHandler::ReclaimBufferEnum
    public enum ReclaimBufferEnum : byte
    {
        ReclaimBuffer = 0x0
    }

    // Members
    public ACBindings.Internal.PStringBase__sbyte m_strRootName;
    public ACBindings.Internal.PStringBase__sbyte m_strUniqueKey;
    public ACBindings.Internal.PStringBase__sbyte m_strFileName;
    public ACBindings.Internal.PStringBase__sbyte m_strDescription;
    public System.IntPtr m_hLogFile;
    public uint m_cWrites;
    public uint m_cbWritten;
    public uint m_cTimesWrapped;
    public fixed sbyte m_szTimeLogCreated[26];
    public double m_timePrintRealTime;
    public byte m_fTimestampedOutput;
    public uint m_cbMaxSize;
    public ACBindings.Internal.LOG_TRUNCATE_OP m_truncop;
    public uint m_dwCurrentFilePos;

    // Methods
}

