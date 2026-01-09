namespace ACBindings;

// CryptoKeyRSA
public unsafe struct CryptoKeyRSA
{
    // Base Classes
    public ACBindings.CryptoKey BaseClass_CryptoKey; // ACBindings.CryptoKey

    // Child Types
    // CryptoKeyRSA_vtbl
    public unsafe struct CryptoKeyRSA_vtbl
    {
        // Members
        public System.IntPtr CryptoKeyRSA_dtor_0; // function pointer
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

    // Methods
}

