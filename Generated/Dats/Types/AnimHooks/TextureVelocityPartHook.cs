namespace ACBindings.Internal;


/// <summary>Applies a texture velocity offset to a specified part of a physics object, enabling animated scrolling or movement of textures on that component.</summary>
public unsafe struct TextureVelocityPartHook
{
    // Base Classes
    public ACBindings.Internal.CAnimHook BaseClass_CAnimHook; // ACBindings.Internal.CAnimHook

    // Child Types
    public unsafe struct TextureVelocityPartHook_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.TextureVelocityPartHook*, void> TextureVelocityPartHook_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.TextureVelocityPartHook*, ACBindings.Internal.CPhysicsObj*, void> Execute; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.TextureVelocityPartHook*, int> GetType; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.TextureVelocityPartHook*, ACBindings.Internal.QualifiedDataIDArray*, void> GetSubDataIDs; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.TextureVelocityPartHook*, uint> pack_size; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.TextureVelocityPartHook*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.TextureVelocityPartHook*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public uint part_index;
    public float u_speed;
    public float v_speed;

    // Generated Constructor
    public TextureVelocityPartHook() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>Initializes a TextureVelocityPartHook instance, setting its base animation hook to default values and resetting the part index along with texture velocity components.
    /// <code>Offset: 0x005274C0
    /// void __thiscall TextureVelocityPartHook::TextureVelocityPartHook(TextureVelocityPartHook*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TextureVelocityPartHook, void>)0x005274C0)(ref this);

    /// <summary>Sets the texture velocity for a specific part of a physics object based on the hook's configuration.
    /// <code>Offset: 0x00527B50
    /// void __thiscall TextureVelocityPartHook::Execute(TextureVelocityPartHook*,CPhysicsObj*)</code>
    /// </summary>
    /// <param name="this">TextureVelocityPartHook instance containing the target part index and u/v speed values.</param>
    /// <param name="object">Physics object whose specified part will receive the new texture velocity.</param>
    public void Execute(ACBindings.Internal.CPhysicsObj* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TextureVelocityPartHook, ACBindings.Internal.CPhysicsObj*, void>)0x00527B50)(ref this, object_);

    /// <summary>Serializes the texture velocity part’s index and speed components into a supplied buffer, advancing the buffer pointer as data is written.
    /// <code>Offset: 0x00527B70
    /// unsigned int __thiscall TextureVelocityPartHook::Pack(TextureVelocityPartHook*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current write position within the buffer; will be updated after each field is serialized.</param>
    /// <param name="size">Number of bytes available in the buffer for serialization; if insufficient, no data is written but the required size is still returned.</param>
    /// <returns>Size in bytes needed to pack this hook’s data.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TextureVelocityPartHook, void**, uint, uint>)0x00527B70)(ref this, addr, size);
}

