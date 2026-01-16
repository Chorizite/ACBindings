namespace ACBindings.Internal;


/// <summary>Manages the game's audio subsystem, handling initialization, preference registration, buffer caching, and playback of ambient, interface, and effect sounds. Applies attenuation, probability, and priority logic across a limited pool of simultaneous streams.</summary>
public unsafe struct SoundManager
{
    // Statics
    public static int* VOL_MIN = (int*)0x00820070;
    public static byte* effect_sounds_enabled = (byte*)0x00820074;
    public static float* effect_sound_volume = (float*)0x00820078;
    public static byte* ambient_sounds_enabled = (byte*)0x0082007C;
    public static float* ambient_sound_volume = (float*)0x00820080;
    public static byte* interface_sounds_enabled = (byte*)0x00820084;
    public static float* interface_sound_volume = (float*)0x00820088;
    public static byte* s_bPlaySoundOnlyWhenActive = (byte*)0x0082008C;
    public static ACBindings.Internal.Position* player_position_ = (ACBindings.Internal.Position*)0x008200F0;
    public static uint* s_SoundFeatures = (uint*)0x008703B4;
    public static int* curr_playing_buffer_ = (int*)0x008703B8;
    public static byte* s_bInittedPrefs = (byte*)0x008703BC;
    public static ACBindings.Internal.IntrusiveHashTable___IDClass____tagDataID___SoundBufRef_ptr* sound_hash_ = (ACBindings.Internal.IntrusiveHashTable___IDClass____tagDataID___SoundBufRef_ptr*)0x008704B0;
    public static ACBindings.Internal.SoundPlayingData** playing_sounds_ = (ACBindings.Internal.SoundPlayingData**)0x00870520;

    // Methods

