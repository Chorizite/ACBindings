namespace ACBindings;

// CryptoProvider_RSA_SChannel
public unsafe struct CryptoProvider_RSA_SChannel
{
    // Base Classes
    public ACBindings.CryptoProvider BaseClass_CryptoProvider; // ACBindings.CryptoProvider

    // Child Types
    // CryptoProvider_RSA_SChannel_vtbl
    public unsafe struct CryptoProvider_RSA_SChannel_vtbl
    {
        // Members
        public System.IntPtr CryptoProvider_RSA_SChannel_dtor_0; // function pointer
        public System.IntPtr Init;
        public System.IntPtr Cleanup; // function pointer
        public System.IntPtr VerifyCryptoAlgorithmSupported; // function pointer
        public System.IntPtr GenRandom; // function pointer
        public System.IntPtr AcquireProvider; // function pointer

        // Methods
    }

    // Methods
}

