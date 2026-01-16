namespace ACBindings.Internal;


/// <summary>Handles Vitae calculations for character power scaling, offering utilities such as computing CP pool thresholds from current Vitae and level.</summary>
public unsafe struct VitaeSystem
{
    // Methods

    /// <summary>Calculates the CP pool threshold based on current vitae and character level using a power‑based formula.
    /// <code>Offset: 0x005C9FB0
    /// unsigned int __cdecl VitaeSystem::VitaeCPPoolThreshold(float,unsigned int)</code>
    /// </summary>
    /// <param name="cur_vitae">Current Vitae value influencing the threshold growth.</param>
    /// <param name="level">Character level used in exponentiation to scale the threshold.</param>
    /// <returns>The computed CP pool threshold as an unsigned integer.</returns>
    public static uint VitaeCPPoolThreshold(float cur_vitae, uint level) => ((delegate* unmanaged[Cdecl]<float, uint, uint>)0x005C9FB0)(cur_vitae, level);
}

