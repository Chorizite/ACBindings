namespace ACBindings;

// FontMapper
public unsafe struct FontMapper
{
    // Statics
    public static ACBindings.SmartArray__FontReference* fonts = (ACBindings.SmartArray__FontReference*)0x0083B1D0;

    // Methods
    // bool __cdecl FontMapper::Startup()
    public static byte Startup() => ((delegate* unmanaged[Cdecl]<byte>)0x0044B810)();
    // void __cdecl FontMapper::Shutdown()
    public static void Shutdown() => ((delegate* unmanaged[Cdecl]<void>)0x0044B820)();
    // Font* __cdecl FontMapper::GetFontByDataID(unsigned int)
    public static ACBindings.Font* GetFontByDataID(uint a1) => ((delegate* unmanaged[Cdecl]<uint, ACBindings.Font*>)0x0044B870)(a1);
}

