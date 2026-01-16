namespace ACBindings.Internal;


/// <summary>Encapsulates an error message transmitted in the DDD system, providing a message type identifier, unique data ID, and detailed client error information.</summary>
public unsafe struct DDD_ErrorMessage
{
    // Base Classes
    public ACBindings.Internal.FakeMessageData BaseClass_FakeMessageData; // ACBindings.Internal.FakeMessageData

    // Child Types
    public unsafe struct DDD_ErrorMessage_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DDD_ErrorMessage*, ACBindings.Internal.Archive*, void> Serialize; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.QualifiedDataID m_qdid;
    public ACBindings.Internal.CliDatError m_eError;

    // Methods

    /// <summary>Serializes the error message data to or from an Archive, handling alignment and field ordering based on operation mode.
    /// <code>Offset: 0x004F8A70
    /// void __thiscall DDD_ErrorMessage::Serialize(DDD_ErrorMessage*,Archive*)</code>
    /// </summary>
    /// <param name="io_archive">Archive used for serialization; its flags determine whether fields are written or read.</param>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DDD_ErrorMessage, ACBindings.Internal.Archive*, void>)0x004F8A70)(ref this, io_archive);
}

