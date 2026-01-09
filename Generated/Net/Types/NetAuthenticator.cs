namespace ACBindings;

// NetAuthenticator
public unsafe struct NetAuthenticator : System.IDisposable
{
    // Base Classes
    public ACBindings.StreamPackObj BaseClass_StreamPackObj; // ACBindings.StreamPackObj

    // Child Types
    // NetAuthenticator_vtbl
    public unsafe struct NetAuthenticator_vtbl
    {
        // Members
        public System.IntPtr NetAuthenticator_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer
        public System.IntPtr StreamPack; // function pointer

        // Methods
    }
    // NetAuthenticator::CGrowBuffer
    public unsafe struct CGrowBuffer
    {
        // Members
        public byte* m_pBuf;
        public uint m_cbAllocatedSize;
        public uint m_cbCurSize;

        // Methods
        // int __thiscall NetAuthenticator::CGrowBuffer::Grow(NetAuthenticator::CGrowBuffer*,unsigned int)
        public int Grow(uint new_size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.NetAuthenticator.CGrowBuffer, uint, int>)0x00541240)(ref this, new_size);
        // int __thiscall NetAuthenticator::CGrowBuffer::StreamPack(NetAuthenticator::CGrowBuffer*,STREAMTYPE,void**,unsigned int*)
        public int StreamPack(ACBindings.STREAMTYPE op, void** addr, uint* size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.NetAuthenticator.CGrowBuffer, ACBindings.STREAMTYPE, void**, uint*, int>)0x00541430)(ref this, op, addr, size);
    }

    // Members
    public uint m_dwAuthType;
    public uint m_dwAuthFlags;
    public uint m_dwConnectionSequenceNumber;
    public ACBindings.accountID m_Account;
    public ACBindings.accountID m_AccountToLogonAs;
    public ACBindings.NetAuthenticator.CGrowBuffer m_CryptoData;
    public ACBindings.NetAuthenticator.CGrowBuffer m_ExtraData;

    // Generated Constructor
    public NetAuthenticator() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall NetAuthenticator::~NetAuthenticator(NetAuthenticator*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.NetAuthenticator, void>)0x00411E10)(ref this);
    // unsigned int __thiscall NetAuthenticator::GetPackSize(NetAuthenticator*)
    public uint GetPackSize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.NetAuthenticator, uint>)0x00541310)(ref this);
    // void __thiscall NetAuthenticator::NetAuthenticator(NetAuthenticator*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.NetAuthenticator, void>)0x005414A0)(ref this);
    // unsigned int __thiscall NetAuthenticator::Pack(NetAuthenticator*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.NetAuthenticator, void**, uint, uint>)0x00541510)(ref this, addr, size);
    // bool __thiscall NetAuthenticator::SetToAuthType(NetAuthenticator*,unsigned int,const accountID*,unsigned int,const unsigned __int8*)
    public byte SetToAuthType(uint dwAuthType, ACBindings.accountID* Account, uint dwBinaryLen, byte* pData) => ((delegate* unmanaged[Thiscall]<ref ACBindings.NetAuthenticator, uint, ACBindings.accountID*, uint, byte*, byte>)0x00541640)(ref this, dwAuthType, Account, dwBinaryLen, pData);
    // int __thiscall NetAuthenticator::StreamPack(NetAuthenticator*,STREAMTYPE,void**,unsigned int*)
    public int StreamPack(ACBindings.STREAMTYPE op, void** addr, uint* size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.NetAuthenticator, ACBindings.STREAMTYPE, void**, uint*, int>)0x005416C0)(ref this, op, addr, size);
}

