namespace ACBindings.Internal;

public unsafe struct CryptoKeyRSAPublic
{
    // Base Classes
    public ACBindings.Internal.CryptoKey BaseClass_CryptoKey; // ACBindings.Internal.CryptoKey

    // Child Types
    public unsafe struct CryptoKeyRSAPublic_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CryptoKeyRSAPublic*, void> CryptoKeyRSAPublic_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CryptoKeyRSAPublic*, byte> GenerateNewKey; // function pointer
        public System.IntPtr StreamEncrypt;
        public System.IntPtr StreamDecrypt;
        public System.IntPtr Encrypt;
        public System.IntPtr Decrypt;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CryptoKeyRSAPublic*, ACBindings.Internal.Archive*, void> Serialize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CryptoKeyRSAPublic*, byte> ShouldSerializeWithExchangeKey; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CryptoKeyRSAPublic*, uint> GetBlobType; // function pointer

        // Methods
    }

    // Methods
}

