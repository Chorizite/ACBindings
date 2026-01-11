namespace ACBindings.Internal;

public unsafe struct PortalThread : System.IDisposable
{
    // Child Types
    public unsafe struct PortalThread_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.PortalThread*, void> PortalThread_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.PortalThread*, int> Startup; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.PortalThread*, byte, void> SetShouldExit; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.PortalThread*, void> WakeForTheReaper; // function pointer

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

    /// <summary>
    /// <code>Offset: 0x004FCB90
    /// void __thiscall PortalThread::SetShouldExit(PortalThread*,bool)</code>
    /// </summary>
    public void SetShouldExit(byte fExit) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PortalThread, byte, void>)0x004FCB90)(ref this, fExit);

    /// <summary>
    /// <code>Offset: 0x0065E960
    /// void __thiscall PortalThread::~PortalThread(PortalThread*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PortalThread, void>)0x0065E960)(ref this);

    /// <summary>
    /// <code>Offset: 0x0065E9A0
    /// bool __thiscall PortalThread::Resume(PortalThread*)</code>
    /// </summary>
    public byte Resume() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PortalThread, byte>)0x0065E9A0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0065EA90
    /// void __thiscall PortalThread::PortalThread(PortalThread*,unsigned int)</code>
    /// </summary>
    public void _ConstructorInternal(uint i_defaultStackSize) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PortalThread, uint, void>)0x0065EA90)(ref this, i_defaultStackSize);
}

