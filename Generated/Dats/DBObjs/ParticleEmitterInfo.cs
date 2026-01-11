namespace ACBindings.Internal;

public unsafe struct ParticleEmitterInfo
{
    // Base Classes
    public ACBindings.Internal.SerializeUsingPackDBObj BaseClass_SerializeUsingPackDBObj; // ACBindings.Internal.SerializeUsingPackDBObj

    // Child Types
    public unsafe struct ParticleEmitterInfo_vtbl
    {
        // Members
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, ACBindings.Internal._GUID*, void**, int> IUnknown_QueryInterface; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_AddRef; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_Release; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, ACBindings.Internal.TResult*, ACBindings.Internal.Turbine_GUID*, void**, ACBindings.Internal.TResult*> QueryInterface; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> AddRef; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> Release; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, void> DBObj_dtor_18; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.Archive*, void> Serialize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.QualifiedDataIDArray*, void> GetSubDataIDs; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> InitLoad; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> GetSubObjects; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> ReleaseSubObjects; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> NotifyFidelityLevel; // function pointer
        public System.IntPtr Refresh;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.DBObj*, byte> CopyInto; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, void> Destroy; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.IDataGraph*, void> FillDataGraph; // function pointer
        public System.IntPtr SetDID;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, uint> GetDBOType; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.DBObj*> Allocate; // function pointer
        public System.IntPtr SaveToDisk;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> ReloadFromDisk; // function pointer

        // Methods
    }

    // Members
    public int emitter_type;
    public int particle_type;
    public int is_parent_local;
    public ACBindings.Internal.IDClass____tagDataID gfxobj_id;
    public ACBindings.Internal.IDClass____tagDataID hw_gfxobj_id;
    public double birthrate;
    public int max_particles;
    public int initial_particles;
    public int total_particles;
    public double total_seconds;
    public double lifespan_rand;
    public double lifespan;
    public ACBindings.Internal.CSphere sorting_sphere;
    public ACBindings.Internal.AC1Legacy.Vector3 offset_dir;
    public float min_offset;
    public float max_offset;
    public ACBindings.Internal.AC1Legacy.Vector3 a;
    public ACBindings.Internal.AC1Legacy.Vector3 b;
    public ACBindings.Internal.AC1Legacy.Vector3 c;
    public float min_a;
    public float max_a;
    public float min_b;
    public float max_b;
    public float min_c;
    public float max_c;
    public float scale_rand;
    public float start_scale;
    public float final_scale;
    public float trans_rand;
    public float start_trans;
    public float final_trans;

