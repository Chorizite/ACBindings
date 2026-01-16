namespace ACBindings.Internal;


/// <summary>Stores an unsigned 64-bit timestamp marking the beginning of a performance measurement interval, enabling subsequent calculation of elapsed time.</summary>
public unsafe struct PerfTimer
{
    // Child Types

    /// <summary>Defines an empty type used as a placeholder within the PerfTimer subsystem.</summary>
    public unsafe struct Initializer
    {
        // Methods
    }

    // Members
    public ulong m_startTime;

    // Methods
}

