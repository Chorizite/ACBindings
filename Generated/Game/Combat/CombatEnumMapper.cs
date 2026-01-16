namespace ACBindings.Internal;


/// <summary>Maps combat mode enumeration values to human‑readable text, enabling UI and logging systems to display the current combat state.</summary>
public unsafe struct CombatEnumMapper
{
    // Methods

    /// <summary>Makes the supplied string object represent the combat mode indicated by the integer argument and returns that string.
    /// <code>Offset: 0x005CAAF0
    /// void* __cdecl CombatEnumMapper::CombatModeToString(void*,int)</code>
    /// </summary>
    /// <param name="a1">String buffer to receive the combat mode description.</param>
    /// <param name="a2">Integer code representing a combat mode (e.g., 1 for peace, 2 for melee, etc.).</param>
    /// <returns>Pointer to the updated string object.</returns>
    public static System.IntPtr CombatModeToString(System.IntPtr a1, int a2) => ((delegate* unmanaged[Cdecl]<System.IntPtr, int, System.IntPtr>)0x005CAAF0)(a1, a2);
}

