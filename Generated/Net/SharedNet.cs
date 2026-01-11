namespace ACBindings.Internal;

public unsafe struct SharedNet : System.IDisposable
{
    // Child Types
    public unsafe struct SharedNet_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SharedNet*, ACBindings.Internal.NetPerfCounter, int, void> AddToPerfCounter; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SharedNet*, ACBindings.Internal._WSABUF*, int, int, int> SendBuff; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SharedNet*, byte> ProcessConnections; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SharedNet*, ACBindings.Internal.ReceiverData*, byte> ProcessConnection; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SharedNet*, void> OnUseTimeTimeout; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SharedNet*, void> BeforeCheckingSocket; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SharedNet*, byte> ReadAndProcessPackets; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SharedNet*, uint, ACBindings.Internal.CNetLayerPacket*, int> ReadNextPacket; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SharedNet*, ACBindings.Internal.CNetLayerPacket*, byte> ProcessPacket; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SharedNet*, ACBindings.Internal.CNetLayerPacket*, byte> VerifyHeader; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SharedNet*, ACBindings.Internal.CNetLayerPacket*, byte> SplitPacketData; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SharedNet*, ACBindings.Internal.CNetLayerPacket*, byte> ProcessNewRemoteInterval; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SharedNet*, ACBindings.Internal.CNetLayerPacket*, byte> ProcessOptionalHeaders; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SharedNet*, ACBindings.Internal.COptionalHeader*, ACBindings.Internal.CNetLayerPacket*, byte> ProcessOptionalHeader; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SharedNet*, ACBindings.Internal.CNetLayerPacket*, byte> ProcessBlobFrags; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SharedNet*, ushort, ACBindings.Internal.ConnectionState, void> SetConnectionState; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SharedNet*, ACBindings.Internal.CTimeSyncHeader*, ACBindings.Internal.CNetLayerPacket*, void> HandleTimeSynch; // function pointer
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

