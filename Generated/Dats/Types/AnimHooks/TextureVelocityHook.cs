namespace ACBindings.Internal;


/// <summary>Represents a texture velocity animation hook that applies scrolling speed to textures on physics objects, storing horizontal (u_speed) and vertical (v_speed) components. It inherits from CAnimHook and integrates with the animation system for packing, unpacking, and execution of hooks.</summary>
public unsafe struct TextureVelocityHook
{
    // Base Classes
    public ACBindings.Internal.CAnimHook BaseClass_CAnimHook; // ACBindings.Internal.CAnimHook

    // Child Types
    public unsafe struct TextureVelocityHook_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.TextureVelocityHook*, void> TextureVelocityHook_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.TextureVelocityHook*, ACBindings.Internal.CPhysicsObj*, void> Execute; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.TextureVelocityHook*, int> GetType; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.TextureVelocityHook*, ACBindings.Internal.QualifiedDataIDArray*, void> GetSubDataIDs; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.TextureVelocityHook*, uint> pack_size; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.TextureVelocityHook*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.TextureVelocityHook*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public float u_speed;
    public float v_speed;

    // Generated Constructor
    public TextureVelocityHook() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>Calculates the number of bytes required to serialize a texture velocity hook.
    /// <code>Offset: 0x005201E0
    /// unsigned int __thiscall TextureVelocityHook::pack_size(Vec2D*)</code>
    /// </summary>
    /// <param name="this">The vector used as context for packing (not directly involved in size calculation).</param>
    /// <returns>The constant size of 8 bytes needed for serialization.</returns>
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TextureVelocityHook, uint>)0x005201E0)(ref this);

    /// <summary>Initializes a TextureVelocityHook instance with default settings and zero texture velocity.
    /// <code>Offset: 0x00527500
    /// void __thiscall TextureVelocityHook::TextureVelocityHook(TextureVelocityHook*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TextureVelocityHook, void>)0x00527500)(ref this);

    /// <summary>Packs the u_speed and v_speed values into a contiguous buffer, advancing the pointer accordingly.
    /// <code>Offset: 0x00527A60
    /// unsigned int __thiscall TextureVelocityHook::Pack(TextureVelocityHook*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="this">The TextureVelocityHook instance containing the velocity components to pack.</param>
    /// <param name="addr">Pointer to the destination buffer; updated to point after the written data.</param>
    /// <param name="size">Number of bytes available in the destination buffer; packing occurs only if sufficient space exists.</param>
    /// <returns>The total size required for packing this hook, expressed in bytes.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TextureVelocityHook, void**, uint, uint>)0x00527A60)(ref this, addr, size);

    /// <summary>Sets the texture velocity of a physics object using the u and v speed values defined in this hook.
    /// <code>Offset: 0x00527BB0
    /// void __thiscall TextureVelocityHook::Execute(TextureVelocityHook*,CPhysicsObj*)</code>
    /// </summary>
    /// <param name="object">The physics object whose texture velocity will be updated.</param>
    public void Execute(ACBindings.Internal.CPhysicsObj* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TextureVelocityHook, ACBindings.Internal.CPhysicsObj*, void>)0x00527BB0)(ref this, object_);
}

