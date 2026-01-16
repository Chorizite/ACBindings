namespace ACBindings.Internal;


/// <summary>
/// Maintains the state and flow control for a network recipient, tracking timestamps, queued blobs, packet dependencies, and flush counters.
/// </summary>
public unsafe struct RecipientData : System.IDisposable
{
    // Members
    public double lastTouched_;
    public double timeAllocated_;
    public ACBindings.Internal.ConnectionState m_ConnectionState;
    public ACBindings.Internal.NIList___NetBlob_ptr waitingBlobs_;
    public ACBindings.Internal.ClientFlowQueue flowQueue_;
    public ACBindings.Internal.RecipientData* next_;
    public ushort recID_;
    public int onQueue_;
    public ACBindings.Internal.Indicator* dependencies_;
    public uint gidPlayer_;
    public uint flushNum_;

    // Generated Constructor
    public RecipientData(ushort recID, int addr, int noflow, float lineNoise) {
        _ConstructorInternal(recID, addr, noflow, lineNoise);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Records the current real time in the recipient data's lastTouched_ field, marking when it was most recently accessed.
    /// <code>Offset: 0x00547990
    /// void __thiscall RecipientData::TouchConnection(RecipientData*)</code>
    /// </summary>
    public void TouchConnection() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RecipientData, void>)0x00547990)(ref this);

    /// <summary>Notifies dependent components that a specific packet has been received by this recipient.
    /// <code>Offset: 0x005479B0
    /// int __thiscall RecipientData::IndicateReceivedPacket(RecipientData*,const NetPacket*,unsigned int)</code>
    /// </summary>
    /// <param name="pPacket">The packet that was processed and marked as received.</param>
    /// <param name="priority">The priority of the packet; currently unused in this implementation.</param>
    /// <returns>Always returns 1 to indicate successful indication.</returns>
    public int IndicateReceivedPacket(ACBindings.Internal.NetPacket* pPacket, uint priority) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RecipientData, ACBindings.Internal.NetPacket*, uint, int>)0x005479B0)(ref this, pPacket, priority);

    /// <summary>Adds a NetBlob to the recipient's flow queue and ensures the recipient is registered with the packet controller for further handling.
    /// <code>Offset: 0x005479E0
    /// void __thiscall RecipientData::EnqueueBlob(RecipientData*,NetBlob*)</code>
    /// </summary>
    /// <param name="newGuy">The network blob to enqueue into the recipient's flow queue.</param>
    public void EnqueueBlob(ACBindings.Internal.NetBlob* newGuy) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RecipientData, ACBindings.Internal.NetBlob*, void>)0x005479E0)(ref this, newGuy);

    /// <summary>Performs maintenance on a recipient’s flow queue and dependency information: empties the queue, flushes pending packets if necessary, and removes timed‑out ArrivedEphInfo entries older than five seconds.
    /// <code>Offset: 0x00547A00
    /// void __thiscall RecipientData::UseTime(RecipientData*)</code>
    /// </summary>
    public void UseTime() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RecipientData, void>)0x00547A00)(ref this);

    /// <summary>Initializes a RecipientData instance with network information and flow control settings.
    /// <code>Offset: 0x00547A40
    /// void __thiscall RecipientData::RecipientData(RecipientData*,unsigned __int16,sockaddr_in,int,float)</code>
    /// </summary>
    /// <param name="recID">Unique identifier for the recipient.</param>
    /// <param name="addr">Socket address of the recipient.</param>
    /// <param name="noflow">Flag reserved for future flow‑control options; currently unused.</param>
    /// <param name="lineNoise">Initial line noise level applied to the flow queue.</param>
    public void _ConstructorInternal(ushort recID, int addr, int noflow, float lineNoise) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RecipientData, ushort, int, int, float, void>)0x00547A40)(ref this, recID, addr, noflow, lineNoise);

    /// <summary>Destroys a RecipientData instance, releasing all owned resources such as pending blobs, the flow queue, dependency indicators, and the client flow queue.
    /// <code>Offset: 0x00547B00
    /// void __thiscall RecipientData::~RecipientData(RecipientData*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RecipientData, void>)0x00547B00)(ref this);

    /// <summary>Updates the internal flush counter to a newer value when the supplied number represents progress beyond the current counter, correctly handling unsigned wrap‑around by treating differences larger than INT_MAX as negative.
    /// <code>Offset: 0x00547B90
    /// void __thiscall RecipientData::QueueFlush(RecipientData*,unsigned int)</code>
    /// </summary>
    /// <param name="num">The candidate new flush number; only assigned if it is considered newer than the existing value according to modular arithmetic rules.</param>
    public void QueueFlush(uint num) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RecipientData, uint, void>)0x00547B90)(ref this, num);

    /// <summary>Processes a batch of NACKed packet sequence numbers by acknowledging them in the flow queue and updating the recipient’s flush number as needed.
    /// <code>Offset: 0x00547BD0
    /// void __thiscall RecipientData::ProcessNaks(RecipientData*,int,const unsigned int*)</code>
    /// </summary>
    /// <param name="numNaks">Number of sequence IDs being processed.</param>
    /// <param name="seqIDs">Pointer to an array of sequence identifiers that were negatively acknowledged.</param>
    public void ProcessNaks(int numNaks, uint* seqIDs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RecipientData, int, uint*, void>)0x00547BD0)(ref this, numNaks, seqIDs);
}