    /// <summary>Plays the sound referenced by current_sound, allocating a slot in an internal pool of 16 simultaneous buffers and respecting priority when all slots are occupied. Playback occurs only if the global play flag permits or the application is active.
    /// <code>Offset: 0x00550AD0
    /// void __cdecl SoundManager::PlaySoundInternal(SoundBufRef*,int,int)</code>
    /// </summary>
    /// <param name="current_sound">The SoundBufRef containing data for the sound to be played.</param>
    /// <param name="pan">Stereo panning value forwarded to the underlying sound buffer.</param>
    /// <param name="attenuation">Attenuation factor (volume reduction) applied during playback.</param>
    public static void PlaySoundInternal(ACBindings.Internal.SoundBufRef* current_sound, int pan, int attenuation) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.SoundBufRef*, int, int, void>)0x00550AD0)(current_sound, pan, attenuation);

    /// <summary>Computes the attenuation for a sound source based on distance, volume and ambient flag, storing the result in the supplied output parameter.
    /// <code>Offset: 0x00550C30
    /// int __cdecl SoundManager::GetAttenuation(float,float,int*,int)</code>
    /// </summary>
    /// <param name="distance">Distance from the listener to the sound source.</param>
    /// <param name="volume">Base volume of the sound before attenuation.</param>
    /// <param name="attenuation">Pointer to an int that receives the computed attenuation value (clamped to the minimum allowed level).</param>
    /// <param name="is_ambient">Flag indicating whether the sound is ambient or an effect, selecting the appropriate global multiplier.</param>
    /// <returns>Non‑zero if the calculated attenuation meets or exceeds the system's minimum threshold; zero when the resulting value is below that threshold, in which case *attenuation is set to the minimum level.</returns>
    public static int GetAttenuation(float distance, float volume, int* attenuation, int is_ambient) => ((delegate* unmanaged[Cdecl]<float, float, int*, int, int>)0x00550C30)(distance, volume, attenuation, is_ambient);

    /// <summary>Determines whether to trigger an action based on a supplied probability threshold by comparing a randomly generated value against the threshold.
    /// <code>Offset: 0x00550CF0
    /// int __cdecl SoundManager::PlayProbability(float)</code>
    /// </summary>
    /// <param name="probability">Probability value between 0 and 1 indicating the likelihood of triggering the action.</param>
    /// <returns>Integer 1 if random value falls below the specified probability; otherwise 0.</returns>
    public static int PlayProbability(float probability) => ((delegate* unmanaged[Cdecl]<float, int>)0x00550CF0)(probability);

    /// <summary>Plays a sound using the provided sound buffer reference, applying spatial attenuation based on source position relative to the player and honoring an ambient flag. Only triggers playback when the application is active.
    /// <code>Offset: 0x00550D80
    /// void __cdecl SoundManager::PlaySoundInternal(SoundBufRef*,const Position*,float,int)</code>
    /// </summary>
    /// <param name="current_sound">Reference to the sound buffer that should be played.</param>
    /// <param name="pos">World-space position of the sound source.</param>
    /// <param name="volume">Base volume level for the sound.</param>
    /// <param name="is_ambient">Indicates whether the sound is ambient (no positional effect).</param>
    public static void PlaySoundInternal(ACBindings.Internal.SoundBufRef* current_sound, ACBindings.Internal.Position* pos, float volume, int is_ambient) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.SoundBufRef*, ACBindings.Internal.Position*, float, int, void>)0x00550D80)(current_sound, pos, volume, is_ambient);

    /// <summary>Shuts down the sound manager by stopping all active sounds, releasing buffers, cleaning up MIDI resources, and unregistering associated configuration variables if they were initialized.
    /// <code>Offset: 0x00550EC0
    /// void __cdecl SoundManager::ShutDown()</code>
    /// </summary>
    public static void ShutDown() => ((delegate* unmanaged[Cdecl]<void>)0x00550EC0)();

    /// <summary>Updates the SoundManager's internal player position data from a supplied Position object.
    /// <code>Offset: 0x00550FD0
    /// void __cdecl SoundManager::SetPlayerPosition(const Position*)</code>
    /// </summary>
    /// <param name="pos">The Position instance containing new cell ID and frame information.</param>
    public static void SetPlayerPosition(ACBindings.Internal.Position* pos) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.Position*, void>)0x00550FD0)(pos);

    /// <summary>Registers a set of sound‑related preferences—including volume controls, enable/disable toggles, and feature flags—with the user preference system, initializing internal state for the SoundManager.
    /// <code>Offset: 0x00551000
    /// void __cdecl SoundManager::InitPrefs()</code>
    /// </summary>
    public static void InitPrefs() => ((delegate* unmanaged[Cdecl]<void>)0x00551000)();

    /// <summary>Initializes sound subsystem using provided window handle: loads preferences, configures audio and MIDI, and seeds random number generator or disables effect sounds based on system settings.
    /// <code>Offset: 0x00551250
    /// void __cdecl SoundManager::Init(HWND__*)</code>
    /// </summary>
    /// <param name="hwnd">Handle to the application's main window used for audio initialization.</param>
    public static void Init(int* hwnd) => ((delegate* unmanaged[Cdecl]<int*, void>)0x00551250)(hwnd);

    /// <summary>Retrieves a sound buffer reference matching the requested SoundType from the given CSoundTable, selecting one randomly among available options and populating the provided SoundData structure.
    /// <code>Offset: 0x00551290
    /// SoundBufRef* __cdecl SoundManager::GetSound(SoundType,const CSoundTable*,SoundData*)</code>
    /// </summary>
    /// <param name="stype">The type of sound to retrieve.</param>
    /// <param name="sound_table">The table containing sound entries for various types.</param>
    /// <param name="stdata">Receives the chosen SoundData entry; must be non‑null when a match is found.</param>
    /// <returns>Pointer to the corresponding SoundBufRef if a matching sound exists, otherwise null.</returns>
    public static ACBindings.Internal.SoundBufRef* GetSound(ACBindings.Internal.SoundType stype, ACBindings.Internal.CSoundTable* sound_table, ACBindings.Internal.SoundData* stdata) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.SoundType, ACBindings.Internal.CSoundTable*, ACBindings.Internal.SoundData*, ACBindings.Internal.SoundBufRef*>)0x00551290)(stype, sound_table, stdata);

    /// <summary>Plays an effect sound identified by the specified ID at a location derived from the supplied Position data when effects are enabled and the application is active.
    /// <code>Offset: 0x00551340
    /// void __cdecl SoundManager::PlaySoundA(unsigned int,const Position*)</code>
    /// </summary>
    /// <param name="a1">Identifier of the sound to play, used as a hash key into the internal sound table.</param>
    /// <param name="a2">Pointer to a Position structure specifying the spatial coordinates for the sound source; an offset of one element is applied internally.</param>
    public static void PlaySoundA(uint a1, ACBindings.Internal.Position* a2) => ((delegate* unmanaged[Cdecl]<uint, ACBindings.Internal.Position*, void>)0x00551340)(a1, a2);

    /// <summary>Plays a registered sound effect identified by its ID at the specified position, subject to global enablement, application activity, and a probability check.
    /// <code>Offset: 0x005513B0
    /// void __cdecl SoundManager::PlaySoundA(unsigned int,const Position*,int,float,float)</code>
    /// </summary>
    /// <param name="a1">Sound identifier used to look up the sound buffer in the internal hash table.</param>
    /// <param name="a2">Pointer to Position structure indicating where the sound originates; an offset is applied when passed internally.</param>
    /// <param name="a3">Unused parameter reserved for future extensions or channel selection.</param>
    /// <param name="probability">Probability threshold (0.0–1.0) that determines whether the sound actually plays.</param>
    /// <param name="volume">Volume multiplier applied to the playback of the sound.</param>
    public static void PlaySoundA(uint a1, ACBindings.Internal.Position* a2, int a3, float probability, float volume) => ((delegate* unmanaged[Cdecl]<uint, ACBindings.Internal.Position*, int, float, float, void>)0x005513B0)(a1, a2, a3, probability, volume);

    /// <summary>Plays an ambient sound of the specified type at a given position and volume, subject to global enablement and per‑sound probability.
    /// <code>Offset: 0x00551430
    /// void __cdecl SoundManager::PlayAmbientSound(SoundType,const CSoundTable*,const Position*,float)</code>
    /// </summary>
    /// <param name="stype">The enumerated type identifying which ambient sound to play.</param>
    /// <param name="sound_table">A table containing data for the requested sound type.</param>
    /// <param name="pos">The spatial location at which the sound should originate.</param>
    /// <param name="volume">Relative volume multiplier applied to the global ambient sound level.</param>
    public static void PlayAmbientSound(ACBindings.Internal.SoundType stype, ACBindings.Internal.CSoundTable* sound_table, ACBindings.Internal.Position* pos, float volume) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.SoundType, ACBindings.Internal.CSoundTable*, ACBindings.Internal.Position*, float, void>)0x00551430)(stype, sound_table, pos, volume);

    /// <summary>Plays an ambient sound of the specified type at the given center volume, respecting global ambient settings and sound table data.
    /// <code>Offset: 0x005514C0
    /// void __cdecl SoundManager::PlayAmbientSoundFromCenter(SoundType,const CSoundTable*,float)</code>
    /// </summary>
    /// <param name="stype">The type of ambient sound to play.</param>
    /// <param name="sound_table">Pointer to a CSoundTable containing metadata for the sound.</param>
    /// <param name="center_volume">Relative volume multiplier applied to the ambient sound's base volume before attenuation.</param>
    public static void PlayAmbientSoundFromCenter(ACBindings.Internal.SoundType stype, ACBindings.Internal.CSoundTable* sound_table, float center_volume) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.SoundType, ACBindings.Internal.CSoundTable*, float, void>)0x005514C0)(stype, sound_table, center_volume);

    /// <summary>Plays a specified sound from the center of the scene based on the provided sound type and table, respecting global sound settings, play probability, and attenuation.
    /// <code>Offset: 0x00551560
    /// void __cdecl SoundManager::PlaySoundFromCenter(SoundType,const CSoundTable*)</code>
    /// </summary>
    /// <param name="stype">The SoundType value identifying which sound to play.</param>
    /// <param name="sound_table">A pointer to a CSoundTable that supplies data for the requested sound.</param>
    public static void PlaySoundFromCenter(ACBindings.Internal.SoundType stype, ACBindings.Internal.CSoundTable* sound_table) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.SoundType, ACBindings.Internal.CSoundTable*, void>)0x00551560)(stype, sound_table);

    /// <summary>Plays the sound identified by the given ID at the center of the scene with the specified volume, applying global sound settings and attenuation.
    /// <code>Offset: 0x005515F0
    /// void __cdecl SoundManager::PlaySoundFromCenter(unsigned int,float)</code>
    /// </summary>
    /// <param name="a1">The unique identifier of the sound to play.</param>
    /// <param name="volume">The desired playback volume (0.0–1.0).</param>
    public static void PlaySoundFromCenter(uint a1, float volume) => ((delegate* unmanaged[Cdecl]<uint, float, void>)0x005515F0)(a1, volume);

    /// <summary>Play a sound effect based on the given type at the position of the specified physics object, considering enabled effects, application activity status, and playback probability.
    /// <code>Offset: 0x00551700
    /// void __cdecl SoundManager::PlaySoundA(SoundType,const CPhysicsObj*,float)</code>
    /// </summary>
    /// <param name="stype">The enumeration value specifying which sound to play.</param>
    /// <param name="physobj">Pointer to the physics object whose position determines where the sound originates and from which its sound table is queried.</param>
    /// <param name="volume">The desired playback volume (typically 0.0f to 1.0f).</param>
    public static void PlaySoundA(ACBindings.Internal.SoundType stype, ACBindings.Internal.CPhysicsObj* physobj, float volume) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.SoundType, ACBindings.Internal.CPhysicsObj*, float, void>)0x00551700)(stype, physobj, volume);

    /// <summary>Plays a sound tied to the specified physics object when effect sounds are enabled and either the application is active or playback in inactive state is permitted.
    /// <code>Offset: 0x00551780
    /// void __cdecl SoundManager::PlaySoundA(SoundType,const CPhysicsObj*)</code>
    /// </summary>
    /// <param name="stype">Sound type identifier.</param>
    /// <param name="physobj">Physics object that supplies position and optional sound table for the source.</param>
    public static void PlaySoundA(ACBindings.Internal.SoundType stype, ACBindings.Internal.CPhysicsObj* physobj) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.SoundType, ACBindings.Internal.CPhysicsObj*, void>)0x00551780)(stype, physobj);

    /// <summary>Creates or retrieves a sound buffer reference for the specified ID, incrementing its link count when already present.
    /// <code>Offset: 0x00551800
    /// char __cdecl SoundManager::CreateSound(unsigned int)</code>
    /// </summary>
    /// <param name="a1">The unique identifier of the sound to create or retrieve.</param>
    /// <returns>A non‑zero value if the operation succeeds; otherwise zero.</returns>
    public static sbyte CreateSound(uint a1) => ((delegate* unmanaged[Cdecl]<uint, sbyte>)0x00551800)(a1);

    /// <summary>Destroys the sound identified by the supplied ID, removing it from the manager when no longer referenced.
    /// <code>Offset: 0x00551870
    /// void __cdecl SoundManager::DestroySound(unsigned int)</code>
    /// </summary>
    /// <param name="a1">The unique identifier of the sound to be destroyed.</param>
    public static void DestroySound(uint a1) => ((delegate* unmanaged[Cdecl]<uint, void>)0x00551870)(a1);
}

