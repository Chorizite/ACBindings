namespace ACBindings.Internal;


/// <summary>Maintains a collection of sent packets and a lookup table of network‑blob identifiers, enabling packet acknowledgment, cleanup, and reference management within the networking layer.</summary>
/// <remarks>Supports adding, querying, flushing, and erasing entries to manage packet lifecycle efficiently.</remarks>
public unsafe struct SentPacketStore : System.IDisposable
{
    // Members
    public ACBindings.Internal.NIList___NetPacket_ptr m_sentPacketList;
    public ACBindings.Internal.HashTable__ulong__ulong m_sentNetBlobIDInfo;

    // Generated Constructor
    public SentPacketStore() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Checks whether a packet with the specified sequence ID exists in the store.
    /// <code>Offset: 0x0054B400
    /// int __thiscall SentPacketStore::Contains(SentPacketStore*,unsigned int)</code>
    /// </summary>
    /// <param name="seqID">The sequence identifier to search for.</param>
    /// <returns>Nonzero if a matching packet is found; zero otherwise.</returns>
    public int Contains(uint seqID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SentPacketStore, uint, int>)0x0054B400)(ref this, seqID);

    /// <summary>Finds the packet in the store that matches the given sequence number, increments its reference count, and returns it; otherwise returns null.
    /// <code>Offset: 0x0054B430
    /// NetPacket* __thiscall SentPacketStore::GenerateAck(SentPacketStore*,unsigned int)</code>
    /// </summary>
    /// <param name="seqID">The sequence identifier of the packet to locate.</param>
    /// <returns>A pointer to the matching NetPacket with an incremented reference count, or null if no packet is found.</returns>
    public ACBindings.Internal.NetPacket* GenerateAck(uint seqID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SentPacketStore, uint, ACBindings.Internal.NetPacket*>)0x0054B430)(ref this, seqID);

    /// <summary>Initializes the sent packet store by clearing its packet list and setting up the hash table that tracks sent network blob identifiers.
    /// <code>Offset: 0x0054B690
    /// void __thiscall SentPacketStore::SentPacketStore(SentPacketStore*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SentPacketStore, void>)0x0054B690)(ref this);

    /// <summary>Destroys the SentPacketStore instance by freeing all stored packets and clearing internal hash table data.
    /// <code>Offset: 0x0054B6C0
    /// void __thiscall SentPacketStore::~SentPacketStore(SentPacketStore*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SentPacketStore, void>)0x0054B6C0)(ref this);

    /// <summary>Adds a sent network packet to the store, incrementing its reference count, appending it to the internal packet list, removing disposable optional headers, and updating blob‑ID metadata for applicable fragments.
    /// <code>Offset: 0x0054B710
    /// int __thiscall SentPacketStore::AddSentPacket(SentPacketStore*,NetPacket*)</code>
    /// </summary>
    /// <param name="packet">The packet to add; its reference count is increased and it will be stored in the packet list.</param>
    /// <returns>1 on success (this implementation always returns 1).</returns>
    public int AddSentPacket(ACBindings.Internal.NetPacket* packet) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SentPacketStore, ACBindings.Internal.NetPacket*, int>)0x0054B710)(ref this, packet);

    /// <summary>Erases an entry from the store's net‑blob ID table for a given identifier, provided the identifier has its Ephemeral flag set and the corresponding sequence exists in the table.
    /// <code>Offset: 0x0054B860
    /// void __thiscall SentPacketStore::EraseNetBlobID(SentPacketStore*,unsigned __int64)</code>
    /// </summary>
    /// <param name="id">The 64‑bit network blob identifier to remove. The function acts only on identifiers whose Ephemeral flag is set; otherwise it does nothing.</param>
    public void EraseNetBlobID(ulong id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SentPacketStore, ulong, void>)0x0054B860)(ref this, id);

    /// <summary>Removes sent packets older than a specified packet identifier or all packets when requested. Cleans up associated net‑blob references and decrements reference counts, freeing memory if necessary.
    /// <code>Offset: 0x0054B8E0
    /// int __thiscall SentPacketStore::Flush(SentPacketStore*,unsigned int,int)</code>
    /// </summary>
    /// <param name="highest">Packet identifier threshold; packets with identifiers less than this value are removed.</param>
    /// <param name="everything">When non‑zero, removes every packet in the store regardless of its identifier.</param>
    /// <returns>Always returns 1 to indicate successful completion.</returns>
    public int Flush(uint highest, int everything) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SentPacketStore, uint, int, int>)0x0054B8E0)(ref this, highest, everything);
}

