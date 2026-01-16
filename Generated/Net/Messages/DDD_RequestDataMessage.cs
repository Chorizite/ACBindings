namespace ACBindings.Internal;


/// <summary>Encapsulates a request to obtain a data item identified by a QualifiedDataID, and inherits common message metadata from FakeMessageData for transmission in the system’s messaging framework.</summary>
public unsafe struct DDD_RequestDataMessage
{
    // Base Classes
    public ACBindings.Internal.FakeMessageData BaseClass_FakeMessageData; // ACBindings.Internal.FakeMessageData

    // Child Types
    public unsafe struct DDD_RequestDataMessage_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DDD_RequestDataMessage*, ACBindings.Internal.Archive*, void> Serialize; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.QualifiedDataID m_qdid;

    // Methods

    /// <summary>Serializes or deserializes the message’s data to or from an Archive object, handling alignment and conditional field access based on archive mode.
    /// <code>Offset: 0x004F89F0
    /// void __thiscall DDD_RequestDataMessage::Serialize(DDD_RequestDataMessage*,Archive*)</code>
    /// </summary>
    /// <param name="io_archive">The Archive used for reading or writing the message fields.</param>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DDD_RequestDataMessage, ACBindings.Internal.Archive*, void>)0x004F89F0)(ref this, io_archive);
}

