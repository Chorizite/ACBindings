namespace ACBindings;

// SetLightHook
public unsafe struct SetLightHook
{
    // Base Classes
    public ACBindings.CAnimHook BaseClass_CAnimHook; // ACBindings.CAnimHook

    // Child Types
    // SetLightHook_vtbl
    public unsafe struct SetLightHook_vtbl
    {
        // Members
        public System.IntPtr SetLightHook_dtor_0; // function pointer
        public System.IntPtr Execute; // function pointer
        public System.IntPtr GetType; // function pointer
        public System.IntPtr GetSubDataIDs; // function pointer
        public System.IntPtr pack_size; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public int _lights_on;

    // Methods
    // void __thiscall SetLightHook::Execute(SetLightHook*,CPhysicsObj*)
    public void Execute(ACBindings.CPhysicsObj* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SetLightHook, ACBindings.CPhysicsObj*, void>)0x00527BD0)(ref this, object_);
}

