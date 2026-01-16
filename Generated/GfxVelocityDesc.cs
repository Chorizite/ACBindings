namespace ACBindings.Internal;


/// <summary>Defines velocity parameters for graphical elements, linking each instance through a unique identifier to its UV offset and total displacement values used in animation calculations.</summary>
public unsafe struct GfxVelocityDesc
{
    // Members
    public ACBindings.Internal.IDClass____tagDataID id;
    public ACBindings.Internal.CVec2Duv offset;
    public ACBindings.Internal.CVec2Duv total;

    // Methods
}

