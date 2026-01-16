namespace ACBindings.Internal;


/// <summary>Holds identification, type classification, and reference count information for global voyeur objects within the application.</summary>
public unsafe struct GlobalVoyeurInfo
{
    // Members
    public uint object_iid;
    public uint type;
    public int ref_count;

    // Methods
}

