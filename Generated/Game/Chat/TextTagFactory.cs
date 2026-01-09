namespace ACBindings;

// TextTagFactory
public unsafe struct TextTagFactory
{
    // Methods
    // volatile LONG* __cdecl TextTagFactory::MakeTag(__int16**)
    public static int* MakeTag(short** a1) => ((delegate* unmanaged[Cdecl]<short**, int*>)0x00478880)(a1);
}

