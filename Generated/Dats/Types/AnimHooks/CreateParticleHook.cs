namespace ACBindings.Internal;


/// <summary>Defines a particle creation hook that holds emitter identifiers, part index, and spatial offset, enabling serialization and execution of particle emitters within the physics system.</summary>
public unsafe struct CreateParticleHook
{
    // Base Classes
    public ACBindings.Internal.CAnimHook BaseClass_CAnimHook; // ACBindings.Internal.CAnimHook

    // Child Types
    public unsafe struct CreateParticleHook_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CreateParticleHook*, void> CreateParticleHook_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CreateParticleHook*, ACBindings.Internal.CPhysicsObj*, void> Execute; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CreateParticleHook*, int> GetType; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CreateParticleHook*, ACBindings.Internal.QualifiedDataIDArray*, void> GetSubDataIDs; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CreateParticleHook*, uint> pack_size; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CreateParticleHook*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CreateParticleHook*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.IDClass____tagDataID emitter_info_id;
    public uint part_index;
    public ACBindings.Internal.Frame offset;
    public uint emitter_id;

    // Generated Constructor
    public CreateParticleHook() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>Creates a particle emitter attached to the specified physics object using stored emitter information.
    /// <code>Offset: 0x00527AC0
    /// void __thiscall CreateParticleHook::Execute(CreateParticleHook*,CPhysicsObj*)</code>
    /// </summary>
    /// <param name="object">The physics object to which the emitter will be attached.</param>
    public void Execute(ACBindings.Internal.CPhysicsObj* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CreateParticleHook, ACBindings.Internal.CPhysicsObj*, void>)0x00527AC0)(ref this, object_);

    /// <summary>Initializes a CreateParticleHook instance with default animation hook settings, an identity offset frame, and prepares it for particle emission.
    /// <code>Offset: 0x00527D30
    /// void __thiscall CreateParticleHook::CreateParticleHook(CreateParticleHook*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CreateParticleHook, void>)0x00527D30)(ref this);

    /// <summary>Serializes CreateParticleHook fields into the provided buffer if space allows and returns the total number of bytes required.
    /// <code>Offset: 0x00528450
    /// unsigned int __thiscall CreateParticleHook::Pack(CreateParticleHook*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current write location in the destination buffer; updated to point past the data written.</param>
    /// <param name="size">Number of bytes remaining available in the buffer.</param>
    /// <returns>Byte count needed to pack this CreateParticleHook instance. Returns the same value whether or not packing occurs.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CreateParticleHook, void**, uint, uint>)0x00528450)(ref this, addr, size);

    /// <summary>Unpacks a CreateParticleHook from a binary stream pointed to by addr using size for embedded Frame data.
    /// <code>Offset: 0x005284A0
    /// int __thiscall CreateParticleHook::UnPack(CreateParticleHook*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="this">The CreateParticleHook instance into which data is read.</param>
    /// <param name="addr">Pointer to the current position in the input buffer; updated as data is consumed.</param>
    /// <param name="size">Size of the remaining buffer or context used by Frame::UnPack.</param>
    /// <returns>Non‑zero value indicating success (always 1).</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CreateParticleHook, void**, uint, int>)0x005284A0)(ref this, addr, size);

    /// <summary>Retrieves the qualified data ID associated with the particle effect in the given PES hook and appends it to the specified QualifiedDataIDArray.
    /// <code>Offset: 0x005285B0
    /// void __thiscall CreateParticleHook::GetSubDataIDs(CallPESHook*,QualifiedDataIDArray*)</code>
    /// </summary>
    /// <param name="id_array">The collection to which the data ID will be added.</param>
    public void GetSubDataIDs(ACBindings.Internal.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CreateParticleHook, ACBindings.Internal.QualifiedDataIDArray*, void>)0x005285B0)(ref this, id_array);
}

