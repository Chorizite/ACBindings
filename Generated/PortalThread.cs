namespace ACBindings.Internal;


/// <summary>Wraps an operating‑system thread, providing state flags for execution control, exit signaling, and run tracking, while managing the thread handle and identifier.</summary>
public unsafe struct PortalThread : System.IDisposable
{
    // Child Types

    /// <summary>Defines the virtual function table layout for PortalThread, mapping its methods to implementations.</summary>
    public unsafe struct PortalThread_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.PortalThread*, void> PortalThread_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.PortalThread*, int> Startup; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.PortalThread*, byte, void> SetShouldExit; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.PortalThread*, void> WakeForTheReaper; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public System.IntPtr m_hThread;
    public uint m_idThread;
    public byte m_fThreadRunning;
    public byte m_fShouldExit;
    public byte m_fThreadHasEverRun;

    // Generated Constructor
    public PortalThread(uint i_defaultStackSize) {
        _ConstructorInternal(i_defaultStackSize);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Sets the flag indicating whether the portal thread should terminate, optionally waking the thread to handle shutdown.
    /// <code>Offset: 0x004FCB90
    /// void __thiscall PortalThread::SetShouldExit(PortalThread*,bool)</code>
    /// </summary>
    /// <param name="fExit">True to signal the thread to exit; false clears the exit request.</param>
    public void SetShouldExit(byte fExit) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PortalThread, byte, void>)0x004FCB90)(ref this, fExit);

    /// <summary>Releases resources owned by a PortalThread instance, closes its thread handle, and resets the virtual table pointer.
    /// <code>Offset: 0x0065E960
    /// void __thiscall PortalThread::~PortalThread(PortalThread*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PortalThread, void>)0x0065E960)(ref this);

    /// <summary>Resumes the underlying thread and blocks until it has executed at least once.
    /// <code>Offset: 0x0065E9A0
    /// bool __thiscall PortalThread::Resume(PortalThread*)</code>
    /// </summary>
    /// <returns>True if the thread was successfully resumed; otherwise, false.</returns>
    public byte Resume() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PortalThread, byte>)0x0065E9A0)(ref this);

    /// <summary>Initializes a new portal thread, setting default state fields and launching an operating‑system thread with the supplied stack size.
    /// <code>Offset: 0x0065EA90
    /// void __thiscall PortalThread::PortalThread(PortalThread*,unsigned int)</code>
    /// </summary>
    /// <param name="i_defaultStackSize">The desired stack size for the newly created thread; if zero, the system default is used.</param>
    public void _ConstructorInternal(uint i_defaultStackSize) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PortalThread, uint, void>)0x0065EA90)(ref this, i_defaultStackSize);
}

