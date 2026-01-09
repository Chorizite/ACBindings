namespace ACBindings;

// Particle
public unsafe struct Particle
{
    // Members
    public ACBindings._6E56156ABBED5B0767B81AF559A00DDB ___u0;
    public double lifespan;
    public double lifetime;
    public ACBindings.Frame start_frame;
    public ACBindings.AC1Legacy.Vector3 offset;
    public ACBindings.AC1Legacy.Vector3 a;
    public ACBindings.AC1Legacy.Vector3 b;
    public ACBindings.AC1Legacy.Vector3 c;
    public float start_scale;
    public float final_scale;
    public float start_trans;
    public float final_trans;

    // Methods
    // void __thiscall Particle::Update(Particle*,ParticleType,int,CPhysicsPart*,const Frame*)
    public void Update(ACBindings.ParticleType particle_type, int is_persistent, ACBindings.CPhysicsPart* part, ACBindings.Frame* parent_frame) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Particle, ACBindings.ParticleType, int, ACBindings.CPhysicsPart*, ACBindings.Frame*, void>)0x0051CDC0)(ref this, particle_type, is_persistent, part, parent_frame);
    // void __thiscall Particle::Init(Particle*,const CPhysicsObj*,const unsigned int,const Frame*,CPhysicsPart*,const AC1Legacy::Vector3*,const ParticleType,const int,const AC1Legacy::Vector3*,const AC1Legacy::Vector3*,const AC1Legacy::Vector3*,const float,const float,const float,const float,const long double)
    public void Init(ACBindings.CPhysicsObj* parent, uint part_index, ACBindings.Frame* parent_offset, ACBindings.CPhysicsPart* part, ACBindings.AC1Legacy.Vector3* offset, ACBindings.ParticleType particle_type, int is_persistent, ACBindings.AC1Legacy.Vector3* a, ACBindings.AC1Legacy.Vector3* b, ACBindings.AC1Legacy.Vector3* c, float start_scale, float final_scale, float start_trans, float final_trans, double lifespan) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Particle, ACBindings.CPhysicsObj*, uint, ACBindings.Frame*, ACBindings.CPhysicsPart*, ACBindings.AC1Legacy.Vector3*, ACBindings.ParticleType, int, ACBindings.AC1Legacy.Vector3*, ACBindings.AC1Legacy.Vector3*, ACBindings.AC1Legacy.Vector3*, float, float, float, float, double, void>)0x0051D460)(ref this, parent, part_index, parent_offset, part, offset, particle_type, is_persistent, a, b, c, start_scale, final_scale, start_trans, final_trans, lifespan);
}

