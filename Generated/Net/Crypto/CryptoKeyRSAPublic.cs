namespace ACBindings.Internal;


/// <summary>Represents an RSA public cryptographic key, storing the parameters needed for encryption and signature verification.</summary>
/// <remarks>Aligns to 4-byte boundaries and encapsulates a CryptoKey base class instance.</remarks>
public unsafe struct CryptoKeyRSAPublic
{
    // Base Classes
    public ACBindings.Internal.CryptoKey BaseClass_CryptoKey; // ACBindings.Internal.CryptoKey

    // Child Types
    public unsafe struct CryptoKeyRSAPublic_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CryptoKeyRSAPublic*, void> CryptoKeyRSAPublic_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CryptoKeyRSAPublic*, byte> GenerateNewKey; // function pointer
        public System.IntPtr StreamEncrypt;
        public System.IntPtr StreamDecrypt;
        public System.IntPtr Encrypt;
        public System.IntPtr Decrypt;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CryptoKeyRSAPublic*, ACBindings.Internal.Archive*, void> Serialize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CryptoKeyRSAPublic*, byte> ShouldSerializeWithExchangeKey; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CryptoKeyRSAPublic*, uint> GetBlobType; // function pointer

        // Methods
    }

    // Methods
}

