namespace ACBindings;

// CryptoProvider_AES
public unsafe struct CryptoProvider_AES
{
    // Base Classes
    public ACBindings.CryptoProvider BaseClass_CryptoProvider; // ACBindings.CryptoProvider

    // Child Types
    // CryptoProvider_AES_vtbl
    public unsafe struct CryptoProvider_AES_vtbl
    {
        // Members
        public System.IntPtr CryptoProvider_AES_dtor_0; // function pointer
        public System.IntPtr Init;
        public System.IntPtr Cleanup; // function pointer
        public System.IntPtr VerifyCryptoAlgorithmSupported; // function pointer
        public System.IntPtr GenRandom; // function pointer
        public System.IntPtr AcquireProvider; // function pointer

        // Methods
    }

    // Methods
}

