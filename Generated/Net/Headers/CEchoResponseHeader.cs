namespace ACBindings;

// CEchoResponseHeader
public unsafe struct CEchoResponseHeader
{
    // Base Classes
    public ACBindings.COptionalHeader BaseClass_COptionalHeader; // ACBindings.COptionalHeader

    // Child Types
    // CEchoResponseHeader_vtbl
    public unsafe struct CEchoResponseHeader_vtbl
    {
        // Members
        public System.IntPtr CEchoResponseHeader_dtor_0; // function pointer
        public System.IntPtr UpdateTimeSensitivePayload; // function pointer

        // Methods
    }
    // CEchoResponseHeader::CEchoResponseHeaderWireData
    public unsafe struct CEchoResponseHeaderWireData
    {
        // Members
        public float LocalTime;
        public float HoldingTime;

        // Methods
    }

    // Members
    public ACBindings.CEchoResponseHeader.CEchoResponseHeaderWireData m_WireData;
    public double m_LocalTimeConstructed;

    // Methods
    // int __thiscall CEchoResponseHeader::UpdateTimeSensitivePayload(CEchoResponseHeader*)
    public int UpdateTimeSensitivePayload() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CEchoResponseHeader, int>)0x00542F30)(ref this);
    // COptionalHeader* __cdecl CEchoResponseHeader::CreateFromData(float)
    public static ACBindings.COptionalHeader* CreateFromData(float EchoRequestPayload) => ((delegate* unmanaged[Cdecl]<float, ACBindings.COptionalHeader*>)0x00543700)(EchoRequestPayload);
    // COptionalHeader* __cdecl CEchoResponseHeader::CreateFromStream(CBufferIterator*)
    public static ACBindings.COptionalHeader* CreateFromStream(ACBindings.CBufferIterator* Buf) => ((delegate* unmanaged[Cdecl]<ACBindings.CBufferIterator*, ACBindings.COptionalHeader*>)0x005ABBB0)(Buf);
}

