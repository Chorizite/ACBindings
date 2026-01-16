namespace ACBindings.Internal;


/// <summary>Placeholder indicating future support for Windows Registry editing.</summary>
/// <remarks>Currently defined without members, it serves as a compile‑time marker for registry‑related functionality that may be added later.</remarks>
public unsafe struct RegEdit
{
    // Methods

    /// <summary>Queries a registry value, returning its data and type.
    /// <code>Offset: 0x0040E120
    /// bool __stdcall RegEdit::QueryStrValue(const CHAR**,LPCSTR*,LPBYTE,DWORD,HKEY)</code>
    /// </summary>
    /// <param name="Type">Pointer to the subkey name; after a successful query, the same location holds the retrieved data type (as DWORD).</param>
    /// <param name="a2">Pointer to the value name within the subkey.</param>
    /// <param name="lpData">Buffer that receives the queried data.</param>
    /// <param name="cbData">Size of lpData; updated with the number of bytes copied on success.</param>
    /// <param name="hKey">Handle to an open registry key under which the subkey is located.</param>
    /// <returns>True if the subkey opens and the value query succeed; otherwise false.</returns>
    public static byte QueryStrValue(sbyte** Type, sbyte** a2, byte* lpData, uint cbData, int hKey) => ((delegate* unmanaged[Stdcall]<sbyte**, sbyte**, byte*, uint, int, byte>)0x0040E120)(Type, a2, lpData, cbData, hKey);

    /// <summary>Opens a registry subkey specified by a5 and queries its default wide string value using the key handle stored at a1. Returns true when both operations succeed.
    /// <code>Offset: 0x0040E1A0
    /// bool __stdcall RegEdit::QueryWStrValue(int*,int,int,int,int)</code>
    /// </summary>
    /// <param name="a1">Pointer to an integer holding the registry key handle whose default value will be queried.</param>
    /// <param name="a2">Reserved; unused.</param>
    /// <param name="a3">Reserved; unused.</param>
    /// <param name="a4">Reserved; unused.</param>
    /// <param name="a5">Registry key handle to open before querying the default value.</param>
    /// <returns>True if RegOpenKeyExW and RegQueryValueExW succeed; otherwise false.</returns>
    public static byte QueryWStrValue(int* a1, int a2, int a3, int a4, int a5) => ((delegate* unmanaged[Stdcall]<int*, int, int, int, int, byte>)0x0040E1A0)(a1, a2, a3, a4, a5);

    /// <summary>Deletes a named registry value from a specified subkey under a given root hive.
    /// <code>Offset: 0x0040E220
    /// bool __thiscall RegEdit::DeleteValue(HKEY,const CHAR**,LPCSTR*,HKEY)</code>
    /// </summary>
    /// <param name="a2">Pointer to the string specifying the subkey path relative to <c>hKey</c>.</param>
    /// <param name="a3">Pointer to the string naming the value to remove.</param>
    /// <param name="hKey">Handle to the root registry hive that contains the target subkey.</param>
    /// <returns>True if the value was successfully deleted; otherwise false.</returns>
    public byte DeleteValue(sbyte** a2, sbyte** a3, int hKey) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RegEdit, sbyte**, sbyte**, int, byte>)0x0040E220)(ref this, a2, a3, hKey);

    /// <summary>Retrieves a string value from the Windows registry for the specified key and stores it in the provided output pointer.
    /// <code>Offset: 0x0040E280
    /// bool __stdcall RegEdit::QueryStrValue(const CHAR**,LPCSTR*,void**,HKEY)</code>
    /// </summary>
    /// <param name="Type">Pointer to the expected data type of the registry value.</param>
    /// <param name="a2">Output parameter that receives the name of the queried value.</param>
    /// <param name="a3">Output buffer receiving the retrieved string; the caller must later free it if necessary.</param>
    /// <param name="hKey">Handle to an open registry key from which to read the value.</param>
    /// <returns>True if the query succeeds and a string is returned; otherwise false.</returns>
    public static byte QueryStrValue(sbyte** Type, sbyte** a2, void** a3, int hKey) => ((delegate* unmanaged[Stdcall]<sbyte**, sbyte**, void**, int, byte>)0x0040E280)(Type, a2, a3, hKey);

    /// <summary>Retrieves a wide‑string value from the registry and returns it through an output pointer.
    /// <code>Offset: 0x0040E2E0
    /// bool __stdcall RegEdit::QueryWStrValue(int*,int,void**,int)</code>
    /// </summary>
    /// <param name="a1">Pointer to the registry key or context used for the query.</param>
    /// <param name="a2">Identifier of the specific value to retrieve.</param>
    /// <param name="a3">Receives a pointer to a newly allocated wide‑string containing the queried value when the call succeeds.</param>
    /// <param name="a4">Optional flags or options that affect how the query is performed.</param>
    /// <returns>True if the value was successfully retrieved; otherwise false.</returns>
    public static byte QueryWStrValue(int* a1, int a2, void** a3, int a4) => ((delegate* unmanaged[Stdcall]<int*, int, void**, int, byte>)0x0040E2E0)(a1, a2, a3, a4);
}

