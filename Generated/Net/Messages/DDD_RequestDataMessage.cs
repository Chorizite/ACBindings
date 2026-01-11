namespace ACBindings.Internal;

public unsafe struct DDD_RequestDataMessage
{
    // Base Classes
    public ACBindings.Internal.FakeMessageData BaseClass_FakeMessageData; // ACBindings.Internal.FakeMessageData

    // Child Types
    public unsafe struct DDD_RequestDataMessage_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DDD_RequestDataMessage*, ACBindings.Internal.Archive*, void> Serialize; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.QualifiedDataID m_qdid;

    // Methods

    /// <summary>
    /// <code>Offset: 0x004F89F0
    /// void __thiscall DDD_RequestDataMessage::Serialize(DDD_RequestDataMessage*,Archive*)</code>
    /// </summary>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DDD_RequestDataMessage, ACBindings.Internal.Archive*, void>)0x004F89F0)(ref this, io_archive);
}

