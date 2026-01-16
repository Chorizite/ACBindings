namespace ACBindings.Internal;


/// <summary>Encapsulates the response header for echo operations, storing the original payload, creation timestamp, and elapsed holding time. Supports construction from data or stream and updating of time‑sensitive values.</summary>
public unsafe struct CEchoResponseHeader
{
    // Base Classes
    public ACBindings.Internal.COptionalHeader BaseClass_COptionalHeader; // ACBindings.Internal.COptionalHeader

    // Child Types
    public unsafe struct CEchoResponseHeader_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CEchoResponseHeader*, void> CEchoResponseHeader_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CEchoResponseHeader*, int> UpdateTimeSensitivePayload; // function pointer

        // Methods
    }

    /// <summary>Provides timing data for an echo response, recording the local timestamp and holding duration.</summary>
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

    /// <summary>Updates the HoldingTime field of m_WireData to reflect the elapsed time since this CEchoResponseHeader instance was created.
    /// <code>Offset: 0x00542F30
    /// int __thiscall CEchoResponseHeader::UpdateTimeSensitivePayload(CEchoResponseHeader*)</code>
    /// </summary>
    /// <returns>The returned int has no defined meaning and should not be relied upon; it is a leftover from the original implementation.</returns>
    public int UpdateTimeSensitivePayload() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CEchoResponseHeader, int>)0x00542F30)(ref this);

    /// <summary>Creates a new optional header representing an echo response, embedding the supplied payload value together with the current local timestamp.
    /// <code>Offset: 0x00543700
    /// COptionalHeader* __cdecl CEchoResponseHeader::CreateFromData(float)</code>
    /// </summary>
    /// <param name="EchoRequestPayload">The float payload from the original echo request to include in the response header.</param>
    /// <returns>A pointer to a freshly allocated <see cref="COptionalHeader"/> object containing the constructed data; null if allocation fails.</returns>
    public static ACBindings.Internal.COptionalHeader* CreateFromData(float EchoRequestPayload) => ((delegate* unmanaged[Cdecl]<float, ACBindings.Internal.COptionalHeader*>)0x00543700)(EchoRequestPayload);

    /// <summary>Creates a new optional header instance from the supplied buffer iterator, reading eight bytes of data if available.
    /// <code>Offset: 0x005ABBB0
    /// COptionalHeader* __cdecl CEchoResponseHeader::CreateFromStream(CBufferIterator*)</code>
    /// </summary>
    /// <param name="Buf">Iterator over input stream containing header data.</param>
    /// <returns>Pointer to allocated COptionalHeader on success; null on failure or insufficient data.</returns>
    public static ACBindings.Internal.COptionalHeader* CreateFromStream(ACBindings.Internal.CBufferIterator* Buf) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CBufferIterator*, ACBindings.Internal.COptionalHeader*>)0x005ABBB0)(Buf);
}

