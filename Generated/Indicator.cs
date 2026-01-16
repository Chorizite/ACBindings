namespace ACBindings.Internal;


/// <summary>Manages incoming network data blobs, tracking incomplete fragments and temporary arrivals. Provides functions to accept fragments, maintain hash tables of waiting and arrived blobs, and clean up resources.</summary>
public unsafe struct Indicator : System.IDisposable
{
    // Child Types
    public unsafe struct Indicator_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Indicator*, void> Indicator_dtor_0; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public ACBindings.Internal.UI64Hash___NetBlob waitingBlobs_;
    public ACBindings.Internal.UI64Hash___ArrivedEphInfo arrivedEphBlobs_;
    public ACBindings.Internal.ArrivedEphInfo* firstInfo_;
    public double flushStamp_;

    // Generated Constructor
    public Indicator() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Initializes an Indicator instance by setting up its virtual function table, preparing internal hash tables for waiting and arrived network blobs, and resetting tracking pointers and timestamps.
    /// <code>Offset: 0x0054ADB0
    /// void __thiscall Indicator::Indicator(Indicator*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Indicator, void>)0x0054ADB0)(ref this);

    /// <summary>Adds an ArrivedEphInfo instance to the Indicator's internal collection, inserting it into a hash table keyed by its unique identifier and prepending it to a linked list of received entries.
    /// <code>Offset: 0x0054AED0
    /// void __thiscall Indicator::AddArrivedEphInfo(Indicator*,ArrivedEphInfo*)</code>
    /// </summary>
    /// <param name="info">The ArrivedEphInfo object containing the arrival data to be stored.</param>
    public void AddArrivedEphInfo(ACBindings.Internal.ArrivedEphInfo* info) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Indicator, ACBindings.Internal.ArrivedEphInfo*, void>)0x0054AED0)(ref this, info);

    /// <summary>Determines whether a given temporary network blob identifier has been superseded by a newer one with the same sequence, updating internal tracking accordingly.
    /// <code>Offset: 0x0054AFB0
    /// int __thiscall Indicator::FragIsObsoleteEmphemeral(Indicator*,unsigned __int64)</code>
    /// </summary>
    /// <param name="netBlobID">The identifier of the network blob to evaluate.</param>
    /// <returns>Non-zero if the supplied blob ID is considered obsolete; zero otherwise.</returns>
    public int FragIsObsoleteEmphemeral(ulong netBlobID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Indicator, ulong, int>)0x0054AFB0)(ref this, netBlobID);

    /// <summary>Removes all entries from the waiting blobs collection, releasing associated resources.
    /// <code>Offset: 0x0054B0E0
    /// void __thiscall Indicator::CleanupWaitingBlobs(Indicator*)</code>
    /// </summary>
    public void CleanupWaitingBlobs() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Indicator, void>)0x0054B0E0)(ref this);

    /// <summary>Accepts an incoming fragment of a network blob, adding it to an existing waiting blob or creating a new one if none exists.
    /// <code>Offset: 0x0054B1A0
    /// void __thiscall Indicator::AcceptFrag(Indicator*,BlobFrag*,unsigned __int16)</code>
    /// </summary>
    /// <param name="newFrag">The fragment received from the network.</param>
    /// <param name="sender">Identifier of the source that sent the fragment.</param>
    public void AcceptFrag(ACBindings.Internal.BlobFrag* newFrag, ushort sender) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Indicator, ACBindings.Internal.BlobFrag*, ushort, void>)0x0054B1A0)(ref this, newFrag, sender);

    /// <summary>Destroys an Indicator instance, releasing all allocated blob collections and resetting virtual table pointers.
    /// <code>Offset: 0x0054B2F0
    /// void __thiscall Indicator::~Indicator(Indicator*)</code>
    /// </summary>
    /// <param name="this">Pointer to the Indicator object being destroyed.</param>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Indicator, void>)0x0054B2F0)(ref this);

    /// <summary>Processes all fragments within a received NetPacket, rejecting obsolete ones and forwarding others to AcceptFrag with the originating sender’s identifier.
    /// <code>Offset: 0x0054B340
    /// void __thiscall Indicator::CheckInPacket(Indicator*,const NetPacket*,unsigned __int16)</code>
    /// </summary>
    /// <param name="packet">The incoming packet holding one or more blob fragments.</param>
    /// <param name="sender">Identifier of the packet source used when accepting fragments.</param>
    public void CheckInPacket(ACBindings.Internal.NetPacket* packet, ushort sender) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Indicator, ACBindings.Internal.NetPacket*, ushort, void>)0x0054B340)(ref this, packet, sender);
}

