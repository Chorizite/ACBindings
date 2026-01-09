namespace ACBindings.Logger;

// Logger::ILoggingOutputHandler
public unsafe struct ILoggingOutputHandler
{
    // Base Classes
    public ACBindings.ReferenceCountTemplate BaseClass_ReferenceCountTemplate; // ACBindings.ReferenceCountTemplate

    // Child Types
    // Logger::ILoggingOutputHandler_vtbl
    public unsafe struct ILoggingOutputHandler_vtbl
    {
        // Members
        public System.IntPtr Logger; // function pointer
        public System.IntPtr Write; // function pointer
        public System.IntPtr Flush; // function pointer

        // Methods
    }

    // Methods
}

