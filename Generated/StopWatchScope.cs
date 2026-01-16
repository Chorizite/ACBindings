namespace ACBindings.Internal;


/// <summary>Holds a reference to an existing CStopWatch, enabling timed operations within a defined scope.</summary>
public unsafe struct StopWatchScope
{
    // Members
    public ACBindings.Internal.CStopWatch* m_pcWatch;

    // Methods
}

