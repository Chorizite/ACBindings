namespace ACBindings.Internal;


/// <summary>Represents a range of landblock identifiers, tracking load status and pending operations within the game world.</summary>
/// <remarks>lowID and highID define inclusive bounds; srvID links to a server instance. Flags indicate deletion pending, frozen state, and whether to request non‑landblocks. Counters record how many blocks have been loaded, including those with unique objects, and track loading in unpopulated areas.</remarks>
public unsafe struct LBRange
{
    // Base Classes
    public ACBindings.Internal.PackableNIListElt___LBRange BaseClass_PackableNIListElt; // ACBindings.Internal.PackableNIListElt___LBRange

    // Members
    public uint lowID;
    public uint highID;
    public uint srvID;
    public int deletePending_;
    public int isFrozen_;
    public int toGetNoLandblocks_;
    public int numBlocksLoaded_;
    public int numBlocksLoadedWithUniques_;
    public int numUniquesInLoadedBlocks_;
    public int loadInUnpopulatedBlocks_;

    // Methods
}

