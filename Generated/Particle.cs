namespace ACBindings.Internal;


/// <summary>
/// Represents an individual particle used in the game's visual effects system, storing its lifecycle timing, motion vectors, and rendering state such as scale and translucency.
/// </summary>
/// <remarks>
/// Particle instances are updated each physics tick according to a ParticleType, adjusting position, size, and transparency over their lifetime.
/// </remarks>
public unsafe struct Particle
{
    // Members
    public ACBindings.Internal._6E56156ABBED5B0767B81AF559A00DDB ___u0;
    public double lifespan;
    public double lifetime;
    public ACBindings.Internal.Frame start_frame;
    public ACBindings.Internal.AC1Legacy.Vector3 offset;
    public ACBindings.Internal.AC1Legacy.Vector3 a;
    public ACBindings.Internal.AC1Legacy.Vector3 b;
    public ACBindings.Internal.AC1Legacy.Vector3 c;
    public float start_scale;
    public float final_scale;
    public float start_trans;
    public float final_trans;

    // Methods

    /// <summary>Updates a particle’s state each simulation step, advancing its lifetime and computing a new position based on the specified motion model; it also scales and fades the particle proportionally to its remaining lifespan.
    /// <code>Offset: 0x0051CDC0
    /// void __thiscall Particle::Update(Particle*,ParticleType,int,CPhysicsPart*,const Frame*)</code>
    /// </summary>
    /// <param name="this">The particle instance being updated.</param>
    /// <param name="particle_type">Describes the movement behavior (e.g., still, velocity‑based, parabolic, swarm, explode, implode).</param>
    /// <param name="is_persistent">If non‑zero, the particle’s birth time is refreshed after each update so its lifetime accumulates; otherwise it only tracks elapsed time.</param>
    /// <param name="part">The physics part that represents the particle in the simulation world. Its position, scale and translucency are modified.</param>
    /// <param name="parent_frame">Reference frame used to transform the particle’s local offset into world coordinates for positioning calculations.</param>
    public void Update(ACBindings.Internal.ParticleType particle_type, int is_persistent, ACBindings.Internal.CPhysicsPart* part, ACBindings.Internal.Frame* parent_frame) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Particle, ACBindings.Internal.ParticleType, int, ACBindings.Internal.CPhysicsPart*, ACBindings.Internal.Frame*, void>)0x0051CDC0)(ref this, particle_type, is_persistent, part, parent_frame);

    /// <summary>Initializes a particle with the specified physics object and rendering parameters, configuring its position, motion vectors, scale, translucency, and lifetime based on the chosen type.
    /// <code>Offset: 0x0051D460
    /// void __thiscall Particle::Init(Particle*,const CPhysicsObj*,const unsigned int,const Frame*,CPhysicsPart*,const AC1Legacy::Vector3*,const ParticleType,const int,const AC1Legacy::Vector3*,const AC1Legacy::Vector3*,const AC1Legacy::Vector3*,const float,const float,const float,const float,const long double)</code>
    /// </summary>
    /// <param name="parent">The parent physics object that owns the particle.</param>
    /// <param name="part_index">Index of the part within the parent to attach the particle; use -1 for the whole object.</param>
    /// <param name="parent_offset">Frame offset applied to the parent's position when positioning the particle.</param>
    /// <param name="part">Physics part used for rendering and scaling of the particle.</param>
    /// <param name="offset">Local offset vector from the parent frame where the particle originates.</param>
    /// <param name="particle_type">Enum value determining the motion behavior of the particle (e.g., Still, Swarm, Explode).</param>
    /// <param name="is_persistent">Flag indicating whether the particle should persist after its lifespan expires.</param>
    /// <param name="a">First vector parameter; meaning depends on particle type (often velocity or direction).</param>
    /// <param name="b">Second vector parameter; meaning depends on particle type (e.g., secondary velocity, gravity).</param>
    /// <param name="c">Third vector parameter; meaning depends on particle type (e.g., scale factor or radial component).</param>
    /// <param name="start_scale">Initial scale of the particle at birth.</param>
    /// <param name="final_scale">Scale the particle transitions to over its lifetime.</param>
    /// <param name="start_trans">Starting translucency value.</param>
    /// <param name="final_trans">Ending translucency value after the lifespan completes.</param>
    /// <param name="lifespan">Total duration the particle remains active before expiring, in seconds (or appropriate time unit).</param>
    public void Init(ACBindings.Internal.CPhysicsObj* parent, uint part_index, ACBindings.Internal.Frame* parent_offset, ACBindings.Internal.CPhysicsPart* part, ACBindings.Internal.AC1Legacy.Vector3* offset, ACBindings.Internal.ParticleType particle_type, int is_persistent, ACBindings.Internal.AC1Legacy.Vector3* a, ACBindings.Internal.AC1Legacy.Vector3* b, ACBindings.Internal.AC1Legacy.Vector3* c, float start_scale, float final_scale, float start_trans, float final_trans, double lifespan) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Particle, ACBindings.Internal.CPhysicsObj*, uint, ACBindings.Internal.Frame*, ACBindings.Internal.CPhysicsPart*, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.ParticleType, int, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.AC1Legacy.Vector3*, float, float, float, float, double, void>)0x0051D460)(ref this, parent, part_index, parent_offset, part, offset, particle_type, is_persistent, a, b, c, start_scale, final_scale, start_trans, final_trans, lifespan);
}

