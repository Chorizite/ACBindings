namespace ACBindings.Internal;


/// <summary>AES-based cryptographic provider implementing the CryptoProvider interface for symmetric encryption and decryption.</summary>
public unsafe struct CryptoProvider_AES
{
    // Base Classes
    public ACBindings.Internal.CryptoProvider BaseClass_CryptoProvider; // ACBindings.Internal.CryptoProvider

    // Child Types
    public unsafe struct CryptoProvider_AES_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CryptoProvider_AES*, void> CryptoProvider_AES_dtor_0; // function pointer
        public System.IntPtr Init;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CryptoProvider_AES*, byte> Cleanup; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CryptoProvider_AES*, uint, byte> VerifyCryptoAlgorithmSupported; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CryptoProvider_AES*, System.IntPtr, uint, byte> GenRandom; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CryptoProvider_AES*, uint, byte> AcquireProvider; // function pointer

        // Methods
    }

    // Methods
}

