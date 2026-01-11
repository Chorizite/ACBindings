namespace ACBindings.Internal;

public unsafe struct BlobFrag
{
    // Base Classes
    public ACBindings.Internal.ReferenceCountTemplate BaseClass_ReferenceCountTemplate; // ACBindings.Internal.ReferenceCountTemplate

    // Child Types
    public unsafe struct BlobFrag_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.BlobFrag*, void> BlobFrag_dtor_0; // function pointer

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

    /// <summary>
    /// <code>Offset: 0x0054A250
    /// void __thiscall BlobFrag::BlobFrag(BlobFrag*,NetBlob*,unsigned int,unsigned int,unsigned __int8*,unsigned int)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.NetBlob* myBlob, uint blobNum, uint cTotalBlobs, byte* dat, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BlobFrag, ACBindings.Internal.NetBlob*, uint, uint, byte*, uint, void>)0x0054A250)(ref this, myBlob, blobNum, cTotalBlobs, dat, size);

    /// <summary>
    /// <code>Offset: 0x0054A320
    /// void __thiscall BlobFrag::BlobFrag(BlobFrag*,const unsigned __int8*,unsigned int,unsigned int*)</code>
    /// </summary>
    public void _ConstructorInternal(byte* pbData, uint cbSize, uint* cbUsed) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BlobFrag, byte*, uint, uint*, void>)0x0054A320)(ref this, pbData, cbSize, cbUsed);

    /// <summary>
    /// <code>Offset: 0x0054A380
    /// BlobFrag* __cdecl BlobFrag::CreateForSend(NetBlob*,unsigned int,unsigned int,unsigned __int8*,unsigned int)</code>
    /// </summary>
    public static ACBindings.Internal.BlobFrag* CreateForSend(ACBindings.Internal.NetBlob* myBlob, uint blobNum, uint cTotalBlobs, byte* dat, uint size) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.NetBlob*, uint, uint, byte*, uint, ACBindings.Internal.BlobFrag*>)0x0054A380)(myBlob, blobNum, cTotalBlobs, dat, size);

    /// <summary>
    /// <code>Offset: 0x0054A3C0
    /// BlobFrag* __cdecl BlobFrag::CreateForRecv(CBufferIterator*)</code>
    /// </summary>
    public static ACBindings.Internal.BlobFrag* CreateForRecv(ACBindings.Internal.CBufferIterator* Buf) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CBufferIterator*, ACBindings.Internal.BlobFrag*>)0x0054A3C0)(Buf);
}

