namespace ACBindings.Internal;


/// <summary>Encapsulates sound playback details including the audio buffer reference, priority level for mixing decisions, and start timestamp for synchronization.</summary>
public unsafe struct SoundPlayingData
{
    // Members
    public ACBindings.Internal.SoundBuf* buffer;
    public float priority;
    public double start_time;

    // Methods
}

