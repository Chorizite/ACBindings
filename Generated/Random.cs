namespace ACBindings;

// Random
public unsafe struct Random
{
    // Statics
    public static int* _idum2 = (int*)0x008189CC;
    public static int* _seed = (int*)0x008189D0;
    public static int* _iv = (int*)0x00837EA0;
    public static int* _iy = (int*)0x00837F20;

    // Methods
    // void __cdecl Random::Seed(int)
    public static void Seed(int seed) => ((delegate* unmanaged[Cdecl]<int, void>)0x0042C6B0)(seed);
    // long double __cdecl Random::rand()
    public static double rand() => ((delegate* unmanaged[Cdecl]<double>)0x0042C720)();
    // void __cdecl Random::Seed()
    public static void Seed() => ((delegate* unmanaged[Cdecl]<void>)0x0042C800)();
    // int __cdecl Random::RollDice(const int,const int)
    public static int RollDice(int lower_bound, int upper_bound) => ((delegate* unmanaged[Cdecl]<int, int, int>)0x0042C820)(lower_bound, upper_bound);
    // float __cdecl Random::RollDice(const float,const float)
    public static float RollDice(float lower_bound, float upper_bound) => ((delegate* unmanaged[Cdecl]<float, float, float>)0x0042C860)(lower_bound, upper_bound);
}

