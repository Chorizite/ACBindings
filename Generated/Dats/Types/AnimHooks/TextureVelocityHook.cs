namespace ACBindings.Internal;

public unsafe struct TextureVelocityHook
{
    // Base Classes
    public ACBindings.Internal.CAnimHook BaseClass_CAnimHook; // ACBindings.Internal.CAnimHook

    // Child Types
    public unsafe struct TextureVelocityHook_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.TextureVelocityHook*, void> TextureVelocityHook_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.TextureVelocityHook*, ACBindings.Internal.CPhysicsObj*, void> Execute; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.TextureVelocityHook*, int> GetType; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.TextureVelocityHook*, ACBindings.Internal.QualifiedDataIDArray*, void> GetSubDataIDs; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.TextureVelocityHook*, uint> pack_size; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.TextureVelocityHook*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.TextureVelocityHook*, void**, uint, int> UnPack; // function pointer

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

    /// <summary>
    /// <code>Offset: 0x005201E0
    /// unsigned int __thiscall TextureVelocityHook::pack_size(Vec2D*)</code>
    /// </summary>
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TextureVelocityHook, uint>)0x005201E0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00527500
    /// void __thiscall TextureVelocityHook::TextureVelocityHook(TextureVelocityHook*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TextureVelocityHook, void>)0x00527500)(ref this);

    /// <summary>
    /// <code>Offset: 0x00527A60
    /// unsigned int __thiscall TextureVelocityHook::Pack(TextureVelocityHook*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TextureVelocityHook, void**, uint, uint>)0x00527A60)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x00527BB0
    /// void __thiscall TextureVelocityHook::Execute(TextureVelocityHook*,CPhysicsObj*)</code>
    /// </summary>
    public void Execute(ACBindings.Internal.CPhysicsObj* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TextureVelocityHook, ACBindings.Internal.CPhysicsObj*, void>)0x00527BB0)(ref this, object_);
}

