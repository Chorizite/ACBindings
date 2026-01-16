namespace ACBindings.Internal;


/// <summary>Handles particle emitter lifecycle, assigning unique identifiers and storing emitters in a hash-based collection for efficient retrieval and management.</summary>
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

    /// <summary>Returns the total number of particle emitters currently stored in the manager.
    /// <code>Offset: 0x0051C0B0
    /// unsigned int __thiscall ParticleManager::GetNumEmitters(ParticleManager*)</code>
    /// </summary>
    /// <returns>The count of emitters as an unsigned integer.</returns>
    public uint GetNumEmitters() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ParticleManager, uint>)0x0051C0B0)(ref this);

    /// <summary>Initializes a new ParticleManager instance by resetting the next emitter identifier and allocating an empty hash table with two buckets to store particle emitters.
    /// <code>Offset: 0x0051C100
    /// void __thiscall ParticleManager::ParticleManager(ParticleManager*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ParticleManager, void>)0x0051C100)(ref this);

    /// <summary>Destroys a ParticleManager instance by destroying all contained ParticleEmitter objects, freeing associated memory, and resetting internal data structures.
    /// <code>Offset: 0x0051C150
    /// void __thiscall ParticleManager::~ParticleManager(ParticleManager*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ParticleManager, void>)0x0051C150)(ref this);

    /// <summary>Creates a particle emitter attached to the specified physics object and registers it in the manager. If an emitter ID is supplied, replaces any existing emitter with that ID.
    /// <code>Offset: 0x0051C1F0
    /// unsigned int __thiscall ParticleManager::CreateParticleEmitter(_DWORD*,CPhysicsObj*,int,unsigned int,Frame*,unsigned int)</code>
    /// </summary>
    /// <param name="parent">Physics object to which the emitter will be attached.</param>
    /// <param name="a3">Index identifying the emitter configuration or type.</param>
    /// <param name="part_index">Attachment point index on the physics object.</param>
    /// <param name="frame">Transform frame defining emitter position and orientation.</param>
    /// <param name="a6">Optional existing emitter ID to replace; if zero, a new unique ID is generated.</param>
    /// <returns>Emitter ID assigned to the created particle emitter, or 0 on failure.</returns>
    public uint CreateParticleEmitter(ACBindings.Internal.CPhysicsObj* parent, int a3, uint part_index, ACBindings.Internal.Frame* frame, uint a6) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ParticleManager, ACBindings.Internal.CPhysicsObj*, int, uint, ACBindings.Internal.Frame*, uint, uint>)0x0051C1F0)(ref this, parent, a3, part_index, frame, a6);

    /// <summary>Updates all active particle emitters stored in the manager by invoking their update logic and removes any emitters whose lifetime has expired, freeing associated resources.
    /// <code>Offset: 0x0051C330
    /// void __thiscall ParticleManager::UpdateParticles(ParticleManager*)</code>
    /// </summary>
    public void UpdateParticles() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ParticleManager, void>)0x0051C330)(ref this);

    /// <summary>Create a particle emitter associated with the supplied physics object unless an emitter with the specified identifier already exists and is active, in which case creation is suppressed.
    /// <code>Offset: 0x0051C3D0
    /// unsigned int __thiscall ParticleManager::CreateBlockingParticleEmitter(_DWORD*,CPhysicsObj*,int,unsigned int,Frame*,unsigned int)</code>
    /// </summary>
    /// <param name="this">Pointer to the ParticleManager instance.</param>
    /// <param name="a2">Physics object that will own or be associated with the new emitter.</param>
    /// <param name="a3">Integer value specifying emitter type or configuration flags.</param>
    /// <param name="a4">Additional unsigned integer influencing emitter creation (e.g., priority, lifespan).</param>
    /// <param name="a5">Frame containing position and orientation for the emitter.</param>
    /// <param name="a6">Identifier used to prevent duplicate active emitters; if an active emitter with this ID already exists, the function returns 0.</param>
    /// <returns>Zero when an existing active emitter blocks creation; otherwise returns the identifier of the newly created particle emitter.</returns>
    public uint CreateBlockingParticleEmitter(ACBindings.Internal.CPhysicsObj* a2, int a3, uint a4, ACBindings.Internal.Frame* a5, uint a6) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ParticleManager, ACBindings.Internal.CPhysicsObj*, int, uint, ACBindings.Internal.Frame*, uint, uint>)0x0051C3D0)(ref this, a2, a3, a4, a5, a6);
}

