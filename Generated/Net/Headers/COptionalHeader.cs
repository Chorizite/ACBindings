namespace ACBindings.Internal;

public unsafe struct COptionalHeader
{
    // Base Classes
    public ACBindings.Internal.ReferenceCountTemplate BaseClass_ReferenceCountTemplate; // ACBindings.Internal.ReferenceCountTemplate

    // Child Types
    public unsafe struct COptionalHeader_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.COptionalHeader*, void> COptionalHeader_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.COptionalHeader*, int> UpdateTimeSensitivePayload; // function pointer

        // Methods
    }

    // Members
    public uint m_dwMask;
    public uint m_Flags;
    public byte* m_pData;
    public uint m_cbData;

    // Methods
}

