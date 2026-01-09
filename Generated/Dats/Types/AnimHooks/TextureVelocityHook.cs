namespace ACBindings;

// TextureVelocityHook
public unsafe struct TextureVelocityHook
{
    // Base Classes
    public ACBindings.CAnimHook BaseClass_CAnimHook; // ACBindings.CAnimHook

    // Child Types
    // TextureVelocityHook_vtbl
    public unsafe struct TextureVelocityHook_vtbl
    {
        // Members
        public System.IntPtr TextureVelocityHook_dtor_0; // function pointer
        public System.IntPtr Execute; // function pointer
        public System.IntPtr GetType; // function pointer
        public System.IntPtr GetSubDataIDs; // function pointer
        public System.IntPtr pack_size; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

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
    // unsigned int __thiscall TextureVelocityHook::pack_size(Vec2D*)
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.TextureVelocityHook, uint>)0x005201E0)(ref this);
    // void __thiscall TextureVelocityHook::TextureVelocityHook(TextureVelocityHook*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.TextureVelocityHook, void>)0x00527500)(ref this);
    // unsigned int __thiscall TextureVelocityHook::Pack(TextureVelocityHook*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.TextureVelocityHook, void**, uint, uint>)0x00527A60)(ref this, addr, size);
    // void __thiscall TextureVelocityHook::Execute(TextureVelocityHook*,CPhysicsObj*)
    public void Execute(ACBindings.CPhysicsObj* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.TextureVelocityHook, ACBindings.CPhysicsObj*, void>)0x00527BB0)(ref this, object_);
}

