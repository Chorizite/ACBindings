namespace ACBindings;

// BlobFrag
public unsafe struct BlobFrag
{
    // Base Classes
    public ACBindings.ReferenceCountTemplate BaseClass_ReferenceCountTemplate; // ACBindings.ReferenceCountTemplate

    // Child Types
    // BlobFrag_vtbl
    public unsafe struct BlobFrag_vtbl
    {
        // Members
        public System.IntPtr BlobFrag_dtor_0; // function pointer

        // Methods
    }

    // Members
    public ACBindings.BlobFrag* blobNextFrag_;
    public ACBindings.BlobFragHeader_t* hdrWrite_;
    public ACBindings.BlobFragHeader_t* hdrRead_;
    public ACBindings.BlobFragHeader_t memberHeader_;
    public byte* dat_;
    public ACBindings.NetBlob* myBlob_;

    // Generated Constructor
    public BlobFrag(ACBindings.NetBlob* myBlob, uint blobNum, uint cTotalBlobs, byte* dat, uint size) {
        _ConstructorInternal(myBlob, blobNum, cTotalBlobs, dat, size);
    }
    public BlobFrag(byte* pbData, uint cbSize, uint* cbUsed) {
        _ConstructorInternal(pbData, cbSize, cbUsed);
    }

    // Methods
    // void __thiscall BlobFrag::BlobFrag(BlobFrag*,NetBlob*,unsigned int,unsigned int,unsigned __int8*,unsigned int)
    public void _ConstructorInternal(ACBindings.NetBlob* myBlob, uint blobNum, uint cTotalBlobs, byte* dat, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BlobFrag, ACBindings.NetBlob*, uint, uint, byte*, uint, void>)0x0054A250)(ref this, myBlob, blobNum, cTotalBlobs, dat, size);
    // void __thiscall BlobFrag::BlobFrag(BlobFrag*,const unsigned __int8*,unsigned int,unsigned int*)
    public void _ConstructorInternal(byte* pbData, uint cbSize, uint* cbUsed) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BlobFrag, byte*, uint, uint*, void>)0x0054A320)(ref this, pbData, cbSize, cbUsed);
    // BlobFrag* __cdecl BlobFrag::CreateForSend(NetBlob*,unsigned int,unsigned int,unsigned __int8*,unsigned int)
    public static ACBindings.BlobFrag* CreateForSend(ACBindings.NetBlob* myBlob, uint blobNum, uint cTotalBlobs, byte* dat, uint size) => ((delegate* unmanaged[Cdecl]<ACBindings.NetBlob*, uint, uint, byte*, uint, ACBindings.BlobFrag*>)0x0054A380)(myBlob, blobNum, cTotalBlobs, dat, size);
    // BlobFrag* __cdecl BlobFrag::CreateForRecv(CBufferIterator*)
    public static ACBindings.BlobFrag* CreateForRecv(ACBindings.CBufferIterator* Buf) => ((delegate* unmanaged[Cdecl]<ACBindings.CBufferIterator*, ACBindings.BlobFrag*>)0x0054A3C0)(Buf);
}

