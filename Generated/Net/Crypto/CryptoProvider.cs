namespace ACBindings;

// CryptoProvider
public unsafe struct CryptoProvider
{
    // Base Classes
    public ACBindings.ReferenceCountTemplate BaseClass_ReferenceCountTemplate; // ACBindings.ReferenceCountTemplate

    // Child Types
    // CryptoProvider_vtbl
    public unsafe struct CryptoProvider_vtbl
    {
        // Members
        public System.IntPtr CryptoProvider_dtor_0; // function pointer
        public System.IntPtr Init;
        public System.IntPtr Cleanup; // function pointer
        public System.IntPtr VerifyCryptoAlgorithmSupported; // function pointer
        public System.IntPtr GenRandom; // function pointer
        public System.IntPtr AcquireProvider; // function pointer

        // Methods
    }

    // Members
    public uint m_hProv;
    public uint m_LastError;
    public ACBindings.PStringBase__sbyte m_ContainerName;
    public sbyte _bf_14;
    public fixed byte _padding_15[3];
    public ACBindings.IntrusiveSmartPointer__CryptoKey m_spIdentityKey;
    public ACBindings.IntrusiveSmartPointer__CryptoKey m_spExchangeKey;

    // Methods
}

