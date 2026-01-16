namespace ACBindings.Internal;


/// <summary>Manages outgoing packet flow for a client connection, extending the base FlowQueue with a priority‑based blob queue and byte‑count tracking.</summary>
public unsafe struct ClientFlowQueue : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.FlowQueue BaseClass_FlowQueue; // ACBindings.Internal.FlowQueue

    // Child Types
    public unsafe struct ClientFlowQueue_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientFlowQueue*, void> ClientFlowQueue_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientFlowQueue*, ACBindings.Internal.NetBlob*, void> Enqueue; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientFlowQueue*, int, ACBindings.Internal.NetBlob*> Dequeue; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientFlowQueue*, uint, void> IncrementLocalInterval; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientFlowQueue*, int, int> WireRoomLeft; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientFlowQueue*, int, int> FragQueueRoomLeft; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientFlowQueue*, int, void> RecordBytesSent; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientFlowQueue*, int, void> RecordBytesQueued; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientFlowQueue*, int, void> RecordBytesDequeued; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientFlowQueue*, ACBindings.Internal.NetPacket*, ACBindings.Internal.NetPacket**, ACBindings.Internal.NetPacket**, void> EnqueuePacket; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientFlowQueue*, ACBindings.Internal.NetPacket**, ACBindings.Internal.NetPacket**, ACBindings.Internal.NetPacket*> DequeuePacket; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientFlowQueue*, ACBindings.Internal.IntervalData*, int> OnLocalIntervalAck; // function pointer

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

    /// <summary>Records the number of bytes sent in the current local interval by incrementing the interval's byte counter.
    /// <code>Offset: 0x00547CD0
    /// void __thiscall ClientFlowQueue::RecordBytesSent(ClientFlowQueue*,int)</code>
    /// </summary>
    /// <param name="dataAmount">The amount, in bytes, that has just been transmitted.</param>
    public void RecordBytesSent(int dataAmount) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientFlowQueue, int, void>)0x00547CD0)(ref this, dataAmount);

    /// <summary>Enqueues a NetBlob into the client's flow queue, inserting it based on priority and notifying the PacketController when the recipient is connected.
    /// <code>Offset: 0x00548890
    /// void __thiscall ClientFlowQueue::Enqueue(ClientFlowQueue*,NetBlob*)</code>
    /// </summary>
    /// <param name="newBlob">The NetBlob to be added to the queue.</param>
    public void Enqueue(ACBindings.Internal.NetBlob* newBlob) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientFlowQueue, ACBindings.Internal.NetBlob*, void>)0x00548890)(ref this, newBlob);

    /// <summary>Dequeues a net blob from the client’s flow queue, returning it or nullptr if the queue is empty.
    /// <code>Offset: 0x005488E0
    /// NetBlob* __thiscall ClientFlowQueue::Dequeue(ClientFlowQueue*,int)</code>
    /// </summary>
    /// <returns>A pointer to the removed NetBlob instance, or nullptr when no elements remain.</returns>
    public ACBindings.Internal.NetBlob* Dequeue(int formal) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientFlowQueue, int, ACBindings.Internal.NetBlob*>)0x005488E0)(ref this, formal);

    /// <summary>Updates the flow queue's last acknowledged interval when a newer interval is received, handling wrap‑around; returns 1 on successful update, otherwise 0.
    /// <code>Offset: 0x00548A80
    /// int __thiscall ClientFlowQueue::OnLocalIntervalAck(ClientFlowQueue*,const IntervalData*)</code>
    /// </summary>
    /// <param name="IntervalBeingAcked">The interval data that is being acknowledged.</param>
    /// <returns>1 if the internal last-acknowledged interval was advanced; 0 if no change occurred.</returns>
    public int OnLocalIntervalAck(ACBindings.Internal.IntervalData* IntervalBeingAcked) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientFlowQueue, ACBindings.Internal.IntervalData*, int>)0x00548A80)(ref this, IntervalBeingAcked);

    /// <summary>Advances the queue’s current local interval by a specified amount and, when crossing defined boundaries, enqueues synchronization or echo‑request headers to maintain timely network communication.
    /// <code>Offset: 0x00548AD0
    /// void __thiscall ClientFlowQueue::IncrementLocalInterval(ClientFlowQueue*,unsigned int)</code>
    /// </summary>
    /// <param name="cIntervals">The number of interval steps by which to increase the local interval counter.</param>
    public void IncrementLocalInterval(uint cIntervals) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientFlowQueue, uint, void>)0x00548AD0)(ref this, cIntervals);

    /// <summary>Creates a client‑side flow queue, setting up network parameters and an empty packet priority queue.
    /// <code>Offset: 0x00549260
    /// void __thiscall ClientFlowQueue::ClientFlowQueue(ClientFlowQueue*,sockaddr_in,unsigned __int16,float)</code>
    /// </summary>
    /// <p>Initializes the base FlowQueue with the supplied address, recipient ID, and line‑noise value. Configures the internal priority queue for outgoing packets, assigns the netID based on the shared network table, and resets the current local interval counters.</p>
    /// <param name="addr">The socket address of the remote endpoint to which packets will be sent.</param>
    /// <param name="recID">Identifier used to locate the recipient’s network data; determines the queue’s netID field.</param>
    /// <param name="lineNoise">Estimated noise level on the line, passed to the base FlowQueue constructor for packet timing adjustments.</param>
    public void _ConstructorInternal(int addr, ushort recID, float lineNoise) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientFlowQueue, int, ushort, float, void>)0x00549260)(ref this, addr, recID, lineNoise);

    /// <summary>Releases resources associated with a ClientFlowQueue instance, deallocating its internal priority queue and invoking the base FlowQueue destructor to clean up network packet tracking structures.
    /// <code>Offset: 0x00549650
    /// void __thiscall ClientFlowQueue::~ClientFlowQueue(ClientFlowQueue*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientFlowQueue, void>)0x00549650)(ref this);
}

