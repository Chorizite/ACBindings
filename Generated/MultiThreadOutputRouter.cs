namespace ACBindings;

// MultiThreadOutputRouter
public unsafe struct MultiThreadOutputRouter
{
    // Base Classes
    public ACBindings.Logger.ITextFileOutputHandler BaseClass_Logger_ITextFileOutputHandler; // ACBindings.Logger.ITextFileOutputHandler

    // Child Types
    // MultiThreadOutputRouter_vtbl
    public unsafe struct MultiThreadOutputRouter_vtbl
    {
        // Members
        public System.IntPtr MultiThreadOutputRouter_dtor_0; // function pointer
        public System.IntPtr Write; // function pointer
        public System.IntPtr Flush; // function pointer
        public System.IntPtr ChangeLogFile;
        public System.IntPtr GetLogFileName;

        // Methods
    }

    // Members
    public ACBindings.CSpinLock m_critsec;
    public ACBindings.HashTable__uint__Logger_ITextFileOutputHandler_ptr m_hash;

    // Methods
}

