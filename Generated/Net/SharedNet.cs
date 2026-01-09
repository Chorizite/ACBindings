namespace ACBindings;

// SharedNet
public unsafe struct SharedNet : System.IDisposable
{
    // Statics
    public static ACBindings.SharedNet* s_pNet = (ACBindings.SharedNet*)0x00846F18;

    // Child Types
    // SharedNet_vtbl
    public unsafe struct SharedNet_vtbl
    {
        // Members
        public System.IntPtr AddToPerfCounter; // function pointer
        public System.IntPtr SendBuff; // function pointer
        public System.IntPtr ProcessConnections; // function pointer
        public System.IntPtr ProcessConnection; // function pointer
        public System.IntPtr OnUseTimeTimeout; // function pointer
        public System.IntPtr BeforeCheckingSocket; // function pointer
        public System.IntPtr ReadAndProcessPackets; // function pointer
        public System.IntPtr ReadNextPacket; // function pointer
        public System.IntPtr ProcessPacket; // function pointer
        public System.IntPtr VerifyHeader; // function pointer
        public System.IntPtr SplitPacketData; // function pointer
        public System.IntPtr ProcessNewRemoteInterval; // function pointer
        public System.IntPtr ProcessOptionalHeaders; // function pointer
        public System.IntPtr ProcessOptionalHeader; // function pointer
        public System.IntPtr ProcessBlobFrags; // function pointer
        public System.IntPtr SetConnectionState; // function pointer
        public System.IntPtr HandleTimeSynch; // function pointer
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
    public ACBindings.PortalDH* dh_;
    public ushort netID_;
    public fixed byte receivers_[34816];
    public ACBindings.ReceiverData* connectionsHead_;
    public ACBindings.ReceiverData* connectionsTail_;
    public double lastDidUseTime_;
    public ACBindings.CQuickTimer m_UseTime_TimeLimit;
    public ACBindings._03CB7E004CA5755A24201E14CFC75D1E m_packetStatsIncoming;
    public System.IntPtr m_pBytesSentCounter;
    public System.IntPtr m_pBytesReceivedCounter;
    public System.IntPtr m_pBadPacketsReceivedCounter;
    public System.IntPtr m_pBadPacketsReceivedRawCounter;
    public System.IntPtr m_pPacketsRetransmittedCounter;
    public ACBindings.LoggingFunctions m_Loggers;
    public ACBindings.CNetLayerPacket* m_pIncomingPacket;

