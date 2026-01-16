namespace ACBindings.Internal;


/// <summary>Specifies drawing configuration by combining a 3‑dimensional viewpoint vector with a reference plane used during rendering calculations.</summary>
public unsafe struct DrawParms
{
    // Members
    public ACBindings.Internal.AC1Legacy.Vector3 viewpoint;
    public ACBindings.Internal.Plane CY;

    // Methods
}

