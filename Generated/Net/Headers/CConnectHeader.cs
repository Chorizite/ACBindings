namespace ACBindings.Internal;


/// <summary>Represents the primary connection header, encapsulating an optional header section and its associated payload used when establishing or managing connections.</summary>
public unsafe struct CConnectHeader
{
    // Base Classes
    public ACBindings.Internal.COptionalHeader BaseClass_COptionalHeader; // ACBindings.Internal.COptionalHeader

    // Child Types
    public unsafe struct CConnectHeader_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CConnectHeader*, void> CConnectHeader_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CConnectHeader*, int> UpdateTimeSensitivePayload; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal._BD07A5DFE72F700984F780826E69DF6F m_Data;

    // Methods

    /// <summary>Creates a new optional header instance by reading 32 bytes from the supplied buffer iterator, initializing header fields and advancing the iterator.
    /// <code>Offset: 0x005ABC40
    /// COptionalHeader* __cdecl CConnectHeader::CreateFromStream(CBufferIterator*)</code>
    /// </summary>
    /// <param name="Buf">Iterator positioned at data to extract; its offset is advanced on success.</param>
    /// <returns>Pointer to the newly allocated COptionalHeader, or nullptr if allocation fails or not enough data remains in the buffer.</returns>
    public static ACBindings.Internal.COptionalHeader* CreateFromStream(ACBindings.Internal.CBufferIterator* Buf) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CBufferIterator*, ACBindings.Internal.COptionalHeader*>)0x005ABC40)(Buf);
}

