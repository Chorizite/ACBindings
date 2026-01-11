namespace ACBindings.Internal;

public unsafe struct DDD_ErrorMessage
{
    // Base Classes
    public ACBindings.Internal.FakeMessageData BaseClass_FakeMessageData; // ACBindings.Internal.FakeMessageData

    // Child Types
    public unsafe struct DDD_ErrorMessage_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DDD_ErrorMessage*, ACBindings.Internal.Archive*, void> Serialize; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.QualifiedDataID m_qdid;
    public ACBindings.Internal.CliDatError m_eError;

    // Methods

    /// <summary>
    /// <code>Offset: 0x004F8A70
    /// void __thiscall DDD_ErrorMessage::Serialize(DDD_ErrorMessage*,Archive*)</code>
    /// </summary>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DDD_ErrorMessage, ACBindings.Internal.Archive*, void>)0x004F8A70)(ref this, io_archive);
}

