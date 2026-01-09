namespace ACBindings;

// AttackHook
public unsafe struct AttackHook
{
    // Base Classes
    public ACBindings.CAnimHook BaseClass_CAnimHook; // ACBindings.CAnimHook

    // Child Types
    // AttackHook_vtbl
    public unsafe struct AttackHook_vtbl
    {
        // Members
        public System.IntPtr AttackHook_dtor_0; // function pointer
        public System.IntPtr Execute; // function pointer
        public System.IntPtr GetType; // function pointer
        public System.IntPtr GetSubDataIDs; // function pointer
        public System.IntPtr pack_size; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.AttackCone attack_cone;

    // Generated Constructor
    public AttackHook() {
        _ConstructorInternal();
    }

    // Methods
    // void __thiscall AttackHook::AttackHook(AttackHook*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.AttackHook, void>)0x005273D0)(ref this);
    // unsigned int __thiscall AttackHook::pack_size(AttackHook*)
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.AttackHook, uint>)0x00527750)(ref this);
    // void __thiscall AttackHook::Execute(AttackHook*,CPhysicsObj*)
    public void Execute(ACBindings.CPhysicsObj* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AttackHook, ACBindings.CPhysicsObj*, void>)0x00527770)(ref this, object_);
    // unsigned int __thiscall AttackHook::Pack(AttackHook*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AttackHook, void**, uint, uint>)0x005283D0)(ref this, addr, size);
    // int __thiscall AttackHook::UnPack(AttackHook*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AttackHook, void**, uint, int>)0x005283E0)(ref this, addr, size);
}

