namespace ACBindings.Internal;

public unsafe struct CryptoKeyRC4
{
    // Base Classes
    public ACBindings.Internal.CryptoKey BaseClass_CryptoKey; // ACBindings.Internal.CryptoKey

    // Child Types
    public unsafe struct CryptoKeyRC4_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CryptoKeyRC4*, void> CryptoKeyRC4_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CryptoKeyRC4*, byte> GenerateNewKey; // function pointer
        public System.IntPtr StreamEncrypt;
        public System.IntPtr StreamDecrypt;
        public System.IntPtr Encrypt;
        public System.IntPtr Decrypt;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CryptoKeyRC4*, ACBindings.Internal.Archive*, void> Serialize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CryptoKeyRC4*, byte> ShouldSerializeWithExchangeKey; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CryptoKeyRC4*, uint> GetBlobType; // function pointer

        // Methods
    }

    // Methods
}

