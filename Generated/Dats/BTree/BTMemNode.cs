namespace ACBindings.Internal;


/// <summary>Represents a node in the behavior tree memory structure, storing timestamp, dirty status, pointers to adjacent nodes, offset data, and the core BTNode payload.</summary>
public unsafe struct BTMemNode
{
    // Members
    public int time_stamp_lm;
    public byte dirty_fm;
    public ACBindings.Internal.BTMemNode* ahead_pm;
    public ACBindings.Internal.BTMemNode* behind_pm;
    public int offset_m;
    public ACBindings.Internal.BTNode node_m;

    // Methods
}

