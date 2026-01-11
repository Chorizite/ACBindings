namespace ACBindings.Internal;

public unsafe struct CombatSystem
{
    // Statics
    public static double* ElementalModPKModifier = (double*)0x00823C60;

    // Methods

    /// <summary>
    /// <code>Offset: 0x005CA000
    /// long double __cdecl CombatSystem::GetElementalModPKModifier(const long double)</code>
    /// </summary>
    public static double GetElementalModPKModifier(double elementalModifier) => ((delegate* unmanaged[Cdecl]<double, double>)0x005CA000)(elementalModifier);

    /// <summary>
    /// <code>Offset: 0x005CA020
    /// int __cdecl CombatSystem::InqCombatHitAdjectives(int,double,int*,int*)</code>
    /// </summary>
    public static int InqCombatHitAdjectives(int a1, double a2, int* a3, int* a4) => ((delegate* unmanaged[Cdecl]<int, double, int*, int*, int>)0x005CA020)(a1, a2, a3, a4);
}

