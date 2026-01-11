namespace ACBindings.Internal;

public unsafe struct ParticleEmitter
{
    // Members
    public uint id;
    public ACBindings.Internal.CPhysicsObj* parent;
    public uint part_index;
    public ACBindings.Internal.Frame parent_offset;
    public ACBindings.Internal.CPhysicsObj* physobj;
    public ACBindings.Internal.ParticleEmitterInfo* info;
    public ACBindings.Internal.Particle* particles;
    public ACBindings.Internal.CPhysicsPart** part_storage;
    public ACBindings.Internal.CPhysicsPart** parts;
    public int degraded_out;
    public float degrade_distance;
    public double creation_time;
    public int num_particles;
    public int total_emitted;
    public double last_emit_time;
    public ACBindings.Internal.AC1Legacy.Vector3 last_emit_offset;
    public int stopped;
    public double last_update_time;

    // Generated Constructor
    public ParticleEmitter(ACBindings.Internal.CPhysicsObj* parent) {
        _ConstructorInternal(parent);
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x0051CCC0
    /// int __thiscall ParticleEmitter::SetParenting(ParticleEmitter*,unsigned int,const Frame*)</code>
    /// </summary>
    public int SetParenting(uint part_index, ACBindings.Internal.Frame* frame) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ParticleEmitter, uint, ACBindings.Internal.Frame*, int>)0x0051CCC0)(ref this, part_index, frame);

    /// <summary>
    /// <code>Offset: 0x0051CD10
    /// int __thiscall ParticleEmitter::KillParticle(ParticleEmitter*,unsigned int)</code>
    /// </summary>
    public int KillParticle(uint i) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ParticleEmitter, uint, int>)0x0051CD10)(ref this, i);

    /// <summary>
    /// <code>Offset: 0x0051CD60
    /// int __thiscall ParticleEmitter::StopEmitter(ParticleEmitter*)</code>
    /// </summary>
    public int StopEmitter() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ParticleEmitter, int>)0x0051CD60)(ref this);

    /// <summary>
    /// <code>Offset: 0x0051D310
    /// void __thiscall ParticleEmitter::ParticleEmitter(ParticleEmitter*,CPhysicsObj*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.CPhysicsObj* parent) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ParticleEmitter, ACBindings.Internal.CPhysicsObj*, void>)0x0051D310)(ref this, parent);

    /// <summary>
    /// <code>Offset: 0x0051D3A0
    /// void __thiscall ParticleEmitter::RecordParticleEmission(ParticleEmitter*)</code>
    /// </summary>
    public void RecordParticleEmission() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ParticleEmitter, void>)0x0051D3A0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0051D3E0
    /// int __thiscall ParticleEmitter::ShouldEmitParticle(ParticleEmitter*)</code>
    /// </summary>
    public int ShouldEmitParticle() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ParticleEmitter, int>)0x0051D3E0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0051D8B0
    /// ParticleEmitter* __cdecl ParticleEmitter::makeParticleEmitter(CPhysicsObj*)</code>
    /// </summary>
    public static ACBindings.Internal.ParticleEmitter* makeParticleEmitter(ACBindings.Internal.CPhysicsObj* parent) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CPhysicsObj*, ACBindings.Internal.ParticleEmitter*>)0x0051D8B0)(parent);

    /// <summary>
    /// <code>Offset: 0x0051D8E0
    /// void __thiscall ParticleEmitter::Destroy(ParticleEmitter*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ParticleEmitter, void>)0x0051D8E0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0051D9C0
    /// int __thiscall ParticleEmitter::SetInfo(ParticleEmitter*,const ParticleEmitterInfo*)</code>
    /// </summary>
    public int SetInfo(ACBindings.Internal.ParticleEmitterInfo* info) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ParticleEmitter, ACBindings.Internal.ParticleEmitterInfo*, int>)0x0051D9C0)(ref this, info);

    /// <summary>
    /// <code>Offset: 0x0051DB40
    /// void __thiscall ParticleEmitter::EmitParticle(ParticleEmitter*)</code>
    /// </summary>
    public void EmitParticle() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ParticleEmitter, void>)0x0051DB40)(ref this);

    /// <summary>
    /// <code>Offset: 0x0051DCB0
    /// int __thiscall ParticleEmitter::UpdateParticles(ParticleEmitter*)</code>
    /// </summary>
    public int UpdateParticles() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ParticleEmitter, int>)0x0051DCB0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0051DEF0
    /// int __thiscall ParticleEmitter::SetInfo(ParticleEmitter*,int)</code>
    /// </summary>
    public int SetInfo(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ParticleEmitter, int, int>)0x0051DEF0)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x0051DF30
    /// int __thiscall ParticleEmitter::InitEnd(ParticleEmitter*)</code>
    /// </summary>
    public int InitEnd() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ParticleEmitter, int>)0x0051DF30)(ref this);
}

