namespace ACBindings;

// BTMemNode
public unsafe struct BTMemNode
{
    // Members
    public int time_stamp_lm;
    public byte dirty_fm;
    public ACBindings.BTMemNode* ahead_pm;
    public ACBindings.BTMemNode* behind_pm;
    public int offset_m;
    public ACBindings.BTNode node_m;

    // Methods
}

