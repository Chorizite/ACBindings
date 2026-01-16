namespace ACBindings.Internal;


/// <summary>Represents a vertex in view geometry, encapsulating a 2‑dimensional position and its associated geometric plane for rendering calculations.</summary>
public unsafe struct view_vertex
{
    // Members
    public ACBindings.Internal.Vec2D pt;
    public ACBindings.Internal.Plane plane;

    // Generated Constructor
    public view_vertex() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>Initializes a view_vertex instance, registering it with DeleteLeafTransactInfo for proper cleanup handling.
    /// <code>Offset: 0x0054D630
    /// void __thiscall view_vertex::view_vertex(view_vertex*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.view_vertex, void>)0x0054D630)(ref this);
}

