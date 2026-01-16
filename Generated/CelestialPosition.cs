namespace ACBindings.Internal;


/// <summary>Defines data for a celestial object’s appearance and positioning in the scene, including graphics identifiers, orientation angles, texture motion, transparency, luminosity, maximum brightness, and property flags used by the rendering system.</summary>
public unsafe struct CelestialPosition
{
    // Members
    public ACBindings.Internal.IDClass____tagDataID gfx_id;
    public ACBindings.Internal.IDClass____tagDataID pes_id;
    public float heading;
    public float rotation;
    public ACBindings.Internal.AC1Legacy.Vector3 tex_velocity;
    public float transparent;
    public float luminosity;
    public float max_bright;
    public uint properties;

    // Methods
}

