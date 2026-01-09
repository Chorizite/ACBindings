namespace ACBindings;

// ParticleEmitterInfo
public unsafe struct ParticleEmitterInfo
{
    // Base Classes
    public ACBindings.SerializeUsingPackDBObj BaseClass_SerializeUsingPackDBObj; // ACBindings.SerializeUsingPackDBObj

    // Child Types
    // ParticleEmitterInfo_vtbl
    public unsafe struct ParticleEmitterInfo_vtbl
    {
        // Members
        public System.IntPtr IUnknown_QueryInterface; // function pointer
        public System.IntPtr IUnknown_AddRef; // function pointer
        public System.IntPtr IUnknown_Release; // function pointer
        public System.IntPtr QueryInterface; // function pointer
        public System.IntPtr AddRef; // function pointer
        public System.IntPtr Release; // function pointer
        public System.IntPtr DBObj_dtor_18; // function pointer
        public System.IntPtr Serialize; // function pointer
        public System.IntPtr GetSubDataIDs; // function pointer
        public System.IntPtr InitLoad; // function pointer
        public System.IntPtr GetSubObjects; // function pointer
        public System.IntPtr ReleaseSubObjects; // function pointer
        public System.IntPtr NotifyFidelityLevel; // function pointer
        public System.IntPtr Refresh;
        public System.IntPtr CopyInto; // function pointer
        public System.IntPtr Destroy; // function pointer
        public System.IntPtr FillDataGraph; // function pointer
        public System.IntPtr SetDID;
        public System.IntPtr GetDBOType; // function pointer
        public System.IntPtr Allocate; // function pointer
        public System.IntPtr SaveToDisk;
        public System.IntPtr ReloadFromDisk; // function pointer

        // Methods
    }

    // Members
    public int emitter_type;
    public int particle_type;
    public int is_parent_local;
    public ACBindings.IDClass___tagDataID gfxobj_id;
    public ACBindings.IDClass___tagDataID hw_gfxobj_id;
    public double birthrate;
    public int max_particles;
    public int initial_particles;
    public int total_particles;
    public double total_seconds;
    public double lifespan_rand;
    public double lifespan;
    public ACBindings.CSphere sorting_sphere;
    public ACBindings.AC1Legacy.Vector3 offset_dir;
    public float min_offset;
    public float max_offset;
    public ACBindings.AC1Legacy.Vector3 a;
    public ACBindings.AC1Legacy.Vector3 b;
    public ACBindings.AC1Legacy.Vector3 c;
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
    // DBObj* __cdecl ParticleEmitterInfo::Allocator()
    public static ACBindings.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.DBObj*>)0x004F7E90)();
    // float __thiscall ParticleEmitterInfo::GetRandomStartScale(ParticleEmitterInfo*)
    public float GetRandomStartScale() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ParticleEmitterInfo, float>)0x00517C00)(ref this);
    // float __thiscall ParticleEmitterInfo::GetRandomFinalScale(ParticleEmitterInfo*)
    public float GetRandomFinalScale() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ParticleEmitterInfo, float>)0x00517C50)(ref this);
    // float __thiscall ParticleEmitterInfo::GetRandomStartTrans(ParticleEmitterInfo*)
    public float GetRandomStartTrans() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ParticleEmitterInfo, float>)0x00517CA0)(ref this);
    // float __thiscall ParticleEmitterInfo::GetRandomFinalTrans(ParticleEmitterInfo*)
    public float GetRandomFinalTrans() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ParticleEmitterInfo, float>)0x00517CF0)(ref this);
    // float __thiscall ParticleEmitterInfo::GetRandomLifespan(ParticleEmitterInfo*)
    public float GetRandomLifespan() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ParticleEmitterInfo, float>)0x00517D40)(ref this);
    // void __thiscall ParticleEmitterInfo::ParticleEmitterInfo(ParticleEmitterInfo*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ParticleEmitterInfo, void>)0x00517D80)(ref this);
    // unsigned int __thiscall ParticleEmitterInfo::GetDBOType(ParticleEmitterInfo*)
    public uint GetDBOType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ParticleEmitterInfo, uint>)0x00517EC0)(ref this);
    // void __thiscall ParticleEmitterInfo::InitEnd(ParticleEmitterInfo*)
    public void InitEnd() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ParticleEmitterInfo, void>)0x00517EE0)(ref this);
    // int __thiscall ParticleEmitterInfo::ShouldEmitParticle(ParticleEmitterInfo*,int,int,const AC1Legacy::Vector3*,long double)
    public int ShouldEmitParticle(int num_particles, int total_emitted, ACBindings.AC1Legacy.Vector3* emitter_offset, double last_emit_time) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ParticleEmitterInfo, int, int, ACBindings.AC1Legacy.Vector3*, double, int>)0x00517F50)(ref this, num_particles, total_emitted, emitter_offset, last_emit_time);
    // AC1Legacy::Vector3* __thiscall ParticleEmitterInfo::GetRandomOffset(ParticleEmitterInfo*,AC1Legacy::Vector3*)
    public ACBindings.AC1Legacy.Vector3* GetRandomOffset(ACBindings.AC1Legacy.Vector3* result) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ParticleEmitterInfo, ACBindings.AC1Legacy.Vector3*, ACBindings.AC1Legacy.Vector3*>)0x00517FD0)(ref this, result);
    // AC1Legacy::Vector3* __thiscall ParticleEmitterInfo::GetRandomA(ParticleEmitterInfo*,AC1Legacy::Vector3*)
    public ACBindings.AC1Legacy.Vector3* GetRandomA(ACBindings.AC1Legacy.Vector3* result) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ParticleEmitterInfo, ACBindings.AC1Legacy.Vector3*, ACBindings.AC1Legacy.Vector3*>)0x00518140)(ref this, result);
    // AC1Legacy::Vector3* __thiscall ParticleEmitterInfo::GetRandomB(ParticleEmitterInfo*,AC1Legacy::Vector3*)
    public ACBindings.AC1Legacy.Vector3* GetRandomB(ACBindings.AC1Legacy.Vector3* result) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ParticleEmitterInfo, ACBindings.AC1Legacy.Vector3*, ACBindings.AC1Legacy.Vector3*>)0x005181A0)(ref this, result);
    // AC1Legacy::Vector3* __thiscall ParticleEmitterInfo::GetRandomC(ParticleEmitterInfo*,AC1Legacy::Vector3*)
    public ACBindings.AC1Legacy.Vector3* GetRandomC(ACBindings.AC1Legacy.Vector3* result) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ParticleEmitterInfo, ACBindings.AC1Legacy.Vector3*, ACBindings.AC1Legacy.Vector3*>)0x00518200)(ref this, result);
    // unsigned int __thiscall ParticleEmitterInfo::Pack(ParticleEmitterInfo*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ParticleEmitterInfo, void**, uint, uint>)0x005182B0)(ref this, addr, size);
    // int __thiscall ParticleEmitterInfo::UnPack(ParticleEmitterInfo*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ParticleEmitterInfo, void**, uint, int>)0x00518520)(ref this, addr, size);
}

