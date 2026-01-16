namespace ACBindings.Internal;


/// <summary>
/// Represents the configuration data for a particle emitter, including emission rates, lifetime, spatial vectors, scaling factors, and transparency settings. Manages how particles are generated, positioned, and animated within a visual effects system.
/// </summary>
public unsafe struct ParticleEmitterInfo
{
    // Base Classes
    public ACBindings.Internal.SerializeUsingPackDBObj BaseClass_SerializeUsingPackDBObj; // ACBindings.Internal.SerializeUsingPackDBObj

    // Child Types
    public unsafe struct ParticleEmitterInfo_vtbl
    {
        // Members
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, ACBindings.Internal._GUID*, void**, int> IUnknown_QueryInterface; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_AddRef; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_Release; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, ACBindings.Internal.TResult*, ACBindings.Internal.Turbine_GUID*, void**, ACBindings.Internal.TResult*> QueryInterface; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> AddRef; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> Release; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, void> DBObj_dtor_18; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.Archive*, void> Serialize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.QualifiedDataIDArray*, void> GetSubDataIDs; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> InitLoad; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> GetSubObjects; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> ReleaseSubObjects; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> NotifyFidelityLevel; // function pointer
        public System.IntPtr Refresh;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.DBObj*, byte> CopyInto; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, void> Destroy; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.IDataGraph*, void> FillDataGraph; // function pointer
        public System.IntPtr SetDID;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, uint> GetDBOType; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.DBObj*> Allocate; // function pointer
        public System.IntPtr SaveToDisk;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> ReloadFromDisk; // function pointer

        // Methods
    }

    // Members
    public int emitter_type;
    public int particle_type;
    public int is_parent_local;
    public ACBindings.Internal.IDClass____tagDataID gfxobj_id;
    public ACBindings.Internal.IDClass____tagDataID hw_gfxobj_id;
    public double birthrate;
    public int max_particles;
    public int initial_particles;
    public int total_particles;
    public double total_seconds;
    public double lifespan_rand;
    public double lifespan;
    public ACBindings.Internal.CSphere sorting_sphere;
    public ACBindings.Internal.AC1Legacy.Vector3 offset_dir;
    public float min_offset;
    public float max_offset;
    public ACBindings.Internal.AC1Legacy.Vector3 a;
    public ACBindings.Internal.AC1Legacy.Vector3 b;
    public ACBindings.Internal.AC1Legacy.Vector3 c;
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

