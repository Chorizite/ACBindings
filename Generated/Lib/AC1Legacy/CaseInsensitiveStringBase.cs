namespace ACBindings.Internal.AC1Legacy;


/// <summary>Wraps a PStringBase&lt;char&gt; to provide case‑insensitive string handling and hashing, enabling its use as keys or values in data structures that ignore letter casing.</summary>
public unsafe struct CaseInsensitiveStringBase___AC1Legacy_PStringBase__sbyte
{
    // Base Classes
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte BaseClass_AC1Legacy_PStringBase; // ACBindings.Internal.AC1Legacy.PStringBase__sbyte

    // Methods

    /// <summary>Computes a case-insensitive hash for the underlying character buffer stored in this instance.
    /// <code>Offset: 0x004FE050
    /// unsigned int __thiscall AC1Legacy::CaseInsensitiveStringBase&lt;AC1Legacy::PStringBase&lt;char&gt;&gt;::case_insensitive_hash(void*)</code>
    /// </summary>
    /// <returns>A 32-bit unsigned integer representing the hash value derived from the string, regardless of letter casing.</returns>
    // unsigned int __thiscall AC1Legacy::CaseInsensitiveStringBase<AC1Legacy::PStringBase<char>>::case_insensitive_hash(void*) (template type method)
}


/// <summary>
/// Represents a case‑insensitive wrapper around AC1Legacy::PStringBase&lt;unsigned short&gt;, providing wide‑character string storage and comparison without regard to letter casing within the legacy system.
/// </summary>
public unsafe struct CaseInsensitiveStringBase___AC1Legacy_PStringBase__ushort
{
    // Base Classes
    public ACBindings.Internal.AC1Legacy.PStringBase__ushort BaseClass_AC1Legacy_PStringBase; // ACBindings.Internal.AC1Legacy.PStringBase__ushort

    // Methods
}

