namespace ACBindings.Internal;


/// <summary>
/// Handles per‑destination packet queuing, acknowledgment management, and transmission scheduling for network traffic, coordinating data fragmentation, optional headers, encryption, and performance statistics before dispatching to the lower‑level socket.
/// </summary>
/// <remarks>
/// Maintains a queue of waiting packets, lists of pending acknowledgments, buffers for empty ACKs, and special header fragments. It tracks sequence numbers, intervals, and statistics such as sent and acknowledged packet counts, while interfacing with ReceiverData for encryption and PacketController for network transmission.
/// </remarks>
public unsafe struct FlowQueue : System.IDisposable
{
    // Statics
    public static ACBindings.Internal.PerfMonCounter__ulong** m_pBlobsDequeuedCounter = (ACBindings.Internal.PerfMonCounter__ulong**)0x00846F64;

    // Child Types
    public unsafe struct FlowQueue_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.FlowQueue*, void> FlowQueue_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.FlowQueue*, ACBindings.Internal.NetBlob*, void> Enqueue; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.FlowQueue*, int, ACBindings.Internal.NetBlob*> Dequeue; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.FlowQueue*, uint, void> IncrementLocalInterval; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.FlowQueue*, int, int> WireRoomLeft; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.FlowQueue*, int, int> FragQueueRoomLeft; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.FlowQueue*, int, void> RecordBytesSent; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.FlowQueue*, int, void> RecordBytesQueued; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.FlowQueue*, int, void> RecordBytesDequeued; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.FlowQueue*, ACBindings.Internal.NetPacket*, ACBindings.Internal.NetPacket**, ACBindings.Internal.NetPacket**, void> EnqueuePacket; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.FlowQueue*, ACBindings.Internal.NetPacket**, ACBindings.Internal.NetPacket**, ACBindings.Internal.NetPacket*> DequeuePacket; // function pointer

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
    /// Dequeues the first packet from the queue referenced by head, updates the head (and tail if necessary), records bytes dequeued, and returns the removed packet or nullptr when the queue is empty.
    /// 
    /// <code>Offset: 0x00547C30
    /// NetPacket* __thiscall FlowQueue::DequeuePacket(FlowQueue*,NetPacket**,NetPacket**)</code>
    /// </summary>
    /// <param name="head">Reference to pointer of the first packet in the queue.</param>
    /// <param name="tail">Reference to pointer of the last packet in the queue; may be updated if the dequeued packet was the only one.</param>
    /// <returns>Pointer to the removed NetPacket, or nullptr if the queue is empty.</returns>
    public ACBindings.Internal.NetPacket* DequeuePacket(ACBindings.Internal.NetPacket** head, ACBindings.Internal.NetPacket** tail) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FlowQueue, ACBindings.Internal.NetPacket**, ACBindings.Internal.NetPacket**, ACBindings.Internal.NetPacket*>)0x00547C30)(ref this, head, tail);

    /// <summary>Encrypts the checksum of a NetPacket and updates its flag and crypto key using ReceiverData's encryption routine.
    /// <code>Offset: 0x00547C70
    /// void __thiscall FlowQueue::EncryptChecksum(FlowQueue*,NetPacket*,unsigned int,unsigned int*)</code>
    /// </summary>
    /// <param name="packet">The packet whose checksum will be encrypted.</param>
    /// <param name="seqnum">Sequence number used in the encryption process.</param>
    /// <param name="pKey">Pointer to store or provide the encryption key for this operation.</param>
    public void EncryptChecksum(ACBindings.Internal.NetPacket* packet, uint seqnum, uint* pKey) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FlowQueue, ACBindings.Internal.NetPacket*, uint, uint*, void>)0x00547C70)(ref this, packet, seqnum, pKey);

    /// <summary>Advances the local interval identifier by a specified number of intervals.
    /// <code>Offset: 0x00547CC0
    /// void __thiscall FlowQueue::IncrementLocalInterval(FlowQueue*,unsigned int)</code>
    /// </summary>
    /// <param name="cIntervals">The number of intervals to increment.</param>
    public void IncrementLocalInterval(uint cIntervals) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FlowQueue, uint, void>)0x00547CC0)(ref this, cIntervals);

    /// <summary>Decrements a shared counter that tracks dequeued blobs. If this was the last reference, calls the registered cleanup callback and clears the static pointer.
    /// <code>Offset: 0x00547E70
    /// void __cdecl FlowQueue::SharedStaticCleanup()</code>
    /// </summary>
    public static void SharedStaticCleanup() => ((delegate* unmanaged[Cdecl]<void>)0x00547E70)();

    /// <summary>Dequeues the next acknowledgment from the flow queue and generates a NetPacket ready for transmission.
    /// <code>Offset: 0x00547EB0
    /// NetPacket* __thiscall FlowQueue::DequeueAck(FlowQueue*)</code>
    /// </summary>
    /// <returns>A pointer to an initialized NetPacket containing the acknowledgment data, or null if no acknowledgment is pending or there isn’t enough space in the send buffer.</returns>
    public ACBindings.Internal.NetPacket* DequeueAck() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FlowQueue, ACBindings.Internal.NetPacket*>)0x00547EB0)(ref this);

    /// <summary>Enqueues a network packet into the flow queue, inserting special‑fragment packets at the head and ordinary packets at the tail while incrementing the packet’s reference count and updating queued byte statistics.
    /// <code>Offset: 0x00547F70
    /// void __thiscall FlowQueue::EnqueuePacket(FlowQueue*,NetPacket*,NetPacket**,NetPacket**)</code>
    /// </summary>
    /// <param name="packet">The packet to enqueue; its reference count is increased before it is linked into the list.</param>
    /// <param name="head">Pointer to the head of the packet list used for inserting special‑fragment packets.</param>
    /// <param name="tail">Pointer to the tail of the packet list used for inserting ordinary packets.</param>
    public void EnqueuePacket(ACBindings.Internal.NetPacket* packet, ACBindings.Internal.NetPacket** head, ACBindings.Internal.NetPacket** tail) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FlowQueue, ACBindings.Internal.NetPacket*, ACBindings.Internal.NetPacket**, ACBindings.Internal.NetPacket**, void>)0x00547F70)(ref this, packet, head, tail);

    /// <summary>Enqueues an optional header fragment into the flow queue by incrementing its reference count, inserting it into the special packet queue, and notifying the packet controller of the associated recipient data.
    /// <code>Offset: 0x00548230
    /// void __thiscall FlowQueue::EnqueueOptionalHeader(FlowQueue*,COptionalHeader*)</code>
    /// </summary>
    /// <param name="newFrag">The optional header fragment to enqueue; may have flags that trigger a connection touch.</param>
    public void EnqueueOptionalHeader(ACBindings.Internal.COptionalHeader* newFrag) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FlowQueue, ACBindings.Internal.COptionalHeader*, void>)0x00548230)(ref this, newFrag);

    /// <summary>Removes acknowledged packet entries up to a specified identifier and discards stored sent packets accordingly. When <paramref name="fEverything"/> is true, all pending data is purged regardless of id.
    /// <code>Offset: 0x00548280
    /// void __thiscall FlowQueue::FlushSentPackets(FlowQueue*,unsigned int,int)</code>
    /// </summary>
    /// <param name="id">Packet ID threshold for selective flushing.</param>
    /// <param name="fEverything">Flag indicating whether to flush all queued packets or only those older than the given ID.</param>
    public void FlushSentPackets(uint id, int fEverything) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FlowQueue, uint, int, void>)0x00548280)(ref this, id, fEverything);

    /// <summary>Combines queued data blobs and optional headers into network packets, respecting size limits and special fragment flags, then enqueues the resulting packets for transmission. Handles reference counting and cleans up processed fragments.
    /// <code>Offset: 0x00548300
    /// void __thiscall FlowQueue::CoalesceData(FlowQueue*)</code>
    /// </summary>
    public void CoalesceData() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FlowQueue, void>)0x00548300)(ref this);

    /// <summary>Transmits all queued network packets that can be sent immediately, handling packet headers, optional encryption, checksum calculation, and updating send statistics.
    /// <code>Offset: 0x00548620
    /// bool __thiscall FlowQueue::TransmitNewPackets(FlowQueue*)</code>
    /// </summary>
    /// <returns>True if at least one packet was successfully transmitted; otherwise false.</returns>
    public byte TransmitNewPackets() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FlowQueue, byte>)0x00548620)(ref this);

    /// <summary>Initializes a FlowQueue instance, setting up packet tracking structures and recording the destination address and recipient identifier.
    /// <code>Offset: 0x00548D40
    /// void __thiscall FlowQueue::FlowQueue(FlowQueue*,sockaddr_in,unsigned __int16,float)</code>
    /// </summary>
    /// <param name="addr">The socket address of the recipient to which packets will be sent.</param>
    /// <param name="recID">Network identifier for the recipient; must be less than 256.</param>
    /// <param name="lineNoise">Ignored during construction (reserved for future use).</param>
    public void _ConstructorInternal(int addr, ushort recID, float lineNoise) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FlowQueue, int, ushort, float, void>)0x00548D40)(ref this, addr, recID, lineNoise);

    /// <summary>Destroys a FlowQueue instance, deallocating its packet queue buffers, clearing packet lists, and releasing all associated hash table resources.
    /// <code>Offset: 0x00548E60
    /// void __thiscall FlowQueue::~FlowQueue(FlowQueue*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FlowQueue, void>)0x00548E60)(ref this);

    /// <summary>Adds a new empty acknowledgement entry for the specified packet ID if it has not already been recorded.
    /// <code>Offset: 0x00548EE0
    /// void __thiscall FlowQueue::EnqueueEmptyAck(FlowQueue*,unsigned int)</code>
    /// </summary>
    /// <param name="id">The identifier of the packet to acknowledge as empty.</param>
    public void EnqueueEmptyAck(uint id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FlowQueue, uint, void>)0x00548EE0)(ref this, id);

    /// <summary>Retrieves and removes the next empty acknowledgment ID from the queue, storing it in the provided location.
    /// <code>Offset: 0x00548FA0
    /// int __thiscall FlowQueue::DequeueEmptyAck(FlowQueue*,unsigned int*)</code>
    /// </summary>
    /// <param name="seqID">Pointer to receive the dequeued acknowledgment identifier; set to 0 if none available.</param>
    /// <returns>Non-zero value if an ID was successfully retrieved; zero otherwise.</returns>
    public int DequeueEmptyAck(uint* seqID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FlowQueue, uint*, int>)0x00548FA0)(ref this, seqID);

    /// <summary>Compiles up to 114 pending empty acknowledgments into the internal array for transmission, resetting the list if no entries remain or if it has already been populated.
    /// <code>Offset: 0x00549020
    /// void __thiscall FlowQueue::CompileEmptyAcks(FlowQueue*)</code>
    /// </summary>
    public void CompileEmptyAcks() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FlowQueue, void>)0x00549020)(ref this);

    /// <summary>Transmits negative acknowledgments by compiling pending empty ACKs into an optional header and queuing it for transmission. Returns true when the header is queued, or false if no data was available to send.
    /// <code>Offset: 0x005490A0
    /// bool __thiscall FlowQueue::TransmitNaks(FlowQueue*)</code>
    /// </summary>
    /// <returns>true if a NAK packet was successfully enqueued; otherwise false.</returns>
    public byte TransmitNaks() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FlowQueue, byte>)0x005490A0)(ref this);

    /// <summary>Sends all queued acknowledgment packets for this flow queue and updates transmission statistics.
    /// <code>Offset: 0x00549110
    /// bool __thiscall FlowQueue::TransmitAcks(FlowQueue*)</code>
    /// </summary>
    /// <returns>True if at least one acknowledgment packet was successfully transmitted; otherwise, false.</returns>
    public byte TransmitAcks() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FlowQueue, byte>)0x00549110)(ref this);

    /// <summary>Destroys the flow queue by draining all waiting packets, clearing acknowledgement lists, and releasing any allocated resources. Reference counts for each packet are decremented, triggering cleanup when they reach zero.
    /// <code>Offset: 0x00549340
    /// void __thiscall FlowQueue::Destroy(FlowQueue*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FlowQueue, void>)0x00549340)(ref this);

    /// <summary>Inserts a set of packet identifiers into the queue’s acknowledgment list, adding them in order if they correspond to packets previously sent or queuing an empty acknowledgement for unknown packets.
    /// <code>Offset: 0x00549440
    /// void __thiscall FlowQueue::EnqueueAcks(FlowQueue*,const unsigned int*,int)</code>
    /// </summary>
    /// <param name="id">Array of packet identifiers to enqueue.</param>
    /// <param name="nIDs">Number of identifiers in the array.</param>
    public void EnqueueAcks(uint* id, int nIDs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FlowQueue, uint*, int, void>)0x00549440)(ref this, id, nIDs);

    /// <summary>Processes outgoing packets for the flow queue, sending ACKs, NAKs, and new data; handles disconnect cleanup by enqueuing an error header when appropriate; then advances the local interval timer, calling IncrementLocalInterval as needed.
    /// <code>Offset: 0x00549580
    /// void __thiscall FlowQueue::Empty(FlowQueue*)</code>
    /// </summary>
    public void Empty() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FlowQueue, void>)0x00549580)(ref this);

    /// <summary>Initializes the global performance counter tracking NetBlob dequeues per second for all FlowQueues.
    /// <code>Offset: 0x005496D0
    /// void __cdecl FlowQueue::SharedStaticInit()</code>
    /// </summary>
    public static void SharedStaticInit() => ((delegate* unmanaged[Cdecl]<void>)0x005496D0)();
}

