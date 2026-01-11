namespace ACBindings.Internal;

public unsafe struct Random
{
    // Statics
    public static int* _seed = (int*)0x008189E8;
    public static int* _idum2 = (int*)0x008189EC;
    public static int* _iv = (int*)0x00837EA0;
    public static int* _iy = (int*)0x00837F20;

    // Methods

    /// <summary>Initializes the random number generator's internal state using the specified seed, ensuring a non‑zero starting value.
    /// <code>Offset: 0x0042C6B0
    /// void __cdecl Random::Seed(int)</code>
    /// </summary>
    /// <param name="seed">The initial seed value; if zero, 1 is used instead to guarantee a valid state.</param>
    public static void Seed(int seed) => ((delegate* unmanaged[Cdecl]<int, void>)0x0042C6B0)(seed);

    /// <summary>Produces a uniformly distributed random value in the range [0, 1) using a combined linear‑congruential algorithm.
    /// <code>Offset: 0x0042C720
    /// long double __cdecl Random::rand()</code>
    /// </summary>
    /// <returns>A long double between 0 and 0.99999988 inclusive, representing pseudorandomness.</returns>
    public static double rand() => ((delegate* unmanaged[Cdecl]<double>)0x0042C720)();

    /// <summary>Initializes the random number generator seed to the current system time, ensuring a new sequence for each execution.
    /// <code>Offset: 0x0042C800
    /// void __cdecl Random::Seed()</code>
    /// </summary>
    public static void Seed() => ((delegate* unmanaged[Cdecl]<void>)0x0042C800)();

    /// <summary>Generates a pseudo‑random integer within the inclusive range specified by <paramref name="lower_bound"/> and <paramref name="upper_bound"/>, automatically handling reversed arguments.
    /// <code>Offset: 0x0042C820
    /// int __cdecl Random::RollDice(const int,const int)</code>
    /// </summary>
    /// <param name="lower_bound">The lower bound of the random range. May be greater than or less than <paramref name="upper_bound"/>; the function will swap them if necessary.</param>
    /// <param name="upper_bound">The upper bound of the random range. If equal to <paramref name="lower_bound"/>, that value is returned.</param>
    /// <returns>The randomly selected integer within the inclusive bounds.</returns>
    public static int RollDice(int lower_bound, int upper_bound) => ((delegate* unmanaged[Cdecl]<int, int, int>)0x0042C820)(lower_bound, upper_bound);

    /// <summary>Generates a pseudo‑random float uniformly distributed between the two supplied limits, treating them symmetrically so that the smaller value is always used as the lower bound.
    /// <code>Offset: 0x0042C860
    /// float __cdecl Random::RollDice(const float,const float)</code>
    /// </summary>
    /// <param name="lower_bound">The first limit of the range; may be greater than or less than upper_bound.</param>
    /// <param name="upper_bound">The second limit of the range; may be greater than or less than lower_bound.</param>
    /// <returns>The random value in [min(lower_bound,upper_bound), max(lower_bound,upper_bound)] (or that single value if bounds are equal).</returns>
    public static float RollDice(float lower_bound, float upper_bound) => ((delegate* unmanaged[Cdecl]<float, float, float>)0x0042C860)(lower_bound, upper_bound);
}