    // Generated Constructor
    public ParticleEmitterInfo() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x004F7E90
    /// DBObj* __cdecl ParticleEmitterInfo::Allocator()</code>
    /// </summary>
    public static ACBindings.Internal.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.DBObj*>)0x004F7E90)();

    /// <summary>
    /// <code>Offset: 0x00517C00
    /// float __thiscall ParticleEmitterInfo::GetRandomStartScale(ParticleEmitterInfo*)</code>
    /// </summary>
    public float GetRandomStartScale() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ParticleEmitterInfo, float>)0x00517C00)(ref this);

    /// <summary>
    /// <code>Offset: 0x00517C50
    /// float __thiscall ParticleEmitterInfo::GetRandomFinalScale(ParticleEmitterInfo*)</code>
    /// </summary>
    public float GetRandomFinalScale() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ParticleEmitterInfo, float>)0x00517C50)(ref this);

    /// <summary>
    /// <code>Offset: 0x00517CA0
    /// float __thiscall ParticleEmitterInfo::GetRandomStartTrans(ParticleEmitterInfo*)</code>
    /// </summary>
    public float GetRandomStartTrans() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ParticleEmitterInfo, float>)0x00517CA0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00517CF0
    /// float __thiscall ParticleEmitterInfo::GetRandomFinalTrans(ParticleEmitterInfo*)</code>
    /// </summary>
    public float GetRandomFinalTrans() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ParticleEmitterInfo, float>)0x00517CF0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00517D40
    /// float __thiscall ParticleEmitterInfo::GetRandomLifespan(ParticleEmitterInfo*)</code>
    /// </summary>
    public float GetRandomLifespan() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ParticleEmitterInfo, float>)0x00517D40)(ref this);

    /// <summary>
    /// <code>Offset: 0x00517D80
    /// void __thiscall ParticleEmitterInfo::ParticleEmitterInfo(ParticleEmitterInfo*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ParticleEmitterInfo, void>)0x00517D80)(ref this);

    /// <summary>
    /// <code>Offset: 0x00517EC0
    /// unsigned int __thiscall ParticleEmitterInfo::GetDBOType(ParticleEmitterInfo*)</code>
    /// </summary>
    public uint GetDBOType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ParticleEmitterInfo, uint>)0x00517EC0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00517EE0
    /// void __thiscall ParticleEmitterInfo::InitEnd(ParticleEmitterInfo*)</code>
    /// </summary>
    public void InitEnd() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ParticleEmitterInfo, void>)0x00517EE0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00517F50
    /// int __thiscall ParticleEmitterInfo::ShouldEmitParticle(ParticleEmitterInfo*,int,int,const AC1Legacy::Vector3*,long double)</code>
    /// </summary>
    public int ShouldEmitParticle(int num_particles, int total_emitted, ACBindings.Internal.AC1Legacy.Vector3* emitter_offset, double last_emit_time) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ParticleEmitterInfo, int, int, ACBindings.Internal.AC1Legacy.Vector3*, double, int>)0x00517F50)(ref this, num_particles, total_emitted, emitter_offset, last_emit_time);

    /// <summary>
    /// <code>Offset: 0x00517FD0
    /// AC1Legacy::Vector3* __thiscall ParticleEmitterInfo::GetRandomOffset(ParticleEmitterInfo*,AC1Legacy::Vector3*)</code>
    /// </summary>
    public ACBindings.Internal.AC1Legacy.Vector3* GetRandomOffset(ACBindings.Internal.AC1Legacy.Vector3* result) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ParticleEmitterInfo, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.AC1Legacy.Vector3*>)0x00517FD0)(ref this, result);

    /// <summary>
    /// <code>Offset: 0x00518140
    /// AC1Legacy::Vector3* __thiscall ParticleEmitterInfo::GetRandomA(ParticleEmitterInfo*,AC1Legacy::Vector3*)</code>
    /// </summary>
    public ACBindings.Internal.AC1Legacy.Vector3* GetRandomA(ACBindings.Internal.AC1Legacy.Vector3* result) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ParticleEmitterInfo, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.AC1Legacy.Vector3*>)0x00518140)(ref this, result);

    /// <summary>
    /// <code>Offset: 0x005181A0
    /// AC1Legacy::Vector3* __thiscall ParticleEmitterInfo::GetRandomB(ParticleEmitterInfo*,AC1Legacy::Vector3*)</code>
    /// </summary>
    public ACBindings.Internal.AC1Legacy.Vector3* GetRandomB(ACBindings.Internal.AC1Legacy.Vector3* result) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ParticleEmitterInfo, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.AC1Legacy.Vector3*>)0x005181A0)(ref this, result);

    /// <summary>
    /// <code>Offset: 0x00518200
    /// AC1Legacy::Vector3* __thiscall ParticleEmitterInfo::GetRandomC(ParticleEmitterInfo*,AC1Legacy::Vector3*)</code>
    /// </summary>
    public ACBindings.Internal.AC1Legacy.Vector3* GetRandomC(ACBindings.Internal.AC1Legacy.Vector3* result) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ParticleEmitterInfo, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.AC1Legacy.Vector3*>)0x00518200)(ref this, result);

    /// <summary>
    /// <code>Offset: 0x005182B0
    /// unsigned int __thiscall ParticleEmitterInfo::Pack(ParticleEmitterInfo*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ParticleEmitterInfo, void**, uint, uint>)0x005182B0)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x00518520
    /// int __thiscall ParticleEmitterInfo::UnPack(ParticleEmitterInfo*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ParticleEmitterInfo, void**, uint, int>)0x00518520)(ref this, addr, size);
}

