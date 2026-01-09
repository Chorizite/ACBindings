namespace ACBindings;

// DDD_DataMessage
public unsafe struct DDD_DataMessage
{
    // Base Classes
    public ACBindings.FakeMessageData BaseClass_FakeMessageData; // ACBindings.FakeMessageData

    // Child Types
    // DDD_DataMessage_vtbl
    public unsafe struct DDD_DataMessage_vtbl
    {
        // Members
        public System.IntPtr Serialize; // function pointer

        // Methods
    }

    // Members
    public ulong m_idDatFile;
    public ACBindings.QualifiedDataID m_qdid;
    public ACBindings.Cache_Pack_t m_cpData;
    public int m_idIteration;
    public byte m_bCompressed;

    // Generated Constructor
    public DDD_DataMessage() {
        _ConstructorInternal();
    }

    // Methods
    // unsigned int __thiscall DDD_DataMessage::GetCompressedSize(DDD_DataMessage*)
    public uint GetCompressedSize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.DDD_DataMessage, uint>)0x004F7F20)(ref this);
    // void __thiscall DDD_DataMessage::DDD_DataMessage(DDD_DataMessage*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.DDD_DataMessage, void>)0x004F8350)(ref this);
    // void __thiscall DDD_DataMessage::Serialize(DDD_DataMessage*,Archive*)
    public void Serialize(ACBindings.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.DDD_DataMessage, ACBindings.Archive*, void>)0x004F8820)(ref this, io_archive);
}

