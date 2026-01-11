namespace ACBindings.Internal;

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

    /// <summary>
    /// <code>Offset: 0x00452960
    /// unsigned int __thiscall Ambient::FlushSoundTables(Ambient*)</code>
    /// </summary>
    public uint FlushSoundTables() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Ambient, uint>)0x00452960)(ref this);

    /// <summary>
    /// <code>Offset: 0x00455890
    /// unsigned int __thiscall Ambient::ReleaseSoundTables(Ambient*)</code>
    /// </summary>
    public uint ReleaseSoundTables() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Ambient, uint>)0x00455890)(ref this);

    /// <summary>
    /// <code>Offset: 0x005519B0
    /// void __stdcall Ambient::PlaySoundA(SoundType,CSoundTable*,Position*,float)</code>
    /// </summary>
    public static void PlaySoundA(ACBindings.Internal.SoundType stype, ACBindings.Internal.CSoundTable* sound_table, ACBindings.Internal.Position* pos, float center_volume) => ((delegate* unmanaged[Stdcall]<ACBindings.Internal.SoundType, ACBindings.Internal.CSoundTable*, ACBindings.Internal.Position*, float, void>)0x005519B0)(stype, sound_table, pos, center_volume);

    /// <summary>
    /// <code>Offset: 0x005519F0
    /// double __thiscall Ambient::CalcWeight(Ambient*,const Vector3*)</code>
    /// </summary>
    public double CalcWeight(ACBindings.Internal.Vector3* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Ambient, ACBindings.Internal.Vector3*, double>)0x005519F0)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x00551A60
    /// int __thiscall Ambient::CalcDir(Ambient*,const Vector3*)</code>
    /// </summary>
    public int CalcDir(ACBindings.Internal.Vector3* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Ambient, ACBindings.Internal.Vector3*, int>)0x00551A60)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x00551CD0
    /// int __thiscall Ambient::GetSound(Ambient*,AmbientSTBDesc*,unsigned int)</code>
    /// </summary>
    public int GetSound(ACBindings.Internal.AmbientSTBDesc* a2, uint a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Ambient, ACBindings.Internal.AmbientSTBDesc*, uint, int>)0x00551CD0)(ref this, a2, a3);

    /// <summary>
    /// <code>Offset: 0x005521A0
    /// unsigned int __thiscall Ambient::Destroy(Ambient*)</code>
    /// </summary>
    public uint Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Ambient, uint>)0x005521A0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005521F0
    /// unsigned int __thiscall Ambient::InitSounds(Ambient*,const Position*)</code>
    /// </summary>
    public uint InitSounds(ACBindings.Internal.Position* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Ambient, ACBindings.Internal.Position*, uint>)0x005521F0)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x00552230
    /// void __thiscall Ambient::AddSound(Position*,AmbientSTBDesc*,Position*)</code>
    /// </summary>
    public void AddSound(ACBindings.Internal.AmbientSTBDesc* a2, ACBindings.Internal.Position* p) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Ambient, ACBindings.Internal.AmbientSTBDesc*, ACBindings.Internal.Position*, void>)0x00552230)(ref this, a2, p);

    /// <summary>
    /// <code>Offset: 0x00552300
    /// Ambient* __thiscall Ambient::Ambient(Ambient*)</code>
    /// </summary>
    public ACBindings.Internal.Ambient* _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Ambient, ACBindings.Internal.Ambient*>)0x00552300)(ref this);

    /// <summary>
    /// <code>Offset: 0x00552380
    /// void __thiscall Ambient::~Ambient(Ambient*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Ambient, void>)0x00552380)(ref this);

    /// <summary>
    /// <code>Offset: 0x005523C0
    /// int __thiscall Ambient::Play(_DWORD*,_DWORD*)</code>
    /// </summary>
    public int Play(int* center_volume) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Ambient, int*, int>)0x005523C0)(ref this, center_volume);

    /// <summary>
    /// <code>Offset: 0x005524A0
    /// void __thiscall Ambient::UseTime(Ambient*)</code>
    /// </summary>
    public void UseTime() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Ambient, void>)0x005524A0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00552670
    /// char __thiscall Ambient::UpdatePlayQueue(Ambient*)</code>
    /// </summary>
    public sbyte UpdatePlayQueue() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Ambient, sbyte>)0x00552670)(ref this);
}

