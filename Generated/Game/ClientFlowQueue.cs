namespace ACBindings.Internal;

public unsafe struct ClientFlowQueue : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.FlowQueue BaseClass_FlowQueue; // ACBindings.Internal.FlowQueue

    // Child Types
    public unsafe struct ClientFlowQueue_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientFlowQueue*, void> ClientFlowQueue_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientFlowQueue*, ACBindings.Internal.NetBlob*, void> Enqueue; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientFlowQueue*, int, ACBindings.Internal.NetBlob*> Dequeue; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientFlowQueue*, uint, void> IncrementLocalInterval; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientFlowQueue*, int, int> WireRoomLeft; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientFlowQueue*, int, int> FragQueueRoomLeft; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientFlowQueue*, int, void> RecordBytesSent; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientFlowQueue*, int, void> RecordBytesQueued; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientFlowQueue*, int, void> RecordBytesDequeued; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientFlowQueue*, ACBindings.Internal.NetPacket*, ACBindings.Internal.NetPacket**, ACBindings.Internal.NetPacket**, void> EnqueuePacket; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientFlowQueue*, ACBindings.Internal.NetPacket**, ACBindings.Internal.NetPacket**, ACBindings.Internal.NetPacket*> DequeuePacket; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientFlowQueue*, ACBindings.Internal.IntervalData*, int> OnLocalIntervalAck; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.PQueueArray__uint__void_ptr pqueue_;
    public int bytesPrevSent_;

    // Generated Constructor
    public ClientFlowQueue(int addr, ushort recID, float lineNoise) {
        _ConstructorInternal(addr, recID, lineNoise);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x00547CD0
    /// void __thiscall ClientFlowQueue::RecordBytesSent(ClientFlowQueue*,int)</code>
    /// </summary>
    public void RecordBytesSent(int dataAmount) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientFlowQueue, int, void>)0x00547CD0)(ref this, dataAmount);

    /// <summary>
    /// <code>Offset: 0x00548890
    /// void __thiscall ClientFlowQueue::Enqueue(ClientFlowQueue*,NetBlob*)</code>
    /// </summary>
    public void Enqueue(ACBindings.Internal.NetBlob* newBlob) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientFlowQueue, ACBindings.Internal.NetBlob*, void>)0x00548890)(ref this, newBlob);

    /// <summary>
    /// <code>Offset: 0x005488E0
    /// NetBlob* __thiscall ClientFlowQueue::Dequeue(ClientFlowQueue*,int)</code>
    /// </summary>
    public ACBindings.Internal.NetBlob* Dequeue(int formal) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientFlowQueue, int, ACBindings.Internal.NetBlob*>)0x005488E0)(ref this, formal);

    /// <summary>
    /// <code>Offset: 0x00548A80
    /// int __thiscall ClientFlowQueue::OnLocalIntervalAck(ClientFlowQueue*,const IntervalData*)</code>
    /// </summary>
    public int OnLocalIntervalAck(ACBindings.Internal.IntervalData* IntervalBeingAcked) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientFlowQueue, ACBindings.Internal.IntervalData*, int>)0x00548A80)(ref this, IntervalBeingAcked);

    /// <summary>
    /// <code>Offset: 0x00548AD0
    /// void __thiscall ClientFlowQueue::IncrementLocalInterval(ClientFlowQueue*,unsigned int)</code>
    /// </summary>
    public void IncrementLocalInterval(uint cIntervals) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientFlowQueue, uint, void>)0x00548AD0)(ref this, cIntervals);

    /// <summary>
    /// <code>Offset: 0x00549260
    /// void __thiscall ClientFlowQueue::ClientFlowQueue(ClientFlowQueue*,sockaddr_in,unsigned __int16,float)</code>
    /// </summary>
    public void _ConstructorInternal(int addr, ushort recID, float lineNoise) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientFlowQueue, int, ushort, float, void>)0x00549260)(ref this, addr, recID, lineNoise);

    /// <summary>
    /// <code>Offset: 0x00549650
    /// void __thiscall ClientFlowQueue::~ClientFlowQueue(ClientFlowQueue*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientFlowQueue, void>)0x00549650)(ref this);
}

