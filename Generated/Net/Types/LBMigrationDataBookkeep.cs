namespace ACBindings.Internal;


/// <summary>Tracks migration state for a simulation region, including block identifiers, checkpoint timestamps, and event queues used during load‑balancing operations.</summary>
public unsafe struct LBMigrationDataBookkeep
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct LBMigrationDataBookkeep_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.LBMigrationDataBookkeep*, void> LBMigrationDataBookkeep_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.LBMigrationDataBookkeep*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.LBMigrationDataBookkeep*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.LBMigrationDataBookkeep*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.LBRange region;
    public int numBlksWithObjects;
    public uint* lbIDs;
    public double* m_rgCheckpointTimes;
    public int numEvQueues;
    public ACBindings.Internal.LBEventQueue* lbEvqs;

    // Methods
}

