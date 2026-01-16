namespace ACBindings.Internal;


/// <summary>Defines parameters for ambient sound playback, including type, continuity flag, volume, probability and rate limits.</summary>
public unsafe struct AmbientSoundDesc
{
    // Members
    public ACBindings.Internal.SoundType stype;
    public int is_continuous;
    public float volume;
    public float base_chance;
    public float min_rate;
    public float max_rate;

    // Methods
}

