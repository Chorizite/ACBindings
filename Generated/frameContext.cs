namespace ACBindings.Internal;

public unsafe struct frameContext
{
    // Members
    public ACBindings.Internal.DrawParms viewer;
    public ACBindings.Internal.Position position;
    public ACBindings.Internal.Vector3 object_offset;
    public float object_scale;
    public ACBindings.Internal.Vector3 object_scale_vec;
    public fixed double pm[28];
    public int era;
    public ACBindings.Internal.Vec2Dscreen* xformNext;

    // Methods
}

