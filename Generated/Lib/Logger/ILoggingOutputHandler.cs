namespace ACBindings.Internal.Logger;

public unsafe struct ILoggingOutputHandler
{
    // Base Classes
    public ACBindings.Internal.ReferenceCountTemplate BaseClass_ReferenceCountTemplate; // ACBindings.Internal.ReferenceCountTemplate

    // Child Types
    public unsafe struct ILoggingOutputHandler_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Logger.ILoggingOutputHandler*, void> Logger; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Logger.ILoggingOutputHandler*, ACBindings.Internal.Logger.LoggingSeverity, uint, sbyte*, ACBindings.Internal.Logger.LoggerWriteResult> Write; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Logger.ILoggingOutputHandler*, void> Flush; // function pointer

        // Methods
    }

    // Methods
}

