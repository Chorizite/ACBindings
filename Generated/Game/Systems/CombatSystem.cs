namespace ACBindings.Internal;


/// <summary>Provides combat utilities, generating descriptive hit adjectives from attack type and damage magnitude, and computing PK modifiers based on elemental adjustments.</summary>
public unsafe struct CombatSystem
{
    // Statics
    public static double* ElementalModPKModifier = (double*)0x00823C60;

    // Methods

    /// <summary>Calculates the PK modifier from a given elemental modifier by scaling with ElementalModPKModifier and offsetting to maintain a base value of 1.
    /// <code>Offset: 0x005CA000
    /// long double __cdecl CombatSystem::GetElementalModPKModifier(const long double)</code>
    /// </summary>
    /// <param name="elementalModifier">The elemental modifier used as input for calculation.</param>
    /// <returns>The resulting PK modifier after applying the element-specific adjustment.</returns>
    public static double GetElementalModPKModifier(double elementalModifier) => ((delegate* unmanaged[Cdecl]<double, double>)0x005CA000)(elementalModifier);

    /// <summary>Determines combat hit adjectives based on attack type and damage magnitude, populating the supplied strings with singular and plural forms; returns a flag indicating whether a specialized adjective was chosen.
    /// <code>Offset: 0x005CA020
    /// int __cdecl CombatSystem::InqCombatHitAdjectives(int,double,int*,int*)</code>
    /// </summary>
    /// <param name="a1">Attack type code identifying the kind of hit (e.g., slash, burn, shock).</param>
    /// <param name="a2">Relative damage factor used to select adjective variation; higher values produce more intense verbs.</param>
    /// <param name="a3">Pointer to a string that receives the singular adjective describing the hit.</param>
    /// <param name="a4">Pointer to a string that receives the plural form of the adjective.</param>
    /// <returns>1 if an action‑verb adjective was selected, otherwise 0 for the generic “hit/hits” case.</returns>
    public static int InqCombatHitAdjectives(int a1, double a2, int* a3, int* a4) => ((delegate* unmanaged[Cdecl]<int, double, int*, int*, int>)0x005CA020)(a1, a2, a3, a4);
}

