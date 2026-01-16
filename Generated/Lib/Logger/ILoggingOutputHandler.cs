namespace ACBindings.Internal.Logger;


/// <summary>Provides an abstraction for handling log output, enabling implementations to direct messages to various destinations such as files, consoles, or network streams.</summary>
public unsafe struct ILoggingOutputHandler
{
    // Base Classes
    public ACBindings.Internal.ReferenceCountTemplate BaseClass_ReferenceCountTemplate; // ACBindings.Internal.ReferenceCountTemplate

    // Child Types
    public unsafe struct ILoggingOutputHandler_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Logger.ILoggingOutputHandler*, void> Logger; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Logger.ILoggingOutputHandler*, ACBindings.Internal.Logger.LoggingSeverity, uint, sbyte*, ACBindings.Internal.Logger.LoggerWriteResult> Write; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Logger.ILoggingOutputHandler*, void> Flush; // function pointer

        // Methods
    }

    // Methods
}

