namespace ACBindings.Internal;

public unsafe struct EHExceptionRecord
{
    // Child Types
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

