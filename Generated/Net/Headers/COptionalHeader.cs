namespace ACBindings;

// COptionalHeader
public unsafe struct COptionalHeader
{
    // Base Classes
    public ACBindings.ReferenceCountTemplate BaseClass_ReferenceCountTemplate; // ACBindings.ReferenceCountTemplate

    // Child Types
    // COptionalHeader_vtbl
    public unsafe struct COptionalHeader_vtbl
    {
        // Members
        public System.IntPtr COptionalHeader_dtor_0; // function pointer
        public System.IntPtr UpdateTimeSensitivePayload; // function pointer

        // Methods
    }

    // Members
    public uint m_dwMask;
    public uint m_Flags;
    public byte* m_pData;
    public uint m_cbData;

    // Methods
}

