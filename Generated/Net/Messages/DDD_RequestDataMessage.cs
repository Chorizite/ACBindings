namespace ACBindings;

// DDD_RequestDataMessage
public unsafe struct DDD_RequestDataMessage
{
    // Base Classes
    public ACBindings.FakeMessageData BaseClass_FakeMessageData; // ACBindings.FakeMessageData

    // Child Types
    // DDD_RequestDataMessage_vtbl
    public unsafe struct DDD_RequestDataMessage_vtbl
    {
        // Members
        public System.IntPtr Serialize; // function pointer

        // Methods
    }

    // Members
    public ACBindings.QualifiedDataID m_qdid;

    // Methods
    // void __thiscall DDD_RequestDataMessage::Serialize(DDD_RequestDataMessage*,Archive*)
    public void Serialize(ACBindings.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.DDD_RequestDataMessage, ACBindings.Archive*, void>)0x004F89F0)(ref this, io_archive);
}

