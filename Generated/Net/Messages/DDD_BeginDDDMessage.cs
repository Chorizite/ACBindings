namespace ACBindings.Internal;


/// <summary>Encapsulates the initiation data of a DDD transaction, holding type information, expected byte count, and any missing iteration details.</summary>
/// <remarks>Designed for serializing its state through an Archive, ensuring proper alignment and resource cleanup.</remarks>
public unsafe struct DDD_BeginDDDMessage : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.FakeMessageData BaseClass_FakeMessageData; // ACBindings.Internal.FakeMessageData

    // Child Types
    public unsafe struct DDD_BeginDDDMessage_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DDD_BeginDDDMessage*, ACBindings.Internal.Archive*, void> Serialize; // function pointer

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

    /// <summary>Releases resources held by the DDD_BeginDDDMessage instance, deleting any dynamically allocated MissingIteration elements when appropriate.
    /// <code>Offset: 0x004F9B20
    /// void __thiscall DDD_BeginDDDMessage::~DDD_BeginDDDMessage(DDD_BeginDDDMessage*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DDD_BeginDDDMessage, void>)0x004F9B20)(ref this);

    /// <summary>Serializes the DDD_BeginDDDMessage state, including its type identifier, expected data size, and missing iterations list, into or from the provided archive.
    /// <code>Offset: 0x004FA6E0
    /// void __thiscall DDD_BeginDDDMessage::Serialize(DDD_BeginDDDMessage*,Archive*)</code>
    /// </summary>
    /// <param name="io_archive">Archive used for serialization; its flags determine whether the operation writes to or reads from the buffer.</param>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DDD_BeginDDDMessage, ACBindings.Internal.Archive*, void>)0x004FA6E0)(ref this, io_archive);
}

