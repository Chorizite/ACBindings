namespace ACBindings;

// VectorHook
public unsafe struct VectorHook
{
    // Base Classes
    public ACBindings.PhysicsObjHook BaseClass_PhysicsObjHook; // ACBindings.PhysicsObjHook

    // Child Types
    // VectorHook_vtbl
    public unsafe struct VectorHook_vtbl
    {
        // Members
        public System.IntPtr Execute; // function pointer

        // Methods
    }

    // Members
    public ACBindings.AC1Legacy.Vector3 start_vector;
    public ACBindings.AC1Legacy.Vector3 end_vector;

    // Methods
}

