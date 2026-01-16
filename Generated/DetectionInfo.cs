namespace ACBindings.Internal;


/// <summary>Provides identification and current status of a detected object within the system.</summary>
public unsafe struct DetectionInfo
{
    // Members
    public uint object_id;
    public ACBindings.Internal.DetectionType object_status;

    // Methods
}

