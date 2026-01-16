namespace ACBindings.Internal;


/// <summary>
///   Holds authentication packet contents and associated metadata for logon exchanges, storing both raw packed data and parsed client‑version information.
/// </summary>
public unsafe struct CLogonHeader
{
    // Base Classes
    public ACBindings.Internal.COptionalHeader BaseClass_COptionalHeader; // ACBindings.Internal.COptionalHeader

    // Child Types
    public unsafe struct CLogonHeader_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CLogonHeader*, void> CLogonHeader_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CLogonHeader*, int> UpdateTimeSensitivePayload; // function pointer

        // Methods
    }

    /// <summary>Captures the client-side handshake payload sent over the network, containing the software version string and authentication data length used during logon negotiation.</summary>
    public unsafe struct HandshakeWireData : System.IDisposable
    {
        // Members
        public ACBindings.Internal.AC1Legacy.PStringBase__sbyte ClientVersion;
        public uint cbAuthData;

        // Generated Dispose
        public void Dispose() {
            _DestructorInternal();
        }

        // Methods

        /// <summary>Releases resources held by a HandshakeWireData object, decrementing the reference count of its ClientVersion buffer and freeing it when the count reaches zero.
        /// <code>Offset: 0x005ABB30
        /// void __thiscall CLogonHeader::HandshakeWireData::~HandshakeWireData(CLogonHeader::HandshakeWireData*)</code>
        /// </summary>
        /// <param name="this">The HandshakeWireData instance being destroyed.</param>
        public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLogonHeader.HandshakeWireData, void>)0x005ABB30)(ref this);
    }

    // Members
    public ACBindings.Internal.CLogonHeader.HandshakeWireData m_UnpackedData;
    public fixed byte m_PackedData[65504];

    // Generated Constructor
    public CLogonHeader(uint cbPackedData) {
        _ConstructorInternal(cbPackedData);
    }
    public CLogonHeader(byte* pRecvBuf, uint cbRecvBuf) {
        _ConstructorInternal(pRecvBuf, cbRecvBuf);
    }

    // Methods

    /// <summary>Initializes a CLogonHeader instance by configuring its optional header, assigning the specified packed data length, setting up client version string storage, and incrementing a global reference counter.
    /// <code>Offset: 0x005AC2D0
    /// void __thiscall CLogonHeader::CLogonHeader(CLogonHeader*,unsigned int)</code>
    /// </summary>
    /// <param name="cbPackedData">The size of the packed data buffer to associate with this logon header.</param>
    public void _ConstructorInternal(uint cbPackedData) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLogonHeader, uint, void>)0x005AC2D0)(ref this, cbPackedData);

    /// <summary>Initializes a logon header from received data by configuring optional header metadata and preparing unpacked client version information.
    /// <code>Offset: 0x005AC320
    /// void __thiscall CLogonHeader::CLogonHeader(CLogonHeader*,const unsigned __int8*,unsigned int)</code>
    /// </summary>
    /// <param name="pRecvBuf">Pointer to the raw packet buffer containing the logon header.</param>
    /// <param name="cbRecvBuf">Size, in bytes, of the provided buffer.</param>
    public void _ConstructorInternal(byte* pRecvBuf, uint cbRecvBuf) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLogonHeader, byte*, uint, void>)0x005AC320)(ref this, pRecvBuf, cbRecvBuf);

    /// <summary>Creates a CLogonHeader instance by packing data from the supplied source into a newly allocated buffer and notifying an associated handler with the resulting packet.
    /// <code>Offset: 0x005AC3A0
    /// int __cdecl CLogonHeader::CreateFromData(int*,int)</code>
    /// </summary>
    /// <param name="a1">Pointer to the input data structure whose contents are to be packed into the header.</param>
    /// <param name="a2">Reference to an object that supplies size information and callback methods for processing the created header.</param>
    /// <returns>Handle (pointer cast to int) of the newly constructed CLogonHeader, or 0 if allocation fails.</returns>
    public static int CreateFromData(int* a1, int a2) => ((delegate* unmanaged[Cdecl]<int*, int, int>)0x005AC3A0)(a1, a2);

    /// <summary>Creates a COptionalHeader instance by unpacking and validating data from the supplied buffer iterator.
    /// <code>Offset: 0x005AC470
    /// COptionalHeader* __cdecl CLogonHeader::CreateFromStream(CBufferIterator*)</code>
    /// </summary>
    /// <param name="Buf">Iterator pointing to the logon packet data; its offset will be updated during parsing.</param>
    /// <returns>A pointer to the constructed COptionalHeader, or nullptr if parsing fails.</returns>
    public static ACBindings.Internal.COptionalHeader* CreateFromStream(ACBindings.Internal.CBufferIterator* Buf) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CBufferIterator*, ACBindings.Internal.COptionalHeader*>)0x005AC470)(Buf);
}

