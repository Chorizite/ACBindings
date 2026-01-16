namespace ACBindings.Internal;


/// <summary>Encapsulates an optional header containing a local timestamp for echo requests, extending the base optional header functionality.</summary>
public unsafe struct CEchoRequestHeader
{
    // Base Classes
    public ACBindings.Internal.COptionalHeader BaseClass_COptionalHeader; // ACBindings.Internal.COptionalHeader

    // Child Types
    public unsafe struct CEchoRequestHeader_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CEchoRequestHeader*, void> CEchoRequestHeader_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CEchoRequestHeader*, int> UpdateTimeSensitivePayload; // function pointer

        // Methods
    }

    // Members
    public float m_LocalTime;

    // Methods

    /// <summary>Updates the header's local time field with the current system time, enabling accurate timestamping for time‑sensitive payloads.
    /// <code>Offset: 0x00547E60
    /// int __thiscall CEchoRequestHeader::UpdateTimeSensitivePayload(CEchoRequestHeader*)</code>
    /// </summary>
    public int UpdateTimeSensitivePayload() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CEchoRequestHeader, int>)0x00547E60)(ref this);

    /// <summary>Creates a new COptionalHeader containing the current local time as its data and initializes reference counting, mask, flags, and pointers appropriately.
    /// <code>Offset: 0x005481E0
    /// COptionalHeader* __cdecl CEchoRequestHeader::CreateFromData()</code>
    /// </summary>
    /// <returns>A pointer to the newly allocated header, or nullptr on failure.</returns>
    public static ACBindings.Internal.COptionalHeader* CreateFromData() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.COptionalHeader*>)0x005481E0)();

    /// <summary>Creates a COptionalHeader instance by reading a 4‑byte value from the supplied CBufferIterator and initializing its fields.
    /// <code>Offset: 0x005ABB50
    /// COptionalHeader* __cdecl CEchoRequestHeader::CreateFromStream(CBufferIterator*)</code>
    /// </summary>
    /// <param name="Buf">The buffer iterator positioned at the start of header data.</param>
    /// <returns>A pointer to the newly constructed COptionalHeader, or null if the buffer does not contain enough bytes to read the header.</returns>
    public static ACBindings.Internal.COptionalHeader* CreateFromStream(ACBindings.Internal.CBufferIterator* Buf) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CBufferIterator*, ACBindings.Internal.COptionalHeader*>)0x005ABB50)(Buf);
}

