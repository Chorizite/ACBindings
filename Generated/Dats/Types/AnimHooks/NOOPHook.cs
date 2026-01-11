namespace ACBindings.Internal;

public unsafe struct NOOPHook
{
    // Base Classes
    public ACBindings.Internal.CAnimHook BaseClass_CAnimHook; // ACBindings.Internal.CAnimHook

    // Child Types
    public unsafe struct NOOPHook_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.NOOPHook*, void> NOOPHook_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.NOOPHook*, ACBindings.Internal.CPhysicsObj*, void> Execute; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.NOOPHook*, int> GetType; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.NOOPHook*, ACBindings.Internal.QualifiedDataIDArray*, void> GetSubDataIDs; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.NOOPHook*, uint> pack_size; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.NOOPHook*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.NOOPHook*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Methods
}

