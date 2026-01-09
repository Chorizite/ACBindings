namespace ACBindings;

// CombatSystem
public unsafe struct CombatSystem
{
    // Statics
    public static float* AUGMENTATION_CRITICAL_DEFENSE_PK_AVOID_CHANCE = (float*)0x00823C54;
    public static double* ElementalModPKModifier = (double*)0x00823C60;

    // Methods
    // long double __cdecl CombatSystem::GetElementalModPKModifier(const long double)
    public static double GetElementalModPKModifier(double elementalModifier) => ((delegate* unmanaged[Cdecl]<double, double>)0x005CA000)(elementalModifier);
    // int __cdecl CombatSystem::InqCombatHitAdjectives(int,double,int*,int*)
    public static int InqCombatHitAdjectives(int a1, double a2, int* a3, int* a4) => ((delegate* unmanaged[Cdecl]<int, double, int*, int*, int>)0x005CA020)(a1, a2, a3, a4);
}

