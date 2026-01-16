namespace ACBindings.Internal;


/// <summary>Retrieves client configuration options from the Windows registry.</summary>
public unsafe struct ClientRegKey
{
    // Methods

    /// <summary>Retrieves client option data from the Windows registry under the client key path.
    /// <code>Offset: 0x006B0D60
    /// bool __cdecl ClientRegKey::GetClientOptions(LPCSTR*,void**)</code>
    /// </summary>
    /// <param name="a1">Receives the queried string value, or remains null if the query fails.</param>
    /// <param name="a2">Receives a pointer to the retrieved data; may be set to null when no data is found.</param>
    /// <returns>True if the registry query succeeded and values were returned; otherwise false.</returns>
    public static byte GetClientOptions(sbyte** a1, void** a2) => ((delegate* unmanaged[Cdecl]<sbyte**, void**, byte>)0x006B0D60)(a1, a2);
}

