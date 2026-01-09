namespace ACBindings;

// ClientRegKey
public unsafe struct ClientRegKey
{
    // Methods
    // bool __cdecl ClientRegKey::GetClientOptions(LPCSTR*,void**)
    public static byte GetClientOptions(sbyte** a1, void** a2) => ((delegate* unmanaged[Cdecl]<sbyte**, void**, byte>)0x006B0D60)(a1, a2);
}

