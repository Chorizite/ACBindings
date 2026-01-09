namespace ACBindings;

// CAMEvent
public unsafe struct CAMEvent : System.IDisposable
{
    // Members
    public System.IntPtr m_hEvent;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall CAMEvent::~CAMEvent(CAMEvent*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CAMEvent, void>)0x006C1FB0)(ref this);
}

