namespace ACBindings.Internal;


/// <summary>Associates a numeric road identifier with its corresponding palette type within land definitions, enabling terrain rendering to use the appropriate visual assets for each road segment.</summary>
public unsafe struct PalShiftRoadCode
{
    // Members
    public uint road_code;
    public ACBindings.Internal.LandDefs.PalType* sub_pal_type;

    // Methods
}

