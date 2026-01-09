namespace ACBindings;

// FlowQueue
public unsafe struct FlowQueue : System.IDisposable
{
    // Statics
    public static ACBindings.PerfMonCounter__ulong* m_pBlobsDequeuedCounter = (ACBindings.PerfMonCounter__ulong*)0x00846F64;

    // Child Types
    // FlowQueue_vtbl
    public unsafe struct FlowQueue_vtbl
    {
        // Members
        public System.IntPtr FlowQueue_dtor_0; // function pointer
        public System.IntPtr Enqueue; // function pointer
        public System.IntPtr Dequeue; // function pointer
        public System.IntPtr IncrementLocalInterval; // function pointer
        public System.IntPtr WireRoomLeft; // function pointer
        public System.IntPtr FragQueueRoomLeft; // function pointer
        public System.IntPtr RecordBytesSent; // function pointer
        public System.IntPtr RecordBytesQueued; // function pointer
        public System.IntPtr RecordBytesDequeued; // function pointer
        public System.IntPtr EnqueuePacket; // function pointer
        public System.IntPtr DequeuePacket; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public ACBindings.NetPacket* waitingPacketsHead_;
    public ACBindings.NetPacket* waitingPacketsTail_;
    public ACBindings.NIList__uint m_ackList;
    public ACBindings.SentPacketStore m_sentPacketStore;
    public ACBindings.NIList__uint m_emptyAckList;
    public ACBindings.HashTable__uint__int empties_;
    public fixed uint emptyAcks_[116];
    public int emptyNum_;
    public int m_cPacketsSent;
    public int m_cPacketsAcked;
    public uint highestIDSent_;
    public int addr_;
    public ACBindings.RecipientData* myRecip_;
    public ACBindings.ReceiverData* myReceiverData_;
    public ushort netID_;
    public ACBindings.IntervalData CurLocalInterval_;
    public ACBindings.PQueueArray__uint__void_ptr pqueueSpecial_;
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
    // NetPacket* __thiscall FlowQueue::DequeuePacket(FlowQueue*,NetPacket**,NetPacket**)
    public ACBindings.NetPacket* DequeuePacket(ACBindings.NetPacket** head, ACBindings.NetPacket** tail) => ((delegate* unmanaged[Thiscall]<ref ACBindings.FlowQueue, ACBindings.NetPacket**, ACBindings.NetPacket**, ACBindings.NetPacket*>)0x00547C30)(ref this, head, tail);
    // void __thiscall FlowQueue::EncryptChecksum(FlowQueue*,NetPacket*,unsigned int,unsigned int*)
    public void EncryptChecksum(ACBindings.NetPacket* packet, uint seqnum, uint* pKey) => ((delegate* unmanaged[Thiscall]<ref ACBindings.FlowQueue, ACBindings.NetPacket*, uint, uint*, void>)0x00547C70)(ref this, packet, seqnum, pKey);
    // void __thiscall FlowQueue::IncrementLocalInterval(FlowQueue*,unsigned int)
    public void IncrementLocalInterval(uint cIntervals) => ((delegate* unmanaged[Thiscall]<ref ACBindings.FlowQueue, uint, void>)0x00547CC0)(ref this, cIntervals);
    // void __cdecl FlowQueue::SharedStaticCleanup()
    public static void SharedStaticCleanup() => ((delegate* unmanaged[Cdecl]<void>)0x00547E70)();
    // NetPacket* __thiscall FlowQueue::DequeueAck(FlowQueue*)
    public ACBindings.NetPacket* DequeueAck() => ((delegate* unmanaged[Thiscall]<ref ACBindings.FlowQueue, ACBindings.NetPacket*>)0x00547EB0)(ref this);
    // void __thiscall FlowQueue::EnqueuePacket(FlowQueue*,NetPacket*,NetPacket**,NetPacket**)
    public void EnqueuePacket(ACBindings.NetPacket* packet, ACBindings.NetPacket** head, ACBindings.NetPacket** tail) => ((delegate* unmanaged[Thiscall]<ref ACBindings.FlowQueue, ACBindings.NetPacket*, ACBindings.NetPacket**, ACBindings.NetPacket**, void>)0x00547F70)(ref this, packet, head, tail);
    // void __thiscall FlowQueue::EnqueueOptionalHeader(FlowQueue*,COptionalHeader*)
    public void EnqueueOptionalHeader(ACBindings.COptionalHeader* newFrag) => ((delegate* unmanaged[Thiscall]<ref ACBindings.FlowQueue, ACBindings.COptionalHeader*, void>)0x00548230)(ref this, newFrag);
    // void __thiscall FlowQueue::FlushSentPackets(FlowQueue*,unsigned int,int)
    public void FlushSentPackets(uint id, int fEverything) => ((delegate* unmanaged[Thiscall]<ref ACBindings.FlowQueue, uint, int, void>)0x00548280)(ref this, id, fEverything);
    // void __thiscall FlowQueue::CoalesceData(FlowQueue*)
    public void CoalesceData() => ((delegate* unmanaged[Thiscall]<ref ACBindings.FlowQueue, void>)0x00548300)(ref this);
    // bool __thiscall FlowQueue::TransmitNewPackets(FlowQueue*)
    public byte TransmitNewPackets() => ((delegate* unmanaged[Thiscall]<ref ACBindings.FlowQueue, byte>)0x00548620)(ref this);
    // void __thiscall FlowQueue::FlowQueue(FlowQueue*,sockaddr_in,unsigned __int16,float)
    public void _ConstructorInternal(int addr, ushort recID, float lineNoise) => ((delegate* unmanaged[Thiscall]<ref ACBindings.FlowQueue, int, ushort, float, void>)0x00548D40)(ref this, addr, recID, lineNoise);
    // void __thiscall FlowQueue::~FlowQueue(FlowQueue*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.FlowQueue, void>)0x00548E60)(ref this);
    // void __thiscall FlowQueue::EnqueueEmptyAck(FlowQueue*,unsigned int)
    public void EnqueueEmptyAck(uint id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.FlowQueue, uint, void>)0x00548EE0)(ref this, id);
    // int __thiscall FlowQueue::DequeueEmptyAck(FlowQueue*,unsigned int*)
    public int DequeueEmptyAck(uint* seqID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.FlowQueue, uint*, int>)0x00548FA0)(ref this, seqID);
    // void __thiscall FlowQueue::CompileEmptyAcks(FlowQueue*)
    public void CompileEmptyAcks() => ((delegate* unmanaged[Thiscall]<ref ACBindings.FlowQueue, void>)0x00549020)(ref this);
    // bool __thiscall FlowQueue::TransmitNaks(FlowQueue*)
    public byte TransmitNaks() => ((delegate* unmanaged[Thiscall]<ref ACBindings.FlowQueue, byte>)0x005490A0)(ref this);
    // bool __thiscall FlowQueue::TransmitAcks(FlowQueue*)
    public byte TransmitAcks() => ((delegate* unmanaged[Thiscall]<ref ACBindings.FlowQueue, byte>)0x00549110)(ref this);
    // void __thiscall FlowQueue::Destroy(FlowQueue*)
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.FlowQueue, void>)0x00549340)(ref this);
    // void __thiscall FlowQueue::EnqueueAcks(FlowQueue*,const unsigned int*,int)
    public void EnqueueAcks(uint* id, int nIDs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.FlowQueue, uint*, int, void>)0x00549440)(ref this, id, nIDs);
    // void __thiscall FlowQueue::Empty(FlowQueue*)
    public void Empty() => ((delegate* unmanaged[Thiscall]<ref ACBindings.FlowQueue, void>)0x00549580)(ref this);
    // void __cdecl FlowQueue::SharedStaticInit()
    public static void SharedStaticInit() => ((delegate* unmanaged[Cdecl]<void>)0x005496D0)();
}

