namespace ACBindings.Internal;

public unsafe struct FlowQueue : System.IDisposable
{
    // Statics
    public static ACBindings.Internal.PerfMonCounter__ulong* m_pBlobsDequeuedCounter = (ACBindings.Internal.PerfMonCounter__ulong*)0x00846F64;

    // Child Types
    public unsafe struct FlowQueue_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.FlowQueue*, void> FlowQueue_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.FlowQueue*, ACBindings.Internal.NetBlob*, void> Enqueue; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.FlowQueue*, int, ACBindings.Internal.NetBlob*> Dequeue; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.FlowQueue*, uint, void> IncrementLocalInterval; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.FlowQueue*, int, int> WireRoomLeft; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.FlowQueue*, int, int> FragQueueRoomLeft; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.FlowQueue*, int, void> RecordBytesSent; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.FlowQueue*, int, void> RecordBytesQueued; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.FlowQueue*, int, void> RecordBytesDequeued; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.FlowQueue*, ACBindings.Internal.NetPacket*, ACBindings.Internal.NetPacket**, ACBindings.Internal.NetPacket**, void> EnqueuePacket; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.FlowQueue*, ACBindings.Internal.NetPacket**, ACBindings.Internal.NetPacket**, ACBindings.Internal.NetPacket*> DequeuePacket; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public ACBindings.Internal.NetPacket* waitingPacketsHead_;
    public ACBindings.Internal.NetPacket* waitingPacketsTail_;
    public ACBindings.Internal.NIList__uint m_ackList;
    public ACBindings.Internal.SentPacketStore m_sentPacketStore;
    public ACBindings.Internal.NIList__uint m_emptyAckList;
    public ACBindings.Internal.HashTable__uint__int empties_;
    public fixed uint emptyAcks_[116];
    public int emptyNum_;
    public int m_cPacketsSent;
    public int m_cPacketsAcked;
    public uint highestIDSent_;
    public int addr_;
    public ACBindings.Internal.RecipientData* myRecip_;
    public ACBindings.Internal.ReceiverData* myReceiverData_;
    public ushort netID_;
    public ACBindings.Internal.IntervalData CurLocalInterval_;
    public ACBindings.Internal.PQueueArray__uint__void_ptr pqueueSpecial_;
    public double intervalTime_;
    public ushort lastIntervalAcked_;

