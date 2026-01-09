namespace ACBindings;

// ParticleEmitter
public unsafe struct ParticleEmitter
{
    // Members
    public uint id;
    public ACBindings.CPhysicsObj* parent;
    public uint part_index;
    public ACBindings.Frame parent_offset;
    public ACBindings.CPhysicsObj* physobj;
    public ACBindings.ParticleEmitterInfo* info;
    public ACBindings.Particle* particles;
    public ACBindings.CPhysicsPart** part_storage;
    public ACBindings.CPhysicsPart** parts;
    public int degraded_out;
    public float degrade_distance;
    public double creation_time;
    public int num_particles;
    public int total_emitted;
    public double last_emit_time;
    public ACBindings.AC1Legacy.Vector3 last_emit_offset;
    public int stopped;
    public double last_update_time;

    // Generated Constructor
    public ParticleEmitter(ACBindings.CPhysicsObj* parent) {
        _ConstructorInternal(parent);
    }

    // Methods
    // int __thiscall ParticleEmitter::SetParenting(ParticleEmitter*,unsigned int,const Frame*)
    public int SetParenting(uint part_index, ACBindings.Frame* frame) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ParticleEmitter, uint, ACBindings.Frame*, int>)0x0051CCC0)(ref this, part_index, frame);
    // int __thiscall ParticleEmitter::KillParticle(ParticleEmitter*,unsigned int)
    public int KillParticle(uint i) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ParticleEmitter, uint, int>)0x0051CD10)(ref this, i);
    // int __thiscall ParticleEmitter::StopEmitter(ParticleEmitter*)
    public int StopEmitter() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ParticleEmitter, int>)0x0051CD60)(ref this);
    // void __thiscall ParticleEmitter::ParticleEmitter(ParticleEmitter*,CPhysicsObj*)
    public void _ConstructorInternal(ACBindings.CPhysicsObj* parent) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ParticleEmitter, ACBindings.CPhysicsObj*, void>)0x0051D310)(ref this, parent);
    // void __thiscall ParticleEmitter::RecordParticleEmission(ParticleEmitter*)
    public void RecordParticleEmission() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ParticleEmitter, void>)0x0051D3A0)(ref this);
    // int __thiscall ParticleEmitter::ShouldEmitParticle(ParticleEmitter*)
    public int ShouldEmitParticle() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ParticleEmitter, int>)0x0051D3E0)(ref this);
    // ParticleEmitter* __cdecl ParticleEmitter::makeParticleEmitter(CPhysicsObj*)
    public static ACBindings.ParticleEmitter* makeParticleEmitter(ACBindings.CPhysicsObj* parent) => ((delegate* unmanaged[Cdecl]<ACBindings.CPhysicsObj*, ACBindings.ParticleEmitter*>)0x0051D8B0)(parent);
    // void __thiscall ParticleEmitter::Destroy(ParticleEmitter*)
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ParticleEmitter, void>)0x0051D8E0)(ref this);
    // int __thiscall ParticleEmitter::SetInfo(ParticleEmitter*,const ParticleEmitterInfo*)
    public int SetInfo(ACBindings.ParticleEmitterInfo* info) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ParticleEmitter, ACBindings.ParticleEmitterInfo*, int>)0x0051D9C0)(ref this, info);
    // void __thiscall ParticleEmitter::EmitParticle(ParticleEmitter*)
    public void EmitParticle() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ParticleEmitter, void>)0x0051DB40)(ref this);
    // int __thiscall ParticleEmitter::UpdateParticles(ParticleEmitter*)
    public int UpdateParticles() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ParticleEmitter, int>)0x0051DCB0)(ref this);
    // int __thiscall ParticleEmitter::SetInfo(ParticleEmitter*,int)
    public int SetInfo(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ParticleEmitter, int, int>)0x0051DEF0)(ref this, a2);
    // int __thiscall ParticleEmitter::InitEnd(ParticleEmitter*)
    public int InitEnd() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ParticleEmitter, int>)0x0051DF30)(ref this);
}

