namespace ACBindings.Internal;


/// <summary>
/// Manages packet transmission, reception, and flow‑control for a client network connection, maintaining recipient lists, queues, timers, and statistics.
/// </summary>
/// <remarks>
/// Provides a singleton instance via Instance(), handles adding and removing recipients, enqueues outgoing NetBlobs or optional headers, processes received packets into appropriate queues, and tracks NAKs and flow‑control expirations. The controller interacts closely with ClientNet, RecipientData, and performance monitoring counters to coordinate network communication.
/// </remarks>
/// <seealso cref="ClientNet"/>
/// <seealso cref="RecipientData"/>
/// <seealso cref="NetBlob"/>
public unsafe struct PacketController : System.IDisposable
{
    // Statics
    public static ACBindings.Internal.PacketController** pcontrol_ = (ACBindings.Internal.PacketController**)0x00846F08;

    // Child Types
    public unsafe struct PacketController_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.PacketController*, ulong> GetNonEphemeralID; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public ACBindings.Internal.ClientNet* net_;
    public ACBindings.Internal.RecipientData** recipients_;
    public fixed byte netQueues__Raw[12 * 4];
    public System.IntPtr* netQueues_ => (System.IntPtr*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref netQueues__Raw[0]);
    public ACBindings.Internal.RecipientData* haveNaks_;
    public ACBindings.Internal.PQueueArray__double__void_ptr FlowControlTimers;
    public double lastEmpty_;
    public ulong m_curNonEphemeralID;
    public fixed byte gap68[4];
    public System.IntPtr m_pSendBlobCallsCounter;

