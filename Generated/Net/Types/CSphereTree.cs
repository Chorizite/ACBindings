namespace ACBindings.Internal;


/// <summary>Organizes a hierarchy of spheres into two levels for efficient spatial queries, including a root sphere and linked arrays of level‑1 nodes and level‑2 sphere references.</summary>
/// <remarks>Serves as the data structure underlying collision detection or visibility culling in the application’s 3D engine.</remarks>
public unsafe struct CSphereTree
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct CSphereTree_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CSphereTree*, void> CSphereTree_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CSphereTree*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CSphereTree*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CSphereTree*, void**, uint, int> UnPack; // function pointer

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

