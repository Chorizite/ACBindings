namespace ACBindings.Internal;


/// <summary>Encapsulates a Windows event handle for synchronization purposes, automatically closing it when the object is destroyed.</summary>
public unsafe struct CAMEvent : System.IDisposable
{
    // Members
    public System.IntPtr m_hEvent;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Destroys a CAMEvent instance by closing its associated event handle when it is valid.
    /// <code>Offset: 0x006C1FB0
    /// void __thiscall CAMEvent::~CAMEvent(CAMEvent*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CAMEvent, void>)0x006C1FB0)(ref this);
}

