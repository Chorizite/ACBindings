namespace ACBindings.Internal;


/// <summary>Tracks the player’s position and manages ambient audio playback by maintaining a list of active sounds, their queueing times, and overall sound count.</summary>
public unsafe struct Ambient : System.IDisposable
{
    // Statics
    public static float* ambient_sound_min_dist = (float*)0x00820158;
    public static float* ambient_sound_min_dist_sq = (float*)0x0082015C;
    public static float* ambient_sound_max_dist_sq = (float*)0x00820164;
    public static float* ambient_sound_min_vol = (float*)0x00820168;

    // Members
    public ACBindings.Internal.Position player_pos;
    public float total_sound_count;
    public uint num_sounds;
    public ACBindings.Internal.DArray___AmbientSound_ptr sounds;
    public ACBindings.Internal.AC1Legacy.PQueueArray__double sound_queue;

    // Generated Constructor
    public Ambient() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Flushes all active ambient sounds, destroying each sound object and releasing any linked resources, then resets the internal counter.
    /// <code>Offset: 0x00452960
    /// unsigned int __thiscall Ambient::FlushSoundTables(Ambient*)</code>
    /// </summary>
    /// <returns>The number of sound slots that were processed (original count before flushing).</returns>
    public uint FlushSoundTables() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Ambient, uint>)0x00452960)(ref this);

    /// <summary>Releases sound tables associated with the ambient object, freeing resources and clearing references.
    /// <code>Offset: 0x00455890
    /// unsigned int __thiscall Ambient::ReleaseSoundTables(Ambient*)</code>
    /// </summary>
    /// <returns>The total number of sounds processed during release.</returns>
    public uint ReleaseSoundTables() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Ambient, uint>)0x00455890)(ref this);

    /// <summary>Play an ambient sound of the specified type using the provided sound table. If a position is supplied, play at that location; otherwise play from the audio source’s center.
    /// <code>Offset: 0x005519B0
    /// void __stdcall Ambient::PlaySoundA(SoundType,CSoundTable*,Position*,float)</code>
    /// </summary>
    /// <param name="stype">The enumerated type of the ambient sound to be played.</param>
    /// <param name="sound_table">Pointer to the sound table containing data for the requested sound.</param>
    /// <param name="pos">Position at which to play the sound; if null, the sound plays from the center.</param>
    /// <param name="center_volume">Volume factor applied when playing the sound.</param>
    public static void PlaySoundA(ACBindings.Internal.SoundType stype, ACBindings.Internal.CSoundTable* sound_table, ACBindings.Internal.Position* pos, float center_volume) => ((delegate* unmanaged[Stdcall]<ACBindings.Internal.SoundType, ACBindings.Internal.CSoundTable*, ACBindings.Internal.Position*, float, void>)0x005519B0)(stype, sound_table, pos, center_volume);

    /// <summary>Determines how audible a sound should be based on its distance from the listener, using predefined minimum and maximum ranges.
    /// <code>Offset: 0x005519F0
    /// double __thiscall Ambient::CalcWeight(Ambient*,const Vector3*)</code>
    /// </summary>
    /// <param name="a2">Vector representing the offset from the sound source to the listener.</param>
    /// <returns>Weight between 0 and 1: returns 0 if the squared distance exceeds the maximum audible range; returns 1 when within the minimum radius; otherwise returns the ratio of the minimum‑range square to the current squared distance, providing an inverse‑square attenuation.</returns>
    public double CalcWeight(ACBindings.Internal.Vector3* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Ambient, ACBindings.Internal.Vector3*, double>)0x005519F0)(ref this, a2);

    /// <summary>Determines a directional quadrant index for a given vector relative to an Ambient instance, returning codes 0–8 based on distance and component ratios.
    /// <code>Offset: 0x00551A60
    /// int __thiscall Ambient::CalcDir(Ambient*,const Vector3*)</code>
    /// </summary>
    /// <param name="this">The Ambient object providing contextual information for the calculation.</param>
    /// <param name="a2">A pointer to the Vector3 whose x and y components define the direction to evaluate.</param>
    /// <returns>Zero if the vector is within a minimum distance; otherwise an integer 1–8 indicating one of eight directional sectors.</returns>
    public int CalcDir(ACBindings.Internal.Vector3* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Ambient, ACBindings.Internal.Vector3*, int>)0x00551A60)(ref this, a2);

    /// <summary>Retrieves or creates an ambient sound object based on the provided descriptor and index, storing it in the Ambient's internal collection.
    /// <code>Offset: 0x00551CD0
    /// int __thiscall Ambient::GetSound(Ambient*,AmbientSTBDesc*,unsigned int)</code>
    /// </summary>
    /// <param name="a2">The ambient sound table descriptor containing sound data and flags.</param>
    /// <param name="a3">The index into the descriptor's ambient_sounds array specifying which specific ambient sound to retrieve or create.</param>
    /// <returns>Pointer to the AmbientSound instance associated with the requested descriptor and index.</returns>
    public int GetSound(ACBindings.Internal.AmbientSTBDesc* a2, uint a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Ambient, ACBindings.Internal.AmbientSTBDesc*, uint, int>)0x00551CD0)(ref this, a2, a3);

    /// <summary>Destroys all ambient sounds associated with the Ambient instance by freeing each sound object, clearing the sound array, and resetting the sound count.
    /// <code>Offset: 0x005521A0
    /// unsigned int __thiscall Ambient::Destroy(Ambient*)</code>
    /// </summary>
    /// <returns>The number of ambient sounds that were destroyed before cleanup.</returns>
    public uint Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Ambient, uint>)0x005521A0)(ref this);

    /// <summary>Sets the ambient system’s player position and orientation from the supplied Position, clears any previously loaded sounds, and resets internal state.
    /// <code>Offset: 0x005521F0
    /// unsigned int __thiscall Ambient::InitSounds(Ambient*,const Position*)</code>
    /// </summary>
    /// <param name="position">The current player position and frame used to initialize sound calculations.</param>
    /// <returns>The number of ambient sounds that existed before reinitialization.</returns>
    public uint InitSounds(ACBindings.Internal.Position* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Ambient, ACBindings.Internal.Position*, uint>)0x005521F0)(ref this, a2);

    /// <summary>Adds ambient sounds described by the provided descriptor at the specified reference position, weighting each sound based on distance from the ambient's player position and queuing them if ambient playback is enabled.
    /// <code>Offset: 0x00552230
    /// void __thiscall Ambient::AddSound(Position*,AmbientSTBDesc*,Position*)</code>
    /// </summary>
    /// <param name="a2">Descriptor containing ambient sound data and play count.</param>
    /// <param name="p">Reference position used for calculating distance and direction of sounds relative to the ambient environment.</param>
    public void AddSound(ACBindings.Internal.AmbientSTBDesc* a2, ACBindings.Internal.Position* p) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Ambient, ACBindings.Internal.AmbientSTBDesc*, ACBindings.Internal.Position*, void>)0x00552230)(ref this, a2, p);

    /// <summary>Initializes an Ambient instance with default position, zero sound counts, and allocates internal arrays for managing ambient sounds.
    /// <code>Offset: 0x00552300
    /// Ambient* __thiscall Ambient::Ambient(Ambient*)</code>
    /// </summary>
    public ACBindings.Internal.Ambient* _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Ambient, ACBindings.Internal.Ambient*>)0x00552300)(ref this);

    /// <summary>Destroys an Ambient object, releasing all stored sounds, freeing dynamic arrays, and restoring base class virtual tables.
    /// <code>Offset: 0x00552380
    /// void __thiscall Ambient::~Ambient(Ambient*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Ambient, void>)0x00552380)(ref this);

    /// <summary>Schedules an ambient sound using the supplied parameters, playing it either from the center or relative to the player position based on flags, and enqueues its start time.
    /// <code>Offset: 0x005523C0
    /// int __thiscall Ambient::Play(_DWORD*,_DWORD*)</code>
    /// </summary>
    /// <param name="center_volume">Pointer to a structure containing volume, type, and playback settings for the ambient sound.</param>
    /// <returns>Zero if scheduling fails; otherwise a status code returned by the queue insertion operation.</returns>
    public int Play(int* center_volume) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Ambient, int*, int>)0x005523C0)(ref this, center_volume);

    /// <summary>Processes queued ambient sounds whose scheduled time has elapsed, playing them when due while ambient sound playback is enabled.
    /// <code>Offset: 0x005524A0
    /// void __thiscall Ambient::UseTime(Ambient*)</code>
    /// </summary>
    public void UseTime() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Ambient, void>)0x005524A0)(ref this);

    /// <summary>Updates the ambient sound queue by iterating over all registered sounds, invoking each sound’s update logic with the current context, and initiating playback for those that become ready to play.
    /// <code>Offset: 0x00552670
    /// char __thiscall Ambient::UpdatePlayQueue(Ambient*)</code>
    /// </summary>
    /// <returns>The number of ambient sounds processed (or zero if ambient sound playback is disabled), returned as a char value.</returns>
    public sbyte UpdatePlayQueue() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Ambient, sbyte>)0x00552670)(ref this);
}

