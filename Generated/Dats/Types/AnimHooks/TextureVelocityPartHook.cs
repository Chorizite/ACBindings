namespace ACBindings.Internal;

public unsafe struct TextureVelocityPartHook
{
    // Base Classes
    public ACBindings.Internal.CAnimHook BaseClass_CAnimHook; // ACBindings.Internal.CAnimHook

    // Child Types
    public unsafe struct TextureVelocityPartHook_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.TextureVelocityPartHook*, void> TextureVelocityPartHook_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.TextureVelocityPartHook*, ACBindings.Internal.CPhysicsObj*, void> Execute; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.TextureVelocityPartHook*, int> GetType; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.TextureVelocityPartHook*, ACBindings.Internal.QualifiedDataIDArray*, void> GetSubDataIDs; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.TextureVelocityPartHook*, uint> pack_size; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.TextureVelocityPartHook*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.TextureVelocityPartHook*, void**, uint, int> UnPack; // function pointer

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

    /// <summary>
    /// <code>Offset: 0x005274C0
    /// void __thiscall TextureVelocityPartHook::TextureVelocityPartHook(TextureVelocityPartHook*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TextureVelocityPartHook, void>)0x005274C0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00527B50
    /// void __thiscall TextureVelocityPartHook::Execute(TextureVelocityPartHook*,CPhysicsObj*)</code>
    /// </summary>
    public void Execute(ACBindings.Internal.CPhysicsObj* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TextureVelocityPartHook, ACBindings.Internal.CPhysicsObj*, void>)0x00527B50)(ref this, object_);

    /// <summary>
    /// <code>Offset: 0x00527B70
    /// unsigned int __thiscall TextureVelocityPartHook::Pack(TextureVelocityPartHook*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TextureVelocityPartHook, void**, uint, uint>)0x00527B70)(ref this, addr, size);
}

