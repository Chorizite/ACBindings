namespace ACBindings.Internal;

public unsafe struct _RTL_CRITICAL_SECTION
{
    // Members
    public System.IntPtr DebugInfo;
    public int LockCount;
    public int RecursionCount;
    public System.IntPtr OwningThread;
    public System.IntPtr LockSemaphore;
    public uint SpinCount;

    // Methods
}

