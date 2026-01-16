namespace ACBindings.Internal;


/// <summary>Represents a node in a spatial hierarchy, holding a bounding sphere and references to child spheres used for efficient traversal.</summary>
/// <field name="sphere">Bounding sphere defining the region covered by this node.</field>
/// <field name="num_kids">Number of child spheres referenced.</field>
/// <field name="kids">Array of pointers to CSphere objects representing child elements of the hierarchy.</field>
public unsafe struct CSphereNode
{
    // Members
    public ACBindings.Internal.CSphere sphere;
    public uint num_kids;
    public ACBindings.Internal.CSphere** kids;

    // Methods
}

