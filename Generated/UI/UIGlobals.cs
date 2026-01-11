namespace ACBindings.Internal;

public unsafe struct UIGlobals
{
    // Statics
    public static short* s_pLevelArray = (short*)0x00841CAC;

    // Methods

    /// <summary>
    /// <code>Offset: 0x004EF100
    /// void __cdecl UIGlobals::Init()</code>
    /// </summary>
    public static void Init() => ((delegate* unmanaged[Cdecl]<void>)0x004EF100)();

    /// <summary>
    /// <code>Offset: 0x004EF1B0
    /// void __cdecl UIGlobals::Cleanup()</code>
    /// </summary>
    public static void Cleanup() => ((delegate* unmanaged[Cdecl]<void>)0x004EF1B0)();

    /// <summary>
    /// <code>Offset: 0x004EF1D0
    /// __int16 __cdecl UIGlobals::GetAnimLevel(float)</code>
    /// </summary>
    public static short GetAnimLevel(float i_fPercentage) => ((delegate* unmanaged[Cdecl]<float, short>)0x004EF1D0)(i_fPercentage);
}

