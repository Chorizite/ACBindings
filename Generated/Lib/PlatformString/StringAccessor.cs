namespace ACBindings.Internal.PlatformString;

public unsafe struct StringAccessor
{
    // Members
    public int* h;

    // Methods

    /// <summary>
    /// <code>Offset: 0x0043CB60
    /// void** __thiscall PlatformString::StringAccessor::GetString(HINSTANCE*,void**,unsigned __int16)</code>
    /// </summary>
    public void** GetString(void** Buffer, ushort a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlatformString.StringAccessor, void**, ushort, void**>)0x0043CB60)(ref this, Buffer, a3);
}

