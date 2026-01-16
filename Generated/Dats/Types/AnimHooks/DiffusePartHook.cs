namespace ACBindings.Internal;


/// <summary>Represents an animation hook that applies diffusion to a specific part of a physics object, specifying the part index and start/end influence over a given time interval.</summary>
public unsafe struct DiffusePartHook
{
    // Base Classes
    public ACBindings.Internal.CAnimHook BaseClass_CAnimHook; // ACBindings.Internal.CAnimHook

    // Child Types
    public unsafe struct DiffusePartHook_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DiffusePartHook*, void> DiffusePartHook_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DiffusePartHook*, ACBindings.Internal.CPhysicsObj*, void> Execute; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DiffusePartHook*, int> GetType; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DiffusePartHook*, ACBindings.Internal.QualifiedDataIDArray*, void> GetSubDataIDs; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DiffusePartHook*, uint> pack_size; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DiffusePartHook*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DiffusePartHook*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public uint part;
    public float start;
    public float end;
    public float time;

    // Methods

    /// <summary>Applies a part-diffusion effect to the specified physics object based on this hook's configuration.
    /// <code>Offset: 0x00527980
    /// void __thiscall DiffusePartHook::Execute(DiffusePartHook*,CPhysicsObj*)</code>
    /// </summary>
    /// <param name="object">The physics object receiving the diffusion effect.</param>
    public void Execute(ACBindings.Internal.CPhysicsObj* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DiffusePartHook, ACBindings.Internal.CPhysicsObj*, void>)0x00527980)(ref this, object_);

    /// <summary>Serializes the DiffusePartHook data into a contiguous memory buffer.
    /// <code>Offset: 0x005279B0
    /// unsigned int __thiscall DiffusePartHook::Pack(DiffusePartHook*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current write position; updated to point after the serialized data if written.</param>
    /// <param name="size">Number of bytes available at the address for writing. If insufficient, no data is written.</param>
    /// <returns>Size in bytes required to serialize the hook. Data is written only when size is sufficient.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DiffusePartHook, void**, uint, uint>)0x005279B0)(ref this, addr, size);
}

