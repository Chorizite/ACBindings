namespace ACBindings;

// CryptoKey
public unsafe struct CryptoKey
{
    // Base Classes
    public ACBindings.ReferenceCountTemplate BaseClass_ReferenceCountTemplate; // ACBindings.ReferenceCountTemplate

    // Child Types
    // CryptoKey_vtbl
    public unsafe struct CryptoKey_vtbl
    {
        // Members
        public System.IntPtr CryptoKey_dtor_0; // function pointer
        public System.IntPtr GenerateNewKey; // function pointer
        public System.IntPtr StreamEncrypt;
        public System.IntPtr StreamDecrypt;
        public System.IntPtr Encrypt;
        public System.IntPtr Decrypt;
        public System.IntPtr Serialize; // function pointer
        public System.IntPtr ShouldSerializeWithExchangeKey; // function pointer
        public System.IntPtr GetBlobType; // function pointer

        // Methods
    }

    // Members
    public uint m_hKey;
    public ACBindings.IntrusiveSmartPointer__CryptoProvider m_spProv;

    // Methods
}