    /// <summary>Allocates and initializes a new particle emitter info object, then returns it as a DBObj pointer.
    /// <code>Offset: 0x004F7E90
    /// DBObj* __cdecl ParticleEmitterInfo::Allocator()</code>
    /// </summary>
    /// <returns>A pointer to the newly constructed DBObj representing the particle emitter; null if allocation fails.</returns>
    public static ACBindings.Internal.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.DBObj*>)0x004F7E90)();

    /// <summary>Calculates a randomized starting scale for particles by applying a random offset to the emitter's base start scale, then limits the value within 0.1 to 10.0.
    /// <code>Offset: 0x00517C00
    /// float __thiscall ParticleEmitterInfo::GetRandomStartScale(ParticleEmitterInfo*)</code>
    /// </summary>
    /// <returns>The resulting starting scale, clamped between 0.1 and 10.0.</returns>
    public float GetRandomStartScale() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ParticleEmitterInfo, float>)0x00517C00)(ref this);

    /// <summary>Computes a random final scaling factor based on the emitter's base final scale and a randomness multiplier, then clamps it between 0.1 and 10.0.
    /// <code>Offset: 0x00517C50
    /// float __thiscall ParticleEmitterInfo::GetRandomFinalScale(ParticleEmitterInfo*)</code>
    /// </summary>
    /// <returns>The resulting scale factor, guaranteed to be between 0.1 and 10.0 inclusive.</returns>
    public float GetRandomFinalScale() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ParticleEmitterInfo, float>)0x00517C50)(ref this);

    /// <summary>Computes a randomized starting transition factor for a particle emitter, combining its base start transition with a random offset and constraining the result between 0 and 1.
    /// <code>Offset: 0x00517CA0
    /// float __thiscall ParticleEmitterInfo::GetRandomStartTrans(ParticleEmitterInfo*)</code>
    /// </summary>
    /// <returns>A float value ranging from 0 to 1 that represents the emitter's initial transition state.</returns>
    public float GetRandomStartTrans() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ParticleEmitterInfo, float>)0x00517CA0)(ref this);

    /// <summary>Computes a randomized final transparency for the emitter, clamped to the range [0, 1].
    /// <code>Offset: 0x00517CF0
    /// float __thiscall ParticleEmitterInfo::GetRandomFinalTrans(ParticleEmitterInfo*)</code>
    /// </summary>
    /// <returns>A float in the interval [0, 1] that represents the emitter’s final transparency value after applying randomness.</returns>
    public float GetRandomFinalTrans() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ParticleEmitterInfo, float>)0x00517CF0)(ref this);

    /// <summary>Computes a random lifespan for emitted particles based on base lifespan and variation, ensuring the result is non‑negative.
    /// <code>Offset: 0x00517D40
    /// float __thiscall ParticleEmitterInfo::GetRandomLifespan(ParticleEmitterInfo*)</code>
    /// </summary>
    /// <returns>A floating‑point value representing the particle’s lifespan in seconds.</returns>
    public float GetRandomLifespan() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ParticleEmitterInfo, float>)0x00517D40)(ref this);

    /// <summary>Initializes a ParticleEmitterInfo instance with default values, setting up base classes and zeroing parameters such as emitter type, particle type, birthrate, lifespan, geometry vectors, and scaling/transparency ranges.
    /// <code>Offset: 0x00517D80
    /// void __thiscall ParticleEmitterInfo::ParticleEmitterInfo(ParticleEmitterInfo*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ParticleEmitterInfo, void>)0x00517D80)(ref this);

    /// <summary>Retrieves the database object type identifier for this particle emitter.
    /// <code>Offset: 0x00517EC0
    /// unsigned int __thiscall ParticleEmitterInfo::GetDBOType(ParticleEmitterInfo*)</code>
    /// </summary>
    /// <returns>The unsigned integer representing the DBO type, typically 42 for this class.</returns>
    public uint GetDBOType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ParticleEmitterInfo, uint>)0x00517EC0)(ref this);

    /// <summary>Initializes the emitter’s sorting sphere by computing its radius from the larger of the configured maximum offset and the product of maximum angular deviation with particle lifespan, then centers the sphere at the origin.
    /// <code>Offset: 0x00517EE0
    /// void __thiscall ParticleEmitterInfo::InitEnd(ParticleEmitterInfo*)</code>
    /// </summary>
    public void InitEnd() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ParticleEmitterInfo, void>)0x00517EE0)(ref this);

    /// <summary>Determines whether a new particle should be emitted based on the emitter’s limits, current count, total emissions, and timing rules.
    /// <code>Offset: 0x00517F50
    /// int __thiscall ParticleEmitterInfo::ShouldEmitParticle(ParticleEmitterInfo*,int,int,const AC1Legacy::Vector3*,long double)</code>
    /// </summary>
    /// <param name="num_particles">Current number of active particles for this emitter; must remain below <c>max_particles</c>.</param>
    /// <param name="total_emitted">Total number of particles that have already been emitted from this emitter; must be less than <c>total_particles</c> if a maximum is set.</param>
    /// <param name="emitter_offset">Position offset for the emitter (unused in the decision logic).</param>
    /// <param name="last_emit_time">Timestamp of the last emission, compared against <c>birthrate</c> when the emitter type requires timed spacing.</param>
    /// <returns>Non‑zero if a particle should be emitted; zero otherwise.</returns>
    public int ShouldEmitParticle(int num_particles, int total_emitted, ACBindings.Internal.AC1Legacy.Vector3* emitter_offset, double last_emit_time) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ParticleEmitterInfo, int, int, ACBindings.Internal.AC1Legacy.Vector3*, double, int>)0x00517F50)(ref this, num_particles, total_emitted, emitter_offset, last_emit_time);

    /// <summary>Computes a random positional offset for particle emission based on the emitter’s direction and configured minimum/maximum offsets, writing the result into the supplied vector.
    /// <code>Offset: 0x00517FD0
    /// AC1Legacy::Vector3* __thiscall ParticleEmitterInfo::GetRandomOffset(ParticleEmitterInfo*,AC1Legacy::Vector3*)</code>
    /// </summary>
    /// <param name="result">The Vector3 instance to receive the computed offset.</param>
    /// <returns>The same Vector3 pointer provided as result after being populated.</returns>
    public ACBindings.Internal.AC1Legacy.Vector3* GetRandomOffset(ACBindings.Internal.AC1Legacy.Vector3* result) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ParticleEmitterInfo, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.AC1Legacy.Vector3*>)0x00517FD0)(ref this, result);

    /// <summary>Generates a vector by scaling the emitter's base vector A with a random factor between min_a and max_a, storing the result in the supplied Vector3.
    /// <code>Offset: 0x00518140
    /// AC1Legacy::Vector3* __thiscall ParticleEmitterInfo::GetRandomA(ParticleEmitterInfo*,AC1Legacy::Vector3*)</code>
    /// </summary>
    /// <param name="result">Vector to receive the calculated values.</param>
    /// <returns>The same pointer passed as result for chaining purposes.</returns>
    public ACBindings.Internal.AC1Legacy.Vector3* GetRandomA(ACBindings.Internal.AC1Legacy.Vector3* result) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ParticleEmitterInfo, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.AC1Legacy.Vector3*>)0x00518140)(ref this, result);

    /// <summary>Generates a random vector by scaling the emitter's base B direction with a value between min_b and max_b, storing it in the supplied result.
    /// <code>Offset: 0x005181A0
    /// AC1Legacy::Vector3* __thiscall ParticleEmitterInfo::GetRandomB(ParticleEmitterInfo*,AC1Legacy::Vector3*)</code>
    /// </summary>
    /// <param name="result">Pointer to an AC1Legacy::Vector3 that receives the generated vector.</param>
    /// <returns>The same pointer passed as result after being filled with the randomized vector.</returns>
    public ACBindings.Internal.AC1Legacy.Vector3* GetRandomB(ACBindings.Internal.AC1Legacy.Vector3* result) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ParticleEmitterInfo, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.AC1Legacy.Vector3*>)0x005181A0)(ref this, result);

    /// <summary>Computes a random vector along the emitter's 'c' axis by selecting a scalar uniformly between min_c and max_c, scaling the c vector accordingly, and storing the result in the supplied Vector3.
    /// <code>Offset: 0x00518200
    /// AC1Legacy::Vector3* __thiscall ParticleEmitterInfo::GetRandomC(ParticleEmitterInfo*,AC1Legacy::Vector3*)</code>
    /// </summary>
    /// <param name="result">The Vector3 instance to receive the computed random vector.</param>
    /// <returns>The same Vector3 pointer that was passed in, populated with the random vector.</returns>
    public ACBindings.Internal.AC1Legacy.Vector3* GetRandomC(ACBindings.Internal.AC1Legacy.Vector3* result) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ParticleEmitterInfo, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.AC1Legacy.Vector3*>)0x00518200)(ref this, result);

    /// <summary>Serializes a ParticleEmitterInfo instance into a binary buffer, writing exactly 172 bytes when sufficient space is available.
    /// <code>Offset: 0x005182B0
    /// unsigned int __thiscall ParticleEmitterInfo::Pack(ParticleEmitterInfo*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current write position in the destination buffer; updated to point after the packed data.</param>
    /// <param name="size">Number of bytes remaining in the buffer; packing proceeds only if this value is at least 172.</param>
    /// <returns>Always 172, the size of the serialized block. If insufficient space, no data is written but the return value remains 172.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ParticleEmitterInfo, void**, uint, uint>)0x005182B0)(ref this, addr, size);

    /// <summary>Deserializes particle emitter information from a packed buffer into this ParticleEmitterInfo instance, initializing all relevant properties.
    /// <code>Offset: 0x00518520
    /// int __thiscall ParticleEmitterInfo::UnPack(ParticleEmitterInfo*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current read position in the buffer; it is advanced as fields are unpacked.</param>
    /// <param name="size">Number of bytes remaining in the buffer, used to determine whether optional data should be processed.</param>
    /// <returns>Always returns 1 to indicate successful unpacking.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ParticleEmitterInfo, void**, uint, int>)0x00518520)(ref this, addr, size);
}

