namespace ACBindings.Internal;


/// <summary>Represents a network packet composed of data fragments and optional headers, managing reference counts, priority, recipient ID, checksum calculation, and linked‑list placement within send queues.</summary>
public unsafe struct NetPacket : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.ReferenceCountTemplate BaseClass_ReferenceCountTemplate; // ACBindings.Internal.ReferenceCountTemplate

    // Child Types
    public unsafe struct NetPacket_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.NetPacket*, void> NetPacket_dtor_0; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.NetPacket* next_;
    public fixed byte specialFragList__Raw[32 * 4];
    public ACBindings.Internal.COptionalHeader** specialFragList_ => (ACBindings.Internal.COptionalHeader**)System.Runtime.CompilerServices.Unsafe.AsPointer(ref specialFragList__Raw[0]);
    public uint numSpecialFrags_;
    public fixed byte fragList__Raw[29 * 4];
    public ACBindings.Internal.BlobFrag** fragList_ => (ACBindings.Internal.BlobFrag**)System.Runtime.CompilerServices.Unsafe.AsPointer(ref fragList__Raw[0]);
    public uint numFrags_;
    public ushort recipient_;
    public uint realPriority_;
    public uint size_;
    public uint seqNum_;
    public uint cryptoKey_;
    public uint checksum_;
    public uint flags_;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Creates a new NetPacket instance initialized with default values and assigns the supplied recipient ID.
    /// <code>Offset: 0x00543760
    /// NetPacket* __cdecl NetPacket::CreateForSend(unsigned __int16)</code>
    /// </summary>
    /// <param name="recip">The destination identifier for the packet.</param>
    /// <returns>A pointer to the newly allocated NetPacket, or null if allocation fails.</returns>
    public static ACBindings.Internal.NetPacket* CreateForSend(ushort recip) => ((delegate* unmanaged[Cdecl]<ushort, ACBindings.Internal.NetPacket*>)0x00543760)(recip);

    /// <summary>Destroys a NetPacket instance, releasing all special and regular fragments by decrementing their reference counts and invoking cleanup callbacks when counts reach zero.
    /// <code>Offset: 0x00543800
    /// void __thiscall NetPacket::~NetPacket(NetPacket*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NetPacket, void>)0x00543800)(ref this);

    /// <summary>
    /// Calculates the packet’s checksum by iterating over its special fragments and normal fragment blobs, accumulating each fragment’s CRC32 into checksum_, and clearing an internal flag bit.
    /// 
    /// <code>Offset: 0x00549E10
    /// void __thiscall NetPacket::ComputeChecksum(NetPacket*)</code>
    /// </summary>
    public void ComputeChecksum() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NetPacket, void>)0x00549E10)(ref this);

    /// <summary>Combines all stored special fragment masks and applies them to the supplied protocol header, updating its header_ field when a non‑null header is provided.
    /// <code>Offset: 0x00549ED0
    /// unsigned int __thiscall NetPacket::ApplySpecialFrags(NetPacket*,ProtoHeader*)</code>
    /// </summary>
    /// <param name="pHeader">The protocol header to receive the combined mask; if null, only the mask value is returned.</param>
    /// <returns>The bitwise OR of all special fragment masks contained in this packet.</returns>
    public uint ApplySpecialFrags(ACBindings.Internal.ProtoHeader* pHeader) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NetPacket, ACBindings.Internal.ProtoHeader*, uint>)0x00549ED0)(ref this, pHeader);

    /// <summary>Adds the current packet to the end of a singly-linked packet chain, updating head and tail references accordingly.
    /// <code>Offset: 0x00549F00
    /// void __thiscall NetPacket::AddToTail(NetPacket*,NetPacket**,NetPacket**)</code>
    /// </summary>
    /// <param name="this">The packet to append.</param>
    /// <param name="head">Reference to the list's first packet; may be null if the list is empty.</param>
    /// <param name="tail">Reference to the list's last packet; updated to point to the newly added packet.</param>
    public void AddToTail(ACBindings.Internal.NetPacket** head, ACBindings.Internal.NetPacket** tail) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NetPacket, ACBindings.Internal.NetPacket**, ACBindings.Internal.NetPacket**, void>)0x00549F00)(ref this, head, tail);

    /// <summary>Inserts the packet into a linked‑list queue. If the list is empty, the packet becomes both head and tail; otherwise, if the current head has flag bit 1 set, the packet is inserted after it, else it replaces the head as the new front.
    /// <code>Offset: 0x00549F30
    /// void __thiscall NetPacket::AddToHead(NetPacket*,NetPacket**,NetPacket**)</code>
    /// </summary>
    /// <param name="head">Pointer to the first packet in the list.</param>
    /// <param name="tail">Pointer to the last packet in the list.</param>
    public void AddToHead(ACBindings.Internal.NetPacket** head, ACBindings.Internal.NetPacket** tail) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NetPacket, ACBindings.Internal.NetPacket**, ACBindings.Internal.NetPacket**, void>)0x00549F30)(ref this, head, tail);

    /// <summary>Removes this packet from a singly linked list, linking surrounding nodes and adjusting the list’s head or tail as necessary.
    /// <code>Offset: 0x00549F80
    /// void __thiscall NetPacket::Remove(NetPacket*,NetPacket*,NetPacket**,NetPacket**)</code>
    /// </summary>
    /// <param name="prev">The preceding packet in the list; null if this packet is at the front.</param>
    /// <param name="head">Reference to the pointer that tracks the first packet of the list.</param>
    /// <param name="tail">Reference to the pointer that tracks the last packet of the list.</param>
    public void Remove(ACBindings.Internal.NetPacket* prev, ACBindings.Internal.NetPacket** head, ACBindings.Internal.NetPacket** tail) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NetPacket, ACBindings.Internal.NetPacket*, ACBindings.Internal.NetPacket**, ACBindings.Internal.NetPacket**, void>)0x00549F80)(ref this, prev, head, tail);

    /// <summary>Adds a COptionalHeader to the NetPacket’s list of special fragments, inserting it in order by mask, updating packet size, checksum, and adjusting flag bits accordingly.
    /// <code>Offset: 0x00549FC0
    /// void __thiscall NetPacket::AddOptionalHeader(NetPacket*,COptionalHeader*)</code>
    /// </summary>
    /// <param name="this">The NetPacket instance receiving the optional header.</param>
    /// <param name="frag">The COptionalHeader fragment to add.</param>
    public void AddOptionalHeader(ACBindings.Internal.COptionalHeader* frag) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NetPacket, ACBindings.Internal.COptionalHeader*, void>)0x00549FC0)(ref this, frag);

    /// <summary>Removes optional headers marked as disposable from the packet, adjusting its size, reference counts, and internal lists accordingly.
    /// <code>Offset: 0x0054A070
    /// bool __thiscall NetPacket::RemoveDisposableOptionalHeaders(NetPacket*)</code>
    /// </summary>
    /// <returns>True if any disposable optional headers were removed; otherwise false.</returns>
    public byte RemoveDisposableOptionalHeaders() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NetPacket, byte>)0x0054A070)(ref this);

    /// <summary>Refreshes time-sensitive headers for the packet, processing any special fragments marked as time-sensitive and resetting related flags.
    /// <code>Offset: 0x0054A130
    /// bool __thiscall NetPacket::UpdateTimeSensitiveHeaders(NetPacket*)</code>
    /// </summary>
    /// <returns>True if the update succeeded; this function always returns true.</returns>
    public byte UpdateTimeSensitiveHeaders() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NetPacket, byte>)0x0054A130)(ref this);

    /// <summary>Adds a blob fragment to the packet, updating metadata such as recipient ID, priority, size, checksum, and flags.
    /// <code>Offset: 0x0054A1A0
    /// void __thiscall NetPacket::AddFrag(NetPacket*,BlobFrag*,unsigned __int16,unsigned int)</code>
    /// </summary>
    /// <param name="frag">The fragment to include in the packet.</param>
    /// <param name="recip">Recipient identifier; assigned if the packet has none yet.</param>
    /// <param name="priority">Desired priority level; stored if higher than current value.</param>
    public void AddFrag(ACBindings.Internal.BlobFrag* frag, ushort recip, uint priority) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NetPacket, ACBindings.Internal.BlobFrag*, ushort, uint, void>)0x0054A1A0)(ref this, frag, recip, priority);
}

