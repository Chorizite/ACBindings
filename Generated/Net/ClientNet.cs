namespace ACBindings.Internal;


/// <summary>Coordinates the client’s network layer, handling authentication, server switching, referral processing, and link‑status reporting while interfacing with the shared networking core.</summary>
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
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientNet*, ACBindings.Internal.NetPerfCounter, int, void> AddToPerfCounter; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientNet*, ACBindings.Internal._WSABUF*, int, int, int> SendBuff; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientNet*, byte> ProcessConnections; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientNet*, ACBindings.Internal.ReceiverData*, byte> ProcessConnection; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientNet*, void> OnUseTimeTimeout; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientNet*, void> BeforeCheckingSocket; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientNet*, byte> ReadAndProcessPackets; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientNet*, uint, ACBindings.Internal.CNetLayerPacket*, int> ReadNextPacket; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientNet*, ACBindings.Internal.CNetLayerPacket*, byte> ProcessPacket; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientNet*, ACBindings.Internal.CNetLayerPacket*, byte> VerifyHeader; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientNet*, ACBindings.Internal.CNetLayerPacket*, byte> SplitPacketData; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientNet*, ACBindings.Internal.CNetLayerPacket*, byte> ProcessNewRemoteInterval; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientNet*, ACBindings.Internal.CNetLayerPacket*, byte> ProcessOptionalHeaders; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientNet*, ACBindings.Internal.COptionalHeader*, ACBindings.Internal.CNetLayerPacket*, byte> ProcessOptionalHeader; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientNet*, ACBindings.Internal.CNetLayerPacket*, byte> ProcessBlobFrags; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientNet*, ushort, ACBindings.Internal.ConnectionState, void> SetConnectionState; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientNet*, ACBindings.Internal.CTimeSyncHeader*, ACBindings.Internal.CNetLayerPacket*, void> HandleTimeSynch; // function pointer
        public System.IntPtr HandleNak;
        public System.IntPtr HandlePak;
        public System.IntPtr HandleEmptyAck;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientNet*, ACBindings.Internal.CConnectHeader*, ACBindings.Internal.CNetLayerPacket*, void> HandleConnectionRequest; // function pointer
        public System.IntPtr HandleReferral;
        public System.IntPtr HandleServerSwitch;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientNet*, void> LogonUseTime; // function pointer

        // Methods
    }

    /// <summary>Tracks the state of a client's logon process, including context, timing, server endpoint, authentication handle, request count, turn flag, and failure reason.</summary>
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

    /// <summary>Entry in the client referral queue, tracking authentication attempts, target server details, scheduling of the next world authentication, and a unique session cookie.</summary>
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

    /// <summary>Captures the time of the most recent client switch and records if a switch has occurred before, enabling logic that depends on switch history.</summary>
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

    /// <summary>Prepares the client network subsystem for a new asynchronous state by resetting internal receiver indices and invoking the state's begin callback.
    /// <code>Offset: 0x005429B0
    /// void __thiscall ClientNet::OnStateBegun(ClientNet*,AsyncContext)</code>
    /// </summary>
    /// <param name="hContext">The asynchronous context associated with the state transition.</param>
    public void OnStateBegun(ACBindings.Internal.AsyncContext hContext) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientNet, ACBindings.Internal.AsyncContext, void>)0x005429B0)(ref this, hContext);

    /// <summary>Marks the client as having entered the game world by setting an internal flag that enables gameplay logic and associated network communication.
    /// <code>Offset: 0x005429D0
    /// void __thiscall ClientNet::EnterWorld(ClientNet*)</code>
    /// </summary>
    public void EnterWorld() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientNet, void>)0x005429D0)(ref this);

    /// <summary>Disconnects the client from the current game world, removes all active server connections except the primary login link, resets world‑switch history and UI event counters, and prepares for a new world session.
    /// <code>Offset: 0x005429E0
    /// void __thiscall ClientNet::ExitWorldDisconnect(ClientNet*)</code>
    /// </summary>
    public void ExitWorldDisconnect() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientNet, void>)0x005429E0)(ref this);

    /// <summary>Transmits the supplied WSABUF buffers to the specified remote address unless a log‑off has already been sent.
    /// <code>Offset: 0x00542A70
    /// int __thiscall ClientNet::SendBuff(ClientNet*,_WSABUF*,int,sockaddr_in)</code>
    /// </summary>
    /// <param name="vecs">Array of WSABUF structures containing data to send.</param>
    /// <param name="vecNum">Number of WSABUF entries in vecs.</param>
    /// <param name="addr_to">Remote socket address for the outgoing packets.</param>
    /// <returns>Zero if a log‑off has been sent or the underlying network send fails; otherwise returns the number of bytes successfully transmitted.</returns>
    public int SendBuff(ACBindings.Internal._WSABUF* vecs, int vecNum, int addr_to) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientNet, ACBindings.Internal._WSABUF*, int, int, int>)0x00542A70)(ref this, vecs, vecNum, addr_to);

    /// <summary>Executes a single client‑network time step, optionally handling pending connections before delegating to SharedNet::UseTime.
    /// <code>Offset: 0x00543440
    /// bool __thiscall ClientNet::UseTime(ClientNet*)</code>
    /// </summary>
    /// <returns>True when the underlying network update succeeds; otherwise false.</returns>
    public byte UseTime() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientNet, byte>)0x00543440)(ref this);

    /// <summary>
    /// Finalizes the client login state, recording the provided error information into the current context and clearing the turn flag.
    /// If the error indicates success, transitions to the next state; otherwise triggers failure handling logic.
    /// 
    /// <code>Offset: 0x00543F40
    /// void __thiscall ClientNet::EndState(ClientNet*,const NetError*)</code>
    /// </summary>
    /// <param name="FailureReason">The NetError describing why the login failed or succeeded.</param>
    public void EndState(ACBindings.Internal.NetError* FailureReason) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientNet, ACBindings.Internal.NetError*, void>)0x00543F40)(ref this, FailureReason);

    /// <summary>Validates the header of a received network packet against stored connection state and logs errors for malformed or mismatched packets.
    /// <code>Offset: 0x00543FE0
    /// bool __thiscall ClientNet::VerifyHeader(ClientNet*,const CNetLayerPacket*)</code>
    /// </summary>
    /// <param name="pkt">The network packet to validate.</param>
    /// <returns>True if the packet's header passes all checks; otherwise, false.</returns>
    public byte VerifyHeader(ACBindings.Internal.CNetLayerPacket* pkt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientNet, ACBindings.Internal.CNetLayerPacket*, byte>)0x00543FE0)(ref this, pkt);

    /// <summary>Notifies all registered link‑status plugins of a change in connection status, forwarding the new state and accompanying data.
    /// <code>Offset: 0x00544190
    /// void __thiscall ClientNet::NotifyPluginsOfStatusChange(ClientNet*,NetStatus,int,int)</code>
    /// </summary>
    /// <param name="Status">The updated network status to inform plugins about.</param>
    /// <param name="Param1">Context‑specific integer parameter supplied by caller.</param>
    /// <param name="Param2">Additional context or error code relevant to the status transition.</param>
    public void NotifyPluginsOfStatusChange(ACBindings.Internal.NetStatus Status, int Param1, int Param2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientNet, ACBindings.Internal.NetStatus, int, int, void>)0x00544190)(ref this, Status, Param1, Param2);

    /// <summary>Notifies each link‑status plugin about the latest heartbeat by providing it with the current network statistics.
    /// <code>Offset: 0x005441E0
    /// void __thiscall ClientNet::NotifyPluginsOfHeartbeat(ClientNet*)</code>
    /// </summary>
    public void NotifyPluginsOfHeartbeat() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientNet, void>)0x005441E0)(ref this);

    /// <summary>Handles completion of a network context, updating stored result codes and notifying plugins of login status.
    /// <code>Offset: 0x00544880
    /// void __thiscall ClientNet::OnContextEnded(ClientNet*,AsyncContext,AsyncStateMachineStatus)</code>
    /// </summary>
    /// <param name="hContext">Identifier for the finished asynchronous operation.</param>
    /// <param name="CompletionStatus">Overall status of the state machine (ignored by this handler).</param>
    public void OnContextEnded(ACBindings.Internal.AsyncContext hContext, ACBindings.Internal.AsyncStateMachineStatus CompletionStatus) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientNet, ACBindings.Internal.AsyncContext, ACBindings.Internal.AsyncStateMachineStatus, void>)0x00544880)(ref this, hContext, CompletionStatus);

    /// <summary>Synchronizes the client clock with server time and detects speed‑hack attempts, sending an error to the recipient if a violation is detected.
    /// <code>Offset: 0x005448F0
    /// void __thiscall ClientNet::HandleTimeSynch(ClientNet*,const CTimeSyncHeader*,const CNetLayerPacket*)</code>
    /// </summary>
    /// <param name="pHdr">The time synchronization header sent by the server containing the current server time.</param>
    /// <param name="pkt">The packet that may contain recipient data used for reporting a speed‑hack detection.</param>
    public void HandleTimeSynch(ACBindings.Internal.CTimeSyncHeader* pHdr, ACBindings.Internal.CNetLayerPacket* pkt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientNet, ACBindings.Internal.CTimeSyncHeader*, ACBindings.Internal.CNetLayerPacket*, void>)0x005448F0)(ref this, pHdr, pkt);

    /// <summary>
    /// Handles a transition to a new server by recording the sequence number and relevant identifiers from the supplied structures, ensuring each switch is processed only once.  
    /// 
    /// <code>Offset: 0x005449E0
    /// __int16 __thiscall ClientNet::HandleServerSwitch(int,int,int)</code>
    /// </summary>
    /// <param name="a2">Pointer to a connection context that contains a flag at offset 28 indicating the type of switch (e.g., login or world) and a sequence number at offset 24 used to detect stale requests.</param>
    /// <param name="a3">Pointer to a server data structure from which identifiers are extracted through offsets such as 264 and 65828 to update internal state during the switch.</param>
    /// <returns>Low‑order 16 bits of an identifier derived from the input structures, typically representing the new server ID or a result code for the switch operation.</returns>
    public short HandleServerSwitch(int a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientNet, int, int, short>)0x005449E0)(ref this, a2, a3);

    /// <summary>Initiates client logout by sending a log‑off header to all connected peers, resetting session identifiers, and disconnecting from the current world.
    /// <code>Offset: 0x00544AB0
    /// void __thiscall ClientNet::LogOffServer(ClientNet*)</code>
    /// </summary>
    public void LogOffServer() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientNet, void>)0x00544AB0)(ref this);

    /// <summary>Sends a login request packet to the specified server using provided authentication data.
    /// <code>Offset: 0x00544B50
    /// bool __thiscall ClientNet::SendLoginRequest(ClientNet*,const sockaddr_in*,const NetAuthenticator*)</code>
    /// </summary>
    /// <param name="ServerAddr">Pointer to a sockaddr_in structure containing the destination IP address and port for the login request.</param>
    /// <param name="pNetAuth">Pointer to a NetAuthenticator object that holds credentials and flags required for logging in.</param>
    /// <returns>True if the packet was successfully queued for transmission; otherwise false (e.g., when authentication data is null or packet construction fails).</returns>
    public byte SendLoginRequest(int* ServerAddr, ACBindings.Internal.NetAuthenticator* pNetAuth) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientNet, int*, ACBindings.Internal.NetAuthenticator*, byte>)0x00544B50)(ref this, ServerAddr, pNetAuth);

    /// <summary>Sends a connect‑acknowledgment packet to the specified receiver and notifies plugins when the send succeeds.
    /// <code>Offset: 0x00544CB0
    /// bool __thiscall ClientNet::SendConnectAck(ClientNet*,ReceiverData*)</code>
    /// </summary>
    /// <param name="pReceiver">The ReceiverData instance representing the remote peer to acknowledge.</param>
    /// <returns>True if the acknowledgment was transmitted successfully; otherwise false.</returns>
    public byte SendConnectAck(ACBindings.Internal.ReceiverData* pReceiver) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientNet, ACBindings.Internal.ReceiverData*, byte>)0x00544CB0)(ref this, pReceiver);

    /// <summary>Processes queued referral authentication requests by sending world‑authentication packets at scheduled intervals, handling retry limits, and removing entries when a maximum number of attempts is exceeded. Notifies registered plugins when a referral connection fails.
    /// <code>Offset: 0x00544DB0
    /// void __thiscall ClientNet::ProcessReferralQueue(ClientNet*)</code>
    /// </summary>
    public void ProcessReferralQueue() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientNet, void>)0x00544DB0)(ref this);

    /// <summary>Initiates an asynchronous context by storing context information and registering relevant data fields such as network identifiers and failure reasons.
    /// <code>Offset: 0x00545540
    /// void __thiscall ClientNet::OnContextBegun(ClientNet*,AsyncContext)</code>
    /// </summary>
    /// <param name="hContext">The context descriptor containing the context ID and related metadata for the operation.</param>
    public void OnContextBegun(ACBindings.Internal.AsyncContext hContext) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientNet, ACBindings.Internal.AsyncContext, void>)0x00545540)(ref this, hContext);

    /// <summary>Manages the client’s logon process by sending authentication requests at regular intervals, handling retries, and terminating the connection if errors occur or a timeout is reached.
    /// <code>Offset: 0x005455D0
    /// void __thiscall ClientNet::LogonUseTime(ClientNet*)</code>
    /// </summary>
    public void LogonUseTime() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientNet, void>)0x005455D0)(ref this);

    /// <summary>Initializes client network addresses for connecting to the specified host and port, configuring sockets according to the provided ClientNetConfiguration. Resolves DNS, creates a TCP socket, selects an appropriate local interface and port, applies socket options, and sets non‑blocking mode.
    /// <code>Offset: 0x005456C0
    /// NetError* __thiscall ClientNet::InitAddresses(ClientNet*,NetError*,const char*,int,sockaddr_in*,const ClientNetConfiguration*)</code>
    /// </summary>
    /// <param name="this">The ClientNet instance being initialized.</param>
    /// <param name="result">Output error object that will contain status information after the call.</param>
    /// <param name="host">The server host name or IP address to connect to.</param>
    /// <param name="port">The TCP port number for the connection; may be overridden by a value embedded in <c>host</c>.</param>
    /// <param name="udp_srv_addr">Pointer to a <c>sockaddr_in</c> structure that will receive the resolved UDP server address.</param>
    /// <param name="Config">Configuration options controlling interface selection and port binding behavior.</param>
    /// <returns>A pointer to the <c>NetError</c> object described by <paramref name="result"/>; indicates success or failure of the initialization.</returns>
    public ACBindings.Internal.NetError* InitAddresses(ACBindings.Internal.NetError* result, sbyte* host, int port, int* udp_srv_addr, ACBindings.Internal.ClientNetConfiguration* Config) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientNet, ACBindings.Internal.NetError*, sbyte*, int, int*, ACBindings.Internal.ClientNetConfiguration*, ACBindings.Internal.NetError*>)0x005456C0)(ref this, result, host, port, udp_srv_addr, Config);

    /// <summary>Initializes a ClientNet instance by configuring link status, copying logging settings, establishing network addresses and authentication data, then allocating the connection state machine if an authenticator is supplied.
    /// <code>Offset: 0x00545BD0
    /// NetError* __thiscall ClientNet::Init(ClientNet*,NetError*,int,const char*,DatIDStamp*,NetAuthenticator*,const ClientNetConfiguration*)</code>
    /// </summary>
    /// <param name="result">A NetError object that will receive the outcome of the initialization; returned unchanged from the function.</param>
    /// <param name="port">The TCP/UDP port to use for the connection.</param>
    /// <param name="host">Hostname or IP address to connect to.</param>
    /// <param name="dataVer">Version stamp used during initialization (currently not altered).</param>
    /// <param name="pNetAuth">Authentication object containing account credentials; may be null, in which case authentication setup is skipped.</param>
    /// <param name="Config">Configuration data whose logger settings are copied into the client base class.</param>
    /// <returns>Returns the same NetError pointer supplied as 'result', now populated with any error codes that occurred during initialization.</returns>
    public ACBindings.Internal.NetError* Init(ACBindings.Internal.NetError* result, int port, sbyte* host, ACBindings.Internal.DatIDStamp* dataVer, ACBindings.Internal.NetAuthenticator* pNetAuth, ACBindings.Internal.ClientNetConfiguration* Config) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientNet, ACBindings.Internal.NetError*, int, sbyte*, ACBindings.Internal.DatIDStamp*, ACBindings.Internal.NetAuthenticator*, ACBindings.Internal.ClientNetConfiguration*, ACBindings.Internal.NetError*>)0x00545BD0)(ref this, result, port, host, dataVer, pNetAuth, Config);

    /// <summary>Processes an incoming network packet for the client, delegating to the shared base class and then handling connection state transitions such as acknowledging a connection request or clearing referral cookies.
    /// <code>Offset: 0x00545CC0
    /// bool __thiscall ClientNet::ProcessPacket(ClientNet*,CNetLayerPacket*)</code>
    /// </summary>
    /// <param name="this">Pointer to the ClientNet instance receiving the packet.</param>
    /// <param name="pkt">Packet containing data and metadata from the network layer.</param>
    /// <returns>True if the packet was processed successfully; otherwise false.</returns>
    public byte ProcessPacket(ACBindings.Internal.CNetLayerPacket* pkt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientNet, ACBindings.Internal.CNetLayerPacket*, byte>)0x00545CC0)(ref this, pkt);

    /// <summary>Processes an optional header from a received packet, performing client‑specific actions such as error reporting, ping response handling, performance counter updates, and connection state changes.
    /// <code>Offset: 0x00545D60
    /// bool __thiscall ClientNet::ProcessOptionalHeader(ClientNet*,const COptionalHeader*,const CNetLayerPacket*)</code>
    /// </summary>
    /// <param name="this">The ClientNet instance.</param>
    /// <param name="pHdr">Optional header to process.</param>
    /// <param name="pkt">Network packet containing the optional header.</param>
    /// <returns>True if the header was handled successfully; otherwise false.</returns>
    public byte ProcessOptionalHeader(ACBindings.Internal.COptionalHeader* pHdr, ACBindings.Internal.CNetLayerPacket* pkt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientNet, ACBindings.Internal.COptionalHeader*, ACBindings.Internal.CNetLayerPacket*, byte>)0x00545D60)(ref this, pHdr, pkt);

    /// <summary>Removes the network connection identified by recID, unregistering it from packet controller, unlinking its receiver data, clearing resources, and initiating logout if it matches current logon or server record IDs.
    /// <code>Offset: 0x00545F80
    /// void __thiscall ClientNet::RemoveConnection(ClientNet*,unsigned __int16)</code>
    /// </summary>
    /// <param name="recID">The identifier of the connection to remove.</param>
    public void RemoveConnection(ushort recID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientNet, ushort, void>)0x00545F80)(ref this, recID);

    /// <summary>Processes queued referrals and updates network connections by delegating to the shared base class implementation.
    /// <code>Offset: 0x00546000
    /// bool __thiscall ClientNet::ProcessConnections(ClientNet*)</code>
    /// </summary>
    /// <returns>True if the underlying shared net processed connections successfully; otherwise false.</returns>
    public byte ProcessConnections() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientNet, byte>)0x00546000)(ref this);

    /// <summary>Processes a network connection according to its current state, handling handshakes, disconnections, NAKs, and referral data while updating link metrics and notifying plugins.
    /// <code>Offset: 0x00546010
    /// bool __thiscall ClientNet::ProcessConnection(ClientNet*,ReceiverData*)</code>
    /// </summary>
    /// <param name="this">The ClientNet instance managing the connection.</param>
    /// <param name="pReceiver">Connection information for which processing is performed.</param>
    /// <returns>True if the state was recognized and handled; false otherwise.</returns>
    public byte ProcessConnection(ACBindings.Internal.ReceiverData* pReceiver) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientNet, ACBindings.Internal.ReceiverData*, byte>)0x00546010)(ref this, pReceiver);

    /// <summary>Releases all client‑side networking resources. Closes the socket, removes active connections, clears buffers and deallocates dynamically allocated memory, then destroys the underlying SharedNet base class.
    /// <code>Offset: 0x00546590
    /// void __thiscall ClientNet::~ClientNet(ClientNet*)</code>
    /// </summary>
    /// <param name="this">Pointer to the ClientNet instance being destroyed.</param>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientNet, void>)0x00546590)(ref this);

    /// <summary>Processes an incoming connection request by validating sequence order, initializing a receiver session, setting up cryptographic key exchange, registering the connection in the network controller, handling referral tracking, and sending back a connection acknowledgment.
    /// <code>Offset: 0x00546680
    /// void __thiscall ClientNet::HandleConnectionRequest(ClientNet*,const CConnectHeader*,const CNetLayerPacket*)</code>
    /// </summary>
    /// <param name="this">The ClientNet instance that handles the connection request.</param>
    /// <param name="pConnectHeader">Header containing login data such as NetID, outgoing/incoming seeds, and the referral cookie.</param>
    /// <param name="pkt">Packet that includes the remote address, iteration information, and other metadata for the connection request.</param>
    public void HandleConnectionRequest(ACBindings.Internal.CConnectHeader* pConnectHeader, ACBindings.Internal.CNetLayerPacket* pkt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientNet, ACBindings.Internal.CConnectHeader*, ACBindings.Internal.CNetLayerPacket*, void>)0x00546680)(ref this, pConnectHeader, pkt);

    /// <summary>Processes a referral packet, updating an existing receiver or queuing a new referral entry for later processing.
    /// <code>Offset: 0x005468F0
    /// void __thiscall ClientNet::HandleReferral(ClientNet*,int)</code>
    /// </summary>
    /// <param name="a2">Pointer to the referral data packet containing server ID and connection information.</param>
    public void HandleReferral(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientNet, int, void>)0x005468F0)(ref this, a2);

    /// <summary>Initializes a ClientNet instance, setting up network components, login state handling, plugin manager, connection state machine, referral queue, and link status statistics while seeding the random number generator with the current time and preparing shared flow‑queue resources.
    /// <code>Offset: 0x00546F20
    /// void __thiscall ClientNet::ClientNet(ClientNet*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientNet, void>)0x00546F20)(ref this);
}

