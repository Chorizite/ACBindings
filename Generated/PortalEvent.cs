namespace ACBindings;

// PortalEvent
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
    // void __thiscall PortalEvent::PortalEvent(PortalEvent*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PortalEvent, void>)0x0065EAE0)(ref this);
    // void __thiscall PortalEvent::~PortalEvent(PortalEvent*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PortalEvent, void>)0x0065EB00)(ref this);
    // bool __thiscall PortalEvent::WaitForSignal(PortalEvent*,unsigned int)
    public byte WaitForSignal(uint milliseconds) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PortalEvent, uint, byte>)0x0065EB30)(ref this, milliseconds);
}

