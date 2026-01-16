namespace ACBindings.Internal;


/// <summary>Represents a cryptographic key handle managed by CryptoProvider, enabling encryption and decryption operations within the application.</summary>
public unsafe struct CryptoKey
{
    // Base Classes
    public ACBindings.Internal.ReferenceCountTemplate BaseClass_ReferenceCountTemplate; // ACBindings.Internal.ReferenceCountTemplate

    // Child Types
    public unsafe struct CryptoKey_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CryptoKey*, void> CryptoKey_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CryptoKey*, byte> GenerateNewKey; // function pointer
        public System.IntPtr StreamEncrypt;
        public System.IntPtr StreamDecrypt;
        public System.IntPtr Encrypt;
        public System.IntPtr Decrypt;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CryptoKey*, ACBindings.Internal.Archive*, void> Serialize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CryptoKey*, byte> ShouldSerializeWithExchangeKey; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CryptoKey*, uint> GetBlobType; // function pointer

        // Methods
    }

    // Members
    public uint m_hKey;
    public ACBindings.Internal.IntrusiveSmartPointer___CryptoProvider m_spProv;

    // Methods
}

