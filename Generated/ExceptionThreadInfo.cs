namespace ACBindings;

// ExceptionThreadInfo
public unsafe struct ExceptionThreadInfo
{
    // Base Classes
    public ACBindings.DebugWorkerThreadData BaseClass_DebugWorkerThreadData; // ACBindings.DebugWorkerThreadData

    // Members
    public System.IntPtr pep;
    public uint dwRetVal;
    public ACBindings.DbgReportContext ctxt;

    // Methods
}

