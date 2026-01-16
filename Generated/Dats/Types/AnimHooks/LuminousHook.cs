namespace ACBindings.Internal;


/// <summary>LuminousHook specifies a luminosity interpolation applied to physics objects, defining start and end brightness levels and the duration over which the change occurs.</summary>
public unsafe struct LuminousHook
{
    // Base Classes
    public ACBindings.Internal.CAnimHook BaseClass_CAnimHook; // ACBindings.Internal.CAnimHook

    // Child Types
    public unsafe struct LuminousHook_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.LuminousHook*, void> LuminousHook_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.LuminousHook*, ACBindings.Internal.CPhysicsObj*, void> Execute; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.LuminousHook*, int> GetType; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.LuminousHook*, ACBindings.Internal.QualifiedDataIDArray*, void> GetSubDataIDs; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.LuminousHook*, uint> pack_size; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.LuminousHook*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.LuminousHook*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public float start;
    public float end;
    public float time;

    // Methods

    /// <summary>Deserializes the part index and velocity components from a binary buffer into the hook object.
    /// <code>Offset: 0x00527890
    /// int __thiscall LuminousHook::UnPack(TextureVelocityPartHook*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="hook">Pointer to the TextureVelocityPartHook instance being initialized.</param>
    /// <param name="addr">Double pointer that tracks the current read position in the buffer; it is advanced as data is consumed.</param>
    /// <param name="size">Size of the remaining data (unused by this implementation).</param>
    /// <returns>1, indicating successful unpacking of the hook data.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LuminousHook, void**, uint, int>)0x00527890)(ref this, addr, size);

    /// <summary>Interpolate a physics object's luminosity from a starting value to an ending value over a set duration.
    /// <code>Offset: 0x00527960
    /// void __thiscall LuminousHook::Execute(LuminousHook*,CPhysicsObj*)</code>
    /// </summary>
    /// <param name="object">The CPhysicsObj whose lighting is being modified.</param>
    public void Execute(ACBindings.Internal.CPhysicsObj* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LuminousHook, ACBindings.Internal.CPhysicsObj*, void>)0x00527960)(ref this, object_);
}

