namespace ACBindings.Internal;


/// <summary>Handles low‑level network communication for a 32‑bit Windows application, maintaining sockets, Diffie–Hellman context, receiver states, and performance counters.</summary>
public unsafe struct SharedNet : System.IDisposable
{
    // Statics
    public static ACBindings.Internal.SharedNet** s_pNet = (ACBindings.Internal.SharedNet**)0x00846F18;

    // Child Types
    public unsafe struct SharedNet_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SharedNet*, ACBindings.Internal.NetPerfCounter, int, void> AddToPerfCounter; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SharedNet*, ACBindings.Internal._WSABUF*, int, int, int> SendBuff; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SharedNet*, byte> ProcessConnections; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SharedNet*, ACBindings.Internal.ReceiverData*, byte> ProcessConnection; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SharedNet*, void> OnUseTimeTimeout; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SharedNet*, void> BeforeCheckingSocket; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SharedNet*, byte> ReadAndProcessPackets; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SharedNet*, uint, ACBindings.Internal.CNetLayerPacket*, int> ReadNextPacket; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SharedNet*, ACBindings.Internal.CNetLayerPacket*, byte> ProcessPacket; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SharedNet*, ACBindings.Internal.CNetLayerPacket*, byte> VerifyHeader; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SharedNet*, ACBindings.Internal.CNetLayerPacket*, byte> SplitPacketData; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SharedNet*, ACBindings.Internal.CNetLayerPacket*, byte> ProcessNewRemoteInterval; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SharedNet*, ACBindings.Internal.CNetLayerPacket*, byte> ProcessOptionalHeaders; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SharedNet*, ACBindings.Internal.COptionalHeader*, ACBindings.Internal.CNetLayerPacket*, byte> ProcessOptionalHeader; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SharedNet*, ACBindings.Internal.CNetLayerPacket*, byte> ProcessBlobFrags; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SharedNet*, ushort, ACBindings.Internal.ConnectionState, void> SetConnectionState; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SharedNet*, ACBindings.Internal.CTimeSyncHeader*, ACBindings.Internal.CNetLayerPacket*, void> HandleTimeSynch; // function pointer
        public System.IntPtr HandleNak;
        public System.IntPtr HandlePak;
        public System.IntPtr HandleEmptyAck;

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public fixed byte gap4[8];
    public uint m_sockRead;
    public uint m_sockWrite;
    public ACBindings.Internal.PortalDH* dh_;
    public ushort netID_;
    public fixed byte receivers_[34816];
    public ACBindings.Internal.ReceiverData* connectionsHead_;
    public ACBindings.Internal.ReceiverData* connectionsTail_;
    public double lastDidUseTime_;
    public ACBindings.Internal.CQuickTimer m_UseTime_TimeLimit;
    public ACBindings.Internal._03CB7E004CA5755A24201E14CFC75D1E m_packetStatsIncoming;
    public System.IntPtr m_pBytesSentCounter;
    public System.IntPtr m_pBytesReceivedCounter;
    public System.IntPtr m_pBadPacketsReceivedCounter;
    public System.IntPtr m_pBadPacketsReceivedRawCounter;
    public System.IntPtr m_pPacketsRetransmittedCounter;
    public ACBindings.Internal.LoggingFunctions m_Loggers;
    public ACBindings.Internal.CNetLayerPacket* m_pIncomingPacket;

    // Generated Constructor
    public SharedNet(ushort netID) {
        _ConstructorInternal(netID);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Processes a packet’s sequence number, updating the receiver’s highest received identifier and generating NACKs for any missing packets between the previous and current IDs.
    /// <code>Offset: 0x00542510
    /// void __thiscall SharedNet::ProcessNewestSeqNum(SharedNet*,const CNetLayerPacket*)</code>
    /// </summary>
    /// <param name="pkt">The network layer packet containing the sequence header and associated receiver information.</param>
    public void ProcessNewestSeqNum(ACBindings.Internal.CNetLayerPacket* pkt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SharedNet, ACBindings.Internal.CNetLayerPacket*, void>)0x00542510)(ref this, pkt);

