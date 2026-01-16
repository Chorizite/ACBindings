namespace ACBindings.Internal;


/// <summary>Encapsulates raw payloads for network transmission, managing fragmentation, priority, and state transitions.</summary>
public unsafe struct NetBlob
{
    // Base Classes
    public ACBindings.Internal.ReferenceCountTemplate BaseClass_ReferenceCountTemplate; // ACBindings.Internal.ReferenceCountTemplate
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj
    public ACBindings.Internal.UI64HashData BaseClass_UI64HashData; // ACBindings.Internal.UI64HashData

    // Child Types
    public unsafe struct NetBlob_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.NetBlob*, void> NetBlob_dtor_0; // function pointer

        // Methods
    }
    // NetBlob::State
    public enum State : uint
    {
        NETBLOB_FROZEN = 0x0,
        NETBLOB_SENDING = 0x1,
        NETBLOB_RECEIVING = 0x2,
        NETBLOB_RECEIVED = 0x3,
        NETBLOB_FRAGMENTED = 0x4,
        FORCE_State_32_BIT = 0x7FFFFFFF
    }

    // Members
    public ACBindings.Internal.NetBlob.State state_;
    public byte* buf_;
    public uint bufSize_;
    public uint cMaxFragments_;
    public uint numFragments_;
    public ushort sender_;
    public ushort queueID_;
    public uint priority_;
    public ACBindings.Internal.NetBlob* waitNext_;
    public ulong savedNetBlobID_;

    // Generated Constructor
    public NetBlob(byte* buf, uint bufSize, short queue) {
        _ConstructorInternal(buf, bufSize, queue);
    }

    // Methods

    /// <summary>Accepts a fragment of a network data blob, appending its payload to an internal buffer and updating state. If this is the first fragment received, initializes metadata and allocates storage based on total fragments.
    /// <code>Offset: 0x0054A580
    /// void __thiscall NetBlob::ReceiveAddFragment(NetBlob*,BlobFrag*)</code>
    /// </summary>
    /// <param name="frag">Fragment containing header and data to be appended to the blob.</param>
    public void ReceiveAddFragment(ACBindings.Internal.BlobFrag* frag) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NetBlob, ACBindings.Internal.BlobFrag*, void>)0x0054A580)(ref this, frag);

    /// <summary>Updates the NetBlob instance’s state to NETBLOB_RECEIVED, signalling that the blob has been received and is ready for subsequent processing.
    /// <code>Offset: 0x0054A690
    /// void __thiscall NetBlob::ReceiveBlobReady(NetBlob*)</code>
    /// </summary>
    public void ReceiveBlobReady() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NetBlob, void>)0x0054A690)(ref this);

    /// <summary>
    /// Sends the blob to a specified recipient with an optional priority level.
    /// 
    /// <code>Offset: 0x0054A6A0
    /// bool __thiscall NetBlob::Send(NetBlob*,unsigned __int16,unsigned int)</code>
    /// </summary>
    /// <param name="recip">The identifier of the intended recipient.</param>
    /// <param name="priority">The desired priority; special value –842150451 defaults to 1.</param>
    /// <returns>True if the blob was queued for transmission; otherwise, false.</returns>
    public byte Send(ushort recip, uint priority) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NetBlob, ushort, uint, byte>)0x0054A6A0)(ref this, recip, priority);

    /// <summary>Initializes a NetBlob instance from raw data, setting its buffer, size, queue identifier and computing the maximum number of fragments based on the payload length.
    /// <code>Offset: 0x0054A6F0
    /// void __thiscall NetBlob::NetBlob(NetBlob*,unsigned __int8*,unsigned int,__int16)</code>
    /// </summary>
    /// <param name="buf">Pointer to the raw byte buffer representing the network payload.</param>
    /// <param name="bufSize">Total size in bytes of the supplied buffer.</param>
    /// <param name="queue">Identifier for the queue to which this blob belongs.</param>
    public void _ConstructorInternal(byte* buf, uint bufSize, short queue) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NetBlob, byte*, uint, short, void>)0x0054A6F0)(ref this, buf, bufSize, queue);

    /// <summary>Calculates the total packet size of this NetBlob instance based on its current state.
    /// <code>Offset: 0x0054A790
    /// unsigned int __thiscall NetBlob::GetPackSize(NetBlob*)</code>
    /// </summary>
    /// <returns>The packet size in bytes, equal to the value of the internal state_ member plus a fixed offset of 40.</returns>
    public uint GetPackSize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NetBlob, uint>)0x0054A790)(ref this);

    /// <summary>Divides the NetBlob buffer into fixed-size fragments, creates BlobFrag objects for each segment, and links them in a singly linked list. The first fragment is returned via the supplied pointer. Sets the blob state to fragmented before processing.
    /// <code>Offset: 0x0054A850
    /// unsigned int __thiscall NetBlob::Fragmentize(NetBlob*,BlobFrag**)</code>
    /// </summary>
    /// <param name="ppCurFragment">Pointer to receive the head of the newly created fragment list.</param>
    /// <returns>The number of fragments generated from the buffer.</returns>
    public uint Fragmentize(ACBindings.Internal.BlobFrag** ppCurFragment) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NetBlob, ACBindings.Internal.BlobFrag**, uint>)0x0054A850)(ref this, ppCurFragment);

    /// <summary>Encodes the NetBlob into a contiguous memory block for transmission.
    /// <code>Offset: 0x0054A900
    /// unsigned int __thiscall NetBlob::Pack(NetBlob*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to a pointer that references the destination buffer; updated as data is written.</param>
    /// <param name="size">Number of bytes available in the destination buffer; packing occurs only if this value is sufficient.</param>
    /// <returns>Required number of bytes to represent the NetBlob (state_ + 40). If size is less than this value, no data is written but the required size is still returned.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NetBlob, void**, uint, uint>)0x0054A900)(ref this, addr, size);

    /// <summary>Unpacks a NetBlob from a serialized byte stream, initializing the object's fields and allocating memory for its payload.
    /// <code>Offset: 0x0054A9D0
    /// int __thiscall NetBlob::UnPack(NetBlob*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current read position; will be advanced as data is consumed.</param>
    /// <param name="size">Size of the remaining buffer (unused by this implementation).</param>
    /// <returns>Always returns 1 to indicate successful unpacking.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NetBlob, void**, uint, int>)0x0054A9D0)(ref this, addr, size);
}

