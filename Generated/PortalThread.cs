namespace ACBindings;

// PortalThread
public unsafe struct PortalThread : System.IDisposable
{
    // Child Types
    // PortalThread_vtbl
    public unsafe struct PortalThread_vtbl
    {
        // Members
        public System.IntPtr PortalThread_dtor_0; // function pointer
        public System.IntPtr Startup; // function pointer
        public System.IntPtr SetShouldExit; // function pointer
        public System.IntPtr WakeForTheReaper; // function pointer

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
    // void __thiscall PortalThread::SetShouldExit(PortalThread*,bool)
    public void SetShouldExit(byte fExit) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PortalThread, byte, void>)0x004FCB90)(ref this, fExit);
    // void __thiscall PortalThread::~PortalThread(PortalThread*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PortalThread, void>)0x0065E960)(ref this);
    // bool __thiscall PortalThread::Resume(PortalThread*)
    public byte Resume() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PortalThread, byte>)0x0065E9A0)(ref this);
    // void __thiscall PortalThread::PortalThread(PortalThread*,unsigned int)
    public void _ConstructorInternal(uint i_defaultStackSize) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PortalThread, uint, void>)0x0065EA90)(ref this, i_defaultStackSize);
}

