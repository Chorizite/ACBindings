namespace ACBindings;

// DDD_BeginDDDMessage
public unsafe struct DDD_BeginDDDMessage : System.IDisposable
{
    // Base Classes
    public ACBindings.FakeMessageData BaseClass_FakeMessageData; // ACBindings.FakeMessageData

    // Child Types
    // DDD_BeginDDDMessage_vtbl
    public unsafe struct DDD_BeginDDDMessage_vtbl
    {
        // Members
        public System.IntPtr Serialize; // function pointer

        // Methods
    }

    // Members
    public uint m_cbDataExpected;
    public ACBindings.SmartArray__MissingIteration m_MissingIterations;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall DDD_BeginDDDMessage::~DDD_BeginDDDMessage(DDD_BeginDDDMessage*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.DDD_BeginDDDMessage, void>)0x004F9B20)(ref this);
    // void __thiscall DDD_BeginDDDMessage::Serialize(DDD_BeginDDDMessage*,Archive*)
    public void Serialize(ACBindings.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.DDD_BeginDDDMessage, ACBindings.Archive*, void>)0x004FA6E0)(ref this, io_archive);
}

