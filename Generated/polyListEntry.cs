namespace ACBindings.Internal;


/// <summary>Associates a CPolygon with a plane mask for efficient spatial queries and rendering.</summary>
/// <remarks>The planeMask encodes which planes intersect or contain the polygon, facilitating culling and collision detection.</remarks>
public unsafe struct polyListEntry
{
    // Members
    public ACBindings.Internal.CPolygon* poly;
    public int planeMask;

    // Methods
}

