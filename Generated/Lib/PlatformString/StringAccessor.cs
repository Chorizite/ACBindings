namespace ACBindings.PlatformString;

// PlatformString::StringAccessor
public unsafe struct StringAccessor
{
    // Members
    public int* h;

    // Methods
    // void** __thiscall PlatformString::StringAccessor::GetString(HINSTANCE*,void**,unsigned __int16)
    public void** GetString(void** Buffer, ushort a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlatformString.StringAccessor, void**, ushort, void**>)0x0043CB60)(ref this, Buffer, a3);
}

