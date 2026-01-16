namespace ACBindings.Internal;


/// <summary>Provides a lightweight wrapper around a Windows event handle, enabling threads to wait for signals.</summary>
/// <remarks>Creates an unnamed event upon construction and releases the handle in the destructor, managing synchronization resources automatically.</remarks>
public unsafe struct PortalEvent : System.IDisposable
{
    // Members
    public System.IntPtr eventHandle_;

    // Generated Constructor
    public PortalEvent() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Initializes a PortalEvent by creating an unnamed Windows event and storing its handle internally.
    /// <code>Offset: 0x0065EAE0
    /// void __thiscall PortalEvent::PortalEvent(PortalEvent*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PortalEvent, void>)0x0065EAE0)(ref this);

    /// <summary>Releases the operating system event handle owned by this PortalEvent instance during destruction.
    /// <code>Offset: 0x0065EB00
    /// void __thiscall PortalEvent::~PortalEvent(PortalEvent*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PortalEvent, void>)0x0065EB00)(ref this);

    /// <summary>Waits for a signal on the event object up to a specified timeout, returning true if signaled before the timeout expires.
    /// <code>Offset: 0x0065EB30
    /// bool __thiscall PortalEvent::WaitForSignal(PortalEvent*,unsigned int)</code>
    /// </summary>
    /// <param name="milliseconds">Maximum time in milliseconds to wait for the event to become signaled.</param>
    /// <returns>True if the event was signaled within the timeout; otherwise false.</returns>
    public byte WaitForSignal(uint milliseconds) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PortalEvent, uint, byte>)0x0065EB30)(ref this, milliseconds);
}

