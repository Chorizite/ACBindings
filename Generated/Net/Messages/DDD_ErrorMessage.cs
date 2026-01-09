namespace ACBindings;

// DDD_ErrorMessage
public unsafe struct DDD_ErrorMessage
{
    // Base Classes
    public ACBindings.FakeMessageData BaseClass_FakeMessageData; // ACBindings.FakeMessageData

    // Child Types
    // DDD_ErrorMessage_vtbl
    public unsafe struct DDD_ErrorMessage_vtbl
    {
        // Members
        public System.IntPtr Serialize; // function pointer

        // Methods
    }

    // Members
    public ACBindings.QualifiedDataID m_qdid;
    public ACBindings.CliDatError m_eError;

    // Methods
    // void __thiscall DDD_ErrorMessage::Serialize(DDD_ErrorMessage*,Archive*)
    public void Serialize(ACBindings.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.DDD_ErrorMessage, ACBindings.Archive*, void>)0x004F8A70)(ref this, io_archive);
}

