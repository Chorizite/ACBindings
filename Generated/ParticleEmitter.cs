namespace ACBindings.Internal;


/// <summary>Controls particle emission for a physics object, handling creation, updates, and destruction while managing particle lifetimes and visibility.</summary>
/// <remarks>Tracks active particles, records emission statistics, and interacts with the physics system to add or remove parts from shadow cells.</remarks>
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

    /// <summary>Assigns the particle emitter’s physics object to a specified part of its parent, copying the relative offset frame into the emitter.
    /// <code>Offset: 0x0051CCC0
    /// int __thiscall ParticleEmitter::SetParenting(ParticleEmitter*,unsigned int,const Frame*)</code>
    /// </summary>
    /// <param name="part_index">Index of the parent part to which the emitter should be attached.</param>
    /// <param name="frame">Frame providing the positional and orientational offset; must point to a valid Frame instance.</param>
    /// <returns>1 if parenting succeeds; 0 otherwise, such as when no physics object exists or the underlying set_parent call fails.</returns>
    public int SetParenting(uint part_index, ACBindings.Internal.Frame* frame) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ParticleEmitter, uint, ACBindings.Internal.Frame*, int>)0x0051CCC0)(ref this, part_index, frame);

    /// <summary>Kills a particle by removing it from the physics system and updating counters, but only when its lifetime has reached or exceeded its lifespan.
    /// <code>Offset: 0x0051CD10
    /// int __thiscall ParticleEmitter::KillParticle(ParticleEmitter*,unsigned int)</code>
    /// </summary>
    /// <param name="i">Index of the particle to be killed.</param>
    /// <returns>Non‑zero if the particle was successfully removed; zero if it is still alive.</returns>
    public int KillParticle(uint i) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ParticleEmitter, uint, int>)0x0051CD10)(ref this, i);

    /// <summary>Marks the particle emitter as stopped once its lifetime expires or it has emitted all configured particles, returning whether it is stopped.
    /// <code>Offset: 0x0051CD60
    /// int __thiscall ParticleEmitter::StopEmitter(ParticleEmitter*)</code>
    /// </summary>
    /// <returns>An integer value of 1 if the emitter has been stopped; otherwise 0.</returns>
    public int StopEmitter() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ParticleEmitter, int>)0x0051CD60)(ref this);

    /// <summary>Initializes a particle emitter with the specified parent physics object, setting identity transform and default values for all internal fields.
    /// <code>Offset: 0x0051D310
    /// void __thiscall ParticleEmitter::ParticleEmitter(ParticleEmitter*,CPhysicsObj*)</code>
    /// </summary>
    /// <param name="parent">The physics object that owns or attaches to this emitter.</param>
    public void _ConstructorInternal(ACBindings.Internal.CPhysicsObj* parent) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ParticleEmitter, ACBindings.Internal.CPhysicsObj*, void>)0x0051D310)(ref this, parent);

    /// <summary>Records a new particle emission by incrementing counters, capturing the emitter’s current position, and storing the timestamp of the event.
    /// <code>Offset: 0x0051D3A0
    /// void __thiscall ParticleEmitter::RecordParticleEmission(ParticleEmitter*)</code>
    /// </summary>
    public void RecordParticleEmission() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ParticleEmitter, void>)0x0051D3A0)(ref this);

    /// <summary>Decides whether the emitter should generate a new particle based on its configuration and current state.
    /// <code>Offset: 0x0051D3E0
    /// int __thiscall ParticleEmitter::ShouldEmitParticle(ParticleEmitter*)</code>
    /// </summary>
    /// <returns>An integer value indicating if a particle can be emitted (non‑zero) or not (zero).</returns>
    public int ShouldEmitParticle() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ParticleEmitter, int>)0x0051D3E0)(ref this);

    /// <summary>Creates and initializes a ParticleEmitter associated with the specified CPhysicsObj.
    /// <code>Offset: 0x0051D8B0
    /// ParticleEmitter* __cdecl ParticleEmitter::makeParticleEmitter(CPhysicsObj*)</code>
    /// </summary>
    /// <param name="parent">The physics object that will own the new emitter.</param>
    /// <returns>The newly created ParticleEmitter, or nullptr if creation fails.</returns>
    public static ACBindings.Internal.ParticleEmitter* makeParticleEmitter(ACBindings.Internal.CPhysicsObj* parent) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CPhysicsObj*, ACBindings.Internal.ParticleEmitter*>)0x0051D8B0)(parent);

    /// <summary>Destroys the particle emitter, freeing all associated particles and physics parts. Detaches any parent physics object and releases the emitter’s info structure. Resets internal counters to zero.
    /// <code>Offset: 0x0051D8E0
    /// void __thiscall ParticleEmitter::Destroy(ParticleEmitter*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ParticleEmitter, void>)0x0051D8E0)(ref this);

    /// <summary>Initializes the particle emitter with the specified configuration, allocating necessary resources and setting up physics objects.
    /// <code>Offset: 0x0051D9C0
    /// int __thiscall ParticleEmitter::SetInfo(ParticleEmitter*,const ParticleEmitterInfo*)</code>
    /// </summary>
    /// <param name="info">The ParticleEmitterInfo defining emitter properties such as type, particle count, geometry, and behavior.</param>
    /// <returns>1 if initialization succeeds; 0 on failure, in which case any allocated data is cleaned up.</returns>
    public int SetInfo(ACBindings.Internal.ParticleEmitterInfo* info) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ParticleEmitter, ACBindings.Internal.ParticleEmitterInfo*, int>)0x0051D9C0)(ref this, info);

    /// <summary>Creates a new particle for the emitter if capacity permits and initializes it with random attributes defined by its ParticleEmitterInfo.
    /// <code>Offset: 0x0051DB40
    /// void __thiscall ParticleEmitter::EmitParticle(ParticleEmitter*)</code>
    /// </summary>
    public void EmitParticle() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ParticleEmitter, void>)0x0051DB40)(ref this);

    /// <summary>Updates the particle emitter's state for the current physics tick, handling visibility culling, particle lifetimes, emission, and cleanup.
    /// <code>Offset: 0x0051DCB0
    /// int __thiscall ParticleEmitter::UpdateParticles(ParticleEmitter*)</code>
    /// </summary>
    /// <returns>Non‑zero if the emitter remains active after the update; zero if it has no valid physics object or particle data.</returns>
    public int UpdateParticles() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ParticleEmitter, int>)0x0051DCB0)(ref this);

    /// <summary>Sets emitter information based on provided data ID; retrieves corresponding info from database and updates emitter configuration.
    /// <code>Offset: 0x0051DEF0
    /// int __thiscall ParticleEmitter::SetInfo(ParticleEmitter*,int)</code>
    /// </summary>
    /// <param name="a2">Identifier of the emitter info to load from the database.</param>
    /// <returns>Non‑zero if the info was successfully retrieved and applied, otherwise zero.</returns>
    public int SetInfo(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ParticleEmitter, int, int>)0x0051DEF0)(ref this, a2);

    /// <summary>Records the emitter's creation timestamp and emits its initial particle set as specified in the emitter information.
    /// <code>Offset: 0x0051DF30
    /// int __thiscall ParticleEmitter::InitEnd(ParticleEmitter*)</code>
    /// </summary>
    /// <param name="this">Pointer to the ParticleEmitter instance being initialized.</param>
    /// <returns>An integer status code; always returns 1 on successful completion.</returns>
    public int InitEnd() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ParticleEmitter, int>)0x0051DF30)(ref this);
}