    /// <summary>Computes a 32‑bit checksum for a ProtoHeader by hashing its sequence ID, header value, record ID, interval, iteration, data length and a constant magic number.
    /// <code>Offset: 0x00542570
    /// unsigned int __thiscall SharedNet::ChecksumHeader(SharedNet*,const ProtoHeader*)</code>
    /// </summary>
    /// <param name="Hdr">The ProtoHeader whose fields contribute to the checksum calculation.</param>
    /// <returns>The resulting 32‑bit checksum as an unsigned integer.</returns>
    public uint ChecksumHeader(ACBindings.Internal.ProtoHeader* Hdr) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SharedNet, ACBindings.Internal.ProtoHeader*, uint>)0x00542570)(ref this, Hdr);

    /// <summary>
    /// Processes each optional header in the supplied packet by invoking ProcessOptionalHeader for every entry in its special fragment list.
    /// 
    /// <code>Offset: 0x005425D0
    /// bool __thiscall SharedNet::ProcessOptionalHeaders(SharedNet*,const CNetLayerPacket*)</code>
    /// </summary>
    /// <param name="pkt">
    /// The network packet whose optional headers should be processed.
    /// </param>
    /// <returns>
    /// True if processing succeeded; always true in this implementation.
    /// </returns>
    public byte ProcessOptionalHeaders(ACBindings.Internal.CNetLayerPacket* pkt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SharedNet, ACBindings.Internal.CNetLayerPacket*, byte>)0x005425D0)(ref this, pkt);

    /// <summary>Notifies recipient data of a received network packet and returns whether the notification succeeded.
    /// <code>Offset: 0x00542630
    /// bool __thiscall SharedNet::ProcessBlobFrags(SharedNet*,const CNetLayerPacket*)</code>
    /// </summary>
    /// <param name="pkt">The network packet containing blob fragments to be processed.</param>
    /// <returns>True if the recipient was notified successfully; otherwise, false.</returns>
    public byte ProcessBlobFrags(ACBindings.Internal.CNetLayerPacket* pkt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SharedNet, ACBindings.Internal.CNetLayerPacket*, byte>)0x00542630)(ref this, pkt);

    /// <summary>Consolidates the supplied WSABUF array into a contiguous block and sends it through the instance’s write socket to the specified address, updating byte‑sent statistics and invoking any configured send logger.
    /// <code>Offset: 0x00542650
    /// int __thiscall SharedNet::SendBuff(SharedNet*,_WSABUF*,int,sockaddr_in)</code>
    /// </summary>
    /// <param name="vecs">Array of _WSABUF structures containing data buffers to transmit.</param>
    /// <param name="iovNum">Number of WSABUF entries in vecs.</param>
    /// <param name="addr_to">Destination address specified as a sockaddr_in structure.</param>
    /// <returns>Number of bytes successfully sent, or 0 if an error occurs during sendto.</returns>
    public int SendBuff(ACBindings.Internal._WSABUF* vecs, int iovNum, int addr_to) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SharedNet, ACBindings.Internal._WSABUF*, int, int, int>)0x00542650)(ref this, vecs, iovNum, addr_to);

    /// <summary>Sends a network packet to the specified address by assembling its fragments and special fragments into a buffer, updating checksum and recording performance metrics.
    /// <code>Offset: 0x00542780
    /// bool __thiscall SharedNet::SendPacket(SharedNet*,NetPacket*,ProtoHeader*,const sockaddr_in*)</code>
    /// </summary>
    /// <param name="packet">The packet containing data and fragment information to be transmitted.</param>
    /// <param name="pheader">Packet header whose checksum is updated before sending.</param>
    /// <param name="addr">Destination socket address for the packet.</param>
    /// <returns>True if all bytes were sent successfully; otherwise false.</returns>
    public byte SendPacket(ACBindings.Internal.NetPacket* packet, ACBindings.Internal.ProtoHeader* pheader, int* addr) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SharedNet, ACBindings.Internal.NetPacket*, ACBindings.Internal.ProtoHeader*, int*, byte>)0x00542780)(ref this, packet, pheader, addr);

    /// <summary>Updates the connection state of a specified receiver and its associated recipient record.
    /// <code>Offset: 0x005428A0
    /// void __thiscall SharedNet::SetConnectionState(SharedNet*,unsigned __int16,ConnectionState)</code>
    /// </summary>
    /// <param name="idRecip">The identifier of the receiver to update (must be less than 0x100).</param>
    /// <param name="NewState">The new connection state to apply.</param>
    public void SetConnectionState(ushort idRecip, ACBindings.Internal.ConnectionState NewState) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SharedNet, ushort, ACBindings.Internal.ConnectionState, void>)0x005428A0)(ref this, idRecip, NewState);

    /// <summary>Performs a network use cycle by resetting packet statistics, starting a timer, checking sockets, reading and processing incoming packets, updating connections, handling timeouts, recording the last usage time, and indicating whether packet processing succeeded.
    /// <code>Offset: 0x00543030
    /// bool __thiscall SharedNet::UseTime(SharedNet*)</code>
    /// </summary>
    /// <returns>True if packet reading and processing succeeded; otherwise false.</returns>
    public byte UseTime() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SharedNet, byte>)0x00543030)(ref this);

    /// <summary>Reads network packets from the socket, processes each valid packet, and stops when no more data is available, an error occurs, or the configured time limit expires.
    /// <code>Offset: 0x005430C0
    /// bool __thiscall SharedNet::ReadAndProcessPackets(SharedNet*)</code>
    /// </summary>
    /// <returns>True if all packets were read without encountering a negative result; false if the incoming packet buffer is null or a read error occurred during processing.</returns>
    public byte ReadAndProcessPackets() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SharedNet, byte>)0x005430C0)(ref this);

    /// <summary>Receives a network packet from the specified socket, updates performance counters, optionally logs receipt details, verifies header checksum, and populates the provided CNetLayerPacket structure when sufficient data is received.
    /// <code>Offset: 0x00543140
    /// int __thiscall SharedNet::ReadNextPacket(SharedNet*,unsigned int,CNetLayerPacket*)</code>
    /// </summary>
    /// <param name="this">The SharedNet instance handling the connection.</param>
    /// <param name="S">Socket descriptor to read from.</param>
    /// <param name="pkt">Pointer to packet buffer that will receive the incoming data and be marked valid when complete.</param>
    /// <returns>Number of bytes received; zero if no data is available (non‑blocking) or negative on error.</returns>
    public int ReadNextPacket(uint S, ACBindings.Internal.CNetLayerPacket* pkt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SharedNet, uint, ACBindings.Internal.CNetLayerPacket*, int>)0x00543140)(ref this, S, pkt);

    /// <summary>Processes a packet by validating its size and the existence of an associated recipient, then triggers a queue flush for that recipient.
    /// <code>Offset: 0x00543240
    /// void __stdcall SharedNet::HandlePak(int,int)</code>
    /// </summary>
    /// <param name="a1">Pointer to packet data or descriptor whose length is examined at offset 24.</param>
    /// <param name="a2">Reference to shared network context containing recipient information and packet statistics.</param>
    public static void HandlePak(int a1, int a2) => ((delegate* unmanaged[Stdcall]<int, int, void>)0x00543240)(a1, a2);

    /// <summary>Handles a negative‑acknowledgment (NAK) packet by extracting the recipient ID, locating the appropriate connection, and forwarding the NAK details for retransmission.
    /// <code>Offset: 0x00543280
    /// void __stdcall SharedNet::HandleNak(int,unsigned int*)</code>
    /// </summary>
    /// <param name="numNaks">Integer containing the address of the NAK packet structure; the function reads the count of NAKs at offset 24 bytes and the sequence identifiers starting at offset 28 bytes.</param>
    /// <param name="seqIDs">Pointer to a packet header from which the recipient ID is obtained at element index 152 (the 153rd 16‑bit value).</param>
    public static void HandleNak(int numNaks, uint* seqIDs) => ((delegate* unmanaged[Stdcall]<int, uint*, void>)0x00543280)(numNaks, seqIDs);

    /// <summary>Processes active receiver connections, invoking ProcessConnection on each while respecting a time‑limit threshold.
    /// <code>Offset: 0x005432D0
    /// bool __thiscall SharedNet::ProcessConnections(SharedNet*)</code>
    /// </summary>
    /// <returns>Always true to indicate the routine completed its processing loop.</returns>
    public byte ProcessConnections() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SharedNet, byte>)0x005432D0)(ref this);

    /// <summary>Updates the receiver's NAK state based on whether any sequence IDs have been marked for retransmission, returning the resulting state.
    /// <code>Offset: 0x00543320
    /// ReceiverState __thiscall SharedNet::SetNakState(SharedNet*,ReceiverData*)</code>
    /// </summary>
    /// <param name="recData">The receiver data whose NAK status is being set.</param>
    /// <returns>The new Nak state: either NAK_STATE if there are pending NAKs or NO_NAK_STATE otherwise.</returns>
    public ACBindings.Internal.ReceiverState SetNakState(ACBindings.Internal.ReceiverData* recData) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SharedNet, ACBindings.Internal.ReceiverData*, ACBindings.Internal.ReceiverState>)0x00543320)(ref this, recData);

    /// <summary>Releases all resources owned by a SharedNet instance—deallocating its Diffie‑Hellman context, decrementing reference counts on packet counters and incoming packets, destroying stored connections, and cleaning up the internal network initializer—without deallocating the instance itself.
    /// <code>Offset: 0x005438A0
    /// void __thiscall SharedNet::~SharedNet(SharedNet*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SharedNet, void>)0x005438A0)(ref this);

    /// <summary>Splits a received network packet into fragments after validating headers, optional sections, and checksum, updating internal statistics, and indicating whether the split succeeded.
    /// <code>Offset: 0x005439F0
    /// bool __thiscall SharedNet::SplitPacketData(SharedNet*,CNetLayerPacket*)</code>
    /// </summary>
    /// <param name="pkt">The packet to be processed and potentially fragmented.</param>
    /// <returns>True if the packet was successfully validated and split; otherwise false.</returns>
    public byte SplitPacketData(ACBindings.Internal.CNetLayerPacket* pkt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SharedNet, ACBindings.Internal.CNetLayerPacket*, byte>)0x005439F0)(ref this, pkt);

    /// <summary>Processes an optional packet header by inspecting its mask value and performing actions such as updating connection state, handling NAKs, ACKs, control packets, time synchronization, or echo responses.
    /// <code>Offset: 0x00543C30
    /// bool __thiscall SharedNet::ProcessOptionalHeader(SharedNet*,const COptionalHeader*,const CNetLayerPacket*)</code>
    /// </summary>
    /// <param name="pHdr">The optional header to process.</param>
    /// <param name="pkt">The network packet containing the header.</param>
    /// <returns>True if the header was handled and an action taken; otherwise false when the mask does not match any known optional type.</returns>
    public byte ProcessOptionalHeader(ACBindings.Internal.COptionalHeader* pHdr, ACBindings.Internal.CNetLayerPacket* pkt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SharedNet, ACBindings.Internal.COptionalHeader*, ACBindings.Internal.CNetLayerPacket*, byte>)0x00543C30)(ref this, pHdr, pkt);

    /// <summary>Sends an optional header packet to a remote endpoint when the supplied header satisfies required flag conditions, returning whether the transmission succeeded.
    /// <code>Offset: 0x00543D20
    /// bool __thiscall SharedNet::SendOptionalHeader(SharedNet*,COptionalHeader*,const sockaddr_in*,const ReceiverData*)</code>
    /// </summary>
    /// <param name="pHdr">Header data to include in the packet.</param>
    /// <param name="addr">Network address of the recipient.</param>
    /// <param name="pRecv">Optional receiver context used for sequence and identification fields; may be null.</param>
    /// <returns>True if the packet was sent successfully, otherwise false.</returns>
    public byte SendOptionalHeader(ACBindings.Internal.COptionalHeader* pHdr, int* addr, ACBindings.Internal.ReceiverData* pRecv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SharedNet, ACBindings.Internal.COptionalHeader*, int*, ACBindings.Internal.ReceiverData*, byte>)0x00543D20)(ref this, pHdr, addr, pRecv);

    /// <summary>Verifies that a packet’s sequence identifier lies within an acceptable window relative to the receiver’s highest known ID and that the receiver’s NAK list remains below its threshold.
    /// <code>Offset: 0x005445E0
    /// bool __thiscall SharedNet::SeqIDSanityCheck(SharedNet*,const CNetLayerPacket*)</code>
    /// </summary>
    /// <param name="pkt">The network packet whose sequence ID is validated.</param>
    /// <returns>True if the packet’s seqID is within ±0x7FFF of the receiver’s highest received ID and the NAK count does not exceed 40000; otherwise, false.</returns>
    public byte SeqIDSanityCheck(ACBindings.Internal.CNetLayerPacket* pkt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SharedNet, ACBindings.Internal.CNetLayerPacket*, byte>)0x005445E0)(ref this, pkt);

    /// <summary>Processes a newly received packet's remote interval information, sending an optional flow‑control header that reports the amount of data received during the previous interval and updating the receiver’s state for the new interval.
    /// <code>Offset: 0x00544640
    /// bool __thiscall SharedNet::ProcessNewRemoteInterval(SharedNet*,const CNetLayerPacket*)</code>
    /// </summary>
    /// <param name="pkt">The packet containing the new remote interval data and associated receiver information.</param>
    /// <returns>True after successfully handling the interval; this function always returns true.</returns>
    public byte ProcessNewRemoteInterval(ACBindings.Internal.CNetLayerPacket* pkt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SharedNet, ACBindings.Internal.CNetLayerPacket*, byte>)0x00544640)(ref this, pkt);

    /// <summary>Adds an optional header containing the highest packet ID received from a particular receiver when its data has not been updated in over two seconds, then enqueues that header for transmission.
    /// <code>Offset: 0x005446D0
    /// void __thiscall SharedNet::EnqueuePak(SharedNet*,ReceiverData*)</code>
    /// </summary>
    /// <param name="recData">Receiver data to be inspected; its timestamp may be refreshed and its highestIDReceived used to create the header.</param>
    public void EnqueuePak(ACBindings.Internal.ReceiverData* recData) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SharedNet, ACBindings.Internal.ReceiverData*, void>)0x005446D0)(ref this, recData);

    /// <summary>Queues a NAK packet for the specified receiver if more than 0.6 seconds have elapsed since its last update, indicating missing packets.
    /// <code>Offset: 0x00544790
    /// void __thiscall SharedNet::EnqueueNaks(SharedNet*,ReceiverData*)</code>
    /// </summary>
    /// <param name="recData">The receiver data whose packet sequence is being monitored.</param>
    public void EnqueueNaks(ACBindings.Internal.ReceiverData* recData) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SharedNet, ACBindings.Internal.ReceiverData*, void>)0x00544790)(ref this, recData);

    /// <summary>Processes a new sequence number for an incoming packet, performing validity checks, handling previously NAKed IDs, updating performance counters, and decrypting the packet if necessary.
    /// <code>Offset: 0x00545250
    /// bool __thiscall SharedNet::ProcessNewSeqNum(SharedNet*,CNetLayerPacket*)</code>
    /// </summary>
    /// <param name="pkt">The network layer packet to process.</param>
    /// <returns>True if the packet was accepted and processed; otherwise false.</returns>
    public byte ProcessNewSeqNum(ACBindings.Internal.CNetLayerPacket* pkt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SharedNet, ACBindings.Internal.CNetLayerPacket*, byte>)0x00545250)(ref this, pkt);

    /// <summary>Processes an incoming network packet by validating its header, handling sequencing, interval updates, fragmentation, and statistics. Returns true when the packet is fully processed; otherwise false.
    /// <code>Offset: 0x00545350
    /// bool __thiscall SharedNet::ProcessPacket(SharedNet*,CNetLayerPacket*)</code>
    /// </summary>
    /// <param name="pkt">The received CNetLayerPacket to process.</param>
    /// <returns>True if the packet was successfully handled; otherwise false.</returns>
    public byte ProcessPacket(ACBindings.Internal.CNetLayerPacket* pkt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SharedNet, ACBindings.Internal.CNetLayerPacket*, byte>)0x00545350)(ref this, pkt);

    /// <summary>Removes retransmission identifiers listed in an empty acknowledgment from a receiver’s pending set and returns that receiver’s identifier.
    /// <code>Offset: 0x005454B0
    /// __int16 __thiscall SharedNet::HandleEmptyAck(char*,int,int)</code>
    /// </summary>
    /// <param name="a2">Pointer to the acknowledgement packet structure, whose count at offset 24 specifies how many identifiers follow at offset 28.</param>
    /// <param name="a3">Pointer to the received packet; the receiver ID is read from its 304‑byte offset.</param>
    /// <returns>16‑bit identifier of the receiver processed in the acknowledgment packet.</returns>
    public short HandleEmptyAck(int a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SharedNet, int, int, short>)0x005454B0)(ref this, a2, a3);

    /// <summary>Processes a receiver's connection state by enqueuing either NAK messages or data packets depending on whether pending negative acknowledgments exist.
    /// <code>Offset: 0x00545510
    /// bool __thiscall SharedNet::ProcessConnection(SharedNet*,ReceiverData*)</code>
    /// </summary>
    /// <param name="recData">The receiver data structure containing connection and packet information.</param>
    /// <returns>True, indicating the operation completed successfully.</returns>
    public byte ProcessConnection(ACBindings.Internal.ReceiverData* recData) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SharedNet, ACBindings.Internal.ReceiverData*, byte>)0x00545510)(ref this, recData);

    /// <summary>Initializes a shared network object with the specified network identifier, setting up socket handles, Diffie‑Hellman parameters, performance counters, and internal structures for packet handling.
    /// <code>Offset: 0x00546A40
    /// void __thiscall SharedNet::SharedNet(SharedNet*,unsigned __int16)</code>
    /// </summary>
    /// <param name="netID">The unique identifier for this network instance.</param>
    public void _ConstructorInternal(ushort netID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SharedNet, ushort, void>)0x00546A40)(ref this, netID);
}

