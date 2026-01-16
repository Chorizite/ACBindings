namespace ACBindings.Internal;


/// <summary>Encapsulates a raw pointer to FileNodeFileInfo, intended for use as an intrusive smart pointer.</summary>
/// <remarks>Aligned to 4-byte boundaries for efficient memory usage.</remarks>
public unsafe struct IntrusiveSmartPointer___FileNodeFileInfo
{
    // Members
    public ACBindings.Internal.FileNodeFileInfo* m_data;

    // Methods

    /// <summary>Creates a new FileNodeFileInfo object, updates reference counts for any existing instance referenced by the supplied pointer, and stores the new object at that location.
    /// <code>Offset: 0x0065CFC0
    /// LONG __thiscall IntrusiveSmartPointer&lt;FileNodeFileInfo&gt;::create(PStringBase&lt;char&gt;**)</code>
    /// </summary>
    /// <param name="this">Pointer to the current FileNodeFileInfo instance; receives address of newly created object. Any previous instance is released if its reference count reaches zero.</param>
    /// <returns>Non‑zero on success; zero if memory allocation fails or creation could not be performed.</returns>
    // LONG __thiscall IntrusiveSmartPointer<FileNodeFileInfo>::create(PStringBase<char>**) (template type method)
}


/// <summary>Wraps a BasePropertyValue pointer, providing intrusive reference‑counting semantics for automatic lifetime management.</summary>
public unsafe struct IntrusiveSmartPointer___BasePropertyValue
{
    // Members
    public ACBindings.Internal.BasePropertyValue* m_data;

    // Methods
}

public unsafe struct IntrusiveSmartPointer___PFileNode
{
    // Members
    public ACBindings.Internal.PFileNode* m_data;

    // Methods
}

public unsafe struct IntrusiveSmartPointer___CryptoKey
{
    // Members
    public ACBindings.Internal.CryptoKey* m_data;

    // Methods
}

public unsafe struct IntrusiveSmartPointer___CryptoProvider
{
    // Members
    public ACBindings.Internal.CryptoProvider* m_data;

    // Methods
}

public unsafe struct IntrusiveSmartPointer___CryptoHash
{
    // Members
    public ACBindings.Internal.CryptoHash* m_data;

    // Methods
}

public unsafe struct IntrusiveSmartPointer___CryptoProvider_RSA_SChannel
{
    // Members
    public ACBindings.Internal.CryptoProvider_RSA_SChannel* m_data;

    // Methods
}

public unsafe struct IntrusiveSmartPointer___CryptoProvider_AES
{
    // Members
    public ACBindings.Internal.CryptoProvider_AES* m_data;

    // Methods
}

public unsafe struct IntrusiveSmartPointer___CryptoKey3DES
{
    // Members
    public ACBindings.Internal.CryptoKey3DES* m_data;

    // Methods
}

public unsafe struct IntrusiveSmartPointer___CryptoKeyRC4
{
    // Members
    public ACBindings.Internal.CryptoKeyRC4* m_data;

    // Methods
}

public unsafe struct IntrusiveSmartPointer___CryptoKeyAES
{
    // Members
    public ACBindings.Internal.CryptoKeyAES* m_data;

    // Methods
}

public unsafe struct IntrusiveSmartPointer___CryptoKeyRSA
{
    // Members
    public ACBindings.Internal.CryptoKeyRSA* m_data;

    // Methods
}

public unsafe struct IntrusiveSmartPointer___CryptoKeyRSAPublic
{
    // Members
    public ACBindings.Internal.CryptoKeyRSAPublic* m_data;

    // Methods
}

public unsafe struct IntrusiveSmartPointer___ReferenceCountTemplate
{
    // Members
    public System.IntPtr m_data;

    // Methods
}

public unsafe struct IntrusiveSmartPointer___AsyncCache_CCallbackHandler
{
    // Members
    public ACBindings.Internal.AsyncCache.CCallbackHandler* m_data;

    // Methods
}

