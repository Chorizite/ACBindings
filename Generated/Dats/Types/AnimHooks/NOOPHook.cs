namespace ACBindings.Internal;


/// <summary>Wraps a CAnimHook instance used as a no-operation hook within the animation system, providing a consistent interface for hook handling.</summary>
/// <remarks>NOOPHook is instantiated when an action requires no effect but a hook object must be present to maintain list integrity and interface consistency across the pipeline.</remarks>
public unsafe struct NOOPHook
{
    // Base Classes
    public ACBindings.Internal.CAnimHook BaseClass_CAnimHook; // ACBindings.Internal.CAnimHook

    // Child Types
    public unsafe struct NOOPHook_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.NOOPHook*, void> NOOPHook_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.NOOPHook*, ACBindings.Internal.CPhysicsObj*, void> Execute; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.NOOPHook*, int> GetType; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.NOOPHook*, ACBindings.Internal.QualifiedDataIDArray*, void> GetSubDataIDs; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.NOOPHook*, uint> pack_size; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.NOOPHook*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.NOOPHook*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Methods
}

