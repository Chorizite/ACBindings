namespace ACBindings;

// CSphereTree
public unsafe struct CSphereTree
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // CSphereTree_vtbl
    public unsafe struct CSphereTree_vtbl
    {
        // Members
        public System.IntPtr CSphereTree_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.CSphere top_sphere;
    public ushort num_level1;
    public ACBindings.CSphereNode* level1_spherenodes;
    public ushort num_level2;
    public ACBindings.CSphere* level2_spheres;

    // Methods
}

