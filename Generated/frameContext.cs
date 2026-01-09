namespace ACBindings;

// frameContext
public unsafe struct frameContext
{
    // Members
    public ACBindings.DrawParms viewer;
    public ACBindings.Position position;
    public ACBindings.Vector3 object_offset;
    public float object_scale;
    public ACBindings.Vector3 object_scale_vec;
    public fixed double pm[28];
    public int era;
    public ACBindings.Vec2Dscreen* xformNext;

    // Methods
}

