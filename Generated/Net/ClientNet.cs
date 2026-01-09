namespace ACBindings;

// ClientNet
public unsafe struct ClientNet : System.IDisposable
{
    // Base Classes
    public ACBindings.SharedNet BaseClass_SharedNet; // ACBindings.SharedNet
    public ACBindings.CClientsideLoginStateHandler BaseClass_CClientsideLoginStateHandler; // ACBindings.CClientsideLoginStateHandler
    public ACBindings.CPluginManagerTemplate__CLinkStatusPlugin BaseClass_CPluginManagerTemplate; // ACBindings.CPluginManagerTemplate__CLinkStatusPlugin

    // Child Types
    // ClientNet_vtbl
    public unsafe struct ClientNet_vtbl
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
        public System.IntPtr HandleConnectionRequest; // function pointer
        public System.IntPtr HandleReferral;
        public System.IntPtr HandleServerSwitch;
        public System.IntPtr LogonUseTime; // function pointer

        // Methods
    }
    // ClientNet::CLogonData
    public unsafe struct CLogonData
    {
        // Members
        public ACBindings.AsyncContext hCurrentContext;
        public int timeLastLoginRequestSent;
        public int ServerAddr;
        public ACBindings.NetAuthenticator* pNetAuth;
        public int nRequestsSent;
        public byte bMyTurn;
        public ACBindings.NetError FailureReason;

        // Methods
    }
    // ClientNet::CReferralQueueEntry
    public unsafe struct CReferralQueueEntry
    {
        // Members
        public uint nAuthsSent;
        public ushort idServer;
        public double localtimeToSendNextWorldAuth;
        public int ServerAddr;
        public ulong qwCookie;

        // Methods
    }
    // ClientNet::CSwitchHistory
    public unsafe struct CSwitchHistory
    {
        // Members
        public ACBindings.CTimestamp__uint LastSwitchStamp;
        public byte bBeenSwitchedBefore;

        // Methods
    }
    // ClientNet::WAIT_RESULT
    public enum WAIT_RESULT : uint
    {
        UNDEF_WAIT_RESULT = 0x0,
        DONE_WAIT_RESULT = 0x1,
        FAILED_WAIT_RESULT = 0x2,
        ROUTED_WAIT_RESULT = 0x3,
        NO_LOGON_SERVER_WAIT_RESULT = 0x4,
        EXPIRED_ZONE_TICKET_RESULT = 0x5,
        FORCE_WAIT_RESULT_32_BIT = 0x7FFFFFFF
    }

    // Members
    public ACBindings.ClientNet.CLogonData m_LogonData;
    public ACBindings.CAsyncStateMachine m_ConnectionFSM;
    public ACBindings.SmartArray__ClientNet_CReferralQueueEntry m_ReferralQueue;
    public ushort logonRecID_;
    public ushort currServerRecID_;
    public uint m_dwCurrentConnectionSequenceNumber;
    public ACBindings.ClientNet.CSwitchHistory m_WorldSwitchHistory;
    public ACBindings.ClientNet.CSwitchHistory m_LogonSwitchHistory;
    public byte logOffSent_;
    public byte fCurrentlyInGame_;
    public double _timeClientSpeedHackDetection;
    public double m_LastDidUseTime;
    public ACBindings.CLinkStatusSnapshot m_CurrentLinkStatus;
    public ACBindings.CLinkStatusAverages m_LinkStatusAverages;

    // Generated Constructor
    public ClientNet() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall ClientNet::OnStateBegun(ClientNet*,AsyncContext)
    public void OnStateBegun(ACBindings.AsyncContext hContext) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientNet, ACBindings.AsyncContext, void>)0x005429B0)(ref this, hContext);
    // void __thiscall ClientNet::EnterWorld(ClientNet*)
    public void EnterWorld() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientNet, void>)0x005429D0)(ref this);
    // void __thiscall ClientNet::ExitWorldDisconnect(ClientNet*)
    public void ExitWorldDisconnect() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientNet, void>)0x005429E0)(ref this);
    // int __thiscall ClientNet::SendBuff(ClientNet*,_WSABUF*,int,sockaddr_in)
    public int SendBuff(ACBindings._WSABUF* vecs, int vecNum, int addr_to) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientNet, ACBindings._WSABUF*, int, int, int>)0x00542A70)(ref this, vecs, vecNum, addr_to);
    // bool __thiscall ClientNet::UseTime(ClientNet*)
    public byte UseTime() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientNet, byte>)0x00543440)(ref this);
    // void __thiscall ClientNet::EndState(ClientNet*,const NetError*)
    public void EndState(ACBindings.NetError* FailureReason) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientNet, ACBindings.NetError*, void>)0x00543F40)(ref this, FailureReason);
    // bool __thiscall ClientNet::VerifyHeader(ClientNet*,const CNetLayerPacket*)
    public byte VerifyHeader(ACBindings.CNetLayerPacket* pkt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientNet, ACBindings.CNetLayerPacket*, byte>)0x00543FE0)(ref this, pkt);
    // void __thiscall ClientNet::NotifyPluginsOfStatusChange(ClientNet*,NetStatus,int,int)
    public void NotifyPluginsOfStatusChange(ACBindings.NetStatus Status, int Param1, int Param2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientNet, ACBindings.NetStatus, int, int, void>)0x00544190)(ref this, Status, Param1, Param2);
    // void __thiscall ClientNet::NotifyPluginsOfHeartbeat(ClientNet*)
    public void NotifyPluginsOfHeartbeat() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientNet, void>)0x005441E0)(ref this);
    // void __thiscall ClientNet::OnContextEnded(ClientNet*,AsyncContext,AsyncStateMachineStatus)
    public void OnContextEnded(ACBindings.AsyncContext hContext, ACBindings.AsyncStateMachineStatus CompletionStatus) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientNet, ACBindings.AsyncContext, ACBindings.AsyncStateMachineStatus, void>)0x00544880)(ref this, hContext, CompletionStatus);
    // void __thiscall ClientNet::HandleTimeSynch(ClientNet*,const CTimeSyncHeader*,const CNetLayerPacket*)
    public void HandleTimeSynch(ACBindings.CTimeSyncHeader* pHdr, ACBindings.CNetLayerPacket* pkt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientNet, ACBindings.CTimeSyncHeader*, ACBindings.CNetLayerPacket*, void>)0x005448F0)(ref this, pHdr, pkt);
    // __int16 __thiscall ClientNet::HandleServerSwitch(int,int,int)
    public short HandleServerSwitch(int a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientNet, int, int, short>)0x005449E0)(ref this, a2, a3);
    // void __thiscall ClientNet::LogOffServer(ClientNet*)
    public void LogOffServer() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientNet, void>)0x00544AB0)(ref this);
    // bool __thiscall ClientNet::SendLoginRequest(ClientNet*,const sockaddr_in*,const NetAuthenticator*)
    public byte SendLoginRequest(int* ServerAddr, ACBindings.NetAuthenticator* pNetAuth) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientNet, int*, ACBindings.NetAuthenticator*, byte>)0x00544B50)(ref this, ServerAddr, pNetAuth);
    // bool __thiscall ClientNet::SendConnectAck(ClientNet*,ReceiverData*)
    public byte SendConnectAck(ACBindings.ReceiverData* pReceiver) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientNet, ACBindings.ReceiverData*, byte>)0x00544CB0)(ref this, pReceiver);
    // void __thiscall ClientNet::ProcessReferralQueue(ClientNet*)
    public void ProcessReferralQueue() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientNet, void>)0x00544DB0)(ref this);
    // void __thiscall ClientNet::OnContextBegun(ClientNet*,AsyncContext)
    public void OnContextBegun(ACBindings.AsyncContext hContext) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientNet, ACBindings.AsyncContext, void>)0x00545540)(ref this, hContext);
    // void __thiscall ClientNet::LogonUseTime(ClientNet*)
    public void LogonUseTime() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientNet, void>)0x005455D0)(ref this);
    // NetError* __thiscall ClientNet::InitAddresses(ClientNet*,NetError*,const char*,int,sockaddr_in*,const ClientNetConfiguration*)
    public ACBindings.NetError* InitAddresses(ACBindings.NetError* result, sbyte* host, int port, int* udp_srv_addr, ACBindings.ClientNetConfiguration* Config) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientNet, ACBindings.NetError*, sbyte*, int, int*, ACBindings.ClientNetConfiguration*, ACBindings.NetError*>)0x005456C0)(ref this, result, host, port, udp_srv_addr, Config);
    // NetError* __thiscall ClientNet::Init(ClientNet*,NetError*,int,const char*,DatIDStamp*,NetAuthenticator*,const ClientNetConfiguration*)
    public ACBindings.NetError* Init(ACBindings.NetError* result, int port, sbyte* host, ACBindings.DatIDStamp* dataVer, ACBindings.NetAuthenticator* pNetAuth, ACBindings.ClientNetConfiguration* Config) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientNet, ACBindings.NetError*, int, sbyte*, ACBindings.DatIDStamp*, ACBindings.NetAuthenticator*, ACBindings.ClientNetConfiguration*, ACBindings.NetError*>)0x00545BD0)(ref this, result, port, host, dataVer, pNetAuth, Config);
    // bool __thiscall ClientNet::ProcessPacket(ClientNet*,CNetLayerPacket*)
    public byte ProcessPacket(ACBindings.CNetLayerPacket* pkt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientNet, ACBindings.CNetLayerPacket*, byte>)0x00545CC0)(ref this, pkt);
    // bool __thiscall ClientNet::ProcessOptionalHeader(ClientNet*,const COptionalHeader*,const CNetLayerPacket*)
    public byte ProcessOptionalHeader(ACBindings.COptionalHeader* pHdr, ACBindings.CNetLayerPacket* pkt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientNet, ACBindings.COptionalHeader*, ACBindings.CNetLayerPacket*, byte>)0x00545D60)(ref this, pHdr, pkt);
    // void __thiscall ClientNet::RemoveConnection(ClientNet*,unsigned __int16)
    public void RemoveConnection(ushort recID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientNet, ushort, void>)0x00545F80)(ref this, recID);
    // bool __thiscall ClientNet::ProcessConnections(ClientNet*)
    public byte ProcessConnections() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientNet, byte>)0x00546000)(ref this);
    // bool __thiscall ClientNet::ProcessConnection(ClientNet*,ReceiverData*)
    public byte ProcessConnection(ACBindings.ReceiverData* pReceiver) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientNet, ACBindings.ReceiverData*, byte>)0x00546010)(ref this, pReceiver);
    // void __thiscall ClientNet::~ClientNet(ClientNet*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientNet, void>)0x00546590)(ref this);
    // void __thiscall ClientNet::HandleConnectionRequest(ClientNet*,const CConnectHeader*,const CNetLayerPacket*)
    public void HandleConnectionRequest(ACBindings.CConnectHeader* pConnectHeader, ACBindings.CNetLayerPacket* pkt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientNet, ACBindings.CConnectHeader*, ACBindings.CNetLayerPacket*, void>)0x00546680)(ref this, pConnectHeader, pkt);
    // void __thiscall ClientNet::HandleReferral(ClientNet*,int)
    public void HandleReferral(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientNet, int, void>)0x005468F0)(ref this, a2);
    // void __thiscall ClientNet::ClientNet(ClientNet*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientNet, void>)0x00546F20)(ref this);
}

