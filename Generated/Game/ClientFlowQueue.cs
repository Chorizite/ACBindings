namespace ACBindings;

// ClientFlowQueue
public unsafe struct ClientFlowQueue : System.IDisposable
{
    // Base Classes
    public ACBindings.FlowQueue BaseClass_FlowQueue; // ACBindings.FlowQueue

    // Child Types
    // ClientFlowQueue_vtbl
    public unsafe struct ClientFlowQueue_vtbl
    {
        // Members
        public System.IntPtr ClientFlowQueue_dtor_0; // function pointer
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
        public System.IntPtr OnLocalIntervalAck; // function pointer

        // Methods
    }

    // Members
    public ACBindings.PQueueArray__uint__void_ptr pqueue_;
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
    // void __thiscall ClientFlowQueue::RecordBytesSent(ClientFlowQueue*,int)
    public void RecordBytesSent(int dataAmount) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientFlowQueue, int, void>)0x00547CD0)(ref this, dataAmount);
    // void __thiscall ClientFlowQueue::Enqueue(ClientFlowQueue*,NetBlob*)
    public void Enqueue(ACBindings.NetBlob* newBlob) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientFlowQueue, ACBindings.NetBlob*, void>)0x00548890)(ref this, newBlob);
    // NetBlob* __thiscall ClientFlowQueue::Dequeue(ClientFlowQueue*,int)
    public ACBindings.NetBlob* Dequeue(int formal) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientFlowQueue, int, ACBindings.NetBlob*>)0x005488E0)(ref this, formal);
    // int __thiscall ClientFlowQueue::OnLocalIntervalAck(ClientFlowQueue*,const IntervalData*)
    public int OnLocalIntervalAck(ACBindings.IntervalData* IntervalBeingAcked) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientFlowQueue, ACBindings.IntervalData*, int>)0x00548A80)(ref this, IntervalBeingAcked);
    // void __thiscall ClientFlowQueue::IncrementLocalInterval(ClientFlowQueue*,unsigned int)
    public void IncrementLocalInterval(uint cIntervals) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientFlowQueue, uint, void>)0x00548AD0)(ref this, cIntervals);
    // void __thiscall ClientFlowQueue::ClientFlowQueue(ClientFlowQueue*,sockaddr_in,unsigned __int16,float)
    public void _ConstructorInternal(int addr, ushort recID, float lineNoise) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientFlowQueue, int, ushort, float, void>)0x00549260)(ref this, addr, recID, lineNoise);
    // void __thiscall ClientFlowQueue::~ClientFlowQueue(ClientFlowQueue*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientFlowQueue, void>)0x00549650)(ref this);
}