    // Generated Constructor
    public SharedNet(ushort netID) {
        _ConstructorInternal(netID);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall SharedNet::ProcessNewestSeqNum(SharedNet*,const CNetLayerPacket*)
    public void ProcessNewestSeqNum(ACBindings.CNetLayerPacket* pkt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SharedNet, ACBindings.CNetLayerPacket*, void>)0x00542510)(ref this, pkt);
    // unsigned int __thiscall SharedNet::ChecksumHeader(SharedNet*,const ProtoHeader*)
    public uint ChecksumHeader(ACBindings.ProtoHeader* Hdr) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SharedNet, ACBindings.ProtoHeader*, uint>)0x00542570)(ref this, Hdr);
    // bool __thiscall SharedNet::ProcessOptionalHeaders(SharedNet*,const CNetLayerPacket*)
    public byte ProcessOptionalHeaders(ACBindings.CNetLayerPacket* pkt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SharedNet, ACBindings.CNetLayerPacket*, byte>)0x005425D0)(ref this, pkt);
    // bool __thiscall SharedNet::ProcessBlobFrags(SharedNet*,const CNetLayerPacket*)
    public byte ProcessBlobFrags(ACBindings.CNetLayerPacket* pkt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SharedNet, ACBindings.CNetLayerPacket*, byte>)0x00542630)(ref this, pkt);
    // int __thiscall SharedNet::SendBuff(SharedNet*,_WSABUF*,int,sockaddr_in)
    public int SendBuff(ACBindings._WSABUF* vecs, int iovNum, int addr_to) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SharedNet, ACBindings._WSABUF*, int, int, int>)0x00542650)(ref this, vecs, iovNum, addr_to);
    // bool __thiscall SharedNet::SendPacket(SharedNet*,NetPacket*,ProtoHeader*,const sockaddr_in*)
    public byte SendPacket(ACBindings.NetPacket* packet, ACBindings.ProtoHeader* pheader, int* addr) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SharedNet, ACBindings.NetPacket*, ACBindings.ProtoHeader*, int*, byte>)0x00542780)(ref this, packet, pheader, addr);
    // void __thiscall SharedNet::SetConnectionState(SharedNet*,unsigned __int16,ConnectionState)
    public void SetConnectionState(ushort idRecip, ACBindings.ConnectionState NewState) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SharedNet, ushort, ACBindings.ConnectionState, void>)0x005428A0)(ref this, idRecip, NewState);
    // bool __thiscall SharedNet::UseTime(SharedNet*)
    public byte UseTime() => ((delegate* unmanaged[Thiscall]<ref ACBindings.SharedNet, byte>)0x00543030)(ref this);
    // bool __thiscall SharedNet::ReadAndProcessPackets(SharedNet*)
    public byte ReadAndProcessPackets() => ((delegate* unmanaged[Thiscall]<ref ACBindings.SharedNet, byte>)0x005430C0)(ref this);
    // int __thiscall SharedNet::ReadNextPacket(SharedNet*,unsigned int,CNetLayerPacket*)
    public int ReadNextPacket(uint S, ACBindings.CNetLayerPacket* pkt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SharedNet, uint, ACBindings.CNetLayerPacket*, int>)0x00543140)(ref this, S, pkt);
    // void __stdcall SharedNet::HandlePak(int,int)
    public static void HandlePak(int a1, int a2) => ((delegate* unmanaged[Stdcall]<int, int, void>)0x00543240)(a1, a2);
    // void __stdcall SharedNet::HandleNak(int,unsigned int*)
    public static void HandleNak(int numNaks, uint* seqIDs) => ((delegate* unmanaged[Stdcall]<int, uint*, void>)0x00543280)(numNaks, seqIDs);
    // bool __thiscall SharedNet::ProcessConnections(SharedNet*)
    public byte ProcessConnections() => ((delegate* unmanaged[Thiscall]<ref ACBindings.SharedNet, byte>)0x005432D0)(ref this);
    // ReceiverState __thiscall SharedNet::SetNakState(SharedNet*,ReceiverData*)
    public ACBindings.ReceiverState SetNakState(ACBindings.ReceiverData* recData) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SharedNet, ACBindings.ReceiverData*, ACBindings.ReceiverState>)0x00543320)(ref this, recData);
    // void __thiscall SharedNet::~SharedNet(SharedNet*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.SharedNet, void>)0x005438A0)(ref this);
    // bool __thiscall SharedNet::SplitPacketData(SharedNet*,CNetLayerPacket*)
    public byte SplitPacketData(ACBindings.CNetLayerPacket* pkt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SharedNet, ACBindings.CNetLayerPacket*, byte>)0x005439F0)(ref this, pkt);
    // bool __thiscall SharedNet::ProcessOptionalHeader(SharedNet*,const COptionalHeader*,const CNetLayerPacket*)
    public byte ProcessOptionalHeader(ACBindings.COptionalHeader* pHdr, ACBindings.CNetLayerPacket* pkt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SharedNet, ACBindings.COptionalHeader*, ACBindings.CNetLayerPacket*, byte>)0x00543C30)(ref this, pHdr, pkt);
    // bool __thiscall SharedNet::SendOptionalHeader(SharedNet*,COptionalHeader*,const sockaddr_in*,const ReceiverData*)
    public byte SendOptionalHeader(ACBindings.COptionalHeader* pHdr, int* addr, ACBindings.ReceiverData* pRecv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SharedNet, ACBindings.COptionalHeader*, int*, ACBindings.ReceiverData*, byte>)0x00543D20)(ref this, pHdr, addr, pRecv);
    // bool __thiscall SharedNet::SeqIDSanityCheck(SharedNet*,const CNetLayerPacket*)
    public byte SeqIDSanityCheck(ACBindings.CNetLayerPacket* pkt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SharedNet, ACBindings.CNetLayerPacket*, byte>)0x005445E0)(ref this, pkt);
    // bool __thiscall SharedNet::ProcessNewRemoteInterval(SharedNet*,const CNetLayerPacket*)
    public byte ProcessNewRemoteInterval(ACBindings.CNetLayerPacket* pkt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SharedNet, ACBindings.CNetLayerPacket*, byte>)0x00544640)(ref this, pkt);
    // void __thiscall SharedNet::EnqueuePak(SharedNet*,ReceiverData*)
    public void EnqueuePak(ACBindings.ReceiverData* recData) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SharedNet, ACBindings.ReceiverData*, void>)0x005446D0)(ref this, recData);
    // void __thiscall SharedNet::EnqueueNaks(SharedNet*,ReceiverData*)
    public void EnqueueNaks(ACBindings.ReceiverData* recData) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SharedNet, ACBindings.ReceiverData*, void>)0x00544790)(ref this, recData);
    // bool __thiscall SharedNet::ProcessNewSeqNum(SharedNet*,CNetLayerPacket*)
    public byte ProcessNewSeqNum(ACBindings.CNetLayerPacket* pkt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SharedNet, ACBindings.CNetLayerPacket*, byte>)0x00545250)(ref this, pkt);
    // bool __thiscall SharedNet::ProcessPacket(SharedNet*,CNetLayerPacket*)
    public byte ProcessPacket(ACBindings.CNetLayerPacket* pkt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SharedNet, ACBindings.CNetLayerPacket*, byte>)0x00545350)(ref this, pkt);
    // __int16 __thiscall SharedNet::HandleEmptyAck(char*,int,int)
    public short HandleEmptyAck(int a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SharedNet, int, int, short>)0x005454B0)(ref this, a2, a3);
    // bool __thiscall SharedNet::ProcessConnection(SharedNet*,ReceiverData*)
    public byte ProcessConnection(ACBindings.ReceiverData* recData) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SharedNet, ACBindings.ReceiverData*, byte>)0x00545510)(ref this, recData);
    // void __thiscall SharedNet::SharedNet(SharedNet*,unsigned __int16)
    public void _ConstructorInternal(ushort netID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SharedNet, ushort, void>)0x00546A40)(ref this, netID);
}

