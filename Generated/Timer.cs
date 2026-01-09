namespace ACBindings;

// Timer
public unsafe struct Timer
{
    // Statics
    public static ACBindings.PreciseTimerInstance* s_pcTimerInstance = (ACBindings.PreciseTimerInstance*)0x008379A0;
    public static double* cur_time = (double*)0x008379A8;
    public static double* local_time = (double*)0x008379B0;
    public static byte* initialized_ = (byte*)0x008379B8;

    // Methods
    // int __cdecl Timer::get_real_time()
    public static int get_real_time() => ((delegate* unmanaged[Cdecl]<int>)0x0040FA90)();
    // long double __cdecl Timer::compute_time()
    public static double compute_time() => ((delegate* unmanaged[Cdecl]<double>)0x0040FAA0)();
    // long double __cdecl Timer::compute_local_time()
    public static double compute_local_time() => ((delegate* unmanaged[Cdecl]<double>)0x0040FAD0)();
    // void __cdecl Timer::set_time(const long double*)
    public static void set_time(double* now) => ((delegate* unmanaged[Cdecl]<double*, void>)0x0040FB00)(now);
    // void __cdecl Timer::update_time()
    public static void update_time() => ((delegate* unmanaged[Cdecl]<void>)0x0040FBD0)();
    // PreciseTimerInstance* __cdecl Timer::GetTimerInstance()
    public static ACBindings.PreciseTimerInstance* GetTimerInstance() => ((delegate* unmanaged[Cdecl]<ACBindings.PreciseTimerInstance*>)0x0040FCA0)();
    // void __cdecl Timer::Init()
    public static void Init() => ((delegate* unmanaged[Cdecl]<void>)0x0040FCD0)();
}

