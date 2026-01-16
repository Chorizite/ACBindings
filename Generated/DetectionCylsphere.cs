namespace ACBindings.Internal;


/// <summary>
/// Defines a cylindrical detection zone identified by context ID, storing its radius, detection status, type, and associated object information.
/// </summary>
public unsafe struct DetectionCylsphere
{
    // Members
    public uint context_id;
    public float radius;
    public int object_detected;
    public ACBindings.Internal.DetectionInfo info;
    public uint detection_type;

    // Methods
}

