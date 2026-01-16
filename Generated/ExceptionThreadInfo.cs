namespace ACBindings.Internal;


/// <summary>Holds state necessary for handling exceptions on a worker thread, linking the original exception data with its debug context and the function’s return status.</summary>
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

