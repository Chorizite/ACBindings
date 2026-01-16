namespace ACBindings.Internal;


/// <summary>
/// Represents a fragment of a network blob, linking payload data to its parent NetBlob and tracking sequence order through header information. Manages reference counts for shared ownership and provides access to the next fragment in the chain.
/// </summary>
public unsafe struct BlobFrag
{
    // Base Classes
    public ACBindings.Internal.ReferenceCountTemplate BaseClass_ReferenceCountTemplate; // ACBindings.Internal.ReferenceCountTemplate

    // Child Types
    public unsafe struct BlobFrag_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.BlobFrag*, void> BlobFrag_dtor_0; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.BlobFrag* blobNextFrag_;
    public ACBindings.Internal.BlobFragHeader_t* hdrWrite_;
    public ACBindings.Internal.BlobFragHeader_t* hdrRead_;
    public ACBindings.Internal.BlobFragHeader_t memberHeader_;
    public byte* dat_;
    public ACBindings.Internal.NetBlob* myBlob_;

    // Generated Constructor
    public BlobFrag(ACBindings.Internal.NetBlob* myBlob, uint blobNum, uint cTotalBlobs, byte* dat, uint size) {
        _ConstructorInternal(myBlob, blobNum, cTotalBlobs, dat, size);
    }
    public BlobFrag(byte* pbData, uint cbSize, uint* cbUsed) {
        _ConstructorInternal(pbData, cbSize, cbUsed);
    }

    // Methods

    /// <summary>Constructs a BlobFrag instance linked to a NetBlob, initializing reference counts and header information for a fragment of a blob transmission.
    /// <code>Offset: 0x0054A250
    /// void __thiscall BlobFrag::BlobFrag(BlobFrag*,NetBlob*,unsigned int,unsigned int,unsigned __int8*,unsigned int)</code>
    /// </summary>
    /// <param name="myBlob">The NetBlob owning this fragment.</param>
    /// <param name="blobNum">The sequence number of this fragment within the blob.</param>
    /// <param name="cTotalBlobs">The total number of fragments that make up the complete blob.</param>
    /// <param name="dat">Pointer to the payload data for this fragment.</param>
    /// <param name="size">Size, in bytes, of the payload data.</param>
    public void _ConstructorInternal(ACBindings.Internal.NetBlob* myBlob, uint blobNum, uint cTotalBlobs, byte* dat, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BlobFrag, ACBindings.Internal.NetBlob*, uint, uint, byte*, uint, void>)0x0054A250)(ref this, myBlob, blobNum, cTotalBlobs, dat, size);

    /// <summary>Initializes a BlobFrag instance from raw data, validating the fragment header size against bounds and setting internal pointers accordingly.
    /// <code>Offset: 0x0054A320
    /// void __thiscall BlobFrag::BlobFrag(BlobFrag*,const unsigned __int8*,unsigned int,unsigned int*)</code>
    /// </summary>
    /// <param name="pbData">Pointer to the input byte buffer containing the blob fragment header followed by payload.</param>
    /// <param name="cbSize">Total size of the supplied buffer in bytes.</param>
    /// <param name="cbUsed">Receives the number of bytes consumed from the buffer when a valid fragment is detected; set to zero otherwise.</param>
    public void _ConstructorInternal(byte* pbData, uint cbSize, uint* cbUsed) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BlobFrag, byte*, uint, uint*, void>)0x0054A320)(ref this, pbData, cbSize, cbUsed);

    /// <summary>Creates a new blob fragment for transmission and associates it with the given NetBlob.
    /// <code>Offset: 0x0054A380
    /// BlobFrag* __cdecl BlobFrag::CreateForSend(NetBlob*,unsigned int,unsigned int,unsigned __int8*,unsigned int)</code>
    /// </summary>
    /// <param name="myBlob">The parent NetBlob that owns the data being sent.</param>
    /// <param name="blobNum">Index of this fragment within the sequence.</param>
    /// <param name="cTotalBlobs">Total number of fragments composing the complete message.</param>
    /// <param name="dat">Pointer to the raw data segment for this fragment.</param>
    /// <param name="size">Size, in bytes, of the data segment pointed to by dat.</param>
    /// <returns>Pointer to the newly allocated BlobFrag instance, or null if memory allocation fails.</returns>
    public static ACBindings.Internal.BlobFrag* CreateForSend(ACBindings.Internal.NetBlob* myBlob, uint blobNum, uint cTotalBlobs, byte* dat, uint size) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.NetBlob*, uint, uint, byte*, uint, ACBindings.Internal.BlobFrag*>)0x0054A380)(myBlob, blobNum, cTotalBlobs, dat, size);

    /// <summary>Creates a new BlobFrag by consuming data from the provided CBufferIterator. If no bytes are consumed, releases the allocated object and returns null.
    /// <code>Offset: 0x0054A3C0
    /// BlobFrag* __cdecl BlobFrag::CreateForRecv(CBufferIterator*)</code>
    /// </summary>
    /// <param name="Buf">The buffer iterator to read fragment data from.</param>
    /// <returns>A pointer to the constructed BlobFrag if successful; otherwise null.</returns>
    public static ACBindings.Internal.BlobFrag* CreateForRecv(ACBindings.Internal.CBufferIterator* Buf) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CBufferIterator*, ACBindings.Internal.BlobFrag*>)0x0054A3C0)(Buf);
}

