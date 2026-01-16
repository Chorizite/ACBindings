namespace ACBindings.Internal;


/// <summary>Destroys a particle emitter identified by emitter_id from a physics object during animation execution.</summary>
public unsafe struct DestroyParticleHook
{
    // Base Classes
    public ACBindings.Internal.CAnimHook BaseClass_CAnimHook; // ACBindings.Internal.CAnimHook

    // Child Types
    public unsafe struct DestroyParticleHook_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DestroyParticleHook*, void> DestroyParticleHook_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DestroyParticleHook*, ACBindings.Internal.CPhysicsObj*, void> Execute; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DestroyParticleHook*, int> GetType; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DestroyParticleHook*, ACBindings.Internal.QualifiedDataIDArray*, void> GetSubDataIDs; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DestroyParticleHook*, uint> pack_size; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DestroyParticleHook*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DestroyParticleHook*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public uint emitter_id;

    // Methods

    /// <summary>Returns the type code identifying a DestroyParticleHook instance.
    /// <code>Offset: 0x005274A0
    /// int __thiscall DestroyParticleHook::GetType(DestroyParticleHook*)</code>
    /// </summary>
    /// <returns>The integer 14, which denotes the DestroyParticleHook type within the animation system.</returns>
    public int GetType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DestroyParticleHook, int>)0x005274A0)(ref this);

    /// <summary>Deserializes a light‑on flag from raw data into a SetLightHook object and advances the buffer pointer.
    /// <code>Offset: 0x005277A0
    /// int __thiscall DestroyParticleHook::UnPack(SetLightHook*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="this">The SetLightHook instance to populate with unpacked data.</param>
    /// <param name="addr">Pointer to the buffer containing serialized data; after execution it points past the consumed bytes.</param>
    /// <param name="size">Number of bytes remaining in the buffer (not used directly by this function).</param>
    /// <returns>Returns 1 to indicate successful unpacking.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DestroyParticleHook, void**, uint, int>)0x005277A0)(ref this, addr, size);

    /// <summary>Destroys the particle emitter identified by emitter_id from the specified physics object.
    /// <code>Offset: 0x00527B10
    /// void __thiscall DestroyParticleHook::Execute(DestroyParticleHook*,CPhysicsObj*)</code>
    /// </summary>
    /// <param name="object">The physics object whose particle emitter should be destroyed.</param>
    public void Execute(ACBindings.Internal.CPhysicsObj* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DestroyParticleHook, ACBindings.Internal.CPhysicsObj*, void>)0x00527B10)(ref this, object_);
}

