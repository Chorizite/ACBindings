namespace ACBindings.Internal;

public unsafe struct SentPacketStore : System.IDisposable
{
    // Members
    public ACBindings.Internal.NIList___NetPacket_ptr m_sentPacketList;
    public ACBindings.Internal.HashTable__ulong__ulong m_sentNetBlobIDInfo;

    // Generated Constructor
    public SentPacketStore() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x0054B400
    /// int __thiscall SentPacketStore::Contains(SentPacketStore*,unsigned int)</code>
    /// </summary>
    public int Contains(uint seqID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SentPacketStore, uint, int>)0x0054B400)(ref this, seqID);

    /// <summary>
    /// <code>Offset: 0x0054B430
    /// NetPacket* __thiscall SentPacketStore::GenerateAck(SentPacketStore*,unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.NetPacket* GenerateAck(uint seqID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SentPacketStore, uint, ACBindings.Internal.NetPacket*>)0x0054B430)(ref this, seqID);

    /// <summary>
    /// <code>Offset: 0x0054B690
    /// void __thiscall SentPacketStore::SentPacketStore(SentPacketStore*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SentPacketStore, void>)0x0054B690)(ref this);

    /// <summary>
    /// <code>Offset: 0x0054B6C0
    /// void __thiscall SentPacketStore::~SentPacketStore(SentPacketStore*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SentPacketStore, void>)0x0054B6C0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0054B710
    /// int __thiscall SentPacketStore::AddSentPacket(SentPacketStore*,NetPacket*)</code>
    /// </summary>
    public int AddSentPacket(ACBindings.Internal.NetPacket* packet) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SentPacketStore, ACBindings.Internal.NetPacket*, int>)0x0054B710)(ref this, packet);

    /// <summary>
    /// <code>Offset: 0x0054B860
    /// void __thiscall SentPacketStore::EraseNetBlobID(SentPacketStore*,unsigned __int64)</code>
    /// </summary>
    public void EraseNetBlobID(ulong id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SentPacketStore, ulong, void>)0x0054B860)(ref this, id);

    /// <summary>
    /// <code>Offset: 0x0054B8E0
    /// int __thiscall SentPacketStore::Flush(SentPacketStore*,unsigned int,int)</code>
    /// </summary>
    public int Flush(uint highest, int everything) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SentPacketStore, uint, int, int>)0x0054B8E0)(ref this, highest, everything);
}

