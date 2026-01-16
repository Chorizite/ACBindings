namespace ACBindings.Internal;


/// <summary>Represents configuration and state for portal rendering, holding a list of portals, view parameters, and counters for update frequency.</summary>
public unsafe struct portal_view_type
{
    // Members
    public ACBindings.Internal.DArray___portal_info portal;
    public ACBindings.Internal.view_type view;
    public float max_indist;
    public uint view_count;
    public int cell_view_done;
    public int view_timestamp;
    public int update_count;

    // Methods
}

