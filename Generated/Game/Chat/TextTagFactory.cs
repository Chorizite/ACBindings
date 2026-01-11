namespace ACBindings.Internal;

public unsafe struct TextTagFactory
{
    // Methods

    /// <summary>
    /// <code>Offset: 0x00478880
    /// volatile LONG* __cdecl TextTagFactory::MakeTag(__int16**)</code>
    /// </summary>
    public static int* MakeTag(short** a1) => ((delegate* unmanaged[Cdecl]<short**, int*>)0x00478880)(a1);
}

