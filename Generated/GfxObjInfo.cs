namespace ACBindings.Internal;


/// <summary>Provides information for a graphical object, including its unique identifier, degradation mode, and spatial distance thresholds used to determine rendering level of detail.</summary>
public unsafe struct GfxObjInfo
{
    // Members
    public ACBindings.Internal.IDClass____tagDataID gfxobj_id;
    public int degrade_mode;
    public float min_dist;
    public float ideal_dist;
    public float max_dist;

    // Methods
}

