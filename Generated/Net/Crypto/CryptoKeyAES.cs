namespace ACBindings.Internal;


/// <summary>Defines an AES cryptographic key derived from the generic CryptoKey base class.</summary>
public unsafe struct CryptoKeyAES
{
    // Base Classes
    public ACBindings.Internal.CryptoKey BaseClass_CryptoKey; // ACBindings.Internal.CryptoKey

    // Child Types
    public unsafe struct CryptoKeyAES_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CryptoKeyAES*, void> CryptoKeyAES_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CryptoKeyAES*, byte> GenerateNewKey; // function pointer
        public System.IntPtr StreamEncrypt;
        public System.IntPtr StreamDecrypt;
        public System.IntPtr Encrypt;
        public System.IntPtr Decrypt;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CryptoKeyAES*, ACBindings.Internal.Archive*, void> Serialize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CryptoKeyAES*, byte> ShouldSerializeWithExchangeKey; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CryptoKeyAES*, uint> GetBlobType; // function pointer

        // Methods
    }

    // Methods
}

