namespace ACBindings.Internal;


/// <summary>Detects whether another instance of the client is running by holding a unique named semaphore.</summary>
public unsafe struct AlreadyRunningCheck
{
    // Members
    public System.IntPtr m_UniqueClientSemaphore;

    // Methods
}

