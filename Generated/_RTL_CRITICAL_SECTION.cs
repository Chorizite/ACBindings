namespace ACBindings.Internal;


/// <summary>Encapsulates data needed by Windows to manage a critical section, including ownership, lock counts, and synchronization objects, allowing threads to safely enter and leave protected code blocks.</summary>
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

