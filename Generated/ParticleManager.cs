namespace ACBindings;

// ParticleManager
public unsafe struct ParticleManager : System.IDisposable
{
    // Members
    public uint next_emitter_id;
    public ACBindings.LongNIHash__ParticleEmitter particle_table;

    // Generated Constructor
    public ParticleManager() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // unsigned int __thiscall ParticleManager::GetNumEmitters(ParticleManager*)
    public uint GetNumEmitters() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ParticleManager, uint>)0x0051C0B0)(ref this);
    // void __thiscall ParticleManager::ParticleManager(ParticleManager*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ParticleManager, void>)0x0051C100)(ref this);
    // void __thiscall ParticleManager::~ParticleManager(ParticleManager*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ParticleManager, void>)0x0051C150)(ref this);
    // unsigned int __thiscall ParticleManager::CreateParticleEmitter(_DWORD*,CPhysicsObj*,int,unsigned int,Frame*,unsigned int)
    public uint CreateParticleEmitter(ACBindings.CPhysicsObj* parent, int a3, uint part_index, ACBindings.Frame* frame, uint a6) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ParticleManager, ACBindings.CPhysicsObj*, int, uint, ACBindings.Frame*, uint, uint>)0x0051C1F0)(ref this, parent, a3, part_index, frame, a6);
    // void __thiscall ParticleManager::UpdateParticles(ParticleManager*)
    public void UpdateParticles() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ParticleManager, void>)0x0051C330)(ref this);
    // unsigned int __thiscall ParticleManager::CreateBlockingParticleEmitter(_DWORD*,CPhysicsObj*,int,unsigned int,Frame*,unsigned int)
    public uint CreateBlockingParticleEmitter(ACBindings.CPhysicsObj* a2, int a3, uint a4, ACBindings.Frame* a5, uint a6) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ParticleManager, ACBindings.CPhysicsObj*, int, uint, ACBindings.Frame*, uint, uint>)0x0051C3D0)(ref this, a2, a3, a4, a5, a6);
}

