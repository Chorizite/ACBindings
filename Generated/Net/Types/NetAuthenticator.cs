namespace ACBindings.Internal;


/// <summary>
/// Handles authentication state for a network connection, storing account identifiers, flags, sequence numbers, and optional cryptographic data, and providing packing and unpacking functionality for packet transmission.
/// </summary>
public unsafe struct NetAuthenticator : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.StreamPackObj BaseClass_StreamPackObj; // ACBindings.Internal.StreamPackObj

    // Child Types
    public unsafe struct NetAuthenticator_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.NetAuthenticator*, void> NetAuthenticator_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.NetAuthenticator*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.NetAuthenticator*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.NetAuthenticator*, void**, uint, int> UnPack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.NetAuthenticator*, ACBindings.Internal.STREAMTYPE, void**, uint*, int> StreamPack; // function pointer

        // Methods
    }

    /// <summary>Dynamic byte buffer used by NetAuthenticator to hold authentication data, automatically expanding as needed during pack/unpack operations.</summary>
    public unsafe struct CGrowBuffer
    {
        // Members
        public byte* m_pBuf;
        public uint m_cbAllocatedSize;
        public uint m_cbCurSize;

        // Methods

        /// <summary>Resizes the growable buffer to at least the specified size, reallocating memory if necessary.
        /// <code>Offset: 0x00541240
        /// int __thiscall NetAuthenticator::CGrowBuffer::Grow(NetAuthenticator::CGrowBuffer*,unsigned int)</code>
        /// </summary>
        /// <param name="new_size">Desired total allocation size for the buffer in bytes.</param>
        /// <returns>Non‑zero when the buffer has been successfully resized or already large enough; zero on failure to allocate new memory.</returns>
        public int Grow(uint new_size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NetAuthenticator.CGrowBuffer, uint, int>)0x00541240)(ref this, new_size);

        /// <summary>Streams data into or out of a growable buffer according to the specified operation type, growing the internal buffer when unpacking if necessary.
        /// <code>Offset: 0x00541430
        /// int __thiscall NetAuthenticator::CGrowBuffer::StreamPack(NetAuthenticator::CGrowBuffer*,STREAMTYPE,void**,unsigned int*)</code>
        /// </summary>
        /// <param name="op">Operation mode (pack or unpack) determining how data is handled.</param>
        /// <param name="addr">Pointer to the data buffer used for packing or receiving unpacked data.</param>
        /// <param name="size">Size of the data to pack; on unpack it receives the number of bytes written into the growable buffer.</param>
        /// <returns>Non‑zero if the stream operation succeeds; zero on failure, such as an insufficient buffer size or invalid parameters.</returns>
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

    /// <summary>Computes and returns the size, in bytes, of the authentication packet associated with this NetAuthenticator instance.
    /// <code>Offset: 0x00541310
    /// unsigned int __thiscall NetAuthenticator::GetPackSize(NetAuthenticator*)</code>
    /// </summary>
    /// <returns>An unsigned integer representing the packet's byte length.</returns>
    public uint GetPackSize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NetAuthenticator, uint>)0x00541310)(ref this);

    /// <summary>Initializes a new NetAuthenticator instance, setting authentication parameters, account information, and cryptographic buffers to their default values.
    /// <code>Offset: 0x005414A0
    /// void __thiscall NetAuthenticator::NetAuthenticator(NetAuthenticator*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NetAuthenticator, void>)0x005414A0)(ref this);

    /// <summary>Packs the NetAuthenticator instance into a memory buffer. If no destination buffer is supplied, returns the required pack size in bytes.
    /// <code>Offset: 0x00541510
    /// unsigned int __thiscall NetAuthenticator::Pack(NetAuthenticator*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the buffer where packed data will be written. May be null to query the needed size.</param>
    /// <param name="size">Size of the provided buffer or maximum number of bytes that may be written.</param>
    /// <returns>Number of bytes written into the buffer, or the required pack size if addr is null.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NetAuthenticator, void**, uint, uint>)0x00541510)(ref this, addr, size);

    /// <summary>Sets the authenticator's authentication type and stores account information along with optional binary data for use during authentication.
    /// <code>Offset: 0x00541640
    /// bool __thiscall NetAuthenticator::SetToAuthType(NetAuthenticator*,unsigned int,const accountID*,unsigned int,const unsigned __int8*)</code>
    /// </summary>
    /// <param name="this">The NetAuthenticator instance being configured.</param>
    /// <param name="dwAuthType">Identifier of the desired authentication method.</param>
    /// <param name="Account">Pointer to an accountID structure containing user identification and expansion flags.</param>
    /// <param name="dwBinaryLen">Length, in bytes, of the optional binary data pointed to by pData.</param>
    /// <param name="pData">Optional binary payload that is copied into the authenticator's internal buffer if non‑null.</param>
    /// <returns>True after successfully updating the authenticator; always returns true for this implementation.</returns>
    public byte SetToAuthType(uint dwAuthType, ACBindings.Internal.accountID* Account, uint dwBinaryLen, byte* pData) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NetAuthenticator, uint, ACBindings.Internal.accountID*, uint, byte*, byte>)0x00541640)(ref this, dwAuthType, Account, dwBinaryLen, pData);

    /// <summary>Serializes or deserializes the authenticator’s state—including authentication type, flags, sequence number, account identifiers, optional logon‑as account, cryptographic data, and any extra data—into or from a stream.
    /// <code>Offset: 0x005416C0
    /// int __thiscall NetAuthenticator::StreamPack(NetAuthenticator*,STREAMTYPE,void**,unsigned int*)</code>
    /// </summary>
    /// <param name="op">Specifies whether to pack (serialize) or unpack (deserialize) the data.</param>
    /// <param name="addr">Pointer to the buffer location used for streaming.</param>
    /// <param name="size">Pointer to the size of the buffer; updated during packing/unpacking.</param>
    /// <returns>Non‑zero if all fields were successfully streamed; otherwise zero.</returns>
    public int StreamPack(ACBindings.Internal.STREAMTYPE op, void** addr, uint* size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NetAuthenticator, ACBindings.Internal.STREAMTYPE, void**, uint*, int>)0x005416C0)(ref this, op, addr, size);
}

