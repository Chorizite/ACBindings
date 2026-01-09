namespace ACBindings;

// TextureVelocityPartHook
public unsafe struct TextureVelocityPartHook
{
    // Base Classes
    public ACBindings.CAnimHook BaseClass_CAnimHook; // ACBindings.CAnimHook

    // Child Types
    // TextureVelocityPartHook_vtbl
    public unsafe struct TextureVelocityPartHook_vtbl
    {
        // Members
        public System.IntPtr TextureVelocityPartHook_dtor_0; // function pointer
        public System.IntPtr Execute; // function pointer
        public System.IntPtr GetType; // function pointer
        public System.IntPtr GetSubDataIDs; // function pointer
        public System.IntPtr pack_size; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

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
    // void __thiscall TextureVelocityPartHook::TextureVelocityPartHook(TextureVelocityPartHook*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.TextureVelocityPartHook, void>)0x005274C0)(ref this);
    // void __thiscall TextureVelocityPartHook::Execute(TextureVelocityPartHook*,CPhysicsObj*)
    public void Execute(ACBindings.CPhysicsObj* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.TextureVelocityPartHook, ACBindings.CPhysicsObj*, void>)0x00527B50)(ref this, object_);
    // unsigned int __thiscall TextureVelocityPartHook::Pack(TextureVelocityPartHook*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.TextureVelocityPartHook, void**, uint, uint>)0x00527B70)(ref this, addr, size);
}

