namespace ACBindings;

// view_vertex
public unsafe struct view_vertex
{
    // Members
    public ACBindings.Vec2D pt;
    public ACBindings.Plane plane;

    // Generated Constructor
    public view_vertex() {
        _ConstructorInternal();
    }

    // Methods
    // void __thiscall view_vertex::view_vertex(view_vertex*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.view_vertex, void>)0x0054D630)(ref this);
}

