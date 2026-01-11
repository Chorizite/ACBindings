namespace ACBindings.Internal;

public unsafe struct CEchoResponseHeader
{
    // Base Classes
    public ACBindings.Internal.COptionalHeader BaseClass_COptionalHeader; // ACBindings.Internal.COptionalHeader

    // Child Types
    public unsafe struct CEchoResponseHeader_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CEchoResponseHeader*, void> CEchoResponseHeader_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CEchoResponseHeader*, int> UpdateTimeSensitivePayload; // function pointer

        // Methods
    }
    public unsafe struct CEchoResponseHeaderWireData
    {
        // Members
        public float LocalTime;
        public float HoldingTime;

        // Methods
    }

    // Members
    public ACBindings.Internal.CEchoResponseHeader.CEchoResponseHeaderWireData m_WireData;
    public double m_LocalTimeConstructed;

    // Methods

    /// <summary>
    /// <code>Offset: 0x00542F30
    /// int __thiscall CEchoResponseHeader::UpdateTimeSensitivePayload(CEchoResponseHeader*)</code>
    /// </summary>
    public int UpdateTimeSensitivePayload() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CEchoResponseHeader, int>)0x00542F30)(ref this);

    /// <summary>
    /// <code>Offset: 0x00543700
    /// COptionalHeader* __cdecl CEchoResponseHeader::CreateFromData(float)</code>
    /// </summary>
    public static ACBindings.Internal.COptionalHeader* CreateFromData(float EchoRequestPayload) => ((delegate* unmanaged[Cdecl]<float, ACBindings.Internal.COptionalHeader*>)0x00543700)(EchoRequestPayload);

    /// <summary>
    /// <code>Offset: 0x005ABBB0
    /// COptionalHeader* __cdecl CEchoResponseHeader::CreateFromStream(CBufferIterator*)</code>
    /// </summary>
    public static ACBindings.Internal.COptionalHeader* CreateFromStream(ACBindings.Internal.CBufferIterator* Buf) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CBufferIterator*, ACBindings.Internal.COptionalHeader*>)0x005ABBB0)(Buf);
}

