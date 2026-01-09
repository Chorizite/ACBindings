namespace ACBindings;

// CryptoHash
public unsafe struct CryptoHash
{
    // Base Classes
    public ACBindings.ReferenceCountTemplate BaseClass_ReferenceCountTemplate; // ACBindings.ReferenceCountTemplate

    // Child Types
    // CryptoHash_vtbl
    public unsafe struct CryptoHash_vtbl
    {
        // Members
        public System.IntPtr CryptoHash_dtor_0; // function pointer

        // Methods
    }

    // Members
    public uint m_algID;
    public uint m_hHash;
    public ACBindings.IntrusiveSmartPointer__CryptoProvider m_spProv;

    // Methods
}

