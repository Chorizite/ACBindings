namespace ACBindings.Internal;

public unsafe struct CryptoKeyRSA
{
    // Base Classes
    public ACBindings.Internal.CryptoKey BaseClass_CryptoKey; // ACBindings.Internal.CryptoKey

    // Child Types
    public unsafe struct CryptoKeyRSA_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CryptoKeyRSA*, void> CryptoKeyRSA_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CryptoKeyRSA*, byte> GenerateNewKey; // function pointer
        public System.IntPtr StreamEncrypt;
        public System.IntPtr StreamDecrypt;
        public System.IntPtr Encrypt;
        public System.IntPtr Decrypt;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CryptoKeyRSA*, ACBindings.Internal.Archive*, void> Serialize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CryptoKeyRSA*, byte> ShouldSerializeWithExchangeKey; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CryptoKeyRSA*, uint> GetBlobType; // function pointer

        // Methods
    }

    // Methods
}

