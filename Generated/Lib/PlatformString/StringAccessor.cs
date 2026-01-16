namespace ACBindings.Internal.PlatformString;


/// <summary>Holds a Windows instance handle, serving as the foundation for platform string resource access and manipulation.</summary>
public unsafe struct StringAccessor
{
    // Members
    public int* h;

    // Methods

    /// <summary>Retrieves a string resource identified by the given ID from corestrings.dll and stores it as a wide‑character string in the supplied buffer. If the module or string is missing, an error message is written instead.
    /// <code>Offset: 0x0043CB60
    /// void** __thiscall PlatformString::StringAccessor::GetString(HINSTANCE*,void**,unsigned __int16)</code>
    /// </summary>
    /// <param name="this">Handle to the corestrings.dll module used for loading resources.</param>
    /// <param name="Buffer">Pointer to a location where the address of the resulting wide‑string will be stored.</param>
    /// <param name="a3">Resource ID of the string to load.</param>
    /// <returns>The same buffer pointer that was passed in, now pointing to the retrieved or error string.</returns>
    public void** GetString(void** Buffer, ushort a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlatformString.StringAccessor, void**, ushort, void**>)0x0043CB60)(ref this, Buffer, a3);
}

