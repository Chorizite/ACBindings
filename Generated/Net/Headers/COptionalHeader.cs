namespace ACBindings.Internal;


/// <summary>Encapsulates optional header data for an object, providing mask and flag fields to describe its attributes, a pointer to the payload, and its length. Reference counting enables shared ownership across components.</summary>
public unsafe struct COptionalHeader
{
    // Base Classes
    public ACBindings.Internal.ReferenceCountTemplate BaseClass_ReferenceCountTemplate; // ACBindings.Internal.ReferenceCountTemplate

    // Child Types
    public unsafe struct COptionalHeader_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.COptionalHeader*, void> COptionalHeader_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.COptionalHeader*, int> UpdateTimeSensitivePayload; // function pointer

        // Methods
    }

    // Members
    public uint m_dwMask;
    public uint m_Flags;
    public byte* m_pData;
    public uint m_cbData;

    // Methods
}

