namespace ACBindings.Internal;


/// <summary>Represents a cryptographic hash instance that holds the algorithm identifier, native hash handle, and reference‑counted provider, enabling creation and management of hash operations.</summary>
public unsafe struct CryptoHash
{
    // Base Classes
    public ACBindings.Internal.ReferenceCountTemplate BaseClass_ReferenceCountTemplate; // ACBindings.Internal.ReferenceCountTemplate

    // Child Types
    public unsafe struct CryptoHash_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CryptoHash*, void> CryptoHash_dtor_0; // function pointer

        // Methods
    }

    // Members
    public uint m_algID;
    public uint m_hHash;
    public ACBindings.Internal.IntrusiveSmartPointer___CryptoProvider m_spProv;

    // Methods
}

