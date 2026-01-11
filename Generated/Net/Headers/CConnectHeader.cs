namespace ACBindings.Internal;

public unsafe struct CConnectHeader
{
    // Base Classes
    public ACBindings.Internal.COptionalHeader BaseClass_COptionalHeader; // ACBindings.Internal.COptionalHeader

    // Child Types
    public unsafe struct CConnectHeader_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CConnectHeader*, void> CConnectHeader_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CConnectHeader*, int> UpdateTimeSensitivePayload; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal._BD07A5DFE72F700984F780826E69DF6F m_Data;

    // Methods

    /// <summary>
    /// <code>Offset: 0x005ABC40
    /// COptionalHeader* __cdecl CConnectHeader::CreateFromStream(CBufferIterator*)</code>
    /// </summary>
    public static ACBindings.Internal.COptionalHeader* CreateFromStream(ACBindings.Internal.CBufferIterator* Buf) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CBufferIterator*, ACBindings.Internal.COptionalHeader*>)0x005ABC40)(Buf);
}

