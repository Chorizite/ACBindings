namespace ACBindings;

// LBMigrationDataBookkeep
public unsafe struct LBMigrationDataBookkeep
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // LBMigrationDataBookkeep_vtbl
    public unsafe struct LBMigrationDataBookkeep_vtbl
    {
        // Members
        public System.IntPtr LBMigrationDataBookkeep_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.LBRange region;
    public int numBlksWithObjects;
    public uint* lbIDs;
    public double* m_rgCheckpointTimes;
    public int numEvQueues;
    public ACBindings.LBEventQueue* lbEvqs;

    // Methods
}

