namespace ACBindings;

// Ambient
public unsafe struct Ambient : System.IDisposable
{
    // Statics
    public static float* ambient_sound_min_dist = (float*)0x00820158;
    public static float* ambient_sound_min_dist_sq = (float*)0x0082015C;
    public static float* ambient_sound_max_dist_sq = (float*)0x00820164;
    public static float* ambient_sound_min_vol = (float*)0x00820168;

    // Members
    public ACBindings.Position player_pos;
    public float total_sound_count;
    public uint num_sounds;
    public ACBindings.DArray__AmbientSound_ptr sounds;
    public ACBindings.AC1Legacy.PQueueArray__double sound_queue;

    // Generated Constructor
    public Ambient() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // unsigned int __thiscall Ambient::FlushSoundTables(Ambient*)
    public uint FlushSoundTables() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Ambient, uint>)0x00452960)(ref this);
    // unsigned int __thiscall Ambient::ReleaseSoundTables(Ambient*)
    public uint ReleaseSoundTables() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Ambient, uint>)0x00455890)(ref this);
    // void __stdcall Ambient::PlaySoundA(SoundType,CSoundTable*,Position*,float)
    public static void PlaySoundA(ACBindings.SoundType stype, ACBindings.CSoundTable* sound_table, ACBindings.Position* pos, float center_volume) => ((delegate* unmanaged[Stdcall]<ACBindings.SoundType, ACBindings.CSoundTable*, ACBindings.Position*, float, void>)0x005519B0)(stype, sound_table, pos, center_volume);
    // double __thiscall Ambient::CalcWeight(Ambient*,const Vector3*)
    public double CalcWeight(ACBindings.Vector3* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Ambient, ACBindings.Vector3*, double>)0x005519F0)(ref this, a2);
    // int __thiscall Ambient::CalcDir(Ambient*,const Vector3*)
    public int CalcDir(ACBindings.Vector3* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Ambient, ACBindings.Vector3*, int>)0x00551A60)(ref this, a2);
    // int __thiscall Ambient::GetSound(Ambient*,AmbientSTBDesc*,unsigned int)
    public int GetSound(ACBindings.AmbientSTBDesc* a2, uint a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Ambient, ACBindings.AmbientSTBDesc*, uint, int>)0x00551CD0)(ref this, a2, a3);
    // unsigned int __thiscall Ambient::Destroy(Ambient*)
    public uint Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Ambient, uint>)0x005521A0)(ref this);
    // unsigned int __thiscall Ambient::InitSounds(Ambient*,const Position*)
    public uint InitSounds(ACBindings.Position* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Ambient, ACBindings.Position*, uint>)0x005521F0)(ref this, a2);
    // void __thiscall Ambient::AddSound(Position*,AmbientSTBDesc*,Position*)
    public void AddSound(ACBindings.AmbientSTBDesc* a2, ACBindings.Position* p) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Ambient, ACBindings.AmbientSTBDesc*, ACBindings.Position*, void>)0x00552230)(ref this, a2, p);
    // Ambient* __thiscall Ambient::Ambient(Ambient*)
    public ACBindings.Ambient* _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Ambient, ACBindings.Ambient*>)0x00552300)(ref this);
    // void __thiscall Ambient::~Ambient(Ambient*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Ambient, void>)0x00552380)(ref this);
    // int __thiscall Ambient::Play(_DWORD*,_DWORD*)
    public int Play(int* center_volume) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Ambient, int*, int>)0x005523C0)(ref this, center_volume);
    // void __thiscall Ambient::UseTime(Ambient*)
    public void UseTime() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Ambient, void>)0x005524A0)(ref this);
    // char __thiscall Ambient::UpdatePlayQueue(Ambient*)
    public sbyte UpdatePlayQueue() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Ambient, sbyte>)0x00552670)(ref this);
}

