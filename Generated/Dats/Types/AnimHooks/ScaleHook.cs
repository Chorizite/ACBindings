namespace ACBindings.Internal;


/// <summary>Encapsulates a timed scale transformation applied to physics objects, storing the target end scale and duration for interpolation.</summary>
public unsafe struct ScaleHook
{
    // Base Classes
    public ACBindings.Internal.CAnimHook BaseClass_CAnimHook; // ACBindings.Internal.CAnimHook

    // Child Types
    public unsafe struct ScaleHook_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ScaleHook*, void> ScaleHook_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ScaleHook*, ACBindings.Internal.CPhysicsObj*, void> Execute; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ScaleHook*, int> GetType; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ScaleHook*, ACBindings.Internal.QualifiedDataIDArray*, void> GetSubDataIDs; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ScaleHook*, uint> pack_size; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ScaleHook*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ScaleHook*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public float end;
    public float time;

    // Methods

    /// <summary>Applies scaling transformation to a physics object based on the hook's target end scale and interpolation period.
    /// <code>Offset: 0x00527A40
    /// void __thiscall ScaleHook::Execute(ScaleHook*,CPhysicsObj*)</code>
    /// </summary>
    /// <param name="object">The CPhysicsObj instance to be scaled.</param>
    public void Execute(ACBindings.Internal.CPhysicsObj* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ScaleHook, ACBindings.Internal.CPhysicsObj*, void>)0x00527A40)(ref this, object_);

    /// <summary>Unpacks texture velocity components from a data stream, storing them in the hook's u_speed and v_speed fields and advancing the buffer pointer.
    /// <code>Offset: 0x00527A90
    /// int __thiscall ScaleHook::UnPack(TextureVelocityHook*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="this">The TextureVelocityHook instance receiving unpacked values.</param>
    /// <param name="addr">Pointer to the current position within the data buffer; updated to point after the read values.</param>
    /// <param name="size">Number of bytes remaining in the buffer (unused by this implementation).</param>
    /// <returns>Integer status code, always 1 indicating success.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ScaleHook, void**, uint, int>)0x00527A90)(ref this, addr, size);
}