    // Generated Constructor
    public PacketController(ACBindings.Internal.ClientNet* net) {
        _ConstructorInternal(net);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Provides access to the single PacketController instance used throughout the application.
    /// <code>Offset: 0x00541770
    /// PacketController* __cdecl PacketController::Instance()</code>
    /// </summary>
    /// <returns>A pointer to the global PacketController instance.</returns>
    public static ACBindings.Internal.PacketController* Instance() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.PacketController*>)0x00541770)();

    /// <summary>Sets the receive queue entry at the specified index to the provided value and reports success.
    /// <code>Offset: 0x00541780
    /// int __thiscall PacketController::AddReceiveQueue(_DWORD*,unsigned __int16,int)</code>
    /// </summary>
    /// <param name="a2">Index of the receive queue slot to update.</param>
    /// <param name="a3">Value to store in that slot.</param>
    /// <returns>Always 1, indicating successful operation.</returns>
    public int AddReceiveQueue(ushort a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PacketController, ushort, int, int>)0x00541780)(ref this, a2, a3);

    /// <summary>Enqueues a recipient into the internal NAK queue, marking it as queued and inserting it at the head of the controller’s linked list if not already present.
    /// <code>Offset: 0x005417A0
    /// void __thiscall PacketController::EnqueueRecip(PacketController*,RecipientData*)</code>
    /// </summary>
    /// <param name="recip">The RecipientData instance to enqueue.</param>
    public void EnqueueRecip(ACBindings.Internal.RecipientData* recip) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PacketController, ACBindings.Internal.RecipientData*, void>)0x005417A0)(ref this, recip);

    /// <summary>Enqueues a NetBlob for transmission to the specified recipient. If the recipient exists, the blob is added to its queue and the function returns true; otherwise it does nothing and returns false.
    /// <code>Offset: 0x005417D0
    /// bool __thiscall PacketController::SendBlob(PacketController*,NetBlob*,unsigned __int16)</code>
    /// </summary>
    /// <param name="blob">The packet data to be sent.</param>
    /// <param name="recip">Index of the target recipient in the controller's recipients array.</param>
    /// <returns>True if the blob was successfully enqueued for the recipient, or false if no such recipient exists.</returns>
    public byte SendBlob(ACBindings.Internal.NetBlob* blob, ushort recip) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PacketController, ACBindings.Internal.NetBlob*, ushort, byte>)0x005417D0)(ref this, blob, recip);

    /// <summary>Retrieves the RecipientData instance at the specified index within the controller’s recipients array.
    /// <code>Offset: 0x00541800
    /// RecipientData* __thiscall PacketController::GetRecipient(PacketController*,unsigned __int16)</code>
    /// </summary>
    /// <param name="recID">Index of the desired recipient in PacketController::recipients_.</param>
    /// <returns>A pointer to the RecipientData at that position, which may be nullptr if no data is stored there.</returns>
    public ACBindings.Internal.RecipientData* GetRecipient(ushort recID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PacketController, ushort, ACBindings.Internal.RecipientData*>)0x00541800)(ref this, recID);

    /// <summary>Destroys a PacketController instance, freeing all recipient data structures, the recipients array, and flow‑control timer resources. It resets global controller references, decrements the send‑blob call counter, and invokes any pending callback when the counter reaches zero.
    /// <code>Offset: 0x00541920
    /// void __thiscall PacketController::~PacketController(PacketController*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PacketController, void>)0x00541920)(ref this);

    /// <summary>Enqueues an optional packet header into the flow queue of a specified recipient if that recipient exists.
    /// <code>Offset: 0x005419F0
    /// bool __thiscall PacketController::EnqueueOptionalHeader(PacketController*,unsigned __int16,COptionalHeader*)</code>
    /// </summary>
    /// <param name="recID">Index identifying the target recipient within the controller's recipients list.</param>
    /// <param name="pHdr">Header to be added to the recipient's flow queue.</param>
    /// <returns>True when the header was successfully enqueued; otherwise, false if no valid recipient is found.</returns>
    public byte EnqueueOptionalHeader(ushort recID, ACBindings.Internal.COptionalHeader* pHdr) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PacketController, ushort, ACBindings.Internal.COptionalHeader*, byte>)0x005419F0)(ref this, recID, pHdr);

    /// <summary>Processes expired flow‑control timers, marking associated recipients with NAKs when needed, adding them to the pending list, recalculating their next timer values based on elapsed time, and reinserting them into the priority queue.
    /// <code>Offset: 0x00541BD0
    /// void __thiscall PacketController::CheckFlowControlTimers(PacketController*)</code>
    /// </summary>
    public void CheckFlowControlTimers() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PacketController, void>)0x00541BD0)(ref this);

    /// <summary>Processes queued NAKs, removes them from the send list, and updates recipient timers based on flow‑control status.
    /// <code>Offset: 0x00541CB0
    /// void __thiscall PacketController::UseTime(PacketController*)</code>
    /// </summary>
    public void UseTime() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PacketController, void>)0x00541CB0)(ref this);

    /// <summary>Adds a recipient to the controller unless an entry with the same identifier already exists.
    /// <code>Offset: 0x00541D10
    /// int __thiscall PacketController::AddRecipient(PacketController*,unsigned __int16,sockaddr_in,int,float,unsigned int,int)</code>
    /// </summary>
    /// <param name="id">Unique identifier for the new recipient.</param>
    /// <param name="addr">Network address of the recipient.</param>
    /// <param name="noflow">Flag that disables flow control when non‑zero.</param>
    /// <param name="lineNoise">Estimated line‑noise level for the connection.</param>
    /// <param name="gid">Group identifier associated with the recipient.</param>
    /// <param name="fIsAdminConnection">True if the connection is an administrator session; otherwise false.</param>
    /// <returns>1 when a new RecipientData object was created and stored, 0 if a recipient with that ID already existed.</returns>
    public int AddRecipient(ushort id, int addr, int noflow, float lineNoise, uint gid, int fIsAdminConnection) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PacketController, ushort, int, int, float, uint, int, int>)0x00541D10)(ref this, id, addr, noflow, lineNoise, gid, fIsAdminConnection);

    /// <summary>Removes a recipient identified by its 16‑bit ID from flow‑control timers, NAK tracking, and internal structures. If the recipient does not exist, the function performs no action but still reports success.
    /// <code>Offset: 0x00541E80
    /// int __thiscall PacketController::DeleteRecipient(PacketController*,unsigned __int16)</code>
    /// </summary>
    /// <param name="id">The identifier of the recipient to delete.</param>
    /// <returns>1 if the packet controller is active (the operation completes successfully or the recipient was already absent); 0 if the global packet controller reference is missing and deletion cannot proceed.</returns>
    public int DeleteRecipient(ushort id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PacketController, ushort, int>)0x00541E80)(ref this, id);

    /// <summary>Adds a received network packet to the appropriate queue based on its queueID; invalid IDs result in the packet being released without queuing.
    /// <code>Offset: 0x00542070
    /// int __thiscall PacketController::AddReceivedBlobToQueue(PacketController*,NetBlob*)</code>
    /// </summary>
    /// <param name="blob">The NetBlob instance to enqueue; may be null, which causes an immediate return of 0.</param>
    /// <returns>1 if the blob was successfully added to a queue, otherwise 0.</returns>
    public int AddReceivedBlobToQueue(ACBindings.Internal.NetBlob* blob) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PacketController, ACBindings.Internal.NetBlob*, int>)0x00542070)(ref this, blob);

    /// <summary>Initializes a PacketController instance by associating it with a ClientNet object and setting up internal data structures such as recipient lists, flow‑control timers, and performance monitoring counters.
    /// <code>Offset: 0x00542380
    /// void __thiscall PacketController::PacketController(PacketController*,ClientNet*)</code>
    /// </summary>
    /// <param name="net">The ClientNet object that the controller will manage communication for.</param>
    public void _ConstructorInternal(ACBindings.Internal.ClientNet* net) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PacketController, ACBindings.Internal.ClientNet*, void>)0x00542380)(ref this, net);
}

