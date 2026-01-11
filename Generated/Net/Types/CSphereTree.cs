namespace ACBindings.Internal;

public unsafe struct CSphereTree
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct CSphereTree_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CSphereTree*, void> CSphereTree_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CSphereTree*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CSphereTree*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CSphereTree*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.CSphere top_sphere;
    public ushort num_level1;
    public ACBindings.Internal.CSphereNode* level1_spherenodes;
    public ushort num_level2;
    public ACBindings.Internal.CSphere* level2_spheres;

    // Methods
}

