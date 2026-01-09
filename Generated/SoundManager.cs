namespace ACBindings;

// SoundManager
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
    public static ACBindings.Position* player_position_ = (ACBindings.Position*)0x008200F4;
    public static ACBindings.IntrusiveHashTable__IDClass___tagDataID__SoundBufRef_ptr* sound_hash_ = (ACBindings.IntrusiveHashTable__IDClass___tagDataID__SoundBufRef_ptr*)0x0086FCAC;
    public static uint* s_SoundFeatures = (uint*)0x0086FE90;
    public static int* curr_playing_buffer_ = (int*)0x0086FEC4;

    // Methods
    // void __cdecl SoundManager::PlaySoundInternal(SoundBufRef*,int,int)
    public static void PlaySoundInternal(ACBindings.SoundBufRef* current_sound, int pan, int attenuation) => ((delegate* unmanaged[Cdecl]<ACBindings.SoundBufRef*, int, int, void>)0x00550AD0)(current_sound, pan, attenuation);
    // int __cdecl SoundManager::GetAttenuation(float,float,int*,int)
    public static int GetAttenuation(float distance, float volume, int* attenuation, int is_ambient) => ((delegate* unmanaged[Cdecl]<float, float, int*, int, int>)0x00550C30)(distance, volume, attenuation, is_ambient);
    // int __cdecl SoundManager::PlayProbability(float)
    public static int PlayProbability(float probability) => ((delegate* unmanaged[Cdecl]<float, int>)0x00550CF0)(probability);
    // void __cdecl SoundManager::PlaySoundInternal(SoundBufRef*,const Position*,float,int)
    public static void PlaySoundInternal(ACBindings.SoundBufRef* current_sound, ACBindings.Position* pos, float volume, int is_ambient) => ((delegate* unmanaged[Cdecl]<ACBindings.SoundBufRef*, ACBindings.Position*, float, int, void>)0x00550D80)(current_sound, pos, volume, is_ambient);
    // void __cdecl SoundManager::ShutDown()
    public static void ShutDown() => ((delegate* unmanaged[Cdecl]<void>)0x00550EC0)();
    // void __cdecl SoundManager::SetPlayerPosition(const Position*)
    public static void SetPlayerPosition(ACBindings.Position* pos) => ((delegate* unmanaged[Cdecl]<ACBindings.Position*, void>)0x00550FD0)(pos);
    // void __cdecl SoundManager::InitPrefs()
    public static void InitPrefs() => ((delegate* unmanaged[Cdecl]<void>)0x00551000)();
    // void __cdecl SoundManager::Init(HWND__*)
    public static void Init(int* hwnd) => ((delegate* unmanaged[Cdecl]<int*, void>)0x00551250)(hwnd);
    // SoundBufRef* __cdecl SoundManager::GetSound(SoundType,const CSoundTable*,SoundData*)
    public static ACBindings.SoundBufRef* GetSound(ACBindings.SoundType stype, ACBindings.CSoundTable* sound_table, ACBindings.SoundData* stdata) => ((delegate* unmanaged[Cdecl]<ACBindings.SoundType, ACBindings.CSoundTable*, ACBindings.SoundData*, ACBindings.SoundBufRef*>)0x00551290)(stype, sound_table, stdata);
    // void __cdecl SoundManager::PlaySoundA(unsigned int,const Position*)
    public static void PlaySoundA(uint a1, ACBindings.Position* a2) => ((delegate* unmanaged[Cdecl]<uint, ACBindings.Position*, void>)0x00551340)(a1, a2);
    // void __cdecl SoundManager::PlaySoundA(unsigned int,const Position*,int,float,float)
    public static void PlaySoundA(uint a1, ACBindings.Position* a2, int a3, float probability, float volume) => ((delegate* unmanaged[Cdecl]<uint, ACBindings.Position*, int, float, float, void>)0x005513B0)(a1, a2, a3, probability, volume);
    // void __cdecl SoundManager::PlayAmbientSound(SoundType,const CSoundTable*,const Position*,float)
    public static void PlayAmbientSound(ACBindings.SoundType stype, ACBindings.CSoundTable* sound_table, ACBindings.Position* pos, float volume) => ((delegate* unmanaged[Cdecl]<ACBindings.SoundType, ACBindings.CSoundTable*, ACBindings.Position*, float, void>)0x00551430)(stype, sound_table, pos, volume);
    // void __cdecl SoundManager::PlayAmbientSoundFromCenter(SoundType,const CSoundTable*,float)
    public static void PlayAmbientSoundFromCenter(ACBindings.SoundType stype, ACBindings.CSoundTable* sound_table, float center_volume) => ((delegate* unmanaged[Cdecl]<ACBindings.SoundType, ACBindings.CSoundTable*, float, void>)0x005514C0)(stype, sound_table, center_volume);
    // void __cdecl SoundManager::PlaySoundFromCenter(SoundType,const CSoundTable*)
    public static void PlaySoundFromCenter(ACBindings.SoundType stype, ACBindings.CSoundTable* sound_table) => ((delegate* unmanaged[Cdecl]<ACBindings.SoundType, ACBindings.CSoundTable*, void>)0x00551560)(stype, sound_table);
    // void __cdecl SoundManager::PlaySoundFromCenter(unsigned int,float)
    public static void PlaySoundFromCenter(uint a1, float volume) => ((delegate* unmanaged[Cdecl]<uint, float, void>)0x005515F0)(a1, volume);
    // void __cdecl SoundManager::PlaySoundA(SoundType,const CPhysicsObj*,float)
    public static void PlaySoundA(ACBindings.SoundType stype, ACBindings.CPhysicsObj* physobj, float volume) => ((delegate* unmanaged[Cdecl]<ACBindings.SoundType, ACBindings.CPhysicsObj*, float, void>)0x00551700)(stype, physobj, volume);
    // void __cdecl SoundManager::PlaySoundA(SoundType,const CPhysicsObj*)
    public static void PlaySoundA(ACBindings.SoundType stype, ACBindings.CPhysicsObj* physobj) => ((delegate* unmanaged[Cdecl]<ACBindings.SoundType, ACBindings.CPhysicsObj*, void>)0x00551780)(stype, physobj);
    // char __cdecl SoundManager::CreateSound(unsigned int)
    public static sbyte CreateSound(uint a1) => ((delegate* unmanaged[Cdecl]<uint, sbyte>)0x00551800)(a1);
    // void __cdecl SoundManager::DestroySound(unsigned int)
    public static void DestroySound(uint a1) => ((delegate* unmanaged[Cdecl]<uint, void>)0x00551870)(a1);
}

