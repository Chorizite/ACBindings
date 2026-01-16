namespace ACBindings.Internal;


/// <summary>Captures the details of an exception thrown by Windows Structured Exception Handling (SEH), including code, flags, nested record, address, and parameters.</summary>
public unsafe struct EHExceptionRecord
{
    // Child Types

    /// <summary>Defines the parameters used by an EHExceptionRecord for exception handling, including a magic identifier, a pointer to the thrown object, and associated throw information.</summary>
    public unsafe struct EHParameters
    {
        // Members
        public uint magicNumber;
        public System.IntPtr pExceptionObject;
        public System.IntPtr pThrowInfo;

        // Methods
    }

    // Members
    public uint ExceptionCode;
    public uint ExceptionFlags;
    public System.IntPtr ExceptionRecord;
    public System.IntPtr ExceptionAddress;
    public uint NumberParameters;
    public ACBindings.Internal.EHExceptionRecord.EHParameters params_;

    // Methods
}

