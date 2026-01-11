namespace ACBindings.Internal;

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

    /// <summary>
    /// <code>Offset: 0x0051CDC0
    /// void __thiscall Particle::Update(Particle*,ParticleType,int,CPhysicsPart*,const Frame*)</code>
    /// </summary>
    public void Update(ACBindings.Internal.ParticleType particle_type, int is_persistent, ACBindings.Internal.CPhysicsPart* part, ACBindings.Internal.Frame* parent_frame) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Particle, ACBindings.Internal.ParticleType, int, ACBindings.Internal.CPhysicsPart*, ACBindings.Internal.Frame*, void>)0x0051CDC0)(ref this, particle_type, is_persistent, part, parent_frame);

    /// <summary>
    /// <code>Offset: 0x0051D460
    /// void __thiscall Particle::Init(Particle*,const CPhysicsObj*,const unsigned int,const Frame*,CPhysicsPart*,const AC1Legacy::Vector3*,const ParticleType,const int,const AC1Legacy::Vector3*,const AC1Legacy::Vector3*,const AC1Legacy::Vector3*,const float,const float,const float,const float,const long double)</code>
    /// </summary>
    public void Init(ACBindings.Internal.CPhysicsObj* parent, uint part_index, ACBindings.Internal.Frame* parent_offset, ACBindings.Internal.CPhysicsPart* part, ACBindings.Internal.AC1Legacy.Vector3* offset, ACBindings.Internal.ParticleType particle_type, int is_persistent, ACBindings.Internal.AC1Legacy.Vector3* a, ACBindings.Internal.AC1Legacy.Vector3* b, ACBindings.Internal.AC1Legacy.Vector3* c, float start_scale, float final_scale, float start_trans, float final_trans, double lifespan) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Particle, ACBindings.Internal.CPhysicsObj*, uint, ACBindings.Internal.Frame*, ACBindings.Internal.CPhysicsPart*, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.ParticleType, int, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.AC1Legacy.Vector3*, float, float, float, float, double, void>)0x0051D460)(ref this, parent, part_index, parent_offset, part, offset, particle_type, is_persistent, a, b, c, start_scale, final_scale, start_trans, final_trans, lifespan);
}

