namespace ACBindings.Internal;

public unsafe struct DDD_DataMessage
{
    // Base Classes
    public ACBindings.Internal.FakeMessageData BaseClass_FakeMessageData; // ACBindings.Internal.FakeMessageData

    // Child Types
    public unsafe struct DDD_DataMessage_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DDD_DataMessage*, ACBindings.Internal.Archive*, void> Serialize; // function pointer

        // Methods
    }

    // Members
    public ulong m_idDatFile;
    public ACBindings.Internal.QualifiedDataID m_qdid;
    public ACBindings.Internal.Cache_Pack_t m_cpData;
    public int m_idIteration;
    public byte m_bCompressed;

    // Generated Constructor
    public DDD_DataMessage() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x004F7F20
    /// unsigned int __thiscall DDD_DataMessage::GetCompressedSize(DDD_DataMessage*)</code>
    /// </summary>
    public uint GetCompressedSize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DDD_DataMessage, uint>)0x004F7F20)(ref this);

    /// <summary>
    /// <code>Offset: 0x004F8350
    /// void __thiscall DDD_DataMessage::DDD_DataMessage(DDD_DataMessage*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DDD_DataMessage, void>)0x004F8350)(ref this);

    /// <summary>
    /// <code>Offset: 0x004F8820
    /// void __thiscall DDD_DataMessage::Serialize(DDD_DataMessage*,Archive*)</code>
    /// </summary>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DDD_DataMessage, ACBindings.Internal.Archive*, void>)0x004F8820)(ref this, io_archive);
}

