namespace ACBindings.Internal;

public unsafe struct ParticleManager : System.IDisposable
{
    // Members
    public uint next_emitter_id;
    public ACBindings.Internal.LongNIHash___ParticleEmitter particle_table;

    // Generated Constructor
    public ParticleManager() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x0051C0B0
    /// unsigned int __thiscall ParticleManager::GetNumEmitters(ParticleManager*)</code>
    /// </summary>
    public uint GetNumEmitters() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ParticleManager, uint>)0x0051C0B0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0051C100
    /// void __thiscall ParticleManager::ParticleManager(ParticleManager*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ParticleManager, void>)0x0051C100)(ref this);

    /// <summary>
    /// <code>Offset: 0x0051C150
    /// void __thiscall ParticleManager::~ParticleManager(ParticleManager*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ParticleManager, void>)0x0051C150)(ref this);

    /// <summary>
    /// <code>Offset: 0x0051C1F0
    /// unsigned int __thiscall ParticleManager::CreateParticleEmitter(_DWORD*,CPhysicsObj*,int,unsigned int,Frame*,unsigned int)</code>
    /// </summary>
    public uint CreateParticleEmitter(ACBindings.Internal.CPhysicsObj* parent, int a3, uint part_index, ACBindings.Internal.Frame* frame, uint a6) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ParticleManager, ACBindings.Internal.CPhysicsObj*, int, uint, ACBindings.Internal.Frame*, uint, uint>)0x0051C1F0)(ref this, parent, a3, part_index, frame, a6);

    /// <summary>
    /// <code>Offset: 0x0051C330
    /// void __thiscall ParticleManager::UpdateParticles(ParticleManager*)</code>
    /// </summary>
    public void UpdateParticles() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ParticleManager, void>)0x0051C330)(ref this);

    /// <summary>
    /// <code>Offset: 0x0051C3D0
    /// unsigned int __thiscall ParticleManager::CreateBlockingParticleEmitter(_DWORD*,CPhysicsObj*,int,unsigned int,Frame*,unsigned int)</code>
    /// </summary>
    public uint CreateBlockingParticleEmitter(ACBindings.Internal.CPhysicsObj* a2, int a3, uint a4, ACBindings.Internal.Frame* a5, uint a6) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ParticleManager, ACBindings.Internal.CPhysicsObj*, int, uint, ACBindings.Internal.Frame*, uint, uint>)0x0051C3D0)(ref this, a2, a3, a4, a5, a6);
}

