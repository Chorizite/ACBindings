namespace ACBindings.Internal;


/// <summary>Represents an association between a unique identifier and its corresponding cell object within the system.</summary>
public unsafe struct CELLINFO
{
    // Members
    public uint cell_id;
    public ACBindings.Internal.CObjCell* cell;

    // Methods
}

