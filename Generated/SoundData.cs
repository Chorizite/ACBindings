namespace ACBindings.Internal;


/// <summary>Handles metadata for an audio clip, including its unique ID, priority level, playback probability, and volume setting within the sound system.</summary>
public unsafe struct SoundData
{
    // Members
    public ACBindings.Internal.IDClass____tagDataID sound_id_;
    public float priority_;
    public float probability_;
    public float volume_;

    // Generated Constructor
    public SoundData() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>Initializes a new instance of the SoundData structure with default values: sound ID set to zero, priority zero, probability one, and volume one.
    /// <code>Offset: 0x005528D0
    /// void __thiscall SoundData::SoundData(SoundData*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SoundData, void>)0x005528D0)(ref this);
}

