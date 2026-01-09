namespace ACBindings;

// CLogonHeader
public unsafe struct CLogonHeader
{
    // Base Classes
    public ACBindings.COptionalHeader BaseClass_COptionalHeader; // ACBindings.COptionalHeader

    // Child Types
    // CLogonHeader_vtbl
    public unsafe struct CLogonHeader_vtbl
    {
        // Members
        public System.IntPtr CLogonHeader_dtor_0; // function pointer
        public System.IntPtr UpdateTimeSensitivePayload; // function pointer

        // Methods
    }
    // CLogonHeader::HandshakeWireData
    public unsafe struct HandshakeWireData : System.IDisposable
    {
        // Members
        public ACBindings.AC1Legacy.PStringBase__sbyte ClientVersion;
        public uint cbAuthData;

        // Generated Dispose
        public void Dispose() {
            _DestructorInternal();
        }

        // Methods
        // void __thiscall CLogonHeader::HandshakeWireData::~HandshakeWireData(CLogonHeader::HandshakeWireData*)
        public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLogonHeader.HandshakeWireData, void>)0x005ABB30)(ref this);
    }

    // Members
    public ACBindings.CLogonHeader.HandshakeWireData m_UnpackedData;
    public fixed byte m_PackedData[65504];

    // Generated Constructor
    public CLogonHeader(uint cbPackedData) {
        _ConstructorInternal(cbPackedData);
    }
    public CLogonHeader(byte* pRecvBuf, uint cbRecvBuf) {
        _ConstructorInternal(pRecvBuf, cbRecvBuf);
    }

    // Methods
    // void __thiscall CLogonHeader::CLogonHeader(CLogonHeader*,unsigned int)
    public void _ConstructorInternal(uint cbPackedData) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLogonHeader, uint, void>)0x005AC2D0)(ref this, cbPackedData);
    // void __thiscall CLogonHeader::CLogonHeader(CLogonHeader*,const unsigned __int8*,unsigned int)
    public void _ConstructorInternal(byte* pRecvBuf, uint cbRecvBuf) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLogonHeader, byte*, uint, void>)0x005AC320)(ref this, pRecvBuf, cbRecvBuf);
    // int __cdecl CLogonHeader::CreateFromData(int*,int)
    public static int CreateFromData(int* a1, int a2) => ((delegate* unmanaged[Cdecl]<int*, int, int>)0x005AC3A0)(a1, a2);
    // COptionalHeader* __cdecl CLogonHeader::CreateFromStream(CBufferIterator*)
    public static ACBindings.COptionalHeader* CreateFromStream(ACBindings.CBufferIterator* Buf) => ((delegate* unmanaged[Cdecl]<ACBindings.CBufferIterator*, ACBindings.COptionalHeader*>)0x005AC470)(Buf);
}

