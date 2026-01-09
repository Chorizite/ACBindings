namespace ACBindings;

// CryptoKey3DES
public unsafe struct CryptoKey3DES
{
    // Base Classes
    public ACBindings.CryptoKey BaseClass_CryptoKey; // ACBindings.CryptoKey

    // Child Types
    // CryptoKey3DES_vtbl
    public unsafe struct CryptoKey3DES_vtbl
    {
        // Members
        public System.IntPtr CryptoKey3DES_dtor_0; // function pointer
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