    // Generated Constructor
    public FlowQueue(int addr, ushort recID, float lineNoise) {
        _ConstructorInternal(addr, recID, lineNoise);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x00547C30
    /// NetPacket* __thiscall FlowQueue::DequeuePacket(FlowQueue*,NetPacket**,NetPacket**)</code>
    /// </summary>
    public ACBindings.Internal.NetPacket* DequeuePacket(ACBindings.Internal.NetPacket** head, ACBindings.Internal.NetPacket** tail) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FlowQueue, ACBindings.Internal.NetPacket**, ACBindings.Internal.NetPacket**, ACBindings.Internal.NetPacket*>)0x00547C30)(ref this, head, tail);

    /// <summary>
    /// <code>Offset: 0x00547C70
    /// void __thiscall FlowQueue::EncryptChecksum(FlowQueue*,NetPacket*,unsigned int,unsigned int*)</code>
    /// </summary>
    public void EncryptChecksum(ACBindings.Internal.NetPacket* packet, uint seqnum, uint* pKey) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FlowQueue, ACBindings.Internal.NetPacket*, uint, uint*, void>)0x00547C70)(ref this, packet, seqnum, pKey);

    /// <summary>
    /// <code>Offset: 0x00547CC0
    /// void __thiscall FlowQueue::IncrementLocalInterval(FlowQueue*,unsigned int)</code>
    /// </summary>
    public void IncrementLocalInterval(uint cIntervals) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FlowQueue, uint, void>)0x00547CC0)(ref this, cIntervals);

    /// <summary>
    /// <code>Offset: 0x00547E70
    /// void __cdecl FlowQueue::SharedStaticCleanup()</code>
    /// </summary>
    public static void SharedStaticCleanup() => ((delegate* unmanaged[Cdecl]<void>)0x00547E70)();

    /// <summary>
    /// <code>Offset: 0x00547EB0
    /// NetPacket* __thiscall FlowQueue::DequeueAck(FlowQueue*)</code>
    /// </summary>
    public ACBindings.Internal.NetPacket* DequeueAck() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FlowQueue, ACBindings.Internal.NetPacket*>)0x00547EB0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00547F70
    /// void __thiscall FlowQueue::EnqueuePacket(FlowQueue*,NetPacket*,NetPacket**,NetPacket**)</code>
    /// </summary>
    public void EnqueuePacket(ACBindings.Internal.NetPacket* packet, ACBindings.Internal.NetPacket** head, ACBindings.Internal.NetPacket** tail) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FlowQueue, ACBindings.Internal.NetPacket*, ACBindings.Internal.NetPacket**, ACBindings.Internal.NetPacket**, void>)0x00547F70)(ref this, packet, head, tail);

    /// <summary>
    /// <code>Offset: 0x00548230
    /// void __thiscall FlowQueue::EnqueueOptionalHeader(FlowQueue*,COptionalHeader*)</code>
    /// </summary>
    public void EnqueueOptionalHeader(ACBindings.Internal.COptionalHeader* newFrag) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FlowQueue, ACBindings.Internal.COptionalHeader*, void>)0x00548230)(ref this, newFrag);

    /// <summary>
    /// <code>Offset: 0x00548280
    /// void __thiscall FlowQueue::FlushSentPackets(FlowQueue*,unsigned int,int)</code>
    /// </summary>
    public void FlushSentPackets(uint id, int fEverything) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FlowQueue, uint, int, void>)0x00548280)(ref this, id, fEverything);

    /// <summary>
    /// <code>Offset: 0x00548300
    /// void __thiscall FlowQueue::CoalesceData(FlowQueue*)</code>
    /// </summary>
    public void CoalesceData() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FlowQueue, void>)0x00548300)(ref this);

    /// <summary>
    /// <code>Offset: 0x00548620
    /// bool __thiscall FlowQueue::TransmitNewPackets(FlowQueue*)</code>
    /// </summary>
    public byte TransmitNewPackets() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FlowQueue, byte>)0x00548620)(ref this);

    /// <summary>
    /// <code>Offset: 0x00548D40
    /// void __thiscall FlowQueue::FlowQueue(FlowQueue*,sockaddr_in,unsigned __int16,float)</code>
    /// </summary>
    public void _ConstructorInternal(int addr, ushort recID, float lineNoise) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FlowQueue, int, ushort, float, void>)0x00548D40)(ref this, addr, recID, lineNoise);

    /// <summary>
    /// <code>Offset: 0x00548E60
    /// void __thiscall FlowQueue::~FlowQueue(FlowQueue*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FlowQueue, void>)0x00548E60)(ref this);

    /// <summary>
    /// <code>Offset: 0x00548EE0
    /// void __thiscall FlowQueue::EnqueueEmptyAck(FlowQueue*,unsigned int)</code>
    /// </summary>
    public void EnqueueEmptyAck(uint id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FlowQueue, uint, void>)0x00548EE0)(ref this, id);

    /// <summary>
    /// <code>Offset: 0x00548FA0
    /// int __thiscall FlowQueue::DequeueEmptyAck(FlowQueue*,unsigned int*)</code>
    /// </summary>
    public int DequeueEmptyAck(uint* seqID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FlowQueue, uint*, int>)0x00548FA0)(ref this, seqID);

    /// <summary>
    /// <code>Offset: 0x00549020
    /// void __thiscall FlowQueue::CompileEmptyAcks(FlowQueue*)</code>
    /// </summary>
    public void CompileEmptyAcks() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FlowQueue, void>)0x00549020)(ref this);

    /// <summary>
    /// <code>Offset: 0x005490A0
    /// bool __thiscall FlowQueue::TransmitNaks(FlowQueue*)</code>
    /// </summary>
    public byte TransmitNaks() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FlowQueue, byte>)0x005490A0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00549110
    /// bool __thiscall FlowQueue::TransmitAcks(FlowQueue*)</code>
    /// </summary>
    public byte TransmitAcks() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FlowQueue, byte>)0x00549110)(ref this);

    /// <summary>
    /// <code>Offset: 0x00549340
    /// void __thiscall FlowQueue::Destroy(FlowQueue*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FlowQueue, void>)0x00549340)(ref this);

    /// <summary>
    /// <code>Offset: 0x00549440
    /// void __thiscall FlowQueue::EnqueueAcks(FlowQueue*,const unsigned int*,int)</code>
    /// </summary>
    public void EnqueueAcks(uint* id, int nIDs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FlowQueue, uint*, int, void>)0x00549440)(ref this, id, nIDs);

    /// <summary>
    /// <code>Offset: 0x00549580
    /// void __thiscall FlowQueue::Empty(FlowQueue*)</code>
    /// </summary>
    public void Empty() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FlowQueue, void>)0x00549580)(ref this);

    /// <summary>
    /// <code>Offset: 0x005496D0
    /// void __cdecl FlowQueue::SharedStaticInit()</code>
    /// </summary>
    public static void SharedStaticInit() => ((delegate* unmanaged[Cdecl]<void>)0x005496D0)();
}

