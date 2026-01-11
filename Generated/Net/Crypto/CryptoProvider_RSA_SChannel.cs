namespace ACBindings.Internal;

public unsafe struct CryptoProvider_RSA_SChannel
{
    // Base Classes
    public ACBindings.Internal.CryptoProvider BaseClass_CryptoProvider; // ACBindings.Internal.CryptoProvider

    // Child Types
    public unsafe struct CryptoProvider_RSA_SChannel_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CryptoProvider_RSA_SChannel*, void> CryptoProvider_RSA_SChannel_dtor_0; // function pointer
        public System.IntPtr Init;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CryptoProvider_RSA_SChannel*, byte> Cleanup; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CryptoProvider_RSA_SChannel*, uint, byte> VerifyCryptoAlgorithmSupported; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CryptoProvider_RSA_SChannel*, System.IntPtr, uint, byte> GenRandom; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CryptoProvider_RSA_SChannel*, uint, byte> AcquireProvider; // function pointer

        // Methods
    }

    // Methods
}

