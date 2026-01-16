namespace ACBindings.Internal;


/// <summary>Maps font data IDs to Font instances, caching loaded fonts and managing their lifecycle across application startup, shutdown, and retrieval by ID.</summary>
public unsafe struct FontMapper
{
    // Statics
    public static ACBindings.Internal.SmartArray___FontReference* fonts = (ACBindings.Internal.SmartArray___FontReference*)0x0083B1D0;

    // Methods

    /// <summary>Initializes the FontMapper by resetting its internal font registry and signals successful startup.
    /// <code>Offset: 0x0044B810
    /// bool __cdecl FontMapper::Startup()</code>
    /// </summary>
    /// <returns>True if initialization succeeded; otherwise, false.</returns>
    public static byte Startup() => ((delegate* unmanaged[Cdecl]<byte>)0x0044B810)();

    /// <summary>Releases all loaded font objects, deallocating resources and resetting the internal font collection.
    /// <code>Offset: 0x0044B820
    /// void __cdecl FontMapper::Shutdown()</code>
    /// </summary>
    public static void Shutdown() => ((delegate* unmanaged[Cdecl]<void>)0x0044B820)();

    /// <summary>Retrieves the Font object linked to the supplied data ID, loading and caching it on first request.
    /// <code>Offset: 0x0044B870
    /// Font* __cdecl FontMapper::GetFontByDataID(unsigned int)</code>
    /// </summary>
    /// <param name="a1">The unique identifier of the font resource.</param>
    /// <returns>A pointer to the corresponding Font instance, or nullptr if the ID is invalid or the font cannot be loaded.</returns>
    public static ACBindings.Internal.Font* GetFontByDataID(uint a1) => ((delegate* unmanaged[Cdecl]<uint, ACBindings.Internal.Font*>)0x0044B870)(a1);
}

