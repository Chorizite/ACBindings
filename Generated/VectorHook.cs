namespace ACBindings.Internal;

public unsafe struct VectorHook
{
    // Base Classes
    public ACBindings.Internal.PhysicsObjHook BaseClass_PhysicsObjHook; // ACBindings.Internal.PhysicsObjHook

    // Child Types
    public unsafe struct VectorHook_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VectorHook*, ACBindings.Internal.CPhysicsObj*, int> Execute; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.AC1Legacy.Vector3 start_vector;
    public ACBindings.Internal.AC1Legacy.Vector3 end_vector;

    // Methods
}

