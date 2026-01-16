namespace ACBindings.Internal;


/// <summary>Applies an angular velocity to a physics object using a predefined rotation axis.</summary>
public unsafe struct SetOmegaHook
{
    // Base Classes
    public ACBindings.Internal.CAnimHook BaseClass_CAnimHook; // ACBindings.Internal.CAnimHook

    // Child Types
    public unsafe struct SetOmegaHook_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SetOmegaHook*, void> SetOmegaHook_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SetOmegaHook*, ACBindings.Internal.CPhysicsObj*, void> Execute; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SetOmegaHook*, int> GetType; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SetOmegaHook*, ACBindings.Internal.QualifiedDataIDArray*, void> GetSubDataIDs; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SetOmegaHook*, uint> pack_size; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SetOmegaHook*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SetOmegaHook*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.AC1Legacy.Vector3 axis;

    // Methods

    /// <summary>Applies the hook’s rotation axis as angular velocity to a physics object.
    /// <code>Offset: 0x00527B30
    /// void __thiscall SetOmegaHook::Execute(SetOmegaHook*,CPhysicsObj*)</code>
    /// </summary>
    /// <param name="object">The physics object whose ω vector is updated using the hook’s axis.</param>
    public void Execute(ACBindings.Internal.CPhysicsObj* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SetOmegaHook, ACBindings.Internal.CPhysicsObj*, void>)0x00527B30)(ref this, object_);

    /// <summary>Packs the SetOmegaHook's axis vector into a byte buffer and returns the total size required.
    /// <code>Offset: 0x005284F0
    /// unsigned int __thiscall SetOmegaHook::Pack(SetOmegaHook*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Reference to a pointer marking the current write position in the buffer; updated to point after the last written byte if sufficient space is available.</param>
    /// <param name="size">Number of bytes available for writing in the buffer.</param>
    /// <returns>The number of bytes that would be written, regardless of whether the provided buffer was large enough.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SetOmegaHook, void**, uint, uint>)0x005284F0)(ref this, addr, size);

    /// <summary>Unpacks three consecutive float values from a byte buffer into the hook's axis vector, advancing the buffer pointer accordingly.
    /// <code>Offset: 0x00528540
    /// int __thiscall SetOmegaHook::UnPack(SetOmegaHook*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Reference to the current position in the data stream; updated to point past the unpacked values.</param>
    /// <param name="size">Number of bytes remaining in the stream; must be at least 12 for a successful unpack.</param>
    /// <returns>Always returns 1, indicating success.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SetOmegaHook, void**, uint, int>)0x00528540)(ref this, addr, size);
}

