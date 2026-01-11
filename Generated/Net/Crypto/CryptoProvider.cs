namespace ACBindings.Internal;

public unsafe struct CryptoProvider
{
    // Base Classes
    public ACBindings.Internal.ReferenceCountTemplate BaseClass_ReferenceCountTemplate; // ACBindings.Internal.ReferenceCountTemplate

    // Child Types
    public unsafe struct CryptoProvider_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CryptoProvider*, void> CryptoProvider_dtor_0; // function pointer
        public System.IntPtr Init;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CryptoProvider*, byte> Cleanup; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CryptoProvider*, uint, byte> VerifyCryptoAlgorithmSupported; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CryptoProvider*, System.IntPtr, uint, byte> GenRandom; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CryptoProvider*, uint, byte> AcquireProvider; // function pointer

        // Methods
    }

    // Members
    public uint m_hProv;
    public uint m_LastError;
    public ACBindings.Internal.PStringBase__sbyte m_ContainerName;
    public sbyte _bf_14;
    public fixed byte _padding_15[3];
    public ACBindings.Internal.IntrusiveSmartPointer___CryptoKey m_spIdentityKey;
    public ACBindings.Internal.IntrusiveSmartPointer___CryptoKey m_spExchangeKey;

    // Methods
}

