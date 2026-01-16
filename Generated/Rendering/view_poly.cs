namespace ACBindings.Internal;


/// <summary>Holds polygon data required for rendering or collision detection, including vertex count, the current processing index, and axis‑aligned bounding box limits.</summary>
public unsafe struct view_poly
{
    // Members
    public int vertex_count;
    public int vertex_index;
    public float xmin;
    public float xmax;
    public float ymin;
    public float ymax;

    // Methods
}

