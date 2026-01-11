namespace ACBindings.Internal;

public unsafe struct SoundManager
{
    // Statics
    public static int* VOL_MIN = (int*)0x00820070;
    public static float* effect_sound_volume = (float*)0x00820078;
    public static float* ambient_sound_volume = (float*)0x00820080;
    public static uint* s_SoundFeatures = (uint*)0x008703B4;
    public static int* curr_playing_buffer_ = (int*)0x008703B8;
    public static ACBindings.Internal.SoundPlayingData* playing_sounds_ = (ACBindings.Internal.SoundPlayingData*)0x00870520;

    // Methods

    /// <summary>
    /// <code>Offset: 0x00550AD0
    /// void __cdecl SoundManager::PlaySoundInternal(SoundBufRef*,int,int)</code>
    /// </summary>
    public static void PlaySoundInternal(ACBindings.Internal.SoundBufRef* current_sound, int pan, int attenuation) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.SoundBufRef*, int, int, void>)0x00550AD0)(current_sound, pan, attenuation);

    /// <summary>
    /// <code>Offset: 0x00550C30
    /// int __cdecl SoundManager::GetAttenuation(float,float,int*,int)</code>
    /// </summary>
    public static int GetAttenuation(float distance, float volume, int* attenuation, int is_ambient) => ((delegate* unmanaged[Cdecl]<float, float, int*, int, int>)0x00550C30)(distance, volume, attenuation, is_ambient);

    /// <summary>
    /// <code>Offset: 0x00550CF0
    /// int __cdecl SoundManager::PlayProbability(float)</code>
    /// </summary>
    public static int PlayProbability(float probability) => ((delegate* unmanaged[Cdecl]<float, int>)0x00550CF0)(probability);

    /// <summary>
    /// <code>Offset: 0x00550D80
    /// void __cdecl SoundManager::PlaySoundInternal(SoundBufRef*,const Position*,float,int)</code>
    /// </summary>
    public static void PlaySoundInternal(ACBindings.Internal.SoundBufRef* current_sound, ACBindings.Internal.Position* pos, float volume, int is_ambient) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.SoundBufRef*, ACBindings.Internal.Position*, float, int, void>)0x00550D80)(current_sound, pos, volume, is_ambient);

    /// <summary>
    /// <code>Offset: 0x00550EC0
    /// void __cdecl SoundManager::ShutDown()</code>
    /// </summary>
    public static void ShutDown() => ((delegate* unmanaged[Cdecl]<void>)0x00550EC0)();

    /// <summary>
    /// <code>Offset: 0x00550FD0
    /// void __cdecl SoundManager::SetPlayerPosition(const Position*)</code>
    /// </summary>
    public static void SetPlayerPosition(ACBindings.Internal.Position* pos) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.Position*, void>)0x00550FD0)(pos);

    /// <summary>
    /// <code>Offset: 0x00551000
    /// void __cdecl SoundManager::InitPrefs()</code>
    /// </summary>
    public static void InitPrefs() => ((delegate* unmanaged[Cdecl]<void>)0x00551000)();

    /// <summary>
    /// <code>Offset: 0x00551250
    /// void __cdecl SoundManager::Init(HWND__*)</code>
    /// </summary>
    public static void Init(int* hwnd) => ((delegate* unmanaged[Cdecl]<int*, void>)0x00551250)(hwnd);

    /// <summary>
    /// <code>Offset: 0x00551290
    /// SoundBufRef* __cdecl SoundManager::GetSound(SoundType,const CSoundTable*,SoundData*)</code>
    /// </summary>
    public static ACBindings.Internal.SoundBufRef* GetSound(ACBindings.Internal.SoundType stype, ACBindings.Internal.CSoundTable* sound_table, ACBindings.Internal.SoundData* stdata) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.SoundType, ACBindings.Internal.CSoundTable*, ACBindings.Internal.SoundData*, ACBindings.Internal.SoundBufRef*>)0x00551290)(stype, sound_table, stdata);

    /// <summary>
    /// <code>Offset: 0x00551340
    /// void __cdecl SoundManager::PlaySoundA(unsigned int,const Position*)</code>
    /// </summary>
    public static void PlaySoundA(uint a1, ACBindings.Internal.Position* a2) => ((delegate* unmanaged[Cdecl]<uint, ACBindings.Internal.Position*, void>)0x00551340)(a1, a2);

    /// <summary>
    /// <code>Offset: 0x005513B0
    /// void __cdecl SoundManager::PlaySoundA(unsigned int,const Position*,int,float,float)</code>
    /// </summary>
    public static void PlaySoundA(uint a1, ACBindings.Internal.Position* a2, int a3, float probability, float volume) => ((delegate* unmanaged[Cdecl]<uint, ACBindings.Internal.Position*, int, float, float, void>)0x005513B0)(a1, a2, a3, probability, volume);

    /// <summary>
    /// <code>Offset: 0x00551430
    /// void __cdecl SoundManager::PlayAmbientSound(SoundType,const CSoundTable*,const Position*,float)</code>
    /// </summary>
    public static void PlayAmbientSound(ACBindings.Internal.SoundType stype, ACBindings.Internal.CSoundTable* sound_table, ACBindings.Internal.Position* pos, float volume) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.SoundType, ACBindings.Internal.CSoundTable*, ACBindings.Internal.Position*, float, void>)0x00551430)(stype, sound_table, pos, volume);

    /// <summary>
    /// <code>Offset: 0x005514C0
    /// void __cdecl SoundManager::PlayAmbientSoundFromCenter(SoundType,const CSoundTable*,float)</code>
    /// </summary>
    public static void PlayAmbientSoundFromCenter(ACBindings.Internal.SoundType stype, ACBindings.Internal.CSoundTable* sound_table, float center_volume) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.SoundType, ACBindings.Internal.CSoundTable*, float, void>)0x005514C0)(stype, sound_table, center_volume);

    /// <summary>
    /// <code>Offset: 0x00551560
    /// void __cdecl SoundManager::PlaySoundFromCenter(SoundType,const CSoundTable*)</code>
    /// </summary>
    public static void PlaySoundFromCenter(ACBindings.Internal.SoundType stype, ACBindings.Internal.CSoundTable* sound_table) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.SoundType, ACBindings.Internal.CSoundTable*, void>)0x00551560)(stype, sound_table);

    /// <summary>
    /// <code>Offset: 0x005515F0
    /// void __cdecl SoundManager::PlaySoundFromCenter(unsigned int,float)</code>
    /// </summary>
    public static void PlaySoundFromCenter(uint a1, float volume) => ((delegate* unmanaged[Cdecl]<uint, float, void>)0x005515F0)(a1, volume);

    /// <summary>
    /// <code>Offset: 0x00551700
    /// void __cdecl SoundManager::PlaySoundA(SoundType,const CPhysicsObj*,float)</code>
    /// </summary>
    public static void PlaySoundA(ACBindings.Internal.SoundType stype, ACBindings.Internal.CPhysicsObj* physobj, float volume) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.SoundType, ACBindings.Internal.CPhysicsObj*, float, void>)0x00551700)(stype, physobj, volume);

    /// <summary>
    /// <code>Offset: 0x00551780
    /// void __cdecl SoundManager::PlaySoundA(SoundType,const CPhysicsObj*)</code>
    /// </summary>
    public static void PlaySoundA(ACBindings.Internal.SoundType stype, ACBindings.Internal.CPhysicsObj* physobj) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.SoundType, ACBindings.Internal.CPhysicsObj*, void>)0x00551780)(stype, physobj);

    /// <summary>
    /// <code>Offset: 0x00551800
    /// char __cdecl SoundManager::CreateSound(unsigned int)</code>
    /// </summary>
    public static sbyte CreateSound(uint a1) => ((delegate* unmanaged[Cdecl]<uint, sbyte>)0x00551800)(a1);

    /// <summary>
    /// <code>Offset: 0x00551870
    /// void __cdecl SoundManager::DestroySound(unsigned int)</code>
    /// </summary>
    public static void DestroySound(uint a1) => ((delegate* unmanaged[Cdecl]<uint, void>)0x00551870)(a1);
}

