namespace ACBindings.Internal;


/// <summary>Encapsulates per‑frame rendering state, holding viewer parameters, object positioning and scaling information, as well as transformation matrices needed by the graphics pipeline.</summary>
/// <remarks>Used during frame construction to convert object space coordinates into screen space and apply appropriate scale factors.</remarks>
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