    /// <summary>
    /// <code>Offset: 0x00542510
    /// void __thiscall SharedNet::ProcessNewestSeqNum(SharedNet*,const CNetLayerPacket*)</code>
    /// </summary>
    public void ProcessNewestSeqNum(ACBindings.Internal.CNetLayerPacket* pkt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SharedNet, ACBindings.Internal.CNetLayerPacket*, void>)0x00542510)(ref this, pkt);

    /// <summary>
    /// <code>Offset: 0x00542570
    /// unsigned int __thiscall SharedNet::ChecksumHeader(SharedNet*,const ProtoHeader*)</code>
    /// </summary>
    public uint ChecksumHeader(ACBindings.Internal.ProtoHeader* Hdr) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SharedNet, ACBindings.Internal.ProtoHeader*, uint>)0x00542570)(ref this, Hdr);

    /// <summary>
    /// <code>Offset: 0x005425D0
    /// bool __thiscall SharedNet::ProcessOptionalHeaders(SharedNet*,const CNetLayerPacket*)</code>
    /// </summary>
    public byte ProcessOptionalHeaders(ACBindings.Internal.CNetLayerPacket* pkt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SharedNet, ACBindings.Internal.CNetLayerPacket*, byte>)0x005425D0)(ref this, pkt);

    /// <summary>
    /// <code>Offset: 0x00542630
    /// bool __thiscall SharedNet::ProcessBlobFrags(SharedNet*,const CNetLayerPacket*)</code>
    /// </summary>
    public byte ProcessBlobFrags(ACBindings.Internal.CNetLayerPacket* pkt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SharedNet, ACBindings.Internal.CNetLayerPacket*, byte>)0x00542630)(ref this, pkt);

    /// <summary>
    /// <code>Offset: 0x00542650
    /// int __thiscall SharedNet::SendBuff(SharedNet*,_WSABUF*,int,sockaddr_in)</code>
    /// </summary>
    public int SendBuff(ACBindings.Internal._WSABUF* vecs, int iovNum, int addr_to) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SharedNet, ACBindings.Internal._WSABUF*, int, int, int>)0x00542650)(ref this, vecs, iovNum, addr_to);

    /// <summary>
    /// <code>Offset: 0x00542780
    /// bool __thiscall SharedNet::SendPacket(SharedNet*,NetPacket*,ProtoHeader*,const sockaddr_in*)</code>
    /// </summary>
    public byte SendPacket(ACBindings.Internal.NetPacket* packet, ACBindings.Internal.ProtoHeader* pheader, int* addr) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SharedNet, ACBindings.Internal.NetPacket*, ACBindings.Internal.ProtoHeader*, int*, byte>)0x00542780)(ref this, packet, pheader, addr);

    /// <summary>
    /// <code>Offset: 0x005428A0
    /// void __thiscall SharedNet::SetConnectionState(SharedNet*,unsigned __int16,ConnectionState)</code>
    /// </summary>
    public void SetConnectionState(ushort idRecip, ACBindings.Internal.ConnectionState NewState) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SharedNet, ushort, ACBindings.Internal.ConnectionState, void>)0x005428A0)(ref this, idRecip, NewState);

    /// <summary>
    /// <code>Offset: 0x00543030
    /// bool __thiscall SharedNet::UseTime(SharedNet*)</code>
    /// </summary>
    public byte UseTime() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SharedNet, byte>)0x00543030)(ref this);

    /// <summary>
    /// <code>Offset: 0x005430C0
    /// bool __thiscall SharedNet::ReadAndProcessPackets(SharedNet*)</code>
    /// </summary>
    public byte ReadAndProcessPackets() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SharedNet, byte>)0x005430C0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00543140
    /// int __thiscall SharedNet::ReadNextPacket(SharedNet*,unsigned int,CNetLayerPacket*)</code>
    /// </summary>
    public int ReadNextPacket(uint S, ACBindings.Internal.CNetLayerPacket* pkt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SharedNet, uint, ACBindings.Internal.CNetLayerPacket*, int>)0x00543140)(ref this, S, pkt);

    /// <summary>
    /// <code>Offset: 0x00543240
    /// void __stdcall SharedNet::HandlePak(int,int)</code>
    /// </summary>
    public static void HandlePak(int a1, int a2) => ((delegate* unmanaged[Stdcall]<int, int, void>)0x00543240)(a1, a2);

    /// <summary>
    /// <code>Offset: 0x00543280
    /// void __stdcall SharedNet::HandleNak(int,unsigned int*)</code>
    /// </summary>
    public static void HandleNak(int numNaks, uint* seqIDs) => ((delegate* unmanaged[Stdcall]<int, uint*, void>)0x00543280)(numNaks, seqIDs);

    /// <summary>
    /// <code>Offset: 0x005432D0
    /// bool __thiscall SharedNet::ProcessConnections(SharedNet*)</code>
    /// </summary>
    public byte ProcessConnections() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SharedNet, byte>)0x005432D0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00543320
    /// ReceiverState __thiscall SharedNet::SetNakState(SharedNet*,ReceiverData*)</code>
    /// </summary>
    public ACBindings.Internal.ReceiverState SetNakState(ACBindings.Internal.ReceiverData* recData) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SharedNet, ACBindings.Internal.ReceiverData*, ACBindings.Internal.ReceiverState>)0x00543320)(ref this, recData);

    /// <summary>
    /// <code>Offset: 0x005438A0
    /// void __thiscall SharedNet::~SharedNet(SharedNet*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SharedNet, void>)0x005438A0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005439F0
    /// bool __thiscall SharedNet::SplitPacketData(SharedNet*,CNetLayerPacket*)</code>
    /// </summary>
    public byte SplitPacketData(ACBindings.Internal.CNetLayerPacket* pkt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SharedNet, ACBindings.Internal.CNetLayerPacket*, byte>)0x005439F0)(ref this, pkt);

    /// <summary>
    /// <code>Offset: 0x00543C30
    /// bool __thiscall SharedNet::ProcessOptionalHeader(SharedNet*,const COptionalHeader*,const CNetLayerPacket*)</code>
    /// </summary>
    public byte ProcessOptionalHeader(ACBindings.Internal.COptionalHeader* pHdr, ACBindings.Internal.CNetLayerPacket* pkt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SharedNet, ACBindings.Internal.COptionalHeader*, ACBindings.Internal.CNetLayerPacket*, byte>)0x00543C30)(ref this, pHdr, pkt);

    /// <summary>
    /// <code>Offset: 0x00543D20
    /// bool __thiscall SharedNet::SendOptionalHeader(SharedNet*,COptionalHeader*,const sockaddr_in*,const ReceiverData*)</code>
    /// </summary>
    public byte SendOptionalHeader(ACBindings.Internal.COptionalHeader* pHdr, int* addr, ACBindings.Internal.ReceiverData* pRecv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SharedNet, ACBindings.Internal.COptionalHeader*, int*, ACBindings.Internal.ReceiverData*, byte>)0x00543D20)(ref this, pHdr, addr, pRecv);

    /// <summary>
    /// <code>Offset: 0x005445E0
    /// bool __thiscall SharedNet::SeqIDSanityCheck(SharedNet*,const CNetLayerPacket*)</code>
    /// </summary>
    public byte SeqIDSanityCheck(ACBindings.Internal.CNetLayerPacket* pkt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SharedNet, ACBindings.Internal.CNetLayerPacket*, byte>)0x005445E0)(ref this, pkt);

    /// <summary>
    /// <code>Offset: 0x00544640
    /// bool __thiscall SharedNet::ProcessNewRemoteInterval(SharedNet*,const CNetLayerPacket*)</code>
    /// </summary>
    public byte ProcessNewRemoteInterval(ACBindings.Internal.CNetLayerPacket* pkt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SharedNet, ACBindings.Internal.CNetLayerPacket*, byte>)0x00544640)(ref this, pkt);

    /// <summary>
    /// <code>Offset: 0x005446D0
    /// void __thiscall SharedNet::EnqueuePak(SharedNet*,ReceiverData*)</code>
    /// </summary>
    public void EnqueuePak(ACBindings.Internal.ReceiverData* recData) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SharedNet, ACBindings.Internal.ReceiverData*, void>)0x005446D0)(ref this, recData);

    /// <summary>
    /// <code>Offset: 0x00544790
    /// void __thiscall SharedNet::EnqueueNaks(SharedNet*,ReceiverData*)</code>
    /// </summary>
    public void EnqueueNaks(ACBindings.Internal.ReceiverData* recData) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SharedNet, ACBindings.Internal.ReceiverData*, void>)0x00544790)(ref this, recData);

    /// <summary>
    /// <code>Offset: 0x00545250
    /// bool __thiscall SharedNet::ProcessNewSeqNum(SharedNet*,CNetLayerPacket*)</code>
    /// </summary>
    public byte ProcessNewSeqNum(ACBindings.Internal.CNetLayerPacket* pkt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SharedNet, ACBindings.Internal.CNetLayerPacket*, byte>)0x00545250)(ref this, pkt);

    /// <summary>
    /// <code>Offset: 0x00545350
    /// bool __thiscall SharedNet::ProcessPacket(SharedNet*,CNetLayerPacket*)</code>
    /// </summary>
    public byte ProcessPacket(ACBindings.Internal.CNetLayerPacket* pkt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SharedNet, ACBindings.Internal.CNetLayerPacket*, byte>)0x00545350)(ref this, pkt);

    /// <summary>
    /// <code>Offset: 0x005454B0
    /// __int16 __thiscall SharedNet::HandleEmptyAck(char*,int,int)</code>
    /// </summary>
    public short HandleEmptyAck(int a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SharedNet, int, int, short>)0x005454B0)(ref this, a2, a3);

    /// <summary>
    /// <code>Offset: 0x00545510
    /// bool __thiscall SharedNet::ProcessConnection(SharedNet*,ReceiverData*)</code>
    /// </summary>
    public byte ProcessConnection(ACBindings.Internal.ReceiverData* recData) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SharedNet, ACBindings.Internal.ReceiverData*, byte>)0x00545510)(ref this, recData);

    /// <summary>
    /// <code>Offset: 0x00546A40
    /// void __thiscall SharedNet::SharedNet(SharedNet*,unsigned __int16)</code>
    /// </summary>
    public void _ConstructorInternal(ushort netID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SharedNet, ushort, void>)0x00546A40)(ref this, netID);
}

