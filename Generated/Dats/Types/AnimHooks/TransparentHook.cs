namespace ACBindings;

// TransparentHook
public unsafe struct TransparentHook
{
    // Base Classes
    public ACBindings.CAnimHook BaseClass_CAnimHook; // ACBindings.CAnimHook

    // Child Types
    // TransparentHook_vtbl
    public unsafe struct TransparentHook_vtbl
    {
        // Members
        public System.IntPtr TransparentHook_dtor_0; // function pointer
        public System.IntPtr Execute; // function pointer
        public System.IntPtr GetType; // function pointer
        public System.IntPtr GetSubDataIDs; // function pointer
        public System.IntPtr pack_size; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public float start;
    public float end;
    public float time;

    // Methods
    // void __thiscall TransparentHook::Execute(TransparentHook*,CPhysicsObj*)
    public void Execute(ACBindings.CPhysicsObj* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.TransparentHook, ACBindings.CPhysicsObj*, void>)0x00527830)(ref this, object_);
    // int __thiscall TransparentHook::GetType(TransparentHook*)
    public int GetType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.TransparentHook, int>)0x00683760)(ref this);
}

