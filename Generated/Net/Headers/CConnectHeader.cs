namespace ACBindings;

// CConnectHeader
public unsafe struct CConnectHeader
{
    // Base Classes
    public ACBindings.COptionalHeader BaseClass_COptionalHeader; // ACBindings.COptionalHeader

    // Child Types
    // CConnectHeader_vtbl
    public unsafe struct CConnectHeader_vtbl
    {
        // Members
        public System.IntPtr CConnectHeader_dtor_0; // function pointer
        public System.IntPtr UpdateTimeSensitivePayload; // function pointer

        // Methods
    }

    // Members
    public ACBindings._BD07A5DFE72F700984F780826E69DF6F m_Data;

    // Methods
    // COptionalHeader* __cdecl CConnectHeader::CreateFromStream(CBufferIterator*)
    public static ACBindings.COptionalHeader* CreateFromStream(ACBindings.CBufferIterator* Buf) => ((delegate* unmanaged[Cdecl]<ACBindings.CBufferIterator*, ACBindings.COptionalHeader*>)0x005ABC40)(Buf);
}

