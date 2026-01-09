namespace ACBindings;

// SentPacketStore
public unsafe struct SentPacketStore : System.IDisposable
{
    // Members
    public ACBindings.NIList__NetPacket_ptr m_sentPacketList;
    public ACBindings.HashTable__ulong__ulong m_sentNetBlobIDInfo;

    // Generated Constructor
    public SentPacketStore() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // int __thiscall SentPacketStore::Contains(SentPacketStore*,unsigned int)
    public int Contains(uint seqID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SentPacketStore, uint, int>)0x0054B400)(ref this, seqID);
    // NetPacket* __thiscall SentPacketStore::GenerateAck(SentPacketStore*,unsigned int)
    public ACBindings.NetPacket* GenerateAck(uint seqID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SentPacketStore, uint, ACBindings.NetPacket*>)0x0054B430)(ref this, seqID);
    // void __thiscall SentPacketStore::SentPacketStore(SentPacketStore*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.SentPacketStore, void>)0x0054B690)(ref this);
    // void __thiscall SentPacketStore::~SentPacketStore(SentPacketStore*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.SentPacketStore, void>)0x0054B6C0)(ref this);
    // int __thiscall SentPacketStore::AddSentPacket(SentPacketStore*,NetPacket*)
    public int AddSentPacket(ACBindings.NetPacket* packet) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SentPacketStore, ACBindings.NetPacket*, int>)0x0054B710)(ref this, packet);
    // void __thiscall SentPacketStore::EraseNetBlobID(SentPacketStore*,unsigned __int64)
    public void EraseNetBlobID(ulong id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SentPacketStore, ulong, void>)0x0054B860)(ref this, id);
    // int __thiscall SentPacketStore::Flush(SentPacketStore*,unsigned int,int)
    public int Flush(uint highest, int everything) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SentPacketStore, uint, int, int>)0x0054B8E0)(ref this, highest, everything);
}

