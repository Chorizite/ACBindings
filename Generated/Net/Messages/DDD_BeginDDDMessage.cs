namespace ACBindings.Internal;

public unsafe struct DDD_BeginDDDMessage : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.FakeMessageData BaseClass_FakeMessageData; // ACBindings.Internal.FakeMessageData

    // Child Types
    public unsafe struct DDD_BeginDDDMessage_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DDD_BeginDDDMessage*, ACBindings.Internal.Archive*, void> Serialize; // function pointer

        // Methods
    }

    // Members
    public uint m_cbDataExpected;
    public ACBindings.Internal.SmartArray___MissingIteration m_MissingIterations;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x004F9B20
    /// void __thiscall DDD_BeginDDDMessage::~DDD_BeginDDDMessage(DDD_BeginDDDMessage*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DDD_BeginDDDMessage, void>)0x004F9B20)(ref this);

    /// <summary>
    /// <code>Offset: 0x004FA6E0
    /// void __thiscall DDD_BeginDDDMessage::Serialize(DDD_BeginDDDMessage*,Archive*)</code>
    /// </summary>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DDD_BeginDDDMessage, ACBindings.Internal.Archive*, void>)0x004FA6E0)(ref this, io_archive);
}

