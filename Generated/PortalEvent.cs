namespace ACBindings.Internal;

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

    /// <summary>
    /// <code>Offset: 0x0065EAE0
    /// void __thiscall PortalEvent::PortalEvent(PortalEvent*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PortalEvent, void>)0x0065EAE0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0065EB00
    /// void __thiscall PortalEvent::~PortalEvent(PortalEvent*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PortalEvent, void>)0x0065EB00)(ref this);

    /// <summary>
    /// <code>Offset: 0x0065EB30
    /// bool __thiscall PortalEvent::WaitForSignal(PortalEvent*,unsigned int)</code>
    /// </summary>
    public byte WaitForSignal(uint milliseconds) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PortalEvent, uint, byte>)0x0065EB30)(ref this, milliseconds);
}

