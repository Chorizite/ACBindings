namespace ACBindings.Internal;

public unsafe struct CLogonHeader
{
    // Base Classes
    public ACBindings.Internal.COptionalHeader BaseClass_COptionalHeader; // ACBindings.Internal.COptionalHeader

    // Child Types
    public unsafe struct CLogonHeader_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CLogonHeader*, void> CLogonHeader_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CLogonHeader*, int> UpdateTimeSensitivePayload; // function pointer

        // Methods
    }
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

        /// <summary>
        /// <code>Offset: 0x005ABB30
        /// void __thiscall CLogonHeader::HandshakeWireData::~HandshakeWireData(CLogonHeader::HandshakeWireData*)</code>
        /// </summary>
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

    /// <summary>
    /// <code>Offset: 0x005AC2D0
    /// void __thiscall CLogonHeader::CLogonHeader(CLogonHeader*,unsigned int)</code>
    /// </summary>
    public void _ConstructorInternal(uint cbPackedData) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLogonHeader, uint, void>)0x005AC2D0)(ref this, cbPackedData);

    /// <summary>
    /// <code>Offset: 0x005AC320
    /// void __thiscall CLogonHeader::CLogonHeader(CLogonHeader*,const unsigned __int8*,unsigned int)</code>
    /// </summary>
    public void _ConstructorInternal(byte* pRecvBuf, uint cbRecvBuf) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLogonHeader, byte*, uint, void>)0x005AC320)(ref this, pRecvBuf, cbRecvBuf);

    /// <summary>
    /// <code>Offset: 0x005AC3A0
    /// int __cdecl CLogonHeader::CreateFromData(int*,int)</code>
    /// </summary>
    public static int CreateFromData(int* a1, int a2) => ((delegate* unmanaged[Cdecl]<int*, int, int>)0x005AC3A0)(a1, a2);

    /// <summary>
    /// <code>Offset: 0x005AC470
    /// COptionalHeader* __cdecl CLogonHeader::CreateFromStream(CBufferIterator*)</code>
    /// </summary>
    public static ACBindings.Internal.COptionalHeader* CreateFromStream(ACBindings.Internal.CBufferIterator* Buf) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CBufferIterator*, ACBindings.Internal.COptionalHeader*>)0x005AC470)(Buf);
}

