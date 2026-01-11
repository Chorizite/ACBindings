namespace ACBindings.Internal;

public unsafe struct NetAuthenticator : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.StreamPackObj BaseClass_StreamPackObj; // ACBindings.Internal.StreamPackObj

    // Child Types
    public unsafe struct NetAuthenticator_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.NetAuthenticator*, void> NetAuthenticator_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.NetAuthenticator*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.NetAuthenticator*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.NetAuthenticator*, void**, uint, int> UnPack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.NetAuthenticator*, ACBindings.Internal.STREAMTYPE, void**, uint*, int> StreamPack; // function pointer

        // Methods
    }
    public unsafe struct CGrowBuffer
    {
        // Members
        public byte* m_pBuf;
        public uint m_cbAllocatedSize;
        public uint m_cbCurSize;

        // Methods

        /// <summary>
        /// <code>Offset: 0x00541240
        /// int __thiscall NetAuthenticator::CGrowBuffer::Grow(NetAuthenticator::CGrowBuffer*,unsigned int)</code>
        /// </summary>
        public int Grow(uint new_size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NetAuthenticator.CGrowBuffer, uint, int>)0x00541240)(ref this, new_size);

        /// <summary>
        /// <code>Offset: 0x00541430
        /// int __thiscall NetAuthenticator::CGrowBuffer::StreamPack(NetAuthenticator::CGrowBuffer*,STREAMTYPE,void**,unsigned int*)</code>
        /// </summary>
        public int StreamPack(ACBindings.Internal.STREAMTYPE op, void** addr, uint* size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NetAuthenticator.CGrowBuffer, ACBindings.Internal.STREAMTYPE, void**, uint*, int>)0x00541430)(ref this, op, addr, size);
    }

    // Members
    public uint m_dwAuthType;
    public uint m_dwAuthFlags;
    public uint m_dwConnectionSequenceNumber;
    public ACBindings.Internal.accountID m_Account;
    public ACBindings.Internal.accountID m_AccountToLogonAs;
    public ACBindings.Internal.NetAuthenticator.CGrowBuffer m_CryptoData;
    public ACBindings.Internal.NetAuthenticator.CGrowBuffer m_ExtraData;

    // Generated Constructor
    public NetAuthenticator() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Releases internal buffers, decrements reference counts of associated account objects, and restores the object’s virtual table to the base PackObj implementation.
    /// <code>Offset: 0x00411E10
    /// void __thiscall NetAuthenticator::~NetAuthenticator(NetAuthenticator*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NetAuthenticator, void>)0x00411E10)(ref this);

    /// <summary>
    /// <code>Offset: 0x00541310
    /// unsigned int __thiscall NetAuthenticator::GetPackSize(NetAuthenticator*)</code>
    /// </summary>
    public uint GetPackSize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NetAuthenticator, uint>)0x00541310)(ref this);

    /// <summary>
    /// <code>Offset: 0x005414A0
    /// void __thiscall NetAuthenticator::NetAuthenticator(NetAuthenticator*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NetAuthenticator, void>)0x005414A0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00541510
    /// unsigned int __thiscall NetAuthenticator::Pack(NetAuthenticator*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NetAuthenticator, void**, uint, uint>)0x00541510)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x00541640
    /// bool __thiscall NetAuthenticator::SetToAuthType(NetAuthenticator*,unsigned int,const accountID*,unsigned int,const unsigned __int8*)</code>
    /// </summary>
    public byte SetToAuthType(uint dwAuthType, ACBindings.Internal.accountID* Account, uint dwBinaryLen, byte* pData) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NetAuthenticator, uint, ACBindings.Internal.accountID*, uint, byte*, byte>)0x00541640)(ref this, dwAuthType, Account, dwBinaryLen, pData);

    /// <summary>
    /// <code>Offset: 0x005416C0
    /// int __thiscall NetAuthenticator::StreamPack(NetAuthenticator*,STREAMTYPE,void**,unsigned int*)</code>
    /// </summary>
    public int StreamPack(ACBindings.Internal.STREAMTYPE op, void** addr, uint* size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NetAuthenticator, ACBindings.Internal.STREAMTYPE, void**, uint*, int>)0x005416C0)(ref this, op, addr, size);
}

