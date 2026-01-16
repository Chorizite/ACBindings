namespace ACBindings.Internal;

public unsafe struct UI64Hash___NetBlob
{
    // Base Classes
    public ACBindings.Internal.HashBase__ulong BaseClass_HashBase; // ACBindings.Internal.HashBase__ulong

    // Methods

    /// <summary>Inserts a NetBlob into the hash table by computing its key from the object, linking it into the appropriate bucket list, and returning the bucket index.
    /// <code>Offset: 0x0054AD00
    /// int __thiscall UI64Hash&lt;NetBlob&gt;::add(_DWORD*,int)</code>
    /// </summary>
    /// <param name="a2">Pointer to the NetBlob instance to be inserted. Must not be null.</param>
    /// <returns>The zero‑based index of the bucket where the element was placed.</returns>
    // int __thiscall UI64Hash<NetBlob>::add(_DWORD*,int) (template type method)
}

public unsafe struct UI64Hash___ArrivedEphInfo
{
    // Base Classes
    public ACBindings.Internal.HashBase__ulong BaseClass_HashBase; // ACBindings.Internal.HashBase__ulong

    // Methods

    /// <summary>Removes every entry from the hash table, effectively clearing its contents.
    /// <code>Offset: 0x0054B080
    /// int __thiscall UI64Hash&lt;ArrivedEphInfo&gt;::destroy_contents(_DWORD**)</code>
    /// </summary>
    /// <returns>Zero to indicate successful clearance of the container.</returns>
    // int __thiscall UI64Hash<ArrivedEphInfo>::destroy_contents(_DWORD**) (template type method)
}

