namespace ACBindings.Internal;

public unsafe struct ExceptionThreadInfo
{
    // Base Classes
    public ACBindings.Internal.DebugWorkerThreadData BaseClass_DebugWorkerThreadData; // ACBindings.Internal.DebugWorkerThreadData

    // Members
    public System.IntPtr pep;
    public uint dwRetVal;
    public ACBindings.Internal.DbgReportContext ctxt;

    // Methods
}

