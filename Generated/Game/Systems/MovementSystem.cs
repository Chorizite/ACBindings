namespace ACBindings.Internal;


/// <summary>Provides movement calculations for characters, determining jump height, running speed, and stamina costs based on load, skill levels, and power modifiers.</summary>
public unsafe struct MovementSystem
{
    // Methods

    /// <summary>Calculates the character's running speed modifier based on encumbrance, skill level, and a scaling factor.
    /// <code>Offset: 0x006B1820
    /// float __cdecl MovementSystem::GetRunRate(const float,const int,const float)</code>
    /// </summary>
    /// <param name="load">The current load or weight carried by the character.</param>
    /// <param name="runskill">The run skill level of the character.</param>
    /// <param name="scaling">A multiplier that adjusts the final run rate for game balance or difficulty.</param>
    /// <returns>The computed running speed modifier as a floating‑point value.</returns>
    public static float GetRunRate(float load, int runskill, float scaling) => ((delegate* unmanaged[Cdecl]<float, int, float, float>)0x006B1820)(load, runskill, scaling);

    /// <summary>Determines the jump height using load, skill level, power factor and scaling, ensuring a minimum height.
    /// <code>Offset: 0x006B1880
    /// float __cdecl MovementSystem::GetJumpHeight(const float,const int,const float,const float)</code>
    /// </summary>
    /// <param name="load">The current encumbrance or weight load affecting jump ability.</param>
    /// <param name="jumpskill">Skill level influencing jump performance.</param>
    /// <param name="power">Power multiplier clamped between 0 and 1 that affects jump potential.</param>
    /// <param name="scaling">Additional scaling factor applied to the computed height.</param>
    /// <returns>The calculated jump height, never below 0.35.</returns>
    public static float GetJumpHeight(float load, int jumpskill, float power, float scaling) => ((delegate* unmanaged[Cdecl]<float, int, float, float, float>)0x006B1880)(load, jumpskill, power, scaling);

    /// <summary>Calculates the stamina cost required to perform a jump based on power, load, and a special flag.
    /// <code>Offset: 0x006B1910
    /// int __cdecl MovementSystem::JumpStaminaCost(float,float,int)</code>
    /// </summary>
    /// <param name="power">The base power of the jump.</param>
    /// <param name="load">The additional load affecting stamina consumption.</param>
    /// <param name="bPK">If non-zero, uses an alternate calculation path for power‑key jumps.</param>
    /// <returns>The computed stamina cost as an integer value.</returns>
    public static int JumpStaminaCost(float power, float load, int bPK) => ((delegate* unmanaged[Cdecl]<float, float, int, int>)0x006B1910)(power, load, bPK);
}

