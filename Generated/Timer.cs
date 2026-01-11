namespace ACBindings.Internal;

public unsafe struct Timer
{
    // Statics
    public static ACBindings.Internal.PreciseTimerInstance* s_pcTimerInstance = (ACBindings.Internal.PreciseTimerInstance*)0x008379A0;

    // Methods

    /// <summary>Retrieves the current system time in seconds since the Unix epoch.
    /// <code>Offset: 0x0040FA90
    /// int __cdecl Timer::get_real_time()</code>
    /// </summary>
    /// <returns>An integer value representing the number of seconds elapsed since January 1, 1970 (Unix time).</returns>
    public static int get_real_time() => ((delegate* unmanaged[Cdecl]<int>)0x0040FA90)();

    /// <summary>Computes the elapsed time for the timer, returning zero if it has not been initialized.
    /// <code>Offset: 0x0040FAA0
    /// long double __cdecl Timer::compute_time()</code>
    /// </summary>
    /// <returns>The total elapsed time as a long double, derived from the performance counter and an internal offset.</returns>
    public static double compute_time() => ((delegate* unmanaged[Cdecl]<double>)0x0040FAA0)();

    /// <summary>Computes the local elapsed time using a high-resolution performance counter when the timer is initialized; otherwise returns 0.
    /// <code>Offset: 0x0040FAD0
    /// long double __cdecl Timer::compute_local_time()</code>
    /// </summary>
    /// <returns>The elapsed time since the timer was initialized, expressed as a long double, or zero if the timer has not been initialized.</returns>
    public static double compute_local_time() => ((delegate* unmanaged[Cdecl]<double>)0x0040FAD0)();

    /// <summary>Updates the timer’s internal state based on the supplied reference timestamp.
    /// <code>Offset: 0x0040FB00
    /// void __cdecl Timer::set_time(const long double*)</code>
    /// </summary>
    /// <param name="now">The current time value used to recompute elapsed and local times.</param>
    public static void set_time(double* now) => ((delegate* unmanaged[Cdecl]<double*, void>)0x0040FB00)(now);

    /// <summary>Updates the Timer instance’s internal timing state by querying a high‑resolution performance counter. Stores elapsed time, updates accumulated time when no error flag is set, and synchronizes static fields for local and current time.
    /// <code>Offset: 0x0040FBD0
    /// void __cdecl Timer::update_time()</code>
    /// </summary>
    public static void update_time() => ((delegate* unmanaged[Cdecl]<void>)0x0040FBD0)();

    /// <summary>Provides access to a globally shared timer instance, creating it on first use.
    /// <code>Offset: 0x0040FCA0
    /// PreciseTimerInstance* __cdecl Timer::GetTimerInstance()</code>
    /// </summary>
    /// <returns>A pointer to the singleton PreciseTimerInstance; may be nullptr if allocation fails.</returns>
    public static ACBindings.Internal.PreciseTimerInstance* GetTimerInstance() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.PreciseTimerInstance*>)0x0040FCA0)();

    /// <summary>Initializes the timer subsystem by allocating and configuring a precise timer instance when first invoked.
    /// <code>Offset: 0x0040FCD0
    /// void __cdecl Timer::Init()</code>
    /// </summary>
    public static void Init() => ((delegate* unmanaged[Cdecl]<void>)0x0040FCD0)();
}

