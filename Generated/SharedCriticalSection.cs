namespace ACBindings.Internal;


/// <summary>Manages mutual exclusion for shared resources using a Windows critical section, tracking lock ownership and recursion count.</summary>
/// <remarks>Maintains the current owning thread ID in lockHolder_ and supports reentrant locking via lockCount_. Encapsulates initialization and cleanup of the underlying critical section.</remarks>
public unsafe struct SharedCriticalSection : System.IDisposable
{
    // Child Types

    /// <summary>Defines function pointers used by SharedCriticalSection to manage synchronization, including cleanup via the destructor and entry into the critical region.</summary>
    public unsafe struct SharedCriticalSection_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SharedCriticalSection*, void> SharedCriticalSection_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SharedCriticalSection*, void> EnterCriticalSection; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public ACBindings.Internal._RTL_CRITICAL_SECTION myCritSection_;
    public uint lockHolder_;
    public int lockCount_;

    // Generated Constructor
    public SharedCriticalSection() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Initializes a new SharedCriticalSection instance, resetting lock state and creating an internal Windows critical section.
    /// <code>Offset: 0x0065E8B0
    /// void __thiscall SharedCriticalSection::SharedCriticalSection(SharedCriticalSection*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SharedCriticalSection, void>)0x0065E8B0)(ref this);

    /// <summary>Destroys a SharedCriticalSection instance by releasing its internal critical section and resetting its virtual table pointer.
    /// <code>Offset: 0x0065E8D0
    /// void __thiscall SharedCriticalSection::~SharedCriticalSection(SharedCriticalSection*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SharedCriticalSection, void>)0x0065E8D0)(ref this);

    /// <summary>Enters the shared critical section, incrementing the lock count and recording the current thread as the lock holder.
    /// <code>Offset: 0x0065E8F0
    /// void __thiscall SharedCriticalSection::EnterCriticalSection(SharedCriticalSection*)</code>
    /// </summary>
    public void EnterCriticalSection() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SharedCriticalSection, void>)0x0065E8F0)(ref this);

    /// <summary>Releases the shared critical section, decrementing lock count and clearing the lock holder when this was the last active lock.
    /// <code>Offset: 0x0065E910
    /// void __thiscall SharedCriticalSection::LeaveCriticalSection(SharedCriticalSection*)</code>
    /// </summary>
    public void LeaveCriticalSection() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SharedCriticalSection, void>)0x0065E910)(ref this);
}

