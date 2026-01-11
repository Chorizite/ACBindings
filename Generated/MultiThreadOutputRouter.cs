namespace ACBindings.Internal;

public unsafe struct MultiThreadOutputRouter
{
    // Base Classes
    public ACBindings.Internal.Logger.ITextFileOutputHandler BaseClass_Logger_ITextFileOutputHandler; // ACBindings.Internal.Logger.ITextFileOutputHandler

    // Child Types
    public unsafe struct MultiThreadOutputRouter_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.MultiThreadOutputRouter*, void> MultiThreadOutputRouter_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.MultiThreadOutputRouter*, ACBindings.Internal.Logger.LoggingSeverity, uint, sbyte*, ACBindings.Internal.Logger.LoggerWriteResult> Write; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.MultiThreadOutputRouter*, void> Flush; // function pointer
        public System.IntPtr ChangeLogFile;
        public System.IntPtr GetLogFileName;

        // Methods
    }

    // Members
    public ACBindings.Internal.CSpinLock m_critsec;
    public ACBindings.Internal.HashTable__uint___Logger_ITextFileOutputHandler_ptr m_hash;

    // Methods
}

