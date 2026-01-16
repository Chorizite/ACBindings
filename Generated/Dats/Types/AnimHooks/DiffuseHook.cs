namespace ACBindings.Internal;


/// <summary>Controls diffusion parameters for a physics object, specifying initial and final values along with transition duration.</summary>
/// <remarks>Derives from <c>CAnimHook</c>; participates in hook serialization and execution within the animation system.</remarks>
public unsafe struct DiffuseHook
{
    // Base Classes
    public ACBindings.Internal.CAnimHook BaseClass_CAnimHook; // ACBindings.Internal.CAnimHook

    // Child Types
    public unsafe struct DiffuseHook_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DiffuseHook*, void> DiffuseHook_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DiffuseHook*, ACBindings.Internal.CPhysicsObj*, void> Execute; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DiffuseHook*, int> GetType; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DiffuseHook*, ACBindings.Internal.QualifiedDataIDArray*, void> GetSubDataIDs; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DiffuseHook*, uint> pack_size; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DiffuseHook*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DiffuseHook*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public float start;
    public float end;
    public float time;

    // Methods

    /// <summary>Packages DiffuseHook's timing values into a contiguous block of memory, advancing the destination pointer past the packed data.
    /// <code>Offset: 0x00527850
    /// unsigned int __thiscall DiffuseHook::Pack(DiffuseHook*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current write location; updated to point after the last written value.</param>
    /// <param name="size">Number of bytes available in the buffer. If less than required, no data is written.</param>
    /// <returns>The total number of bytes that would be written (the size needed for start, end, and time).</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DiffuseHook, void**, uint, uint>)0x00527850)(ref this, addr, size);

    /// <summary>Applies diffusion to the specified physics object using start and end values over a given time period.
    /// <code>Offset: 0x00527A00
    /// void __thiscall DiffuseHook::Execute(DiffuseHook*,CPhysicsObj*)</code>
    /// </summary>
    /// <param name="object">The physics object to receive the diffusion effect.</param>
    public void Execute(ACBindings.Internal.CPhysicsObj* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DiffuseHook, ACBindings.Internal.CPhysicsObj*, void>)0x00527A00)(ref this, object_);
}

