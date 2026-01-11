namespace ACBindings.Internal;

public unsafe struct FontMapper
{
    // Methods

    /// <summary>
    /// <code>Offset: 0x0044B810
    /// bool __cdecl FontMapper::Startup()</code>
    /// </summary>
    public static byte Startup() => ((delegate* unmanaged[Cdecl]<byte>)0x0044B810)();

    /// <summary>
    /// <code>Offset: 0x0044B820
    /// void __cdecl FontMapper::Shutdown()</code>
    /// </summary>
    public static void Shutdown() => ((delegate* unmanaged[Cdecl]<void>)0x0044B820)();

    /// <summary>
    /// <code>Offset: 0x0044B870
    /// Font* __cdecl FontMapper::GetFontByDataID(unsigned int)</code>
    /// </summary>
    public static ACBindings.Internal.Font* GetFontByDataID(uint a1) => ((delegate* unmanaged[Cdecl]<uint, ACBindings.Internal.Font*>)0x0044B870)(a1);
}

