namespace ACBindings.Internal;


/// <summary>
/// Maintains global UI animation data by initializing a pre‑computed sine‑based level array and providing utilities to retrieve animation levels based on normalized progress.
/// </summary>
public unsafe struct UIGlobals
{
    // Statics
    public static short** s_pLevelArray = (short**)0x00841CAC;

    // Methods

    /// <summary>Creates and initializes the global level array with 100 pre‑computed values based on a sinusoidal pattern, converting them into a normalized cumulative distribution; does nothing if the array has already been initialized.
    /// <code>Offset: 0x004EF100
    /// void __cdecl UIGlobals::Init()</code>
    /// </summary>
    public static void Init() => ((delegate* unmanaged[Cdecl]<void>)0x004EF100)();

    /// <summary>Releases resources held by the UI global state by deleting the level array and setting its pointer to null.
    /// <code>Offset: 0x004EF1B0
    /// void __cdecl UIGlobals::Cleanup()</code>
    /// </summary>
    public static void Cleanup() => ((delegate* unmanaged[Cdecl]<void>)0x004EF1B0)();

    /// <summary>Returns an animation level based on a normalized percentage, clamping input between 0 and 1.
    /// <code>Offset: 0x004EF1D0
    /// __int16 __cdecl UIGlobals::GetAnimLevel(float)</code>
    /// </summary>
    /// <param name="i_fPercentage">A value representing progress from start (0) to finish (1).</param>
    /// <returns>The animation level as a signed 16‑bit integer.</returns>
    public static short GetAnimLevel(float i_fPercentage) => ((delegate* unmanaged[Cdecl]<float, short>)0x004EF1D0)(i_fPercentage);
}

