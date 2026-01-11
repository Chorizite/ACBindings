namespace ACBindings.Internal;

public unsafe struct ClientNet : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.SharedNet BaseClass_SharedNet; // ACBindings.Internal.SharedNet
    public ACBindings.Internal.CClientsideLoginStateHandler BaseClass_CClientsideLoginStateHandler; // ACBindings.Internal.CClientsideLoginStateHandler
    public ACBindings.Internal.CPluginManagerTemplate___CLinkStatusPlugin BaseClass_CPluginManagerTemplate; // ACBindings.Internal.CPluginManagerTemplate___CLinkStatusPlugin

    // Child Types
    public unsafe struct ClientNet_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientNet*, ACBindings.Internal.NetPerfCounter, int, void> AddToPerfCounter; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientNet*, ACBindings.Internal._WSABUF*, int, int, int> SendBuff; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientNet*, byte> ProcessConnections; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientNet*, ACBindings.Internal.ReceiverData*, byte> ProcessConnection; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientNet*, void> OnUseTimeTimeout; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientNet*, void> BeforeCheckingSocket; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientNet*, byte> ReadAndProcessPackets; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientNet*, uint, ACBindings.Internal.CNetLayerPacket*, int> ReadNextPacket; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientNet*, ACBindings.Internal.CNetLayerPacket*, byte> ProcessPacket; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientNet*, ACBindings.Internal.CNetLayerPacket*, byte> VerifyHeader; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientNet*, ACBindings.Internal.CNetLayerPacket*, byte> SplitPacketData; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientNet*, ACBindings.Internal.CNetLayerPacket*, byte> ProcessNewRemoteInterval; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientNet*, ACBindings.Internal.CNetLayerPacket*, byte> ProcessOptionalHeaders; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientNet*, ACBindings.Internal.COptionalHeader*, ACBindings.Internal.CNetLayerPacket*, byte> ProcessOptionalHeader; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientNet*, ACBindings.Internal.CNetLayerPacket*, byte> ProcessBlobFrags; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientNet*, ushort, ACBindings.Internal.ConnectionState, void> SetConnectionState; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientNet*, ACBindings.Internal.CTimeSyncHeader*, ACBindings.Internal.CNetLayerPacket*, void> HandleTimeSynch; // function pointer
        public System.IntPtr HandleNak;
        public System.IntPtr HandlePak;
        public System.IntPtr HandleEmptyAck;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientNet*, ACBindings.Internal.CConnectHeader*, ACBindings.Internal.CNetLayerPacket*, void> HandleConnectionRequest; // function pointer
        public System.IntPtr HandleReferral;
        public System.IntPtr HandleServerSwitch;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientNet*, void> LogonUseTime; // function pointer

        // Methods
    }
    public unsafe struct CLogonData
    {
        // Members
        public ACBindings.Internal.AsyncContext hCurrentContext;
        public int timeLastLoginRequestSent;
        public int ServerAddr;
        public ACBindings.Internal.NetAuthenticator* pNetAuth;
        public int nRequestsSent;
        public byte bMyTurn;
        public ACBindings.Internal.NetError FailureReason;

        // Methods
    }
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
    public unsafe struct CSwitchHistory
    {
        // Members
        public ACBindings.Internal.CTimestamp__uint LastSwitchStamp;
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
    public ACBindings.Internal.ClientNet.CLogonData m_LogonData;
    public ACBindings.Internal.CAsyncStateMachine m_ConnectionFSM;
    public ACBindings.Internal.SmartArray___ClientNet_CReferralQueueEntry m_ReferralQueue;
    public ushort logonRecID_;
    public ushort currServerRecID_;
    public uint m_dwCurrentConnectionSequenceNumber;
    public ACBindings.Internal.ClientNet.CSwitchHistory m_WorldSwitchHistory;
    public ACBindings.Internal.ClientNet.CSwitchHistory m_LogonSwitchHistory;
    public byte logOffSent_;
    public byte fCurrentlyInGame_;
    public double _timeClientSpeedHackDetection;
    public double m_LastDidUseTime;
    public ACBindings.Internal.CLinkStatusSnapshot m_CurrentLinkStatus;
    public ACBindings.Internal.CLinkStatusAverages m_LinkStatusAverages;

    // Generated Constructor
    public ClientNet() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x005429B0
    /// void __thiscall ClientNet::OnStateBegun(ClientNet*,AsyncContext)</code>
    /// </summary>
    public void OnStateBegun(ACBindings.Internal.AsyncContext hContext) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientNet, ACBindings.Internal.AsyncContext, void>)0x005429B0)(ref this, hContext);

    /// <summary>
    /// <code>Offset: 0x005429D0
    /// void __thiscall ClientNet::EnterWorld(ClientNet*)</code>
    /// </summary>
    public void EnterWorld() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientNet, void>)0x005429D0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005429E0
    /// void __thiscall ClientNet::ExitWorldDisconnect(ClientNet*)</code>
    /// </summary>
    public void ExitWorldDisconnect() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientNet, void>)0x005429E0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00542A70
    /// int __thiscall ClientNet::SendBuff(ClientNet*,_WSABUF*,int,sockaddr_in)</code>
    /// </summary>
    public int SendBuff(ACBindings.Internal._WSABUF* vecs, int vecNum, int addr_to) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientNet, ACBindings.Internal._WSABUF*, int, int, int>)0x00542A70)(ref this, vecs, vecNum, addr_to);

    /// <summary>
    /// <code>Offset: 0x00543440
    /// bool __thiscall ClientNet::UseTime(ClientNet*)</code>
    /// </summary>
    public byte UseTime() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientNet, byte>)0x00543440)(ref this);

    /// <summary>
    /// <code>Offset: 0x00543F40
    /// void __thiscall ClientNet::EndState(ClientNet*,const NetError*)</code>
    /// </summary>
    public void EndState(ACBindings.Internal.NetError* FailureReason) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientNet, ACBindings.Internal.NetError*, void>)0x00543F40)(ref this, FailureReason);

    /// <summary>
    /// <code>Offset: 0x00543FE0
    /// bool __thiscall ClientNet::VerifyHeader(ClientNet*,const CNetLayerPacket*)</code>
    /// </summary>
    public byte VerifyHeader(ACBindings.Internal.CNetLayerPacket* pkt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientNet, ACBindings.Internal.CNetLayerPacket*, byte>)0x00543FE0)(ref this, pkt);

    /// <summary>
    /// <code>Offset: 0x00544190
    /// void __thiscall ClientNet::NotifyPluginsOfStatusChange(ClientNet*,NetStatus,int,int)</code>
    /// </summary>
    public void NotifyPluginsOfStatusChange(ACBindings.Internal.NetStatus Status, int Param1, int Param2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientNet, ACBindings.Internal.NetStatus, int, int, void>)0x00544190)(ref this, Status, Param1, Param2);

    /// <summary>
    /// <code>Offset: 0x005441E0
    /// void __thiscall ClientNet::NotifyPluginsOfHeartbeat(ClientNet*)</code>
    /// </summary>
    public void NotifyPluginsOfHeartbeat() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientNet, void>)0x005441E0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00544880
    /// void __thiscall ClientNet::OnContextEnded(ClientNet*,AsyncContext,AsyncStateMachineStatus)</code>
    /// </summary>
    public void OnContextEnded(ACBindings.Internal.AsyncContext hContext, ACBindings.Internal.AsyncStateMachineStatus CompletionStatus) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientNet, ACBindings.Internal.AsyncContext, ACBindings.Internal.AsyncStateMachineStatus, void>)0x00544880)(ref this, hContext, CompletionStatus);

    /// <summary>
    /// <code>Offset: 0x005448F0
    /// void __thiscall ClientNet::HandleTimeSynch(ClientNet*,const CTimeSyncHeader*,const CNetLayerPacket*)</code>
    /// </summary>
    public void HandleTimeSynch(ACBindings.Internal.CTimeSyncHeader* pHdr, ACBindings.Internal.CNetLayerPacket* pkt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientNet, ACBindings.Internal.CTimeSyncHeader*, ACBindings.Internal.CNetLayerPacket*, void>)0x005448F0)(ref this, pHdr, pkt);

    /// <summary>
    /// <code>Offset: 0x005449E0
    /// __int16 __thiscall ClientNet::HandleServerSwitch(int,int,int)</code>
    /// </summary>
    public short HandleServerSwitch(int a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientNet, int, int, short>)0x005449E0)(ref this, a2, a3);

    /// <summary>
    /// <code>Offset: 0x00544AB0
    /// void __thiscall ClientNet::LogOffServer(ClientNet*)</code>
    /// </summary>
    public void LogOffServer() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientNet, void>)0x00544AB0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00544B50
    /// bool __thiscall ClientNet::SendLoginRequest(ClientNet*,const sockaddr_in*,const NetAuthenticator*)</code>
    /// </summary>
    public byte SendLoginRequest(int* ServerAddr, ACBindings.Internal.NetAuthenticator* pNetAuth) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientNet, int*, ACBindings.Internal.NetAuthenticator*, byte>)0x00544B50)(ref this, ServerAddr, pNetAuth);

    /// <summary>
    /// <code>Offset: 0x00544CB0
    /// bool __thiscall ClientNet::SendConnectAck(ClientNet*,ReceiverData*)</code>
    /// </summary>
    public byte SendConnectAck(ACBindings.Internal.ReceiverData* pReceiver) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientNet, ACBindings.Internal.ReceiverData*, byte>)0x00544CB0)(ref this, pReceiver);

    /// <summary>
    /// <code>Offset: 0x00544DB0
    /// void __thiscall ClientNet::ProcessReferralQueue(ClientNet*)</code>
    /// </summary>
    public void ProcessReferralQueue() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientNet, void>)0x00544DB0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00545540
    /// void __thiscall ClientNet::OnContextBegun(ClientNet*,AsyncContext)</code>
    /// </summary>
    public void OnContextBegun(ACBindings.Internal.AsyncContext hContext) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientNet, ACBindings.Internal.AsyncContext, void>)0x00545540)(ref this, hContext);

    /// <summary>
    /// <code>Offset: 0x005455D0
    /// void __thiscall ClientNet::LogonUseTime(ClientNet*)</code>
    /// </summary>
    public void LogonUseTime() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientNet, void>)0x005455D0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005456C0
    /// NetError* __thiscall ClientNet::InitAddresses(ClientNet*,NetError*,const char*,int,sockaddr_in*,const ClientNetConfiguration*)</code>
    /// </summary>
    public ACBindings.Internal.NetError* InitAddresses(ACBindings.Internal.NetError* result, sbyte* host, int port, int* udp_srv_addr, ACBindings.Internal.ClientNetConfiguration* Config) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientNet, ACBindings.Internal.NetError*, sbyte*, int, int*, ACBindings.Internal.ClientNetConfiguration*, ACBindings.Internal.NetError*>)0x005456C0)(ref this, result, host, port, udp_srv_addr, Config);

    /// <summary>
    /// <code>Offset: 0x00545BD0
    /// NetError* __thiscall ClientNet::Init(ClientNet*,NetError*,int,const char*,DatIDStamp*,NetAuthenticator*,const ClientNetConfiguration*)</code>
    /// </summary>
    public ACBindings.Internal.NetError* Init(ACBindings.Internal.NetError* result, int port, sbyte* host, ACBindings.Internal.DatIDStamp* dataVer, ACBindings.Internal.NetAuthenticator* pNetAuth, ACBindings.Internal.ClientNetConfiguration* Config) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientNet, ACBindings.Internal.NetError*, int, sbyte*, ACBindings.Internal.DatIDStamp*, ACBindings.Internal.NetAuthenticator*, ACBindings.Internal.ClientNetConfiguration*, ACBindings.Internal.NetError*>)0x00545BD0)(ref this, result, port, host, dataVer, pNetAuth, Config);

    /// <summary>
    /// <code>Offset: 0x00545CC0
    /// bool __thiscall ClientNet::ProcessPacket(ClientNet*,CNetLayerPacket*)</code>
    /// </summary>
    public byte ProcessPacket(ACBindings.Internal.CNetLayerPacket* pkt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientNet, ACBindings.Internal.CNetLayerPacket*, byte>)0x00545CC0)(ref this, pkt);

    /// <summary>
    /// <code>Offset: 0x00545D60
    /// bool __thiscall ClientNet::ProcessOptionalHeader(ClientNet*,const COptionalHeader*,const CNetLayerPacket*)</code>
    /// </summary>
    public byte ProcessOptionalHeader(ACBindings.Internal.COptionalHeader* pHdr, ACBindings.Internal.CNetLayerPacket* pkt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientNet, ACBindings.Internal.COptionalHeader*, ACBindings.Internal.CNetLayerPacket*, byte>)0x00545D60)(ref this, pHdr, pkt);

    /// <summary>
    /// <code>Offset: 0x00545F80
    /// void __thiscall ClientNet::RemoveConnection(ClientNet*,unsigned __int16)</code>
    /// </summary>
    public void RemoveConnection(ushort recID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientNet, ushort, void>)0x00545F80)(ref this, recID);

    /// <summary>
    /// <code>Offset: 0x00546000
    /// bool __thiscall ClientNet::ProcessConnections(ClientNet*)</code>
    /// </summary>
    public byte ProcessConnections() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientNet, byte>)0x00546000)(ref this);

    /// <summary>
    /// <code>Offset: 0x00546010
    /// bool __thiscall ClientNet::ProcessConnection(ClientNet*,ReceiverData*)</code>
    /// </summary>
    public byte ProcessConnection(ACBindings.Internal.ReceiverData* pReceiver) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientNet, ACBindings.Internal.ReceiverData*, byte>)0x00546010)(ref this, pReceiver);

    /// <summary>
    /// <code>Offset: 0x00546590
    /// void __thiscall ClientNet::~ClientNet(ClientNet*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientNet, void>)0x00546590)(ref this);

    /// <summary>
    /// <code>Offset: 0x00546680
    /// void __thiscall ClientNet::HandleConnectionRequest(ClientNet*,const CConnectHeader*,const CNetLayerPacket*)</code>
    /// </summary>
    public void HandleConnectionRequest(ACBindings.Internal.CConnectHeader* pConnectHeader, ACBindings.Internal.CNetLayerPacket* pkt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientNet, ACBindings.Internal.CConnectHeader*, ACBindings.Internal.CNetLayerPacket*, void>)0x00546680)(ref this, pConnectHeader, pkt);

    /// <summary>
    /// <code>Offset: 0x005468F0
    /// void __thiscall ClientNet::HandleReferral(ClientNet*,int)</code>
    /// </summary>
    public void HandleReferral(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientNet, int, void>)0x005468F0)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x00546F20
    /// void __thiscall ClientNet::ClientNet(ClientNet*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientNet, void>)0x00546F20)(ref this);
}

